using System;

namespace ServiceStation.WebApp.Models
{
    public class ErrorViewModel
    {
        public string Error { get; set; }
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
