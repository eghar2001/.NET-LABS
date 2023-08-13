using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab02
{
    public class ManejadorArchivoTxt: ManejadorArchivo
    {
        protected string connectionString
        {


            get
            {
                return @"Provider=Microsoft.Jet.OLEDB.4.0;
Data Source=K:\Proyectos\.NET\Labs\Unidad_4\Lab02\bin\Debug\net6.0;" +
"Extended Properties='text;HDR=Yes;FMT=Delimited'";
            }
        }
        public override DataTable getTabla()
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                OleDbCommand command = new OleDbCommand("SELECT * FROM agenda.txt", conn);
                conn.Open();
                OleDbDataReader reader = command.ExecuteReader();
                DataTable contactos = new DataTable();
                if (reader != null)
                {
                    contactos.Load(reader);
                }
                conn.Close();
                return contactos;

            }
        }
        public override void aplicaCambios()
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                OleDbCommand cmdInsert = new OleDbCommand("INSERT INTO agenda.txt VALUES (@id,@nombre, @apellido, @email, @telefono)", conn);
                cmdInsert.Parameters.Add("@id", OleDbType.Integer);
                cmdInsert.Parameters.Add("@nombre", OleDbType.VarChar);
                cmdInsert.Parameters.Add("@apellido", OleDbType.VarChar);
                cmdInsert.Parameters.Add("@email", OleDbType.VarChar);
                cmdInsert.Parameters.Add("@telefono", OleDbType.VarChar);

                OleDbCommand cmdUpdate = new OleDbCommand("UPDATE agenda.txt SET nombre = @nombre, apellido = @apellido, email = @email, telefono = @telefono WHERE id = @id", conn);
                cmdUpdate.Parameters.Add("@id", OleDbType.Integer);
                cmdUpdate.Parameters.Add("@nombre", OleDbType.VarChar);
                cmdUpdate.Parameters.Add("@apellido", OleDbType.VarChar);
                cmdUpdate.Parameters.Add("@email", OleDbType.VarChar);
                cmdUpdate.Parameters.Add("@telefono", OleDbType.VarChar);

                OleDbCommand cmdDelete = new OleDbCommand("DELETE FROM agenda.txt WHERE id = @id", conn);
                cmdUpdate.Parameters.Add("@id", OleDbType.Integer);


                DataTable filasNuevas = this.misContactos.GetChanges(DataRowState.Added);
                DataTable filasCambiadas = this.misContactos.GetChanges(DataRowState.Modified);
                DataTable filasBorradas = this.misContactos.GetChanges(DataRowState.Deleted);


                conn.Open();
                if (filasNuevas != null)
                {
                    foreach (DataRow row in filasNuevas.Rows)
                    {
                        cmdInsert.Parameters["@id"].Value = row["@id"];
                        cmdInsert.Parameters["@nombre"].Value = row["@nombre"];
                        cmdInsert.Parameters["@apellido"].Value = row["@apellido"];
                        cmdInsert.Parameters["@email"].Value = row["@email"];
                        cmdInsert.Parameters["@telefono"].Value = row["@telefono"];

                        cmdInsert.ExecuteNonQuery();
                    }
                }
                if (filasCambiadas != null)
                {
                    foreach (DataRow row in filasCambiadas.Rows)
                    {
                        cmdUpdate.Parameters["@id"].Value = row["@id"];
                        cmdUpdate.Parameters["@nombre"].Value = row["@nombre"];
                        cmdUpdate.Parameters["@apellido"].Value = row["@apellido"];
                        cmdUpdate.Parameters["@email"].Value = row["@email"];
                        cmdUpdate.Parameters["@telefono"].Value = row["@telefono"];

                        cmdUpdate.ExecuteNonQuery();
                    }
                }
                if (filasBorradas != null)
                {
                    foreach (DataRow row in filasBorradas.Rows)
                    {
                        cmdDelete.Parameters["@id"].Value = row["@id"];


                        cmdDelete.ExecuteNonQuery();
                    }
                }

                conn.Close();
            }
        }
    }
}
