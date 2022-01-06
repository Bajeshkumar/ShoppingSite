using Microsoft.AspNetCore.Mvc;
using Shopping_Site.Models;
using Shopping_Site.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping_Site.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountRepository _accountRepo;

        public AccountController(IAccountRepository accountRepository)
        {
            _accountRepo = accountRepository;
        }
        [Route("signup")]
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        [Route("signup")]
        public async Task<IActionResult> SignUp(SignUpUserModel signupusermodel)
        {
            if (ModelState.IsValid)
            {
                //write you code
                var result = await _accountRepo.CreateUserAsync(signupusermodel);
                if (!result.Succeeded)
                {
                    foreach (var errormessage in result.Errors)
                    {
                        ModelState.AddModelError("", errormessage.Description);
                    }
                    return View(signupusermodel);
                }
                ModelState.Clear();
            }
            return View(signupusermodel);
        }
        [Route("signin")]
        public IActionResult SignIn()
        {
            return View();
        }

        [Route("signin")]
        [HttpPost]
        public async Task<IActionResult> SignIn(SignInModel signInModel)
        {
            if (ModelState.IsValid)
            {
                var result = await _accountRepo.PasswordSignInAsync(signInModel);
                if (result.Succeeded)
                {
                    return RedirectToAction("GetAllCategories", "Category");
                }
                ModelState.AddModelError("", "Invalid credentials");
            }
            return View(signInModel);
        }
        
        //public async Task<ActionResult> Logout()
        //{
        //    await _accountRepo.signoutAsync();
        //    return RedirectToAction("GetAllCategories");

        //}

    }
}
