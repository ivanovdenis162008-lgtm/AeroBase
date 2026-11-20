using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AeroBase.Models;

namespace AeroBase
{
    public partial class MainForm : Form
    {
        // Исправленные строки (без ошибки C# 7.3)
        private readonly List<Drone> drones = new List<Drone>();
        private readonly List<Part> parts = new List<Part>();

        public MainForm()
        {
            InitializeComponent();
            LoadData();
            RefreshDronesTable();
        }

        private void LoadData()
        {
            // 5 учебных записей БПЛА
            drones.Add(new Drone { Id = 1, Name = "Учебный №1", Model = "DJI Mavic 3", Type = "Квадрокоптер", InventoryNumber = "UAV-001", Status = "Исправен" });
            drones.Add(new Drone { Id = 2, Name = "Учебный №2", Model = "Supercam S350", Type = "Самолётный", InventoryNumber = "UAV-002", Status = "На обслуживании" });
            drones.Add(new Drone { Id = 3, Name = "Учебный №3", Model = "Autel EVO II", Type = "Квадрокоптер", InventoryNumber = "UAV-003", Status = "Исправен" });
            drones.Add(new Drone { Id = 4, Name = "Учебный №4", Model = "Geoscan 201", Type = "Самолётный", InventoryNumber = "UAV-004", Status = "Исправен" });
            drones.Add(new Drone { Id = 5, Name = "Учебный №5", Model = "T150 (гибрид)", Type = "Гибридный (VTOL)", InventoryNumber = "UAV-005", Status = "Неисправен" });

            // 10 комплектующих
            parts.Add(new Part { Id = 1, Name = "Аккумулятор LiPo 4S", Category = "Питание", Quantity = 12, StorageLocation = "Шкаф A-1", Compatibility = "Mavic 3 / EVO II" });
            parts.Add(new Part { Id = 2, Name = "Пропеллер 9450", Category = "Винты", Quantity = 40, StorageLocation = "Ящик B-2", Compatibility = "Квадрокоптеры" });
            parts.Add(new Part { Id = 3, Name = "Мотор 2212", Category = "Двигатели", Quantity = 8, StorageLocation = "Шкаф C-1", Compatibility = "Квадрокоптеры" });
            // ... (остальные 7 позиций аналогично)
        }

        private void RefreshDronesTable()
        {
            dgvDrones.DataSource = null;
            dgvDrones.DataSource = drones;

            lblTotalDrones.Text = drones.Count.ToString();
            lblReadyDrones.Text = drones.Count(d => d.Status == "Исправен").ToString();
            lblMaintenanceDrones.Text = drones.Count(d => d.Status == "На обслуживании").ToString();
        }

        private void btnAddDrone_Click(object sender, EventArgs e)
        {
            int nextId = drones.Count + 1;
            drones.Add(new Drone
            {
                Id = nextId,
                Name = $"Учебный №{nextId}",
                Model = "—",
                Type = "Квадрокоптер",
                InventoryNumber = $"UAV-{nextId:000}",
                Status = "Исправен"
            });
            RefreshDronesTable();
        }

        private void btnDeleteDrone_Click(object sender, EventArgs e)
        {
            Drone selected = dgvDrones.CurrentRow?.DataBoundItem as Drone;
            if (selected == null)
            {
                MessageBox.Show("Выберите строку.");
                return;
            }

            if (MessageBox.Show($"Удалить {selected.Name}?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                drones.Remove(selected);
                RefreshDronesTable();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string query = txtSearch.Text.Trim();
            var filtered = drones.Where(d => d.Name.ToLower().Contains(query.ToLower())).ToList();

            dgvDrones.DataSource = null;
            dgvDrones.DataSource = filtered;

            lblTotalDrones.Text = filtered.Count.ToString();
            lblReadyDrones.Text = filtered.Count(d => d.Status == "Исправен").ToString();
            lblMaintenanceDrones.Text = filtered.Count(d => d.Status == "На обслуживании").ToString();
        }
    }
}