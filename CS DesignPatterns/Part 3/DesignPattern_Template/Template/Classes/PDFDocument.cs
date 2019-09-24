using System;

namespace Template.Classes
{
    //'ConcreteClass'- concrete class
    class PDFDocument : DocumentReader
    {
        public override void InterpretDocumentFormat()
        {
            Console.WriteLine("Document file is processed with " +
                                "PDF Interpreter");
        }
    }
}
