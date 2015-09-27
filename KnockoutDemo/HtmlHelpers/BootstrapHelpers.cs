namespace KnockoutDemo.HtmlHelpers
{
    using System;
    using System.Linq.Expressions;
    using System.Web.Mvc;
    using System.Web.Mvc.Html;

    public static class BootstrapHelpers
    {
        /// <summary>
        /// Renders a bootstrap datetimepicker control and label.
        /// </summary>
        /// <typeparam name="TModel">The type of the model.</typeparam>
        /// <typeparam name="TProperty">The type of the property.</typeparam>
        /// <param name="htmlHelper">The HTML helper.</param>
        /// <param name="expression">The expression.</param>
        /// <param name="controlId">The div container identifier.</param>
        /// <param name="glyphClass">The glyph icon to use for the button.</param>
        /// <returns>An MvcHtmlString instance.</returns>
        public static MvcHtmlString DateTimePickerFor<TModel, TProperty>(
            this HtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TProperty>> expression,
            string controlId,
            string glyphClass)
        {
            var label = htmlHelper.LabelFor(expression, new { @class = "control-label" });
            var container = ElementBuilder.DivTag(controlId, "input-group date", string.Empty, string.Empty);
            var textBox = htmlHelper.TextBoxFor(expression, new { @class = "form-control" });
            var span = ElementBuilder.SpanTag(string.Empty, "input-group-addon", string.Empty, string.Empty);
            var glyph = ElementBuilder.SpanTag(string.Empty, string.Format("glyphicon {0}", glyphClass), string.Empty, string.Empty);

            span.InnerHtml = glyph.ToString();
            container.InnerHtml = textBox + span.ToString();

            return new MvcHtmlString(label + container.ToString(TagRenderMode.Normal));
        }
    }
}