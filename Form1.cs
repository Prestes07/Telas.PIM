namespace Totem
{
    public partial class Form1 : Form
    {
        private Control? button;
        private object button1;

        public Form1()
        {
            InitializeComponent();
            lblText.Text = "fsdfs";

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Button btnVoltar = new Button();
            Controls.Add(button);


        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            Button btnProximo = new Button();
            Controls.Add(button);
     
        }
    }
}
