using System;

namespace Abstract
{
    abstract class Part
    {
        protected string content;
        abstract public string Content { get; set; }
        abstract public void Show();
    }
}
