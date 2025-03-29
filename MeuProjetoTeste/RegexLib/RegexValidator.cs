// Classe que valida se uma string é um e-mail válido usando regex

using System.Text.RegularExpressions;

public class RegexValidator
{
    // Método que valida se uma string é um e-mail válido usando regex
    public bool IsValidEmail(string email)
    {
        string pattern = @"^[\w\.-]+@[\w\.-]+\.\w+$";
        Regex regex = new Regex(pattern);
        return regex.IsMatch(email);
    }
}
// Método que valida se uma senha tem pelo menos 8 caracteres, uma letra maiúscula, um número e um caractere especial usando regex

public class RegexValidator
{
    // Método que valida se uma string é um e-mail válido usando regex
    public bool IsValidEmail(string email)
    {
        string pattern = @"^[\w\.-]+@[\w\.-]+\.\w+$";
        Regex regex = new Regex(pattern);
        return regex.IsMatch(email);
    }

    // Método que valida se uma senha tem pelo menos 8 caracteres, uma letra maiúscula, um número e um caractere especial usando regex
    public bool IsValidPassword(string password)
    {
        string pattern = @"^(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";
        Regex regex = new Regex(pattern);
        return regex.IsMatch(password);
    }
}