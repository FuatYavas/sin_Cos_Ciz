using System.Text;

namespace projeödevi1
{
    public partial class Form1 : Form
    {
        private string cache = string.Empty;
        private string oldcache = string.Empty;
        private Boolean sinSecili = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }




        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double sayi = Convert.ToDouble(txtGiris.Text);
                double mutlak = Matematik.mutlakDeger(sayi);
                txtGiris.Text = Convert.ToString(mutlak);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }

        private void btnKok_Click(object sender, EventArgs e)
        {

            double sayi = Convert.ToDouble(txtGiris.Text);
            double x = Matematik.karekok(sayi);
            string karekok = x.ToString("0.00");
            txtGiris.Text = karekok;

        }

       
        private void btnMax_Click(object sender, EventArgs e)
        {
            string veri = txtGiris.Text;
            string[] sayiStr = veri.Split(',');
            double[] sayiDbl = new double[sayiStr.Length];
            for (int i = 0; i < sayiStr.Length; i++)
            {
                if (double.TryParse(sayiStr[i].Trim(), out double sonuc))
                {
                    sayiDbl[i] = sonuc;
                }
                else
                {
                    Console.WriteLine($"Hatalı giriş: {sayiStr[i]}");
                }
            }

            txtGiris.Text = Convert.ToString(Matematik.max(sayiDbl));

        }

        private void btnsin_Click(object sender, EventArgs e)
        {
            double derece = Convert.ToDouble(txtGiris.Text);
            double x = derece * Math.PI / 180.0;


            double sinx = Matematik.sincosHesapla(x);

            txtGiris.Text = Convert.ToString(sinx);
        }

        private void btncos_Click(object sender, EventArgs e)
        {
            double derece = Convert.ToDouble(txtGiris.Text);
            derece = 90 - derece;
            double x = derece * Math.PI / 180.0;
            double cosx = Matematik.sincosHesapla(x);
            txtGiris.Text = Convert.ToString(cosx);
        }
        private void txtGiris_TextChanged(object sender, EventArgs e)
            {
                oldcache = cache;
                cache = Form1.Cache(txtGiris).ToString();
            }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            txtGiris.Text = oldcache;
        }

        private void btnCiz_Click(object sender, EventArgs e)
        {
            Boolean checkedsin =  radiosin.Checked;
            string bas = txtbasla.Text;
            string bitis = txtbit.Text;

            sinusForm grafikForm = new sinusForm(checkedsin, bas , bitis);
            grafikForm.Show();

            
        }

        public static StringBuilder Cache(TextBox txtGiris)
        {
            StringBuilder cache = new StringBuilder();
            cache.Append(txtGiris.Text);
            return cache;
        }

  
    }
}