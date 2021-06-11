using System;

namespace Ardalis.Endpoints.Examples
{
    public abstract class BaseMessage
    {
        protected Guid _correlationId = Guid.NewGuid();
        public Guid CorrelationId() => _correlationId;
    }
}
