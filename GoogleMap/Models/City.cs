//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GoogleMap.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class City
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Name_en { get; set; }
        public double Log { get; set; }
        public double Lat { get; set; }
        public int Country_ID { get; set; }
    
        public virtual Country Country { get; set; }
    }
}
