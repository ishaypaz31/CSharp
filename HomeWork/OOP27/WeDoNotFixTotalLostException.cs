using System;
using System.Runtime.Serialization;

namespace OOP27
{
    [Serializable]
    internal class WeDoNotFixTotalLostException : Exception
    {
        private Car car;

        public WeDoNotFixTotalLostException()
        {
        }

        public WeDoNotFixTotalLostException(Car car)
        {
            this.car = car;
        }

        public WeDoNotFixTotalLostException(string message) : base(message)
        {
        }

        public WeDoNotFixTotalLostException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected WeDoNotFixTotalLostException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}