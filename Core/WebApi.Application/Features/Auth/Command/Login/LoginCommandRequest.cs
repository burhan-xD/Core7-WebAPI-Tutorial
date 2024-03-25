using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Application.Features.Auth.Command.Login
{
    public class LoginCommandRequest : IRequest<LoginCommandResponse>
    {
        [DefaultValue("testmest@mest.test")]  // for swager-test
        public string Email { get; set; }

        [DefaultValue("123456")]            // for swager-test
        public string Password { get; set; }
    }
}
