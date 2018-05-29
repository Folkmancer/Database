using System;
using System.Windows.Forms;

namespace ClientForBD
{
    public partial class FormTable09 : Form
    {
        private bool change;

        public FormTable09()
        {
            InitializeComponent();
        }

        private void FormTable09_Load(object sender, EventArgs e)
        {
            this.addressEnterpriseTableAdapter.Fill(this.goodsDataSet.AddressEnterprise);
            this.contactPersonTableAdapter.Fill(this.goodsDataSet.ContactPerson);
            this.headDepartmentTableAdapter.Fill(this.goodsDataSet.HeadDepartment);
            this.headEnterpriseTableAdapter.Fill(this.goodsDataSet.HeadEnterprise);
            this.headEnterpriseTableAdapter.Fill(this.goodsDataSet.HeadEnterprise);
            this.предприятиеTableAdapter.Fill(this.goodsDataSet.Предприятие);
            this.change = false;
        }
        
        private void предприятиеBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.предприятиеBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.goodsDataSet);
            this.change = false;
        }

        private void FormTable09_FormClosing(object sender, FormClosingEventArgs e)
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
                        this.предприятиеBindingSource.EndEdit();
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
            this.предприятиеDataGridView.DataSource = "";
        }

        private void предприятиеDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            this.change = true;
        }

        private void предприятиеDataGridView_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            this.change = true;
        }

        private void предприятиеDataGridView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            this.change = true;
        }
    }
}
