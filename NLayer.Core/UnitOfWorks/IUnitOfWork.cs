using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.UnitOfWorks
{
    // Birden fazla işlem ve katman yapılarındaki işleri tek bir iş gibi yönetme işlemi => Unit of Work
    public interface IUnitOfWork
    {
        Task CommitAsync();
        void Commit();
    }
}
