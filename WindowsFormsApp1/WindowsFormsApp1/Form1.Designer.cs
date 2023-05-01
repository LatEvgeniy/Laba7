
namespace WindowsFormsApp1
{
    partial class Form1
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
            this.btOutputData = new System.Windows.Forms.Button();
            this.dgvLecturers = new System.Windows.Forms.DataGridView();
            this.dgvSubjects = new System.Windows.Forms.DataGridView();
            this.btUpdateData = new System.Windows.Forms.Button();
            this.cbSheetsForUpdate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTables = new System.Windows.Forms.ComboBox();
            this.tbNewValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btInsertData = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbChangingValue = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbSheetsForInsert = new System.Windows.Forms.ComboBox();
            this.labelIDInsert = new System.Windows.Forms.Label();
            this.tbIDInsert = new System.Windows.Forms.TextBox();
            this.labelNameInsert = new System.Windows.Forms.Label();
            this.tbNameInsert = new System.Windows.Forms.TextBox();
            this.labelLastNameInsert = new System.Windows.Forms.Label();
            this.tbLastNameInsert = new System.Windows.Forms.TextBox();
            this.labelSubjectsInsert = new System.Windows.Forms.Label();
            this.tbSubjectsInsert = new System.Windows.Forms.TextBox();
            this.tbLecturersInsert = new System.Windows.Forms.TextBox();
            this.labelLecturersInsert = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLecturers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjects)).BeginInit();
            this.SuspendLayout();
            // 
            // btOutputData
            // 
            this.btOutputData.Location = new System.Drawing.Point(21, 342);
            this.btOutputData.Name = "btOutputData";
            this.btOutputData.Size = new System.Drawing.Size(148, 50);
            this.btOutputData.TabIndex = 2;
            this.btOutputData.Text = "Вывести данные с эксель файла";
            this.btOutputData.UseVisualStyleBackColor = true;
            // 
            // dgvLecturers
            // 
            this.dgvLecturers.AllowUserToAddRows = false;
            this.dgvLecturers.AllowUserToDeleteRows = false;
            this.dgvLecturers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLecturers.Location = new System.Drawing.Point(21, 12);
            this.dgvLecturers.Name = "dgvLecturers";
            this.dgvLecturers.ReadOnly = true;
            this.dgvLecturers.RowHeadersWidth = 51;
            this.dgvLecturers.RowTemplate.Height = 24;
            this.dgvLecturers.Size = new System.Drawing.Size(690, 324);
            this.dgvLecturers.TabIndex = 3;
            // 
            // dgvSubjects
            // 
            this.dgvSubjects.AllowUserToAddRows = false;
            this.dgvSubjects.AllowUserToDeleteRows = false;
            this.dgvSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubjects.Location = new System.Drawing.Point(717, 12);
            this.dgvSubjects.Name = "dgvSubjects";
            this.dgvSubjects.ReadOnly = true;
            this.dgvSubjects.RowHeadersWidth = 51;
            this.dgvSubjects.RowTemplate.Height = 24;
            this.dgvSubjects.Size = new System.Drawing.Size(597, 324);
            this.dgvSubjects.TabIndex = 5;
            // 
            // btUpdateData
            // 
            this.btUpdateData.Location = new System.Drawing.Point(715, 342);
            this.btUpdateData.Name = "btUpdateData";
            this.btUpdateData.Size = new System.Drawing.Size(267, 24);
            this.btUpdateData.TabIndex = 6;
            this.btUpdateData.Text = "Обновить данные в эксель файле";
            this.btUpdateData.UseVisualStyleBackColor = true;
            // 
            // cbSheetsForUpdate
            // 
            this.cbSheetsForUpdate.FormattingEnabled = true;
            this.cbSheetsForUpdate.Items.AddRange(new object[] {
            "Lecturers$",
            "Subjects$"});
            this.cbSheetsForUpdate.Location = new System.Drawing.Point(717, 386);
            this.cbSheetsForUpdate.Name = "cbSheetsForUpdate";
            this.cbSheetsForUpdate.Size = new System.Drawing.Size(108, 24);
            this.cbSheetsForUpdate.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(717, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Выберите лист";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(831, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Выберите таблицу";
            // 
            // cbTables
            // 
            this.cbTables.FormattingEnabled = true;
            this.cbTables.Location = new System.Drawing.Point(831, 386);
            this.cbTables.Name = "cbTables";
            this.cbTables.Size = new System.Drawing.Size(132, 24);
            this.cbTables.TabIndex = 10;
            // 
            // tbNewValue
            // 
            this.tbNewValue.Location = new System.Drawing.Point(717, 438);
            this.tbNewValue.Name = "tbNewValue";
            this.tbNewValue.Size = new System.Drawing.Size(173, 22);
            this.tbNewValue.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(717, 418);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Введите новое значение";
            // 
            // btInsertData
            // 
            this.btInsertData.Location = new System.Drawing.Point(175, 342);
            this.btInsertData.Name = "btInsertData";
            this.btInsertData.Size = new System.Drawing.Size(258, 24);
            this.btInsertData.TabIndex = 13;
            this.btInsertData.Text = "Добавить строку данных в эксель";
            this.btInsertData.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(969, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Выберите изменяемое значение";
            // 
            // cbChangingValue
            // 
            this.cbChangingValue.FormattingEnabled = true;
            this.cbChangingValue.Location = new System.Drawing.Point(972, 386);
            this.cbChangingValue.Name = "cbChangingValue";
            this.cbChangingValue.Size = new System.Drawing.Size(223, 24);
            this.cbChangingValue.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(175, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Выберите лист";
            // 
            // cbSheetsForInsert
            // 
            this.cbSheetsForInsert.FormattingEnabled = true;
            this.cbSheetsForInsert.Items.AddRange(new object[] {
            "Lecturers$",
            "Subjects$"});
            this.cbSheetsForInsert.Location = new System.Drawing.Point(175, 386);
            this.cbSheetsForInsert.Name = "cbSheetsForInsert";
            this.cbSheetsForInsert.Size = new System.Drawing.Size(108, 24);
            this.cbSheetsForInsert.TabIndex = 16;
            // 
            // labelIDInsert
            // 
            this.labelIDInsert.AutoSize = true;
            this.labelIDInsert.Location = new System.Drawing.Point(175, 418);
            this.labelIDInsert.Name = "labelIDInsert";
            this.labelIDInsert.Size = new System.Drawing.Size(80, 17);
            this.labelIDInsert.TabIndex = 19;
            this.labelIDInsert.Text = "Введите ID";
            this.labelIDInsert.Visible = false;
            // 
            // tbIDInsert
            // 
            this.tbIDInsert.Location = new System.Drawing.Point(175, 438);
            this.tbIDInsert.Name = "tbIDInsert";
            this.tbIDInsert.Size = new System.Drawing.Size(80, 22);
            this.tbIDInsert.TabIndex = 18;
            this.tbIDInsert.Visible = false;
            // 
            // labelNameInsert
            // 
            this.labelNameInsert.AutoSize = true;
            this.labelNameInsert.Location = new System.Drawing.Point(261, 418);
            this.labelNameInsert.Name = "labelNameInsert";
            this.labelNameInsert.Size = new System.Drawing.Size(94, 17);
            this.labelNameInsert.TabIndex = 21;
            this.labelNameInsert.Text = "Введите Имя";
            this.labelNameInsert.Visible = false;
            // 
            // tbNameInsert
            // 
            this.tbNameInsert.Location = new System.Drawing.Point(261, 438);
            this.tbNameInsert.Name = "tbNameInsert";
            this.tbNameInsert.Size = new System.Drawing.Size(94, 22);
            this.tbNameInsert.TabIndex = 20;
            this.tbNameInsert.Visible = false;
            // 
            // labelLastNameInsert
            // 
            this.labelLastNameInsert.AutoSize = true;
            this.labelLastNameInsert.Location = new System.Drawing.Point(361, 418);
            this.labelLastNameInsert.Name = "labelLastNameInsert";
            this.labelLastNameInsert.Size = new System.Drawing.Size(131, 17);
            this.labelLastNameInsert.TabIndex = 23;
            this.labelLastNameInsert.Text = "Введите Фамилию";
            this.labelLastNameInsert.Visible = false;
            // 
            // tbLastNameInsert
            // 
            this.tbLastNameInsert.Location = new System.Drawing.Point(364, 438);
            this.tbLastNameInsert.Name = "tbLastNameInsert";
            this.tbLastNameInsert.Size = new System.Drawing.Size(131, 22);
            this.tbLastNameInsert.TabIndex = 22;
            this.tbLastNameInsert.Visible = false;
            // 
            // labelSubjectsInsert
            // 
            this.labelSubjectsInsert.AutoSize = true;
            this.labelSubjectsInsert.Location = new System.Drawing.Point(498, 418);
            this.labelSubjectsInsert.Name = "labelSubjectsInsert";
            this.labelSubjectsInsert.Size = new System.Drawing.Size(178, 17);
            this.labelSubjectsInsert.TabIndex = 25;
            this.labelSubjectsInsert.Text = "Введите ID предмета(-ов)";
            this.labelSubjectsInsert.Visible = false;
            // 
            // tbSubjectsInsert
            // 
            this.tbSubjectsInsert.Location = new System.Drawing.Point(501, 438);
            this.tbSubjectsInsert.Name = "tbSubjectsInsert";
            this.tbSubjectsInsert.Size = new System.Drawing.Size(210, 22);
            this.tbSubjectsInsert.TabIndex = 26;
            this.tbSubjectsInsert.Visible = false;
            // 
            // tbLecturersInsert
            // 
            this.tbLecturersInsert.Location = new System.Drawing.Point(364, 438);
            this.tbLecturersInsert.Name = "tbLecturersInsert";
            this.tbLecturersInsert.Size = new System.Drawing.Size(282, 22);
            this.tbLecturersInsert.TabIndex = 27;
            this.tbLecturersInsert.Visible = false;
            // 
            // labelLecturersInsert
            // 
            this.labelLecturersInsert.AutoSize = true;
            this.labelLecturersInsert.Location = new System.Drawing.Point(361, 418);
            this.labelLecturersInsert.Name = "labelLecturersInsert";
            this.labelLecturersInsert.Size = new System.Drawing.Size(217, 17);
            this.labelLecturersInsert.TabIndex = 28;
            this.labelLecturersInsert.Text = "Введите ID преподавателя(-ей)";
            this.labelLecturersInsert.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 498);
            this.Controls.Add(this.labelLecturersInsert);
            this.Controls.Add(this.tbLecturersInsert);
            this.Controls.Add(this.tbSubjectsInsert);
            this.Controls.Add(this.labelSubjectsInsert);
            this.Controls.Add(this.labelLastNameInsert);
            this.Controls.Add(this.tbLastNameInsert);
            this.Controls.Add(this.labelNameInsert);
            this.Controls.Add(this.tbNameInsert);
            this.Controls.Add(this.labelIDInsert);
            this.Controls.Add(this.tbIDInsert);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbSheetsForInsert);
            this.Controls.Add(this.cbChangingValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btInsertData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNewValue);
            this.Controls.Add(this.cbTables);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSheetsForUpdate);
            this.Controls.Add(this.btUpdateData);
            this.Controls.Add(this.dgvSubjects);
            this.Controls.Add(this.dgvLecturers);
            this.Controls.Add(this.btOutputData);
            this.Name = "Form1";
            this.Text = "Лаба 7";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLecturers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjects)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btOutputData;
        private System.Windows.Forms.DataGridView dgvLecturers;
        private System.Windows.Forms.DataGridView dgvSubjects;
        private System.Windows.Forms.Button btUpdateData;
        private System.Windows.Forms.ComboBox cbSheetsForUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTables;
        private System.Windows.Forms.TextBox tbNewValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btInsertData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbChangingValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbSheetsForInsert;
        private System.Windows.Forms.Label labelIDInsert;
        private System.Windows.Forms.TextBox tbIDInsert;
        private System.Windows.Forms.Label labelNameInsert;
        private System.Windows.Forms.TextBox tbNameInsert;
        private System.Windows.Forms.Label labelLastNameInsert;
        private System.Windows.Forms.TextBox tbLastNameInsert;
        private System.Windows.Forms.Label labelSubjectsInsert;
        private System.Windows.Forms.TextBox tbSubjectsInsert;
        private System.Windows.Forms.TextBox tbLecturersInsert;
        private System.Windows.Forms.Label labelLecturersInsert;
    }
}

