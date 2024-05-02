using Microsoft.Extensions.Configuration;


namespace Repository.Util
{

    static class ConfigurationManager
    {
        public static IConfiguration AppSetting
        {
            get;
        }
        static ConfigurationManager()
        {
            AppSetting = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
        }
    }

}

/*
try
{
    System.IO.DirectoryInfo directoryInfo =
        System.IO.Directory.GetParent(Directory.GetCurrentDirectory());

    System.Console.WriteLine("directory name : " + directoryInfo?.FullName);
}
catch (ArgumentNullException)
{
    System.Console.WriteLine("Path is a null reference.");
}
catch (ArgumentException)
{
    System.Console.WriteLine("Path is an empty string, " +
        "contains only white spaces, or " +
        "contains invalid characters.");
}
*/