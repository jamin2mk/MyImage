//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyImageClient.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_shippingcategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_shippingcategory()
        {
            this.tb_order = new HashSet<tb_order>();
        }
    
        public int s_id { get; set; }
        public string s_location { get; set; }
        public decimal s_price { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_order> tb_order { get; set; }
    }
}
