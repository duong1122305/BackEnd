using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities.Response;
using ViewModels.DTOs;

namespace Authentication.UserAuthentication.IAuthentication
{
    public interface IAuthenticationUser
    {
        public Task<ResponseData<string>> Register(UserRegister userRegister);
    }
}
