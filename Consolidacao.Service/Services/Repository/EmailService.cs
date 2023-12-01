
using consolidacao.domain.Intefaces;
using consolidacao.domain.Models;
using Consolidacao.Service.Services.Intefaces;

namespace Consolidacao.Service.Services.Repository
{
    public class EmailService : IEmailService
    {
        private readonly IEmailRepository _emailRepository;

        public EmailService(IEmailRepository emailRepository)
        {
            _emailRepository = emailRepository;
        }

        public void Salva(Email email)
        {
            _emailRepository.Save(email);
        }
    }
}
