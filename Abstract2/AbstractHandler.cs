using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract2
{
    abstract class AbstractHandler
    {
        protected string fileName;

        public AbstractHandler(string fileName)
        {
            this.fileName = fileName;
        }

        public void Open()
        {
            Console.WriteLine(fileName + " opened.");
        }
        public void Create()
        {
            Console.WriteLine(fileName + " created.");
        }
        public void Change()
        {
            Console.WriteLine(fileName + " edited.");
        }
        public abstract void Save();

    }

    class XMLHandler : AbstractHandler
    {
        public XMLHandler(string fileName)
            : base(fileName)
        {

        }
        public override void Save()
        {
            Console.WriteLine(fileName + " saved as XML.");
        }
    }

    class TXTHandler : AbstractHandler
    {
        public TXTHandler(string fileName)
            : base(fileName)
        {

        }
        public override void Save()
        {
            Console.WriteLine(fileName + " saved as TXT.");
        }
    }

    class DOCHandler : AbstractHandler
    {
        public DOCHandler(string fileName)
            : base(fileName)
        {

        }
        public override void Save()
        {
            Console.WriteLine(fileName + " saved as DOC.");
        }
    }
}
