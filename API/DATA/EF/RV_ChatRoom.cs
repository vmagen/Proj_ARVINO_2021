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
    
    public partial class RV_ChatRoom
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RV_ChatRoom()
        {
            this.RV_UserJoinChatRoom = new HashSet<RV_UserJoinChatRoom>();
        }
    
        public int chatRoomId { get; set; }
        public string title { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RV_UserJoinChatRoom> RV_UserJoinChatRoom { get; set; }
    }
}