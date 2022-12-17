using RestSharp;
using Newtonsoft.Json;


namespace API_AJ.AuthToken
{
    public class Services
    {
        public static async Task<UserAuthResponse> GetUSerAuthorization()
        {
            var client = new RestClient("https://sendbox.platform.ajsy.com.br");

            var request = new RestRequest("api/Token", Method.Post);

            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Accept", "application/json");

            var user = new UserAuth();
            user.user = "davi";
            user.password = "123456";
            var convertUSer = JsonConvert.SerializeObject(user);
            request.AddBody(convertUSer);

            var response = await client.PostAsync<UserAuthResponse>(request);

            return response;
        }
             
    }
}
