using System.IO;

namespace WebRequestFromUser
{
    /// <summary>
    /// FileRequester class
    /// inherits from IRequest interface
    /// Implements its own RequestData method
    /// Returns the content of a file that the user chooses.
    /// </summary>
    public class FileRequester :IRequest
    {
        public string RequestData(string path)
        {
            // creates a new streamReader that takes the path as parameter
            StreamReader reader = new StreamReader(path);

            // goes through the reader and saves the data in a string variable
            string responseFromServer = reader.ReadToEnd();
            //closes the reader
            reader.Close();
            // returns the string variable
            return responseFromServer;
        }
    }
}