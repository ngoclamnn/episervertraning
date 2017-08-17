using System;
using EPiServer.Core;
using episerverBeginner.Models.Pages;

namespace episerverBeginner.Models.ViewModels
{
    public class PageViewModel<T> : IPageViewModel<T> where T : PageDataBase
    {
        public PageViewModel(T currentPage)
        {
            CurrentPage = currentPage;
        }

        public T CurrentPage { get; private set; }
        public LayoutModel Layout { get; set; }
        public IContent Section { get; set; }
    }

    public static class PageViewModel
    {
        /// <summary>
        /// Returns a PageViewModel of type <typeparam name="T"/>.
        /// </summary>
        /// <remarks>
        /// Convenience method for creating PageViewModels without having to specify the type as methods can use type inference while constructors cannot.
        /// </remarks>
        public static PageViewModel<T> Create<T>(T page) where T : PageDataBase
        {
            return new PageViewModel<T>(page);
        }
    }
}
