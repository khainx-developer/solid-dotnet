namespace SolidPrinciples;

public class User
{
}

public class UserDataAccessLogic
{
    public User GetEmployeeDetails(int id)
    {
        // get user detail
        return new User();
    }
}

public class UserBusinessLogic
{
    // this property depends on low level class
    UserDataAccessLogic _userDataAccessLogic;

    public UserBusinessLogic(UserDataAccessLogic userDataAccessLogic)
    {
        _userDataAccessLogic = userDataAccessLogic;
    }

    public User GetUserDetails(int id)
    {
        return _userDataAccessLogic.GetEmployeeDetails(id);
    }
}

// refactor
public interface IUserDataAccessLogic
{
    User GetEmployeeDetails(int id);
}

public class UserDataAccessLogicV1 : IUserDataAccessLogic
{
    public User GetEmployeeDetails(int id)
    {
        // get user detail
        return new User();
    }
}
public class UserBusinessLogicV1
{
    // this property depends on low level class
    IUserDataAccessLogic _userDataAccessLogic;

    public UserBusinessLogicV1(IUserDataAccessLogic userDataAccessLogic)
    {
        _userDataAccessLogic = userDataAccessLogic;
    }

    public User GetUserDetails(int id)
    {
        return _userDataAccessLogic.GetEmployeeDetails(id);
    }
}