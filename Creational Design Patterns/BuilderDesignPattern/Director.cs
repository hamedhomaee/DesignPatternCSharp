namespace BuilderDesignPattern
{
    public class Director
    {
        public static User MakeUser(Builder builder, int id) 
        {
            builder.CreateUser();
            builder.setUserId(id);
            builder.setUserAuthentication();
            builder.setUserRoles();
            return builder.PassUser();
        }
    }
}