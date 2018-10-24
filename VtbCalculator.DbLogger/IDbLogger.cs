namespace VtbCalculator.DbLogger
{
    public interface IDbLogger
    {
        void Log(string source, string method, string message);
    }
}