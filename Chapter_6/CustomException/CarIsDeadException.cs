using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomException
{
    class CarIsDeadException : ApplicationException
    {   
        // properties
        private string _messageDetails = String.Empty;
        public DateTime ErrorTimeStamp { get; set; }
        public string CauseOfError { get; set; }

        // constructors
        public CarIsDeadException() { }

        public CarIsDeadException(string cause, DateTime time)
            : this (cause,time,string.Empty)
        {          
        }

        public CarIsDeadException(string cause, DateTime time ,string message)
            : this(cause, time, string.Empty,null)
        {
        }

        public CarIsDeadException(string cause, DateTime time
            , string message, System.Exception
        inner)
            : base(message, inner)
        {
            CauseOfError = cause;
            ErrorTimeStamp = time;
        }


        // Override the Exception.Message property.
        public override string Message
        => $"Car Error Message: {_messageDetails}";
    }

    // a custom exception class pattern pre defind
    // by .net using exp twice tab

    [Serializable]
    public class MyException : Exception
    {
        public MyException() { }
        public MyException(string message) : base(message) { }
        public MyException(string message, Exception inner) : base(message, inner) { }
        protected MyException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
                
}
