
using ZeroLisp.Data;

namespace ZeroLisp.Reader
{
    public interface IReaderMacro
    {
        IOption<Expr> Process( IStream input, char target );
    }
}
