using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = Microsoft.Build.Framework.RequiredAttribute;

namespace Company.Domain.Entities
{
    public abstract class EntityBase
    {
        protected EntityBase() => DateAdded = DateTime.UtcNow;
        [Required]
        public Guid Id { get; set; }
        
        [Display(Name = "Name (header)")]
        public virtual string Title { get; set; }
        
        [Display(Name ="Short Describe")]
        public virtual string SubTitle { get; set; }

        [Display(Name = "Full Describe")]
        public virtual string Text { get; set; }

        [Display(Name = "Home Page")]
        public virtual string TitleImagePath { get; set; }

        [Display(Name = "SEO metatag Title")]
        public virtual string MetaTitle { get; set; }

        [Display(Name = "SEO metatag Description")]
        public virtual string MetaDescription { get; set; }

        [Display(Name = "Short Keywords")]
        public virtual string MetaKeyWords { get; set; }

        [DataType(DataType.Time)]
        public DateTime DateAdded { get; set; }


    }
}
