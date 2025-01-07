using System.Data;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double result = 0;
        string operation = "";
        bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }



        private void btnNumber_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            txtDisplay.Text += button.Text;
        }

        private void operator_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEqal_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable table = new DataTable();
                var result = table.Compute(txtDisplay.Text, "");
                txtDisplay.Text = result.ToString();
            }
            catch (Exception ex)
            {
                txtDisplay.Text = "Error";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
        }
    }
}
