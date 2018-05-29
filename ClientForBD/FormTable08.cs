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
    public partial class FormTable08 : Form
    {
        private bool change;

        public FormTable08()
        {
            InitializeComponent();
        }

        private void FormTable08_Load(object sender, EventArgs e)
        {
            this.контактное_лицоTableAdapter.Fill(this.goodsDataSet.Контактное_лицо);
            this.change = false;
        }
                
        private void контактное_лицоBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.контактное_лицоBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.goodsDataSet);
            this.change = false;
        }

        private void FormTable08_FormClosing(object sender, FormClosingEventArgs e)
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
                        this.контактное_лицоBindingSource.EndEdit();
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
            this.контактное_лицоDataGridView.DataSource = "";
        }

        private void контактное_лицоDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            this.change = true;
        }

        private void контактное_лицоDataGridView_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            this.change = true;
        }

        private void контактное_лицоDataGridView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            this.change = true;
        }
    }
}
