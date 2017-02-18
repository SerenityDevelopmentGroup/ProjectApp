using System;
using System.Collections.Generic;

namespace ProjectApp.Data
{
    public partial class SupplierInvoice
    {
        public int Id { get; set; }
        public int RSupId { get; set; }
        public DateTime InvoiceDate { get; set; }
        public decimal InvoiceAmount { get; set; }
        public decimal? PaymentAmount { get; set; }
        public DateTime? PaymentDate { get; set; }
        public string CheckNumber { get; set; }
        public string Comments { get; set; }
        public string CheckFileName { get; set; }
        public int RPerCreatedId { get; set; }
        public DateTime Created { get; set; }
        public int? RPerUpdatedId { get; set; }
        public DateTime? Updated { get; set; }
        public DateTime? SecondNotice { get; set; }
        public DateTime? ThirdNotice { get; set; }
        public int? RInvStatusId { get; set; }
        public decimal? Adjustment { get; set; }

        public virtual InvoiceStatus RInvStatus { get; set; }
        public virtual Person RPerCreated { get; set; }
        public virtual Person RPerUpdated { get; set; }
        public virtual Supplier RSup { get; set; }
    }
}
