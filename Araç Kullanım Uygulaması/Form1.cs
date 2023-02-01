namespace Araç_Kullanım_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Rota: " + CmbNereden.Text + " - " + CmbNereye.Text);
            listBox1.Items.Add("Tarih: " + MskDate.Text);
            listBox1.Items.Add("Saat: " + MskTime.Text);

            listBox1.Items.Add("------------");
            listBox1.Items.Add("~Yolcu bilgileri~");
            listBox1.Items.Add("Ad Soyad: " + TxtAdSoyad.Text);
            listBox1.Items.Add("T.C. Kimlik No: " + MskTC.Text);

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            label9.Text = CmbNereden.Text;
            CmbNereden.Text = CmbNereye.Text;
            CmbNereye.Text = label9.Text;
        }
    }
}