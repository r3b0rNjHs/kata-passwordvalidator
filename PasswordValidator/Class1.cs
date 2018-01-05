using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace PasswordValidator
{
    public class PasswordValidatorShould
    {
        [Fact]
        public void Validate_all_password_requirements()
        {
            IsValid("Abc4_s").Should().BeTrue();
        }

        [Fact]
        public void deny_lenghts_shorter_than_6()
        {
            IsValid("Abc4_").Should().BeFalse();
        }

        [Fact]
        public void deny_if_doesnt_use_lowercase()
        {
            IsValid("ABC4_S").Should().BeFalse();
        }

        [Fact]
        public void deny_if_doesnt_use_uppercase()
        {
            IsValid("abc4_s").Should().BeFalse();
        }

        [Fact]
        public void deny_if_doesnt_use_number()
        {
            IsValid("abcD_s").Should().BeFalse();
        }

        [Fact]
        public void deny_if_doesnt_use_underscore()
        {
            IsValid("abcD4s").Should().BeFalse();
        }

        private bool IsValid(string password)
        {
            if (password.Length < 6 || password.ToLower().Equals(password) || password.ToUpper().Equals(password))
            {
                return false;
            }

            if (Regex.Replace(password, "[0-9]", "").Equals(password))
            {
                return false;
            }

            return true;
        }
    }
}