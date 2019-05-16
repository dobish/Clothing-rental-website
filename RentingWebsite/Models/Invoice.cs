//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RentingWebsite.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Invoice
    {
        public int InvoiceId { get; set; }
        public Nullable<int> OrderItemId { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
        public Nullable<System.DateTime> ReturnDate { get; set; }
        public Nullable<decimal> InvoiceTotalPrice { get; set; }
        public Nullable<int> CustomerId { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual OrderItem OrderItem { get; set; }
    }
}