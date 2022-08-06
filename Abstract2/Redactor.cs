using System;

namespace Abstract2
{
    class Redactor
    {
        AbstractHandler handler;

        public void ChooseDocument(string fileName)
        {
            string format = fileName.Substring(fileName.Length - 4);

            switch (format.ToLower())
            {
                case ".txt":
                    handler = new TXTHandler(fileName);
                    break;
                case ".doc":
                    handler = new DOCHandler(fileName);
                    break;
                case ".xml":
                    handler = new XMLHandler(fileName);
                    break;
                default:
                    Console.WriteLine("Format unknown. ");
                    break;
            }
        }


        public void Open()
        {
            if (handler != null)
            {
                handler.Open();
            }
        }

        public void Create()
        {
            if (handler != null)
            {
                handler.Create();
            }
        }

        public void Change()
        {
            if (handler != null)
            {
                handler.Change();
            }
        }

        public void Save()
        {
            if (handler != null)
            {
                handler.Save();
            }
        }
    }
}
