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
    public partial class Comfort : Supportive
    {
        public Comfort()
        {
            InitializeComponent();
        }

        private void Comfort_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void комфортBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.комфортBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.таксопаркDataSet);

        }

        private void Comfort_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "таксопаркDataSet.Комфорт". При необходимости она может быть перемещена или удалена.
            this.комфортTableAdapter.Fill(this.таксопаркDataSet.Комфорт);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            for (int col = 0; col < комфортDataGridView.ColumnCount; col++)
                for (int row = 0; row < комфортDataGridView.RowCount - 1; row++)
                {
                    комфортDataGridView[col, row].Style.BackColor = Color.White;
                    if (комфортDataGridView[col, row].Value.ToString().IndexOf(toolStripTextBox1.Text) >= 0) комфортDataGridView[col, row].Style.BackColor = Color.Red;
                }
        }
    }
}
