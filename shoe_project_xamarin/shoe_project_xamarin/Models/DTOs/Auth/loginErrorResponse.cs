using System;
using System.Collections.Generic;
using System.Text;

namespace shoe_project_xamarin.Models.DTOs.Auth
{
    public class LoginErrorResponse
    {

        public string message { get; set; }
        public List<string> errors { get; set; }
    }
   
}
