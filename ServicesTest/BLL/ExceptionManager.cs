﻿using ServicesTest.Domain;
using ServicesTest.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesTest.BLL
{

        internal sealed class ExceptionManager
        {
            #region Singleton
            private readonly static ExceptionManager _instance = new ExceptionManager();

            public static ExceptionManager Current
            {
                get
                {
                    return _instance;
                }
            }

            private ExceptionManager()
            {
            }
            #endregion

            /// <summary>
            /// Manager de exceptions...
            /// </summary>
            /// <param name="ex"></param>
            public void Handle(Exception ex)
            {
                if (ex is BLLException)
                {
                    Handle(ex as BLLException);
                }
                else if (ex is DALException)
                {
                    Handle(ex as DALException);
                }
                else if (ex is UIException)
                {
                    Handle(ex as UIException);
                }
                else
                {
                    Bitacora bitacora = CrearBitacora("Exception desconocida ::: " + ex, System.Diagnostics.Tracing.EventLevel.Critical);
                    BitacoraManager.Current.Registrar(bitacora);
                }
            }

            
            private void Handle(BLLException ex)
            {
                if (ex.InnerException is DALException)
                {
                //Es una BLL Exception que en realidad viene desde una DALException
                Bitacora bitacora = CrearBitacora("Error accediendo a los datos: LLame a X ::: " + ex, System.Diagnostics.Tracing.EventLevel.Critical);
                BitacoraManager.Current.Registrar(bitacora);
                }
                else if (ex.IsBusinessException)
                {
                    TraceManager.Current.Write(ex.Message, System.Diagnostics.Tracing.EventLevel.Error);
                    //Console.WriteLine($"[Exception] Fecha: { DateTime.Now.ToString() }, {ex.Message} , { ex.StackTrace } ");
                }
                else {
                Console.WriteLine($"[Exception] Fecha: { DateTime.Now.ToString() }, {ex.Message} : { ex.InnerException.Message }, { ex.StackTrace } ");
                }
            }
            private void Handle(DALException ex)
            {
            //Registro la exception -> Bitácora...
            Bitacora bitacora = CrearBitacora("DAL Exception ::: " + ex,  System.Diagnostics.Tracing.EventLevel.Critical);
            BitacoraManager.Current.Registrar(bitacora);

            Console.WriteLine($"[Exception] Fecha: { DateTime.Now.ToString() }, {ex.Message}, { ex.StackTrace } ");
            }
            private void Handle(UIException ex)
            {
            //Registro la exception -> Bitácora...

            Bitacora bitacora = CrearBitacora("UI Exception ::: " + ex, System.Diagnostics.Tracing.EventLevel.Error);
            BitacoraManager.Current.Registrar(bitacora);

            Console.WriteLine($"[Exception] Fecha: { DateTime.Now.ToString() }, {ex.Message}, { ex.StackTrace } ");
            }

             private Bitacora CrearBitacora(string descripcion, EventLevel level)
             {
                    Bitacora bitacora = new Bitacora();
                    bitacora.Fecha = DateTime.Now;
                    bitacora.Descripcion = descripcion;
                    bitacora.Usuario = "Admin";

                    switch (level) {
                        case EventLevel.Error:
                            bitacora.Criticidad = Bitacora.CriticidadEnum.Medio;
                            break;
                        case EventLevel.Critical:
                            bitacora.Criticidad = Bitacora.CriticidadEnum.Mayor;
                            break;
                        case EventLevel.Warning:
                            bitacora.Criticidad = Bitacora.CriticidadEnum.Menor;
                            break;
                    }
                    return bitacora;
             }
        }
 }

