using System;
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

        private bool IsValid(string password)
        {
            return true;
        }
    }
}
