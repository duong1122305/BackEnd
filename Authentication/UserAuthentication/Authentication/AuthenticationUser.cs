using Authentication.UserAuthentication.IAuthentication;
using Entities.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities.Response;
using ViewModels.DTOs;

namespace Authentication.UserAuthentication.Authentication
{
    public class AuthenticationUser : IAuthenticationUser
    {
        private readonly UserManager<Users> _userManager;
        private readonly RoleManager<Roles> _roleManager;
        private readonly IConfiguration _configuration;
        private Users _users;
        public AuthenticationUser(
            UserManager<Users> userManager,
            RoleManager<Roles> roleManager,
            IConfiguration configuration,
            Users users)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _configuration = configuration;
            _users = users;
        }
        public async Task<ResponseData<string>> Register(UserRegister userRegister)
        {
            try
            {
                var newUser = new Users();
                newUser.UserName = userRegister.Username;
                newUser.Email = userRegister.Email;
                newUser.Address = userRegister.Address;
                newUser.PhoneNumber = userRegister.PhoneNumber;
                newUser.AliasName = userRegister.Alias;
                newUser.Dob = userRegister.Dob;
                newUser.NormalizedEmail = userRegister.Email.ToLower();
                newUser.NormalizedUserName = userRegister.Username.ToLower();

                var checkEmail = await _userManager.FindByEmailAsync(userRegister.Email);

                if (checkEmail != null)
                {
                    var result = await _userManager.CreateAsync(newUser, userRegister.Password);
                    if (result.Succeeded)
                    {
                        var userInfo = new UserRegister()
                        {
                            Username = userRegister.Username,
                            Password = userRegister.Password,
                        };

                        return new ResponseData<string> { IsSuccess = true, DataRespone = "Ok" };
                    }

                    return new ResponseData<string> { IsSuccess = false, ErrorMessage = "False to register new account" };
                }
                else
                {
                    return new ResponseData<string> { IsSuccess = false, ErrorMessage = "Your email or password is exsisted" };
                }
            }
            catch (Exception ex)
            {
                return new ResponseData<string> { IsSuccess = false, ErrorMessage = ex.Message };
            }
        }
    }
}
