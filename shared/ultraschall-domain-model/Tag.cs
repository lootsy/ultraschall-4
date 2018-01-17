using System;

namespace ultraschall_domain_model
{
    public abstract class Tag
    {
        public Guid Id { get; set; }
        public Timestamp Timestamp { get; set; }
        public String Comment { get; set; }
    }
}
