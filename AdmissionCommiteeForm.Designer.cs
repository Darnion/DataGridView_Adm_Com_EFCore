namespace DataGridView_Adm_Com
{
    partial class AdmissionCommiteeForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdmissionCommiteeForm));
            this.dataGridView_Adm_Com = new System.Windows.Forms.DataGridView();
            this.FIOColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SexColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EducationFormColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MathExamsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RussianExamsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITExamsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SumExamsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Close = new System.Windows.Forms.ToolStripMenuItem();
            this.editItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labelAmountEntrant = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelAmountPassGrade = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.buttonAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonDelete = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Adm_Com)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_Adm_Com
            // 
            this.dataGridView_Adm_Com.AllowUserToAddRows = false;
            this.dataGridView_Adm_Com.AllowUserToDeleteRows = false;
            this.dataGridView_Adm_Com.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Adm_Com.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FIOColumn,
            this.SexColumn,
            this.BirthDateColumn,
            this.EducationFormColumn,
            this.MathExamsColumn,
            this.RussianExamsColumn,
            this.ITExamsColumn,
            this.SumExamsColumn});
            this.dataGridView_Adm_Com.Location = new System.Drawing.Point(-2, 45);
            this.dataGridView_Adm_Com.Name = "dataGridView_Adm_Com";
            this.dataGridView_Adm_Com.ReadOnly = true;
            this.dataGridView_Adm_Com.Size = new System.Drawing.Size(844, 380);
            this.dataGridView_Adm_Com.TabIndex = 0;
            this.dataGridView_Adm_Com.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView_Adm_Com_CellFormatting);
            this.dataGridView_Adm_Com.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView_Adm_Com_DataBindingComplete);
            this.dataGridView_Adm_Com.SelectionChanged += new System.EventHandler(this.dataGridView_Adm_Com_SelectionChanged);
            // 
            // FIOColumn
            // 
            this.FIOColumn.DataPropertyName = "FullName";
            this.FIOColumn.HeaderText = "ФИО";
            this.FIOColumn.Name = "FIOColumn";
            this.FIOColumn.ReadOnly = true;
            // 
            // SexColumn
            // 
            this.SexColumn.DataPropertyName = "Gender";
            this.SexColumn.HeaderText = "Пол";
            this.SexColumn.Name = "SexColumn";
            this.SexColumn.ReadOnly = true;
            // 
            // BirthDateColumn
            // 
            this.BirthDateColumn.DataPropertyName = "BirthDate";
            this.BirthDateColumn.HeaderText = "Дата рождения";
            this.BirthDateColumn.Name = "BirthDateColumn";
            this.BirthDateColumn.ReadOnly = true;
            // 
            // EducationFormColumn
            // 
            this.EducationFormColumn.DataPropertyName = "EducationForm";
            this.EducationFormColumn.HeaderText = "Форма обучения";
            this.EducationFormColumn.Name = "EducationFormColumn";
            this.EducationFormColumn.ReadOnly = true;
            // 
            // MathExamsColumn
            // 
            this.MathExamsColumn.DataPropertyName = "MathExams";
            this.MathExamsColumn.HeaderText = "ЕГЭ по математике";
            this.MathExamsColumn.Name = "MathExamsColumn";
            this.MathExamsColumn.ReadOnly = true;
            // 
            // RussianExamsColumn
            // 
            this.RussianExamsColumn.DataPropertyName = "RussianExams";
            this.RussianExamsColumn.HeaderText = "ЕГЭ по русскому языку";
            this.RussianExamsColumn.Name = "RussianExamsColumn";
            this.RussianExamsColumn.ReadOnly = true;
            // 
            // ITExamsColumn
            // 
            this.ITExamsColumn.DataPropertyName = "ITExams";
            this.ITExamsColumn.HeaderText = "ЕГЭ по информатике";
            this.ITExamsColumn.Name = "ITExamsColumn";
            this.ITExamsColumn.ReadOnly = true;
            // 
            // SumExamsColumn
            // 
            this.SumExamsColumn.HeaderText = "Сумма баллов";
            this.SumExamsColumn.Name = "SumExamsColumn";
            this.SumExamsColumn.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileItem,
            this.editItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(840, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileItem
            // 
            this.fileItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_Close});
            this.fileItem.Name = "fileItem";
            this.fileItem.Size = new System.Drawing.Size(48, 20);
            this.fileItem.Text = "Файл";
            // 
            // toolStripMenuItem_Close
            // 
            this.toolStripMenuItem_Close.Name = "toolStripMenuItem_Close";
            this.toolStripMenuItem_Close.Size = new System.Drawing.Size(120, 22);
            this.toolStripMenuItem_Close.Text = "Закрыть";
            this.toolStripMenuItem_Close.Click += new System.EventHandler(this.toolStripMenuItem_Close_Click);
            // 
            // editItem
            // 
            this.editItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_Add,
            this.toolStripSeparator3,
            this.toolStripMenuItem_Edit,
            this.toolStripSeparator4,
            this.toolStripMenuItem_Delete});
            this.editItem.Name = "editItem";
            this.editItem.Size = new System.Drawing.Size(59, 20);
            this.editItem.Text = "Правка";
            // 
            // toolStripMenuItem_Add
            // 
            this.toolStripMenuItem_Add.Name = "toolStripMenuItem_Add";
            this.toolStripMenuItem_Add.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem_Add.Text = "Добавить";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripMenuItem_Edit
            // 
            this.toolStripMenuItem_Edit.Enabled = false;
            this.toolStripMenuItem_Edit.Name = "toolStripMenuItem_Edit";
            this.toolStripMenuItem_Edit.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem_Edit.Text = "Изменить";
            this.toolStripMenuItem_Edit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripMenuItem_Delete
            // 
            this.toolStripMenuItem_Delete.Enabled = false;
            this.toolStripMenuItem_Delete.Name = "toolStripMenuItem_Delete";
            this.toolStripMenuItem_Delete.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem_Delete.Text = "Удалить";
            this.toolStripMenuItem_Delete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelAmountEntrant,
            this.labelAmountPassGrade});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(840, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // labelAmountEntrant
            // 
            this.labelAmountEntrant.Name = "labelAmountEntrant";
            this.labelAmountEntrant.Size = new System.Drawing.Size(157, 17);
            this.labelAmountEntrant.Text = "Количество абитуриентов: ";
            // 
            // labelAmountPassGrade
            // 
            this.labelAmountPassGrade.Name = "labelAmountPassGrade";
            this.labelAmountPassGrade.Size = new System.Drawing.Size(317, 17);
            this.labelAmountPassGrade.Text = "Количество абитуриентов с проходным баллом (>150): ";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonAdd,
            this.toolStripSeparator1,
            this.buttonEdit,
            this.toolStripSeparator2,
            this.buttonDelete});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(840, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // buttonAdd
            // 
            this.buttonAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonAdd.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdd.Image")));
            this.buttonAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(63, 22);
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // buttonEdit
            // 
            this.buttonEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonEdit.Enabled = false;
            this.buttonEdit.Image = ((System.Drawing.Image)(resources.GetObject("buttonEdit.Image")));
            this.buttonEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(65, 22);
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // buttonDelete
            // 
            this.buttonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonDelete.Enabled = false;
            this.buttonDelete.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelete.Image")));
            this.buttonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(55, 22);
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // AdmissionCommiteeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridView_Adm_Com);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdmissionCommiteeForm";
            this.Text = "Приемная комиссия";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Adm_Com)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Adm_Com;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton buttonAdd;
        private System.Windows.Forms.ToolStripButton buttonEdit;
        private System.Windows.Forms.ToolStripButton buttonDelete;
        private System.Windows.Forms.ToolStripMenuItem fileItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Close;
        private System.Windows.Forms.ToolStripMenuItem editItem;
        private System.Windows.Forms.ToolStripStatusLabel labelAmountEntrant;
        private System.Windows.Forms.ToolStripStatusLabel labelAmountPassGrade;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Add;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Edit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIOColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SexColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EducationFormColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MathExamsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RussianExamsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITExamsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SumExamsColumn;
    }
}

