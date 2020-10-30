using ServicesTest.DAL.Contracts;
using ServicesTest.DAL.Tools;
using ServicesTest.Domain;
using ServicesTest.Domain.Exceptions;
using ServicesTest.Facade;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesTest.DAL.Repositories.SQL
{
    public class BackupRepository: IGenericRepository<Backup>
    {
        #region Statements
        private string InsertStatement
        {
            get => "INSERT INTO [dbo].[Backup] (Fecha, Descripcion, Path) VALUES (@Fecha, @Descripcion, @Path)";
        }

        private string DoBackup {
            get => "BACKUP DATABASE TCSecurity TO DISK =" + @"C:\Users\Paula\Desktop\log";
        }
        private string SelectFilterStatement
        {
            get => "SELECT Fecha, Descripcion, Path FROM [dbo].[Backup] " +
                "WHERE Fecha >= @desde " +
                "and Fecha <= @hasta " +
                "order by Fecha";
        }
        private string SelectAllStatement
        {
            get => "SELECT Fecha, Descripcion, Path FROM [dbo].[Backup]";
        }
        private string RestoreBackupStatement 
        { 
            get => "dbo.spRestoreBackup";
        }
        #endregion

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Backup> GetAll(Array filtros)
        {
            try
            {
                List<Backup> backup = new List<Backup>();

                /*List<SqlParameter> parametros = new List<SqlParameter>();
                
                parametros.Add(new SqlParameter("@desde", Convert.ToDateTime(filtros.GetValue(0))));
                parametros.Add(new SqlParameter("@hasta", Convert.ToDateTime(filtros.GetValue(1))));
                System.Console.WriteLine(SelectFilterStatement);
                System.Console.WriteLine(parametros.ToArray().ToString());
                */
                using (var dr = SqlHelper.ExecuteReader(SelectAllStatement, System.Data.CommandType.Text, "security"))//,parametros.ToArray()))
                {
                    Object[] values = new Object[dr.FieldCount];

                    while (dr.Read())
                    {
                        dr.GetValues(values);
                        Backup bkp = new Backup();
                        bkp.Fecha = (DateTime)values[0];
                        bkp.Descripcion = values[1].ToString();
                        bkp.Path = values[2].ToString();

                        backup.Add(bkp);
                    }
                }

                return backup;
            }
            catch (Exception ex)
            {
                FacadeService.ManageException(new DALException(ex));
                return null;
            }
        }

        public int Insert(Backup backup)
        {
            int inserted = SqlHelper.ExecuteNonQueryBackup(InsertStatement, System.Data.CommandType.Text, "security", backup);
            return inserted;
        }


        public int RestoreBackup(string path) {

            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@ruta", path));

            int restored = SqlHelper.ExecuteNonQueryRestore(RestoreBackupStatement, System.Data.CommandType.StoredProcedure, "security", parametros.ToArray());

            return restored;
        }


        public int Update(Backup o)
        {
            throw new NotImplementedException();
        }

    
    }
}
