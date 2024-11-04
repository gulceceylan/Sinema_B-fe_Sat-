namespace sinemabufe_satıs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kasatutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int misir = 0, bilet, su, cay, toplam;
            misir = Convert.ToInt16(misirtxt.Text);
            bilet = Convert.ToInt16(bilettxt.Text);
            cay = Convert.ToInt16(caytxt.Text);
            su = Convert.ToInt16(sutxt.Text);
            toplam = misir * 4 + su * 1 + cay * 2 + bilet * 10;
            lbltoplam.Text = toplam.ToString() + "TL";
            kasatutar = kasatutar + toplam;
            lblkasa.Text = kasatutar.ToString() + "TL";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bilettxt.Text = "";
            caytxt.Text = "";
            misirtxt.Text = "";
            sutxt.Text = "";
            misirtxt.Focus();
        }
    }
}
