using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using Entidades;



namespace Datos
{
    public class dPaciente
    {
        Database db = new Database();

        public string Insertar(ePaciente obj)
        {
            try {
                SqlConnection con = db.ConectaDB();
                string insert = string.Format("INSERT INTO Paciente(DNI, NombreCompleto, Sexo, Distrito, FechaNacimiento, FechaRegistro) VALUES ('{0}','{1}','{2}','{3}',{4},{5})", obj.DNI, obj.NombreCompleto, obj.Sexo, obj.Distrito, obj.FechaNacimiento, obj.FechaRegistro);
                SqlCommand cmd = new SqlCommand(insert, con);
                cmd.ExecuteNonQuery();
                return "Insertó";

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                db.DesconectaDB();
            }
        }

        public string Eliminar(string DNI)
        {
            try {
                SqlConnection con = db.ConectaDB();
                string delete = string.Format("DELETE FROM Paciente WHERE DNI='{0}'", DNI);
                SqlCommand cmd = new SqlCommand(delete, con);
                cmd.ExecuteNonQuery();
                return "Eliminó";
            
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

            finally {

                db.DesconectaDB();
            }
        }

        public string Modificar(ePaciente obj, string DNI)
        {
            try {
                SqlConnection con = db.ConectaDB();
                string update = string.Format("UPDATE Paciente SET NombreCompleto='{0}', Sexo='{1}', Distrito='{2}', FechaNacimiento={3}, FechaRegistro={4} WHERE DNI='{5}'", obj.NombreCompleto, obj.Sexo, obj.Distrito, obj.FechaNacimiento, obj.FechaRegistro, DNI);
                SqlCommand cmd = new SqlCommand(update, con);
                cmd.ExecuteNonQuery();
                return "Modificó.";

            }
            catch (Exception ex) {
                return ex.Message;
            }
            finally {
                db.DesconectaDB();
            }
        }

        public List<ePaciente> ListarTodoPacientes()
        {
            try {
                List<ePaciente> lsPaciente = new List<ePaciente>();
                ePaciente paciente = null;
                SqlConnection con = db.ConectaDB();
                SqlCommand cmd = new SqlCommand("SELECT DNI, NombreCompleto, Sexo, Distrito, FechaNacimiento, FechaRegistro FROM Paciente", con);
                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    paciente = new ePaciente();
                    paciente.DNI = (string)reader["DNI"];
                    paciente.NombreCompleto = (string)reader["NombreCompleto"];
                    paciente.Sexo = (string)reader["Sexo"];
                    paciente.Distrito = (string)reader["Distrito"];
                    paciente.FechaNacimiento = (int)reader["FechaNacimiento"];
                    paciente.FechaRegistro = (int)reader["FechaRegistro"];
                    lsPaciente.Add(paciente);
                }
                reader.Close();
                return lsPaciente;

            }
            catch (Exception ex) {
                return null;
            }
            finally
            {
                db.DesconectaDB();

            }
            
        }

    }
}
