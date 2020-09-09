using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServicesTest.DAL.Contracts;
using ServicesTest.Domain;
using ServicesTest.DAL.Tools;
using ServicesTest.Facade;
using ServicesTest.Domain.Exceptions;
using System.Data.SqlClient;

namespace ServicesTest.DAL.Repositories.SQL
{
    public class BitacoraRepository : IGenericRepository<Bitacora>
    {
        #region Statements
        private string InsertStatement
        {
            get => "INSERT INTO [dbo].[Bitacora] (Fecha, Descripcion, Criticidad, Usuario) VALUES (@Fecha, @Descripcion, @Criticidad, @Usuario)";
        }

        private string UpdateStatement
        {
            get => "UPDATE [dbo].[Customer] SET (Fecha= @Fecha, Descripcion=@Descripcion, Criticidad=@Criticidad, Usuario=@Usuario) WHERE IdCustomer = @IdCustomer";
        }

        private string SelectLimitStatement
        {
            get => "SELECT Fecha, Descripcion, Criticidad, Usuario FROM [dbo].[Bitacora] order by Fecha desc limit 100";
        }

        private string SelectFilterStatement
        {
            get => "SELECT Fecha, Descripcion, Criticidad, Usuario FROM [dbo].[Bitacora] " +
                "WHERE Fecha >= @desde " +
                "and Fecha <= @hasta ";
            set { }
        }
       
        private string SelectAllStatement
        {
            get => "SELECT Fecha, Descripcion, Criticidad, Usuario FROM [dbo].[Bitacora] order by Fecha";
        }
        #endregion
        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Bitacora> GetAll(Array filtros)
        {
            try
            {
                List<Bitacora> bitacora = new List<Bitacora>();
                List<SqlParameter> parametros = new List<SqlParameter>();
                string finalStatementString;
                if (filtros.GetValue(0) != null)
                {
                    finalStatementString = String.Concat(SelectFilterStatement, "and Criticidad = @Criticidad order by Fecha");
                    parametros.Add(new SqlParameter("@criticidad", filtros.GetValue(0)));
                }
                else {
                    finalStatementString = String.Concat(SelectFilterStatement, "order by Fecha");
                }

                parametros.Add(new SqlParameter("@desde",Convert.ToDateTime(filtros.GetValue(1))));
                parametros.Add(new SqlParameter("@hasta", Convert.ToDateTime(filtros.GetValue(2))));
                System.Console.WriteLine(finalStatementString);
                System.Console.WriteLine(parametros.ToArray().ToString());

                using (var dr = SqlHelper.ExecuteReader(finalStatementString, System.Data.CommandType.Text, "security", parametros.ToArray()))
                {
                    Object[] values = new Object[dr.FieldCount];

                    while (dr.Read())
                    {
                        dr.GetValues(values);
                        Bitacora bita = new Bitacora();
                        bita.Fecha = (DateTime)values[0];
                        bita.Descripcion = values[1].ToString();
                          switch (values[2].ToString().Trim())
                          {
                              case "Menor": 
                                  bita.Criticidad = Bitacora.CriticidadEnum.Menor;
                                  break;
                              case "Medio":
                                  bita.Criticidad = Bitacora.CriticidadEnum.Medio;
                                  break;
                              case "Mayor":
                                  bita.Criticidad = Bitacora.CriticidadEnum.Mayor;
                                  break;
                          }                          
                        bita.Usuario = values[3].ToString();
                        bitacora.Add(bita);
                    }
                }

                return bitacora;
            }
            catch (Exception ex)
            {
                FacadeService.ManageException(new DALException(ex));
                return null;
            }
        }

        public int Insert(Bitacora bitacora)
        {
            int inserted = SqlHelper.ExecuteNonQueryBitacora(InsertStatement, System.Data.CommandType.Text, "security", bitacora);
            return inserted;            
        }

        public void Update(Bitacora o)
        {
            throw new NotImplementedException();
        }

    }
}
