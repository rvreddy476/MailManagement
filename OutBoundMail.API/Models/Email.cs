﻿namespace OutBoundMail.API.Models
{
    public class Email
    {
        public string To { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string UniqueIdentifier { get; set; }
    }
}
