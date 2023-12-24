using System.Runtime.Serialization;

namespace Avtopark.BL.Auth
{
    [Serializable]
    public class RegistrationException : Exception
    {
        public RegistrationException()
        {
        }

        public RegistrationException(string? message) : base(message)
        {
        }

        public RegistrationException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected RegistrationException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}