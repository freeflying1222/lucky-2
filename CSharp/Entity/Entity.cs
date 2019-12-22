using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    class Entity<T>
    {
        public T Id { get; private set; }
    }
}
