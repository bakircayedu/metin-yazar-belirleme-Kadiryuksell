using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace _2106061686_KadirKağanYüksel
{
    public partial class frmOdev : Form
    {
        public frmOdev()
        {
            InitializeComponent();
        }
        // Global değişken tanımlandı
        string satir = "";


        /* Fonksiyon dosyayı parçalara ayırıp stacke gonderiyor.
         Kelime analizi yapıp listbox'a yazdırıyor.*/
        public void stackeGonder()
        {
            // Dosyayı adresinden alıyoruz ve analiz işlemleri gerçekleşiyor.
            stackLinkedList dosyaStack = new stackLinkedList();
            StreamReader sr = new StreamReader("C:\\Users\\Kadır\\Desktop\\odev\\deneme.txt");

            double cumleSayisi = 0, toplamkelimeler = 0, ortalamKelimesayisi = 0;
            while (true)
            {
                satir = sr.ReadLine();
                if (satir == null)
                {
                    break;
                }

                dosyaStack.push(satir);
                cumleSayisi++;
                string[] kelimeler = satir.Split(' ');

                toplamkelimeler += kelimeler.Length;
                lstAnaliz.Items.Add("\nCümle Sayısı:" + cumleSayisi.ToString() + "  Kelime sayisi: " + kelimeler.Length);
            }
            ortalamKelimesayisi = toplamkelimeler / cumleSayisi;
            lstAnaliz.Items.Add("Ortalama kelime sayısı: " + ortalamKelimesayisi.ToString());

        }


        //Fonksiyon verdiğimiz dosya yolundan dosyayı okumaya yarıyor.
        private void btnDosyaAl_Click(object sender, EventArgs e)
        {

            OpenFileDialog dosya = new OpenFileDialog();

            if (dosya.ShowDialog() == DialogResult.OK)
            {
                FileInfo fi = new FileInfo(dosya.FileName);
                if (fi.Exists)
                {
                    MessageBox.Show("Dosyanız yüklenmiştir.");
                }
                else
                {
                    // dosya yolunu verdiğimiz için buraya girmesini beklememeliyiz.
                    throw new ArgumentException("Dosya yüklenemedi.");
                }
                string guzergah = dosya.FileName.ToString();

            }
        }


        // Stacke'e gonder fonksiyonunu çağrıyor ve oradaki işlemleri yapıyor.
        private void btnStackeGonder_Click(object sender, EventArgs e)
        {
            stackeGonder();
            MessageBox.Show("Başarıyla yığına gönderilmiştir.");
        }


        // Fonksiyonumuz kelimenin kaçıncı index,cümlede kaçıncı sırada, hangi cümlede ve kaç defa kullanıldığını döndürüyor.
        public void kelimeArama(string deger)
        {
            stackLinkedList dosyaStack = new stackLinkedList();
            StreamReader sr = new StreamReader("C:\\Users\\Kadır\\Desktop\\odev\\deneme.txt");            
            stackKelimeler stackKelimeler = new stackKelimeler();
            
            string arananKelime = deger;
            int cumleSayisi = 0, tumMetindeKelimeSayısı = 0;
            while (true)
            {

                
                satir = sr.ReadLine();
                if (satir == null)
                {
                    break;
                }

                dosyaStack.push(satir);
                cumleSayisi++;
                string[] kelimeler = satir.Split(' ');
                int index = 0, i = 0, say = 0;
                for (i = 0; i < kelimeler.Length; i++)
                {
                    if (arananKelime == kelimeler[i])
                    {
                        say++;                     
                        index = i;
                        i++;

                         MessageBox.Show(cumleSayisi.ToString() + "-Cümle :  " + dosyaStack.peek().ToString() + "\nAranan Kelime :  "
                       + arananKelime + "\nCümlede kaçıncı index :  " + index.ToString() +
                       "\nCümlede kaçıncı sırada :  " + i.ToString() + "\nCümlede kullanım sayısı :  " + say.ToString());                    
                        continue;
                    }
                                          
                }
                
                tumMetindeKelimeSayısı += say;     
            }
            stackKelimeler.push(arananKelime, tumMetindeKelimeSayısı);                             
        }


        // Fonksiyon sırayla tüm kelimeleri metin içinde arar ve kaç tane olduğunu hesplayıp kelimeyle beraber ağacın içine gönderirir.
        public void KelimeleriAgacaAktar()
        {
            stackLinkedList dosyaStack = new stackLinkedList();
            StreamReader sr = new StreamReader("C:\\Users\\Kadır\\Desktop\\odev\\deneme.txt");
            binaryHeapTree heapTree = new binaryHeapTree(100);
            stackKelimeler stackKelimeler = new stackKelimeler();
            int cumleSayisi = 0, toplamKelime = 0, index = 0;
            string[] metin = new string[1000];
            string kelimeAramasi = "";
            while (true)
            {                
                satir = sr.ReadLine();
                if (satir == null)
                {
                    for (int i = 0; i <toplamKelime; i++)
                    {
                        int metindeArananSayisi = 0, say = 0;
                        kelimeAramasi = metin[i];
                        for (int j = 0; j < toplamKelime; j++)
                        {
                            if ( kelimeAramasi== metin[j])
                            {
                                say++;
                            }                                          
                        }
                        metindeArananSayisi += say;
                        heapTree.InsertElementInHeap(kelimeAramasi, metindeArananSayisi);
                        //MessageBox.Show("geldi :  " + heapTree.levelOrder());
                    }
                    break;
                }
                dosyaStack.push(satir);
                cumleSayisi++;
                string[] kelimeler = satir.Split(' ');
                toplamKelime += kelimeler.Length;
               
                foreach (var kelime in kelimeler)
                {
                    if (kelime == "")
                        break;
                    metin[index] += kelime;
                    index++;  
                }         
            }
        }
        
        // butona tıklandığında kelimeArama fonksiyonuna txtKelime parametresini gönderiyoruz.
        private void btnKelimeAra_Click(object sender, EventArgs e)
        {
            kelimeArama(txtKelime.Text);    
        }

        private void btnAnalizAgacaAktar_Click(object sender, EventArgs e)
        {
            KelimeleriAgacaAktar();
        }

        private void btnTopKelime_Click(object sender, EventArgs e)
        {
            heapSort heapSort = new heapSort();
        }

        private void btnHashTablo_Click(object sender, EventArgs e)
        {
            hashTable table = new hashTable();
            table.AddKelime();
        }
    }   
}

