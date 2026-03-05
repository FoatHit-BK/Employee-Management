using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagement.GUI
{
    public partial class frmLogin : Form
    {
        #region variables

        public static string ConnectionString = "Data Source = localhost; Initial Catalog = EmployeeManagement; Integrated Security=True";

        #endregion
        public frmLogin()
        {
            //lblError.Text = "";
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //private void btnLogin(object sender, EventArgs e)
        //{
        //    RegisterForm regForm = new RegisterForm();
        //    regForm.Show();
        //    this.Hide();
        //}

        //private void chkShowPassword(object sender, EventArgs e)
        //{
        //    txtPassword.PasswordChar = chkShowPassword.Checked ? '\0' : '*';
        //}

        //private void btnLogin(object sender, EventArgs e)
        //{
        //    if (txtName.Text == null|| txtPassword.Text == null)
        //    {
        //        MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    else
        //    {
        //        if (connect.State == ConnectionState.Closed)
        //        {
        //            try
        //            {
        //                connect.Open();

        //                string selectData = "SELECT * FROM users WHERE username = @username " +"AND password = @password";
        //                using (SqlCommand cmd = new SqlCommand(selectData, connect))
        //                {
        //                    cmd.Parameters.AddWithValue("@username", login_username.Text.Trim());
        //                    cmd.Parameters.AddWithValue("@password", login_password.Text.Trim());

        //                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        //                    DataTable table = new DataTable();
        //                    adapter.Fill(table);

        //                    if (table.Rows.Count >= 1)
        //                    {
        //                        MessageBox.Show("Login successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                        MainForm mForm = new MainForm();
        //                        mForm.Show();
        //                        this.Hide();
        //                    }
        //                    else
        //                    {
        //                        MessageBox.Show("Incorrect Username/Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                    }
        //                }
        //            }
        //            catch (Exception ex)
        //            {
        //                MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //            finally
        //            {
        //                connect.Close();
        //            }
        //        }
        //    }
        //}

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Trim() == "" && txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng điền vào trường này.");
                txtUserName.Focus();
                return;
            }
            else if (txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng điền vào trường này.");
                txtPassword.Focus();
                return;
            }
            else if (txtUserName.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng điền vào trường này.");
                txtUserName.Focus();
                return;
            }
            frmMain f = new frmMain();
            f.Show();
            this.Hide();



        }
        //private void btnLogin_Clickkk(object sender, EventArgs e)
        //{
        //            try
        //            {
        //                //kiểm tra xem textbox tk vs mk đã nhập hay chưa
        //                if (txtUserName.Text != null && txtUserName.Text.Trim() != "") { }
        //                else
        //                {
        //                    MessageBox.Show("Account name information has not been entered", "Notification");
        //                    txtUserName.Focus();
        //                    return;
        //                }

        //                if (txtPassword.Text != null && txtPassword.Text.Trim() != "") { }
        //                else
        //{
        //    MessageBox.Show("Password information has not been entered", "Notification");
        //    txtPassword.Focus();
        //    return;
        //}

        //SqlConnection conn = new SqlConnection();
        //if (conn.State == ConnectionState.Closed)
        //{
        //    conn.Open();
        //}
        //string UserName = txtUserName.Text.Trim();
        //string Password = txtPassword.Text.Trim();
        //string query = "SELECT * FROM tblAccount WHERE userName = '" + UserName + "' AND passWord = '" + Password + "'";

        //SqlCommand cmd = new SqlCommand(query, conn);
        //SqlDataAdapter da = new SqlDataAdapter(cmd);

        //DataSet ds = new DataSet();
        //da.Fill(ds);

        //if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
        //{
        //    frmMain _frmMain = new frmMain();
        //    _frmMain.Show();
        //    this.Hide();
        //}
        //else
        //{
        //    lblError.Text = "Account information or password is incorrect!";
        //}
        //            }
        //            catch (Exception ex)
        //            {
        //                lblError.Text = ex.Message;
        //            }
        //}

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            try
            {
                lblError.Text = "";
                //kiểm tra xem textbox tk vs mk đã nhập hay chưa
                if (txtUserName.Text != null && txtUserName.Text.Trim() != "") { }
                else
                {
                    MessageBox.Show("Account name information has not been entered", "Notification");
                    txtUserName.Focus();
                    return;
                }

                if (txtPassword.Text != null && txtPassword.Text.Trim() != "") { }
                else
                {
                    MessageBox.Show("Password information has not been entered", "Notification");
                    txtPassword.Focus();
                    return;
                }

                SqlConnection conn = new SqlConnection();
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string UserName = txtUserName.Text.Trim();
                string Password = txtPassword.Text.Trim();
                string query = "SELECT * FROM tblAccount WHERE userName = '" + UserName + "' AND passWord = '" + Password + "'";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();
                da.Fill(ds);

                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    frmMain _frmMain = new frmMain();
                    _frmMain.Show();
                    this.Hide();
                }
                else
                {
                    lblError.Text = "Account information or password is incorrect!";
                }
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
                //lblError.Text = "Account information or password is incorrect!";
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void lblError_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
