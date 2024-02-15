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
    public partial class Orders : Supportive
    {
        public Orders()
        {
            InitializeComponent();
        }

        private void заказыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.заказыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.таксопаркDataSet);

        }

        private void Orders_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "таксопаркDataSet.Тарифы". При необходимости она может быть перемещена или удалена.
            this.тарифыTableAdapter.Fill(this.таксопаркDataSet.Тарифы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "таксопаркDataSet.Группы_услуг". При необходимости она может быть перемещена или удалена.
            this.группы_услугTableAdapter.Fill(this.таксопаркDataSet.Группы_услуг);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "таксопаркDataSet.Водители". При необходимости она может быть перемещена или удалена.
            this.водителиTableAdapter.Fill(this.таксопаркDataSet.Водители);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "таксопаркDataSet.Заказы". При необходимости она может быть перемещена или удалена.
            this.заказыTableAdapter.Fill(this.таксопаркDataSet.Заказы);

        }

        private void Orders_FormClosed(object sender, FormClosedEventArgs e)
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
            for (int col = 0; col < заказыDataGridView.ColumnCount; col++)
                for (int row = 0; row < заказыDataGridView.RowCount - 1; row++)
                {
                    заказыDataGridView[col, row].Style.BackColor = Color.White;
                    if (заказыDataGridView[col, row].Value.ToString().IndexOf(toolStripTextBox1.Text) >= 0) заказыDataGridView[col, row].Style.BackColor = Color.Red;
                }
        }
    }
}
