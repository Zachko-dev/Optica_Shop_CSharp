using Optika_SvitZoryProgect.Data.Interfaces;
using Optika_SvitZoryProgect.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Optika_SvitZoryProgect.Data.Mocks
{
    public class MockGlases : IAllGlases
    {
        private readonly IGlasesCstegory _catagoryGlases = new MockCategory();

        public IEnumerable<Glases> Glasess
        {
            get {
                return new List<Glases>
                {
                    new Glases{
                        name ="Vito Rossi",
                        shortDesk ="Optic glases",
                        longDesk ="Зручні у використанні  та стильний дезайн",
                        img ="https://opt-725745.ssl.1c-bitrix-cdn.ru/upload/products/compiled/images/Soncezahisni_okuljari/GUCCI/c16b77c2-1f8b-445d-b736-8c75903efc56.jpg?158975610120785",
                        prise =1250,
                        isFavorite =true,
                        avaiLable =true,
                        Category =_catagoryGlases.AllCategories.First() },

                    new Glases{
                        name ="Vito Rossi Rose",
                        shortDesk ="sun glases",
                        longDesk ="Зручні у використанні  та стильний дезайн",
                        img ="https://opt-725745.ssl.1c-bitrix-cdn.ru/upload/products/compiled/images/Soncezahisni_okuljari/GUCCI/e456cf98-9863-11e7-aabd-0050569c7e77.jpg?158975116221785",
                        prise =1250,
                        isFavorite =true,
                        avaiLable =true,
                        Category =_catagoryGlases.AllCategories.First()},

                    new Glases{
                        name ="Gucci ",
                        shortDesk ="    Sun glases ",
                        longDesk ="Зручні у використанні  та стильний дезайн",
                        img ="https://opt-725745.ssl.1c-bitrix-cdn.ru/upload/products/compiled/images/Soncezahisni_okuljari/GUCCI/c0e54ed4-9866-11e7-aabd-0050569c7e77.jpg?159369292221349",
                        prise =2300,
                        isFavorite =true,
                        avaiLable =true,
                        Category =_catagoryGlases.AllCategories.First()},

                    new Glases{
                        name ="Montal",
                        shortDesk ="OPtic glases",
                        longDesk ="Зручні у використанні  та стильний дезайн",
                        img ="https://opt-725745.ssl.1c-bitrix-cdn.ru/upload/products/compiled/images/Soncezahisni_okuljari/GUCCI/c16b77c2-1f8b-445d-b736-8c75903efc56.jpg?158975610120785",
                        prise =1250,
                        isFavorite =true,
                        avaiLable =true,
                        Category =_catagoryGlases.AllCategories.First()},

                    new Glases{
                        name ="Ray Ban",
                        shortDesk ="Sun glases ",
                        longDesk ="Зручні у використанні  та стильний дезайн",
                        img ="https://opt-725745.ssl.1c-bitrix-cdn.ru/upload/products/compiled/images/Soncezahisni_okuljari/GUCCI/a5b7a0d4-12a6-41ed-a093-f8bd1fa64cb7.jpg?158975420017950",
                        prise =1500,
                        isFavorite =true,
                        avaiLable =true,
                        Category =_catagoryGlases.AllCategories.First()},

                    new Glases{
                        name ="Ray ban Duo",
                        shortDesk ="Sun glases",
                        longDesk ="Зручні у використанні  та стильний дезайн",
                        img ="https://opt-725745.ssl.1c-bitrix-cdn.ru/upload/products/compiled/images/Soncezahisni_okuljari/GUCCI/579d441a-0d96-44e4-b55e-c282ed6d033a.jpg?158975420417319",
                        prise =1300,
                        isFavorite =true,
                        avaiLable =true,
                        Category =_catagoryGlases.AllCategories.First()},
                };
            } 
        }
        public IEnumerable<Glases> getFavGlasess { get ; set ; }

        public Glases getObjectGlaes(int glasesID)
        {
            throw new NotImplementedException();
        }
    }
}
