namespace App
{
    using Our.Umbraco.Ditto;
    using Umbraco.Core.Models;
    public class MappingHelper
    {
        public static CommonPage MapCommonPage(IPublishedContent currentPage)
        {
            var processorContexts = new[]
            {
                new ContentDataContext()
                {
                    DataContent = currentPage
                }
            };
            var page = currentPage.As<CommonPage>(processorContexts: processorContexts);
            return page;
        }
    }
}