﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace DIAS_Project.Pages.Account
{
    public class LogoutModel : PageModel
    {
        private readonly IConfiguration _configuration;
        public LogoutModel(IConfiguration configuration) {
            _configuration = configuration;
        }
        public async Task<IActionResult> OnGet() {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            string lang = _configuration.GetValue<string>("DefaultSystemLang");
            HttpContext.Session.Clear();
            if (!string.IsNullOrEmpty(Request.Cookies["userLang"]))
                lang = Request.Cookies["userLang"];
            return Redirect("~/Development/Account/Login/?culture=" + lang);
        }

        public async Task<IActionResult> OnPostLogout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            string lang = _configuration.GetValue<string>("DefaultSystemLang");
            foreach (var cookie in Request.Cookies.Keys)
            {
                //if (cookie == ".AspNetCore.Session")
                    Response.Cookies.Delete(cookie);
            }
            HttpContext.Session.Clear();

            return new OkResult();
            //if (!string.IsNullOrEmpty(Request.Cookies["userLang"]))
            //    lang = Request.Cookies["userLang"];            
           // return Redirect("~/Account/Login/?culture=" + lang);
        }
    }
}