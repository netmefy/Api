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
    
    public partial class tecnico
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tecnico()
        {
            this.bt_ord_trabajo = new HashSet<bt_ord_trabajo>();
        }
    
        public int tecnico_sk { get; set; }
        public string tecnico_id { get; set; }
        public string tecnico_psw { get; set; }
        public string tecnico_desc { get; set; }
        public string tecnico_email { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bt_ord_trabajo> bt_ord_trabajo { get; set; }
    }
}
