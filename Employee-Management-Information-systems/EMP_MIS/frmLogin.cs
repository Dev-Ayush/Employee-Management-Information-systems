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
    public partial class frmLogin : Form
    {
        SqlCeConnection con;
        SqlCeCommand cmd;
        SqlCeDataAdapter da;
        DataSet ds;
        string str;
        public string rights;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoginIconPack(); // To Load Icons of Username & Password Field


        }

        private void LoginIconPack()
        {
            this.pictureBox1.Image = Image.FromFile("user-icon.png");
            this.pictureBox2.Image = Image.FromFile("password-icon.png");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlCeConnection(@"Data Source=emp_mis.sdf");
            con.Open();
            if (rights == "admin")
            {
                str = "select uname,pass,aid from admin where uname='" + this.textBox1.Text + "' and pass='" + this.textBox2.Text + "'";
            }

            if (rights == "emp")
            {
                str = "select ename,epass,eid from emp where ename='" + this.textBox1.Text + "' and epass='" + this.textBox2.Text + "'";
            }

            cmd = new SqlCeCommand(str, con);
            da = new SqlCeDataAdapter(cmd);
            ds = new DataSet();
            try
            {
                da.Fill(ds, "abc");
                
                if (ds.Tables[0].Rows[0][0].ToString() == this.textBox1.Text && ds.Tables[0].Rows[0][1].ToString() == this.textBox2.Text)
                {
                    MessageBox.Show("Login Sucessfull");
                    
                    MainPanel main_panel = new MainPanel(ds.Tables[0].Rows[0][2].ToString(), (MyRights)Enum.Parse(typeof(MyRights), rights));
                    main_panel.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Login Failed");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Login Failedddddd");
            }
            con.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton1.Checked == true)
            {
                rights = "admin";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton2.Checked == true)
            {
                rights = "emp";
            }
        }
    }
}
