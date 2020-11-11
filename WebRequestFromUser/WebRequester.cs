using System;
using System.IO;
using System.Net;

namespace WebRequestFromUser
{
    /// <summary>
    /// WebRequester class
    /// Inherits from Irequest interface
    /// Implements its own RequestData method
    /// Returns the HTML from a website that the user chooses.
    /// </summary>
    public class WebRequester : IRequest
    {
        public string RequestData(string path)
        {
            string StoreResponseFromServer = null;
            // This line creates a request of the path from the user
            WebRequest request = WebRequest.Create(path);
            // checks if the website requires login Credentials
            request.Credentials = CredentialCache.DefaultCredentials;
            // creates a new HTTPWebResponse
            HttpWebResponse response = (HttpWebResponse) request.GetResponse();
            // Prints out the response from the webServer "ok" if the server is running.
            Console.WriteLine(response.StatusDescription);
            // get a stream with response data from webServer

            using (Stream dataStream = response.GetResponseStream())
            {
                // reads the response data in a StreamReader
                StreamReader reader = new StreamReader(dataStream);

                // saves the streamReader data in a string variable
                StoreResponseFromServer = reader.ReadToEnd();
            }

            response.Close();
            // returns the streamReader string variable
            return StoreResponseFromServer;
        }
    }
}