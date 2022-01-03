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
    }
}
