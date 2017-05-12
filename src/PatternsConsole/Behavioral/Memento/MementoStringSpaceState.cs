using System.Collections.Generic;

namespace PatternsConsole.Behavioral.Memento
{
    public class MementoStringSpaceState
    {
        public List<int> SpacePositions { get; set; }

        public MementoStringSpaceState()
        {
            SpacePositions = new List<int>();
        }
    }
}