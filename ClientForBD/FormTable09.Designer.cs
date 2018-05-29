namespace ClientForBD
{
    partial class FormTable09
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTable09));
            this.goodsDataSet = new ClientForBD.GoodsDataSet();
            this.предприятиеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.предприятиеTableAdapter = new ClientForBD.GoodsDataSetTableAdapters.ПредприятиеTableAdapter();
            this.tableAdapterManager = new ClientForBD.GoodsDataSetTableAdapters.TableAdapterManager();
            this.предприятиеBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.предприятиеBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.предприятиеDataGridView = new System.Windows.Forms.DataGridView();
            this.headEnterpriseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.headEnterpriseTableAdapter = new ClientForBD.GoodsDataSetTableAdapters.HeadEnterpriseTableAdapter();
            this.headDepartmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.headDepartmentTableAdapter = new ClientForBD.GoodsDataSetTableAdapters.HeadDepartmentTableAdapter();
            this.contactPersonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactPersonTableAdapter = new ClientForBD.GoodsDataSetTableAdapters.ContactPersonTableAdapter();
            this.addressEnterpriseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addressEnterpriseTableAdapter = new ClientForBD.GoodsDataSetTableAdapters.AddressEnterpriseTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewComboBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewComboBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewComboBoxColumn5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.goodsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.предприятиеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.предприятиеBindingNavigator)).BeginInit();
            this.предприятиеBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.предприятиеDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headEnterpriseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headDepartmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactPersonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressEnterpriseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // goodsDataSet
            // 
            this.goodsDataSet.DataSetName = "GoodsDataSet";
            this.goodsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // предприятиеBindingSource
            // 
            this.предприятиеBindingSource.DataMember = "Предприятие";
            this.предприятиеBindingSource.DataSource = this.goodsDataSet;
            // 
            // предприятиеTableAdapter
            // 
            this.предприятиеTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = ClientForBD.GoodsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АдресTableAdapter = null;
            this.tableAdapterManager.Группа_товаровTableAdapter = null;
            this.tableAdapterManager.Контактное_лицоTableAdapter = null;
            this.tableAdapterManager.Отдел_маркетингаTableAdapter = null;
            this.tableAdapterManager.Прайс_листTableAdapter = null;
            this.tableAdapterManager.ПредприятиеTableAdapter = this.предприятиеTableAdapter;
            this.tableAdapterManager.Производимый_товарTableAdapter = null;
            this.tableAdapterManager.Руководитель_отдела_маркетингаTableAdapter = null;
            this.tableAdapterManager.Руководитель_предприятияTableAdapter = null;
            this.tableAdapterManager.Тип_товараTableAdapter = null;
            this.tableAdapterManager.ТоварTableAdapter = null;
            // 
            // предприятиеBindingNavigator
            // 
            this.предприятиеBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.предприятиеBindingNavigator.BindingSource = this.предприятиеBindingSource;
            this.предприятиеBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.предприятиеBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.предприятиеBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.предприятиеBindingNavigatorSaveItem});
            this.предприятиеBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.предприятиеBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.предприятиеBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.предприятиеBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.предприятиеBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.предприятиеBindingNavigator.Name = "предприятиеBindingNavigator";
            this.предприятиеBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.предприятиеBindingNavigator.Size = new System.Drawing.Size(1054, 25);
            this.предприятиеBindingNavigator.TabIndex = 0;
            this.предприятиеBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // предприятиеBindingNavigatorSaveItem
            // 
            this.предприятиеBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.предприятиеBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("предприятиеBindingNavigatorSaveItem.Image")));
            this.предприятиеBindingNavigatorSaveItem.Name = "предприятиеBindingNavigatorSaveItem";
            this.предприятиеBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.предприятиеBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.предприятиеBindingNavigatorSaveItem.Click += new System.EventHandler(this.предприятиеBindingNavigatorSaveItem_Click);
            // 
            // предприятиеDataGridView
            // 
            this.предприятиеDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.предприятиеDataGridView.AutoGenerateColumns = false;
            this.предприятиеDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.предприятиеDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.предприятиеDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewComboBoxColumn2,
            this.dataGridViewComboBoxColumn3,
            this.dataGridViewComboBoxColumn4,
            this.dataGridViewComboBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.предприятиеDataGridView.DataSource = this.предприятиеBindingSource;
            this.предприятиеDataGridView.Location = new System.Drawing.Point(12, 28);
            this.предприятиеDataGridView.Name = "предприятиеDataGridView";
            this.предприятиеDataGridView.Size = new System.Drawing.Size(1030, 387);
            this.предприятиеDataGridView.TabIndex = 1;
            this.предприятиеDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.предприятиеDataGridView_CellValueChanged);
            this.предприятиеDataGridView.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.предприятиеDataGridView_UserAddedRow);
            this.предприятиеDataGridView.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.предприятиеDataGridView_UserDeletedRow);
            // 
            // headEnterpriseBindingSource
            // 
            this.headEnterpriseBindingSource.DataMember = "HeadEnterprise";
            this.headEnterpriseBindingSource.DataSource = this.goodsDataSet;
            // 
            // headEnterpriseTableAdapter
            // 
            this.headEnterpriseTableAdapter.ClearBeforeFill = true;
            // 
            // headDepartmentBindingSource
            // 
            this.headDepartmentBindingSource.DataMember = "HeadDepartment";
            this.headDepartmentBindingSource.DataSource = this.goodsDataSet;
            // 
            // headDepartmentTableAdapter
            // 
            this.headDepartmentTableAdapter.ClearBeforeFill = true;
            // 
            // contactPersonBindingSource
            // 
            this.contactPersonBindingSource.DataMember = "ContactPerson";
            this.contactPersonBindingSource.DataSource = this.goodsDataSet;
            // 
            // contactPersonTableAdapter
            // 
            this.contactPersonTableAdapter.ClearBeforeFill = true;
            // 
            // addressEnterpriseBindingSource
            // 
            this.addressEnterpriseBindingSource.DataMember = "AddressEnterprise";
            this.addressEnterpriseBindingSource.DataSource = this.goodsDataSet;
            // 
            // addressEnterpriseTableAdapter
            // 
            this.addressEnterpriseTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код_предприятия";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewComboBoxColumn2
            // 
            this.dataGridViewComboBoxColumn2.DataPropertyName = "Код_руководителя";
            this.dataGridViewComboBoxColumn2.DataSource = this.headEnterpriseBindingSource;
            this.dataGridViewComboBoxColumn2.DisplayMember = "ФИО";
            this.dataGridViewComboBoxColumn2.HeaderText = "Руководитель";
            this.dataGridViewComboBoxColumn2.Name = "dataGridViewComboBoxColumn2";
            this.dataGridViewComboBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewComboBoxColumn2.ValueMember = "Код_руководителя";
            // 
            // dataGridViewComboBoxColumn3
            // 
            this.dataGridViewComboBoxColumn3.DataPropertyName = "Код_отдела_маркетинга";
            this.dataGridViewComboBoxColumn3.DataSource = this.headDepartmentBindingSource;
            this.dataGridViewComboBoxColumn3.DisplayMember = "ФИО";
            this.dataGridViewComboBoxColumn3.HeaderText = "Отдел маркетинга";
            this.dataGridViewComboBoxColumn3.Name = "dataGridViewComboBoxColumn3";
            this.dataGridViewComboBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewComboBoxColumn3.ValueMember = "Код_отдела_маркетинга";
            // 
            // dataGridViewComboBoxColumn4
            // 
            this.dataGridViewComboBoxColumn4.DataPropertyName = "Код_контактного_лица";
            this.dataGridViewComboBoxColumn4.DataSource = this.contactPersonBindingSource;
            this.dataGridViewComboBoxColumn4.DisplayMember = "ФИО";
            this.dataGridViewComboBoxColumn4.HeaderText = "Контактное лицо";
            this.dataGridViewComboBoxColumn4.Name = "dataGridViewComboBoxColumn4";
            this.dataGridViewComboBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewComboBoxColumn4.ValueMember = "Код_контактного_лица";
            // 
            // dataGridViewComboBoxColumn5
            // 
            this.dataGridViewComboBoxColumn5.DataPropertyName = "Код_адреса";
            this.dataGridViewComboBoxColumn5.DataSource = this.addressEnterpriseBindingSource;
            this.dataGridViewComboBoxColumn5.DisplayMember = "Полный адрес";
            this.dataGridViewComboBoxColumn5.HeaderText = "Адрес";
            this.dataGridViewComboBoxColumn5.Name = "dataGridViewComboBoxColumn5";
            this.dataGridViewComboBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewComboBoxColumn5.ValueMember = "Код_адреса";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Наименование";
            this.dataGridViewTextBoxColumn6.HeaderText = "Наименование";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Дата_регистрации";
            this.dataGridViewTextBoxColumn7.HeaderText = "Дата регистрации";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Номер_телефона";
            this.dataGridViewTextBoxColumn8.HeaderText = "Номер телефона";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // FormTable09
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 427);
            this.Controls.Add(this.предприятиеDataGridView);
            this.Controls.Add(this.предприятиеBindingNavigator);
            this.Name = "FormTable09";
            this.Text = "Предприятие";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTable09_FormClosing);
            this.Load += new System.EventHandler(this.FormTable09_Load);
            ((System.ComponentModel.ISupportInitialize)(this.goodsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.предприятиеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.предприятиеBindingNavigator)).EndInit();
            this.предприятиеBindingNavigator.ResumeLayout(false);
            this.предприятиеBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.предприятиеDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headEnterpriseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headDepartmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactPersonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressEnterpriseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GoodsDataSet goodsDataSet;
        private System.Windows.Forms.BindingSource предприятиеBindingSource;
        private GoodsDataSetTableAdapters.ПредприятиеTableAdapter предприятиеTableAdapter;
        private GoodsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator предприятиеBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton предприятиеBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView предприятиеDataGridView;
        private System.Windows.Forms.BindingSource headEnterpriseBindingSource;
        private GoodsDataSetTableAdapters.HeadEnterpriseTableAdapter headEnterpriseTableAdapter;
        private System.Windows.Forms.BindingSource headDepartmentBindingSource;
        private GoodsDataSetTableAdapters.HeadDepartmentTableAdapter headDepartmentTableAdapter;
        private System.Windows.Forms.BindingSource contactPersonBindingSource;
        private GoodsDataSetTableAdapters.ContactPersonTableAdapter contactPersonTableAdapter;
        private System.Windows.Forms.BindingSource addressEnterpriseBindingSource;
        private GoodsDataSetTableAdapters.AddressEnterpriseTableAdapter addressEnterpriseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}