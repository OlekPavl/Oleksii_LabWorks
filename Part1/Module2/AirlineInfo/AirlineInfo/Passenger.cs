using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineInfo
{
    class Passenger : IPassenger
    {
        public string[] arrayPassenger = new string[8];
        public int? FlightNumber { get; set; }
        FlightInformation flight;

        public Passenger(FlightInformation flight)
        {
            this.flight = flight;
            FlightNumber = flight.FlightNumber;
            arrayPassenger[0] = FlightNumber.ToString();
            PassengerAutomaticalInitializer();
        }

        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Nationality { get; set; }
        public int? Passport { get; set; }
        public String DateOfBirthday { get; set; }
        public SexType Sex { get; set; }
        public FlightClass Class { get; set; }
        public void PassengerAutomaticalInitializer()
        {
            Random random = new Random();

            string[] maleFirstNamesArray = new string[] { "Wade", "Dave", "Seth", "Ivan", "Riley", "Gilbert", "Jorge", "Dan", "Brian", "Roberto", "Ramon", "Miles", "Liam", "Nathaniel", "Ethan", "Lewis", "Milton", "Claude", "Joshua", "Glen", "Harvey", "Blake", "Antonio", "Connor", "Julian", "Aidan", "Harold", "Conner", "Peter", "Hunter", "Eli", "Alberto", "Carlos", "Shane", "Aaron", "Marlin", "Paul", "Ricardo", "Hector", "Alexis", "Adrian", "Kingston", "Douglas", "Gerald", "Joey", "Johnny", "Charlie", "Scott", "Martin", "Tristin", "Troy", "Tommy", "Rick", "Victor", "Jessie", "Neil", "Ted", "Nick", "Wiley", "Morris", "Clark", "Stuart", "Orlando", "Keith", "Marion", "Marshall", "Noel", "Everett", "Romeo", "Sebastian", "Stefan", "Robin", "Clarence", "Sandy", "Ernest", "Samuel", "Benjamin", "Luka", "Fred", "Albert", "Greyson", "Terry", "Cedric", "Joe", "Paul", "George", "Bruce", "Christopher", "Mark", "Ron", "Craig", "Philip", "Jimmy", "Arthur", "Jaime", "Perry", "Harold", "Jerry", "Shawn", "Walter" };
            string[] femaleFirstNamesArray = new string[] { "Daisy", "Deborah", "Isabel", "Stella", "Debra", "Beverly", "Vera", "Angela", "Lucy", "Lauren", "Janet", "Loretta", "Tracey", "Beatrice", "Sabrina", "Melody", "Chrysta", "Christina", "Vicki", "Molly", "Alison", "Miranda", "Stephanie", "Leona", "Katrina", "Mila", "Teresa", "Gabriela", "Ashley", "Nicole", "Valentina", "Rose", "Juliana", "Alice", "Kathie", "Gloria", "Luna", "Phoebe", "Angelique", "Graciela", "Gemma", "Katelynn", "Danna", "Luisa", "Julie", "Olive", "Carolina", "Harmony", "Hanna", "Anabelle", "Francesca", "Whitney", "Skyla", "Nathalie", "Sophie", "Hannah", "Silvia", "Sophia", "Della", "Myra", "Blanca", "Bethany", "Robyn", "Traci", "Desiree", "Laverne", "Patricia", "Alberta", "Lynda", "Cara", "Brandi", "Janessa", "Claudia", "Rosa", "Sandra", "Eunice", "Kayla", "Kathryn", "Rosie", "Monique", "Maggie", "Hope", "Alexia", "Lucille", "Odessa", "Amanda", "Kimberly", "Blanche", "Tyra", "Helena", "Kayleigh", "Lucia", "Janine", "Maribel", "Camille", "Alisa", "Vivian", "Lesley", "Rachelle", "Kianna" };
            int state = random.Next(0, 2);
            if (state == 1)
            {
                FirstName = maleFirstNamesArray[random.Next(0, 100)];
                arrayPassenger[1] = FirstName.ToString();
            }
            else
            {
                FirstName = femaleFirstNamesArray[random.Next(0, 100)];
                arrayPassenger[1] = FirstName.ToString();
            }

            string[] secondNamesArray = new string[] { "Williams", "Harris", "Thomas", "Robinson", "Walker", "Scott", "Nelson", "Mitchell", "Morgan", "Cooper", "Howard", "Davis", "Miller", "Martin", "Smith", "Anderson", "White", "Perry", "Clark", "Richards", "Wheeler", "Warburton", "Stanley", "Holland", "Terry", "Shelton", "Miles", "Lucas", "Fletcher", "Parks", "Norris", "Guzman", "Daniel", "Newton", "Potter", "Francis", "Erickson", "Norman", "Moody", "Lindsey", "Gross", "Sherman", "Simon", "Jones", "Brown", "Garcia", "Rodriguez", "Lee", "Young", "Hall", "Allen", "Lopez", "Green", "Gonzalez", "Baker", "Adams", "Perez", "Campbell", "Shaw", "Gordon", "Burns", "Warren", "Long", "Mcdonald", "Gibson", "Ellis", "Fisher", "Reynolds", "Jordan", "Hamilton", "Ford", "Graham", "Griffin", "Russell", "Foster", "Butler", "Simmons", "Flores", "Bennett", "Sanders", "Hughes", "Bryant", "Patterson", "Matthews", "Jenkins", "Watkins", "Ward", "Murphy", "Bailey", "Bell", "Cox", "Martinez", "Evans", "Rivera", "Peterson", "Gomez", "Murray", "Tucker", "Hicks", "Crawford", "Mason", "Rice", "Black", "Knight", "Arnold", "Wagner", "Mosby", "Ramirez", "Coleman", "Powell", "Singh", "Patel", "Wood", "Wright", "Stephens", "Eriksen", "Cook", "Roberts", "Holmes", "Kennedy", "Saunders", "Fisher", "Hunter", "Reid", "Stewart", "Carter", "Phillips", "Spencer", "Howell", "Alvarez", "Little", "Jacobs", "Foreman", "Knowles", "Meadows", "Richmond", "Valentine", "Dudley", "Woodward", "Weasley", "Livingston", "Sheppard", "Kimmel", "Noble", "Leach", "Gentry", "Lara", "Pace", "Trujillo", "Grant" };
            SecondName = secondNamesArray[random.Next(0, 150)];
            arrayPassenger[2] = SecondName.ToString();

            string[] nationalityArray = new string[] { "Afghan", "Albanian", "Algerian", "Argentine", "Argentinian", "Australian", "Austrian", "Bangladeshi", "Belgian", "Bolivian", "Batswana", "Brazilian", "Bulgarian", "Cambodian", "Cameroonian", "Canadian", "Chilean", "Chinese", "Colombian", "Costa Rican", "Croatian", "Cuban", "Czech", "Danish", "Dominican", "Ecuadorian", "Egyptian", "Salvadorian", "English", "Estonian", "Ethiopian", "Fijian", "Finnish", "French", "German", "Ghanaian", "Greek", "Guatemalan", "Haitian", "Honduran", "Hungarian", "Icelandic", "Indian", "Indonesian", "Iranian", "Iraqi", "Irish", "Israeli", "Italian", "Jamaican", "Japanese", "Jordanian", "Kenyan", "Kuwaiti", "Lao", "Latvian", "Lebanese", "Libyan", "Lithuanian", "Malagasy", "Malaysian", "Malian", "Maltese", "Mexican", "Mongolian", "Moroccan", "Mozambican", "Namibian", "Nepalese", "Dutch", "New Zealand", "Nicaraguan", "Nigerian", "Norwegian", "Pakistani", "Panamanian", "Paraguayan", "Peruvian", "Philippine", "Polish", "Portuguese", "Romanian", "Russian", "Saudi", "Scottish", "Senegalese", "Serbian", "Singaporean", "Slovak", "South African", "Korean", "Spanish", "Sri Lankan", "Sudanese", "Swedish", "Swiss", "Syrian", "Taiwanese", "Tajikistani", "Thai", "Tongan", "Tunisian", "Turkish", "Ukrainian", "Emirati", "British", "American", "Uruguayan", "Venezuelan", "Vietnamese", "Welsh", "Zambian", "Zimbabwean" };
            Nationality = nationalityArray[random.Next(0, 113)];
            arrayPassenger[3] = Nationality.ToString();

            Passport = null;
            arrayPassenger[4] = Passport.ToString();
            
            DateOfBirthday = (DateTime.Now - TimeSpan.FromDays(random.Next(23000))).ToShortDateString();
            arrayPassenger[5] = DateOfBirthday;


            if (state == 1)
            {
                Sex = SexType.Male;
                arrayPassenger[6] = Sex.ToString();
            }
            else
            {
                Sex = SexType.Female;
                arrayPassenger[6] = Sex.ToString();
            }

            int flightClass = random.Next(0, 2);
            if (flightClass == 1)
            {
                Class = FlightClass.Business;
                arrayPassenger[7] = Class.ToString();
            }
            else
            {
                Class = FlightClass.Economy;
                arrayPassenger[7] = Class.ToString();
            }
        }
    }
}
