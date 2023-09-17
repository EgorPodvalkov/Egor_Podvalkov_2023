namespace Skeleton.BLL.Exceptions;

public class UserRegistrationFailedException : Exception
{
    public UserRegistrationFailedException(string password)
        : base($"User with password {password} already exists")
    {
        // easter egg
    }
}