using System;
using System.Collections.Generic;

#nullable disable

namespace bex.Models
{
    public partial class TblNotificationConfig
    {
        public long Id { get; set; }
        public string NotificationTitle { get; set; }
        public string Messages { get; set; }
        public long TimeIntervalInDays { get; set; }
    }
}
