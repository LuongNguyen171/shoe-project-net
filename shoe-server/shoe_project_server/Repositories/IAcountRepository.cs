using Microsoft.AspNetCore.Identity;
using shoe_project_server.Models.DTOs;

namespace shoe_project_server.Repositories
{
    public interface IAcountRepository
    {
        public Task<IdentityResult> SignUpAsync(RegisterModel model);
    }
}
