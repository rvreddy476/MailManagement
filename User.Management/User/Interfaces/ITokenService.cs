using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User.Management.User.Interfaces
{
    public interface ITokenService
    {
        Task<string> GenerateToken(string token);

    }
}
