namespace RegexLib.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {

    }
}
Teste unitário que verifica se o método valida corretamente um e-mail válido.
```csharpnamespace RegexLib.Tests
{
    public class RegexValidatorTests
    {
        [Fact]
        public void Should_Validate_Valid_Email()
        {
            // Arrange
            var validator = new RegexValidator();
            var validEmail = "test@example.com";

            // Act
            var result = validator.IsValidEmail(validEmail);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Should_Invalidate_Invalid_Email()
        {
            // Arrange
            var validator = new RegexValidator();
            var invalidEmail = "invalid-email";

            // Act
            var result = validator.IsValidEmail(invalidEmail);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void Should_Invalidate_Email_Without_At_Symbol()
        {
            // Arrange
            var validator = new RegexValidator();
            var invalidEmail = "testexample.com";

            // Act
            var result = validator.IsValidEmail(invalidEmail);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void Should_Invalidate_Email_With_Invalid_Domain()
        {
            // Arrange
            var validator = new RegexValidator();
            var invalidEmail = "test@.com";

            // Act
            var result = validator.IsValidEmail(invalidEmail);

            // Assert
            Assert.False(result);
        }
    }

    public class RegexValidator
    {
        public bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            var emailRegex = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return System.Text.RegularExpressions.Regex.IsMatch(email, emailRegex);
        }
    }
}



Teste unitário que verifica se o método detecta corretamente um e-mail inválido.

using Xunit;

namespace RegexLib.Tests
{
    public class RegexValidatorTests
    {
        [Fact]
        public void Should_Validate_Valid_Email()
        {
            // Arrange
            var validator = new RegexValidator();
            var validEmail = "test@example.com";

            // Act
            var result = validator.IsValidEmail(validEmail);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Should_Invalidate_Invalid_Email()
        {
            // Arrange
            var validator = new RegexValidator();
            var invalidEmail = "invalid-email";

            // Act
            var result = validator.IsValidEmail(invalidEmail);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void Should_Invalidate_Email_Without_At_Symbol()
        {
            // Arrange
            var validator = new RegexValidator();
            var invalidEmail = "testexample.com";

            // Act
            var result = validator.IsValidEmail(invalidEmail);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void Should_Invalidate_Email_With_Invalid_Domain()
        {
            // Arrange
            var validator = new RegexValidator();
            var invalidEmail = "test@.com";

            // Act
            var result = validator.IsValidEmail(invalidEmail);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void Should_Invalidate_Email_With_Spaces()
        {
            // Arrange
            var validator = new RegexValidator();
            var invalidEmail = "test @example.com";

            // Act
            var result = validator.IsValidEmail(invalidEmail);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void Should_Invalidate_Email_With_Multiple_At_Symbols()
        {
            // Arrange
            var validator = new RegexValidator();
            var invalidEmail = "test@@example.com";

            // Act
            var result = validator.IsValidEmail(invalidEmail);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void Should_Invalidate_Email_With_Empty_Local_Part()
        {
            // Arrange
            var validator = new RegexValidator();
            var invalidEmail = "@example.com";

            // Act
            var result = validator.IsValidEmail(invalidEmail);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void Should_Invalidate_Email_With_Empty_Domain()
        {
            // Arrange
            var validator = new RegexValidator();
            var invalidEmail = "test@";

            // Act
            var result = validator.IsValidEmail(invalidEmail);

            // Assert
            Assert.False(result);
        }
    }

    public class RegexValidator
    {
        public bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            var emailRegex = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return System.Text.RegularExpressions.Regex.IsMatch(email, emailRegex);
        }
    }
}





