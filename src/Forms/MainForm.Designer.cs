using System;
            using System.ComponentModel;
            using System.Drawing;
            using System.Windows.Forms;
            
            namespace HotelBookingSystem.Forms
            {
                partial class MainForm : Form
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
                        this.menuStrip = new System.Windows.Forms.MenuStrip();
                        this.bookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                        this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                        this.roomManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                        this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                        this.menuStrip.SuspendLayout();
                        this.SuspendLayout();
                        // 
                        // menuStrip
                        // 
                        this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                        this.bookingToolStripMenuItem,
                        this.customerToolStripMenuItem,
                        this.roomManagementToolStripMenuItem,
                        this.reportToolStripMenuItem});
                        this.menuStrip.Location = new System.Drawing.Point(0, 0);
                        this.menuStrip.Name = "menuStrip";
                        this.menuStrip.Size = new System.Drawing.Size(800, 24);
                        this.menuStrip.TabIndex = 0;
                        this.menuStrip.Text = "menuStrip";
                        // customerToolStripMenuItem
                        // 
                        this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
                        this.customerToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
                        this.customerToolStripMenuItem.Text = "Customer";
                        this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
                        // 
                        // roomManagementToolStripMenuItem
                        // 
                        this.roomManagementToolStripMenuItem.Name = "roomManagementToolStripMenuItem";
                        this.roomManagementToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
                        this.roomManagementToolStripMenuItem.Text = "Room Management";
                        this.roomManagementToolStripMenuItem.Click += new System.EventHandler(this.roomManagementToolStripMenuItem_Click);
                        // 
                        // reportToolStripMenuItem
                        // 
                        this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
                        this.reportToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
                        this.reportToolStripMenuItem.Text = "Report";
                        this.reportToolStripMenuItem.Click += new System.EventHandler(this.reportToolStripMenuItem_Click);
                        // 
                        // MainForm
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.ClientSize = new System.Drawing.Size(800, 450);
                        this.Controls.Add(this.menuStrip);
                        this.MainMenuStrip = this.menuStrip;
                        this.Name = "MainForm";
                        this.Text = "Hotel Management System";
                        this.menuStrip.ResumeLayout(false);
                        this.menuStrip.PerformLayout();
                        this.ResumeLayout(false);
                        this.PerformLayout();
                    }
            
                    private System.Windows.Forms.MenuStrip menuStrip;
                    private System.Windows.Forms.ToolStripMenuItem bookingToolStripMenuItem;
                    private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
                    private System.Windows.Forms.ToolStripMenuItem roomManagementToolStripMenuItem;
                    private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
                }
            }