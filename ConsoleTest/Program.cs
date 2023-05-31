using Trader.Domain.Models;
using Trader.Domain.Services;
using Trader.EntityFramework;
using Trader.EntityFramework.Services;
using System;


namespace ConsoleTest // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            IDataService<User> userService = new GenericDataService<User>(new SimpleTraderDbContextFactory());
            userService.Create(new User { Username = "Test" }).Wait();
        }
    }
}