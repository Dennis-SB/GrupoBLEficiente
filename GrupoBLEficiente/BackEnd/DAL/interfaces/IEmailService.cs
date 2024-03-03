using BackEnd.Models.Service;

namespace BackEnd.DAL.interfaces
{
    public interface IEmailService
    {
        void SendEmail(Message message);
    }
}