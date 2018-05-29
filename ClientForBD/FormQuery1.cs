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
    public partial class FormQuery1 : Form
    {
        public FormQuery1()
        {
            InitializeComponent();
        }

        private void FormQuery1_Load(object sender, EventArgs e)
        {
            this.предприятиеTableAdapter.Fill(this.goodsDataSet.Предприятие);
            this.toolStripComboBox1.ComboBox.DataSource = this.предприятиеBindingSource;
            this.toolStripComboBox1.ComboBox.DisplayMember = "Наименование";
            this.toolStripComboBox1.ComboBox.ValueMember = "Код_предприятия";
        }

        private void FillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.enterprisesGoodsTableAdapter.Fill(this.goodsDataSet.EnterprisesGoods, this.toolStripComboBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }        
    }
}
