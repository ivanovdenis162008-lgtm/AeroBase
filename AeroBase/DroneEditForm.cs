using System;
using System.Windows.Forms;
using AeroBase.Models;

namespace AeroBase
{
    public partial class DroneEditForm : Form
    {
        // Результат, который мы передадим обратно в MainForm
        public Drone Result { get; private set; }

        public DroneEditForm()
        {
            InitializeComponent();

            // Заполняем выпадающие списки
            cmbDroneType.Items.AddRange(new[] { "Квадрокоптер", "Самолётный", "Гибридный (VTOL)" });
            cmbDroneType.SelectedIndex = 0;

            cmbDroneStatus.Items.AddRange(new[] { "Исправен", "На обслуживании", "Неисправен" });
            cmbDroneStatus.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Проверка на пустые обязательные поля
            if (string.IsNullOrWhiteSpace(txtDroneName.Text) || string.IsNullOrWhiteSpace(txtInventoryNumber.Text))
            {
                MessageBox.Show("Название и инвентарный номер обязательны для заполнения.", "Ошибка");
                return;
            }

            // Формируем объект
            Result = new Drone
            {
                Name = txtDroneName.Text.Trim(),
                Model = txtModel.Text.Trim(),
                InventoryNumber = txtInventoryNumber.Text.Trim(),
                Type = cmbDroneType.SelectedItem.ToString(),
                Status = cmbDroneStatus.SelectedItem.ToString()
            };

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