using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Office.Interop.Excel;
using System.Diagnostics;
using System.Data.SqlClient;

namespace Control_Industrial_Processes
{
    public partial class Debriefing : Form
    {
        string connString = @"Data Source=DESKTOP-21H6HAU\DESKTOP;Initial Catalog=Industrial;Integrated Security=True;
            Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        SqlDataAdapter dataAdapter;
        System.Data.DataTable table;
        SqlConnection conn;
        string selectionStatement = "Select * from Efficiency";
        public Debriefing()
        {
            InitializeComponent();
        }

        private void Debriefing_Load(object sender, EventArgs e)
        {
            cboSearch.SelectedIndex = 0;
            dataGridView1.DataSource = bindingSource2;
            GetData(selectionStatement);
            
        }
        private void GetData(string selectCommand)
        {
            try
            {
                dataAdapter = new SqlDataAdapter(selectCommand, connString);
                table = new System.Data.DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                bindingSource2.DataSource = table;
                dataGridView1.Columns[0].ReadOnly = true;

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);

            }

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            switch (cboSearch.SelectedItem.ToString())
            {
                case "Power":
                    GetData("select * from Efficiency where lower(power) like '%" + txtSearch.Text.ToLower() + "%'");
                    break;
                case "Date":
                    GetData("select * from Efficiency where lower(Date) like '%" + txtSearch.Text.ToLower() + "%'");
                    break;
            }
        }

        private void btnExportOpen_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            _Workbook workbook = excel.Workbooks.Add(Type.Missing);
            _Worksheet worksheet = null;
            try
            {
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Efficiency";
                for (int rowIndex = 0; rowIndex < dataGridView1.Rows.Count - 1; rowIndex++)
                {
                    for (int colIndex = 0; colIndex < dataGridView1.Columns.Count; colIndex++)
                    {
                        if (rowIndex == 0)
                        {
                            worksheet.Cells[rowIndex + 1, colIndex + 1] = dataGridView1.Columns[colIndex].HeaderText;
                        }
                        else
                        {
                            worksheet.Cells[rowIndex + 1, colIndex + 1] = dataGridView1.Rows[rowIndex].Cells[colIndex].Value.ToString();
                        }
                    }

                }
                if (SFDG2.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(SFDG2.FileName);
                    Process.Start("excel.exe", SFDG2.FileName);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                excel.Quit();
                workbook = null;
                excel = null;

            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            chart1.Series["Power"].XValueMember = "Power";
            chart1.Series["Power"].YValueMembers = "Gas";
            chart1.DataSource = dataAdapter;
            chart1.DataBind();

        }
    }
}
