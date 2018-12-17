namespace NewsTable
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
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.labelHead = new System.Windows.Forms.Label();
            this.labelText = new System.Windows.Forms.Label();
            this.buttonAddNew = new System.Windows.Forms.Button();
            this.buttonMain = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonAddComment = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.labelComment = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxCommentAdd = new System.Windows.Forms.TextBox();
            this.userControlAddNew1 = new NewsTable.UserControlAddNew();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLeft
            // 
            this.buttonLeft.Location = new System.Drawing.Point(945, 74);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(139, 60);
            this.buttonLeft.TabIndex = 0;
            this.buttonLeft.Text = "<===";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Location = new System.Drawing.Point(945, 150);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(139, 60);
            this.buttonRight.TabIndex = 1;
            this.buttonRight.Text = "===>";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // labelHead
            // 
            this.labelHead.AutoSize = true;
            this.labelHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHead.Location = new System.Drawing.Point(436, 22);
            this.labelHead.Name = "labelHead";
            this.labelHead.Size = new System.Drawing.Size(46, 31);
            this.labelHead.TabIndex = 2;
            this.labelHead.Text = "....";
            this.labelHead.Click += new System.EventHandler(this.labelHead_Click);
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Location = new System.Drawing.Point(354, 74);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(35, 13);
            this.labelText.TabIndex = 3;
            this.labelText.Text = "label1";
            // 
            // buttonAddNew
            // 
            this.buttonAddNew.Location = new System.Drawing.Point(13, 22);
            this.buttonAddNew.Name = "buttonAddNew";
            this.buttonAddNew.Size = new System.Drawing.Size(140, 23);
            this.buttonAddNew.TabIndex = 5;
            this.buttonAddNew.Text = "ADD New";
            this.buttonAddNew.UseVisualStyleBackColor = true;
            this.buttonAddNew.Click += new System.EventHandler(this.buttonAddNew_Click);
            // 
            // buttonMain
            // 
            this.buttonMain.Location = new System.Drawing.Point(13, 74);
            this.buttonMain.Name = "buttonMain";
            this.buttonMain.Size = new System.Drawing.Size(140, 23);
            this.buttonMain.TabIndex = 6;
            this.buttonMain.Text = "Main";
            this.buttonMain.UseVisualStyleBackColor = true;
            this.buttonMain.Click += new System.EventHandler(this.buttonMain_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(945, 22);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(115, 46);
            this.buttonRefresh.TabIndex = 0;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonAddComment
            // 
            this.buttonAddComment.Location = new System.Drawing.Point(970, 281);
            this.buttonAddComment.Name = "buttonAddComment";
            this.buttonAddComment.Size = new System.Drawing.Size(114, 23);
            this.buttonAddComment.TabIndex = 8;
            this.buttonAddComment.Text = "Add Comment";
            this.buttonAddComment.UseVisualStyleBackColor = true;
            this.buttonAddComment.Click += new System.EventHandler(this.buttonAddComment_Click);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(413, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 157);
            this.vScrollBar1.TabIndex = 0;
            // 
            // labelComment
            // 
            this.labelComment.AutoSize = true;
            this.labelComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelComment.Location = new System.Drawing.Point(32, 18);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(0, 31);
            this.labelComment.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.labelComment);
            this.panel1.Controls.Add(this.vScrollBar1);
            this.panel1.Location = new System.Drawing.Point(708, 310);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 157);
            this.panel1.TabIndex = 4;
            // 
            // textBoxCommentAdd
            // 
            this.textBoxCommentAdd.Location = new System.Drawing.Point(773, 216);
            this.textBoxCommentAdd.Multiline = true;
            this.textBoxCommentAdd.Name = "textBoxCommentAdd";
            this.textBoxCommentAdd.Size = new System.Drawing.Size(352, 49);
            this.textBoxCommentAdd.TabIndex = 9;
            // 
            // userControlAddNew1
            // 
            this.userControlAddNew1.Location = new System.Drawing.Point(338, -3);
            this.userControlAddNew1.Name = "userControlAddNew1";
            this.userControlAddNew1.Size = new System.Drawing.Size(800, 506);
            this.userControlAddNew1.TabIndex = 7;
            this.userControlAddNew1.Load += new System.EventHandler(this.userControlAddNew1_Load_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 467);
            this.Controls.Add(this.textBoxCommentAdd);
            this.Controls.Add(this.buttonAddComment);
            this.Controls.Add(this.userControlAddNew1);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonMain);
            this.Controls.Add(this.buttonAddNew);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.labelHead);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonLeft);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Label labelHead;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Button buttonAddNew;
        private System.Windows.Forms.Button buttonMain;
        private System.Windows.Forms.Button buttonRefresh;
        private UserControlAddNew userControlAddNew1;
        private System.Windows.Forms.Button buttonAddComment;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Label labelComment;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxCommentAdd;
    }
}

