using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2106061686_KadirKağanYüksel
{
    public class stackLinkedList 
    {
        /* https://www.geeksforgeeks.org/implement-a-stack-using-singly-linked-list/ referans aldım.
        Düğümü kalıtım ile sağladığımda hep bozulmalar yaşandı ben stack içine private olarak oluşturdum.
          */

        // düğümü oluşturup veriyi string yaptım çünkü cümle alacağızz.
        private class Node
        {
            public string veri;
            public Node next;
        }
        Node top;


        // Kurucu metot top değerini "null" değere eşitliyor.
        public stackLinkedList()
        {
            this.top = null;
        }


        // Stack içine gönderme fonksiyonudur.
        public void push(string metin)
        {
            Node temp = new Node();

            if (temp == null)
            {
                return;
            }
            temp.veri = metin;
            temp.next = top;
            top = temp;
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
                return top.veri;
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
            top = (top).next;
        }

        public void display()
        {
            if (top == null)
            {
                  return;
            }
            else
            {
                // Travers işlemi uygulanıyor.
                Node temp = top;
                while (temp != null)
                {
                    temp = temp.next;
                }
            }
        }


    }
}
