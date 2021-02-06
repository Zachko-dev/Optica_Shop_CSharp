using Optika_SvitZoryProgect.Data.Interfaces;
using Optika_SvitZoryProgect.Data.Models;
using System.Collections.Generic;

namespace Optika_SvitZoryProgect.Data.Mocks
{
    public class MockCategory : IGlasesCstegory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category {categoryName ="Sun Glases",desk="Sunshine Glases" },
                    new Category {categoryName ="Optic Glases",desk="Optical Glases" }


                };
            }
        }
    }
}
