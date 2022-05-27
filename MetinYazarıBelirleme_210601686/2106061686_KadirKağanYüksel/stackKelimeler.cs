using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2106061686_KadirKağanYüksel
{
    public class stackKelimeler
    {
        // sınıfın içine düğümleri tanımladım çünkü kaılıtım yaptığımda bozuluyordu.
        private class Node
        {
            public string veri;
            public Node link;          
            public int kelimeMetinKullanimsayisi;

        }
        Node top;


        // kurucu metot top değerini "null" değere atar.
        public stackKelimeler()
        {
            this.top = null;
        }


        // Push fonksiyonu kelime ve kullanimsıklığını alır, yığına gönderir.
        public void push(string kelime,  int kullanimSikligi)
        {
            Node degisken = new Node();

            if (degisken == null)
            {
                
            }
            degisken.veri = kelime;      
            degisken.kelimeMetinKullanimsayisi = kullanimSikligi;
            degisken.link = top;
            top = degisken;
        }

        public bool isEmpty()
        {
            return top == null;
        }


        //Fonksiyon yığıtın en üstündeki öğeyi değer olarak alır. 
        public string peek()
        {
            
            if (!isEmpty())
            {
                string sonuc = "Kelime :  " + top.veri + "\ntüm metinde kullanılma sayısı: "
                    + top.kelimeMetinKullanimsayisi.ToString();
                return sonuc;
            }
            else
            {
                
                return "-1";
            }
        }

        //Fonksiyon yığıtın en üstündeki öğeyi değer olarak alır ve onu yığıttan siler.
        public void pop()
        {
            if (top == null)
            {
                return;
            }
            top = (top).link;
        }

        public void display()
        {
            if (top == null)
            {
                
                return;
            }
            else
            {
                // Traverse işlemidir.
                Node temp = top;
                while (temp != null)
                {
                    
                    temp = temp.link;
                }
            }

        }
    }


}
