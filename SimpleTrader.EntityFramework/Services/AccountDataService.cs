using Microsoft.EntityFrameworkCore;
using SimpleTrader.EntityFramework.Services.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trader.Domain.Models;
using Trader.Domain.Services;
using Trader.EntityFramework;

namespace SimpleTrader.EntityFramework.Services
{
    public class AccountDataService : IDataService<Account>
    {
        private readonly SimpleTraderDbContextFactory _contextFactory;
        private readonly NonQueryDataService<Account> _noQueryDataService;

        public AccountDataService(SimpleTraderDbContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
            _noQueryDataService = new NonQueryDataService<Account>(contextFactory);
        }

        public async Task<Account> Create(Account entity)
        {
            return await _noQueryDataService.Create(entity);

        }

        public async Task<bool> Delete(int id)
        {
            return await _noQueryDataService.Delete(id);
        }

        public async Task<IEnumerable<Account>> GetAll()
        {
            using (SimpleTraderDbContext context = _contextFactory.CreateDbContext(null))
            {
                IEnumerable<Account> entitys = await context.Accounts.Include(a => a.AssetTransactions).ToListAsync();
                return entitys;
            }
        }

        public async Task<Account> GetById(int id)
        {
            using (SimpleTraderDbContext context = _contextFactory.CreateDbContext(null))
            {
                Account entity = await context.Accounts.Include(a => a.AssetTransactions).FirstOrDefaultAsync((e) => e.Id == id);
                return entity;
            }

        }

        public async Task<Account> Update(int id, Account entity)
        {
            return await _noQueryDataService.Update(id, entity);
        }
    }
}
