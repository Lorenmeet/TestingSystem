//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassLibrarySchool
{
    using System;
    using System.Collections.Generic;
    
    public partial class Test
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Test()
        {
            this.TestAppointments = new HashSet<TestAppointment>();
            this.Questions = new HashSet<Question>();
        }
    
        public int ID { get; set; }
        public int Teacher { get; set; }
        public System.DateTime CreateTimew { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte StandardLeadTime { get; set; }
        public byte StandartAttemptCount { get; set; }
        public double Min5 { get; set; }
        public double Min4 { get; set; }
        public double Min3 { get; set; }
    
        public virtual TeacherWorkload TeacherWorkload { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TestAppointment> TestAppointments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Question> Questions { get; set; }
    }
}