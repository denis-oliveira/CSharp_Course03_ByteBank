﻿using ByteBank.Systems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class CommercialPartner : IAuthenticable
    {
        public string Password { get; set; }
        public bool Authenticate(string passwordAttempt)
        {
            return this.Password == passwordAttempt;
        }
    }
}
