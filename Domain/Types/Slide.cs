namespace Domain.Types
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Slide
    {
        public long Id { get; set; }

        public string Provider { get; set; }

        public string ReferenceNumber { get; set; }

        public string SlideType { get; set; }

        public DateTime? From { get; set; }

        [Required(ErrorMessage = "The To date must be specified")]
        public DateTime? To { get; set; }
    }
}