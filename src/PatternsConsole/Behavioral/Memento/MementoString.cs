using System.Collections.Generic;

namespace PatternsConsole.Behavioral.Memento
{
    public class MementoSpaceString
    {
        private MementoStringSpaceState _state;
        private string _value;

        public string Value
        {
            get { return _value; }
            set
            {
                _state = new MementoStringSpaceState();

                var tmp = "";

                for (var i = 0; i < value.Length; i++)
                {
                    var cur = value[i];

                    if(cur==' ')
                        _state.SpacePositions.Add(i);
                    else
                        tmp += cur;
                }

                _value = tmp;
            }
        }

        public void SetMemento(MementoStringSpaceState memento)
        {
            _state = memento;
        }

        public MementoStringSpaceState CreateMemento()
        {
            return new MementoStringSpaceState
            {
                SpacePositions = new List<int>(_state.SpacePositions)
            };
        }

        public override string ToString()
        {
            var str = Value;
            foreach (var spacePosition in _state.SpacePositions)
            {
                str = str.Insert(spacePosition, " ");
            }
            return str;
        }
    }
}