namespace E2AC9V_ZH3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

            UserControl userControl1 = new UserControl1();

            panel1.Controls.Add(userControl1);

            userControl1.Dock = DockStyle.Fill;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

            UserControl userControl2 = new UserControl2();

            panel1.Controls.Add(userControl2);

            userControl2.Dock = DockStyle.Fill;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

            UserControl userControl3 = new UserControl3();

            panel1.Controls.Add(userControl3);

            userControl3.Dock = DockStyle.Fill;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Biztos beakarod zárni az alkalmazást?", "Alkalmazás bezárása", MessageBoxButtons.YesNo);
            if (res == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 masodikform = new Form2();

            
            this.Hide();

            
            masodikform.Show();
        }
    }
}