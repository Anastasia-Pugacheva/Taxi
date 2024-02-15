using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Tables
{
    public partial class Drivers : Supportive
    {
        public Drivers()
        {
            InitializeComponent();
        }

        private void водителиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.водителиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.таксопаркDataSet);

        }

        private void Drivers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "таксопаркDataSet.Водители". При необходимости она может быть перемещена или удалена.
            this.водителиTableAdapter.Fill(this.таксопаркDataSet.Водители);

        }

        private void водителиDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Drivers_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            for (int col = 0; col < водителиDataGridView.ColumnCount; col++)
                for (int row = 0; row < водителиDataGridView.RowCount - 1; row++)
                {
                    водителиDataGridView[col, row].Style.BackColor = Color.White;
                    if (водителиDataGridView[col, row].Value.ToString().IndexOf(toolStripTextBox1.Text) >= 0) водителиDataGridView[col, row].Style.BackColor = Color.Red;
                }
        }
    }
}
