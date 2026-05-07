using BCrypt.Net;

string password = "Admin@123";

string hashedPassword =
    BCrypt.Net.BCrypt.HashPassword(password);

Console.WriteLine("Hashed Password:");
Console.WriteLine(hashedPassword);

bool isVerified =
    BCrypt.Net.BCrypt.Verify(
        "Admin@123",
        hashedPassword);

Console.WriteLine($"Password Match: {isVerified}");
