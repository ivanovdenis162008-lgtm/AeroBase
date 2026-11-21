using System;
using System.Windows.Forms;
using AeroBase.Models;

namespace AeroBase
{
    public partial class DroneEditForm : Form
    {
        public Drone Result { get; private set; }
        private Drone _droneToEdit;

        public DroneEditForm()
        {
            InitializeComponent();
            SetupForm();
        }

        public DroneEditForm(Drone droneToEdit)
        {
            InitializeComponent();
            SetupForm();
            _droneToEdit = droneToEdit;

            txtDroneName.Text = _droneToEdit.Name;
            txtModel.Text = _droneToEdit.Model;
            txtInventoryNumber.Text = _droneToEdit.InventoryNumber;
            cmbDroneType.SelectedItem = _droneToEdit.Type;
            cmbDroneStatus.SelectedItem = _droneToEdit.Status;
            this.Text = "Редактирование БПЛА";
        }

        private void SetupForm()
        {
            cmbDroneType.Items.AddRange(new[] { "Квадрокоптер", "Самолётный", "Гибридный (VTOL)" });
            cmbDroneType.SelectedIndex = 0;
            cmbDroneStatus.Items.AddRange(new[] { "Исправен", "На обслуживании", "Неисправен" });
            cmbDroneStatus.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDroneName.Text) || string.IsNullOrWhiteSpace(txtInventoryNumber.Text))
            {
                MessageBox.Show("Название и инвентарный номер обязательны для заполнения.", "Ошибка");
                return;
            }

            if (_droneToEdit != null)
            {
                _droneToEdit.Name = txtDroneName.Text.Trim();
                _droneToEdit.Model = txtModel.Text.Trim();
                _droneToEdit.InventoryNumber = txtInventoryNumber.Text.Trim();
                _droneToEdit.Type = cmbDroneType.SelectedItem.ToString();
                _droneToEdit.Status = cmbDroneStatus.SelectedItem.ToString();
            }
            else
            {
                Result = new Drone
                {
                    Name = txtDroneName.Text.Trim(),
                    Model = txtModel.Text.Trim(),
                    InventoryNumber = txtInventoryNumber.Text.Trim(),
                    Type = cmbDroneType.SelectedItem.ToString(),
                    Status = cmbDroneStatus.SelectedItem.ToString()
                };
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}