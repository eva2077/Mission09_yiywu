﻿using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Mission09_yiywu.Models.ViewModels;

namespace Mission09_yiywu.Infrastructure
{
    [HtmlTargetElement ("div", Attributes = "page-x")]
    public class PaginationTagHelper : TagHelper
    {
        //Dynamically create the page links for us 
        private IUrlHelperFactory uhf;
        public PaginationTagHelper(IUrlHelperFactory temp)
        {
            uhf = temp;
        }
        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext vc { get; set; }
        //different 
        public PageInfo pagex { get; set; }
        public string PageAction { get; set; }
        public override void Process(TagHelperContext thc, TagHelperOutput tho)
        {
            IUrlHelper uh = uhf.GetUrlHelper(vc);
            TagBuilder final = new TagBuilder("div");
            for (int i = 1; i < pagex.TotalPages; i++)
            {
                TagBuilder tb = new TagBuilder("a");
                tb.Attributes["href"] = uh.Action(PageAction, new { pageNum = i });
                tb.InnerHtml.Append(i.ToString());

                final.InnerHtml.AppendHtml(tb);


            }
            tho.Content.AppendHtml(final.InnerHtml);
        }
    }
}