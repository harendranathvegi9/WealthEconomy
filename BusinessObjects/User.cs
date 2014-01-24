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
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    [MetadataType(typeof(UserMetadata))]
    public partial class User : IEntity<int>
    {
        public User()
        {
            this.UserLicenseRatingSet = new HashSet<UserLicenseRating>();
            this.UserOrganizationRatingSet = new HashSet<UserOrganizationRating>();
            this.UserSectorRatingSet = new HashSet<UserSectorRating>();
            this.UserDistributionIndexRatingSet = new HashSet<UserDistributionIndexRating>();
        }
    
        public int Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public System.DateTime ModifiedOn { get; set; }
        public Nullable<System.DateTime> DeletedOn { get; set; }
    
        public virtual ICollection<UserLicenseRating> UserLicenseRatingSet { get; set; }
        public virtual ICollection<UserOrganizationRating> UserOrganizationRatingSet { get; set; }
        public virtual ICollection<UserSectorRating> UserSectorRatingSet { get; set; }
        public virtual ICollection<UserDistributionIndexRating> UserDistributionIndexRatingSet { get; set; }
    }
}
