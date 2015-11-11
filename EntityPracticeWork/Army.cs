using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityPracticeWork
    {
    abstract class Army
        {
        public virtual List<Warrior> Troops { get; set; }  //don't need to override this !
        }

    class NinjaClan : Army
        {
       
        }

    class SamuraiClan : Army
        {

        }
    }
