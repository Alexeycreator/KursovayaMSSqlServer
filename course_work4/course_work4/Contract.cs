//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace course_work4
{
    using System;
    using System.Collections.Generic;
    
    public partial class Contract
    {
        public int Number_of_contract { get; set; }
        public Nullable<System.DateTime> Date_of_contract { get; set; }
        public string Terms_of_an_agreement { get; set; }
        public Nullable<int> Account_number { get; set; }
        public Nullable<int> Product_id { get; set; }
        public Nullable<int> Supplier_id { get; set; }
        public Nullable<int> Customer_id { get; set; }
        public Nullable<int> Number_of_sclad { get; set; }
        public Nullable<int> Quntity_products { get; set; }
    
        public virtual Bank Bank { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Product Product { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}