using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Değişkenler_int
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayı1, sayı2, toplam, carpim, fark, bolum;
            sayı1 = Convert.ToInt16(textBox1.Text);
            sayı2 = Convert.ToInt16(textBox2.Text);
            toplam = sayı1 + sayı2;
            carpim = sayı1 * sayı2;
            fark = sayı1 - sayı2;
            bolum = sayı1 / sayı2;

            MessageBox.Show("Toplam:" + toplam + "\n" + "Fark:" + fark+"\n"+"Çarpım:"+carpim+"\n"+"Bölüm:"+bolum);

        }
    }
}
