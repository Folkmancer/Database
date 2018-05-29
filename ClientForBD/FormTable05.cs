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
    public partial class FormTable05 : Form
    {
        private bool change;

        public FormTable05()
        {
            InitializeComponent();
        }

        private void FormTable05_Load(object sender, EventArgs e)
        {
            this.руководитель_предприятияTableAdapter.Fill(this.goodsDataSet.Руководитель_предприятия);
            this.change = false;
        }
        
        private void руководитель_предприятияBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.руководитель_предприятияBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.goodsDataSet);
            this.change = false;
        }

        private void FormTable05_FormClosing(object sender, FormClosingEventArgs e)
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
                        this.руководитель_предприятияBindingSource.EndEdit();
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
            this.руководитель_предприятияDataGridView.DataSource = "";
        }

        private void руководитель_предприятияDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            this.change = true;
        }

        private void руководитель_предприятияDataGridView_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            this.change = true;
        }

        private void руководитель_предприятияDataGridView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            this.change = true;
        }
    }
}
