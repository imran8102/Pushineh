﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pooshineh.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Table_User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Table_User()
        {
            this.Table_Cart = new HashSet<Table_Cart>();
        }

        [Display(Name = "آیدی")]
        public int ID { get; set; }
        [Display(Name = "نام")]
        public string Name { get; set; }
        [Display(Name = "نام خانوادگی")]
        public string LastName { get; set; }
        [Display(Name = "شماره موبایل")]
        [RegularExpression("09[0-9]{9}", ErrorMessage = "{0} نامعتبر است.")]
        [Required(ErrorMessage = "فیلد {0} اجباری است.")]
        public string PhoneNumber { get; set; }
        [Display(Name = "آدرس")]
        public string Address { get; set; }
        [Display(Name = "آدرس ایمیل")]
        [EmailAddress]
        public string EmailAddress { get; set; }
        [Display(Name = "شهر محل سکونت")]
        public string City { get; set; }
        [Display(Name = "تاریخ ثیت نام")]
        public Nullable<System.DateTime> RegisterDate { get; set; }
        [Display(Name = "تاریخ تولد")]
        public Nullable<System.DateTime> BirthDate { get; set; }
        [Display(Name = "تاریخچه ورود")]
        public Nullable<System.DateTime> LoginHistory { get; set; }
        [Display(Name = "رمز عبور")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "فیلد {0} اجباری است.")]
        [RegularExpression("^[a-zA-Z0-9]*$", ErrorMessage = "لطفا از کاراکتر های انگلیسی استفاده کنید.")]
        public string Password { get; set; }
        [Display(Name = "وضعیت")]
        public bool IsActive { get; set; }
        [Display(Name = "آیدی نقش کاربری")]
        public int RoleID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Table_Cart> Table_Cart { get; set; }
        public virtual Table_Roles Table_Roles { get; set; }
    }
}
