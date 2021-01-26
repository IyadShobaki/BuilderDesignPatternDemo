using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorUI.Models
{
    public class HtmlBuilder
    {
        private readonly string _rootName;
        HtmlElement root = new HtmlElement();

        public HtmlBuilder(string rootName, string rootText = " ")
        {
            _rootName = rootName;
            root.Name = rootName;
            root.Text = rootText;
        }
        //public void AddChild(string childName,string childText)
        public HtmlBuilder AddChild(string childName,string childText) // using fluent interface
        {
            var e = new HtmlElement(childName, childText);
            root.Elements.Add(e);
            return this;
        }

        public override string ToString()
        {
            return root.ToString();
        }

        public void Clear()
        {
            root = new HtmlElement { Name = _rootName };
        }
    }
}
