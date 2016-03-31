using DataProvider.API;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ExchangeRateVisualizer
{
    public partial class MainForm : Form
    {
        private bool _isFormVisible;

        public MainForm()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.Manual;
            Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - Width, Screen.PrimaryScreen.WorkingArea.Height - Height);
            WindowState = FormWindowState.Minimized;
            Visible = false;
        }

        private void trayIcon_MouseClick(object sender, MouseEventArgs e)
        {
            var usdRate = GetCurrentCurrencyRate(Currency.USD);
            var eurRate = GetCurrentCurrencyRate(Currency.EUR);

            lblUsdPurchase.Text = FormatRate(usdRate.Bid);
            lblUsdSell.Text = FormatRate(usdRate.Ask);
            lblEurPurchase.Text = FormatRate(eurRate.Bid);
            lblEurSell.Text = FormatRate(eurRate.Ask);

            ChangeFormVisibility();
        }

        private CurrencyRate GetCurrentCurrencyRate(Currency currency)
        {
            var provider = new ExchangeRateProvider();
            var rates = provider.GetExchangeRates(currency);
            return rates.Last();
        }

        private string FormatRate(decimal rate)
        {
            return string.Format("{0}", rate);
        }

        private void ChangeFormVisibility()
        {
            _isFormVisible = !_isFormVisible;
            Visible = _isFormVisible;
            WindowState = WindowState == FormWindowState.Normal ? FormWindowState.Minimized : FormWindowState.Normal;
        }
    }
}
