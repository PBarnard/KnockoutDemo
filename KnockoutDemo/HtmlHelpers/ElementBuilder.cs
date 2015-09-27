namespace KnockoutDemo.HtmlHelpers
{
    using System.Web.Mvc;

    /// <summary>
    /// Defines shared functions for the custom HTML helper classes.
    /// </summary>
    public static class ElementBuilder
    {
        /// <summary>
        /// Builds an anchor tag with the specified destination.
        /// </summary>
        /// <param name="destination">The destination value.</param>
        /// <param name="cssClass">The CSS class.</param>
        /// <param name="id">The Id attribute value.</param>
        /// <returns>A TagBuilder instance.</returns>
        public static TagBuilder AnchorTag(string destination, string cssClass, string id)
        {
            var output = new TagBuilder("a");

            if (string.IsNullOrEmpty(id) == false)
            {
                output.Attributes.Add("id", id);
            }

            if (string.IsNullOrEmpty(destination) == false)
            {
                output.Attributes.Add("href", destination);
            }

            if (string.IsNullOrEmpty(cssClass) == false)
            {
                output.Attributes.Add("class", cssClass);
            }

            return output;
        }

        /// <summary>
        /// Buttons a button tag with the specified attribute values.
        /// </summary>
        /// <param name="type">The button type.</param>
        /// <param name="cssClass">The button CSS class.</param>
        /// <param name="text">The button's inner text.</param>
        /// <returns>A TagBuilder instance.</returns>
        public static TagBuilder ButtonTag(string type, string cssClass, string text)
        {
            var output = new TagBuilder("button");

            if (string.IsNullOrEmpty(type) == false)
            {
                output.Attributes.Add("type", type);
            }

            if (string.IsNullOrEmpty(cssClass) == false)
            {
                output.Attributes.Add("class", cssClass);
            }

            output.SetInnerText(text);

            return output;
        }

        /// <summary>
        /// Builds a DIV tag with the specified attribute values.
        /// </summary>
        /// <param name="id">The DIV id..</param>
        /// <param name="cssClass">The DIV CSS class.</param>
        /// <param name="innerText">The inner text for the DIV.</param>
        /// <param name="style">The DIV inline style.</param>
        /// <returns>A TagBuilder instance.</returns>
        public static TagBuilder DivTag(string id, string cssClass, string innerText, string style)
        {
            var output = new TagBuilder("div");

            if (string.IsNullOrEmpty(id) == false)
            {
                output.Attributes.Add("id", id);
            }

            if (string.IsNullOrEmpty(cssClass) == false)
            {
                output.AddCssClass(cssClass);
            }

            if (string.IsNullOrEmpty(style) == false)
            {
                output.Attributes.Add("style", style);
            }

            output.SetInnerText(innerText);

            return output;
        }

        /// <summary>
        /// Builds a tag of the specified type with the specified id, style and inner text.
        /// </summary>
        /// <param name="tag">The tag to build.</param>
        /// <param name="id">The tag id.</param>
        /// <param name="style">The tag style.</param>
        /// <param name="innerText">The tag inner text.</param>
        /// <param name="cssClass">The CSS class.</param>
        /// <returns>A TagBuilder instance.</returns>
        public static TagBuilder GenericTag(string tag, string id = "", string style = "", string innerText = "", string cssClass = "")
        {
            var output = new TagBuilder(tag);

            if (string.IsNullOrEmpty(id) == false)
            {
                output.Attributes.Add("id", id);
            }

            if (string.IsNullOrEmpty(style) == false)
            {
                output.Attributes.Add("style", style);
            }

            if (string.IsNullOrEmpty(cssClass) == false)
            {
                output.Attributes.Add("class", cssClass);
            }

            output.SetInnerText(innerText);

            return output;
        }

        /// <summary>
        /// Builds an image tag with the specified attribute values.
        /// </summary>
        /// <param name="source">The image source.</param>
        /// <param name="id">The image id.</param>
        /// <param name="altText">The alt text.</param>
        /// <param name="style">The image style.</param>
        /// <param name="cssClass">The image CSS class.</param>
        /// <param name="click">The script to execute when the user clicks the image.</param>
        /// <returns>A TagBuilder instance.</returns>
        public static TagBuilder ImageTag(string source, string id = "", string altText = "", string style = "", string cssClass = "", string click = "")
        {
            var image = new TagBuilder("image");

            image.Attributes.Add("id", id);
            image.Attributes.Add("src", source);
            image.Attributes.Add("alt", altText);
            image.Attributes.Add("style", style);
            image.Attributes.Add("class", cssClass);
            image.Attributes.Add("onclick", click);

            return image;
        }

        /// <summary>
        /// Builds a label tag with the specified attribute values.
        /// </summary>
        /// <param name="id">The label id.</param>
        /// <param name="cssClass">The label CSS class.</param>
        /// <param name="innerText">The inner text for the label.</param>
        /// <returns>A TagBuilder instance.</returns>
        public static TagBuilder LabelTag(string id, string cssClass, string innerText)
        {
            var output = new TagBuilder("label");

            if (string.IsNullOrEmpty(id) == false)
            {
                output.Attributes.Add("id", id);
            }

            if (string.IsNullOrEmpty(cssClass) == false)
            {
                output.AddCssClass(cssClass);
            }

            output.SetInnerText(innerText);

            return output;
        }

        /// <summary>
        /// Builds a span tag with the specified attribute values.
        /// </summary>
        /// <param name="id">The span element id.</param>
        /// <param name="cssClass">The span CSS class.</param>
        /// <param name="style">The style.</param>
        /// <param name="innerText">The span's inner text.</param>
        /// <returns>A TagBuilder instance.</returns>
        public static TagBuilder SpanTag(string id, string cssClass, string style, string innerText)
        {
            var span = new TagBuilder("span");

            span.Attributes.Add("id", id);
            span.Attributes.Add("class", cssClass);
            span.Attributes.Add("style", style);
            span.SetInnerText(innerText);

            return span;
        }

        /// <summary>
        /// Builds a paragraph tag with the specified inner text.
        /// </summary>
        /// <param name="text">The inner text.</param>
        /// <param name="cssClass">The CSS class name.</param>
        /// <param name="id">The paragraph id.</param>
        /// <returns>A TagBuilder instance.</returns>
        public static TagBuilder ParagraphTag(string text, string cssClass, string id)
        {
            var output = new TagBuilder("p");

            output.Attributes.Add("id", id);
            output.Attributes.Add("class", cssClass);
            output.SetInnerText(text);

            return output;
        }

        /// <summary>
        /// Builds a JavaScript tag containing the specified code.
        /// </summary>
        /// <param name="javascript">The JavaScript code.</param>
        /// <returns>A TagBuilder instance.</returns>
        public static TagBuilder ScriptTag(string javascript)
        {
            var output = new TagBuilder("script");

            output.Attributes.Add("type", @"text/javascript");

            output.SetInnerText(javascript);

            return output;
        }
    }
}