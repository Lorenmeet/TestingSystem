//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassLibrary1
{
    using System;
    using System.Collections.Generic;
    
    public partial class AnswerVariant
    {
        public int ID { get; set; }
        public int AnswerID { get; set; }
        public Nullable<int> VariantID { get; set; }
        public string VariantText { get; set; }
        public System.DateTime Time { get; set; }
    
        public virtual Answer Answer { get; set; }
        public virtual Variant Variant { get; set; }
    }
}
