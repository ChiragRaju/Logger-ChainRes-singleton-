using LoggerFramework;

public class Program
{
   public static void Main()
    {
        var logger = LogManager.Instance;

        logger.Logger("System is starting", LoggerEnum.INFO);
        logger.Logger("Debugging", LoggerEnum.DEBUG);
        logger.Logger("Error", LoggerEnum.ERROR);
        logger.Logger("Warning", LoggerEnum.WARNING);

    }
}
