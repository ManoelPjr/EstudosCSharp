using Visitor.Classes;

namespace Visitor.Interfaces
{
    /// <summary>
    /// The 'Visitor' interface
    /// </summary>
    interface IVisitor
    {
        void Visit(Element element);
    }
}
