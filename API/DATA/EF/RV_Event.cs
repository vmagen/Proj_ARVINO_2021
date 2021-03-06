//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DATA.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class RV_Event
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RV_Event()
        {
            this.RV_PurchasedEventsByUsers = new HashSet<RV_PurchasedEventsByUsers>();
        }
    
        public int eventId { get; set; }
        public string eventName { get; set; }
        public string content { get; set; }
        public int price { get; set; }
        public int participantsAmount { get; set; }
        public System.DateTime eventDate { get; set; }
        public System.TimeSpan startTime { get; set; }
        public string eventImgPath { get; set; }
        public Nullable<int> categoryId { get; set; }
        public Nullable<int> wineryId { get; set; }
        public Nullable<int> ticketsPurchased { get; set; }
    
        public virtual RV_EventCategory RV_EventCategory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RV_PurchasedEventsByUsers> RV_PurchasedEventsByUsers { get; set; }
    }
}
