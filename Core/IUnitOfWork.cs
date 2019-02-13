using RoyCityCemetery.Core.Repositories;
using System;

namespace RoyCityCemetery.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IDeathRecordRepository DeathRecords { get; }
        int Complete();
    }
}