using System;
using System.Collections.Generic;

#nullable disable

namespace bex.Models
{
    public partial class TblEmailTemplate
    {
        public int Id { get; set; }
        public string TemplateName { get; set; }
        public string TemplateHeader { get; set; }
        public string TemplateSubject { get; set; }
        public string TemplateBody { get; set; }
        public string TemplateFooter { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ChecklistId { get; set; }
        public bool? DynamicTemplate { get; set; }

        public virtual CheckList Checklist { get; set; }
    }
}
