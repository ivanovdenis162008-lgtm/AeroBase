using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AeroBase.Models;
using Npgsql;

namespace AeroBase
{
    public partial class MainForm : Form
    {
        private DroneRepository repository;
        private string connectionString = "Host=localhost;Port=5432;Database=aerobase;Username=postgres;Password=Canekza09";

        private List<Drone> drones = new List<Drone>();
        private List<Part> parts = new List<Part>();

        public MainForm()
        {
            InitializeComponent();
            repository = new DroneRepository(connectionString);
            RefreshDronesTable();
        }

        private void RefreshDronesTable()
        {
            try
            {
                drones = repository.GetAll();

                dgvDrones.DataSource = null;
                dgvDrones.DataSource = drones;

                if (dgvDrones.Columns["Id"] != null)
                    dgvDrones.Columns["Id"].Visible = false;

                lblTotalDrones.Text = drones.Count.ToString();
                lblReadyDrones.Text = drones.Count(d => d.Status == "Исправен").ToString();
                lblMaintenanceDrones.Text = drones.Count(d => d.Status == "На обслуживании").ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки: " + ex.Message);
            }
        }
        private void btnAddDrone_Click(object sender, EventArgs e)
        {
            using (DroneEditForm editForm = new DroneEditForm())
            {
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        repository.Add(editForm.Result);
                        RefreshDronesTable();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка добавления: " + ex.Message);
                    }
                }
            }
        }

        private void btnEditDrone_Click(object sender, EventArgs e)
        {
            Drone selected = dgvDrones.CurrentRow?.DataBoundItem as Drone;

            if (selected == null)
            {
                MessageBox.Show("Выберите строку для редактирования.");
                return;
            }

            using (DroneEditForm editForm = new DroneEditForm(selected))
            {
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        repository.Update(selected);
                        RefreshDronesTable();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка обновления: " + ex.Message);
                    }
                }
            }
        }

        private void btnDeleteDrone_Click(object sender, EventArgs e)
        {
            Drone selected = dgvDrones.CurrentRow?.DataBoundItem as Drone;

            if (selected == null)
            {
                MessageBox.Show("Выберите строку для удаления.");
                return;
            }

            if (MessageBox.Show($"Удалить «{selected.Name}»?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    repository.Delete(selected.Id);
                    RefreshDronesTable();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка удаления: " + ex.Message);
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string query = txtSearch.Text.Trim().ToLower();

            var filtered = string.IsNullOrWhiteSpace(query)
                ? drones
                : drones.Where(d => d.Name.ToLower().Contains(query)).ToList();

            dgvDrones.DataSource = null;
            dgvDrones.DataSource = filtered;

            lblTotalDrones.Text = filtered.Count.ToString();
            lblReadyDrones.Text = filtered.Count(d => d.Status == "Исправен").ToString();
            lblMaintenanceDrones.Text = filtered.Count(d => d.Status == "На обслуживании").ToString();
        }
    }
}