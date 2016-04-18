using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Windows.Media.Protection.PlayReady;
using ObligatoriskOpg.Model;

namespace ObligatoriskOpg.Facade
{
    public class GuestFacade
    {
        private const string serverUrl = "http://localhost:4583";
        //HttpClientHandler handler = new HttpClientHandler();
        //handler.UseDefaultCredentials = true;
        public string ErrorMessage { get; set; }
        public string responseMessage { get; set; }

        //Http GET
        public async Task<List<GuestClass>> GetGuestList()
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.BaseAddress = new Uri(serverUrl);
                client.DefaultRequestHeaders.Clear();
                string urlString = "api/guests";

                try
                {
                    HttpResponseMessage response = client.GetAsync(urlString).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var guestList = await response.Content.ReadAsAsync<List<GuestClass>>();
                        return guestList;
                    }
                    return null;
                }
                catch (Exception e)
                {
                    ErrorMessage = e.Message;
                    return null;
                }
            }
        }

        public async Task<GuestClass> GetGuest()
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.BaseAddress = new Uri(serverUrl);
                client.DefaultRequestHeaders.Clear();
                string urlString = "api/guests";

                try
                {
                    HttpResponseMessage response = client.GetAsync(urlString).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var guest = await response.Content.ReadAsAsync<GuestClass>();
                        return guest;
                    }
                    return null;
                }
                catch (Exception e)
                {
                    ErrorMessage = e.Message;
                    return null;
                }
            }
        }

        //Http POST



        public async Task<GuestClass> PostGuest(int Guest_No, string Address, string Name)
        {
            var MyNewGuest = new GuestClass(Name, Guest_No, Address)
            {
                Guest_No = Guest_No,
                Name = Name,
                Address = Address
            };
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(serverUrl);
                client.DefaultRequestHeaders.Clear();

                try
                {
                    var response = await client.PostAsJsonAsync<GuestClass>("API/guest", MyNewGuest);
                    if (response.IsSuccessStatusCode)
                    {
                        //return MyNewGuest;
                        ErrorMessage = response.StatusCode.ToString();
                        return MyNewGuest;
                    }
                  
                   ErrorMessage  = response.StatusCode.ToString();
                    return null;
                }
                catch (Exception e)
                {
                    ErrorMessage = e.Message;
                    return null;
                }

            }
        }

    }
}
