namespace Ticket.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AspNetUserRoles
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(100)]
        public string UserId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string RoleId { get; set; }

        public virtual AspNetRoles AspNetRoles { get; set; }

        public virtual AspNetRoles AspNetRoles1 { get; set; }

        public virtual AspNetUsers AspNetUsers { get; set; }
    }
}
