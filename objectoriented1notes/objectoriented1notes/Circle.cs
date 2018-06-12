using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objectoriented1notes
{
    class UserClass
    {
        //Data here (member variables)
        //we typically want data private

        //don't put values in here--this is the blueprint
        //there can be default values, like paid always starts false
        //Full name
        private string name;
        //password
        private string password;
        //email
        private string email;
        //age
        private int age;
        //paid subscriber
        private bool paid;

        //registration date
        private DateTime regdate;

        //Methods
        //we typically want methods to be public
        //these are instance methods--by definition they are not static

        //Constructor: metod that initializes a new nstance of this
        //access modifier: almost always public
        //return type: none (not void, nothing)
        //name: same as class (capitalization counts)
        //parameter list: varier
        //no-arguements version which sets everything to null or default values
        //all-arguments version which takes a parameter for each data type
        //we might use some number in between based on our design

            //shadow variables: I can gace a local variable/parameter with the same name as an instance variable
        public UserClass(string name, string password, string email, int age)
            {
            //common mistake, do not put the parameter first
            //instance variable always goes on the left
            this.name = name;
            this.password = password;
            this.email = email;
            this.age = age;
            this.paid = false; //all users start as upaid (false)
            this.regdate = DateTime.Now; //this does not need to be a parameter, needs to be now
        }
        //getters: public methods which let you read private instance data
        //(accessor)
        //access: public
        //return type: typicaclly void (possibly bool if i need to know this worked)
        //name: typically set + var name
        //parameter list: same type as im setting 
        public void SetName (string name)
        {
            this.name = name; //taking temp value and storing it in
        }

        public void SetPassword (string password)
        {
            this.password = password;
        }


       
        //return type: data type of the member you're trying to get
        //name: usually get + instance var name; for booleans, might be is.variable name
        //parameter list: usually empty
        public string GetName ()
        {
            return name;
        }

        public int GetAge ()
        {
            return age;
        }

        public DateTime GetRegDate()
        {
            return regdate;

        }

       user1.SetName("Humpty Hump");

        //setters and getter control private information

        //setters: public methods which let you modify/change private instances
        //(mutator)

        //helper methods: generally private methods which are called by methods in the class (to help accomplish something) for other instance methods
        public bool CheckPassword(string password)
        {
            return (this.password == password);
        }


    }
}
