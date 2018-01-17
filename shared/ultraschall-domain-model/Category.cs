using System;

namespace ultraschall_domain_model
{
    public class Category
    {
        public Guid Id { get; set; }
        public String Name { get; set; }
        public Category Parent { get; set; }
    }
}
