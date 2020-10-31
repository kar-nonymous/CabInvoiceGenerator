// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CabInvoiceException.cs" company="Capgemini">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Kumar Kartikeya"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenerator
{
    [Serializable]
    public class CabInvoiceException : Exception
    {
        public ExceptionType exceptionType;
        public enum ExceptionType
        {
            INVALID_RIDE_TYPE,
            INVALID_DISTANCE,
            INVALID_TIME,
        }
        public CabInvoiceException(ExceptionType exception, string message) : base(message)
        {
            this.exceptionType = exception;
        }
    }
}
