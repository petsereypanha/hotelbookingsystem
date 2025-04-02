namespace HotelBookingSystem.src
{
    partial class RoomDetail
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
            dgvHotelList = new DataGridView();
            label1 = new Label();
            btnAddRoom = new Button();
            btnUpdateRoom = new Button();
            btnDeleteRoom = new Button();
            txtRoomId = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtRoomPrice = new TextBox();
            cbRoomType = new ComboBox();
            label5 = new Label();
            cbIsAvailable = new ComboBox();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvHotelList).BeginInit();
            SuspendLayout();
            // 
            // dgvHotelList
            // 
            dgvHotelList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHotelList.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dgvHotelList.Location = new Point(44, 95);
            dgvHotelList.Name = "dgvHotelList";
            dgvHotelList.Size = new Size(592, 436);
            dgvHotelList.TabIndex = 50;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 20F, FontStyle.Bold);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(44, 33);
            label1.Name = "label1";
            label1.Size = new Size(176, 37);
            label1.TabIndex = 51;
            label1.Text = "Room Detail";
            // 
            // btnAddRoom
            // 
            btnAddRoom.BackColor = Color.MediumSeaGreen;
            btnAddRoom.Font = new Font("Segoe UI", 12F);
            btnAddRoom.ForeColor = Color.White;
            btnAddRoom.Location = new Point(673, 494);
            btnAddRoom.Name = "btnAddRoom";
            btnAddRoom.Size = new Size(140, 37);
            btnAddRoom.TabIndex = 52;
            btnAddRoom.Text = "Add";
            btnAddRoom.UseVisualStyleBackColor = false;
            // 
            // btnUpdateRoom
            // 
            btnUpdateRoom.BackColor = Color.DarkKhaki;
            btnUpdateRoom.Font = new Font("Segoe UI", 12F);
            btnUpdateRoom.ForeColor = Color.White;
            btnUpdateRoom.Location = new Point(858, 494);
            btnUpdateRoom.Name = "btnUpdateRoom";
            btnUpdateRoom.Size = new Size(140, 37);
            btnUpdateRoom.TabIndex = 53;
            btnUpdateRoom.Text = "Update";
            btnUpdateRoom.UseVisualStyleBackColor = false;
            // 
            // btnDeleteRoom
            // 
            btnDeleteRoom.BackColor = Color.Brown;
            btnDeleteRoom.Font = new Font("Segoe UI", 12F);
            btnDeleteRoom.ForeColor = Color.White;
            btnDeleteRoom.Location = new Point(1033, 494);
            btnDeleteRoom.Name = "btnDeleteRoom";
            btnDeleteRoom.Size = new Size(140, 37);
            btnDeleteRoom.TabIndex = 54;
            btnDeleteRoom.Text = "Delete";
            btnDeleteRoom.UseVisualStyleBackColor = false;
            // 
            // txtRoomId
            // 
            txtRoomId.Font = new Font("Segoe UI", 14F);
            txtRoomId.Location = new Point(876, 146);
            txtRoomId.Name = "txtRoomId";
            txtRoomId.Size = new Size(166, 32);
            txtRoomId.TabIndex = 55;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(736, 149);
            label2.Name = "label2";
            label2.Size = new Size(83, 25);
            label2.TabIndex = 56;
            label2.Text = "Room ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(736, 195);
            label3.Name = "label3";
            label3.Size = new Size(104, 25);
            label3.TabIndex = 58;
            label3.Text = "Room Type";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(736, 249);
            label4.Name = "label4";
            label4.Size = new Size(107, 25);
            label4.TabIndex = 60;
            label4.Text = "Room Price";
            // 
            // txtRoomPrice
            // 
            txtRoomPrice.Font = new Font("Segoe UI", 14F);
            txtRoomPrice.Location = new Point(876, 246);
            txtRoomPrice.Name = "txtRoomPrice";
            txtRoomPrice.Size = new Size(166, 32);
            txtRoomPrice.TabIndex = 59;
            // 
            // cbRoomType
            // 
            cbRoomType.Font = new Font("Segoe UI", 14F);
            cbRoomType.FormattingEnabled = true;
            cbRoomType.Items.AddRange(new object[] { "Standard", "Premium" });
            cbRoomType.Location = new Point(876, 195);
            cbRoomType.Name = "cbRoomType";
            cbRoomType.Size = new Size(166, 33);
            cbRoomType.TabIndex = 65;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(736, 300);
            label5.Name = "label5";
            label5.Size = new Size(107, 25);
            label5.TabIndex = 66;
            label5.Text = "Is Available";
            // 
            // cbIsAvailable
            // 
            cbIsAvailable.Font = new Font("Segoe UI", 14F);
            cbIsAvailable.FormattingEnabled = true;
            cbIsAvailable.Location = new Point(876, 300);
            cbIsAvailable.Name = "cbIsAvailable";
            cbIsAvailable.Size = new Size(166, 33);
            cbIsAvailable.TabIndex = 67;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "Room ID";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Room Type";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "Price";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.HeaderText = "AvailabilityStatus";
            Column4.Name = "Column4";
            // 
            // RoomDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cbIsAvailable);
            Controls.Add(label5);
            Controls.Add(cbRoomType);
            Controls.Add(label4);
            Controls.Add(txtRoomPrice);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtRoomId);
            Controls.Add(btnDeleteRoom);
            Controls.Add(btnUpdateRoom);
            Controls.Add(btnAddRoom);
            Controls.Add(label1);
            Controls.Add(dgvHotelList);
            Name = "RoomDetail";
            Size = new Size(1197, 682);
            ((System.ComponentModel.ISupportInitialize)dgvHotelList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvHotelList;
        private Label label1;
        private Button btnAddRoom;
        private Button btnUpdateRoom;
        private Button btnDeleteRoom;
        private TextBox txtRoomId;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtRoomPrice;
        private ComboBox cbRoomType;
        private Label label5;
        private ComboBox cbIsAvailable;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}
