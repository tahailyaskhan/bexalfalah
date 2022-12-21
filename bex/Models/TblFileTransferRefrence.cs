using System;
using System.Collections.Generic;

#nullable disable

namespace bex.Models
{
    public partial class TblFileTransferRefrence
    {
        public int Id { get; set; }
        public string DirectoryName { get; set; }
        public int? FolderSize { get; set; }
        public DateTime? CopiedOn { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
    }
}
