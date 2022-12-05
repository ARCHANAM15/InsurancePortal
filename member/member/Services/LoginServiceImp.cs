using member.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace member.Services
{
    public class LoginServiceImp : ILoginService
    {
        InsuranceDbContext db;
        private IConfiguration _config;

        public LoginServiceImp(IConfiguration config, InsuranceDbContext _db)
        {
            config = _config;
            db = _db;
        }
        public LoginTbl AuthenticateUser(LoginTbl login, bool IsRegister)
        {
            throw new NotImplementedException();
        }

        public string GenerateToken(LoginTbl login)
        {
            throw new NotImplementedException();
        }

        public Task<string> Login(LoginTbl login, bool Isregister)
        {
            throw new NotImplementedException();
        }

        public Task<string> Register(LoginTbl login, bool Isregister)
        {
            throw new NotImplementedException();
        }
    }
}
