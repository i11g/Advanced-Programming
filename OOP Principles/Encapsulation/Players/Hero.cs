namespace Players;

public class Hero
{
    private string _username;
    private int _level; 

    public string Username
    {
        get { return _username; }
        set { _username = value; }
    }

    public int Level
    {
        get { return _level; }
        set { _level = value; }
    }

}
