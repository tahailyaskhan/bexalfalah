using System;
using System.Collections.Generic;

#nullable disable

namespace bex.Models
{
    public partial class MakerCheckerNotificationLog
    {
        public int Id { get; set; }
        public string PostId { get; set; }
        public string DeviceId { get; set; }
        public string NotificationTitle { get; set; }
        public string NotificationBody { get; set; }
        public string Request { get; set; }
        public string Result { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
