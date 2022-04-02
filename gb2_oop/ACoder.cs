namespace gb2_oop;

public class ACoder : ICoder
{
    public string _str;
    
    private void ChangeCharOffset(int offset)
    {
        char[] encodedStr = new char[_str.Length];

        for (int i = 0; i < _str.Length; i++)
        {
            int currentCharIndex = (int) _str[i];
            encodedStr[i] = (char)(currentCharIndex + offset);
        }
        
        _str = new string(encodedStr);
    }
    
    public void Encode()
    {
        ChangeCharOffset(1);
    }

    public void Decode()
    {
        ChangeCharOffset(-1);
    }
}