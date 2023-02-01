
namespace KursovayaBSBD
{
    partial class FormAdmin
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заявлениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.получающийПраваЧеловекToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.праваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникГИБДДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pravaDataSet = new KursovayaBSBD.PravaDataSet();
            this.peopleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.peopleTableAdapter = new KursovayaBSBD.PravaDataSetTableAdapters.PeopleTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pravaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.таблицыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(652, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // таблицыToolStripMenuItem
            // 
            this.таблицыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.заявлениеToolStripMenuItem,
            this.получающийПраваЧеловекToolStripMenuItem,
            this.праваToolStripMenuItem,
            this.сотрудникГИБДДToolStripMenuItem});
            this.таблицыToolStripMenuItem.Name = "таблицыToolStripMenuItem";
            this.таблицыToolStripMenuItem.Size = new System.Drawing.Size(85, 26);
            this.таблицыToolStripMenuItem.Text = "Таблицы";
            // 
            // заявлениеToolStripMenuItem
            // 
            this.заявлениеToolStripMenuItem.Name = "заявлениеToolStripMenuItem";
            this.заявлениеToolStripMenuItem.Size = new System.Drawing.Size(291, 26);
            this.заявлениеToolStripMenuItem.Text = "Заявление";
            this.заявлениеToolStripMenuItem.Click += new System.EventHandler(this.заявлениеToolStripMenuItem_Click);
            // 
            // получающийПраваЧеловекToolStripMenuItem
            // 
            this.получающийПраваЧеловекToolStripMenuItem.Name = "получающийПраваЧеловекToolStripMenuItem";
            this.получающийПраваЧеловекToolStripMenuItem.Size = new System.Drawing.Size(291, 26);
            this.получающийПраваЧеловекToolStripMenuItem.Text = "Получающий права человек";
            this.получающийПраваЧеловекToolStripMenuItem.Click += new System.EventHandler(this.получающийПраваЧеловекToolStripMenuItem_Click);
            // 
            // праваToolStripMenuItem
            // 
            this.праваToolStripMenuItem.Name = "праваToolStripMenuItem";
            this.праваToolStripMenuItem.Size = new System.Drawing.Size(291, 26);
            this.праваToolStripMenuItem.Text = "Права";
            this.праваToolStripMenuItem.Click += new System.EventHandler(this.праваToolStripMenuItem_Click);
            // 
            // сотрудникГИБДДToolStripMenuItem
            // 
            this.сотрудникГИБДДToolStripMenuItem.Name = "сотрудникГИБДДToolStripMenuItem";
            this.сотрудникГИБДДToolStripMenuItem.Size = new System.Drawing.Size(291, 26);
            this.сотрудникГИБДДToolStripMenuItem.Text = "Сотрудник ГИБДД";
            this.сотрудникГИБДДToolStripMenuItem.Click += new System.EventHandler(this.сотрудникГИБДДToolStripMenuItem_Click);
            // 
            // pravaDataSet
            // 
            this.pravaDataSet.DataSetName = "PravaDataSet";
            this.pravaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // peopleBindingSource
            // 
            this.peopleBindingSource.DataMember = "People";
            this.peopleBindingSource.DataSource = this.pravaDataSet;
            // 
            // peopleTableAdapter
            // 
            this.peopleTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Добро пожаловать в приложение для выдачи прав";
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 201);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormAdmin";
            this.Text = "Приложение для выдачи прав (полный доступ)";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pravaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem таблицыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заявлениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem получающийПраваЧеловекToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem праваToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникГИБДДToolStripMenuItem;
        private PravaDataSet pravaDataSet;
        private System.Windows.Forms.BindingSource peopleBindingSource;
        private PravaDataSetTableAdapters.PeopleTableAdapter peopleTableAdapter;
        private System.Windows.Forms.Label label1;
    }
}