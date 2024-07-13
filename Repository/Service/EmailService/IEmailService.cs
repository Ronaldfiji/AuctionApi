using SharedModel.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Service.EmailService
{
    public interface IEmailService
    {
        void SendEmail(EmailDto emailDto);
    }
}
