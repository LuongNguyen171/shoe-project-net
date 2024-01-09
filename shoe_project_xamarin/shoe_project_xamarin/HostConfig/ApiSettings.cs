namespace shoe_project_server.Models.HostConfig
{
    public interface IApiSettings
    {
        string BuildApiBaseClientHost(string endpoint);
        string BuildApiClientHost(string endpoint);
    }

    public class ApiSettings : IApiSettings
    {
        private string BaseClientHost = "http://192.168.86.250";
        private string ApiClientHost = "http://192.168.86.250/shoestore/api";

        public string BuildApiBaseClientHost(string endpoint)
        {
            return $"{BaseClientHost}{endpoint}";
        }
        public string BuildApiClientHost(string endpoint)
        {
            return $"{ApiClientHost}{endpoint}";
        }
    }
}
