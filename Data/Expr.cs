
using System.Collections.Generic;

namespace ZeroLisp.Data
{
    public class Symbol : Expr
    {
        public string Name { get; }
    }

    public class Number : Expr
    {
        public int Value { get; set; }
    }

    public interface IFunction : Expr
    {
        IReadOnlyList<Expr> Call( IDictionary<Symbol, Expr> global, 
                                  IDictionary<Symbol, Expr> local, 
                                  IReadOnlyList<Expr> input );
    }

    public interface IMacro : Expr
    {
    }

    public interface Expr
    {
    }
}
