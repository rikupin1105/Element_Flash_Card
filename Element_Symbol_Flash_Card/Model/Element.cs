using System;
using System.Collections.Generic;
using System.Text;

namespace Element_Symbol_Flash_Card.Model
{
    internal class Element
    {
        public Element(int number, string symbol, string name)
        {
            Number=number;
            Symbol=symbol;
            Name=name;
        }

        public int Number { get; set; }
        public string Symbol { get; set; }
        public string Name { get; set; }
    }
}
