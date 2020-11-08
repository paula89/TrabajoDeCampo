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
    public class TrackingRepository : IGenericRepository<Tracking>
    {
        #region Statements
        private string SelectStatement
        {
            get => "SELECT CT.SYS_CHANGE_VERSION, CT.SYS_CHANGE_OPERATION, US.Usuario,US.Email " +
                   "FROM CHANGETABLE (CHANGES dbo.Usuarios, 0) as CT " +
                   "JOIN dbo.Usuarios US ON CT.Usuario = US.Usuario " +
                    "ORDER BY SYS_CHANGE_VERSION";
        }
        #endregion

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// get all about tracking database
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Tracking> GetAll()
        {
            try
            {
                List<Tracking> trackings = new List<Tracking>();
                
                System.Console.WriteLine(SelectStatement);
                using (var dr = SqlHelper.ExecuteReader(SelectStatement, System.Data.CommandType.Text, "security"))
                {
                    Object[] values = new Object[dr.FieldCount];

                    while (dr.Read())
                    {
                        dr.GetValues(values);
                        Tracking tracking = new Tracking();
                        tracking.SYS_CHANGE_VERSION = Convert.ToInt32(values[0]);
                        tracking.SYS_CHANGE_OPERATION = values[1].ToString();
                        tracking.Usuario = values[2].ToString();
                        tracking.Email = values[3].ToString();
                        trackings.Add(tracking);
                    }
                }

                return trackings;
            }
            catch (Exception ex)
            {
                FacadeService.ManageException(new DALException(ex));
                return null;
            }
        }
       
        public IEnumerable<Tracking> GetAll(Array filtros)
        {
            throw new NotImplementedException();
        }

        public int Insert(Tracking o)
        {
            throw new NotImplementedException();
        }

        public int Update(Tracking o)
        {
            throw new NotImplementedException();
        }
    }
}
