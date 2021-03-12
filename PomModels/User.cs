using System;
using System.Collections.Generic;

namespace PomModels
{
    /// <summary>
    /// Model for a User. Has properties for Id, Username, FirstName, and LastName
    /// </summary>
    public class User
    {
        public int Id { get; set; }
        public string UserUserName { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public ICollection<Pomodoro> Pomodoros { get; set; }
        public ICollection<NoteRecord> NoteRecords { get; set; }
    }
}
