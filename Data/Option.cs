namespace ZeroLisp.Data
{
    public static class Option
    {
        public static IOption<T> Some<T>(T item)
        {
            return new Some<T>(item);
        }
        public static IOption<T> None<T>()
        {
            return new None<T>();
        }
    }
    public interface IOption<T>
    {
        T Item { get; }
        bool HasItem { get; }
    }

    public class Some<T> : IOption<T>
    {
        public T Item { get; }
        public bool HasItem { get; } = true;
        public Some(T item)
        {
            Item = item;
        }
    }

    public class None<T> : IOption<T>
    {
        public T Item { get; }
        public bool HasItem { get; } = false;
        public None()
        {
        }
    }
}
