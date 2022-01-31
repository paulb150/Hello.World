using System;

namespace Hello.World
{
    public class HelloMessage
    {
        public string FirstName { get; }
        public string LastName { get; }
        public HelloMessage(string firstName, string lastName)
        {
            this.LastName = lastName;
            this.FirstName = firstName;
        }

        public string GetMessage(){
            return $"Hello, {FirstName} {LastName}";
        }
    }
}
