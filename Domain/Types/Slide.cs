namespace Domain.Types
{
    using System;

    public class Slide
    {
        public long Id { get; set; }

        public string Provider { get; set; }

        public string ReferenceNumber { get; set; }

        public string SlideType { get; set; }

        public DateTime? From { get; set; }

        public DateTime? To { get; set; }
    }
}