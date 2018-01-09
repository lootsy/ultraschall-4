using System;

namespace ultraschall_domain_model
{
    public class Contribution
    {
        public Guid Id { get; set; }
        public ContributorPresence Presence { get; set; }
        public ContributorRole Role { get; set; }
    }
}
