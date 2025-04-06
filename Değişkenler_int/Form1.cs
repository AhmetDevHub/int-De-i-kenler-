namespace Değişkenler_int
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //    int sayi1, sayi2,toplam;
            //    sayi1 = 5;
            //    sayi2 = 7;
            //    toplam = sayi1 + sayi2;
            //    label1.Text = toplam.ToString();


            //int kenar, alan, çevre;
            //kenar = 10;
            //alan = kenar * kenar;
            //çevre = kenar * 4;
            //label1.Text = "Alan:" + alan+"  Çevre:"+çevre;



            int sınav1, sınav2, sınav3,ortalama;
            sınav1 = 50;
            sınav2 = 40;
            sınav3 = 58;

            ortalama = (sınav1 + sınav2 + sınav3) / 3;

            label1.Text = "Sınav Ortalaması : " + ortalama;

        }
    }
}
