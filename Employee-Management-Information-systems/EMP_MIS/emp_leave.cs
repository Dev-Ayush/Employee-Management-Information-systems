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
    public partial class emp_leave : Form
    {
        SqlCeCommand cmd;
        SqlCeConnection con;
        string str;
        SqlCeDataAdapter da;
        DataSet ds;
        public string myId = "";
        string myName = "";
        string[] s = new string[3];
        public emp_leave(string myid,string myname)
        {
            InitializeComponent();
            this.myId = myid;
            this.myName = myname;
        }

        private void emp_leave_Load(object sender, EventArgs e)
        {
            this.txt_leave_name.Text = myName;

            listview_Headers();    //To Load ListView Table Headings
            load_leave_details();  //To Load ListView Table Items
            
        }

        //To Load Table Headers on Page Load
        private void listview_Headers()
        {
            listView1.View = View.Details;
            listView1.Columns.Add("Total Number of Leaves", 165);
            listView1.Columns.Add("Applied Leave", 165);
            listView1.Columns.Add("Remaining Leaves", 125);
            con = new SqlCeConnection(@"Data Source=emp_mis.sdf");
            con.Open();
        }
        
        // To Load Available Leave Records of the Individual
        private void load_leave_details()
        {
            str = "select available_leave,applied_leave,remaining_leave from leave_calculation where eid=" + Convert.ToInt32(myId);
            cmd = new SqlCeCommand(str,con);
            da = new SqlCeDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "leave_calculation");
            listView1.Items.Clear();

                s[0] = ds.Tables[0].Rows[0][0].ToString();
                s[1] = ds.Tables[0].Rows[0][1].ToString();
                s[2] = ds.Tables[0].Rows[0][2].ToString();

                ListViewItem lv = new ListViewItem(s);
                listView1.Items.Add(lv);
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result= MessageBox.Show("Are You Sure ??","Leave Application",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            
            if(result==DialogResult.OK)
            { 
                apply_for_leave();

                update_leave_application();
            }
        }

        // To Apply for a New Leave 
        private void apply_for_leave()
        {
            //str = "insert into leave values(" + Convert.ToInt32(myId) + "," + txt_leave_date.Value + ",'" + this.txt_leave_reason.Text + "')";
            //cmd = new SqlCeCommand(str, con);
            str = "insert into leave values(@eid,@leave_date,@reason)";
            cmd = new SqlCeCommand(str,con);
            cmd.Parameters.AddWithValue("@eid", Convert.ToInt32(myId));
            cmd.Parameters.AddWithValue("@leave_date", txt_leave_date.Value);
            cmd.Parameters.AddWithValue("@reason", this.txt_leave_reason.Text);

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Applied");
        }

        // To Manage Leave after Applying for it
        private void update_leave_application()
        {
            int applied_leave = Convert.ToInt32(s[1]) + 1;
            int remaining_leave = Convert.ToInt32(s[2]) - 1;
            con.Open();
            string str2 = "UPDATE leave_calculation SET applied_leave=" + applied_leave + ",remaining_leave=" + remaining_leave + " WHERE eid=" + Convert.ToInt32(myId);
            cmd = new SqlCeCommand(str2,con);
            cmd.ExecuteNonQuery();
            
            load_leave_details();
            con.Close();
        }

        private void emp_leave_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((MainPanel)this.MdiParent).DisplayPanel();
        }
    }
}
