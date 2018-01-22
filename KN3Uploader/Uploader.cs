using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KN3Uploader
{
    public class Uploader
    {
        public Task<string> Upload(string actionUrl, string fileName, Stream paramFileStream)
        {
            FileInfo file = new FileInfo(fileName);
            
            if (!file.Exists)
                return Task<string>.Factory.StartNew(() => "");

            HttpContent fileStreamContent = new StreamContent(paramFileStream);

            using (var client = new HttpClient())
            {
                using (var formData = new MultipartFormDataContent())
                {
                    client.DefaultRequestHeaders.Add("X-Requested-With", "XMLHttpRequest"); //ajax
                    //client.DefaultRequestHeaders.Add("Expect", "100"); //I dunno
                    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                    formData.Add(fileStreamContent, "files[]", file.Name);
                    var response = client.PostAsync(actionUrl, formData).Result;
                    if (!response.IsSuccessStatusCode)
                    {
                        return Task<string>.Factory.StartNew(() => "");
                    }
                    return response.Content.ReadAsStringAsync();
                }
            }
        }
    }
}
