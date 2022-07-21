using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism
{
    class DocumentWorker
    {
        public void OpenDocument()
        {
            Console.WriteLine("Document opened. ");
        }
        public virtual void EditDocument()
        {
            Console.WriteLine("Document may be edited in the Pro version. ");
        }
        public virtual void SaveDocument()
        {
            Console.WriteLine("Document may be saved in the Pro version. ");
        }
    }

    class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("Document edited. ");
        }

        public override void SaveDocument()
        {
            Console.WriteLine("Document saved in the old format, it may be saved in other formats in the Expert version. ");
        }
    }
    class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Document saved in a new format. ");
        }
    }
}
