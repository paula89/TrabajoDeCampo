using DomainTest;
using DalTest.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DalTest.Contracts;

namespace DalTest.Repositories.SQL
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
                        Bitacora bita = new Bitacora();
                        bita.Fecha = (DateTime)values[0];
                        bita.Descripcion = values[1].ToString();
                      /*  switch (values[2].ToString())
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
                        */
                        bita.Usuario = values[3].ToString();
                       
                        bitacora.Add(bita);
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
