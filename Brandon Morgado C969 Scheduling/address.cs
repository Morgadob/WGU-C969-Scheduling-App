namespace Brandon_Morgado_C969_Scheduling
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("U056oM.address")]
    public partial class address
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public address()
        {
            customers = new HashSet<customer>();
        }

        public int addressId { get; set; }

        [Column("address")]
        [Required]
        [StringLength(50)]
        public string address1 { get; set; }

        [Required]
        [StringLength(50)]
        public string address2 { get; set; }

        public int cityId { get; set; }

        [Required]
        [StringLength(10)]
        public string postalCode { get; set; }

        [Required]
        [StringLength(20)]
        public string phone { get; set; }

        public DateTime createDate { get; set; }

        [Required]
        [StringLength(40)]
        public string createdBy { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime lastUpdate { get; set; }

        [Required]
        [StringLength(40)]
        public string lastUpdateBy { get; set; }

        public virtual city city { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<customer> customers { get; set; }
    }
}
