using System;
using System.Collections.Generic;
using System.Text;

namespace Cyphers
{
    class VernamCipher : ICipherDecipher
    {
        public string Cipher(params object[] arguments)
        {
            if (arguments.Length == 2)
            {
                string text = arguments[0] as string;
                string keyword = arguments[1] as string;

                return CipherDecipher(text, keyword, true);
            }
            return string.Empty;
        }

        public string Decipher(params object[] arguments)
        {
            if (arguments.Length == 2)
            {
                string text = arguments[0] as string;
                string keyword = arguments[1] as string;

                return CipherDecipher(text, keyword, false);
            }
            return string.Empty;
        }
        public string CipherDecipher(string Text, string Key, bool Crypt)
        {
            string alph1 = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ !";

            Dictionary<char, int> alph = new Dictionary<char, int>();
            Dictionary<int, char> alph_r = new Dictionary<int, char>();

            OnTimePad(alph1);

            void OnTimePad(IEnumerable<char> Alphabet)
            {
                int i = 0;
                foreach (char c in Alphabet)
                {
                    alph.Add(c, i);
                    alph_r.Add(i++, c);
                }
            }

            char[] key = Key.ToCharArray();
            char[] text = Text.ToCharArray();
            var sb = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                int idx;
                if (alph.TryGetValue(text[i], out idx))
                {
                    int r = alph.Count + idx;
                    r += (Crypt ? 1 : -1) * alph[key[i % key.Length]];
                    sb.Append(alph_r[r % alph.Count]);
                }
            }

            return sb.ToString();
        }

    }
}
