using System;

namespace JokeApi.Models
{
    public class JokesModel
    {
        public int Id { get; set; }  
        public string Title { get; set; }
        public string  Content { get; set; }
        public int  IdUser { get; set; }
        public DateTime CreationDate { get; set; }
        public short Rating { get; set; }
    }
}
