using Playstore;

int x = 10;
IUser userObj1 = new User();
userObj1.AddUser();

Console.WriteLine("My Play Store");


//How to create object for class?
User userObj = new User();
Console.WriteLine("My Name: " +userObj.Name);
userObj.CreateUser(); //function calling

Categories categories = new Categories(11, "Fashion", "Fashion Test");

Console.WriteLine(categories.Id);
Console.WriteLine(categories.Name);
Console.WriteLine(categories.Description);

categories.AddCategory(1, "ABC");
categories.AddCategory(2, "XYZ", "Test");