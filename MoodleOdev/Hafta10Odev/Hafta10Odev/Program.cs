// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
#region
//MyClass mycs = new MyClass();
//MyClass mycs2 = new MyClass();
//MyClass mycs3 = new MyClass();
//MyClass mycs4 = new MyClass();

//class MyClass
//{
//    //SADECE ilk  nesne için üretilir
//    static MyClass()
//    {
//        Console.WriteLine("Static Constructor");
//    }

//    public MyClass()
//    {
//        Console.WriteLine("Instance create");
//    }
//}
#endregion

Console.WriteLine("Singleton");

ConfigurationService configurationService = ConfigurationService.GetInstance();
ConfigurationService.GetInstance();
ConfigurationService.GetInstance();
ConfigurationService.GetInstance().GetValue("ConnectionStrings:ExampleDb"); ;
//var azureConnString = configurationService.GetValue("ConnectionStrings:ExampleDb");

