
using Xamarin.Forms;
using System;

namespace RPAT
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

       public void OnCalculateClicked(object sender, EventArgs args)
        {
            var RentIncomeVal = (Convert.ToDecimal(PerUnitRentPerMonth.Text) *  Convert.ToInt16(NumOfUnits.Text) * 12);
            decimal TotalExpensesVal;
            decimal NetIncomeVal;

            var AnnualTaxesVal = Convert.ToDecimal(AnnualTaxes.Text);
            var AnnualInsuranceVal = Convert.ToDecimal(AnnualInsurance.Text);
            var MonthlyElectricVal = Convert.ToDecimal(MonthlyElectric.Text) * 12;
            var MonthlyGasVal = Convert.ToDecimal(MonthlyGas.Text) * 12;
            var MonthlyWaterVal = Convert.ToDecimal(MonthlyWater.Text) * 12;
            var MonthlyMaintenanceVal = Convert.ToDecimal(MonthlyMaintenance.Text) * 12;
            var PropertyMgmtPercentVal = Convert.ToDecimal(PropertyMgmtPercent.Text)* RentIncomeVal / 100;
            var VacanyLossPercentVal = Convert.ToDecimal(VacanyLossPercent.Text) * RentIncomeVal / 100;
            TotalExpensesVal = AnnualTaxesVal + AnnualInsuranceVal + MonthlyElectricVal + MonthlyGasVal + MonthlyWaterVal + MonthlyMaintenanceVal + PropertyMgmtPercentVal + VacanyLossPercentVal;
            TotalIncome.Text = RentIncomeVal.ToString();
            TotalExpenses.Text = TotalExpensesVal.ToString();
            NetIncomeVal = RentIncomeVal - TotalExpensesVal;
            NetIncome.Text = NetIncomeVal.ToString();
 

            decimal totalDownPaymentVal = Convert.ToDecimal(ClosingCost.Text) + Convert.ToDecimal(DownPayment.Text);

            LeveragedNetROI.Text = (totalDownPaymentVal / NetIncomeVal).ToString("#.##");
            CashOnCashReturn.Text = (NetIncomeVal / RentIncomeVal).ToString("#.##");
            //AnnualPreTaxCashFlow

        }
        public void OnClearClicked(object sender, EventArgs args)
        {
            TotalIncome.Text = "";
            TotalExpenses.Text = "";
            NetIncome.Text = "";
            LeveragedNetROI.Text = "";
            CashOnCashReturn.Text = "";
            AnnualPreTaxCashFlow.Text = "";

        }
    }
}
