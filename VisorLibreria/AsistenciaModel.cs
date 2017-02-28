using ScjnUtilities;
using System;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data.OleDb;
using System.Linq;

namespace VisorLibreria
{
    public class AsistenciaModel
    {

        private readonly string connectionString = ConfigurationManager.ConnectionStrings["Base"].ConnectionString;

        public ObservableCollection<Asistencia> GetAsistencia()
        {
            ObservableCollection<Asistencia> catalogoTitulares = new ObservableCollection<Asistencia>();

            const string OleDbQuery = "SELECT A.*, P.NombreCompleto, L.Nombre FROM (Asistencia A INNER JOIN C_Libreria L ON A.idLibreria = L.IdLibreria) INNER JOIN C_Personal P ON A.IdPersonal = P.IdPersonal ORDER By Fecha desc";


            OleDbConnection connection = new OleDbConnection(connectionString);
            OleDbCommand cmd = null;
            OleDbDataReader reader = null;


            try
            {
                connection.Open();

                cmd = new OleDbCommand(OleDbQuery, connection);
                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {


                        Asistencia titular = new Asistencia()
                        {
                            IdAsistencia = Convert.ToInt32(reader["IdAsistencia"]),
                            IdUsuario = Convert.ToInt32(reader["IdPersonal"]),
                            Usuario = reader["NombreCompleto"].ToString(),
                            IdLibreria = Convert.ToInt32(reader["IdLibreria"]),
                            Libreria = reader["Nombre"].ToString(),
                            Fecha = DateTimeUtilities.GetDateFromReader(reader, "Fecha"),
                            Entrada = DateTimeUtilities.GetDateFromReader(reader, "HoraEntrada"),
                            Salida = DateTimeUtilities.GetDateFromReader(reader, "HoraSalida"),
                            ObsUser = reader["ObservacionesUser"].ToString(),
                            ObsChief = reader["ObservacionesChief"].ToString()
                        };


                        catalogoTitulares.Add(titular);
                    }
                }
                cmd.Dispose();
                reader.Close();

            }
            catch (OleDbException ex)
            {
                string methodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
                ErrorUtilities.SetNewErrorMessage(ex, methodName + " Exception,AutorModel", "PadronApi");
            }
            catch (Exception ex)
            {
                string methodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
                ErrorUtilities.SetNewErrorMessage(ex, methodName + " Exception,AutorModel", "PadronApi");
            }
            finally
            {
                connection.Close();
            }

            return catalogoTitulares;
        }


    }
}
