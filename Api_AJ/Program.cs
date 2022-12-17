using API_AJ;
using API_AJ.AuthToken;
using API_AJ.Functions;
using Newtonsoft.Json;
using RestSharp;


internal class Program
{
    public static async Task Main(string[] args)
    {

        var client = new RestClient("https://sendbox.platform.ajsy.com.br/");
        var request = new RestRequest("/api/Brand", Method.Get);

        var userToken = await Services.GetUSerAuthorization();
        request.AddHeader("Accept", "application/json");
        request.AddHeader("Authorization", $"Bearer {userToken.token}");



        var response = await client.GetAsync<List<Brand>>(request);

        

        foreach (Brand brand in response)
        {
            var convertBrand = JsonConvert.SerializeObject(brand);

            Functions.CreateFile($"{brand.brandName}.json", convertBrand);
            
        }

    }

}
