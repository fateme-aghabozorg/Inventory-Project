using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class inventory : Form
    {
        string connetionString;
        SqlConnection cnn;

        public inventory()
        {
            InitializeComponent();
            //connection string has to change in other system to connect system sql server
            //connetionString = @"Server=Name;Initial Catalog = DB_INVENTORY;User ID=SA;Password=****";
            connetionString = "Data Source=DESKTOP-7FRVFH5\\MSSQLSERVERLAB;Initial Catalog=DB_INVENTORY;User ID=SA;Password=****;"; 
            cnn = new SqlConnection(connetionString);

        }
        private void DtGrid_Size()
        {
            try
            {
                int last_index = dataGridView1.ColumnCount - 1;
                for (int i = 0; i < last_index; i++)
                    dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                dataGridView1.Columns[last_index].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception e)
            {
                MessageBox.Show(" !پیفام خطا: خطا رخ داده است" + "\n" + e);
            }
        }
        private void DtGrid_Fill(string select)
        {
            try
            {
                var dataAdapter = new SqlDataAdapter(select, cnn);
                var ds = new DataSet();
                dataAdapter.Fill(ds);
                dataGridView1.ReadOnly = true;
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception e)
            {
                MessageBox.Show(" !پیفام خطا: خطا رخ داده است" + "\n" + e);
            }

        }

        private void IMG_Poeple_Click(object sender, EventArgs e)
        {
            DtGrid_Fill("SELECT * FROM TBL_RC");
            DtGrid_Size();
        }

        private void IMG_Product_Click_1(object sender, EventArgs e)
        {
            DtGrid_Fill("SELECT * FROM TBL_PR");
            DtGrid_Size();
        }

        private void IMG_Inventory_Click_1(object sender, EventArgs e)
        {

            DtGrid_Fill("SELECT * FROM TBL_INV");
            DtGrid_Size();
        }

        private void IMG_Charge_Click_1(object sender, EventArgs e)
        {

            DtGrid_Fill("SELECT * FROM TBL_CHR");
            DtGrid_Size();
        }

        private void IMG_Decharge_Click_1(object sender, EventArgs e)
        {

            DtGrid_Fill("SELECT * FROM TBL_DCHR");
            DtGrid_Size();
        }
        private void ToCsV(DataGridView DataGridView1, string filename)
        {
            try
            {
                string StringOutPut = "";
                string StringHeaders = "";

                for (int j = 0; j < DataGridView1.Columns.Count; j++)
                    StringHeaders = StringHeaders.ToString() + Convert.ToString(DataGridView1.Columns[j].HeaderText) + "\t";
                StringOutPut += StringHeaders + "\r\n";
                for (int i = 0; i < DataGridView1.RowCount - 1; i++)
                {
                    string StringLine = "";
                    for (int j = 0; j < DataGridView1.Rows[i].Cells.Count; j++)
                        StringLine = StringLine.ToString() + Convert.ToString(DataGridView1.Rows[i].Cells[j].Value) + "\t";
                    StringOutPut += StringLine + "\r\n";
                }
                Encoding utf16 = Encoding.GetEncoding(1254);
                byte[] output = utf16.GetBytes(StringOutPut);
                FileStream FileStream1 = new FileStream(filename, FileMode.Create);
                BinaryWriter BinaryWriter1 = new BinaryWriter(FileStream1);
                BinaryWriter1.Write(output, 0, output.Length);
                BinaryWriter1.Flush();
                BinaryWriter1.Close();
                FileStream1.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }


        private void IMG_PrintExcel_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog SaveFileDialog = new SaveFileDialog();
            SaveFileDialog.Filter = "Excel Documents (*.xls)|*.xls";
            SaveFileDialog.FileName = "export.xls";
            if (SaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ToCsV(dataGridView1, SaveFileDialog.FileName);
            }
        }


        private bool Is_PoepleInfo_Complete()
        {
            if ((cmbx_SearchType.SelectedIndex == 0 && txbx_ID.Text == "")
               || (cmbx_SearchType.SelectedIndex == 1 && (txbx_FName.Text == "" || txbx_LName.Text == ""))
               || (cmbx_SearchType.SelectedIndex == 2 && (txbx_FName.Text == "" || txbx_LName.Text == "" || txbx_ID.Text == ""))
               || cmbx_Poeple.SelectedIndex == -1
               || cmbx_SearchType.SelectedIndex == -1)
                MessageBox.Show("!تکمیل اطلاعات فرم به درستی صورت نپذیرفته است");
            else if ((!(cmbx_Poeple.SelectedIndex == -1)) && (!(cmbx_SearchType.SelectedIndex == -1)))
                return true;

            return false;
        }
        private string Find_People_Query(bool Is_Form_Complete)
        {
            string Table_Name = "";
            string QUERY = "";
            string Person_Column = "";
            int Search_index = cmbx_SearchType.SelectedIndex;
            if (!Is_Form_Complete)
                return "";
            else
            {
                //poeple selected index is zero: receiver and decharge table
                //poeple selected index is one: deliverer and charge table
                Table_Name = (cmbx_Poeple.SelectedIndex == 0) ? "DCHR" : "CHR";
                Person_Column = (Table_Name == "DCHR") ? "RC" : "DL";

                //search by id
                if (Search_index == 0)
                    QUERY = "SELECT * FROM TBL_" + Table_Name
                             + " WHERE " + Table_Name + "_" + Person_Column + "ID = " + txbx_ID.Text;

                //search by first name and last name
                else if (Search_index == 1)
                    QUERY = "SELECT * FROM TBL_" + Table_Name + " JOIN " + "TBL_" + Person_Column
                              + " ON " + Table_Name + "_" + Person_Column + "ID =" + Person_Column + "_" + Person_Column + "ID"
                              + " WHERE " + Person_Column + "_" + Person_Column + "FNAME = '" + txbx_FName.Text + "'"
                              + " AND " + Person_Column + "_" + Person_Column + "LNAME = '" + txbx_LName.Text + "'";

                //search by first name, last name and id
                else if (Search_index == 2)
                    QUERY = "SELECT * FROM TBL_" + Table_Name + " JOIN " + "TBL_" + Person_Column
                              + " ON " + Table_Name + "_" + Person_Column + "ID =" + Person_Column + "_" + Person_Column + "ID"
                              + " WHERE " + Person_Column + "_" + Person_Column + "FNAME = '" + txbx_FName.Text + "'"
                              + " AND " + Person_Column + "_" + Person_Column + "LNAME = '" + txbx_LName.Text + "'"
                              + " AND " + Table_Name + "_" + Person_Column + "ID = " + txbx_ID.Text;

                return QUERY;
            }
        }
        private void btn_Find_People_Click(object sender, EventArgs e)
        {
            string SQL_QUERY = Find_People_Query(Is_PoepleInfo_Complete());
            if (SQL_QUERY != "")
            {
                DtGrid_Fill(SQL_QUERY);
            }
        }
        private string Product_Group(int cmbx_group_index)
        {
            switch (cmbx_group_index)
            {
                case 0:
                    return "digital";
                case 1:
                    return "clothes";
                case 2:
                    return "personal items";
                case 3:
                    return "hobby";
                case 4:
                    return "industrial tools and equipment";
                default:
                    return "no selected group!";
            }
        }
        private void btn_Find_Product_Click(object sender, EventArgs e)
        {
            string QUERY = "SELECT * FROM TBL_PR WHERE ";
            int Initial_Len = QUERY.Length;
            int i = 0;
            for (i = 0; i < 5; i++)
            {
                switch (i)
                {
                    case 1:
                        if (QUERY.Length > Initial_Len && txbx_PR_ID.Text != "")
                            QUERY += " AND PR_PRID = " + txbx_PR_ID.Text;
                        else if (txbx_PR_ID.Text != "")
                            QUERY += " PR_PRID = " + txbx_PR_ID.Text;
                        break;
                    case 2:
                        if (QUERY.Length > Initial_Len && (txbx_PR_Model.Text != ""))
                            QUERY += " AND PR_MODEL = " + txbx_PR_Model.Text;
                        else if (txbx_PR_Model.Text != "")
                            QUERY += " PR_MODEL = " + Convert.ToInt32(txbx_PR_Model.Text);
                        break;
                    case 3:
                        if (QUERY.Length > Initial_Len && (txbx_PR_Name.Text != ""))
                            QUERY += " AND PR_NAME = '" + txbx_PR_Name.Text+"'";
                        else if (txbx_PR_Name.Text != "")
                            QUERY += " PR_PRNAME = '" + txbx_PR_Name.Text+"'";
                        break;
                    case 4:
                        if (QUERY.Length > Initial_Len && (cmbx_PR_Group.SelectedIndex != -1))
                            QUERY += " AND PR_GROUP = '" + Product_Group(cmbx_PR_Group.SelectedIndex) + "'";
                        else if (cmbx_PR_Group.SelectedIndex != -1)
                            QUERY += " PR_GROUP = '" + Product_Group(cmbx_PR_Group.SelectedIndex) + "'";
                        break;
                    default:
                        if (txbx_PR_ID.Text == ""
                            && txbx_PR_Model.Text == ""
                            && txbx_PR_Name.Text == ""
                            && cmbx_PR_Group.SelectedIndex == -1)
                            MessageBox.Show("!تکمیل اطلاعات فرم به درستی صورت نپذیرفته است");
                        break;
                }
            }

            if (QUERY.Length > Initial_Len) DtGrid_Fill(QUERY);
        }
        private bool Is_ProductInfo_Complete()
        {
            if (txbx_PR_ID.Text == ""
               || txbx_PR_Model.Text == ""
               || txbx_PR_Name.Text == ""
               || cmbx_PR_Group.SelectedIndex == -1)
                MessageBox.Show("!همه مشخصات کالا برای جستجو وارد نشده است");
            else if ((!(cmbx_Poeple.SelectedIndex == -1)) && (!(cmbx_SearchType.SelectedIndex == -1)))
                return true;

            return false;
        }
        
        private void tlstrip_Exit_Click(object sender, EventArgs e)
        {
            DialogResult rslt = MessageBox.Show("آیا برای خروج اطمینان دارید؟", "خروج", MessageBoxButtons.OKCancel);
            if (rslt == DialogResult.Yes)
                this.Close();
        }

    }
}
