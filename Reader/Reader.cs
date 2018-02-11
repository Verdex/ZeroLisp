
using System.Collections.Generic;

using ZeroLisp.Data;

using static ZeroLisp.Data.Option;

namespace ZeroLisp.Reader
{
    public static class Reader
    {
        public static IOption<Expr> Read( IStream input, IDictionary<char, IReaderMacro> readerMacros )
        {
            var oc = input.Read();

            char c = '\0'; 
            switch( oc )
            {
                case Some<char> s:
                    c = s.Item;
                    break;
                case None<char> n:
                    return None<Expr>( "Reader encountered empty file stream" );
            }

            if ( readerMacros.ContainsKey( c ) )
            {
                return readerMacros[c].Process( input, c );
            }
            else
            {
                return None<Expr>( $"Reader encountered unknown character {c}" );
            }
        }
    }
}
