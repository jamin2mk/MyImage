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
    
    public partial class tb_customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_customer()
        {
            this.tb_order = new HashSet<tb_order>();
        }
    
        public int cus_id { get; set; }
        public string cus_fname { get; set; }
        public string cus_lname { get; set; }
        public Nullable<bool> cus_gender { get; set; }
        public Nullable<System.DateTime> cus_dob { get; set; }
        public string cus_phone { get; set; }
        public string cus_add { get; set; }
        public string cus_card { get; set; }
        public string cus_email { get; set; }
        public string cus_pass { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_order> tb_order { get; set; }
    }
}
