
namespace UserAccountNamespace;

abstract class UserAccount
{
    private string fullName;
    protected string userName;
    protected string userPassword;

    public UserAccount(string name, string uName, string password)
    {
        this.fullName = name;
        this.userName = uName;
        this.userPassword = password;
    }

    public abstract bool validateLogin(string uName, string password);

    public string getFullName
    {
        get { return fullName; }
        set { fullName = value; }
    }
}
