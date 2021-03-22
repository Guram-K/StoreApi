using Core.Models.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Abstraction
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}
