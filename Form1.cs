using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsuariosDelCampo
{
    public partial class Form1 : Form
    {
        private Logic _logic;
        private User _user;
        public Form1()
        {
            InitializeComponent();
            _logic = new Logic();
            _user = new User();

            active.Checked = true;
            country.Items.AddRange(new string[] { "Mexicana", "Estadounidense", "Canadiense", "Otro" });
            country.SelectedIndex = 0;
            maleButton.Checked = true;
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(name.Text) || string.IsNullOrEmpty(direction.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            char genre;
            if (maleButton.Checked == true)
            {
                genre = 'M';
            } else
            {
                genre = 'F';
            }


            _user.Name = name.Text;
            _user.Direction = direction.Text;
            _user.BornDate = dateTimePicker.Value;
            _user.Country = country.Text;
            _user.Genre = genre;
            _user.ImagePath = pictureBox.ImageLocation;
            _user.Active = active.Checked;

            int id = _logic.saveUser(_user);
            Debug.WriteLine(id);

            if (id != 0)
            {
                cleanForm();
            }
        }
        private void uploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox.ImageLocation = openFileDialog.FileName;
                _user.ImagePath = openFileDialog.FileName;
            }
        }
        private void search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(userID.Text) || !int.TryParse(userID.Text, out int userId))
            {
                MessageBox.Show("Por favor, ingrese un ID válido para buscar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _user = _logic.searchUser(userId);

            if (_user != null)
            {
                userID.Enabled = false;
                name.Text = _user.Name;
                dateTimePicker.Value = _user.BornDate;
                direction.Text = _user.Direction;
                country.Text = _user.Country;
                maleButton.Checked = (_user.Genre == 'M');
                femaleButton.Checked = (_user.Genre == 'F');
                pictureBox.ImageLocation = _user.ImagePath;
                active.Checked = _user.Active;
            }
            else
            {
                MessageBox.Show("Usuario no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void deleteUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(userID.Text) || !int.TryParse(userID.Text, out int userId))
            {
                MessageBox.Show("Por favor, ingrese un ID válido para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _logic.EliminarUsuario(userId);
            cleanForm();
        }
        private void clean_Click(object sender, EventArgs e)
        {
            cleanForm();

        }
        private void cleanForm()
        {
            userID.Enabled = true;
            userID.Clear();
            name.Clear();
            dateTimePicker.Value = DateTime.Now;
            direction.Clear();
            country.SelectedIndex = -1;
            maleButton.Checked = true;
            femaleButton.Checked = false;
            pictureBox.ImageLocation = null;
            active.Checked = true;
        }
    }
}
