using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace LibraryManager.BLL
{
    public class NetworkManager
    {
        public static async Task<bool> FetchJSONData(string url)
        {
            using (var httpClient = new System.Net.Http.HttpClient())
            {
                var httpResponse = await httpClient.GetAsync(url, HttpCompletionOption.ResponseContentRead);

                if (httpResponse.Content is object || httpResponse.Content.Headers.ContentType.MediaType == "plain/text")
                {
                    try
                    {
                        var contentStream = await httpResponse.Content.ReadAsStreamAsync();

                        var streamReader = new StreamReader(contentStream);

                        string jsonString = streamReader.ReadToEnd();

                        LibraryJSONSerializer serializer = new LibraryJSONSerializer();
                        var data = serializer.ParseJSON(jsonString);

                        BookStore.Instance.books = data.Books;
                        DVDStore.Instance.DVDs = data.DVDs;
                        MemberStore.Instance.members = data.Members;

                        return true;
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine(e.Message);
                        return false;
                    }
                }
                else
                {
                    Console.WriteLine("HTTP Response was invalid and cannot be deserialised.");

                    return false;
                }
            }
        }
    }
}
