using System;
using System.Runtime.Serialization;

namespace OOP27
{
    [Serializable]
    internal class CarNotInGarageException : Exception
    {
        private Car car;

        public CarNotInGarageException()
        {
        }

        public CarNotInGarageException(Car car)
        {
            this.car = car;
        }

        public CarNotInGarageException(string message) : base(message)
        {
        }

        public CarNotInGarageException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CarNotInGarageException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}