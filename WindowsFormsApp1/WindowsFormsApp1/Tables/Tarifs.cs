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
    public partial class Tarifs : Supportive
    {
        public Tarifs()
        {
            InitializeComponent();
        }

        private void тарифыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.тарифыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.таксопаркDataSet);

        }

        private void Tarifs_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "таксопаркDataSet.Тарифы". При необходимости она может быть перемещена или удалена.
            this.тарифыTableAdapter.Fill(this.таксопаркDataSet.Тарифы);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void Tarifs_FormClosed(object sender, FormClosedEventArgs e)
        {
           Application.Exit();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            for (int col = 0; col < тарифыDataGridView.ColumnCount; col++)
                for (int row = 0; row < тарифыDataGridView.RowCount - 1; row++)
                {
                    тарифыDataGridView[col, row].Style.BackColor = Color.White;
                    if (тарифыDataGridView[col, row].Value.ToString().IndexOf(toolStripTextBox1.Text) >= 0) тарифыDataGridView[col, row].Style.BackColor = Color.Red;
                }
        }
    }
}
