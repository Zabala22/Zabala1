namespace Full_name_on_message_box
{
    public partial class FullNameDisplayer : Form
    {
        public FullNameDisplayer()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FullnametextBox.Text = LastnametextBox.Text + "," + " " + FirstnametextBox.Text + " " + MiddlenametextBox.Text;
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            FirstnametextBox.Text = "";
            MiddlenametextBox.Text = "";
            LastnametextBox.Text = "";
            FullnametextBox.Text = "";
            FirstnametextBox.Focus();
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}