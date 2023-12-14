using System;
using System.Windows.Forms;

namespace UsuariosDelCampo
{
    public class Logic
    {
        private DataAccess _dataAccess;

        public Logic()
        {
            _dataAccess = new DataAccess();
        }

        public int saveUser(User user)
        {
            int id = 0;

            if (user.ID == 0)
            {
                id = _dataAccess.InsertUser(user);
                return id;
            }
            else
            {
                _dataAccess.UpdateUser(user);
            }

            return id;
        }

        public User searchUser(int ID)
        {
            User user = null;

            user = _dataAccess.SearchUser(ID);

            return user;
        }

        public void EliminarUsuario(int userID)
        {
            bool eliminacionExitosa = _dataAccess.Delete(userID);

            if (eliminacionExitosa)
            {
                MessageBox.Show("Usuario eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al eliminar usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}