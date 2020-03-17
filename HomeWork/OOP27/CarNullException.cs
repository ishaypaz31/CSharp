using System;
using System.Runtime.Serialization;

namespace OOP27
{
    [Serializable]
    internal class CarNullException : Exception
    {
        private Car car;

        public CarNullException()
        {
        }

        public CarNullException(Car car)
        {
            this.car = car;
        }

        public CarNullException(string message) : base(message)
        {
        }

        public CarNullException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CarNullException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}