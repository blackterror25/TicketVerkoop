//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ticket.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Plaats
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Plaats()
        {
            this.Tickets = new HashSet<Tickets>();
            this.Wedstrijd = new HashSet<Wedstrijd>();
        }
    
        public int id { get; set; }
        public int Stadionid { get; set; }
        public int Vakid { get; set; }
        public float prijs { get; set; }
    
        public virtual Vak Vak { get; set; }
        public virtual Stadion Stadion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tickets> Tickets { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Wedstrijd> Wedstrijd { get; set; }
    }
}
