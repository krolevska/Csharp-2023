using System;

namespace Abstract
{
    class Title : Part
    {
        public override string Content
        {
            get
            {
                if (content != null)
                    return content;
                else
                    return "No title in the Document. ";
            }

            set
            {
                content = value;
            }
        }

        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
