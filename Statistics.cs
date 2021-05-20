using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace project.cs
{
    public partial class Statistics : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStr"].ConnectionString;
        public Statistics()
        {
            InitializeComponent();
        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
              //  using (SqlConnection con = new SqlConnection("Server=ADMIN-PC;DataBase=project;Integrated Security=SSPI"))
                {
                    using (SqlCommand cmd = new SqlCommand("PrcStatViewAll", con))
                    {
                       cmd.CommandType = CommandType.StoredProcedure;
                        con.Open();
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                DataTable dt = new DataTable();
                                dt.Load(dr);
                                datagrid1.DataSource = dt;
                                con.Close();
                            }
                            else
                            {
                                MessageBox.Show("No Records Found ! ");
                            }
                        }
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Some thing went wrong.Please try again :)");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
              //  using (SqlConnection con = new SqlConnection("Server=ADMIN-PC;DataBase=project;Integrated Security=SSPI"))
                {
                    using (SqlCommand cmd = new SqlCommand("PrcStatRegSearch", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Regno", txtboxregno.Text);
                        con.Open();
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                DataTable dt = new DataTable();
                                dt.Load(dr);
                                datagrid1.DataSource = dt;
                                con.Close();
                            }
                            else
                            {
                                MessageBox.Show(" Register-Number Not Found ! ");
                            }
                        }
                    }
                }
         
            }
            catch(Exception ex)
            {
                MessageBox.Show("Some thing went wrong.Please try again :)"+ex);
            }
            
       }

        private void comboboxcourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
              //  using (SqlConnection con = new SqlConnection("Server=ADMIN-PC;DataBase=project;Integrated Security=SSPI"))
                {
                    using (SqlCommand cmd = new SqlCommand("PrcStatCourse", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Course", comboboxcourse.Text);
                        con.Open();
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                DataTable dt = new DataTable();
                                dt.Load(dr);
                                datagrid1.DataSource = dt;
                                con.Close();
                            }
                            else
                            {
                                MessageBox.Show(" No Records Found ! ");
                            }
                        }
                    }
                }
         
            }
            catch(Exception ex)
            {
                MessageBox.Show("Some thing went wrong.Please try again :)"+ex);
            }
            
        }

        private void comboboxyear_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                //using (SqlConnection con = new SqlConnection("Server=ADMIN-PC;DataBase=project;Integrated Security=SSPI"))
                {
                    using (SqlCommand cmd = new SqlCommand("PrcStatYear", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Year", comboboxyear.Text);
                        con.Open();
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                DataTable dt = new DataTable();
                                dt.Load(dr);
                                datagrid1.DataSource = dt;
                                con.Close();
                            }
                            else
                            {
                                MessageBox.Show(" No Records Found ! ");
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Some thing went wrong.Please try again :)"+ex);
            }
            
        }

        private void comboboxpaytype_SelectedIndexChanged(object sender, EventArgs e)
        {
              try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                //using (SqlConnection con = new SqlConnection("Server=ADMIN-PC;DataBase=project;Integrated Security=SSPI"))
                {
                    using (SqlCommand cmd = new SqlCommand("PrcStatPayType", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@PayType", comboboxpaytype.Text);
                        con.Open();
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                DataTable dt = new DataTable();
                                dt.Load(dr);
                                datagrid1.DataSource = dt;
                                con.Close();
                            }
                            else
                            {
                                MessageBox.Show(" No Records Found ! ");
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Some thing went wrong.Please try again :)"+ex);
            }
        }

        private void btnsort_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                //using (SqlConnection con = new SqlConnection("Server=ADMIN-PC;DataBase=project;Integrated Security=SSPI"))
                {
                    using (SqlCommand cmd = new SqlCommand("PrcStatSort", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@PayType", comboboxpaytype.Text);
                        cmd.Parameters.AddWithValue("@Course", comboboxcourse.Text);
                        cmd.Parameters.AddWithValue("@Year", comboboxyear.Text);
                        con.Open();
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                DataTable dt = new DataTable();
                                dt.Load(dr);
                                datagrid1.DataSource = dt;
                                con.Close();
                            }
                            else
                            {
                                MessageBox.Show(" No Records Found ! ");
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Some thing went wrong.Please try again :)"+ex);
            }
        }
    }
}
