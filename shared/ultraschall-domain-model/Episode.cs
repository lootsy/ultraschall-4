using System;

namespace ultraschall_domain_model
{
    public class Episode
    {
        public enum EPISODE_TYPE { FULL, TRAILER, BONUS };

        public Guid Id { get; set; }
        public int Sequence { get; set; }
        public String Title { get; set; }
        public String Subtitle { get; set; }
        public String Description { get; set; }
        public String Summary { get; set; }
        public String Link { get; set; }
        public String PublicationDate { get; set; }
        public String Guid { get; set; }
        public int Duration { get; set; }
        public EPISODE_TYPE Type { get; set; }
        public Contribution[] Contributions { get; set; }
    }
}
