namespace HotelBookingSystem
{
    partial class UserControlCustomer
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label1 = new Label();
            dgvCustomer = new DataGridView();
            Column4 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            label5 = new Label();
            label4 = new Label();
            txtCustomerPhone = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtCustomerId = new TextBox();
            btnDeleteRoom = new Button();
            btnUpdateRoom = new Button();
            btnAddRoom = new Button();
            label6 = new Label();
            txtCustomerName = new TextBox();
            txtCustomerEmail = new TextBox();
            txtCustomerAddress = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Vanna-English Kbach Khmer", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(40, 36);
            label1.Name = "label1";
            label1.Size = new Size(150, 17);
            label1.TabIndex = 5;
            label1.Text = "Customer List";
            // 
            // dgvCustomer
            // 
            dgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomer.Columns.AddRange(new DataGridViewColumn[] { Column4, Column2, Column3, Column1, Column5 });
            dgvCustomer.Location = new Point(33, 66);
            dgvCustomer.Name = "dgvCustomer";
            dgvCustomer.Size = new Size(547, 551);
            dgvCustomer.TabIndex = 6;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.HeaderText = "ID";
            Column4.Name = "Column4";
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Name";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Phone";
            Column3.Name = "Column3";
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "Email";
            Column1.Name = "Column1";
            // 
            // Column5
            // 
            Column5.HeaderText = "Address";
            Column5.Name = "Column5";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(684, 298);
            label5.Name = "label5";
            label5.Size = new Size(58, 25);
            label5.TabIndex = 77;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(684, 247);
            label4.Name = "label4";
            label4.Size = new Size(66, 25);
            label4.TabIndex = 75;
            label4.Text = "Phone";
            // 
            // txtCustomerPhone
            // 
            txtCustomerPhone.Font = new Font("Segoe UI", 14F);
            txtCustomerPhone.Location = new Point(824, 244);
            txtCustomerPhone.Name = "txtCustomerPhone";
            txtCustomerPhone.Size = new Size(166, 32);
            txtCustomerPhone.TabIndex = 74;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(684, 193);
            label3.Name = "label3";
            label3.Size = new Size(62, 25);
            label3.TabIndex = 73;
            label3.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(684, 147);
            label2.Name = "label2";
            label2.Size = new Size(116, 25);
            label2.TabIndex = 72;
            label2.Text = "Customer ID";
            // 
            // txtCustomerId
            // 
            txtCustomerId.Font = new Font("Segoe UI", 14F);
            txtCustomerId.Location = new Point(824, 144);
            txtCustomerId.Name = "txtCustomerId";
            txtCustomerId.Size = new Size(166, 32);
            txtCustomerId.TabIndex = 71;
            // 
            // btnDeleteRoom
            // 
            btnDeleteRoom.BackColor = Color.Brown;
            btnDeleteRoom.Font = new Font("Segoe UI", 12F);
            btnDeleteRoom.ForeColor = Color.White;
            btnDeleteRoom.Location = new Point(981, 492);
            btnDeleteRoom.Name = "btnDeleteRoom";
            btnDeleteRoom.Size = new Size(140, 37);
            btnDeleteRoom.TabIndex = 70;
            btnDeleteRoom.Text = "Delete";
            btnDeleteRoom.UseVisualStyleBackColor = false;
            // 
            // btnUpdateRoom
            // 
            btnUpdateRoom.BackColor = Color.DarkKhaki;
            btnUpdateRoom.Font = new Font("Segoe UI", 12F);
            btnUpdateRoom.ForeColor = Color.White;
            btnUpdateRoom.Location = new Point(806, 492);
            btnUpdateRoom.Name = "btnUpdateRoom";
            btnUpdateRoom.Size = new Size(140, 37);
            btnUpdateRoom.TabIndex = 69;
            btnUpdateRoom.Text = "Update";
            btnUpdateRoom.UseVisualStyleBackColor = false;
            // 
            // btnAddRoom
            // 
            btnAddRoom.BackColor = Color.MediumSeaGreen;
            btnAddRoom.Font = new Font("Segoe UI", 12F);
            btnAddRoom.ForeColor = Color.White;
            btnAddRoom.Location = new Point(621, 492);
            btnAddRoom.Name = "btnAddRoom";
            btnAddRoom.Size = new Size(140, 37);
            btnAddRoom.TabIndex = 68;
            btnAddRoom.Text = "Add";
            btnAddRoom.UseVisualStyleBackColor = false;
            btnAddRoom.Click += btnAddRoom_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F);
            label6.Location = new Point(688, 351);
            label6.Name = "label6";
            label6.Size = new Size(79, 25);
            label6.TabIndex = 79;
            label6.Text = "Address";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Font = new Font("Segoe UI", 14F);
            txtCustomerName.Location = new Point(824, 190);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(166, 32);
            txtCustomerName.TabIndex = 80;
            // 
            // txtCustomerEmail
            // 
            txtCustomerEmail.Font = new Font("Segoe UI", 14F);
            txtCustomerEmail.Location = new Point(824, 298);
            txtCustomerEmail.Name = "txtCustomerEmail";
            txtCustomerEmail.Size = new Size(166, 32);
            txtCustomerEmail.TabIndex = 81;
            // 
            // txtCustomerAddress
            // 
            txtCustomerAddress.Font = new Font("Segoe UI", 14F);
            txtCustomerAddress.Location = new Point(824, 351);
            txtCustomerAddress.Name = "txtCustomerAddress";
            txtCustomerAddress.Size = new Size(166, 32);
            txtCustomerAddress.TabIndex = 82;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Vanna-English Kbach Khmer", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DarkRed;
            label7.Location = new Point(633, 36);
            label7.Name = "label7";
            label7.Size = new Size(202, 17);
            label7.TabIndex = 83;
            label7.Text = "Customer Register";
            // 
            // UserControlCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label7);
            Controls.Add(txtCustomerAddress);
            Controls.Add(txtCustomerEmail);
            Controls.Add(txtCustomerName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtCustomerPhone);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtCustomerId);
            Controls.Add(btnDeleteRoom);
            Controls.Add(btnUpdateRoom);
            Controls.Add(btnAddRoom);
            Controls.Add(dgvCustomer);
            Controls.Add(label1);
            Name = "UserControlCustomer";
            Size = new Size(1197, 682);
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private Label label1;
        private DataGridView dgvCustomer;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column5;
        private Label label5;
        private Label label4;
        private TextBox txtCustomerPhone;
        private Label label3;
        private Label label2;
        private TextBox txtCustomerId;
        private Button btnDeleteRoom;
        private Button btnUpdateRoom;
        private Button btnAddRoom;
        private Label label6;
        private TextBox txtCustomerName;
        private TextBox txtCustomerEmail;
        private TextBox txtCustomerAddress;
        private Label label7;
    }
}
