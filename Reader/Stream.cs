
using ZeroLisp.Data;
using static ZeroLisp.Data.Option;

namespace ZeroLisp.Reader
{
    public interface IStream
    {
        bool Active { get; }
        IOption<char> Peak();
        IOption<char> Read();
    }

    public class BasicStream : IStream
    {
        private readonly string _input;
        private int _index;
        public BasicStream( string input )
        {
            _input = input;
            _index = 0;
        }

        public bool Active { get => _index < _input.Length; }

        public IOption<char> Peak()
        {
            if ( _index < _input.Length )
            {
                return Some(_input[_index]);
            }
            else
            {
                return None<char>();
            }
        }

        public IOption<char> Read()
        {
            if ( _index < _input.Length )
            {
                var i = _index;
                _index++;
                return Some(_input[i]);
            }
            else
            {
                return None<char>();
            }
        }
    }
}
