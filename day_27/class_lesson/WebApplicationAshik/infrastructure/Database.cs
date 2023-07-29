namespace infrastructure
{
    public static class Database // for database
    {
        public static List<User> GetUsers()
        {
            List<User> users = new List<User>(); //creating a new users (list) object
            User user1 = new User("Ashik", "Khulal", "Texas"); //
            User user2 = new User("Bishnu", "Sharma", "Texas");
            User user3 = new User("Bishnu", "Thapa", "Texas");

            users.Add(user1);
            users.Add(user2);
            users.Add(user3);

            return users;
        }
    }

    public class User
    {
        public User(string firstname, string lastname, string location)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Location = location;
        }
        //user properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public string UniversityName { get; set; }
        public string Location { get; set; }
        public string Country { get; set; }
        public int ZipCode { get; set; }
        public List<Car> Cars { get; set; }
    }

    // solid, interface, generics, abstract class, API(4 types)
}