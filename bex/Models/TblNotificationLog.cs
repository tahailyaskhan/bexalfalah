using System;
using System.Collections.Generic;

#nullable disable

namespace bex.Models
{
    public partial class TblNotificationLog
    {
        public long Id { get; set; }
        public long NotificationId { get; set; }
        public string Message { get; set; }
        public string PostId { get; set; }
        public long UserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string FireBaseResponse { get; set; }
        public string DeviceId { get; set; }
    }
}
