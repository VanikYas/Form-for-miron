using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void avtomobilBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.avtomobilBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lada_AvtosalonDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lada_AvtosalonDataSet.Customer". При необходимости она может быть перемещена или удалена.
            this.customerTableAdapter.Fill(this.lada_AvtosalonDataSet.Customer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lada_AvtosalonDataSet.Deal". При необходимости она может быть перемещена или удалена.
            this.dealTableAdapter.Fill(this.lada_AvtosalonDataSet.Deal);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lada_AvtosalonDataSet.Avtomobil". При необходимости она может быть перемещена или удалена.
            this.avtomobilTableAdapter.Fill(this.lada_AvtosalonDataSet.Avtomobil);

        }

        private void avtomobilDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void customerDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dealDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            avtomobilTableAdapter.Update(lada_AvtosalonDataSet);
            dealTableAdapter.Update(lada_AvtosalonDataSet);
            customerTableAdapter.Update(lada_AvtosalonDataSet);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void dealDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.customerTableAdapter.FillBy(this.lada_AvtosalonDataSet.Customer);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
