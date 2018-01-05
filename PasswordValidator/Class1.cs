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
        public void IsValid()
        {
            Validate("Abc4_s").Should().BeTrue();
        }

        private bool Validate(string password)
        {
            if (password.Length < 6)
            {
                return false;
            }
            return true;
        }
    }
}
