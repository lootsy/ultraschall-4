using System;

namespace ultraschall_domain_model
{
    public class ContributorPresence
    {
        public Guid Id { get; set; }

        public Guid Contributor { get; set; }
        public String Name { get; set; }
        public String Url { get; set; }
        public String Icon { get; set; }
    }
}

