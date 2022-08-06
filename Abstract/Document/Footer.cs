using System;

namespace Abstract
{
    class Footer : Part
    {
        public override string Content
        {
            get
            {
                if (content != null)
                    return content;
                else
                    return "No footer in the Document. ";
            }

            set
            {
                content = value;
            }
        }

        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
