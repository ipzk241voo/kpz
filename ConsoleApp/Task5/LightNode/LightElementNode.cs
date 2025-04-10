using System.Text;

namespace ConsoleApp.Task5.LightNode
{
    internal class LightElementNode: LightNode
    {
        public string TagName { get; set; }
        public string DisplayType { get; set; }
        public string ClosingType { get; set; }
        public List<string> CssClasses { get; set; }
        public List<LightNode> Children { get; set; }

        public LightElementNode(string tagName, string displayType, string closingType, List<string> cssClasses = null)
        {
            TagName = tagName;
            DisplayType = displayType;
            ClosingType = closingType;
            CssClasses = cssClasses ?? new List<string>();
            Children = new List<LightNode>();
        }

        public void AddChild(LightNode child)
        {
            Children.Add(child);
        }

        public override string OuterHTML()
        {
            string classes = CssClasses.Count > 0 ? $" class=\"{string.Join(" ", CssClasses)}\"" : "";

            if (ClosingType == "single")
            {
                return $"<{TagName}{classes}/>";
            }
            else
            {
                return $"<{TagName}{classes}>{InnerHTML()}</{TagName}>";
            }
        }

        public override string InnerHTML()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var child in Children)
            {
                sb.Append(child.OuterHTML());
            }
            return sb.ToString();
        }

        public int ChildCount()
        {
            return Children.Count;
        }
    }
}
