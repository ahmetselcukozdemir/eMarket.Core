using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.AspNetCore.Routing;

namespace eMarket.Core.Web.UI.Helpers
{
    [HtmlTargetElement(Attributes = ControllersAttributeName)]
    [HtmlTargetElement(Attributes = ActionsAttributeName)]
    [HtmlTargetElement(Attributes = RouteAttributeName)]
    [HtmlTargetElement(Attributes = ClassAttributeName)]
    public class HtmlHelpers : TagHelper
    {
        private const string ActionsAttributeName = "asp-active-actions";
        private const string ControllersAttributeName = "asp-active-controllers";
        private const string ClassAttributeName = "asp-active-class";
        private const string RouteAttributeName = "asp-active-route";

        [HtmlAttributeName(ControllersAttributeName)]
        public string Controllers { get; set; }

        [HtmlAttributeName(ActionsAttributeName)]
        public string Actions { get; set; }

        [HtmlAttributeName(RouteAttributeName)]
        public string Route { get; set; }

        [HtmlAttributeName(ClassAttributeName)]
        public string Class { get; set; } = "active";

        [HtmlAttributeNotBound]
        [ViewContext]
        public ViewContext ViewContext { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            RouteValueDictionary routeValues = ViewContext.RouteData.Values;
            string currentAction = routeValues["action"].ToString();
            string currentController = routeValues["controller"].ToString();

            if (IsNullOrEmpty(Actions))
                Actions = currentAction;

            if (IsNullOrEmpty(Controllers))
                Controllers = currentController;

            string[] acceptedActions = Actions.Trim().Split(',').Distinct().ToArray();
            string[] acceptedControllers = Controllers.Trim().Split(',').Distinct().ToArray();


            if (acceptedActions.Contains(currentAction) && acceptedControllers.Contains(currentController))
            {
                SetAttribute(output, "class", Class);
            }

            base.Process(context, output);
        }

        private bool IsNullOrEmpty(string actions)
        {
            throw new NotImplementedException();
        }

        private void SetAttribute(TagHelperOutput output, string attributeName, string value, bool merge = true)
        {
            var v = value;
            TagHelperAttribute attribute;
            if (output.Attributes.TryGetAttribute(attributeName, out attribute))
            {
                if (merge)
                {
                    v = $"{attribute.Value} {value}";
                }
            }
            output.Attributes.SetAttribute(attributeName, v);
        }
    }
}
