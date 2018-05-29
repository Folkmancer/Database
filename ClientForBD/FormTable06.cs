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
    public partial class FormTable06 : Form
    {
        private bool change;

        public FormTable06()
        {
            InitializeComponent();
        }

        private void FormTable06_Load(object sender, EventArgs e)
        {
            this.руководитель_отдела_маркетингаTableAdapter.Fill(this.goodsDataSet.Руководитель_отдела_маркетинга);
            this.change = false;
        }
        
        private void руководитель_отдела_маркетингаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.руководитель_отдела_маркетингаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.goodsDataSet);
            this.change = false;
        }

        private void FormTable06_FormClosing(object sender, FormClosingEventArgs e)
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
                        this.руководитель_отдела_маркетингаBindingSource.EndEdit();
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
            this.руководитель_отдела_маркетингаDataGridView.DataSource = "";
        }

        private void руководитель_отдела_маркетингаDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            this.change = true;
        }

        private void руководитель_отдела_маркетингаDataGridView_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            this.change = true;
        }

        private void руководитель_отдела_маркетингаDataGridView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            this.change = true;
        }
    }
}
