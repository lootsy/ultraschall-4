using System;

namespace ultraschall_domain_model
{
    public class Podcast
    {
        public Guid Id { get; set; }
        public String Title { get; set; }
        public String Subtitle { get; set; }
        public String Description { get; set; }
        public String Summary { get; set; }
        public String Language { get; set; }
        public String Link { get; set; }
        public String Image { get; set; }
        public Contributor Owner { get; set; }
        public String[] Categories { get; set; }
    }
}

