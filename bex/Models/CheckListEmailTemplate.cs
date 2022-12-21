using System;
using System.Collections.Generic;

#nullable disable

namespace bex.Models
{
    public partial class CheckListEmailTemplate
    {
        public int Id { get; set; }
        public int? TemplateId { get; set; }
        public int? CheckListId { get; set; }
        public string TemplateSubject { get; set; }
        public string TemplateName { get; set; }
    }
}
