using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurkeyService;

namespace AdapterPattern.Adapter
{
    public class TurkeyAdapter : Duck
    {
        private ITurkey turkey;
        public TurkeyAdapter(ITurkey turkey)
        {
            this.turkey = turkey;
        }

        public override void Fly()
        {
            for (int i = 0; i < 5; i++)
            {
                turkey.Fly();
            }
        }

        public override void Quack()
        {
            turkey.Gobble();
        }
    }
}
