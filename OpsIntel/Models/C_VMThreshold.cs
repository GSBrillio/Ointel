//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OpsIntel.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class C_VMThreshold
    {
        public int Id { get; set; }
        public string VMName { get; set; }
        public string CloudServiceName { get; set; }
        public string Status { get; set; }
        public int Threshold_CPU { get; set; }
        public int Threshold_Memory { get; set; }
        public int Threshold_NetworkIn { get; set; }
        public int Threshold_NetworkOut { get; set; }
        public int Threshold_DiskRead { get; set; }
        public int Threshold_DiskWrite { get; set; }
        public string VMImageName { get; set; }
        public string VnetName { get; set; }
        public string SubnetNAme { get; set; }
        public Nullable<int> CPU { get; set; }
        public Nullable<decimal> Memory { get; set; }
    }
}
