//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WaterOrders
{
    using System;
    using System.Collections.Generic;
    
    public partial class Orders
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Orders()
        {
            this.OrderDetail = new HashSet<OrderDetail>();
        }
    
        public int OrderId { get; set; }
        public int StockId { get; set; }
        public int UserId { get; set; }
        public int BranchId { get; set; }
        public string ToOrder { get; set; }
        public System.DateTime OrderDate { get; set; }
        public string OrderStatu { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalUnitPrice { get; set; }
        public int Quantity { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetail { get; set; }
        public virtual Stocks Stocks { get; set; }
        public virtual Users Users { get; set; }
    }
}