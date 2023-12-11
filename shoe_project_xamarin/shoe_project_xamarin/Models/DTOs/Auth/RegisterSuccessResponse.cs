using System;
using System.Collections.Generic;
using System.Text;

namespace shoe_project_xamarin.Models.DTOs.Auth
{
    public class RegisterSuccessResponse
    {
        public string userName { get; set; }
        public string message { get; set; }
        public string token { get; set; }
    }
}
