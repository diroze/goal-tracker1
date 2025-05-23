using System;

namespace GoalTrackerApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBoxGoals = new System.Windows.Forms.ListBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.dateTimePickerDueDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-82, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1625, 846);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // listBoxGoals
            // 
            this.listBoxGoals.AccessibleName = "Ваша мета на таку дату:";
            this.listBoxGoals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.listBoxGoals.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxGoals.FormattingEnabled = true;
            this.listBoxGoals.ItemHeight = 19;
            this.listBoxGoals.Location = new System.Drawing.Point(25, 274);
            this.listBoxGoals.Name = "listBoxGoals";
            this.listBoxGoals.Size = new System.Drawing.Size(399, 289);
            this.listBoxGoals.TabIndex = 14;
            this.listBoxGoals.Click += new System.EventHandler(this.listBoxGoals_SelectedIndexChanged);
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.textBoxTitle.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTitle.Location = new System.Drawing.Point(610, 274);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(332, 45);
            this.textBoxTitle.TabIndex = 15;
            this.textBoxTitle.Text = "Назва мети...";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Yellow;
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.buttonAdd.Location = new System.Drawing.Point(610, 316);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(139, 40);
            this.buttonAdd.TabIndex = 18;
            this.buttonAdd.Text = "Додати мету";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.Yellow;
            this.buttonEdit.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.buttonEdit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonEdit.Location = new System.Drawing.Point(745, 316);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(197, 40);
            this.buttonEdit.TabIndex = 19;
            this.buttonEdit.Text = "Редагувати мету";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Red;
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.buttonDelete.Location = new System.Drawing.Point(610, 362);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(332, 53);
            this.buttonDelete.TabIndex = 20;
            this.buttonDelete.Text = "Видалити мету";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.Yellow;
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.buttonSave.Location = new System.Drawing.Point(610, 412);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(146, 44);
            this.buttonSave.TabIndex = 21;
            this.buttonSave.Text = "Зберегти мету...";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.BackColor = System.Drawing.Color.Yellow;
            this.buttonLoad.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.buttonLoad.Location = new System.Drawing.Point(745, 412);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(197, 44);
            this.buttonLoad.TabIndex = 22;
            this.buttonLoad.Text = "Завантажити мету";
            this.buttonLoad.UseVisualStyleBackColor = false;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // dateTimePickerDueDate
            // 
            this.dateTimePickerDueDate.AccessibleDescription = "";
            this.dateTimePickerDueDate.AllowDrop = true;
            this.dateTimePickerDueDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerDueDate.CalendarForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dateTimePickerDueDate.CalendarMonthBackground = System.Drawing.SystemColors.Highlight;
            this.dateTimePickerDueDate.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.dateTimePickerDueDate.CalendarTitleForeColor = System.Drawing.Color.Blue;
            this.dateTimePickerDueDate.CalendarTrailingForeColor = System.Drawing.Color.RosyBrown;
            this.dateTimePickerDueDate.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dateTimePickerDueDate.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDueDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePickerDueDate.Location = new System.Drawing.Point(980, 274);
            this.dateTimePickerDueDate.Name = "dateTimePickerDueDate";
            this.dateTimePickerDueDate.Size = new System.Drawing.Size(512, 30);
            this.dateTimePickerDueDate.TabIndex = 23;
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1540, 835);
            this.Controls.Add(this.dateTimePickerDueDate);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.listBoxGoals);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void MainForm_Load_1(object sender, EventArgs e)
        {

        }
        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBoxGoals;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.DateTimePicker dateTimePickerDueDate;
        private System.Windows.Forms.Label label1;
    }
}

