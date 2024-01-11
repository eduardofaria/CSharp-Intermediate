namespace CSharp_Intermediate
{

        public class Person
        {
            //Attributes
            public string Name { get; set; }
            public string Username { get; set; }
            public DateTime Birthdate { get; private set; }

            //Constructor
            public Person(DateTime birthdate)
                {
                    Birthdate = birthdate;
                }
        
            public int Age
            {
                get
                {
                    var timeSpan = DateTime.Today - Birthdate;
                    var years = timeSpan.Days / 365;
                    return years;
                }

            }


            
        }


}
