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
    
    public partial class RV_UserJoinChatRoom
    {
        public int chatRoomId { get; set; }
        public string creatorEmail { get; set; }
    
        public virtual RV_ChatRoom RV_ChatRoom { get; set; }
    }
}