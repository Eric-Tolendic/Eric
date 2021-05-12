using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyphers
{
    class VigenereCipher : ICipherDecipher
    {
        char[][] tabulaRecta;
        public VigenereCipher()
        {
            //string clearText = text;

            List<char> alphabet =
                Enumerable.Range('A', 'z' - 'A' + 1)
                .Select(x => (char)x).ToList();

            tabulaRecta = new char['z' - 'A' + 1][];
            for (int i = 0; i < tabulaRecta.Length; i++)
            {
                tabulaRecta[i] = alphabet.ToArray();
                var first = alphabet.First();
                alphabet.Remove(first);
                alphabet.Insert(alphabet.Count, first);
            }

            //string cipherText = Cipher(clearText, tabulaRecta, keyword);
            //Console.WriteLine("Ciphered Text: {0}", cipherText);

            //string decipherText = Decipher(cipherText, tabulaRecta, keyword);
            //Console.WriteLine("Deciphered Text: {0}", decipherText);

            //Console.ReadKey();
        }
        public string Cipher(params object[] arguments)
        {
            if (arguments.Length == 2)
            {
                string text = arguments[0] as string;
                string keyword = arguments[1] as string;

                return Cipher(text,tabulaRecta,keyword);
            }
            return string.Empty;
        }

        public string Decipher(params object[] arguments)
        {
            if (arguments.Length == 2)
            {
                string text = arguments[0] as string;
                string keyword = arguments[1] as string;

                return Decipher(text, tabulaRecta, keyword);
            }
            return string.Empty;
        }



        private static string GrowToTextSize(int length, string keyword)
        {
            string result = keyword;

            int idx = 0;
            while (result.Length < length)
            {
                result += keyword[idx++];

                if (idx >= length)
                {
                    idx = 0;
                }
            }

            return result;
        }

        private static char[][] TransposeMatrix(char[][] matrix)
        {
            char[][] result = new char[matrix[0].Length][];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = new char[matrix.Length];
            }

            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    result[col][row] = matrix[row][col];
                }
            }
            return result;
        }

        private static int IndexOf(char[] array, char toFind)
        {
            int result = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == toFind)
                {
                    result = i;
                    break;
                }
            }

            return result;
        }

        private static string Cipher(
            string clearText, char[][] tabulaRecta, string keyword)
        {
            string result = string.Empty;

            keyword = GrowToTextSize(clearText.Length, keyword);

            for (int i = 0; i < clearText.Length; i++)
            {
                int row = clearText[i] - 'A';
                int col = keyword[i] - 'A';

                result += tabulaRecta[row][col];
            }

            return result;
        }

        private static string Decipher(
            string cipherText, char[][] tabulaRecta, string keyword)
        {
            string result = string.Empty;

            keyword = GrowToTextSize(cipherText.Length, keyword);
            tabulaRecta = TransposeMatrix(tabulaRecta);

            for (int i = 0; i < cipherText.Length; i++)
            {
                int row = keyword[i] - 'A';
                int col = IndexOf(tabulaRecta[row], cipherText[i]);

                result += tabulaRecta[0][col];
            }

            return result;
        }
    }
}
