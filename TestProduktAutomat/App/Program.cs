

using TestProduktAutomat.Domain.Entities;
using TestProduktAutomat.UI;

namespace TestProduktAutomat.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppScreen appScreen = new AppScreen();
            appScreen.InitializeDataDrinks();
            appScreen.InitializeDataKläder();
            appScreen.InitializeDataMat();
            appScreen.InitializeDataMonye();
            appScreen.Run();

        }
    }
}