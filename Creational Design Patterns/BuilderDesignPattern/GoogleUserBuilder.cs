using System;

namespace BuilderDesignPattern
{
    public class GoogleUserBuilder : Builder
    {
        public override void setUserAuthentication()
        {
            Object userAuthentication = new {
                Type = "Google"
            };
            theUser.Authentication = userAuthentication; 
        }

        public override void setUserId(int id)
        {
            theUser.Id = id;
        }

        public override void setUserRoles()
        {
            Object userRoles = new {
                Name = "Google Admin"
            };
            theUser.Roles = userRoles;
        }
    }
}