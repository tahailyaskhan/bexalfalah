using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bex.Models.MVVM
{
    public class RolePrivilagesModel
    {
        public string DisplayName { get; set; }
        public string MethodName { get; set; }
        public int RoleId { get; set; }
        public bool? RightToAdd { get; set; }
        public bool? RightToView { get; set; }
        public bool? RightToDelete { get; set; }
        public bool? RightToEdit { get; set; }
    }
}
