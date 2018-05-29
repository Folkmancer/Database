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
    public partial class FormTable11 : Form
    {
        private bool change;

        public FormTable11()
        {
            InitializeComponent();
        }

        private void FormTable11_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "goodsDataSet.GoodsName". При необходимости она может быть перемещена или удалена.
            this.goodsNameTableAdapter.Fill(this.goodsDataSet.GoodsName);
            this.прайс_листTableAdapter.Fill(this.goodsDataSet._Прайс_лист);
            this.change = false;
        }
        
        private void прайс_листBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.прайс_листBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.goodsDataSet);
                this.change = false;
            }
            catch (System.Data.SqlClient.SqlException)
            {
                string message = "Цена не может быть отрицательной!";
                string caption = "Ошибка!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons, icon);
            }
            catch (DataException Error)
            {
                string message = "Ошибка данных!" + Error.Message.ToString();
                string caption = "Ошибка!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons, icon);
            }
        }

        private void FormTable11_FormClosing(object sender, FormClosingEventArgs e)
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
                        this.прайс_листBindingSource.EndEdit();
                        this.tableAdapterManager.UpdateAll(this.goodsDataSet);
                        this.change = false;
                    }
                }
            }
            catch (System.Data.SqlClient.SqlException)
            {
                string message = "Цена не может быть отрицательной!";
                string caption = "Ошибка!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons, icon);
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
            this.прайс_листDataGridView.DataSource = "";
        }

        private void прайс_листDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            this.change = true;
        }

        private void прайс_листDataGridView_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            this.change = true;
        }

        private void прайс_листDataGridView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            this.change = true;
        }
    }
}
