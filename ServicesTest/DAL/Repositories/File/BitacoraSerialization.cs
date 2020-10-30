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

        public static int Guardar(object obj)
        {
            try
            {
                Stream stream = new FileStream(archivo, FileMode.Append, FileAccess.Write);
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, obj);
                stream.Close();
                return 1;
            } catch (Exception ex) {
                FacadeService.ManageException(new DALException(ex));
                return 0;
            }
        }

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
