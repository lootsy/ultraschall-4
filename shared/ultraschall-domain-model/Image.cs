using System;

namespace ultraschall_domain_model
{
    public class Image : Annotation
    {
        public String Mime { get; set; }
        public String Author { get; set; }
        public String License { get; set; }
        public String Copyright { get; set; }
    }
}
