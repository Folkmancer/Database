namespace ClientForBD
{
    partial class FormTable07
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTable07));
            this.goodsDataSet = new ClientForBD.GoodsDataSet();
            this.отдел_маркетингаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.отдел_маркетингаTableAdapter = new ClientForBD.GoodsDataSetTableAdapters.Отдел_маркетингаTableAdapter();
            this.tableAdapterManager = new ClientForBD.GoodsDataSetTableAdapters.TableAdapterManager();
            this.отдел_маркетингаBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.отдел_маркетингаBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.отдел_маркетингаDataGridView = new System.Windows.Forms.DataGridView();
            this.headDepartmentFDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.headDepartmentFDTableAdapter = new ClientForBD.GoodsDataSetTableAdapters.HeadDepartmentFDTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.goodsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.отдел_маркетингаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.отдел_маркетингаBindingNavigator)).BeginInit();
            this.отдел_маркетингаBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.отдел_маркетингаDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headDepartmentFDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // goodsDataSet
            // 
            this.goodsDataSet.DataSetName = "GoodsDataSet";
            this.goodsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // отдел_маркетингаBindingSource
            // 
            this.отдел_маркетингаBindingSource.DataMember = "Отдел_маркетинга";
            this.отдел_маркетингаBindingSource.DataSource = this.goodsDataSet;
            // 
            // отдел_маркетингаTableAdapter
            // 
            this.отдел_маркетингаTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = ClientForBD.GoodsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АдресTableAdapter = null;
            this.tableAdapterManager.Группа_товаровTableAdapter = null;
            this.tableAdapterManager.Контактное_лицоTableAdapter = null;
            this.tableAdapterManager.Отдел_маркетингаTableAdapter = this.отдел_маркетингаTableAdapter;
            this.tableAdapterManager.Прайс_листTableAdapter = null;
            this.tableAdapterManager.ПредприятиеTableAdapter = null;
            this.tableAdapterManager.Производимый_товарTableAdapter = null;
            this.tableAdapterManager.Руководитель_отдела_маркетингаTableAdapter = null;
            this.tableAdapterManager.Руководитель_предприятияTableAdapter = null;
            this.tableAdapterManager.Тип_товараTableAdapter = null;
            this.tableAdapterManager.ТоварTableAdapter = null;
            // 
            // отдел_маркетингаBindingNavigator
            // 
            this.отдел_маркетингаBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.отдел_маркетингаBindingNavigator.BindingSource = this.отдел_маркетингаBindingSource;
            this.отдел_маркетингаBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.отдел_маркетингаBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.отдел_маркетингаBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.отдел_маркетингаBindingNavigatorSaveItem});
            this.отдел_маркетингаBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.отдел_маркетингаBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.отдел_маркетингаBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.отдел_маркетингаBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.отдел_маркетингаBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.отдел_маркетингаBindingNavigator.Name = "отдел_маркетингаBindingNavigator";
            this.отдел_маркетингаBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.отдел_маркетингаBindingNavigator.Size = new System.Drawing.Size(536, 25);
            this.отдел_маркетингаBindingNavigator.TabIndex = 0;
            this.отдел_маркетингаBindingNavigator.Text = "bindingNavigator1";
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
            // отдел_маркетингаBindingNavigatorSaveItem
            // 
            this.отдел_маркетингаBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.отдел_маркетингаBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("отдел_маркетингаBindingNavigatorSaveItem.Image")));
            this.отдел_маркетингаBindingNavigatorSaveItem.Name = "отдел_маркетингаBindingNavigatorSaveItem";
            this.отдел_маркетингаBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.отдел_маркетингаBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.отдел_маркетингаBindingNavigatorSaveItem.Click += new System.EventHandler(this.отдел_маркетингаBindingNavigatorSaveItem_Click);
            // 
            // отдел_маркетингаDataGridView
            // 
            this.отдел_маркетингаDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.отдел_маркетингаDataGridView.AutoGenerateColumns = false;
            this.отдел_маркетингаDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.отдел_маркетингаDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.отдел_маркетингаDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewComboBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.отдел_маркетингаDataGridView.DataSource = this.отдел_маркетингаBindingSource;
            this.отдел_маркетингаDataGridView.Location = new System.Drawing.Point(12, 28);
            this.отдел_маркетингаDataGridView.Name = "отдел_маркетингаDataGridView";
            this.отдел_маркетингаDataGridView.Size = new System.Drawing.Size(512, 265);
            this.отдел_маркетингаDataGridView.TabIndex = 1;
            this.отдел_маркетингаDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.отдел_маркетингаDataGridView_CellValueChanged);
            this.отдел_маркетингаDataGridView.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.отдел_маркетингаDataGridView_UserAddedRow);
            this.отдел_маркетингаDataGridView.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.отдел_маркетингаDataGridView_UserDeletedRow);
            // 
            // headDepartmentFDBindingSource
            // 
            this.headDepartmentFDBindingSource.DataMember = "HeadDepartmentFD";
            this.headDepartmentFDBindingSource.DataSource = this.goodsDataSet;
            // 
            // headDepartmentFDTableAdapter
            // 
            this.headDepartmentFDTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код_отдела_маркетинга";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewComboBoxColumn2
            // 
            this.dataGridViewComboBoxColumn2.DataPropertyName = "Код_руководителя_маркетинга";
            this.dataGridViewComboBoxColumn2.DataSource = this.headDepartmentFDBindingSource;
            this.dataGridViewComboBoxColumn2.DisplayMember = "ФИО";
            this.dataGridViewComboBoxColumn2.HeaderText = "Руководитель";
            this.dataGridViewComboBoxColumn2.Name = "dataGridViewComboBoxColumn2";
            this.dataGridViewComboBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewComboBoxColumn2.ValueMember = "Код_руководителя_маркетинга";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Номер_телефона";
            this.dataGridViewTextBoxColumn3.HeaderText = "Номер телефона";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // FormTable07
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 305);
            this.Controls.Add(this.отдел_маркетингаDataGridView);
            this.Controls.Add(this.отдел_маркетингаBindingNavigator);
            this.Name = "FormTable07";
            this.Text = "Отдел маркетинга";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTable07_FormClosing);
            this.Load += new System.EventHandler(this.FormTable07_Load);
            ((System.ComponentModel.ISupportInitialize)(this.goodsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.отдел_маркетингаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.отдел_маркетингаBindingNavigator)).EndInit();
            this.отдел_маркетингаBindingNavigator.ResumeLayout(false);
            this.отдел_маркетингаBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.отдел_маркетингаDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headDepartmentFDBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GoodsDataSet goodsDataSet;
        private System.Windows.Forms.BindingSource отдел_маркетингаBindingSource;
        private GoodsDataSetTableAdapters.Отдел_маркетингаTableAdapter отдел_маркетингаTableAdapter;
        private GoodsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator отдел_маркетингаBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton отдел_маркетингаBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView отдел_маркетингаDataGridView;
        private System.Windows.Forms.BindingSource headDepartmentFDBindingSource;
        private GoodsDataSetTableAdapters.HeadDepartmentFDTableAdapter headDepartmentFDTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}