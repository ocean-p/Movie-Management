using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE140501
{
    public partial class Form1 : Form
    {
        int pos = -1;
        //bool duplicate = false;
        public Form1()
        {
            InitializeComponent();
            FirstLoad();
            LoadData();
        }

        private SqlConnection MakeConnection()
        { 
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connect"].ConnectionString);
            return conn;
        }
        private void LoadData()
        {
            try
            {
                SqlConnection conn = MakeConnection();
                conn.Open();
                SqlCommand cm = conn.CreateCommand();
                cm.Connection = conn;
                cm.CommandText = "select title,year,length,genre from Movies";
                SqlDataReader dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    ListViewItem lvi = new ListViewItem(dr["title"].ToString());
                    lvi.SubItems.Add(dr["year"].ToString());
                    lvi.SubItems.Add(dr["length"].ToString());
                    lvi.SubItems.Add(dr["genre"].ToString());
                    movielist.Items.Add(lvi);
                }
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Load data fail", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private bool IsDuplicate(string title, int year)
        {
            bool a = false;
            try
            {
                SqlConnection conn = MakeConnection();
                conn.Open();
                SqlCommand cm = conn.CreateCommand();
                cm.Connection = conn;
                cm.CommandText = "select title,year,length,genre from Movies where title = @t and year = @y";
                cm.Parameters.Add("@t", SqlDbType.VarChar);
                cm.Parameters.Add("@y", SqlDbType.Int);
                cm.Parameters["@t"].Value = title;
                cm.Parameters["@y"].Value = year;
                SqlDataReader dr = cm.ExecuteReader();
                if (dr.Read())
                {
                    a = true;
                }
                
            }
            catch
            {

            }
            return a;
        }
        private bool ValidInput1()
        {
            string s;
            //title
            s = txttitle.Text.Trim();
            if(s.Length == 0)
            {
                MessageBox.Show("Title is not empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txttitle.Focus();
                return false;
            }
            //end title
            //year
            s = txtyear.Text.Trim();
            if(s.Length == 0)
            {
                MessageBox.Show("Year is not empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtyear.Focus();
                return false;
            }
            if(!Regex.IsMatch(s,"^[0-9]+$"))
            {
                MessageBox.Show("Year must be number only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtyear.Focus();
                return false;
            }
            if(int.Parse(s) < 1000 || int.Parse(s) > 3000)
            {
                MessageBox.Show("Year must be between 1000 - 3000!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtyear.Focus();
                return false;
            }
            //end year
            //length
            s = txtlength.Text.Trim();
            if (!Regex.IsMatch(s, "^[0-9]+$"))
            {
                MessageBox.Show("Length must be number > 0!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtlength.Focus();
                return false;
            }
            if (int.Parse(s) <= 0)
            {
                MessageBox.Show("Length must be number > 0!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtlength.Focus();
                return false;
            }
            // end length
            //genre
            s = txtgenre.Text.Trim();
            if(s.Length == 0 || s.Length > 10)
            {
                MessageBox.Show("Genre'length min: 1, max: 10!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtgenre.Focus();
                return false;
            }
            if(!Regex.IsMatch(s,"^[a-zA-z0-9 ]+$"))
            {
                MessageBox.Show("Genre must be letters only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtgenre.Focus();
                return false;
            }
            //end genre
            //duplicate
            if (IsDuplicate(txttitle.Text.Trim(), int.Parse(txtyear.Text.Trim())))
            {
                MessageBox.Show("This title and year were existed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txttitle.Focus();
                return false;
            }
            //end duplicate
            return true;
        }
        private bool ValidInput2()
        {
            string s;
            //length
            s = txtlength.Text.Trim();
            if (!Regex.IsMatch(s, "^[0-9]+$"))
            {
                MessageBox.Show("Length must be number > 0!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtlength.Focus();
                return false;
            }
            if (int.Parse(s) <= 0)
            {
                MessageBox.Show("Length must be number > 0!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtlength.Focus();
                return false;
            }
            // end length
            //genre
            s = txtgenre.Text.Trim();
            if (s.Length == 0 || s.Length > 10)
            {
                MessageBox.Show("Genre'length min: 1, max: 10!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtgenre.Focus();
                return false;
            }
            //end genre
            
            return true;
        }
        private void btadd_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidInput1())
                {
                    SqlConnection conn = MakeConnection();
                    conn.Open();
                    string title = txttitle.Text.Trim();
                    string year = txtyear.Text.Trim();
                    string length = txtlength.Text.Trim();
                    string genre = txtgenre.Text.Trim();
                    SqlCommand cm = new SqlCommand("insert into Movies(title,year,length,genre) values(@a,@b,@c,@d)", conn);
                    cm.Parameters.Add("@a", SqlDbType.VarChar);
                    cm.Parameters.Add("@b", SqlDbType.Int);
                    cm.Parameters.Add("@c", SqlDbType.Int);
                    cm.Parameters.Add("@d", SqlDbType.VarChar);
                    cm.Parameters["@a"].Value = title;
                    cm.Parameters["@b"].Value = year;
                    cm.Parameters["@c"].Value = length;
                    cm.Parameters["@d"].Value = genre;
                    cm.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Adding successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    movielist.Items.Clear();
                    LoadData();
                    FirstLoad();
                }
            }
            catch
            {
                MessageBox.Show("Adding Fail!", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);   
            }
        }

        private void humanlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(ListViewItem list in movielist.SelectedItems)
            {
                txttitle.Text = list.SubItems[0].Text.Trim();
                txtyear.Text = list.SubItems[1].Text.Trim();
                txtlength.Text = list.SubItems[2].Text.Trim();
                txtgenre.Text = list.SubItems[3].Text.Trim();
                pos = list.Index;
            }
            txttitle.Enabled = false;
            txtyear.Enabled = false;
            txtlength.Enabled = true;
            txtgenre.Enabled = true;
            btadd.Enabled = false;
            btupdate.Enabled = true;
            btdelete.Enabled = true;
        }

        private void btupdate_Click(object sender, EventArgs e)
        {
            if(pos < 0)
            {
                MessageBox.Show("Please choose a row for updating!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    if (ValidInput2())
                    {
                        string title = txttitle.Text.Trim();
                        string year = txtyear.Text.Trim();
                        string length = txtlength.Text.Trim();
                        string genre = txtgenre.Text.Trim();
                        SqlConnection conn = MakeConnection();
                        conn.Open();
                        SqlCommand cm = new SqlCommand("update Movies set length = @a, genre = @b where title = @c and year = @d", conn);
                        cm.Parameters.Add("@a", SqlDbType.Int);
                        cm.Parameters.Add("@b", SqlDbType.VarChar);
                        cm.Parameters.Add("@c", SqlDbType.VarChar);
                        cm.Parameters.Add("@d", SqlDbType.Int);
                        cm.Parameters["@a"].Value = length;
                        cm.Parameters["@b"].Value = genre;
                        cm.Parameters["@c"].Value = title;
                        cm.Parameters["@d"].Value = year;
                        cm.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Updating Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        movielist.Items.Clear();
                        pos = -1;
                        LoadData();
                        FirstLoad();
                    }
                }
                catch
                {
                    MessageBox.Show("Updating Fail!", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            if(pos < 0)
            {
                MessageBox.Show("Please choose a row for deleting!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    var c = MessageBox.Show("Are you sure to delete?", "Confirm",
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(c == DialogResult.Yes)
                    {
                        string title = txttitle.Text.Trim();
                        string year = txtyear.Text.Trim();
                        SqlConnection conn = MakeConnection();
                        conn.Open();
                        SqlCommand cm = new SqlCommand("delete Movies where title = @a and year = @b", conn);
                        cm.Parameters.Add("@a", SqlDbType.VarChar);
                        cm.Parameters.Add("@b", SqlDbType.Int);
                        cm.Parameters["@a"].Value = title;
                        cm.Parameters["@b"].Value = year;
                        cm.ExecuteNonQuery();
                        conn.Close();
                        txttitle.Text = "";
                        txtyear.Text = "";
                        txtlength.Text = "";
                        txtgenre.Text = "";
                        MessageBox.Show("Delete successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        movielist.Items.Clear();
                        pos = -1;
                        LoadData();
                        FirstLoad();
                    }
                    
                }
                catch
                {
                    MessageBox.Show("Delete Fail!", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnew_Click(object sender, EventArgs e)
        {
            txttitle.Enabled = true;
            txtyear.Enabled = true;
            txtlength.Enabled = true;
            txtgenre.Enabled = true;
            txttitle.Clear();
            txtyear.Clear();
            txtlength.Clear();
            txtgenre.Clear();
            btadd.Enabled = true;
            btupdate.Enabled = false;
            btdelete.Enabled = false;
            pos = -1;
        }
        private void FirstLoad()
        {
            txttitle.Enabled = false;
            txtyear.Enabled = false;
            txtlength.Enabled = false;
            txtgenre.Enabled = false;
            btadd.Enabled = false;
            btupdate.Enabled = true;
            btdelete.Enabled = true;
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            var c = MessageBox.Show("Are you sure to exit?", "Confirm",
                                           MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (c == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
