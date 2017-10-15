namespace Web.WebApiClient
{
    public class SequenceApiClient
    {
        /// <summary>
        /// Consumes Web API and returns the response data 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public string GetSequence(string request)
        {
            string _sData = string.Empty;
            string me = string.Empty;
            try
            {
                System.Net.WebClient wc = new System.Net.WebClient();
                byte[] response = wc.DownloadData(request);
                _sData = System.Text.Encoding.ASCII.GetString(response);
            }
            catch { _sData = "unable to connect to server "; }
            return _sData;
        }
    }
}
