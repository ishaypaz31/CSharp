using System;
using System.Runtime.Serialization;

namespace OOP27
{
    [Serializable]
    internal class WrongGarageException : Exception
    {
        private Car car;

        public WrongGarageException()
        {
        }

        public WrongGarageException(Car car)
        {
            this.car = car;
        }

        public WrongGarageException(string message) : base(message)
        {
        }

        public WrongGarageException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected WrongGarageException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}