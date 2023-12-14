using System.Data.SqlClient;
using System.Windows.Forms;
using System;
using UsuariosDelCampo;
using System.Diagnostics;
using System.Data;

public class DataAccess
{
    private SqlConnection conn = new SqlConnection("Server=LAPTOP-9MIIIQ5I;Database=EjemploBD;Trusted_Connection=True;");

    public int InsertUser(User user)
    {
        try
        {
            conn.Open();
            string procedureName = "InsertUser";

            using (SqlCommand command = new SqlCommand(procedureName, conn))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@name", user.Name);
                command.Parameters.AddWithValue("@bornDate", user.BornDate);
                command.Parameters.AddWithValue("@direction", user.Direction);
                command.Parameters.AddWithValue("@country", user.Country);
                command.Parameters.AddWithValue("@genre", user.Genre);
                command.Parameters.AddWithValue("@imagePath", user.ImagePath);
                command.Parameters.AddWithValue("@active", user.Active);

                object generatedID = command.ExecuteScalar();
                Debug.WriteLine($"ID generado: {generatedID}");

                MessageBox.Show($"Usuario guardado con éxito. ID: {generatedID}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return Convert.ToInt32(generatedID);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error al insertar usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return 0;
        }
        finally
        {
            conn.Close();
        }
    }

    public void UpdateUser(User user)
    {
        try
        {
            conn.Open();
            string procedureName = "UpdateUser";

            using (SqlCommand command = new SqlCommand(procedureName, conn))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@id", user.ID);
                command.Parameters.AddWithValue("@name", user.Name);
                command.Parameters.AddWithValue("@bornDate", user.BornDate);
                command.Parameters.AddWithValue("@direction", user.Direction);
                command.Parameters.AddWithValue("@country", user.Country);
                command.Parameters.AddWithValue("@genre", user.Genre);
                command.Parameters.AddWithValue("@imagePath", user.ImagePath);
                command.Parameters.AddWithValue("@active", user.Active);

                command.ExecuteNonQuery();

                MessageBox.Show($"Usuario actualizado correctamente (ID: {user.ID})", "Actualización Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error al actualizar usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            conn.Close();
        }
    }

    public User SearchUser(int ID)
    {
        User user = null;
        try
        {
            conn.Open();
            string procedureName = "SearchUser";

            using (SqlCommand command = new SqlCommand(procedureName, conn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ID", ID);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        user = new User
                        {
                            ID = Convert.ToInt32(reader["ID"]),
                            Name = reader["Nombre"].ToString(),
                            BornDate = Convert.ToDateTime(reader["FechaNacimiento"]),
                            Direction = reader["Direccion"].ToString(),
                            Country = reader["Nacionalidad"].ToString(),
                            Genre = reader["Sexo"].ToString()[0],
                            ImagePath = reader["RutaImagen"].ToString(),
                            Active = Convert.ToBoolean(reader["Activo"])
                        };
                    }
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error al buscar usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            conn.Close();
        }
        return user;
    }

    public bool Delete(int ID)
    {
        try
        {
            conn.Open();
            string procedureName = "DeleteUser";

            using (SqlCommand command = new SqlCommand(procedureName, conn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ID", ID);

                int affectedRows = command.ExecuteNonQuery();

                if (affectedRows > 0)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("ID no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error al eliminar usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        finally
        {
            conn.Close();
        }
    }
}