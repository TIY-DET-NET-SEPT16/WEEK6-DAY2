//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PartialClasses
{
    using System;
    using System.Collections.Generic;
    
    public partial class RentalRecord
    {
        public int RentalID { get; set; }
        public int MovieID { get; set; }
        public int CustomerID { get; set; }
        public System.DateTime RentalDate { get; set; }
        public System.DateTime DueDate { get; set; }
        public Nullable<System.DateTime> ReturnDate { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Movy Movy { get; set; }
    }
}
