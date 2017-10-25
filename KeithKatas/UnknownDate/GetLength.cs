using System.Dynamic;

namespace Kata
{
    public class GetLength
    {
        public int GetObjectLength(dynamic inputObject)
        {
            if (inputObject is ExpandoObject)
            {
                return (int)inputObject.Length;
            }
            else
            {
                return (int)inputObject.GetType().GetProperty("Length").GetValue(inputObject, null);
            }
        }
    }
}
