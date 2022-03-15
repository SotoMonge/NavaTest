using System;
using System.Collections.Generic;
using System.Text;

namespace AlphabetCodingTest
{
    public class Alphabet
    {
        private readonly Dictionary<string, string> _Diccionario = new Dictionary<string, string>();

        public Alphabet()
        {
            _Diccionario.Add("1", "A");
            _Diccionario.Add("2", "B");
            _Diccionario.Add("3", "C");
            _Diccionario.Add("4", "D");
            _Diccionario.Add("5", "E");
            _Diccionario.Add("6", "F");
            _Diccionario.Add("7", "G");
            _Diccionario.Add("8", "H");
            _Diccionario.Add("9", "I");
            _Diccionario.Add("10", "J");
            _Diccionario.Add("11", "K");
            _Diccionario.Add("12", "L");
            _Diccionario.Add("13", "M");
            _Diccionario.Add("14", "N");
            _Diccionario.Add("15", "O");
            _Diccionario.Add("16", "P");
            _Diccionario.Add("17", "Q");
            _Diccionario.Add("18", "R");
            _Diccionario.Add("19", "S");
            _Diccionario.Add("20", "T");
            _Diccionario.Add("21", "U");
            _Diccionario.Add("22", "V");
            _Diccionario.Add("23", "W");
            _Diccionario.Add("24", "X");
            _Diccionario.Add("25", "Y");
            _Diccionario.Add("26", "Z");
        }

        static void Main(string[] args)
        {
            Alphabet alphabet = new Alphabet();
            alphabet.AlphabetOrder();
        }

        public void AlphabetOrder()
        {
            try
            {
                Console.WriteLine("Type a number");
                string val = Console.ReadLine();
                StringBuilder sb = new StringBuilder();

                int p1 = 0;
                int p2 = val.Length - 1;

                List<string> lista = new List<string>();
                for (int i = 0; i < val.Length; i++)
                {
                    sb.Append(_Diccionario[val[i].ToString()]);
                }
                lista.Add(sb.ToString());
                sb.Clear();

                string sInsert1 = int.Parse(val[p2 - 1].ToString() + val[p2].ToString()) < _Diccionario.Count ?
                    val[p2 - 1].ToString() + val[p2].ToString() : val[p2].ToString();
                p2 = int.Parse(val[p2 - 1].ToString() + val[p2].ToString()) < _Diccionario.Count ? p2 - 1 : p2;

                while (p1 < p2)
                {
                    string sInsert = int.Parse(val[p1].ToString() + val[p1 + 1].ToString()) < _Diccionario.Count ?
                    val[p1].ToString() + val[p1 + 1].ToString() : val[p1].ToString();
                    for (int i = 0; i < val.Length; i++)
                    {
                        if (i == p1)
                        {
                            sb.Append(_Diccionario[sInsert]);
                            i = int.Parse(val[p1].ToString() + val[p1 + 1].ToString()) < _Diccionario.Count ? i + 1 : i;
                            continue;
                        }
                        if (i == p2)
                        {
                            sb.Append(_Diccionario[sInsert1]);
                            i = int.Parse(val[p2 - 1].ToString() + val[p2].ToString()) < _Diccionario.Count ? i + 1 : i;
                            continue;
                        }
                        sb.Append(_Diccionario[val[i].ToString()]);
                    }
                    if (!lista.Contains(sb.ToString()))
                    {
                        lista.Add(sb.ToString());
                    }

                    sb.Clear();
                    p1++;
                }
                PrintList(lista);
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurs: " + e.Message);
            }
        }

        static void PrintList(List<string> lista)
        {
            foreach (string s in lista)
            {
                Console.WriteLine(s);
            }
        }
    }
}
