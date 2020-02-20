using Microsoft.EntityFrameworkCore;
using QRPaymentSystem.Server.Domain.Models;

namespace QRPaymentSystem.Server.Repository.EntityFramework.Repositories
{
    public class MoneyAccountRepository : Repository<MoneyAccount>, IMoneyAccountRepository
    {
        public MoneyAccountRepository(QRPaymentSystemDbContext context) : base(context)
        {
        }
    }
}