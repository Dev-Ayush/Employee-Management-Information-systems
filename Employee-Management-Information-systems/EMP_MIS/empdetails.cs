using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;


namespace EMP_MIS
{
    public partial class empdetails : Form
    {
        SqlCeConnection con;
        SqlCeCommand cmd;
        SqlCeDataAdapter da;
        DataSet ds;
        string str;
        string f = "";
        DataTable dt;
        int j;

        MainPanel mp;
        public empdetails(MainPanel mp)
        {
            InitializeComponent();

            comboBox1.DataSource = GetSearchColumn();
            comboBox1.DisplayMember = "Front_Name";
            comboBox1.ValueMember = "Back_Name";

            this.mp = mp;
        }

        private void empdetails_Load(object sender, EventArgs e)
        {
            
            this.textBox1.Enabled = false;
            this.timer1.Enabled = false;
            this.timer1.Interval = 100;
            this.Width = 749;
            j = this.Width;

            CreateListViewtableHeading(); // To Load Headers of ListView Table
            
            loaddata(); // To Load Table Contents
           
        }

        private void CreateListViewtableHeading()
        {
            this.listView1.View = View.Details;
            this.listView1.Columns.Add("ID", 85);
            this.listView1.Columns.Add("Name", 85);
            this.listView1.Columns.Add("Address", 155);
            this.listView1.Columns.Add("Designation", 95);
            this.listView1.Columns.Add("Photo", 60);
            con = new SqlCeConnection(@"Data Source=emp_mis.sdf");
            con.Open();
        }

        public void loaddata()
        {
            load_list_view();
        }

        public void load_list_view()
        {
            str = "select eid,ename,eaddress,edesig,ephoto from emp";
            cmd = new SqlCeCommand(str, con);
            da = new SqlCeDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "emp");
            listView1.Items.Clear();

            for (int i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
            {
                string[] s = new string[5];
                s[0] = ds.Tables[0].Rows[i][0].ToString();
                s[1] = ds.Tables[0].Rows[i][1].ToString();
                s[2] = ds.Tables[0].Rows[i][2].ToString();
                s[3] = ds.Tables[0].Rows[i][3].ToString();
                s[4] = ds.Tables[0].Rows[i][4].ToString();
                ListViewItem lv = new ListViewItem(s);
                this.listView1.Items.Add(lv);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i <= this.listView1.SelectedItems.Count - 1; i++)
                {
                    this.textBox1.Text = this.listView1.SelectedItems[i].SubItems[0].Text;
                    this.textBox2.Text = this.listView1.SelectedItems[i].SubItems[1].Text;
                    this.textBox3.Text = this.listView1.SelectedItems[i].SubItems[2].Text;
                    this.textBox4.Text = this.listView1.SelectedItems[i].SubItems[3].Text;
                    this.pictureBox1.Image = Image.FromFile(@"emp_images\" + this.listView1.SelectedItems[i].SubItems[4].Text);

                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show("No photo Available for this record");
            }
        }
                
        private void button4_Click(object sender, EventArgs e) // Button For Searching 
        {
            str = "select eid,ename,eaddress,edesig,ephoto from emp where " + (this.comboBox1.SelectedValue) + " like '%" + this.textBox5.Text+"%'";
           
            cmd = new SqlCeCommand(str,con);
            da = new SqlCeDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "emp");
            listView1.Items.Clear();

            for (int i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
            {
                string[] s = new string[5];
                s[0] = ds.Tables[0].Rows[i][0].ToString();
                s[1] = ds.Tables[0].Rows[i][1].ToString();
                s[2] = ds.Tables[0].Rows[i][2].ToString();
                s[3] = ds.Tables[0].Rows[i][3].ToString();
                s[4] = ds.Tables[0].Rows[i][4].ToString();
                ListViewItem lv = new ListViewItem(s);
                this.listView1.Items.Add(lv);
            }
                
        }

        private DataTable GetSearchColumn() // Creating Table for Key-Value Pair
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Front_Name");
            dt.Columns.Add("Back_Name");

            dt.Rows.Add("ID", "eid");
            dt.Rows.Add("Name", "ename");
            dt.Rows.Add("Address", "eaddress");
            dt.Rows.Add("Designation", "edesig");

            return dt;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void button2_Click(object sender, EventArgs e) // Button To Update Information
        {
            str = "update emp set ename='" + this.textBox2.Text + "',eaddress='" + this.textBox3.Text + "',edesig='" + this.textBox4.Text + "' where eid=" + Convert.ToInt32(this.textBox1.Text);
            cmd = new SqlCeCommand(str, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Ok");
            loaddata();
        }

        private void button6_Click(object sender, EventArgs e) // Button To Delete Selected Record
        {
            for (int i = 0; i <= this.listBox1.Items.Count - 1; i++)
            {
                f = f + this.listBox1.Items[i].ToString() + ",";
            }
            f = f.Remove(f.Length - 1);
            str = "delete from emp where eid in (" + f + ")";
            cmd = new SqlCeCommand(str, con);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Records deleted");
                load_list_view();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Deletion");
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {

        }

        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            load_list_view();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            button4_Click(sender, e);
        }

        private void listView1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            this.listBox1.Items.Clear();
            
        }

        private void listView1_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            for (int i = 0; i <= this.listView1.CheckedItems.Count - 1; i++)
            {
              this.listBox1.Items.Add(this.listView1.CheckedItems[i].SubItems[0].Text);
            }
            
        }

      

        /* Timer Control Started */

        private void timer1_Tick(object sender, EventArgs e) // Timer To expand Menu
        {
            if (j >= 1093)
            {
                this.timer1.Stop();
            }
            else
            {
                j = j + 35;
            }
            this.Width = j;
        }

        private void timer2_Tick(object sender, EventArgs e) // Timer To Contract Menu
        {
            if (j <= 749)
            {
                this.timer2.Stop();
            }
            else
            {
                j -= 35;
            }
            this.Width = j;
        }

        private void button1_Click(object sender, EventArgs e) // Expand
        {
            this.timer2.Stop();
            this.timer1.Start();
        }

        private void button3_Click(object sender, EventArgs e) // Collapse
        {
            this.timer1.Stop();
            this.timer2.Start();
        }


        /* Timer Control Ended */

        private void empdetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            mp.DisplayPanel();
        }
    }
}
