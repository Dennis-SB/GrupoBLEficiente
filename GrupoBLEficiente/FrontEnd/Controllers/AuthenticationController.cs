using FrontEnd.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using FrontEnd.Helpers;
using System.Data;

namespace FrontEnd.Controllers
{
    public class AuthenticationController : Controller
    {
        //public List<user> users = null;
        public AuthenticationController()
        {

        }

        // GET: CategoryController/Create
        public ActionResult Register()
        {
            return View();
        }

        /*
         * // POST: CategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(RegisterViewModel user)
        {
            AuthenticationHelper seguridadHelper;
            try
            {
                seguridadHelper = new AuthenticationHelper();
                user = seguridadHelper.RegisterSinRoles(user);
                return LocalRedirect("/Account/Login");
            }
            catch
            {
                return View();
            }
        }
        */

        public IActionResult Login(string ReturnUrl = "/")
        {
            if (User.Identity.IsAuthenticated)
            {
                return Redirect(ReturnUrl);
            }
            UserViewModel objLoginModel = new UserViewModel();
            objLoginModel.ReturnUrl = ReturnUrl;
            return View(objLoginModel);
        }

        [HttpPost]
        public async Task<IActionResult> Login(UserViewModel objLoginModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    AuthenticationHelper seguridadHelper = new AuthenticationHelper();
                    TokenViewModel tokenModel = seguridadHelper.Login(objLoginModel);
                    HttpContext.Session.SetString("token", tokenModel.Token);
                    var EsValido = false;
                    
                    if (tokenModel != null)
                    {
                        EsValido = true;
                    }

                    // var user = users.Where(x => x.Username == objLoginModel.UserName && x.Password == objLoginModel.Password).FirstOrDefault();
                    
                    if (!EsValido)
                    {
                        ViewBag.Message = "Invalid Credentials";
                        return View(objLoginModel);
                    }

                    var loginModel = seguridadHelper.GetUser(objLoginModel);
                    var claims = new List<Claim>() {
                                     new Claim(ClaimTypes.NameIdentifier, loginModel.UserName),
                                         new Claim(ClaimTypes.Name, loginModel.UserName)
                    };

                    foreach (var item in loginModel.roles)
                    {
                        claims.Add(new Claim(ClaimTypes.Role, item));
                    }
                    
                    var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var principal = new ClaimsPrincipal(identity);
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, new AuthenticationProperties()
                    {
                        IsPersistent = objLoginModel.RememberLogin
                    });
                    //return View("AccessDenied");
                    return LocalRedirect(objLoginModel.ReturnUrl);
                }
                return View(objLoginModel);
            }
            catch (Exception)
            {
                return View("AccessDenied");
            }
        }

        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login");
        }
        
        [HttpGet]
        [Route("/MicrosoftIdentity/Account/AccessDenied")]
        public ActionResult AccessDenied()
        {
            return View();
        }
    }
}