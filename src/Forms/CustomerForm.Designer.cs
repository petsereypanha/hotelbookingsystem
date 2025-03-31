using System.Windows.Forms;

namespace HotelBookingSystem.Forms
{
    partial class CustomerForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelCustomerId = new System.Windows.Forms.Label();
            this.textBoxCustomerId = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelContactInfo = new System.Windows.Forms.Label();
            this.textBoxContactInfo = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.dataGridViewCustomers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCustomerId
            // 
            this.labelCustomerId.AutoSize = true;
            this.labelCustomerId.Location = new System.Drawing.Point(12, 15);
            this.labelCustomerId.Name = "labelCustomerId";
            this.labelCustomerId.Size = new System.Drawing.Size(75, 13);
            this.labelCustomerId.TabIndex = 0;
            this.labelCustomerId.Text = "Customer ID:";
            // 
            // textBoxCustomerId
            // 
            this.textBoxCustomerId.Location = new System.Drawing.Point(93, 12);
            this.textBoxCustomerId.Name = "textBoxCustomerId";
            this.textBoxCustomerId.Size = new System.Drawing.Size(100, 20);
            this.textBoxCustomerId.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 41);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 13);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(93, 38);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 3;
            // 
            // labelContactInfo
            // 
            this.labelContactInfo.AutoSize = true;
            this.labelContactInfo.Location = new System.Drawing.Point(12, 67);
            this.labelContactInfo.Name = "labelContactInfo";
            this.labelContactInfo.Size = new System.Drawing.Size(75, 13);
            this.labelContactInfo.TabIndex = 4;
            this.labelContactInfo.Text = "Contact Info:";
            // 
            // textBoxContactInfo
            // 
            this.textBoxContactInfo.Location = new System.Drawing.Point(93, 64);
            this.textBoxContactInfo.Name = "textBoxContactInfo";
            this.textBoxContactInfo.Size = new System.Drawing.Size(100, 20);
            this.textBoxContactInfo.TabIndex = 5;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(15, 90);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(96, 90);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 7;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(177, 90);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 8;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCustomers
            // 
            this.dataGridViewCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomers.Location = new System.Drawing.Point(15, 119);
            this.dataGridViewCustomers.Name = "dataGridViewCustomers";
            this.dataGridViewCustomers.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewCustomers.TabIndex = 9;
            // 
            // CustomerForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 281);
            this.Controls.Add(this.dataGridViewCustomers);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxContactInfo);
            this.Controls.Add(this.labelContactInfo);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxCustomerId);
            this.Controls.Add(this.labelCustomerId);
            this.Name = "CustomerForm";
            this.Text = "Customer Management";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelCustomerId;
        private System.Windows.Forms.TextBox textBoxCustomerId;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelContactInfo;
        private System.Windows.Forms.TextBox textBoxContactInfo;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridView dataGridViewCustomers;
    }
}