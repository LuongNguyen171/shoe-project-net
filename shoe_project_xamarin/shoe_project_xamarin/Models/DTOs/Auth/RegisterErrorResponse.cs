using System;
using System.Collections.Generic;
using System.Text;

namespace shoe_project_xamarin.Models.DTOs.Auth
{
    public class RegisterError
    {
        public string Code { get; set; }
        public string Description { get; set; }
    }
    public class RegisterErrorResponse
    {

        public List<RegisterError> errors { get; set; }
        public string message { get; set; }
    }
}
