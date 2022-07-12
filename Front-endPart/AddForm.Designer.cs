namespace Front_endPart
{
    partial class AddForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbDeadLine = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.cbPriority = new System.Windows.Forms.ComboBox();
            this.chbIsCompleted = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Заголовок завдання";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пріоритет";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Кінцевий час виконання";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Детальний опис";
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(228, 67);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(186, 27);
            this.tbTitle.TabIndex = 5;
            // 
            // tbDeadLine
            // 
            this.tbDeadLine.Location = new System.Drawing.Point(228, 245);
            this.tbDeadLine.Name = "tbDeadLine";
            this.tbDeadLine.Size = new System.Drawing.Size(186, 27);
            this.tbDeadLine.TabIndex = 6;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(218, 307);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(186, 77);
            this.tbDescription.TabIndex = 7;
            // 
            // cbPriority
            // 
            this.cbPriority.FormattingEnabled = true;
            this.cbPriority.Items.AddRange(new object[] {
            "Низький",
            "Середній",
            "Високий"});
            this.cbPriority.Location = new System.Drawing.Point(228, 145);
            this.cbPriority.Name = "cbPriority";
            this.cbPriority.Size = new System.Drawing.Size(151, 28);
            this.cbPriority.TabIndex = 8;
            // 
            // chbIsCompleted
            // 
            this.chbIsCompleted.AutoSize = true;
            this.chbIsCompleted.Enabled = false;
            this.chbIsCompleted.Location = new System.Drawing.Point(12, 414);
            this.chbIsCompleted.Name = "chbIsCompleted";
            this.chbIsCompleted.Size = new System.Drawing.Size(442, 24);
            this.chbIsCompleted.TabIndex = 9;
            this.chbIsCompleted.Text = "Позначити як виконане (Доступно тільки при редагуванні)";
            this.chbIsCompleted.UseVisualStyleBackColor = true;
            this.chbIsCompleted.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.chbIsCompleted.Click += new System.EventHandler(this.chbIsCompleted_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(514, 450);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(109, 38);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "Додати";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(652, 450);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 38);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Скасувати";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 500);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.chbIsCompleted);
            this.Controls.Add(this.cbPriority);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.tbDeadLine);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddForm";
            this.Text = "Додати нове завдання";
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbTitle;
        private TextBox tbDeadLine;
        private TextBox tbDescription;
        private ComboBox cbPriority;
        private CheckBox chbIsCompleted;
        private Button btnOK;
        private Button btnCancel;
    }
}