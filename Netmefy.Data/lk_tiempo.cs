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
    
    public partial class lk_tiempo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public lk_tiempo()
        {
            this.bt_notificaciones = new HashSet<bt_notificaciones>();
            this.bt_tests = new HashSet<bt_tests>();
            this.bt_os_status = new HashSet<bt_os_status>();
            this.bt_ot_status = new HashSet<bt_ot_status>();
            this.bt_ord_trabajo = new HashSet<bt_ord_trabajo>();
            this.bt_ord_trabajo1 = new HashSet<bt_ord_trabajo>();
            this.bt_solicitudes = new HashSet<bt_solicitudes>();
            this.bt_solicitudes1 = new HashSet<bt_solicitudes>();
        }
    
        public System.DateTime tiempo_sk { get; set; }
        public int mes { get; set; }
        public string mes_nombre { get; set; }
        public string trimestre { get; set; }
        public int anio { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bt_notificaciones> bt_notificaciones { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bt_tests> bt_tests { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bt_os_status> bt_os_status { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bt_ot_status> bt_ot_status { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bt_ord_trabajo> bt_ord_trabajo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bt_ord_trabajo> bt_ord_trabajo1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bt_solicitudes> bt_solicitudes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bt_solicitudes> bt_solicitudes1 { get; set; }
    }
}
