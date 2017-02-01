namespace App
{
    using Our.Umbraco.Ditto;
    using Umbraco.Core.Models;

    /// <summary>
    /// Context for a content node.
    /// </summary>
    public class ContentDataContext : DittoProcessorContext
    {
        public IPublishedContent DataContent { get; set; }
    }

}