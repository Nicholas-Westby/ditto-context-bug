namespace App
{
    using Our.Umbraco.Ditto;
    public class OverviewWidget : IWidget
    {

        /// <summary>
        /// Gets the overview from the current page rather than from the current widget.
        /// </summary>
        [DataContentAs]
        [UmbracoProperty]
        public string Overview { get; set; }

    }
}