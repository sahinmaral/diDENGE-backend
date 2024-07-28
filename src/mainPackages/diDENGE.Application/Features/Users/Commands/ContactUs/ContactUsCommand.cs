using diDENGE.Application.Services.MailService;
using MediatR;

namespace diDENGE.Application.Features.Users.Commands.ContactUs;

public class ContactUsCommand : IRequest
{
    public string NameSurname { get; set; }
    public string Email { get; set; }
    public string Content { get; set; }
    public string ReportType { get; set; }

    public class ContactUsCommandHandler : IRequestHandler<ContactUsCommand>
    {
        private readonly IMailService _mailService;

        public ContactUsCommandHandler(IMailService mailService)
        {
            _mailService = mailService;
        }

        public async Task Handle(ContactUsCommand request, CancellationToken cancellationToken)
        {
            var htmlTemplate = @"
<!DOCTYPE html>
<html lang='tr'>
<head>
    <meta charset='UTF-8'>
    <meta name='viewport' content='width=device-width, initial-scale=1.0'>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f4;
            margin: 0;
            padding: 0;
        }
        .container {
            max-width: 600px;
            margin: 20px auto;
            background-color: #fff;
            padding: 20px;
            box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);
        }
        .header {
            background-color: #4CAF50;
            color: white;
            padding: 10px 0;
            text-align: center;
        }
        .content {
            margin: 20px 0;
        }
        .footer {
            text-align: center;
            margin-top: 20px;
            font-size: 12px;
            color: #777;
        }
    </style>
</head>
<body>
    <div class='container'>
        <div class='header'>
            <h2>{{ReportType}} Raporu</h2>
        </div>
        <div class='content'>
            <p><strong>Ad Soyad:</strong> {{NameSurname}}</p>
            <p><strong>Email:</strong> {{Email}}</p>
            <p><strong>Mesaj:</strong></p>
            <p>{{Content}}</p>
        </div>
        <div class='footer'>
            <p>&copy; 2024 didenge. Tüm hakları saklıdır.</p>
        </div>
    </div>
</body>
</html>";
            
            var emailBody = htmlTemplate
                .Replace("{{NameSurname}}", request.NameSurname)
                .Replace("{{Email}}", request.Email)
                .Replace("{{Content}}", request.Content)
                .Replace("{{ReportType}}", request.ReportType);
            
            await _mailService.SendMailAsync(request.Email, $"{request.ReportType} Raporu",emailBody);
        }
    }
}
