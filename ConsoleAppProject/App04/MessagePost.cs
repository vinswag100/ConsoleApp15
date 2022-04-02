using System;

namespace ConsoleAppProject.App04
{
    ///<summary>
    /// This class stores information about a post in a social network. 
    /// The main part of the post consists of a (possibly multi-line)
    /// text message. Other data, such as author and time, are also stored.
    /// </summary>
    /// <author>
    /// Michael Kölling and David J. Barnes
    /// version 0.1
    /// </author>
    public class MessagePost : Post
    {
        // an arbitrarily long, multi-line message
        public String Message { get; set; }

        public MessagePost(string message, string author) : base(author)
        {
            Message = message;
        }

    }
     
}
