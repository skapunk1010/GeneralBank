using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeneralBank.Clases
{
    class ComboBoxItem
    {
        public string Name { get; set; }
        public int Value { get; set; }

        public ComboBoxItem(string name, int value)
        {
            Name = name;
            Value = value;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
