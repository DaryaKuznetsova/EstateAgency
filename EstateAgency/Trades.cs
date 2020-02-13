namespace EstateAgency
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Trades
    {
        public int Id { get; set; }

        public int ItemId { get; set; }

        public int ManagerId { get; set; }

        public int ClientId { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        public int PaymentTypeId { get; set; }

        public int PaymentInstrumentId { get; set; }

        public virtual Clients Clients { get; set; }

        public virtual EstateObjects EstateObjects { get; set; }

        public virtual Managers Managers { get; set; }

        public virtual PaymentTypes PaymentTypes { get; set; }

        public virtual PaymnetInstruments PaymnetInstruments { get; set; }
    }
}
