//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Netmefy.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class bt_os_status
    {
        public int os_id { get; set; }
        public System.DateTime tiempo_sk { get; set; }
        public int estado_sk { get; set; }
        public string comentarios { get; set; }
        public int hh_mm_ss { get; set; }
    
        public virtual bt_solicitudes bt_solicitudes { get; set; }
        public virtual lk_estado lk_estado { get; set; }
        public virtual lk_tiempo lk_tiempo { get; set; }
    }
}
