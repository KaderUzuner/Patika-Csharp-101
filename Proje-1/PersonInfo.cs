namespace Proje_1
{
    public class PersonInfo
    {
        private string name;
        private string surname;
        private long phoneNumber;

        public PersonInfo(string name, string surname, long phoneNumber)
        {
            this.name = name;
            this.surname = surname;
            this.phoneNumber = phoneNumber;
        }

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public long PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
    }
}
