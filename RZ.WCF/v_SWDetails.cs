//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RuckZuck_WCF
{
    using System;
    using System.Collections.Generic;
    
    public partial class v_SWDetails
    {
        public long Id { get; set; }
        public long SWId { get; set; }
        public string Architecture { get; set; }
        public string ShortName { get; set; }
        public string Definition { get; set; }
        public Nullable<System.DateTime> LastModified { get; set; }
        public long Downloads { get; set; }
        public long Failures { get; set; }
        public System.DateTime CreationDate { get; set; }
        public long Success { get; set; }
    }
}