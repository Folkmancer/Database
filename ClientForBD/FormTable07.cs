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
    public partial class FormTable07 : Form
    {
        private bool change;

        public FormTable07()
        {
            InitializeComponent();
        }

        private void FormTable07_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "goodsDataSet.HeadDepartmentFD". При необходимости она может быть перемещена или удалена.
            this.headDepartmentFDTableAdapter.Fill(this.goodsDataSet.HeadDepartmentFD);
            this.отдел_маркетингаTableAdapter.Fill(this.goodsDataSet.Отдел_маркетинга);
            this.change = false;
        }
        
        private void отдел_маркетингаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.отдел_маркетингаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.goodsDataSet);
            this.change = false;
        }

        private void FormTable07_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (this.change == true)
                {
                    string message = "Сохранить изменения?";
                    string caption = "Внимание!";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    MessageBoxIcon icon = MessageBoxIcon.Warning;
                    DialogResult result;
                    result = MessageBox.Show(message, caption, buttons, icon);
                    if (result == DialogResult.Yes)
                    {
                        this.Validate();
                        this.отдел_маркетингаBindingSource.EndEdit();
                        this.tableAdapterManager.UpdateAll(this.goodsDataSet);
                        this.change = false;
                    }
                }
            }
            catch
            {
                string message = "Ошибка!";
                string caption = "Ошибка!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons, icon);
            }
            this.отдел_маркетингаDataGridView.DataSource = "";
        }

        private void отдел_маркетингаDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            this.change = true;
        }

        private void отдел_маркетингаDataGridView_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            this.change = true;
        }

        private void отдел_маркетингаDataGridView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            this.change = true;
        }
    }
}