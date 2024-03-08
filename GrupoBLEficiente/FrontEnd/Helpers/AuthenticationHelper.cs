using FrontEnd.Models;
using Newtonsoft.Json;
using System.Security.Claims;

namespace FrontEnd.Helpers
{
    public class AuthenticationHelper
    {
        ServiceRepository repository;

        public AuthenticationHelper()
        {
            repository = new ServiceRepository();
        }

        /*public RegisterViewModel RegisterSinRoles(RegisterViewModel user, string role = "Socio")
        {
            HttpResponseMessage responseMessage = repository.PostResponse("api/Authentication/RegisterSinRoles", user);
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            RegisterViewModel registerAPI = JsonConvert.DeserializeObject<RegisterViewModel>(content);
            return registerAPI;
        }*/

        /*public RegisterViewModel Register(RegisterViewModel user, string role = "Socio")
        {
            HttpResponseMessage responseMessage = repository.PostResponse("api/Authentication/RegisterSinRoles", user);
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            RegisterViewModel registerAPI = JsonConvert.DeserializeObject<RegisterViewModel>(content);
            return registerAPI;
        }*/

        public TokenViewModel Login(UserViewModel usuario)
        {
            try
            {
                TokenViewModel TokenModel;
                HttpResponseMessage responseMessage = repository.PostResponse("api/Authentication/Login", new { usuario.UserName, usuario.Password });
                var content = responseMessage.Content.ReadAsStringAsync().Result;
                TokenModel = JsonConvert.DeserializeObject<TokenViewModel>(content);
                return TokenModel;
            }
            catch (Exception)
            {
                throw;
            }
        }
        
        public LoginViewModel GetUser(UserViewModel usuario)
        {
            HttpResponseMessage responseMessage = repository.PostResponse("api/Authentication/GetUser", usuario);
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            LoginViewModel loginModel = JsonConvert.DeserializeObject<LoginViewModel>(content);
            return loginModel;
        }
    }
}