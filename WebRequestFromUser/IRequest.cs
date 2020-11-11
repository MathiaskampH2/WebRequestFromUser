namespace WebRequestFromUser
{
    /// <summary>
    /// Interface Irequest
    /// Its purpose is to tell all classes which inherits from it
    /// That they should implement their own RequestData method
    /// </summary>
    interface IRequest
    {
        string RequestData(string path);
    }
}