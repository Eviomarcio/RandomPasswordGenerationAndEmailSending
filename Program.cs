using RandomPasswordGenerationAndEmailSending.Entities;
using RandomPasswordGenerationAndEmailSending.Service;

var provider = "smtp.office365.com";
var userName = "";
var password = "";

var outlook = new Email(provider, userName, password);

outlook.SendEmail(
    emailsTo: new List<string>
    {
        "Um ou uma lista de emails para enviar"
    },
    subject: "Geração de senha aleatória",
    body: $"Sua nova senha Temporaria é: {GeneratePasswordRandomService.GenerateRandomPassword()}",
    attachments: new List<string>
    {
        @"Path dos anexos."
    });
