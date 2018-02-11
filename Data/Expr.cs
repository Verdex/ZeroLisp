
namespace ZeroLisp.Data
{
    public class Number : Expr
    {
        public int Value { get; set; }
    }

    public interface Expr
    {
    }
}
