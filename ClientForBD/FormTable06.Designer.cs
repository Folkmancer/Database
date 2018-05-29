namespace ClientForBD
{
    partial class FormTable06
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTable06));
            this.goodsDataSet = new ClientForBD.GoodsDataSet();
            this.руководитель_отдела_маркетингаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.руководитель_отдела_маркетингаTableAdapter = new ClientForBD.GoodsDataSetTableAdapters.Руководитель_отдела_маркетингаTableAdapter();
            this.tableAdapterManager = new ClientForBD.GoodsDataSetTableAdapters.TableAdapterManager();
            this.руководитель_отдела_маркетингаBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.руководитель_отдела_маркетингаBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.руководитель_отдела_маркетингаDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.goodsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.руководитель_отдела_маркетингаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.руководитель_отдела_маркетингаBindingNavigator)).BeginInit();
            this.руководитель_отдела_маркетингаBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.руководитель_отдела_маркетингаDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // goodsDataSet
            // 
            this.goodsDataSet.DataSetName = "GoodsDataSet";
            this.goodsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // руководитель_отдела_маркетингаBindingSource
            // 
            this.руководитель_отдела_маркетингаBindingSource.DataMember = "Руководитель_отдела_маркетинга";
            this.руководитель_отдела_маркетингаBindingSource.DataSource = this.goodsDataSet;
            // 
            // руководитель_отдела_маркетингаTableAdapter
            // 
            this.руководитель_отдела_маркетингаTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.ПредприятиеTableAdapter = null;
            this.tableAdapterManager.Производимый_товарTableAdapter = null;
            this.tableAdapterManager.Руководитель_отдела_маркетингаTableAdapter = this.руководитель_отдела_маркетингаTableAdapter;
            this.tableAdapterManager.Руководитель_предприятияTableAdapter = null;
            this.tableAdapterManager.Тип_товараTableAdapter = null;
            this.tableAdapterManager.ТоварTableAdapter = null;
            // 
            // руководитель_отдела_маркетингаBindingNavigator
            // 
            this.руководитель_отдела_маркетингаBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.руководитель_отдела_маркетингаBindingNavigator.BindingSource = this.руководитель_отдела_маркетингаBindingSource;
            this.руководитель_отдела_маркетингаBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.руководитель_отдела_маркетингаBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.руководитель_отдела_маркетингаBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.руководитель_отдела_маркетингаBindingNavigatorSaveItem});
            this.руководитель_отдела_маркетингаBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.руководитель_отдела_маркетингаBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.руководитель_отдела_маркетингаBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.руководитель_отдела_маркетингаBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.руководитель_отдела_маркетингаBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.руководитель_отдела_маркетингаBindingNavigator.Name = "руководитель_отдела_маркетингаBindingNavigator";
            this.руководитель_отдела_маркетингаBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.руководитель_отдела_маркетингаBindingNavigator.Size = new System.Drawing.Size(554, 25);
            this.руководитель_отдела_маркетингаBindingNavigator.TabIndex = 0;
            this.руководитель_отдела_маркетингаBindingNavigator.Text = "bindingNavigator1";
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
            // руководитель_отдела_маркетингаBindingNavigatorSaveItem
            // 
            this.руководитель_отдела_маркетингаBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.руководитель_отдела_маркетингаBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("руководитель_отдела_маркетингаBindingNavigatorSaveItem.Image")));
            this.руководитель_отдела_маркетингаBindingNavigatorSaveItem.Name = "руководитель_отдела_маркетингаBindingNavigatorSaveItem";
            this.руководитель_отдела_маркетингаBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.руководитель_отдела_маркетингаBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.руководитель_отдела_маркетингаBindingNavigatorSaveItem.Click += new System.EventHandler(this.руководитель_отдела_маркетингаBindingNavigatorSaveItem_Click);
            // 
            // руководитель_отдела_маркетингаDataGridView
            // 
            this.руководитель_отдела_маркетингаDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.руководитель_отдела_маркетингаDataGridView.AutoGenerateColumns = false;
            this.руководитель_отдела_маркетингаDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.руководитель_отдела_маркетингаDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.руководитель_отдела_маркетингаDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.руководитель_отдела_маркетингаDataGridView.DataSource = this.руководитель_отдела_маркетингаBindingSource;
            this.руководитель_отдела_маркетингаDataGridView.Location = new System.Drawing.Point(12, 28);
            this.руководитель_отдела_маркетингаDataGridView.Name = "руководитель_отдела_маркетингаDataGridView";
            this.руководитель_отдела_маркетингаDataGridView.Size = new System.Drawing.Size(530, 339);
            this.руководитель_отдела_маркетингаDataGridView.TabIndex = 1;
            this.руководитель_отдела_маркетингаDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.руководитель_отдела_маркетингаDataGridView_CellValueChanged);
            this.руководитель_отдела_маркетингаDataGridView.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.руководитель_отдела_маркетингаDataGridView_UserAddedRow);
            this.руководитель_отдела_маркетингаDataGridView.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.руководитель_отдела_маркетингаDataGridView_UserDeletedRow);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код_руководителя_маркетинга";
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
            // FormTable06
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 379);
            this.Controls.Add(this.руководитель_отдела_маркетингаDataGridView);
            this.Controls.Add(this.руководитель_отдела_маркетингаBindingNavigator);
            this.Name = "FormTable06";
            this.Text = "Руководитель отдела маркетинга";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTable06_FormClosing);
            this.Load += new System.EventHandler(this.FormTable06_Load);
            ((System.ComponentModel.ISupportInitialize)(this.goodsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.руководитель_отдела_маркетингаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.руководитель_отдела_маркетингаBindingNavigator)).EndInit();
            this.руководитель_отдела_маркетингаBindingNavigator.ResumeLayout(false);
            this.руководитель_отдела_маркетингаBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.руководитель_отдела_маркетингаDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GoodsDataSet goodsDataSet;
        private System.Windows.Forms.BindingSource руководитель_отдела_маркетингаBindingSource;
        private GoodsDataSetTableAdapters.Руководитель_отдела_маркетингаTableAdapter руководитель_отдела_маркетингаTableAdapter;
        private GoodsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator руководитель_отдела_маркетингаBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton руководитель_отдела_маркетингаBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView руководитель_отдела_маркетингаDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}