using UserAccount = UserAccountNamespace.UserAccount;

namespace UserAccountNamespace;

class Cashier : UserAccount
{
    private string department;
    public Cashier(string name, string department, string uName, string password) : base(name, uName, password)
    {
        this.department = department;
    }

    public override bool validateLogin(string uName, string password)
    {
        return (this.userName == uName && this.userPassword == password);
    }

    public string getDepartment()
    {
        return department;
    }
}