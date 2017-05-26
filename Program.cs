using System;
using System.Linq;
using RestSharp;

namespace ClashOfClans
{
    public class Program
    {
        static void Main(string[] args)
        {
            var client = new RestClient("https://api.clashofclans.com/v1/");

            var request = new RestRequest("clans/{clanTag}/members", Method.GET);
            request.AddParameter("clanTag", "#8ujgproj", ParameterType.UrlSegment);

            request.AddHeader("Accept", "application/json");
            request.AddHeader("Authorization", "Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzUxMiIsImtpZCI6IjI4YTMxOGY3LTAwMDAtYTFlYi03ZmExLTJjNzQzM2M2Y2NhNSJ9.eyJpc3MiOiJzdXBlcmNlbGwiLCJhdWQiOiJzdXBlcmNlbGw6Z2FtZWFwaSIsImp0aSI6IjNkMDkzZThhLWMxNTAtNDI1NS04NTA4LWMzYTBlMTU1MTMyNiIsImlhdCI6MTQ5NTE1MzMyNSwic3ViIjoiZGV2ZWxvcGVyLzEzNmQ0NzI1LTYyMWItMmY1OC1iNTcwLWM1ZGY2ZmVmN2U2MyIsInNjb3BlcyI6WyJjbGFzaCJdLCJsaW1pdHMiOlt7InRpZXIiOiJkZXZlbG9wZXIvc2lsdmVyIiwidHlwZSI6InRocm90dGxpbmcifSx7ImNpZHJzIjpbIjEwOC44NC4xOTguMTQiXSwidHlwZSI6ImNsaWVudCJ9XX0.hIjNh83gOEbkbLdaQn-9u8gkSxFuyOAoDaq1tarxlvpKolZh5kKQYP9MCGhitYSaeJNUuJwIm7kUTXeHXZPYug");
            
            var response = client.Execute<Clan>(request);
            var clanMembers = response.Data.ClanMembers;
            var member = response.Data.ClanMembers.Single(x => x.Name == "Dada");

            Console.WriteLine("____Individual Member____ ");
            Console.WriteLine("Member name: " + member.Name);
            Console.WriteLine("Member rank: " + member.ClanRank);
            Console.WriteLine("____All Clan Members____");

            foreach (var clanMember in clanMembers)
            {
                Console.WriteLine(clanMember.Name);
            }

            Console.ReadLine();
        }
    }
}
