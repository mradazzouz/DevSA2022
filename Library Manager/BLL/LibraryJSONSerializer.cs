using Newtonsoft.Json;


namespace LibraryManager.BLL
{
    public class LibraryJSONSerializer
    {
        public LibraryData ParseJSON(string text)
        {
            if (string.IsNullOrEmpty(text))
                return new LibraryData();

            return JsonConvert.DeserializeObject<LibraryData>(text);
        }
    }
}
