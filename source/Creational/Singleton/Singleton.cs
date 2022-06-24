namespace Singleton;

public sealed class Singleton
{
    private static Singleton instance = null;

    private static readonly object instanceLock = new();

    public static Singleton Instance
    {
        get
        {
            if (instance == null)
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                }
            }

            return instance;
        }
    }

    private Singleton() { }
}
