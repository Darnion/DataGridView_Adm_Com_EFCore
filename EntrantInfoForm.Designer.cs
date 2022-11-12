namespace DataGridView_Adm_Com
{
    partial class EntrantInfoForm
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelHeader = new System.Windows.Forms.Label();
            this.logoCollegePictureBox = new System.Windows.Forms.PictureBox();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelFIO = new System.Windows.Forms.Label();
            this.labelSex = new System.Windows.Forms.Label();
            this.labelBirrthDate = new System.Windows.Forms.Label();
            this.labelEducationForm = new System.Windows.Forms.Label();
            this.labelMathExams = new System.Windows.Forms.Label();
            this.labelRussianExams = new System.Windows.Forms.Label();
            this.labelITExams = new System.Windows.Forms.Label();
            this.textBoxFIO = new System.Windows.Forms.TextBox();
            this.comboBoxSex = new System.Windows.Forms.ComboBox();
            this.textBoxMathExams = new System.Windows.Forms.TextBox();
            this.textBoxRussianExams = new System.Windows.Forms.TextBox();
            this.textBoxITExams = new System.Windows.Forms.TextBox();
            this.dateTimePicker_BirthDate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxEducationForm = new System.Windows.Forms.ComboBox();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoCollegePictureBox)).BeginInit();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Salmon;
            this.panelHeader.Controls.Add(this.labelHeader);
            this.panelHeader.Controls.Add(this.logoCollegePictureBox);
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(480, 81);
            this.panelHeader.TabIndex = 0;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeader.Location = new System.Drawing.Point(133, 25);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(335, 25);
            this.labelHeader.TabIndex = 1;
            this.labelHeader.Text = "Информация об абитуриенте";
            this.labelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logoCollegePictureBox
            // 
            this.logoCollegePictureBox.Image = global::DataGridView_Adm_Com.Properties.Resources.logo_college;
            this.logoCollegePictureBox.InitialImage = global::DataGridView_Adm_Com.Properties.Resources.logo_college;
            this.logoCollegePictureBox.Location = new System.Drawing.Point(12, 12);
            this.logoCollegePictureBox.Name = "logoCollegePictureBox";
            this.logoCollegePictureBox.Size = new System.Drawing.Size(100, 50);
            this.logoCollegePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoCollegePictureBox.TabIndex = 0;
            this.logoCollegePictureBox.TabStop = false;
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.MistyRose;
            this.panelFooter.Controls.Add(this.buttonCancel);
            this.panelFooter.Controls.Add(this.buttonSave);
            this.panelFooter.Location = new System.Drawing.Point(0, 346);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(480, 66);
            this.panelFooter.TabIndex = 1;
            // 
            // buttonCancel
            // 
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCancel.Location = new System.Drawing.Point(291, 16);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(132, 34);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "Отменить";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSave.Location = new System.Drawing.Point(45, 16);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(132, 34);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelFIO
            // 
            this.labelFIO.AutoSize = true;
            this.labelFIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFIO.Location = new System.Drawing.Point(25, 102);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(41, 16);
            this.labelFIO.TabIndex = 2;
            this.labelFIO.Text = "ФИО";
            // 
            // labelSex
            // 
            this.labelSex.AutoSize = true;
            this.labelSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSex.Location = new System.Drawing.Point(25, 135);
            this.labelSex.Name = "labelSex";
            this.labelSex.Size = new System.Drawing.Size(36, 16);
            this.labelSex.TabIndex = 2;
            this.labelSex.Text = "Пол";
            // 
            // labelBirrthDate
            // 
            this.labelBirrthDate.AutoSize = true;
            this.labelBirrthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBirrthDate.Location = new System.Drawing.Point(25, 169);
            this.labelBirrthDate.Name = "labelBirrthDate";
            this.labelBirrthDate.Size = new System.Drawing.Size(119, 16);
            this.labelBirrthDate.TabIndex = 2;
            this.labelBirrthDate.Text = "Дата рождения";
            // 
            // labelEducationForm
            // 
            this.labelEducationForm.AutoSize = true;
            this.labelEducationForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEducationForm.Location = new System.Drawing.Point(25, 204);
            this.labelEducationForm.Name = "labelEducationForm";
            this.labelEducationForm.Size = new System.Drawing.Size(131, 16);
            this.labelEducationForm.TabIndex = 2;
            this.labelEducationForm.Text = "Форма обучения";
            // 
            // labelMathExams
            // 
            this.labelMathExams.AutoSize = true;
            this.labelMathExams.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMathExams.Location = new System.Drawing.Point(25, 238);
            this.labelMathExams.Name = "labelMathExams";
            this.labelMathExams.Size = new System.Drawing.Size(169, 16);
            this.labelMathExams.TabIndex = 2;
            this.labelMathExams.Text = "Баллы по математике";
            // 
            // labelRussianExams
            // 
            this.labelRussianExams.AutoSize = true;
            this.labelRussianExams.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRussianExams.Location = new System.Drawing.Point(27, 276);
            this.labelRussianExams.Name = "labelRussianExams";
            this.labelRussianExams.Size = new System.Drawing.Size(150, 16);
            this.labelRussianExams.TabIndex = 2;
            this.labelRussianExams.Text = "Баллы по русскому";
            // 
            // labelITExams
            // 
            this.labelITExams.AutoSize = true;
            this.labelITExams.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelITExams.Location = new System.Drawing.Point(25, 310);
            this.labelITExams.Name = "labelITExams";
            this.labelITExams.Size = new System.Drawing.Size(181, 16);
            this.labelITExams.TabIndex = 2;
            this.labelITExams.Text = "Баллы по информатике";
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.Location = new System.Drawing.Point(82, 101);
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.Size = new System.Drawing.Size(385, 20);
            this.textBoxFIO.TabIndex = 3;
            this.textBoxFIO.TextChanged += new System.EventHandler(this.textBoxFIO_TextChanged);
            // 
            // comboBoxSex
            // 
            this.comboBoxSex.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSex.FormattingEnabled = true;
            this.comboBoxSex.Location = new System.Drawing.Point(82, 133);
            this.comboBoxSex.Name = "comboBoxSex";
            this.comboBoxSex.Size = new System.Drawing.Size(384, 21);
            this.comboBoxSex.TabIndex = 4;
            this.comboBoxSex.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBoxSex_DrawItem);
            this.comboBoxSex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxSex_KeyPress);
            // 
            // textBoxMathExams
            // 
            this.textBoxMathExams.Location = new System.Drawing.Point(215, 237);
            this.textBoxMathExams.Name = "textBoxMathExams";
            this.textBoxMathExams.Size = new System.Drawing.Size(252, 20);
            this.textBoxMathExams.TabIndex = 3;
            this.textBoxMathExams.TextChanged += new System.EventHandler(this.textBoxMathExams_TextChanged);
            this.textBoxMathExams.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMathExams_KeyPress);
            // 
            // textBoxRussianExams
            // 
            this.textBoxRussianExams.Location = new System.Drawing.Point(195, 275);
            this.textBoxRussianExams.Name = "textBoxRussianExams";
            this.textBoxRussianExams.Size = new System.Drawing.Size(273, 20);
            this.textBoxRussianExams.TabIndex = 3;
            this.textBoxRussianExams.TextChanged += new System.EventHandler(this.textBoxMathExams_TextChanged);
            this.textBoxRussianExams.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMathExams_KeyPress);
            // 
            // textBoxITExams
            // 
            this.textBoxITExams.Location = new System.Drawing.Point(227, 309);
            this.textBoxITExams.Name = "textBoxITExams";
            this.textBoxITExams.Size = new System.Drawing.Size(241, 20);
            this.textBoxITExams.TabIndex = 3;
            this.textBoxITExams.TextChanged += new System.EventHandler(this.textBoxMathExams_TextChanged);
            this.textBoxITExams.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMathExams_KeyPress);
            // 
            // dateTimePicker_BirthDate
            // 
            this.dateTimePicker_BirthDate.Location = new System.Drawing.Point(163, 168);
            this.dateTimePicker_BirthDate.MaxDate = new System.DateTime(2007, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker_BirthDate.MinDate = new System.DateTime(1972, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_BirthDate.Name = "dateTimePicker_BirthDate";
            this.dateTimePicker_BirthDate.Size = new System.Drawing.Size(302, 20);
            this.dateTimePicker_BirthDate.TabIndex = 5;
            this.dateTimePicker_BirthDate.Value = new System.DateTime(2006, 12, 31, 0, 0, 0, 0);
            // 
            // comboBoxEducationForm
            // 
            this.comboBoxEducationForm.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEducationForm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEducationForm.FormattingEnabled = true;
            this.comboBoxEducationForm.Location = new System.Drawing.Point(178, 203);
            this.comboBoxEducationForm.Name = "comboBoxEducationForm";
            this.comboBoxEducationForm.Size = new System.Drawing.Size(287, 21);
            this.comboBoxEducationForm.TabIndex = 4;
            this.comboBoxEducationForm.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBoxEducationForm_DrawItem);
            this.comboBoxEducationForm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxSex_KeyPress);
            // 
            // EntrantInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(480, 412);
            this.Controls.Add(this.dateTimePicker_BirthDate);
            this.Controls.Add(this.comboBoxEducationForm);
            this.Controls.Add(this.comboBoxSex);
            this.Controls.Add(this.textBoxITExams);
            this.Controls.Add(this.textBoxRussianExams);
            this.Controls.Add(this.textBoxMathExams);
            this.Controls.Add(this.textBoxFIO);
            this.Controls.Add(this.labelITExams);
            this.Controls.Add(this.labelRussianExams);
            this.Controls.Add(this.labelMathExams);
            this.Controls.Add(this.labelEducationForm);
            this.Controls.Add(this.labelBirrthDate);
            this.Controls.Add(this.labelSex);
            this.Controls.Add(this.labelFIO);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EntrantInfoForm";
            this.Text = "EntrantInfoForm";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoCollegePictureBox)).EndInit();
            this.panelFooter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox logoCollegePictureBox;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.Label labelSex;
        private System.Windows.Forms.Label labelBirrthDate;
        private System.Windows.Forms.Label labelEducationForm;
        private System.Windows.Forms.Label labelMathExams;
        private System.Windows.Forms.Label labelRussianExams;
        private System.Windows.Forms.Label labelITExams;
        private System.Windows.Forms.TextBox textBoxFIO;
        private System.Windows.Forms.ComboBox comboBoxSex;
        private System.Windows.Forms.TextBox textBoxMathExams;
        private System.Windows.Forms.TextBox textBoxRussianExams;
        private System.Windows.Forms.TextBox textBoxITExams;
        private System.Windows.Forms.DateTimePicker dateTimePicker_BirthDate;
        private System.Windows.Forms.ComboBox comboBoxEducationForm;
    }
}