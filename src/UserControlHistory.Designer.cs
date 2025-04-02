namespace HotelBookingSystem
{
    partial class UserControlHistory
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            dgvBookingHistory = new DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBookingHistory).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 20F, FontStyle.Bold);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(33, 30);
            label1.Name = "label1";
            label1.Size = new Size(221, 37);
            label1.TabIndex = 22;
            label1.Text = "Booking History";
            // 
            // dgvBookingHistory
            // 
            dgvBookingHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookingHistory.Columns.AddRange(new DataGridViewColumn[] { Column2, Column3, Column4, Column5, Column6, Column8 });
            dgvBookingHistory.Location = new Point(16, 143);
            dgvBookingHistory.Name = "dgvBookingHistory";
            dgvBookingHistory.Size = new Size(1165, 509);
            dgvBookingHistory.TabIndex = 21;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Booking ID";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "Customer";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.HeaderText = "Room ID";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column5.HeaderText = "Start Date";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column6.HeaderText = "End Date";
            Column6.Name = "Column6";
            // 
            // Column8
            // 
            Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column8.HeaderText = "Payment Status";
            Column8.Name = "Column8";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.Location = new Point(660, 83);
            label2.Name = "label2";
            label2.Size = new Size(69, 25);
            label2.TabIndex = 23;
            label2.Text = "Sort By";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11F);
            button1.Location = new Point(757, 74);
            button1.Name = "button1";
            button1.Size = new Size(131, 43);
            button1.TabIndex = 24;
            button1.Text = "Date";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 11F);
            button2.Location = new Point(894, 74);
            button2.Name = "button2";
            button2.Size = new Size(171, 43);
            button2.TabIndex = 25;
            button2.Text = "Payment Status";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 11F);
            button3.Location = new Point(1071, 74);
            button3.Name = "button3";
            button3.Size = new Size(108, 43);
            button3.TabIndex = 26;
            button3.Text = "Reset";
            button3.UseVisualStyleBackColor = true;
            // 
            // UserControlHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvBookingHistory);
            Name = "UserControlHistory";
            Size = new Size(1197, 682);
            Load += UserControlHistory_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBookingHistory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvBookingHistory;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column8;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
