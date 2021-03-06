using Microsoft.AspNetCore.Razor.TagHelpers;

namespace DDDSouthWest.Website.Components
{
    public class PageBannerTagHelper : TagHelper
    {
        public string Title { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagMode = TagMode.StartTagAndEndTag;
            string panel = $@"
            <div class=""page-banner"">
                <div class=""grid-container"">
                    <div class=""grid-100"">
                        <div class=""page-banner__content"">
                            <span class=""page-banner--title"">{Title}</span>
                        </div>
                    </div>
                </div>
            </div>";

            output.Content.SetHtmlContent(panel);
        }
    }
}