using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace project.cs
{
    public partial class FeeStructure : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStr"].ConnectionString;
        public FeeStructure()
        {
            InitializeComponent();

        }
        int flag = 0, flag1 = 0, flag2 = 0;
        int e1, e2, e3, e4, e5, e6, e7, e8, e9, e10, e11, e12;

        //=================================== CONVERTS NUMBER TO WORDS ===================================================//
        public string ConvertNumbertoWords(long number)
        {
            if (number == 0) return "ZERO";
            if (number < 0) return "minus " + ConvertNumbertoWords(Math.Abs(number));
            string words = "";
            if ((number / 1000000) > 0)
            {
                words += ConvertNumbertoWords(number / 100000) + " LAKHS ";
                number %= 1000000;
            }
            if ((number / 1000) > 0)
            {
                words += ConvertNumbertoWords(number / 1000) + " THOUSAND ";
                number %= 1000;
            }
            if ((number / 100) > 0)
            {
                words += ConvertNumbertoWords(number / 100) + " HUNDRED ";
                number %= 100;
            }
            if (number > 0)
            {
                if (words != "") words += "AND ";
                var unitsMap = new[]   
                    {  
                        "ZERO", "ONE", "TWO", "THREE", "FOUR", "FIVE", "SIX", "SEVEN", "EIGHT", "NINE", "TEN", "ELEVEN", "TWELVE", "THIRTEEN", "FOURTEEN", "FIFTEEN", "SIXTEEN", "SEVENTEEN", "EIGHTEEN", "NINETEEN"  
                    };
                var tensMap = new[]   
                    {  
                        "ZERO", "TEN", "TWENTY", "THIRTY", "FORTY", "FIFTY", "SIXTY", "SEVENTY", "EIGHTY", "NINETY"  
                    };
                if (number < 20) words += unitsMap[number];
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0) words += " " + unitsMap[number % 10];
                }
            }
            return words;
        }
        private void txtboxgtotal_TextChanged(object sender, EventArgs e)
        {
            FeeStructure fs = new FeeStructure();
            txtboxamtwords.Text = fs.ConvertNumbertoWords(Convert.ToInt64(txtboxgtotal.Text));
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            ///////////////////// SQL DATA INSERTION //////////////////////////////////
            try
            {
                if ((txtboxgtotal.Text != "") && (txtboxgtotal.Text != "0"))
                {
                    SqlConnection con = new SqlConnection(connectionString);
                   // SqlConnection con = new SqlConnection("Server=ADMIN-PC;DataBase=project;Integrated Security=SSPI");
                    SqlCommand cmd = new SqlCommand("PrcFeeStructure", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Course", ComboBoxCourse.Text);
                    cmd.Parameters.AddWithValue("@Ipomo", txtboxipomo.Text);
                    cmd.Parameters.AddWithValue("@Idcrad", txtboxidcard.Text);
                    cmd.Parameters.AddWithValue("@BlueBook", txtboxbluebook.Text);
                    cmd.Parameters.AddWithValue("@Cultural", txtboxcultural.Text);
                    cmd.Parameters.AddWithValue("@Total", txtboxtotal1.Text);
                    cmd.Parameters.AddWithValue("@Tutuion", txtboxtution.Text);
                    cmd.Parameters.AddWithValue("@Uniform", txtboxuniform.Text);
                    cmd.Parameters.AddWithValue("@Library", txtboxlibrary.Text);
                    cmd.Parameters.AddWithValue("@Lab", txtboxlab.Text);
                    cmd.Parameters.AddWithValue("@Total2", txtboxtotal2.Text);
                    cmd.Parameters.AddWithValue("@Development", txtboxdev.Text);
                    cmd.Parameters.AddWithValue("@vani", txtboxvani.Text);
                    cmd.Parameters.AddWithValue("@Stationary", txtboxstationary.Text);
                    cmd.Parameters.AddWithValue("@Alumni", txtboxalumni.Text);
                    cmd.Parameters.AddWithValue("@Total3", txtboxtotal3.Text);
                    cmd.Parameters.AddWithValue("@GTotal", txtboxgtotal.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Inserted Successfully");
                    ComboBoxCourse.Text = "";
                    txtboxipomo.Text = "";
                    txtboxidcard.Text = "";
                    txtboxbluebook.Text = "";
                    txtboxcultural.Text = "";
                    txtboxtotal1.Text = "0";
                    txtboxtution.Text = "";
                    txtboxuniform.Text = "";
                    txtboxlibrary.Text = "";
                    txtboxlab.Text = "";
                    txtboxtotal2.Text = "0";
                    txtboxdev.Text = "";
                    txtboxvani.Text = "";
                    txtboxstationary.Text = "";
                    txtboxalumni.Text = "";
                    txtboxtotal3.Text = "0";
                    txtboxgtotal.Text = "0";
                }
                else
                {
                    MessageBox.Show("Fill All TEXTBOX :) ");
                }
            }
            catch
            {
                MessageBox.Show("Some thing went wrong.Please try again :) ");
            }
            
        }
        private void BtnReset_Click(object sender, EventArgs e)
        {
            //// ---------------------------- RESET THE TYPED TEXT -------------------------------//

            ComboBoxCourse.Text = "";
            txtboxipomo.Text = "";
            txtboxidcard.Text = "";
            txtboxbluebook.Text = "";
            txtboxcultural.Text = "";
            txtboxtotal1.Text = "0";
            txtboxtution.Text = "";
            txtboxuniform.Text = "";
            txtboxlibrary.Text = "";
            txtboxlab.Text = "";
            txtboxtotal2.Text = "0";
            txtboxdev.Text = "";
            txtboxvani.Text = "";
            txtboxstationary.Text = "";
            txtboxalumni.Text = "";
            txtboxtotal3.Text = "0";
            txtboxgtotal.Text = "0";
        }

        private void btnadd1_Click(object sender, EventArgs e)
        {
            //// ==================================== Checks the input : Only Natural numbers are accepted ===============================================////
            if (flag == 0)
            {
                if (txtboxipomo.Text.Any(c => !(Char.IsNumber(c))) || (txtboxipomo.Text == ""))
                {
                    erroripomo.SetError(txtboxipomo, "Enter Natural Numbers Only. ");
                }
                else
                {
                    erroripomo.SetError(txtboxipomo, "");
                    e1 = 1;
                }
                if (txtboxidcard.Text.Any(c => !(Char.IsNumber(c))) || (txtboxidcard.Text == ""))
                {
                    erroridcard.SetError(txtboxidcard, "Enter Natural Numbers Only.");
                }
                else
                {
                    erroridcard.SetError(txtboxidcard, "");
                    e2 = 1;
                }
                if (txtboxbluebook.Text.Any(c => !(Char.IsNumber(c))) || (txtboxbluebook.Text == ""))
                {
                    errorbluebook.SetError(txtboxbluebook, "Enter Natural Numbers Only.");
                }
                else
                {
                    errorbluebook.SetError(txtboxbluebook, "");
                    e3 = 1;
                }
                if (txtboxcultural.Text.Any(c => !(Char.IsNumber(c))) || (txtboxcultural.Text == ""))
                {
                    errorcultural.SetError(txtboxcultural, "Enter Natural Numbers Only.");
                }
                else
                {
                    errorcultural.SetError(txtboxcultural, "");
                    e4 = 1;
                }
                if ((e1 == 1) && (e2 == 1) && (e3 == 1) && (e4 == 1))
                {
                    flag = 1;
                }
            }
            try
            {
                if (flag == 1)
                    txtboxtotal1.Text = ((Convert.ToInt64(txtboxipomo.Text)) + (Convert.ToInt64(txtboxidcard.Text)) + (Convert.ToInt64(txtboxbluebook.Text)) + (Convert.ToInt64(txtboxcultural.Text))).ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Some thing went wrong.Please try again :) "+ex);
            }
            
        }

        private void btnadd2_Click(object sender, EventArgs e)
        {
            //// ==================================== Checks the input : Only Natural numbers are accepted ===============================================////
            if (flag1 == 0)
            {
                if (txtboxtution.Text.Any(c => !(Char.IsNumber(c))) || (txtboxtution.Text == ""))
                {
                    errortution.SetError(txtboxtution, "Enter Natural Numbers Only.");
                }
                else
                {
                    errortution.SetError(txtboxtution, "");
                    e5 = 1;
                }
                if (txtboxuniform.Text.Any(c => !(Char.IsNumber(c))) || (txtboxuniform.Text == ""))
                {
                    erroruniform.SetError(txtboxuniform, "Enter Natural Numbers Only.");
                }
                else
                {
                    erroruniform.SetError(txtboxuniform, "");
                    e6 = 1;
                }
                if (txtboxlibrary.Text.Any(c => !(Char.IsNumber(c))) || (txtboxlibrary.Text == ""))
                {
                    errorlibrary.SetError(txtboxlibrary, "Enter Natural Numbers Only.");
                }
                else
                {
                    errorlibrary.SetError(txtboxlibrary, "");
                    e7 = 1;
                }
                if (txtboxlab.Text.Any(c => !(Char.IsNumber(c))) || (txtboxlibrary.Text == ""))
                {
                    errorlab.SetError(txtboxlab, "Enter Natural Numbers Only.");
                }
                else
                {
                    errorlab.SetError(txtboxlab, "");
                    e8 = 1;
                }
                if ((e5 == 1) && (e6 == 1) && (e7 == 1) && (e8 == 1))
                {
                    flag1 = 1;
                }
            }
            if (flag1 == 1)
            {
                txtboxtotal2.Text = ((Convert.ToInt64(txtboxtution.Text)) + (Convert.ToInt64(txtboxuniform.Text)) + (Convert.ToInt64(txtboxlibrary.Text)) + (Convert.ToInt64(txtboxlab.Text))).ToString();
            }
        }

        private void btnadd3_Click(object sender, EventArgs e)
        {
            //// ==================================== Checks the input : Only Natural numbers are accepted ===============================================////
            if (flag2 == 0)
            {
                if (txtboxdev.Text.Any(c => !(Char.IsNumber(c))) || (txtboxdev.Text == ""))
                {
                    e9 = 0;
                    errordev.SetError(txtboxdev, "Enter Natural Numbers Only.");
                }
                else
                {
                    errordev.SetError(txtboxdev, "");
                    e9 = 1;
                }
                if (txtboxvani.Text.Any(c => !(Char.IsNumber(c))) || (txtboxvani.Text == ""))
                {
                    e10 = 0;
                    errorvani.SetError(txtboxvani, "Enter Natural Numbers Only.");
                }
                else
                {
                    errorvani.SetError(txtboxvani, "");
                    e10 = 1;
                }
                if (txtboxstationary.Text.Any(c => !(Char.IsNumber(c))) || (txtboxstationary.Text == ""))
                {
                    e11 = 0;
                    errorstationary.SetError(txtboxstationary, "Enter Natural Numbers Only.");
                }
                else
                {
                    errorstationary.SetError(txtboxstationary, "");
                    e11 = 1;
                }
                if (txtboxalumni.Text.Any(c => !(Char.IsNumber(c))) || (txtboxalumni.Text == ""))
                {
                    e12 = 0;
                    erroralumni.SetError(txtboxalumni, "Enter Natural Numbers Only.");
                }
                else
                {
                    erroralumni.SetError(txtboxalumni, "");
                    e12 = 1;
                }
                if ((e9 == 1) && (e10 == 1) && (e11 == 1) && (e12 == 1))
                {
                    flag2 = 1;
                }
            }
            if (flag2 == 1)
                txtboxtotal3.Text = ((Convert.ToInt64(txtboxdev.Text)) + (Convert.ToInt64(txtboxvani.Text)) + (Convert.ToInt64(txtboxstationary.Text)) + (Convert.ToInt64(txtboxalumni.Text))).ToString();
        }

        private void btnaddg_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtboxtotal1.Text != "") && (txtboxtotal2.Text != "") && (txtboxtotal3.Text != ""))
                {
                    txtboxgtotal.Text = ((Convert.ToInt64(txtboxtotal1.Text)) + (Convert.ToInt64(txtboxtotal2.Text)) + (Convert.ToInt64(txtboxtotal3.Text))).ToString();
                }
                else
                {
                    MessageBox.Show("FILL ALL THE TEXTBOX :) ");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Some thing went wrong.Please try again :)" + ex);
            }
            
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtboxgtotal.Text != "")
                {
                    SqlConnection con = new SqlConnection(connectionString);
                   // SqlConnection con = new SqlConnection("Server=ADMIN-PC;DataBase=project;Integrated Security=SSPI");
                    SqlCommand cmd = new SqlCommand("PrcFeeStructUpdater", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    //  cmd.Parameters.AddWithValue("@Course", ComboBoxCourse.Text);
                    cmd.Parameters.AddWithValue("@Course", ComboBoxCourse.Text);
                    cmd.Parameters.AddWithValue("@Ipomo", txtboxipomo.Text);
                    cmd.Parameters.AddWithValue("@Idcrad", txtboxidcard.Text);
                    cmd.Parameters.AddWithValue("@BlueBook", txtboxbluebook.Text);
                    cmd.Parameters.AddWithValue("@Cultural", txtboxcultural.Text);
                    cmd.Parameters.AddWithValue("@Total", txtboxtotal1.Text);
                    cmd.Parameters.AddWithValue("@Tutuion", txtboxtution.Text);
                    cmd.Parameters.AddWithValue("@Uniform", txtboxuniform.Text);
                    cmd.Parameters.AddWithValue("@Library", txtboxlibrary.Text);
                    cmd.Parameters.AddWithValue("@Lab", txtboxlab.Text);
                    cmd.Parameters.AddWithValue("@Total2", txtboxtotal2.Text);
                    cmd.Parameters.AddWithValue("@Development", txtboxdev.Text);
                    cmd.Parameters.AddWithValue("@vani", txtboxvani.Text);
                    cmd.Parameters.AddWithValue("@Stationary", txtboxstationary.Text);
                    cmd.Parameters.AddWithValue("@Alumni", txtboxalumni.Text);
                    cmd.Parameters.AddWithValue("@Total3", txtboxtotal3.Text);
                    cmd.Parameters.AddWithValue("@GTotal", txtboxgtotal.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Updated Successfully :) ");
                    ComboBoxCourse.Text = "";
                    txtboxipomo.Text = "";
                    txtboxidcard.Text = "";
                    txtboxbluebook.Text = "";
                    txtboxcultural.Text = "";
                    txtboxtotal1.Text = "0";
                    txtboxtution.Text = "";
                    txtboxuniform.Text = "";
                    txtboxlibrary.Text = "";
                    txtboxlab.Text = "";
                    txtboxtotal2.Text = "0";
                    txtboxdev.Text = "";
                    txtboxvani.Text = "";
                    txtboxstationary.Text = "";
                    txtboxalumni.Text = "";
                    txtboxtotal3.Text = "0";
                    txtboxgtotal.Text = "0";
                }
                else
                {
                    MessageBox.Show("Fill All TEXTBOX :) ");
                }
            }
            catch
            {
                MessageBox.Show("Some thing went wrong.Please try again :) ");
            }
            
        }

        private void ComboBoxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            /////------------------------- SQL DATA VIEW ------------------------------------//////
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                //using (SqlConnection con = new SqlConnection("Server=ADMIN-PC;DataBase=project;Integrated Security=SSPI"))
                {
                    // ================== WITHOUT STORED PROCEDURE =============================//
                    // using (SqlCommand cmd1 = new SqlCommand("select * from TblFeeStructure where Course=@Course",con))
                    using (SqlCommand cmd1 = new SqlCommand("PrcFeeStructViewer", con))
                    {
                        cmd1.CommandType = CommandType.StoredProcedure;

                        cmd1.Parameters.AddWithValue("@Course", ComboBoxCourse.Text);
                        con.Open();
                        using (SqlDataReader dr = cmd1.ExecuteReader())
                        {
                            // dr.SelectCommand = cmd1;
                            if (dr.Read())
                            {
                                //      ComboBoxCourse.Text = (dr["Course"].ToString());
                                txtboxipomo.Text = (dr["Ipomo"].ToString());
                                txtboxidcard.Text = (dr["IdCard"].ToString());
                                txtboxbluebook.Text = (dr["BlueBook"].ToString());
                                txtboxcultural.Text = (dr["Cultural"].ToString());
                                txtboxtotal1.Text = (dr["Total1"].ToString());
                                txtboxtution.Text = (dr["Tution"].ToString());
                                txtboxuniform.Text = (dr["Uniform"].ToString());
                                txtboxlibrary.Text = (dr["Library"].ToString());
                                txtboxlab.Text = (dr["Lab"].ToString());
                                txtboxtotal2.Text = (dr["Total2"].ToString());
                                txtboxdev.Text = (dr["Development"].ToString());
                                txtboxvani.Text = (dr["vani"].ToString());
                                txtboxstationary.Text = (dr["Stationary"].ToString());
                                txtboxalumni.Text = (dr["Alumni"].ToString());
                                txtboxtotal3.Text = (dr["Total3"].ToString());
                                txtboxgtotal.Text = (dr["GTotal"].ToString());
                                con.Close();

                            }
                            else
                            {
                                txtboxipomo.Text = "";
                                txtboxidcard.Text = "";
                                txtboxbluebook.Text = "";
                                txtboxcultural.Text = "";
                                txtboxtotal1.Text = "0";
                                txtboxtution.Text = "";
                                txtboxuniform.Text = "";
                                txtboxlibrary.Text = "";
                                txtboxlab.Text = "";
                                txtboxtotal2.Text = "0";
                                txtboxdev.Text = "";
                                txtboxvani.Text = "";
                                txtboxstationary.Text = "";
                                txtboxalumni.Text = "";
                                txtboxtotal3.Text = "0";
                                txtboxgtotal.Text = "0";
                                MessageBox.Show("No Records Found For This Course :) ");
                                con.Close();
                            }
                        }
                    }
                 }
            }
            catch
            {
                MessageBox.Show("Some thing went wrong.Please try again :)  ");
            }
        }
    }
}
