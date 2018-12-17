namespace NewsTable
{
    partial class UserControlAddNew
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxHead = new System.Windows.Forms.TextBox();
            this.textBoxText = new System.Windows.Forms.TextBox();
            this.buttonAddNewT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxHead
            // 
            this.textBoxHead.Location = new System.Drawing.Point(299, 20);
            this.textBoxHead.Multiline = true;
            this.textBoxHead.Name = "textBoxHead";
            this.textBoxHead.Size = new System.Drawing.Size(239, 39);
            this.textBoxHead.TabIndex = 0;
            // 
            // textBoxText
            // 
            this.textBoxText.Location = new System.Drawing.Point(263, 76);
            this.textBoxText.Multiline = true;
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.Size = new System.Drawing.Size(331, 385);
            this.textBoxText.TabIndex = 1;
            // 
            // buttonAddNewT
            // 
            this.buttonAddNewT.Location = new System.Drawing.Point(600, 410);
            this.buttonAddNewT.Name = "buttonAddNewT";
            this.buttonAddNewT.Size = new System.Drawing.Size(147, 51);
            this.buttonAddNewT.TabIndex = 2;
            this.buttonAddNewT.Text = "Add";
            this.buttonAddNewT.UseVisualStyleBackColor = true;
            this.buttonAddNewT.Click += new System.EventHandler(this.buttonAddNewT_Click);
            // 
            // UserControlAddNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonAddNewT);
            this.Controls.Add(this.textBoxText);
            this.Controls.Add(this.textBoxHead);
            this.Name = "UserControlAddNew";
            this.Size = new System.Drawing.Size(800, 506);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxHead;
        private System.Windows.Forms.TextBox textBoxText;
        private System.Windows.Forms.Button buttonAddNewT;
    }
}
