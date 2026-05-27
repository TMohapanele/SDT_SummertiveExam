namespace SectionB_Q2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            string name = txtName.Text; // Get the current text from the txtName TextBox and store it in the variable 'name'
        }

        private void btnGreet_Click(object sender, EventArgs e)
        {
            string name = txtName.Text; // Get the current text from the txtName TextBox and store it in the variable 'name'
            MessageBox.Show($"Hello {name}"); // Display a greeting message that includes the user's name using string interpolation in a message box
        }
    }
}
