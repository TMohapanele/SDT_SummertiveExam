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
            //When the btnAdd button is clicked, the program should insert a record into the tblMobilePhones with the MobileCode, Make and Quantity from the corresponding data from the form and and display the message “Record Added” in the lblOutput. 
            lblOutput.Text = "Record Added";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "Record Deleted";
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "Record Found";
        }
    }
}
