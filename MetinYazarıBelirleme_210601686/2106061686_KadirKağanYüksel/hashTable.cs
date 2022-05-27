using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2106061686_KadirKağanYüksel
{
    public class hashTable
    {
        int size = 10;
        hashNode[] table;
        public hashTable()
        {
            table = new hashNode[size];
            for (int i = 0; i < size; i++)
            {
                table[i] = null;
            }
        }
        public stackKelimeler Kelime(int key)
        {
            int h = (key % size);
            while (table[h] != null && table[h].Key != key)
            {
                h = (h + 1) % size;
            }
            if (table[h] == null)
                return null;
            else
                return (stackKelimeler)table[h].data;
        }
        public void addKelime(int key, object data)
        {
            int hash = (key % size);
            while (table[hash] != null && table[hash].Key != key)
                hash = (hash + 1) % size;
            table[hash] = new hashNode(key, data);
        }
    }
}
