namespace App
{
    using Our.Umbraco.Ditto;
    using Rhythm.Umbraco.Ditto.Archetype;
    using System.Collections.Generic;
    public class CommonPage
    {

        /// <summary>
        /// The main content for the page (a collection of widgets).
        /// </summary>
        [UmbracoProperty]
        [DittoMixedArchetype]
        public IEnumerable<IWidget> MainContent { get; set; }

    }
}