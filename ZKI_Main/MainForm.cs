namespace ZKI_Main
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PolybiusForm pb = new PolybiusForm();
            pb.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DoubleTranspositionForm dtf = new DoubleTranspositionForm();
            dtf.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SingleTranspositionForm stf = new SingleTranspositionForm();
            stf.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CezarVizh cezarVizh = new CezarVizh();
            cezarVizh.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            VizhPleifForm vizhPleifForm = new VizhPleifForm();
            vizhPleifForm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PleifWitsonForm pleifWitsonForm = new PleifWitsonForm();
            pleifWitsonForm.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CezarGamForm cezarGamForm = new CezarGamForm();
            cezarGamForm.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ElGamalForm elGamalForm = new ElGamalForm();
            elGamalForm.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            RanecForm ranecForm = new RanecForm();
            ranecForm.Show();
            this.Hide();
        }
    }
}