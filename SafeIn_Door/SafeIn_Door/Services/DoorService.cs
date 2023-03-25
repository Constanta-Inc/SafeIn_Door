using SafeIn_Door.Models;
using SafeIn_Door.Services;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

[assembly: Dependency(typeof(DoorService))]
namespace SafeIn_Door.Services
{
    public class DoorService : IDoorService
    {
        static HttpClient client;
        static DoorService()
        {
            client = new HttpClient() { BaseAddress = new Uri(App.BaseUrl) };
        }
        public async Task<DoorOpenResult> DoorOpen(string doorID, string ScanResult)
        {
            try
            {
                var response = await client.GetAsync($"api/Door/enter-the-door?DoorId={doorID}&userAccessToken={ScanResult}");
                if (!response.IsSuccessStatusCode)
                {
                    var ErrorMessage_ = await response.Content.ReadAsStringAsync();
                    return new DoorOpenResult { ISSuccess = response.IsSuccessStatusCode, ErrorMessage = ErrorMessage_ };
                }
                return new DoorOpenResult { ISSuccess = response.IsSuccessStatusCode };
            }
            catch (Exception)
            {
                return new DoorOpenResult { ISSuccess = false, ErrorMessage = "Request Error." };
            }
        }
    }
}
