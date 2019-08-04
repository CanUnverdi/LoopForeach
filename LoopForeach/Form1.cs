using System;
using System.Collections.Generic;
using System.Text;

namespace LoopForeach
{
 
    {
        public Form1()
        {
            InitializeComponent();
        }
     

        string[] sehirler = { "Ankara", "Istanbul", "İzmir", "Eskişehir", "Tekirdağ", "Antalya", "Konya", "Trabzon", "Bursa" };//string tipindeki sehrler diizm global alanda tanımlandığı için bu form.cs'sin heryerinde erişilebilir.

        private void btnOrnek1_Click(object sender, EventArgs e)
        {
            foreach (string item in sehirler)
            {
                listBox1.Items.Add(item);
            }
        }

        private void btnOrnek2_Click(object sender, EventArgs e)
        {
          
            int[] dizi = { 123, 45, 234, 67, 657, 4323, 654, 767, 988 };

            int tamBolunenSayiMiktari = 0;

            foreach (int item in dizi)
            {
                if (item % 2 == 0)
                {
                    listBox1.Items.Add(item);
                }
                else
                {
                    listBox2.Items.Add(item);
                }

                if (item % 2 == 0 && item % 3 == 0)
                {
                    tamBolunenSayiMiktari++;
                }
            }
    
            MessageBox.Show($"Bu dizide hem ikiye hemde üçe bölünen toplam {tamBolunenSayiMiktari} sayı vardır");//String formmating dolar işareti ile işaretlenir, string metin içerisne değişkende tutulan veriyi yerleştirmemize yarar. BU yapıyı tersih etmezsek yukarıdaki gibi "+" paramatersei ile metin ile değişkeni bağlamak gerekir
        }

        private void btnOrnek3_Click(object sender, EventArgs e)
        {
     
            listBox2.Items.Clear();

            foreach (string item in listBox1.SelectedItems)
            {
                listBox2.Items.Add(item);
            }
        }

        private void btnOrnek4_Click(object sender, EventArgs e)
        {
      

            foreach (Control item in Controls)
            {
                if (item is Button)
                {
                    item.BackColor = Color.AliceBlue;
                    item.ForeColor = Color.Green;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
    }
}
