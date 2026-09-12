using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_student_information_system
{
    public partial class Login_From : Form
    {
        public Login_From()
        {
            InitializeComponent();
        }

        // button cancel ( close the form )
        private void button_CANCEL_Click(object sender, EventArgs e)
        {
            Close();
        }

        // button login
        private void button_LOGIN_Click(object sender, EventArgs e)
        {
            MY_DB db = new MY_DB();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            DataTable table = new DataTable();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `user` WHERE `username` = @usn AND `password` = @pass", db.getConnection);
            
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = TextBoxUsername.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = TextBoxPassword.Text;
            
            adapter.SelectCommand = command;
            
            adapter.Fill(table);
            
            if ((table.Rows.Count > 0))
            {
                // if this user exist 
                // we will set the dialogResult to OK
                // that mean the login informatons are correct -> open the mainform
                // check out the "Program.cs"
                // learn more here -> https://stackoverflow.com/questions/4759334/how-can-i-close-a-login-form-and-show-the-main-form-without-my-application-closi 
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Invalid Username Or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // on form load
        private void Login_From_Load(object sender, EventArgs e)
        {
            // set image into picturebox from images folder
            pictureBox1.Image = Image.FromFile("../../images/user.png");
        }
    }
}
