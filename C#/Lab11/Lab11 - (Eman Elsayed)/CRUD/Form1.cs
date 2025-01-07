namespace ITI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCreate formCreate = new FormCreate();
            formCreate.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormRead formRead = new FormRead();
            formRead.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormUpdate formUpdate = new FormUpdate();
            formUpdate.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormDelete formDelete = new FormDelete();
            formDelete.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormJoin formJoin = new FormJoin();
            formJoin.Show();
        }
    }
}
