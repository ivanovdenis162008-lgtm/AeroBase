namespace AeroBase
{
    partial class DroneEditForm
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
            this.txtDroneName = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtInventoryNumber = new System.Windows.Forms.TextBox();
            this.cmbDroneType = new System.Windows.Forms.ComboBox();
            this.cmbDroneStatus = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // txtDroneName
            this.txtDroneName.Location = new System.Drawing.Point(150, 20);
            this.txtDroneName.Name = "txtDroneName";
            this.txtDroneName.Size = new System.Drawing.Size(200, 23);
            this.txtDroneName.TabIndex = 0;

            // txtModel
            this.txtModel.Location = new System.Drawing.Point(150, 60);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(200, 23);
            this.txtModel.TabIndex = 1;

            // txtInventoryNumber
            this.txtInventoryNumber.Location = new System.Drawing.Point(150, 100);
            this.txtInventoryNumber.Name = "txtInventoryNumber";
            this.txtInventoryNumber.Size = new System.Drawing.Size(200, 23);
            this.txtInventoryNumber.TabIndex = 2;

            // cmbDroneType
            this.cmbDroneType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDroneType.FormattingEnabled = true;
            this.cmbDroneType.Location = new System.Drawing.Point(150, 140);
            this.cmbDroneType.Name = "cmbDroneType";
            this.cmbDroneType.Size = new System.Drawing.Size(200, 23);
            this.cmbDroneType.TabIndex = 3;

            // cmbDroneStatus
            this.cmbDroneStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDroneStatus.FormattingEnabled = true;
            this.cmbDroneStatus.Location = new System.Drawing.Point(150, 180);
            this.cmbDroneStatus.Name = "cmbDroneStatus";
            this.cmbDroneStatus.Size = new System.Drawing.Size(200, 23);
            this.cmbDroneStatus.TabIndex = 4;

            // btnSave
            this.btnSave.Location = new System.Drawing.Point(150, 230);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 30);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // btnCancel
            this.btnCancel.Location = new System.Drawing.Point(255, 230);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 30);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // label1-5
            this.label1.AutoSize = true; this.label1.Location = new System.Drawing.Point(20, 23); this.label1.Text = "Название:";
            this.label2.AutoSize = true; this.label2.Location = new System.Drawing.Point(20, 63); this.label2.Text = "Модель:";
            this.label3.AutoSize = true; this.label3.Location = new System.Drawing.Point(20, 103); this.label3.Text = "Инв. номер:";
            this.label4.AutoSize = true; this.label4.Location = new System.Drawing.Point(20, 143); this.label4.Text = "Тип:";
            this.label5.AutoSize = true; this.label5.Location = new System.Drawing.Point(20, 183); this.label5.Text = "Состояние:";

            // DroneEditForm
            this.ClientSize = new System.Drawing.Size(380, 280);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbDroneStatus);
            this.Controls.Add(this.cmbDroneType);
            this.Controls.Add(this.txtInventoryNumber);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtDroneName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DroneEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление / Редактирование БПЛА";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtDroneName;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtInventoryNumber;
        private System.Windows.Forms.ComboBox cmbDroneType;
        private System.Windows.Forms.ComboBox cmbDroneStatus;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}