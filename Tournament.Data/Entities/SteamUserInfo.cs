using System;
using System.Collections.Generic;
using System.Text;

namespace Tournament.Data.Entities
{
    public class SteamUserInfo
    {
        public int SteamUserInfoId { get; set; }
        public int UserId { get; set; }
        public string SteamToken { get; set; }
    }
}
