using ServicesTest.Domain;
using ServicesTest.Domain.Exceptions;
using ServicesTest.Facade;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ServicesTest.DAL.Repositories.File
{
    internal static class BitacoraSerialization
    {
        private static String archivo = "C:\\Users\\paula\\Documents\\git\\TrabajoDeCampo\\Files\\criticos.bin";
        /// <summary>
        /// save in a file the critical errors by serialization
        /// </summary>
        /// <param name="critico"></param>
        /// <returns></returns>
        public static int Guardar(object critico)
        {
            try
            {
                Stream stream = new FileStream(archivo, FileMode.Append, FileAccess.Write);
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, critico);
                stream.Close();
                return 1;
            } catch (Exception ex) {
                FacadeService.ManageException(new DALException(ex));
                return 0;
            }
        }
        /// <summary>
        /// get from a file the critical errors deserealized 
        /// </summary>
        /// <returns></returns>
        public static List<Bitacora> GetBitacora()
        {
            List<Bitacora> lecturas = new List<Bitacora>();
            Stream stream = new FileStream(archivo, FileMode.Open, FileAccess.Read);
            BinaryFormatter formatter = new BinaryFormatter();
            while (stream.Position < stream.Length)
            {
                Bitacora lectura = (Bitacora)formatter.Deserialize(stream);
                lecturas.Add(lectura);
                
            }
            stream.Close();
            return lecturas;
        }
    }
}
