namespace WebApplicationAshik.Day_28
{
    public interface IFile 
    {
        string ReadFile();  // defining them
        void WriteFile(string text); // signatures means return type & params combined
    }


    public class File : IFile 
    {
        public string ReadFile()
        {
            //this is an implementation
            throw new NotImplementedException();
        }

        public void WriteFile(string text)
        {
            throw new NotImplementedException();
        }
    }

    public class Addition
    {
        public int Add(int num1, int num2) 
        { 
            return num1+ num2;
        }

        public string Add(string str1, string str2)
        {
            return (str1 + str2);
        }


    }

    public class Addition<T>
    {
        public T Add(T num1, T num2)
        {
            T sum = (dynamic) num1 + (dynamic) num2;

            return sum;
        }
    }


}
