﻿namespace LibraryMgmtSystem.Domain.Entities
{
    public class Book : Entity
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Isbn { get; set; }
    }
}
