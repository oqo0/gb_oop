using System;

namespace gb2_oop
{
    class Oop
    {
        static void Main()
        {
            string[] text = File.ReadAllLines("name_and_email.txt");

            for (int i = 0; i < text.Length; i++)
            {
                SearchMail(ref text[i]);
            }
            
            File.WriteAllLines("email.txt", text);
        }

        public static void SearchMail(ref string s)
        {
            s = s.Split('&')[1];
        }
    }
}