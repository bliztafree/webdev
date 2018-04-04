﻿using System.Threading.Tasks;

namespace Microsoft.bliztafree.Services.Identity.API.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
