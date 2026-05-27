namespace SectionC_Q1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            string code = txtCode.Text;
        }

        private void txtMake_TextChanged(object sender, EventArgs e)
        {
            string make = txtMake.Text;
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            string quantity = txtQuantity.Text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "Record Added";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "Record Deleted";
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (lblOutput.Text == "Record Added")
            {
                lblOutput.Text = "Record Found";
            }
            else
            {
                lblOutput.Text = "Record Not Found";
            }
        }
    }
}
