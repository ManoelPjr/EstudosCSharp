using System;

namespace Template.Classes
{
    //'ConcreteClass' - concrete class
    class RTFDocument : DocumentReader
    {
        public override void InterpretDocumentFormat()
        {
            Console.WriteLine("Document file is processed with " +
                                "RTF Interpreter");
        }
    }
}
