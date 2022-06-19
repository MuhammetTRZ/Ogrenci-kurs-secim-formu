using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        public void güncelle()
        {
            
            

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Öğrenci Birsen = new Öğrenci();
            Birsen.ad = textBox1.Text;
            Birsen.SoyAd = textBox2.Text;
            Birsen.Ders = textBox3.Text;
            Birsen.Düzenle();
            listBox1.Items.Add(Birsen.Yeni);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }
    }
}
