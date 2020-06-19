using DAL.Contracts;
using DAL.Tools;
using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repositories.SQL
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
            get => "SELECT Fecha, Descripcion, Criticidad, Usuario FROM [dbo].[Bitacora] limit 100";
        }

        private string SelectAllStatement
        {
            get => "SELECT Fecha, Descripcion, Criticidad, Usuario FROM [dbo].[Bitacora]";
        }
        #endregion
        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Bitacora> GetAll()
        {
            try
            {
                List<Bitacora> bitacora = new List<Bitacora>();

                using (var dr = SqlHelper.ExecuteReader(SelectAllStatement, System.Data.CommandType.Text, "security"))
                {
                    Object[] values = new Object[dr.FieldCount];

                    while (dr.Read())
                    {
                        dr.GetValues(values);
                        //Adaptar los values que vienen en el array a un objeto Customer.
                        Bitacora c = new Bitacora();
                        c.Descripcion = values[2].ToString();

                        bitacora.Add(c);
                    }
                }

                return bitacora;
            }
            catch (Exception ex)
            {
                // FacadeService.ManageException(new DALException(ex));
                return null;
            }
        }

        public void Insert(Bitacora o)
        {
            throw new NotImplementedException();
        }

        public void Update(Bitacora o)
        {
            throw new NotImplementedException();
        }
    }
}
