namespace App
{
    using Our.Umbraco.Ditto;
    using System;

    /// <summary>
    /// Ditto processor that gets the data content from the current context.
    /// </summary>
    /// <remarks>
    /// This processor is useful when the content node you are mapping does not contain
    /// the data you want to map (e.g., when you want to map widgets with one content
    /// node, but populate those widgets with data from another content node).
    /// </remarks>
    [AttributeUsage(validOn: AttributeTargets.Property, AllowMultiple = true)]
    [DittoProcessorMetaData(ContextType = typeof(ContentDataContext))]
    public class DataContentAsAttribute : UmbracoPropertyAttribute
    {

        /// <summary>
        /// Returns the data content.
        /// </summary>
        /// <returns>
        /// The data content.
        /// </returns>
        public override object ProcessValue()
        {
            var casted = Context as ContentDataContext;
            return casted?.DataContent;
        }

    }

}