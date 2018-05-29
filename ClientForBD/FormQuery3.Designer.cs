namespace ClientForBD
{
    partial class FormQuery3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuery3));
            this.goodsDataSet = new ClientForBD.GoodsDataSet();
            this.enterpriseQueryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enterpriseQueryTableAdapter = new ClientForBD.GoodsDataSetTableAdapters.EnterpriseQueryTableAdapter();
            this.tableAdapterManager = new ClientForBD.GoodsDataSetTableAdapters.TableAdapterManager();
            this.enterpriseQueryBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.enterpriseQueryDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.goodsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterpriseQueryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterpriseQueryBindingNavigator)).BeginInit();
            this.enterpriseQueryBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enterpriseQueryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // goodsDataSet
            // 
            this.goodsDataSet.DataSetName = "GoodsDataSet";
            this.goodsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // enterpriseQueryBindingSource
            // 
            this.enterpriseQueryBindingSource.DataMember = "EnterpriseQuery";
            this.enterpriseQueryBindingSource.DataSource = this.goodsDataSet;
            // 
            // enterpriseQueryTableAdapter
            // 
            this.enterpriseQueryTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = ClientForBD.GoodsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АдресTableAdapter = null;
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
            // enterpriseQueryBindingNavigator
            // 
            this.enterpriseQueryBindingNavigator.AddNewItem = null;
            this.enterpriseQueryBindingNavigator.BindingSource = this.enterpriseQueryBindingSource;
            this.enterpriseQueryBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.enterpriseQueryBindingNavigator.DeleteItem = null;
            this.enterpriseQueryBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem});
            this.enterpriseQueryBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.enterpriseQueryBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.enterpriseQueryBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.enterpriseQueryBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.enterpriseQueryBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.enterpriseQueryBindingNavigator.Name = "enterpriseQueryBindingNavigator";
            this.enterpriseQueryBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.enterpriseQueryBindingNavigator.Size = new System.Drawing.Size(494, 25);
            this.enterpriseQueryBindingNavigator.TabIndex = 0;
            this.enterpriseQueryBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            // enterpriseQueryDataGridView
            // 
            this.enterpriseQueryDataGridView.AllowUserToAddRows = false;
            this.enterpriseQueryDataGridView.AllowUserToDeleteRows = false;
            this.enterpriseQueryDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.enterpriseQueryDataGridView.AutoGenerateColumns = false;
            this.enterpriseQueryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.enterpriseQueryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.enterpriseQueryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.enterpriseQueryDataGridView.DataSource = this.enterpriseQueryBindingSource;
            this.enterpriseQueryDataGridView.Location = new System.Drawing.Point(12, 28);
            this.enterpriseQueryDataGridView.Name = "enterpriseQueryDataGridView";
            this.enterpriseQueryDataGridView.ReadOnly = true;
            this.enterpriseQueryDataGridView.Size = new System.Drawing.Size(470, 273);
            this.enterpriseQueryDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Дата";
            this.dataGridViewTextBoxColumn1.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Название";
            this.dataGridViewTextBoxColumn2.HeaderText = "Название";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Телефон";
            this.dataGridViewTextBoxColumn3.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ФИО контактного лица";
            this.dataGridViewTextBoxColumn4.HeaderText = "ФИО контактного лица";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // FormQuery3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 313);
            this.Controls.Add(this.enterpriseQueryDataGridView);
            this.Controls.Add(this.enterpriseQueryBindingNavigator);
            this.Name = "FormQuery3";
            this.Text = "Список всех предприятий ";
            this.Load += new System.EventHandler(this.FormQuery3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.goodsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterpriseQueryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterpriseQueryBindingNavigator)).EndInit();
            this.enterpriseQueryBindingNavigator.ResumeLayout(false);
            this.enterpriseQueryBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enterpriseQueryDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GoodsDataSet goodsDataSet;
        private System.Windows.Forms.BindingSource enterpriseQueryBindingSource;
        private GoodsDataSetTableAdapters.EnterpriseQueryTableAdapter enterpriseQueryTableAdapter;
        private GoodsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator enterpriseQueryBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.DataGridView enterpriseQueryDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}