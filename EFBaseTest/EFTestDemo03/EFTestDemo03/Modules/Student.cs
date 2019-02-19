namespace EFTestDemo03.Modules
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Student")]
    public partial class Student
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public int? Age { get; set; }

        public int ClassID { get; set; }

        public string s() {
            return "ID:" + ID + ",Name:" + Name + ",Age:" + Age;
        }
    }
}
