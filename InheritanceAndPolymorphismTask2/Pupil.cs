using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism
{
    class Pupil
    {
        public virtual void Study()
        {
            Console.WriteLine($"Study ");
        }

        public virtual void Read()
        {
            Console.WriteLine($"Read ");
        }

        public virtual void Write()
        {
            Console.WriteLine($"Write ");
        }

        public virtual void Relax()
        {
            Console.WriteLine($"Relax ");
        }
    }

    class ExelentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine($"Study ExelentPupil");
        }

        public override void Read()
        {
            Console.WriteLine($"Read ExelentPupil");
        }

        public override void Write()
        {
            Console.WriteLine($"Write ExelentPupil");
        }

        public override void Relax()
        {
            Console.WriteLine($"Relax ExelentPupil");
        }
    }

    class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine($"Study GoodPupil");
        }

        public override void Read()
        {
            Console.WriteLine($"Read GoodPupil");
        }

        public override void Write()
        {
            Console.WriteLine($"Write GoodPupil");
        }

        public override void Relax()
        {
            Console.WriteLine($"Relax GoodPupil");
        }
    }

    class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine($"Study BadPupil");
        }

        public override void Read()
        {
            Console.WriteLine($"Read BadPupil");
        }

        public override void Write()
        {
            Console.WriteLine($"Write BadPupil");
        }

        public override void Relax()
        {
            Console.WriteLine($"Relax BadPupil");
        }
    }
}
