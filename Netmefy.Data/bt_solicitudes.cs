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
    
    public partial class bt_solicitudes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public bt_solicitudes()
        {
            this.bt_os_status = new HashSet<bt_os_status>();
        }
    
        public int os_id { get; set; }
        public int cliente_sk { get; set; }
        public System.DateTime fh_creacion { get; set; }
        public Nullable<System.DateTime> fh_cierre { get; set; }
        public string descripcion { get; set; }
    
        public virtual cliente lk_cliente { get; set; }
        public virtual lk_tiempo lk_tiempo { get; set; }
        public virtual lk_tiempo lk_tiempo1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bt_os_status> bt_os_status { get; set; }
    }
}
