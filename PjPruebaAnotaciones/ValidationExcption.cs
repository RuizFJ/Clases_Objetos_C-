using System.Runtime.Serialization;

namespace PjPruebaAnotaciones
{
    [Serializable]
    internal class ValidationExcption : Exception
    {
        public ValidationExcption()
        {
        }

        public ValidationExcption(string? message) : base(message)
        {
        }

        public ValidationExcption(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected ValidationExcption(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}