using System;

namespace AeroBase
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        private void InitializeComponent()
        {
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.btnOverview = new System.Windows.Forms.Button();
            this.btnDrones = new System.Windows.Forms.Button();
            this.btnParts = new System.Windows.Forms.Button();
            this.btnMaintenance = new System.Windows.Forms.Button();
            this.btnRules = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.lblTotalDronesLabel = new System.Windows.Forms.Label();
            this.lblTotalDrones = new System.Windows.Forms.Label();
            this.lblReadyDronesLabel = new System.Windows.Forms.Label();
            this.lblReadyDrones = new System.Windows.Forms.Label();
            this.lblMaintenanceDronesLabel = new System.Windows.Forms.Label();
            this.lblMaintenanceDrones = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvDrones = new System.Windows.Forms.DataGridView();
            this.btnAddDrone = new System.Windows.Forms.Button();
            this.btnEditDrone = new System.Windows.Forms.Button();
            this.btnEditDrone.Location = new System.Drawing.Point(540, 148);
            this.btnEditDrone.Name = "btnEditDrone";
            this.btnEditDrone.Size = new System.Drawing.Size(130, 27);
            this.btnEditDrone.TabIndex = 11;
            this.btnEditDrone.Text = "Изменить";
            this.btnEditDrone.UseVisualStyleBackColor = true;
            this.btnEditDrone.Click += new System.EventHandler(this.btnEditDrone_Click);
            this.panelMain.Controls.Add(this.btnEditDrone);
            this.btnDeleteDrone = new System.Windows.Forms.Button();
            this.panelSidebar.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrones)).BeginInit();
            this.SuspendLayout();
           
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(40)))), ((int)(((byte)(64)))));
            this.panelSidebar.Controls.Add(this.btnRules);
            this.panelSidebar.Controls.Add(this.btnMaintenance);
            this.panelSidebar.Controls.Add(this.btnParts);
            this.panelSidebar.Controls.Add(this.btnDrones);
            this.panelSidebar.Controls.Add(this.btnOverview);
            this.panelSidebar.Controls.Add(this.lblLogo);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(210, 750);
            this.panelSidebar.TabIndex = 0;
           
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(20, 20);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(113, 30);
            this.lblLogo.TabIndex = 0;
            
            this.btnOverview.FlatAppearance.BorderSize = 0;
            this.btnOverview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOverview.ForeColor = System.Drawing.Color.White;
            this.btnOverview.Location = new System.Drawing.Point(0, 70);
            this.btnOverview.Name = "btnOverview";
            this.btnOverview.Size = new System.Drawing.Size(210, 44);
            this.btnOverview.TabIndex = 1;
            this.btnOverview.Text = "Обзор";
            this.btnOverview.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOverview.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
          
            this.btnDrones.FlatAppearance.BorderSize = 0;
            this.btnDrones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrones.ForeColor = System.Drawing.Color.White;
            this.btnDrones.Location = new System.Drawing.Point(0, 114);
            this.btnDrones.Name = "btnDrones";
            this.btnDrones.Size = new System.Drawing.Size(210, 44);
            this.btnDrones.TabIndex = 2;
            this.btnDrones.Text = "Реестр БПЛА";
            this.btnDrones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDrones.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            
            this.btnParts.FlatAppearance.BorderSize = 0;
            this.btnParts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParts.ForeColor = System.Drawing.Color.White;
            this.btnParts.Location = new System.Drawing.Point(0, 158);
            this.btnParts.Name = "btnParts";
            this.btnParts.Size = new System.Drawing.Size(210, 44);
            this.btnParts.TabIndex = 3;
            this.btnParts.Text = "Комплектующие";
            this.btnParts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnParts.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            
            this.btnMaintenance.FlatAppearance.BorderSize = 0;
            this.btnMaintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaintenance.ForeColor = System.Drawing.Color.White;
            this.btnMaintenance.Location = new System.Drawing.Point(0, 202);
            this.btnMaintenance.Name = "btnMaintenance";
            this.btnMaintenance.Size = new System.Drawing.Size(210, 44);
            this.btnMaintenance.TabIndex = 4;
            this.btnMaintenance.Text = "Обслуживание";
            this.btnMaintenance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaintenance.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            
            this.btnRules.FlatAppearance.BorderSize = 0;
            this.btnRules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRules.ForeColor = System.Drawing.Color.White;
            this.btnRules.Location = new System.Drawing.Point(0, 246);
            this.btnRules.Name = "btnRules";
            this.btnRules.Size = new System.Drawing.Size(210, 44);
            this.btnRules.TabIndex = 5;
            this.btnRules.Text = "Правила";
            this.btnRules.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRules.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.panelMain.Controls.Add(this.btnDeleteDrone);
            this.panelMain.Controls.Add(this.btnAddDrone);
            this.panelMain.Controls.Add(this.dgvDrones);
            this.panelMain.Controls.Add(this.txtSearch);
            this.panelMain.Controls.Add(this.lblMaintenanceDrones);
            this.panelMain.Controls.Add(this.lblMaintenanceDronesLabel);
            this.panelMain.Controls.Add(this.lblReadyDrones);
            this.panelMain.Controls.Add(this.lblReadyDronesLabel);
            this.panelMain.Controls.Add(this.lblTotalDrones);
            this.panelMain.Controls.Add(this.lblTotalDronesLabel);
            this.panelMain.Controls.Add(this.lblPageTitle);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(210, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(20);
            this.panelMain.Size = new System.Drawing.Size(990, 750);
            this.panelMain.TabIndex = 1;
             
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPageTitle.Location = new System.Drawing.Point(23, 20);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(185, 37);
            this.lblPageTitle.TabIndex = 0;
            this.lblPageTitle.Text = "Реестр БПЛА"; 
           
            this.lblTotalDronesLabel.AutoSize = true;
            this.lblTotalDronesLabel.Location = new System.Drawing.Point(23, 70);
            this.lblTotalDronesLabel.Name = "lblTotalDronesLabel";
            this.lblTotalDronesLabel.Size = new System.Drawing.Size(90, 15);
            this.lblTotalDronesLabel.TabIndex = 1;
            this.lblTotalDronesLabel.Text = "Всего БПЛА:";
           
            this.lblTotalDrones.AutoSize = true;
            this.lblTotalDrones.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalDrones.Location = new System.Drawing.Point(23, 90);
            this.lblTotalDrones.Name = "lblTotalDrones";
            this.lblTotalDrones.Size = new System.Drawing.Size(26, 30);
            this.lblTotalDrones.TabIndex = 2;
            this.lblTotalDrones.Text = "0";
           
            this.lblReadyDronesLabel.AutoSize = true;
            this.lblReadyDronesLabel.Location = new System.Drawing.Point(150, 70);
            this.lblReadyDronesLabel.Name = "lblReadyDronesLabel";
            this.lblReadyDronesLabel.Size = new System.Drawing.Size(85, 15);
            this.lblReadyDronesLabel.TabIndex = 3;
            this.lblReadyDronesLabel.Text = "Исправные:";
           
            this.lblReadyDrones.AutoSize = true;
            this.lblReadyDrones.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReadyDrones.Location = new System.Drawing.Point(150, 90);
            this.lblReadyDrones.Name = "lblReadyDrones";
            this.lblReadyDrones.Size = new System.Drawing.Size(26, 30);
            this.lblReadyDrones.TabIndex = 4;
            this.lblReadyDrones.Text = "0";
            
            this.lblMaintenanceDronesLabel.AutoSize = true;
            this.lblMaintenanceDronesLabel.Location = new System.Drawing.Point(277, 70);
            this.lblMaintenanceDronesLabel.Name = "lblMaintenanceDronesLabel";
            this.lblMaintenanceDronesLabel.Size = new System.Drawing.Size(110, 15);
            this.lblMaintenanceDronesLabel.TabIndex = 5;
            this.lblMaintenanceDronesLabel.Text = "На обслуживании:";
            
            this.lblMaintenanceDrones.AutoSize = true;
            this.lblMaintenanceDrones.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMaintenanceDrones.Location = new System.Drawing.Point(277, 90);
            this.lblMaintenanceDrones.Name = "lblMaintenanceDrones";
            this.lblMaintenanceDrones.Size = new System.Drawing.Size(26, 30);
            this.lblMaintenanceDrones.TabIndex = 6;
            this.lblMaintenanceDrones.Text = "0";
            
            this.txtSearch.Location = new System.Drawing.Point(23, 150);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(300, 23);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            
            this.btnAddDrone.Location = new System.Drawing.Point(680, 148);
            this.btnAddDrone.Name = "btnAddDrone";
            this.btnAddDrone.Size = new System.Drawing.Size(130, 27);
            this.btnAddDrone.TabIndex = 8;
            this.btnAddDrone.Text = "Добавить запись";
            this.btnAddDrone.UseVisualStyleBackColor = true;
            this.btnAddDrone.Click += new System.EventHandler(this.btnAddDrone_Click);
            
            this.btnDeleteDrone.Location = new System.Drawing.Point(820, 148);
            this.btnDeleteDrone.Name = "btnDeleteDrone";
            this.btnDeleteDrone.Size = new System.Drawing.Size(130, 27);
            this.btnDeleteDrone.TabIndex = 9;
            this.btnDeleteDrone.Text = "Удалить";
            this.btnDeleteDrone.UseVisualStyleBackColor = true;
            this.btnDeleteDrone.Click += new System.EventHandler(this.btnDeleteDrone_Click);
             
            this.dgvDrones.AllowUserToAddRows = false;
            this.dgvDrones.AllowUserToDeleteRows = false;
            this.dgvDrones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDrones.BackgroundColor = System.Drawing.Color.White;
            this.dgvDrones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDrones.Location = new System.Drawing.Point(23, 190);
            this.dgvDrones.MultiSelect = false;
            this.dgvDrones.Name = "dgvDrones";
            this.dgvDrones.ReadOnly = true;
            this.dgvDrones.RowHeadersVisible = false;
            this.dgvDrones.RowTemplate.Height = 25;
            this.dgvDrones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDrones.Size = new System.Drawing.Size(927, 400);
            this.dgvDrones.TabIndex = 10; 
             
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 750);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelSidebar);
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AeroBase – учёт БПЛА";
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrones)).EndInit();
            this.ResumeLayout(false);

            System.Windows.Forms.Label lblHello = new System.Windows.Forms.Label();
            lblHello.AutoSize = true;
            lblHello.Location = new System.Drawing.Point(23, 610); 
            lblHello.Name = "lblHello";
            lblHello.Size = new System.Drawing.Size(100, 15);
            lblHello.Text = "Привет от Участника 1!";
            this.panelMain.Controls.Add(lblHello);
        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button btnOverview;
        private System.Windows.Forms.Button btnDrones;
        private System.Windows.Forms.Button btnParts;
        private System.Windows.Forms.Button btnMaintenance;
        private System.Windows.Forms.Button btnRules;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Label lblTotalDronesLabel;
        private System.Windows.Forms.Label lblTotalDrones;
        private System.Windows.Forms.Label lblReadyDronesLabel;
        private System.Windows.Forms.Label lblReadyDrones;
        private System.Windows.Forms.Label lblMaintenanceDronesLabel;
        private System.Windows.Forms.Label lblMaintenanceDrones;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAddDrone;
        private System.Windows.Forms.Button btnDeleteDrone;
        private System.Windows.Forms.DataGridView dgvDrones;
        private System.Windows.Forms.Button btnEditDrone;
    }
}
