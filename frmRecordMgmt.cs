using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace bulate
{
    public partial class frmRecordMgmt : Form
    {

        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\franc\\Documents\\Database1.accdb");
        
        public frmRecordMgmt()
        {
            InitializeComponent();
        }


        void search()
        {
            string query = "SELECT * from product where prodID LIKE "+txtId.Text+"";
            OleDbCommand cmd = new OleDbCommand(query, conn);
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dgrdData.DataSource = dt;
        }
            void displayRec()
        {
            string query = "SELECT * from product order by prodID asc";
            OleDbCommand cmd = new OleDbCommand(query, conn);
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dgrdData.DataSource = dt;
        }
        private void frmRecordMgmt_Load(object sender, EventArgs e)
        {
            displayRec();
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO product(prodName, quantity, price) VALUES ('" + txtProdNme.Text + "', '" + txtQuantity.Text + "', '" + txtPrice.Text + "' )";
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Record Saved");
            displayRec();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = "UPDATE product set prodName = '" + txtProdNme.Text + "', quantity = '" + txtQuantity.Text + "' ,price = '" + txtPrice.Text + "' where prodID = "+txtId.Text+" ";
            cmd.ExecuteNonQuery();
            conn.Close();
            displayRec();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = "DELETE FROM product WHERE prodID =  " + txtId.Text + " ";
            cmd.ExecuteNonQuery();

            conn.Close();
            displayRec();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            search();
        }
    }
}





       

        //private void btnSearch_Click(object sender, EventArgs e)
        //{

        //    search(" SELECT doctor.* FROM doctor WHERE(((doctor.Lastname) = '" + txtLname.Text + "'));");
        //}

      
       
