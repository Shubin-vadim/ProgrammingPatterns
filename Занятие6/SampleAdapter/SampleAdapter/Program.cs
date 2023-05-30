using SampleAdapter.Adapters;
using SampleAdapter.HomeCats;
using SampleAdapter.WildCats;
using System;

namespace SampleAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            IHomeCat vaska = new YardCat();
            vaska.Name = "Васька";
            IHomeCat wagner = new PedigreedCat();
            wagner.Name = "Вагнер";

            CatInfoPrinter.PrintCatInfo(vaska);
            CatInfoPrinter.PrintCatInfo(wagner);

            IWildCat amurTiger = new AmurTiger();
            CatInfoPrinter.PrintCatInfo(new HomeCatAdapter(amurTiger));
        }
    }
}