namespace Nargs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sairbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nargsbtn_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new (Properties.Resources.som);
            player.Play();
            Form2 f2 = new Form2();
            f2.ShowDialog();
                      
        }
    }
}