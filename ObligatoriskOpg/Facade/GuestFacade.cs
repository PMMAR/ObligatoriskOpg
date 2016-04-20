using System;
using System.Collections.Generic;
using System.Globalization;
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
     

        //Http GET
        public async Task<List<Guest>> GetGuestList()
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
                        var guestList = await response.Content.ReadAsAsync<List<Guest>>();
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

        public async Task<Guest> GetGuest(Guest getGuest)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.BaseAddress = new Uri(serverUrl);
                client.DefaultRequestHeaders.Clear();
                string urlString = "api/guests/" + getGuest.Guest_No;

                try
                {
                    HttpResponseMessage response = client.GetAsync(urlString).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var guest = await response.Content.ReadAsAsync<Guest>();
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



        public async Task<Guest> PostGuest(Guest newGuest)
        {
            
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(serverUrl);
                client.DefaultRequestHeaders.Clear();

                try
                {
                    var response = await client.PostAsJsonAsync<Guest>("API/guests", newGuest);
                    if (response.IsSuccessStatusCode)
                    {
                        //return MyNewGuest;
                        ErrorMessage = response.StatusCode.ToString();
                        return newGuest;
                    }

                    ErrorMessage = response.StatusCode.ToString();
                    return null;
                }
                catch (Exception e)
                {
                    ErrorMessage = e.Message;
                    return null;
                }

            }
        }

            //HTTP PUT
        public async Task<Guest> GuestPut(Guest udGuest)
        {
        
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(serverUrl);
                client.DefaultRequestHeaders.Clear();
                try
                {
                    var response = await client.PutAsJsonAsync<Guest>("API/guests/" + udGuest.Guest_No, udGuest);
                    if (response.IsSuccessStatusCode)
                    {

                        ErrorMessage = response.StatusCode.ToString();
                        return udGuest;
                    }
                    ErrorMessage = response.StatusCode.ToString();
                    return null;
                }
                catch (Exception e)
                {
                    ErrorMessage = e.Message;
                    return null;
                }
            }
        }



        // Http Delete

        public async Task<Guest> GuestDelete(Guest delGuest)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(serverUrl);
                client.DefaultRequestHeaders.Clear();

                string urlString = "api/guests/" + delGuest.Guest_No;

                try
                {
                    HttpResponseMessage response = await client.DeleteAsync(urlString);
                    if (response.IsSuccessStatusCode)
                    {
                        ErrorMessage = response.StatusCode.ToString();
                        return null;
                    }
                    ErrorMessage = response.StatusCode.ToString();
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
