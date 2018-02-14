
using System.Linq;
using System.Collections.Generic;

using static ZeroLisp.Data.Option;

namespace ZeroLisp.Data
{
    public class Scope
    {
        private readonly Stack<Dictionary<Symbol, Expr>> _scope
            = new Stack<Dictionary<Symbol, Expr>>();

        public void StartLocal()
        {
            _scope.Push(new Dictionary<Symbol, Expr>());
        }

        public void EndLocal()
        {
            _scope.Pop();
        }

        public IOption<Expr> GetVariable( Symbol name )
        {
            var local = _scope.Peek();

            if( local.ContainsKey( name ) )
            {
                return Some( local[name] );
            }

            foreach( var s in _scope )
            {
                if( s.ContainsKey( name ) )
                {
                    return Some( s[name] );
                }
            }

            return None<Expr>();
        }
    }
}
