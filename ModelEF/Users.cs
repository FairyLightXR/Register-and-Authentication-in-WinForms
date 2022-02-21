namespace Practice_3_01_Gundorov.ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Users
    {
        [Key]
        [StringLength(50)]
        public string Login { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        public int RoleID { get; set; }

        [Required]
        [StringLength(50)]
        public string FIO { get; set; }

        public virtual Roles Roles { get; set; }
    }
}
