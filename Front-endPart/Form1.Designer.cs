namespace Front_endPart
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvTasks = new System.Windows.Forms.DataGridView();
            this.btnShowData = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnShowHistory = new System.Windows.Forms.Button();
            this.btnCloseHistory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTasks
            // 
            this.dgvTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTasks.Location = new System.Drawing.Point(87, 92);
            this.dgvTasks.Name = "dgvTasks";
            this.dgvTasks.RowHeadersWidth = 51;
            this.dgvTasks.RowTemplate.Height = 29;
            this.dgvTasks.Size = new System.Drawing.Size(824, 428);
            this.dgvTasks.TabIndex = 0;
            this.dgvTasks.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTasks_RowLeave);
            this.dgvTasks.SelectionChanged += new System.EventHandler(this.dgvTasks_SelectionChanged);
            // 
            // btnShowData
            // 
            this.btnShowData.Location = new System.Drawing.Point(31, 12);
            this.btnShowData.Name = "btnShowData";
            this.btnShowData.Size = new System.Drawing.Size(149, 55);
            this.btnShowData.TabIndex = 1;
            this.btnShowData.Text = "Показати всі завдання, оновити";
            this.btnShowData.UseVisualStyleBackColor = true;
            this.btnShowData.Click += new System.EventHandler(this.btnShowData_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(222, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(149, 55);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Додати нове завдання";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(435, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(149, 55);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Видалити завдання";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(635, 12);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(149, 55);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Опції обраного завдання";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(815, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(149, 55);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Видалити ВСЕ, очистити базу";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnShowHistory
            // 
            this.btnShowHistory.Location = new System.Drawing.Point(396, 526);
            this.btnShowHistory.Name = "btnShowHistory";
            this.btnShowHistory.Size = new System.Drawing.Size(243, 80);
            this.btnShowHistory.TabIndex = 6;
            this.btnShowHistory.Text = "Показати історію останніх 10 видалених, чи виконаних завдань";
            this.btnShowHistory.UseVisualStyleBackColor = true;
            this.btnShowHistory.Click += new System.EventHandler(this.btnShowHistory_Click);
            // 
            // btnCloseHistory
            // 
            this.btnCloseHistory.Enabled = false;
            this.btnCloseHistory.Location = new System.Drawing.Point(678, 526);
            this.btnCloseHistory.Name = "btnCloseHistory";
            this.btnCloseHistory.Size = new System.Drawing.Size(243, 80);
            this.btnCloseHistory.TabIndex = 7;
            this.btnCloseHistory.Text = "Закрити історію";
            this.btnCloseHistory.UseVisualStyleBackColor = true;
            this.btnCloseHistory.Click += new System.EventHandler(this.btnCloseHistory_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 618);
            this.Controls.Add(this.btnCloseHistory);
            this.Controls.Add(this.btnShowHistory);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnShowData);
            this.Controls.Add(this.dgvTasks);
            this.Name = "MainForm";
            this.Text = "Головна форма програми";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvTasks;
        private Button btnShowData;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnClear;
        private Button btnShowHistory;
        private Button btnCloseHistory;
    }
}