using System;

namespace ultraschall_domain_model
{
    public abstract class Annotation : Tag
    {
        public String Label { get; set; }
        public String Language { get; set; }
        public String Uri { get; set; }
    }
}
