using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //string sqlQuery = string.Format($"SELECT * FROM [{0}]", sheetName);
        private readonly List<string> lecturersTables = new List<string>() { "ID", "First_Name", "Last_Name", "Subjects_ID" };

        private readonly List<string> subjectsTables = new List<string>() { "ID", "Name", "Lecturers_ID" };

        private const string CONNECTION_STRING = @"provider = Microsoft.ACE.OLEDB.12.0; 
                            data source = F:\Учеба\Мое\C#\Laba7\Data.xlsx; 
                            Extended Properties = 'Excel 12.0'";
        public Form1()
        {
            InitializeComponent();

            cbSheetsForUpdate.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTables.DropDownStyle = ComboBoxStyle.DropDownList;
            cbChangingValue.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSheetsForInsert.DropDownStyle = ComboBoxStyle.DropDownList;

            cbSheetsForUpdate.SelectedIndexChanged += CbSheets_SelectedIndexChanged;
            cbTables.SelectedIndexChanged += CbTables_SelectedIndexChanged;
            cbSheetsForInsert.SelectedIndexChanged += CbSheetsForInsert_SelectedIndexChanged;

            btOutputData.Click += OutputData;
            btUpdateData.Click += UpdateData;
            btInsertData.Click += BtAddData_Click;
        }

        private void BtAddData_Click(object sender, EventArgs e)
        {
            if (cbSheetsForInsert.SelectedIndex == 0)
                ExecuteQuery($"Insert into [{cbSheetsForInsert.SelectedItem}] (ID, First_Name, Last_Name, Subjects_ID) values({tbIDInsert.Text}, '{tbNameInsert.Text}', '{tbLastNameInsert.Text}', {tbSubjectsInsert.Text})");
            else
                ExecuteQuery($"Insert into [{cbSheetsForInsert.SelectedItem}] (ID, Name, Lecturers_ID) values({tbIDInsert.Text}, '{tbNameInsert.Text}', {tbLecturersInsert.Text})");

            MessageBox.Show("Данные успешно добавлены!", "Успех!", MessageBoxButtons.OK);
        }

        private void UpdateData(object sender, EventArgs e)
        {
            if (cbTables.SelectedItem.ToString().Contains("ID"))
                ExecuteQuery($"Update [{cbSheetsForUpdate.SelectedItem}] set {cbTables.SelectedItem} = '{tbNewValue.Text}' where {cbTables.SelectedItem}={cbChangingValue.SelectedItem}");
            else
                ExecuteQuery($"Update [{cbSheetsForUpdate.SelectedItem}] set {cbTables.SelectedItem} = '{tbNewValue.Text}' where {cbTables.SelectedItem}='{cbChangingValue.SelectedItem}'");          

            MessageBox.Show("Данные успешно обновлены!", "Успех!", MessageBoxButtons.OK);
        }



        private void CbSheetsForInsert_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Control> lecturersElements = new List<Control>() { tbIDInsert, tbNameInsert, tbLastNameInsert,
                    tbSubjectsInsert, labelIDInsert, labelNameInsert, labelLastNameInsert, labelSubjectsInsert};
            List<Control> subjectsElements = new List<Control>() { tbIDInsert, tbNameInsert,
                tbLecturersInsert, labelIDInsert, labelNameInsert, labelLecturersInsert};
            if (cbSheetsForInsert.SelectedIndex == 0)
            {
                foreach (Control element in subjectsElements)
                    element.Visible = false;
                foreach (Control element in lecturersElements)
                    element.Visible = true;
            }
            else
            {
                foreach (Control element in lecturersElements)
                    element.Visible = false;
                foreach (Control element in subjectsElements)
                    element.Visible = true;
            }
        }

        private void CbTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbChangingValue.Items.Clear();

            DataSet dataset = LoadSheetData(new List<string>() { cbSheetsForUpdate.SelectedItem.ToString() },
                                                     cbTables.SelectedItem.ToString());
            DataTable dataTable = dataset.Tables[0];
            foreach (DataRow row in dataTable.Rows)
                cbChangingValue.Items.Add(row.ItemArray[0].ToString());
        }

        private void CbSheets_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbTables.Items.Clear();
            List<string> tables = cbSheetsForUpdate.SelectedIndex == 0 ? lecturersTables : subjectsTables;
            foreach (string table in tables)
                cbTables.Items.Add(table);
        }



        private void OutputData(object sender, EventArgs e)
        {
            List<string> sheetNames = GetExcelSheetNames();
            DataSet dtAllSheets = LoadSheetData(sheetNames);
            dgvLecturers.DataSource = dtAllSheets.Tables[0];
            dgvSubjects.DataSource = dtAllSheets.Tables[1];
        }

        public DataSet LoadSheetData(List<string> sheetNames, string tableName = "*")
        {
            DataSet dataSet = new DataSet();
            foreach (string sheetName in sheetNames)
            {
                OleDbConnection oleDbConnection = new OleDbConnection(CONNECTION_STRING);
                DataTable dataTable = new DataTable();
                string sqlQuery = $"SELECT {tableName} FROM [{sheetName}]";
                oleDbConnection.Open();
                OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(sqlQuery, oleDbConnection);
                oleDbDataAdapter.Fill(dataTable);
                dataSet.Tables.Add(dataTable);
                oleDbConnection.Close();
            }
            return dataSet;
        }

        List<string> GetExcelSheetNames()
        {
            OleDbConnection oleDbConnection = new OleDbConnection(CONNECTION_STRING);
            oleDbConnection.Open();
            DataTable dataTable = new DataTable();
            dataTable = oleDbConnection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
            oleDbConnection.Close();
            List<string> sheetNames = new List<string>();
            foreach (DataRow row in dataTable.Rows)
            {
                sheetNames.Add(row["TABLE_NAME"].ToString());
            }
            return sheetNames;
        }



        private void ExecuteQuery(string sqlStatement)
        {
            OleDbConnection oleDbConnection = new OleDbConnection(CONNECTION_STRING);
            oleDbConnection.Open();
            OleDbCommand oleDbCommand = new OleDbCommand();
            oleDbCommand.Connection = oleDbConnection;
            oleDbCommand.CommandText = sqlStatement;
            oleDbCommand.ExecuteNonQuery();
            oleDbConnection.Close();
        }
    }
}
