using System;
using System.ComponentModel.DataAnnotations;

namespace ByteBank.Models
{
    public class ErrorViewModel
    {
        [Required]
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);



    }
}