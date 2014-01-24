//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BusinessObjects
{
    using System;
    using System.ComponentModel.DataAnnotations;
    
    public class UserDistributionIndexRatingMetadata
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        
        [Display(Name = "Total Cost Index")]
        public decimal TotalCostIndexRating { get; set; }
        
        [Display(Name = "Knowledge Sharing Index")]
        public decimal KnowledgeIndexRating { get; set; }

        [Display(Name = "Quality Index")]
        public decimal QualityIndexRating { get; set; }

        [Display(Name = "Sector Index")]
        public decimal SectorIndexRating { get; set; }

        [Display(Name = "Employee Satisfaction Index")]
        public decimal EmployeeIndexRating { get; set; }

        [Display(Name = "Customer Satisfaction Index")]
        public decimal CustomerIndexRating { get; set; }

        [Display(Name = "Distance Index")]
        public decimal DistanceIndexRating { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public System.DateTime ModifiedOn { get; set; }
        public Nullable<System.DateTime> DeletedOn { get; set; }
    }
}
