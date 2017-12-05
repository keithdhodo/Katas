namespace Kata.December2017
{
    public class FullName
    {
        private string firstName;
        private string lastName;
        public string GetFullName
        {
            get
            {
                return $"{firstName} {lastName}".Trim();
            }
        }

        public FullName(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }
}
