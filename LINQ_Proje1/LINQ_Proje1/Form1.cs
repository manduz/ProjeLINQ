using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ_Proje1
{
    public partial class Form1 : Form
    {
        int[] sayilar = { -9, -6, -5, 3, 8, 12, 25 };
        List<string> isimler = new List<string>();

        public Form1()
        {
            isimler.Add("Emek");
            isimler.Add("Veli");
            isimler.Add("Ayşe");
            isimler.Add("Buse");
            isimler.Add("Ali");
            isimler.Add("Lale");
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Sayilar_All_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = sayilar.ToList();
        }

        private void Negative_Click(object sender, EventArgs e)
        {
            //-> lambda
            //foreach ile dolaşabilidğimiz bir ifadedir, bir interfacedir.

            IEnumerable<int> n = sayilar.Where(x=> x < 0);//x yerine başka bir şey yazsan da olur, foreach görevi görür
            listBox1.DataSource = null;
            listBox1.DataSource = n.ToList();
        }

        private void Positive_Click(object sender, EventArgs e)
        {
            IEnumerable<int> n = sayilar.Where(x => x > 0);//x yerine başka bir şey yazsan da olur, foreach görevi görür
            listBox1.DataSource = null;
            listBox1.DataSource = n.ToList();
        }

        private void Cift_Click(object sender, EventArgs e)
        {
            IEnumerable<int> n = sayilar.Where(x => x %2 == 0);//x yerine başka bir şey yazsan da olur, foreach görevi görür
            listBox1.DataSource = null;
            listBox1.DataSource = n.ToList();
        }

        private void Tek_Click(object sender, EventArgs e)
        {
            IEnumerable<int> n = sayilar.Where(x => x % 2 == 1 || x %2 == -1);//x yerine başka bir şey yazsan da olur, foreach görevi görür
            listBox1.DataSource = null;
            listBox1.DataSource = n.ToList();
        }

        private void max_number_Click(object sender, EventArgs e)
        {
            int enBuyukSayi = sayilar.Max();
            MessageBox.Show(enBuyukSayi.ToString());
        }

        private void Min_Number_Click(object sender, EventArgs e)
        {
            int enKucukSayi = sayilar.Min();
            MessageBox.Show(enKucukSayi.ToString());
        }

        private void kac_tane_Click(object sender, EventArgs e)
        {
            int kacTaneSayiVar = sayilar.Length;
            int kacTaneSayiVar2 = sayilar.Count();
            //  MessageBox.Show(kacTaneSayiVar.ToString());
            MessageBox.Show(kacTaneSayiVar2.ToString());
        }

        private void Alfabetik_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = isimler.OrderBy(x => x).ToList();
        }

        private void Tersten_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = isimler.OrderByDescending(x => x).ToList();

        }

        private void Uzunluk_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = isimler.Select(x=>x.Length).ToList();
        }

        private void e_harfi_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = isimler.Where(x=>x.Contains('e') || x.Contains('U')).ToList();
        }

        private void a_harfi_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = isimler.Where(x=>x.StartsWith("A") || x.StartsWith("a")).ToList();
        }

        private void tumSiparisGetir_Click(object sender, EventArgs e)
        {
            List<Order> orders = new Order().GetOrder();
            var gorunen = orders.Select(siparis => new 
            { 
                siparisNo = siparis.OrderID,
                tarih = siparis.OrderDate,
                musteri =siparis.customer.ContactName
            });
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = gorunen.ToList();

        }

        private void Date_Click(object sender, EventArgs e)
        {
            List<Order> orders = new Order().GetOrder();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = orders.Select(x => x.OrderDate).ToList();
        }

        private void Top5_Click(object sender, EventArgs e)
        {
            List<Order> orders = new Order().GetOrder();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = orders.Take(5).ToList();
        }

        private void son5_Click(object sender, EventArgs e)
        {
            List<Order> orders = new Order().GetOrder();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = orders.OrderByDescending(x => x.OrderID).Take(5).Select(x => new
            {
                x.OrderID,
                x.customer.ContactName,
                x.OrderDate
            } ).ToList();
        }

        private void yanWang_Click(object sender, EventArgs e)
        {
            List<Order> orders = new Order().GetOrder();
            var filter = orders.Where(x => x.customer.ContactName == "Yang Wang").ToList();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = filter;
        }

        private void siparisSayisi_Click(object sender, EventArgs e)
        {
            List<Order> orders = new Order().GetOrder();
            int sayi = orders.Count;
            MessageBox.Show(sayi.ToString());
        }
    }
}
