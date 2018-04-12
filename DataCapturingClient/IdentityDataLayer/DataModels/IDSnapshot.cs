//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IdentityDataLayer.DataModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class IDSnapshot
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IDSnapshot()
        {
            this.PersonFingers = new HashSet<PersonFinger>();
            this.PersonPictures = new HashSet<PersonPicture>();
        }
    
        public int SnapshotID { get; set; }
        public int PersonId { get; set; }
        public string SnapshotDetails { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime DateCreated { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> DateLastModified { get; set; }
    
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonFinger> PersonFingers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonPicture> PersonPictures { get; set; }
    }
}
