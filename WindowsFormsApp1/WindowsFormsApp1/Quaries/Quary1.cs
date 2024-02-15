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
    public partial class Quary1 : Supportive
    {
        public Quary1()
        {
            InitializeComponent();
        }

        private void Quary1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "таксопаркDataSet.Запрос1". При необходимости она может быть перемещена или удалена.
            this.запрос1TableAdapter.Fill(this.таксопаркDataSet.Запрос1);

        }

        private void Quary1_FormClosed(object sender, FormClosedEventArgs e)
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

                for(int i =0; i<запрос1DataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j< запрос1DataGridView.ColumnCount;j++)
                    {
                        Excelapp.Cells[i + 1, j + 1] = запрос1DataGridView.Rows[i].Cells[j].Value;
                    }
                }
                Excelapp.Visible = true;
                Excelapp.UserControl = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка" + ex);
            }
        }

        private void запрос1DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            for (int col = 0; col < запрос1DataGridView.ColumnCount; col++)
                for (int row = 0; row < запрос1DataGridView.RowCount - 1; row++)
                {
                    запрос1DataGridView[col, row].Style.BackColor = Color.White;
                    if (запрос1DataGridView[col, row].Value.ToString().IndexOf(toolStripTextBox1.Text) >= 0) запрос1DataGridView[col, row].Style.BackColor = Color.Red;
                }
        }
    }
}
