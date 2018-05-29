namespace ClientForBD
{
    partial class FormTable04
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTable04));
            this.goodsDataSet = new ClientForBD.GoodsDataSet();
            this.адресBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.адресTableAdapter = new ClientForBD.GoodsDataSetTableAdapters.АдресTableAdapter();
            this.tableAdapterManager = new ClientForBD.GoodsDataSetTableAdapters.TableAdapterManager();
            this.адресBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.адресBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.адресDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.goodsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.адресBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.адресBindingNavigator)).BeginInit();
            this.адресBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.адресDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // goodsDataSet
            // 
            this.goodsDataSet.DataSetName = "GoodsDataSet";
            this.goodsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // адресBindingSource
            // 
            this.адресBindingSource.DataMember = "Адрес";
            this.адресBindingSource.DataSource = this.goodsDataSet;
            // 
            // адресTableAdapter
            // 
            this.адресTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = ClientForBD.GoodsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АдресTableAdapter = this.адресTableAdapter;
            this.tableAdapterManager.Группа_товаровTableAdapter = null;
            this.tableAdapterManager.Контактное_лицоTableAdapter = null;
            this.tableAdapterManager.Отдел_маркетингаTableAdapter = null;
            this.tableAdapterManager.Прайс_листTableAdapter = null;
            this.tableAdapterManager.ПредприятиеTableAdapter = null;
            this.tableAdapterManager.Производимый_товарTableAdapter = null;
            this.tableAdapterManager.Руководитель_отдела_маркетингаTableAdapter = null;
            this.tableAdapterManager.Руководитель_предприятияTableAdapter = null;
            this.tableAdapterManager.Тип_товараTableAdapter = null;
            this.tableAdapterManager.ТоварTableAdapter = null;
            // 
            // адресBindingNavigator
            // 
            this.адресBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.адресBindingNavigator.BindingSource = this.адресBindingSource;
            this.адресBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.адресBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.адресBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.адресBindingNavigatorSaveItem});
            this.адресBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.адресBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.адресBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.адресBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.адресBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.адресBindingNavigator.Name = "адресBindingNavigator";
            this.адресBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.адресBindingNavigator.Size = new System.Drawing.Size(704, 25);
            this.адресBindingNavigator.TabIndex = 0;
            this.адресBindingNavigator.Text = "bindingNavigator1";
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
            // адресBindingNavigatorSaveItem
            // 
            this.адресBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.адресBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("адресBindingNavigatorSaveItem.Image")));
            this.адресBindingNavigatorSaveItem.Name = "адресBindingNavigatorSaveItem";
            this.адресBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.адресBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.адресBindingNavigatorSaveItem.Click += new System.EventHandler(this.адресBindingNavigatorSaveItem_Click);
            // 
            // адресDataGridView
            // 
            this.адресDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.адресDataGridView.AutoGenerateColumns = false;
            this.адресDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.адресDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.адресDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.адресDataGridView.DataSource = this.адресBindingSource;
            this.адресDataGridView.Location = new System.Drawing.Point(12, 28);
            this.адресDataGridView.Name = "адресDataGridView";
            this.адресDataGridView.Size = new System.Drawing.Size(680, 311);
            this.адресDataGridView.TabIndex = 1;
            this.адресDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.адресDataGridView_CellValueChanged);
            this.адресDataGridView.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.адресDataGridView_UserAddedRow);
            this.адресDataGridView.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.адресDataGridView_UserDeletedRow);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код_адреса";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Район";
            this.dataGridViewTextBoxColumn2.HeaderText = "Район";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Населённый_пункт";
            this.dataGridViewTextBoxColumn3.HeaderText = "Населённый пункт";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Улица";
            this.dataGridViewTextBoxColumn4.HeaderText = "Улица";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Дом";
            this.dataGridViewTextBoxColumn5.HeaderText = "Дом";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // FormTable04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 351);
            this.Controls.Add(this.адресDataGridView);
            this.Controls.Add(this.адресBindingNavigator);
            this.Name = "FormTable04";
            this.Text = "Адрес";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTable04_FormClosing);
            this.Load += new System.EventHandler(this.FormTable04_Load);
            ((System.ComponentModel.ISupportInitialize)(this.goodsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.адресBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.адресBindingNavigator)).EndInit();
            this.адресBindingNavigator.ResumeLayout(false);
            this.адресBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.адресDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GoodsDataSet goodsDataSet;
        private System.Windows.Forms.BindingSource адресBindingSource;
        private GoodsDataSetTableAdapters.АдресTableAdapter адресTableAdapter;
        private GoodsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator адресBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton адресBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView адресDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}