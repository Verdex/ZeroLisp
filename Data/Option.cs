namespace ZeroLisp.Data
{
    public static class Option
    {
        public static IOption<T> Some<T>(T item)
        {
            return new Some<T>(item);
        }
        public static IOption<T> None<T>(string details = "")
        {
            return new None<T>(details);
        }
    }
    public interface IOption<T>
    {
        T Item { get; }
        bool HasItem { get; }
        string Details { get; }
    }

    public class Some<T> : IOption<T>
    {
        public T Item { get; }
        public bool HasItem { get; } = true;
        public string Details { get; } = "";
        public Some(T item)
        {
            Item = item;
        }
    }

    public class None<T> : IOption<T>
    {
        public T Item { get; }
        public bool HasItem { get; } = false;
        public string Details { get; }
        public None(string details)
        {
            Details = details;
        }
    }
}
