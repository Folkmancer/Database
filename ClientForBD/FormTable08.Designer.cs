namespace ClientForBD
{
    partial class FormTable08
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTable08));
            this.goodsDataSet = new ClientForBD.GoodsDataSet();
            this.контактное_лицоBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.контактное_лицоTableAdapter = new ClientForBD.GoodsDataSetTableAdapters.Контактное_лицоTableAdapter();
            this.tableAdapterManager = new ClientForBD.GoodsDataSetTableAdapters.TableAdapterManager();
            this.контактное_лицоBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.контактное_лицоBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.контактное_лицоDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.goodsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.контактное_лицоBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.контактное_лицоBindingNavigator)).BeginInit();
            this.контактное_лицоBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.контактное_лицоDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // goodsDataSet
            // 
            this.goodsDataSet.DataSetName = "GoodsDataSet";
            this.goodsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // контактное_лицоBindingSource
            // 
            this.контактное_лицоBindingSource.DataMember = "Контактное_лицо";
            this.контактное_лицоBindingSource.DataSource = this.goodsDataSet;
            // 
            // контактное_лицоTableAdapter
            // 
            this.контактное_лицоTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = ClientForBD.GoodsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АдресTableAdapter = null;
            this.tableAdapterManager.Группа_товаровTableAdapter = null;
            this.tableAdapterManager.Контактное_лицоTableAdapter = this.контактное_лицоTableAdapter;
            this.tableAdapterManager.Отдел_маркетингаTableAdapter = null;
            this.tableAdapterManager.Прайс_листTableAdapter = null;
            this.tableAdapterManager.ПредприятиеTableAdapter = null;
            this.tableAdapterManager.Производимый_товарTableAdapter = null;
            this.tableAdapterManager.Руководитель_отдела_маркетингаTableAdapter = null;
            this.tableAdapterManager.Руководитель_предприятияTableAdapter = null;
            this.tableAdapterManager.Тип_товараTableAdapter = null;
            this.tableAdapterManager.ТоварTableAdapter = null;
            // 
            // контактное_лицоBindingNavigator
            // 
            this.контактное_лицоBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.контактное_лицоBindingNavigator.BindingSource = this.контактное_лицоBindingSource;
            this.контактное_лицоBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.контактное_лицоBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.контактное_лицоBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.контактное_лицоBindingNavigatorSaveItem});
            this.контактное_лицоBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.контактное_лицоBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.контактное_лицоBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.контактное_лицоBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.контактное_лицоBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.контактное_лицоBindingNavigator.Name = "контактное_лицоBindingNavigator";
            this.контактное_лицоBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.контактное_лицоBindingNavigator.Size = new System.Drawing.Size(520, 25);
            this.контактное_лицоBindingNavigator.TabIndex = 0;
            this.контактное_лицоBindingNavigator.Text = "bindingNavigator1";
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
            // контактное_лицоBindingNavigatorSaveItem
            // 
            this.контактное_лицоBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.контактное_лицоBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("контактное_лицоBindingNavigatorSaveItem.Image")));
            this.контактное_лицоBindingNavigatorSaveItem.Name = "контактное_лицоBindingNavigatorSaveItem";
            this.контактное_лицоBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.контактное_лицоBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.контактное_лицоBindingNavigatorSaveItem.Click += new System.EventHandler(this.контактное_лицоBindingNavigatorSaveItem_Click);
            // 
            // контактное_лицоDataGridView
            // 
            this.контактное_лицоDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.контактное_лицоDataGridView.AutoGenerateColumns = false;
            this.контактное_лицоDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.контактное_лицоDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.контактное_лицоDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.контактное_лицоDataGridView.DataSource = this.контактное_лицоBindingSource;
            this.контактное_лицоDataGridView.Location = new System.Drawing.Point(12, 28);
            this.контактное_лицоDataGridView.Name = "контактное_лицоDataGridView";
            this.контактное_лицоDataGridView.Size = new System.Drawing.Size(496, 267);
            this.контактное_лицоDataGridView.TabIndex = 1;
            this.контактное_лицоDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.контактное_лицоDataGridView_CellValueChanged);
            this.контактное_лицоDataGridView.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.контактное_лицоDataGridView_UserAddedRow);
            this.контактное_лицоDataGridView.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.контактное_лицоDataGridView_UserDeletedRow);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код_контактного_лица";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Фамилия";
            this.dataGridViewTextBoxColumn2.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Имя";
            this.dataGridViewTextBoxColumn3.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Отчество";
            this.dataGridViewTextBoxColumn4.HeaderText = "Отчество";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // FormTable08
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 307);
            this.Controls.Add(this.контактное_лицоDataGridView);
            this.Controls.Add(this.контактное_лицоBindingNavigator);
            this.Name = "FormTable08";
            this.Text = "Контактное лицо";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTable08_FormClosing);
            this.Load += new System.EventHandler(this.FormTable08_Load);
            ((System.ComponentModel.ISupportInitialize)(this.goodsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.контактное_лицоBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.контактное_лицоBindingNavigator)).EndInit();
            this.контактное_лицоBindingNavigator.ResumeLayout(false);
            this.контактное_лицоBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.контактное_лицоDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GoodsDataSet goodsDataSet;
        private System.Windows.Forms.BindingSource контактное_лицоBindingSource;
        private GoodsDataSetTableAdapters.Контактное_лицоTableAdapter контактное_лицоTableAdapter;
        private GoodsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator контактное_лицоBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton контактное_лицоBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView контактное_лицоDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}