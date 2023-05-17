namespace Diary.Application.Exception;

public class DataNotFoundException : System.Exception
{
    public DataNotFoundException(int id) : base($"Data Not Found By Id={id}")
    {
    }
}