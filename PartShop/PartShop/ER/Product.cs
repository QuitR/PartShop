//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PartShop.ER
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        public int Article { get; set; }
        public int ItemId { get; set; }
        public Nullable<int> UserId { get; set; }
    
        public virtual Item Item { get; set; }
        public virtual User User { get; set; }
    }
}