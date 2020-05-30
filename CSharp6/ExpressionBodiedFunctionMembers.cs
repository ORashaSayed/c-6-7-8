namespace CSharp6
{   //Many members that you write are single statements that could be single expressions. 
    //Write an expression-bodied member instead. It works for methods and read-only properties. For example
    //, an override of ToString() is often a great candidate:


    class ExpressionBodiedFunctionMembers
    {
        public string LastName { get; private set; }
        public string FirstName { get; private set; }

        public override string ToString() => $"{LastName}, {FirstName}";
        public string FullName => $"{FirstName} {LastName}";
    }
}
