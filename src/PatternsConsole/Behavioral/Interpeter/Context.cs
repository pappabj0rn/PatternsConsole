using System.Collections.Generic;

namespace PatternsConsole.Behavioral.Interpeter
{
    public class Context
    {
        private readonly Dictionary<string, bool> _variables;

        public Context()
        {
            _variables = new Dictionary<string, bool>();
        }

        public bool Lookup(string name)
        {
            return _variables[name];
        }

        public void Assign(VariableExpression var, bool value)
        {
            if(!_variables.ContainsKey(var.Name))
                _variables.Add(var.Name,value);
            else
                _variables[var.Name] = value;
        }
    }
}