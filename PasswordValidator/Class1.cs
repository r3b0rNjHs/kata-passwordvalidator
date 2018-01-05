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
        public void isvalid()
        {
            Validate("Abc4_s").Should().BeTrue();
        }

        private bool Validate(string password)
        {
            return false;
        }
    }
}
