using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientForBD
{
    public partial class FormQuery2 : Form
    {
        public FormQuery2()
        {
            InitializeComponent();
            this.toolStripComboBox1.ComboBox.DataSource = this.товарBindingSource;
            this.toolStripComboBox1.ComboBox.DisplayMember = "Наименование";
            this.toolStripComboBox1.ComboBox.ValueMember = "Код_товара";
        }

        private void FillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.goodsEnterprisesTableAdapter.Fill(this.goodsDataSet.GoodsEnterprises, toolStripComboBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormQuery2_Load(object sender, EventArgs e)
        {
            this.товарTableAdapter.Fill(this.goodsDataSet.Товар);
        }
    }
}
