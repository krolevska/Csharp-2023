using System;

namespace ArraysAndIndexers1
{
    class Dictionary
    {
        private string[] ua = new string[5];
        private string[] en = new string[5];
        private string[] ge = new string[5];
        public Dictionary()
        {
            ua[0] = "книга"; en[0] = "book"; ge[0] = "Buch";
            ua[1] = "ручка"; en[1] = "pen"; ge[1] = "Kugelschreiber";
            ua[2] = "сонце"; en[2] = "sun"; ge[2] = "Sonne";
            ua[3] = "яблуко"; en[3] = "apple"; ge[3] = "Apfel";
            ua[4] = "небо"; en[4] = "sky"; ge[4] = "Himmel";
        }

        public string this[string word, string langTwo]
        {
            get
            {
                for (int i = 0; i < ua.Length; i++)
                {
                    if (ua[i] == word && langTwo == "en")
                        return ua[i] + " - " + en[i];
                    if (ua[i] == word && langTwo == "ge")
                        return ua[i] + " - " + ge[i];
                    if (en[i] == word && langTwo == "ua")
                        return en[i] + " - " + ua[i];
                    if (en[i] == word && langTwo == "ge")
                        return en[i] + " - " + ge[i];
                    if (ge[i] == word && langTwo == "en")
                        return ge[i] + " - " + en[i];
                    if (ge[i] == word && langTwo == "ua")
                        return ge[i] + " - " + ua[i];
                }
                return string.Format("{0} - cannot translate.", word);
            }
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < ua.Length)
                    return ua[index] + " - " + en[index] + " - " + ge[index];
                else
                    return "Attempt to adress outside of array.";
            }
        }
    }
}
