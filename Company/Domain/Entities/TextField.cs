using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace Company.Domain.Entities
{
    public class TextField : EntityBase
    {
        [Required]
        public string CodeWord { get; set; }
        [Display(Name = "Title of page")]
        public override string Title { get; set; } = "Information page ";
        [Display(Name = "Page content")]
        public override string Text { get; set; } = "Content is filled by the administrator";
        

    }
}
