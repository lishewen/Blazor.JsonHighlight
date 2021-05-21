using Microsoft.AspNetCore.Components;
using System.Text;
using System.Text.Json;

namespace Blazor.JsonHighlight
{
    public partial class JsonHighlight
    {
        [Parameter]
        public JsonElement Element { get; set; }
        [Parameter]
        public int Level { get; set; }

        private bool IsExpand { get; set; } = true;

        private string iconName
        {
            get
            {
                if (IsExpand) return "far fa-minus-square";
                return "far fa-plus-square";
            }
        }

        private string display
        {
            get
            {
                if (IsExpand) return "inline";
                return "none";
            }
        }

        private void OnExpandClick()
        {
            IsExpand = !IsExpand;
        }

        public MarkupString Space(int scount)
        {
            string str = string.Empty;
            for (int i = 0; i < scount; i++)
                str += "&nbsp;";
            return new MarkupString(str);
        }
        public MarkupString Tab(int tcount)
        {
            return Space(tcount * 4);
        }
    }
}