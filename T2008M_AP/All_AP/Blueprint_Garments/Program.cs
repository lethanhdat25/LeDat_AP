using System;

namespace T2008M_AP.All_AP.Blueprint_Garments
{
    public class Program
    {
        public static void Main(string[] args)
        {
            TrendSetting trendSetting = new TrendSetting();
            Areas area1 = new Areas();
            area1.name = "area1";
            area1.sale = 40;
            Areas area2 = new Areas();
            area2.name = "area2";
            area2.sale = 20;
            Areas area3 = new Areas();
            area3.name = "area3";
            area3.sale = 70;
            Areas area4 = new Areas();
            area4.name = "area4";
            area4.sale = 60;
            Areas area5 = new Areas();
            area5.name = "area5";
            area5.sale = 80;
            trendSetting.SaleArea.Add(area1);
            trendSetting.SaleArea.Add(area2);
            trendSetting.SaleArea.Add(area3);
            trendSetting.SaleArea.Add(area4);
            trendSetting.SaleArea.Add(area5);
            trendSetting.Sales();
            trendSetting.ShowSales();
        }
    }
}