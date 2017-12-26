namespace KeithKatas.December2017
{
    public class Hello
    {
        public static string Greet(string name)
        {
            return string.IsNullOrEmpty(name) ? null : $"hello {name}!";
        }
    }
}
