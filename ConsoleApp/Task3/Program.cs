using static System.Console;
using ConsoleApp.Task3;

Authenticator auth1 = Authenticator.Instance("user1", "pass1");
Authenticator auth2 = Authenticator.Instance("user2", "pass2"); // Спроба створити другий екземпляр

WriteLine($"auth1 is auth2: {ReferenceEquals(auth1, auth2)}"); // Перевірка, чи це один і той самий об'єкт

WriteLine($"Authentication with correct credentials: {auth1.Authenticate("user1", "pass1")}");
WriteLine($"Authentication with incorrect credentials: {auth1.Authenticate("user2", "pass2")}");