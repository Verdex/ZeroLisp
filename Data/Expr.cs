
namespace ZeroLisp.Data
{
    public class Number : Expr
    {
        public int Value { get; set; }
    }

    public inteface IFunction : Expr
    {
        Values Call( IDictionary<Symbol, Expr> 
    }

    public interface IMacro : Expr
    {
    }

    public interface Expr
    {
    }
}
