using System;

namespace Open_Lab_04._02
{
    public class Doubler
    {
        public string DoubleChar(string original)
        {
            string a = "";
            for (int i = 0; i < original.Length; i++)
            {
                a = a + original[i] + original[i];
            }
            return a;
        }
    }
}
