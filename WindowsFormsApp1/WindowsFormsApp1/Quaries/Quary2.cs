using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;


namespace WindowsFormsApp1.Quaries
{
    public partial class Quary2 : Supportive
    {
        public Quary2()
        {
            InitializeComponent();
        }

        private void Quary2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "таксопаркDataSet.Запрос2". При необходимости она может быть перемещена или удалена.
            this.запрос2TableAdapter.Fill(this.таксопаркDataSet.Запрос2);

        }

        private void Quary2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Excel.Application Excelapp = new Excel.Application();
                Excel.Workbook workbook;
                Excel.Worksheet worksheet;

                workbook = Excelapp.Workbooks.Add(System.Reflection.Missing.Value);
                worksheet = (Excel.Worksheet)workbook.Worksheets.get_Item(1);
                
                for (int i = 0; i < запрос2DataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < запрос2DataGridView.ColumnCount; j++)
                    {
                        Excelapp.Cells[i + 1, j + 1] = запрос2DataGridView.Rows[i].Cells[j].Value;
                    }
                }
                Excelapp.Visible = true;
                Excelapp.UserControl = true;
            }
            catch (ApplicationException aEx)
            {
                MessageBox.Show("Ошибка приложения: " + aEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            for (int col = 0; col < запрос2DataGridView.ColumnCount; col++)
                for (int row = 0; row < запрос2DataGridView.RowCount - 1; row++)
                {
                    запрос2DataGridView[col, row].Style.BackColor = Color.White;
                    if (запрос2DataGridView[col, row].Value.ToString().IndexOf(toolStripTextBox1.Text) >= 0) запрос2DataGridView[col, row].Style.BackColor = Color.Red;
                }
        }
    }
}
