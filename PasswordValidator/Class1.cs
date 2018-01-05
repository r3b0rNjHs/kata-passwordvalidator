﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace PasswordValidator
{
    public class PasswordValidatorShould
    {

        [Fact]
        public void validate_all_password_requirements()
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

        private bool IsValid(string password)
        {
            if (password.Length < 6)
            {
                return false;
            }

            if (password.ToUpper().Equals(password))
            {
                return false;
            }

            return true;
        }
    }
}
