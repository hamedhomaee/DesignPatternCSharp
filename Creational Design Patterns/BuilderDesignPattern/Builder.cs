using System;

namespace BuilderDesignPattern
{
    public abstract class Builder
    {
        protected User theUser; 
        public abstract void setUserId(int id);
        public abstract void setUserAuthentication();
        public abstract void setUserRoles();
        public void CreateUser() 
        {
            theUser = new User();
        }
        public User PassUser() 
        {
            return theUser;
        }
    }
}