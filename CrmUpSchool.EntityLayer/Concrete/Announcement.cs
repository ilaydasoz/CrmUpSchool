using System;
namespace CrmUpSchool.EntityLayer.Concrete
{
    public class Announcement
    {
        public int AnnouncementID { get; set; }
        public string Content { get; set; }
        public string Title { get; set; }
        public DateTime AnnouncementDate { get; set; }
    }
}
