namespace terceiroprojeto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnsoma_Click(object sender, EventArgs e)
        {
            int var1, var2, var3, total;
            var1 = int.Parse(TbValor1.Text);
            var2 = int.Parse(TbValor2.Text);
            total = var1 + var2;

            LblResultado.Text = total.ToString();
        }

        private void btnsoma1_Click(object sender, EventArgs e)
        {
            int var1, var2, var3, total;
            var1 = int.Parse(txtvalor.Text);
            var2 = int.Parse(txtvalor2.Text);

            total = var1 - var2;
            lblResultado1.Text = total.ToString();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            int var1,var2,var3,total;
            var1 = int.Parse(txtbox1.Text);
            var2 = int.Parse(txtbox2.Text);
            total = var1 * var2;
            resu2.Text = total.ToString();

        }
    }
}
