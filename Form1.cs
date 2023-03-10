using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PreoExpress
{
    public partial class Preo : Form
    {
        public Preo()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            Driver driver = new Driver();
            driver.Payment = 320;
            driver.Miltal = Convert.ToInt32(tbMiles.Text);
            driver.MilePrice = Convert.ToInt32(tbPriceForMiles.Text);
            driver.TotalPriceForMiles = driver.Miltal * driver.MilePrice;
            driver.Vat = Convert.ToDecimal(tbVat.Text);

            Loader loader = new Loader();
            loader.Payment = 160;
            loader.Vat = Convert.ToDecimal(tbVat.Text);



            string outputWithStrings;
            string newLine = Environment.NewLine;

            decimal totalPriceInsideStockholm;
            decimal totalPriceWithVatInsideStockholm;
            decimal VatAndRut;
            decimal totalPriceOutsideStockholm;
            decimal totalPriceWithVatOutsideStockholm;

            if (cbDriver.Checked && rbStockholm.Checked)
            {
                if (!cbLoader.Checked && tbLoaders.Text != "0")
                {
                    MessageBox.Show("Har du glömt att markera flyttarbetare?", "Tips");
                }

                driver.NumberOfWorkers = Convert.ToInt32(tbDrivers.Text);
                driver.Hours = Convert.ToInt32(tbHours.Text);
                driver.TotalSumma = driver.Total(driver.NumberOfWorkers, driver.Hours);
                driver.TotalSummaWithVat = driver.TotalPriceWithVat(driver.NumberOfWorkers, driver.Hours);
                VatAndRut = driver.Rutavdrag(driver.TotalSummaWithVat) + driver.TotalSummaWithVat;

                outputWithStrings = $"Förare: {driver.NumberOfWorkers}" + newLine +
                                    $"Flyttarbetare: {loader.NumberOfWorkers}" + newLine +
                                    $"******************************************************" + newLine +
                                    $"Priset ex moms: {driver.TotalSumma}" + newLine +
                                    $"Priset inklusiv moms ({driver.Vat} %): {driver.TotalSummaWithVat} kr" + newLine +
                                    $"Priset innan rutavdrag: {VatAndRut} kr";

                tbDisplay.Text = outputWithStrings;
            }
            if (cbLoader.Checked && rbStockholm.Checked)
            {
                if (!cbDriver.Checked && tbDrivers.Text != "0")
                {
                    MessageBox.Show("Har du glömt att markera förare?", "Tips");
                }

                loader.NumberOfWorkers = Convert.ToInt32(tbLoaders.Text);
                loader.Hours = Convert.ToInt32(tbHours.Text);
                loader.TotalSumma = loader.Total(loader.NumberOfWorkers, loader.Hours);
                loader.TotalSummaWithVat = loader.TotalPriceWithVat(loader.NumberOfWorkers, loader.Hours);
                VatAndRut = loader.Rutavdrag(loader.TotalSummaWithVat) + loader.TotalSummaWithVat;
                outputWithStrings = $"Förare: {driver.NumberOfWorkers}" + newLine +
                                    $"Flyttarbetare: {loader.NumberOfWorkers}" + newLine +
                                    $"******************************************************" + newLine +
                                    $"Priset ex moms: {loader.TotalSumma}" + newLine +
                                    $"Priset inklusiv moms ({driver.Vat} %): {loader.TotalSummaWithVat} kr" + newLine +
                                    $"Priset innan rutavdrag: {VatAndRut} kr";

                tbDisplay.Text = outputWithStrings;
            }
            if (cbDriver.Checked && rbOutside.Checked)
            {
                if (!cbLoader.Checked && tbLoaders.Text != "0")
                {
                    MessageBox.Show("Har du glömt att markera flyttarbetare?", "Tips");
                }

                driver.NumberOfWorkers = Convert.ToInt32(tbDrivers.Text);
                driver.Hours = Convert.ToInt32(tbHours.Text);
                driver.TotalSumma = driver.TotalWithMile(driver.NumberOfWorkers, driver.Hours);

                totalPriceWithVatOutsideStockholm = driver.TotalSumma * driver.Vat;

                VatAndRut = driver.Rutavdrag(totalPriceWithVatOutsideStockholm) + totalPriceWithVatOutsideStockholm;

                outputWithStrings = $"Förare: {driver.NumberOfWorkers}" + newLine +
                                    $"Flyttarbetare: {loader.NumberOfWorkers}" + newLine +
                                    $"Miltal: {driver.Miltal}" + newLine +
                                    $"******************************************************" + newLine +
                                    $"Priset miltal: {driver.TotalPriceForMiles} kr" + newLine +
                                    $"Priset ex moms: {driver.TotalSumma}" + newLine +
                                    $"Priset inklusiv moms ({driver.Vat} %): {totalPriceWithVatOutsideStockholm} kr" + newLine +
                                    $"Priset innan rutavdrag: {VatAndRut} kr";

                tbDisplay.Text = outputWithStrings;
            }
            if (cbDriver.Checked && cbLoader.Checked && rbStockholm.Checked)
            {
                driver.NumberOfWorkers = Convert.ToInt32(tbDrivers.Text);
                driver.Hours = Convert.ToInt32(tbHours.Text);
                driver.TotalSumma = driver.Total(driver.NumberOfWorkers, driver.Hours);

                loader.NumberOfWorkers = Convert.ToInt32(tbLoaders.Text);
                loader.Hours = Convert.ToInt32(tbHours.Text);
                loader.TotalSumma = loader.Total(loader.NumberOfWorkers, loader.Hours);

                totalPriceInsideStockholm = driver.TotalSumma + loader.TotalSumma;

                totalPriceWithVatInsideStockholm = totalPriceInsideStockholm * driver.Vat;

                VatAndRut = driver.Rutavdrag(totalPriceWithVatInsideStockholm) + totalPriceWithVatInsideStockholm;

                outputWithStrings = $"Förare: {driver.NumberOfWorkers}" + newLine +
                                    $"Flyttarbetare: {loader.NumberOfWorkers}" + newLine +
                                    $"******************************************************" + newLine +
                                    $"Priset ex moms: {totalPriceInsideStockholm}" + newLine +
                                    $"Priset inklusiv moms ({driver.Vat} %): {totalPriceWithVatInsideStockholm} kr" + newLine +
                                    $"Priset innan rutavdrag: {VatAndRut} kr";

                tbDisplay.Text = outputWithStrings;
            }
            if (cbDriver.Checked && cbLoader.Checked && rbOutside.Checked)
            {
                driver.NumberOfWorkers = Convert.ToInt32(tbDrivers.Text);
                driver.Hours = Convert.ToInt32(tbHours.Text);
                driver.TotalSumma = driver.TotalWithMile(driver.NumberOfWorkers, driver.Hours);

                loader.NumberOfWorkers = Convert.ToInt32(tbLoaders.Text);
                loader.Hours = Convert.ToInt32(tbHours.Text);
                loader.TotalSumma = loader.Total(loader.NumberOfWorkers, loader.Hours);

                totalPriceOutsideStockholm = driver.TotalSumma + loader.TotalSumma;

                totalPriceWithVatOutsideStockholm = totalPriceOutsideStockholm * driver.Vat;

                VatAndRut = driver.Rutavdrag(totalPriceWithVatOutsideStockholm) + totalPriceWithVatOutsideStockholm;

                outputWithStrings = $"Förare: {driver.NumberOfWorkers}" + newLine +
                                    $"Flyttarbetare: {loader.NumberOfWorkers}" + newLine +
                                    $"Miltal: {driver.Miltal}" + newLine +
                                    $"******************************************************" + newLine +
                                    $"Priset miltal: {driver.TotalPriceForMiles} kr" + newLine +
                                    $"Priset ex moms: {totalPriceOutsideStockholm}" + newLine +
                                    $"Priset inklusiv moms ({driver.Vat} %): {totalPriceWithVatOutsideStockholm} kr" + newLine +
                                    $"Priset innan rutavdrag: {VatAndRut} kr";

                tbDisplay.Text = outputWithStrings;
            }
        }
    }
}
