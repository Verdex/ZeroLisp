
using System.Collections.Generic;

namespace ZeroLisp.Data
{
    public class Symbol : Expr
    {
        public string Name { get; }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public override bool Equals(object o)
        {
            if( o is Symbol s )
            {
                return s.Name == Name;
            }
            else
            {
                return false;
            }
        }
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
