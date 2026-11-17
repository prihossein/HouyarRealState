namespace HouyarRealState.Application.Wrappers
{
    public class Result<T>
    {
        public T Value { get; set; }
    }

    public class Result : Result<int> { }
}
