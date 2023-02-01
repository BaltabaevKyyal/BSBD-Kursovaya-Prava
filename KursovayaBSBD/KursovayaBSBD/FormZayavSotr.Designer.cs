
namespace KursovayaBSBD
{
    partial class FormZayavSotr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormZayavSotr));
            this.pravaDataSet = new KursovayaBSBD.PravaDataSet();
            this.zayavlenieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zayavlenieTableAdapter = new KursovayaBSBD.PravaDataSetTableAdapters.ZayavlenieTableAdapter();
            this.tableAdapterManager = new KursovayaBSBD.PravaDataSetTableAdapters.TableAdapterManager();
            this.zayavlenieBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.zayavlenieDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.zayavlenieBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.pravaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zayavlenieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zayavlenieBindingNavigator)).BeginInit();
            this.zayavlenieBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zayavlenieDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pravaDataSet
            // 
            this.pravaDataSet.DataSetName = "PravaDataSet";
            this.pravaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zayavlenieBindingSource
            // 
            this.zayavlenieBindingSource.DataMember = "Zayavlenie";
            this.zayavlenieBindingSource.DataSource = this.pravaDataSet;
            // 
            // zayavlenieTableAdapter
            // 
            this.zayavlenieTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PeopleTableAdapter = null;
            this.tableAdapterManager.PravaTableAdapter = null;
            this.tableAdapterManager.SotrudnikTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = KursovayaBSBD.PravaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ZayavlenieTableAdapter = this.zayavlenieTableAdapter;
            // 
            // zayavlenieBindingNavigator
            // 
            this.zayavlenieBindingNavigator.AddNewItem = null;
            this.zayavlenieBindingNavigator.BindingSource = this.zayavlenieBindingSource;
            this.zayavlenieBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.zayavlenieBindingNavigator.CountItemFormat = "из {0}";
            this.zayavlenieBindingNavigator.DeleteItem = null;
            this.zayavlenieBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.zayavlenieBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.zayavlenieBindingNavigatorSaveItem});
            this.zayavlenieBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.zayavlenieBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.zayavlenieBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.zayavlenieBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.zayavlenieBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.zayavlenieBindingNavigator.Name = "zayavlenieBindingNavigator";
            this.zayavlenieBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.zayavlenieBindingNavigator.Size = new System.Drawing.Size(800, 31);
            this.zayavlenieBindingNavigator.TabIndex = 0;
            this.zayavlenieBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(47, 28);
            this.bindingNavigatorCountItem.Text = "из {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // zayavlenieDataGridView
            // 
            this.zayavlenieDataGridView.AutoGenerateColumns = false;
            this.zayavlenieDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.zayavlenieDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.zayavlenieDataGridView.DataSource = this.zayavlenieBindingSource;
            this.zayavlenieDataGridView.Location = new System.Drawing.Point(25, 26);
            this.zayavlenieDataGridView.Name = "zayavlenieDataGridView";
            this.zayavlenieDataGridView.RowHeadersWidth = 51;
            this.zayavlenieDataGridView.RowTemplate.Height = 24;
            this.zayavlenieDataGridView.Size = new System.Drawing.Size(735, 225);
            this.zayavlenieDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Zayavlenie_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Zayavlenie_ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Data";
            this.dataGridViewTextBoxColumn2.HeaderText = "Data";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "People_ID";
            this.dataGridViewTextBoxColumn3.HeaderText = "People_ID";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Sotrudnik_ID";
            this.dataGridViewTextBoxColumn4.HeaderText = "Sotrudnik_ID";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // zayavlenieBindingNavigatorSaveItem
            // 
            this.zayavlenieBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zayavlenieBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("zayavlenieBindingNavigatorSaveItem.Image")));
            this.zayavlenieBindingNavigatorSaveItem.Name = "zayavlenieBindingNavigatorSaveItem";
            this.zayavlenieBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.zayavlenieBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.zayavlenieBindingNavigatorSaveItem.Click += new System.EventHandler(this.zayavlenieBindingNavigatorSaveItem_Click);
            // 
            // FormZayavSotr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 358);
            this.Controls.Add(this.zayavlenieDataGridView);
            this.Controls.Add(this.zayavlenieBindingNavigator);
            this.Name = "FormZayavSotr";
            this.Text = "Заявления";
            this.Load += new System.EventHandler(this.FormZayavSotr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pravaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zayavlenieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zayavlenieBindingNavigator)).EndInit();
            this.zayavlenieBindingNavigator.ResumeLayout(false);
            this.zayavlenieBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zayavlenieDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PravaDataSet pravaDataSet;
        private System.Windows.Forms.BindingSource zayavlenieBindingSource;
        private PravaDataSetTableAdapters.ZayavlenieTableAdapter zayavlenieTableAdapter;
        private PravaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator zayavlenieBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton zayavlenieBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView zayavlenieDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}