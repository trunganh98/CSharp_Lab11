using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session13
{
    class GeneralList2<T>
    {
        protected T ItemOne;
        public GeneralList2(T valOne)
        {
            ItemOne = valOne;
        }
        public virtual T GetValue()
        {
            return ItemOne;
        }

        
    }
}
