namespace EstateAgency
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EstateObjects
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EstateObjects()
        {
            Trades = new HashSet<Trades>();
            Pictures = new HashSet<Pictures>();
        }

        public int Id { get; set; }

        public int StatusId { get; set; }

        public int OwnerId { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        [Required]
        [StringLength(100)]
        public string Address { get; set; }

        public int DistrictId { get; set; }

        [StringLength(300)]
        public string Description { get; set; }

        public int RealtyTypeId { get; set; }

        public int TradeTypeId { get; set; }

        public float Area { get; set; }

        public byte? Rooms { get; set; }

        [StringLength(50)]
        public string LandDescription { get; set; }
        public float? LandArea { get; set; }

        [StringLength(50)]
        public string Furniture { get; set; }

        public virtual Districts Districts { get; set; }

        public virtual Owners Owners { get; set; }

        public virtual RealtyTypes RealtyTypes { get; set; }

        public virtual Statuses Statuses { get; set; }

        public virtual TradeTypes TradeTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Trades> Trades { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pictures> Pictures { get; set; }
    }
}
