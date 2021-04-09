using System;

namespace BuilderDesignPattern
{
    public class MicrosoftUserBuilder : Builder
    {
        public override void setUserAuthentication()
        {
            Object userAuthentication = new {
                Type = "Microsoft"
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
                Name = "Microsoft Admin"
            };
            theUser.Roles = userRoles;
        }
    }
}