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
    public partial class    Login : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SAGAR;Initial Catalog=CrackersManagementSystem;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public Login()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
 
            BindData();

        }

        private void BindData()
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

         //   con.Close();
           // da = new SqlDataAdapter("select * from tblLoginDetails", con);

            //con.Open();
            da.Fill(dt);
           // throw new NotImplementedException();
        }

        private void ClearData()
        {
            //throw new NotImplementedException();
        }
    }
}
