using System.Collections.Generic;
using RestSharp.Deserializers;

namespace ClashOfClans
{
    public class Clan
    {
        [DeserializeAs(Name = "items")]
        public List<Member> ClanMembers { get; set; }
    }
}

