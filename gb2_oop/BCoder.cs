using System.ComponentModel.Design;

namespace gb2_oop;

public class BCoder : ICoder
{
    public string _str;
    
    private static readonly char[] alphabetLower = new char[32];
    private static readonly char[] alphabetUpper = new char[32];

    public BCoder()
    {
        // заполнение массива алфавита строчными буквами
        for (int i = (int) 'а', k = 0; i <= (int) 'я'; i++, k++)
            alphabetLower[k] = (char) i;
        
        // заполнение массива алфавита заглавными буквами
        for (int i = (int) 'А', k = 0; i <= (int) 'Я'; i++, k++)
            alphabetUpper[k] = (char) i;
    }

    private void Code()
    {
        char[] result = new char[_str.Length];
        
        for (int i = 0; i < _str.Length; i++)
        {
            int сharIndexInAlphabet = Array.IndexOf(alphabetLower, _str[i]);

            if (сharIndexInAlphabet == -1)
            {
                сharIndexInAlphabet = Array.IndexOf(alphabetUpper, _str[i]);
                result[i] = alphabetUpper[alphabetUpper.Length - сharIndexInAlphabet - 1];
            }
            else
            {
                result[i] = alphabetLower[alphabetLower.Length - сharIndexInAlphabet - 1];
            }
        }
        
        _str = new string(result);
    }
    
    public void Encode()
    {
        Code();
    }
    
    public void Decode()
    {
        Code();
    }
}