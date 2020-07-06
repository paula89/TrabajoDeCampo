using DALTest.Contracts;
using ServicesTest.DAL.Tools;
using ServicesTest.Domain;
using ServicesTest.Domain.Exceptions;
using ServicesTest.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesTest.DAL.Repositories.SQL
{
    public class BackupRepository : IGenericRepository<Backup>
    {
        #region Statements
        private string InsertStatement
        {
            get => "INSERT INTO [dbo].[Backup] (Fecha, Descripcion, Path) VALUES (@Fecha, @Descripcion, @Path)";
        }

        private string DoBackup {
            get => "BACKUP DATABASE TCSecurity TO DISK =" + @"C:\Users\Paula\Desktop\log";
        }
        private string SelectLimitStatement
        {
            get => "SELECT Fecha, Descripcion, Path FROM [dbo].[Backup] order by Fecha desc limit 100";
        }

        private string SelectAllStatement
        {
            get => "SELECT Fecha, Descripcion, Path FROM [dbo].[Backup]";
        }
        #endregion
        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Backup> GetAll()
        {
            try
            {
                List<Backup> backup = new List<Backup>();
                using (var dr = SqlHelper.ExecuteReader(SelectAllStatement, System.Data.CommandType.Text, "security"))
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
            int inserted = Tools.SqlHelper.ExecuteNonQuery(InsertStatement, System.Data.CommandType.Text, "security", backup);
            return inserted;
        }

        public void Update(Backup o)
        {
            throw new NotImplementedException();
        }

    
    }
}
