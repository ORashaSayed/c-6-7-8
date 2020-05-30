namespace CSharp8
{
  //Declare readonly members when a struct can't be immutable
 //Declare a readonly struct to express that a type is immutable. That enables the compiler to save defensive copies when using in parameters.

    struct ReadOnlyStructMembers
    {
        public readonly int MyProperty { get; }
    }

}
