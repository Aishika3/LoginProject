namespace LoginProject
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text!=" " && txtPassword.Text=="123")
            {
                Form2? frm1 = new Form2();
                this.Hide();
                frm1.ShowDialog();
                frm1 = null;
                this.Show();
            }
            else if(txtUserName.Text==" " || txtPassword.Text!="123")
            {
                MessageBox.Show("User Name or Password not correct.Please enter any valid UserName and Password!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Okay closing the Form!");
            this.Close();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}