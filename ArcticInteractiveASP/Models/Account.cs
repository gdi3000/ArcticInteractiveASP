using System;
using System.Collections.Generic;

using System.Web;

namespace ArcticInteractiveASP { 
    public class Account
    {
        private static Account _LoggedInUser;
        public string Name { get; set; }
        public string Password { get; set; }

    private string _pwdHash;
    public Account(string username, string pwdHash)
    {
        Username = username;
        _pwdHash = pwdHash;

    }

    public Account()
    {

    }

    public string Username { get; set; }
    public string PwdHash
    {
        get
        {
            if (_pwdHash != null)
            {
                return _pwdHash.ToUpper();

            }

            return "invalid";
        }

        set => _pwdHash = value;
    }
}
    }

