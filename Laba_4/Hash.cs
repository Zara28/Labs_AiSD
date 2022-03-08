using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_4
{
    public class Hash
    {
        public string[] Mas;
        int ras;
        public Hash(int size)
        {
            Mas = new string[size];
            ras = size;
            for(int i = 0; i<size; i++)
            {
                Mas[i] = "";
            }
        }
        public void Print()
        {
            for (int i = 0; i < ras; i++)
            {
                if (Mas[i] == "")
                {
                    Console.Write(" . ");
                }
                else Console.Write(Mas[i] + " ");
            }
        }
        public int Key(int v)
        {
            int k = v+1;
            return k<ras ? k : Math.Abs(k-ras);
        }
        public int Key2(int v)
        {
            int k = v+3;
            return k<ras? k : Math.Abs(ras - k + 1);
        }
        public void Add(int key, string vulue)
        {
            if(Mas[key]!="")
            { 
                int k = 1;
                while(Mas[key]!="")
                {
                    key = Key(key) + k * Key2(key);
                    k++;
                }
            }
            Mas[key] = vulue;

        }
        public int Search(int key, string val)
        {
            if (Mas[key]==val)
            {
                return key;
            }
            else
            {
                int k = 1;
                while (key < ras && k < ras && Mas[key]!=val)
                {
                    key = Key(key) + k * Key2(key);
                    k++;
                }
                if (key >= ras || Mas[key] != val) return -1;
                else return key;
            }
            
        }

        public void Delete(int key)
        {
            Mas[key] = "";
        }
    }
}
