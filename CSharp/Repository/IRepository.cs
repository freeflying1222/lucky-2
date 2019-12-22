using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Repository
{
    interface IRepository<T> /*where T : Entity*/
    {
        int Save(T student);
        void Delete(int Id);
        T Load(int id);
    }
}
