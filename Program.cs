using System;
using RestSharp;

namespace ClashOfClans
{
    public class Program
    {
        static void Main(string[] args)
        {
            var client = new RestClient("http://api.clashofclans.com/v1/");
            
            var request = new RestRequest("clans", Method.GET);
            request.AddParameter("name", "in yo face");

            request.AddHeader("Accept", "application/json");
            request.AddHeader("Authorization", "Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzUxMiIsImtpZCI6IjI4YTMxOGY3LTAwMDAtYTFlYi03ZmExLTJjNzQzM2M2Y2NhNSJ9.eyJpc3MiOiJzdXBlcmNlbGwiLCJhdWQiOiJzdXBlcmNlbGw6Z2FtZWFwaSIsImp0aSI6IjA3NmViYjE4LWI1N2EtNGJjYS04Yjk0LWNmYWNiNWYwMzk5NyIsImlhdCI6MTQ5NTE0NTg1Nywic3ViIjoiZGV2ZWxvcGVyLzEzNmQ0NzI1LTYyMWItMmY1OC1iNTcwLWM1ZGY2ZmVmN2U2MyIsInNjb3BlcyI6WyJjbGFzaCJdLCJsaW1pdHMiOlt7InRpZXIiOiJkZXZlbG9wZXIvc2lsdmVyIiwidHlwZSI6InRocm90dGxpbmcifSx7ImNpZHJzIjpbIjE0OC4xNDEuMTUuOTciXSwidHlwZSI6ImNsaWVudCJ9XX0.SCN9usmlxkMMj2s_yt647q9NtIN-YcMtpiv1gxIFqj3y5Vb_Mf8aDsXxkXtqAMLh-nzeQWFRFN_5YdckkyM0Ng");


            IRestResponse response = client.Execute(request);

            var responseContent = response.Content;

            Console.Write(responseContent);
            Console.ReadLine();
        }
    }
}
