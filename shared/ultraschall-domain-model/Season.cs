using System;

namespace ultraschall_domain_model
{

    public class Season
    {
        public Guid Id { get; set; }
        public int Sequence { get; set; }
        public String Title { get; set; }
        public String Subtitle { get; set; }
        public String Description { get; set; }
        public String Summary { get; set; }
    }
}
