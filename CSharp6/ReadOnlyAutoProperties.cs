using System;

namespace CSharp6
{
    //The FirstName and LastName properties can be set only in the body of the constructor of the same class:
    //This feature enables true language support for creating immutable types and uses the more concise and convenient auto-property syntax.

    class ReadOnlyAutoProperties
    {
        public string FirstName { get; }
        public string LastName { get; } = "lk";
        public ReadOnlyAutoProperties(string firstName, string lastName)
        {
            if (string.IsNullOrWhiteSpace(lastName))
                throw new ArgumentException(message: "Cannot be blank", paramName: nameof(lastName));
            FirstName = firstName;
            LastName = lastName;
        }
        //Trying to set LastName in another method generates a CS0200 compilation error:
        //public void ChangeName(string newLastName)
        //{
        //    // Generates CS0200: Property or indexer cannot be assigned to -- it is read only
        //    LastName = newLastName;
        //}
    }
}
