
// Console.WriteLine("Hello, World!");


// int age = 37;
// string name = "Veronica";
// bool isHere = true;
// double salary = 22000.01; 


// Console.WriteLine($"Hi, {name}. Your age is {age}. Is she here? {isHere}");
// Console.WriteLine($"And you make ${salary} a year.");

try{

 savingsAccount myAccount 
 = new savingsAccount(300);


Console.WriteLine($"Your balance is ");

Console.WriteLine(myAccount.getBalance());
} catch (Exception ex) {
    Console.WriteLine($"We got an error: {ex.Message}");
}
