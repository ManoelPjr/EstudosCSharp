namespace Facade.Classes
{
    /// <summary>
    /// Student class
    /// </summary>
    class Student
    {
        private string _name;

        // Constructor
        public Student(string name)
        {
            this._name = name;
        }

        // Gets the name
        public string Name
        {
            get { return _name; }
        }
    }
}
