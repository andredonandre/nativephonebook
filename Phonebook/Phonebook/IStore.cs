using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    interface IStore
    {
        void Create(object obj);
        void Update(object obj);
        void Delete(object obj);
    }
}
