namespace pract
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
            this.buttonSortSalary = new System.Windows.Forms.Button();
            this.buttonFindManagers = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.listBoxLog = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonSortSalary
            // 
            this.buttonSortSalary.Location = new System.Drawing.Point(396, 280);
            this.buttonSortSalary.Name = "buttonSortSalary";
            this.buttonSortSalary.Size = new System.Drawing.Size(120, 42);
            this.buttonSortSalary.TabIndex = 9;
            this.buttonSortSalary.Text = "Сортировать";
            this.buttonSortSalary.UseVisualStyleBackColor = true;
            // 
            // buttonFindManagers
            // 
            this.buttonFindManagers.Location = new System.Drawing.Point(268, 280);
            this.buttonFindManagers.Name = "buttonFindManagers";
            this.buttonFindManagers.Size = new System.Drawing.Size(120, 42);
            this.buttonFindManagers.TabIndex = 8;
            this.buttonFindManagers.Text = "Найти менеджеров";
            this.buttonFindManagers.UseVisualStyleBackColor = true;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(140, 280);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(120, 42);
            this.buttonRemove.TabIndex = 7;
            this.buttonRemove.Text = "Удалить ID=4";
            this.buttonRemove.UseVisualStyleBackColor = true;
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(12, 280);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(120, 42);
            this.buttonInsert.TabIndex = 6;
            this.buttonInsert.Text = "Вставить перед ID=3 ";
            this.buttonInsert.UseMnemonic = false;
            this.buttonInsert.UseVisualStyleBackColor = true;
            // 
            // listBoxLog
            // 
            this.listBoxLog.FormattingEnabled = true;
            this.listBoxLog.HorizontalScrollbar = true;
            this.listBoxLog.ItemHeight = 16;
            this.listBoxLog.Location = new System.Drawing.Point(12, 12);
            this.listBoxLog.Name = "listBoxLog";
            this.listBoxLog.ScrollAlwaysVisible = true;
            this.listBoxLog.Size = new System.Drawing.Size(600, 244);
            this.listBoxLog.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSortSalary);
            this.Controls.Add(this.buttonFindManagers);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.listBoxLog);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSortSalary;
        private System.Windows.Forms.Button buttonFindManagers;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.ListBox listBoxLog;
    }
}

