using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Base
{
    public abstract class Receiver<T>
    {
        public void Receive(T t)
        {
            if (IsAccept(t) == false)
            {
                return;
            }
            Process(t);
        }

        protected abstract bool IsAccept(T t);

        public abstract void Process(T t);
    }
}
