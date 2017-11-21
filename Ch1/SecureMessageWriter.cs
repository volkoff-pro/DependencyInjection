using System;
using System.Threading;
using System.Threading.Tasks;

namespace Ch1
{
    public class SecureMessageWriter : IMessageWriter
    {
        private readonly IMessageWriter writer;

        public SecureMessageWriter(IMessageWriter writer)
        {
            if (writer == null)
            {
                throw new ArgumentNullException("writer");
            }
            this.writer = writer;
        }

        public void Write(string message)
        {
            if (true)
            {
                this.writer.Write(message);
            }
        }
    }
}