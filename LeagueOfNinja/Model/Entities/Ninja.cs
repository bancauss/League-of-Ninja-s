//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LeagueOfNinja.Model.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ninja
    {
        public int NinjaId { get; set; }
        public string Name { get; set; }
        public int Money { get; set; }
        public int ShopId { get; set; }
    
        public virtual Inventory Inventory { get; set; }
        public virtual Shop Shop { get; set; }
    }
}
