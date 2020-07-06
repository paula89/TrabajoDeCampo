﻿using ServicesTest.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesTest.Domain.Exceptions
{
    public class BLLException: Exception
    {
        public bool IsBusinessException { get; private set; }
        public BLLException(Exception ex, bool IsBusinessException = false) : base("BLL Exception", ex)
        {
            this.IsBusinessException = IsBusinessException;
        }

        public BLLException(string message, bool IsBusinessException = false) : base(message)
        {
            this.IsBusinessException = IsBusinessException;           
        }        
    }
}
