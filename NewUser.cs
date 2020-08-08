using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Crackers_Management_System
{
    public partial class NewUser : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SAGAR;Initial Catalog=CrackersManagementSystem;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public NewUser()
        {
            InitializeComponent();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            con.Close();
            cmd = new SqlCommand("insert into tblLoginDetails values ('" + txtusername.Text + "','" + txtpassword.Text + "');", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("You Registered Successfully..");
            ClearData();
        }

        private void ClearData()
        {
            txtusername.Text = "";
            txtpassword.Text = "";
            //throw new NotImplementedException();
        }

        private void NewUser_Load(object sender, EventArgs e)
        {

        }
    }
}
