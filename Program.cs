using System;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main(string[] args)
    {
        string email = "test@example.com";
        string password = "Password123";
        string phoneNumber = "+998912345678";

        bool isEmailValid = ValidateEmail(email);
        bool isPasswordValid = ValidatePassword(password);
        bool isPhoneNumberValid = ValidatePhoneNumber(phoneNumber);

        Console.WriteLine($"Email is valid: {isEmailValid}");
        Console.WriteLine($"Password is valid: {isPasswordValid}");
        Console.WriteLine($"Phone number is valid: {isPhoneNumberValid}");
    }

    public static bool ValidateEmail(string email)
    {
        string emailPattern = @"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$";
        return Regex.IsMatch(email, emailPattern);
    }

    public static bool ValidatePassword(string password)
    {
        string passwordPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d!@#$%^&*()+={}\[\]:;""'<>?,.-]{8,16}$";
        return Regex.IsMatch(password, passwordPattern);
    }

    public static bool ValidatePhoneNumber(string phoneNumber)
    {
        string phoneNumberPattern = @"^\+\d{12}$";
        return Regex.IsMatch(phoneNumber, phoneNumberPattern);
    }
}