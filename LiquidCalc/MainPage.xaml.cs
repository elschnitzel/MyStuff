using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace LiquidCalc
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            Application.Current.DebugSettings.EnableFrameRateCounter = false;
        }

        private string targetLiquidAmountLastValidInput = "";
        private double targetLiquidAmount;
        private void TargetLiquidAmountTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (TargetLiquidAmountTextBox.Text == "")
                {
                    targetLiquidAmount = 0;
                }
                else
                {
                    TargetLiquidAmountTextBox.Text = TargetLiquidAmountTextBox.Text.Replace(',', '.');
                    TargetLiquidAmountTextBox.Select(TargetLiquidAmountTextBox.Text.Length, 0);
                    targetLiquidAmount = Convert.ToDouble(TargetLiquidAmountTextBox.Text);
                }

                targetLiquidAmountLastValidInput = targetLiquidAmount.ToString();
            }
            catch
            {
                TargetLiquidAmountTextBox.Text = targetLiquidAmountLastValidInput;
                TargetLiquidAmountTextBox.Select(TargetLiquidAmountTextBox.Text.Length, 0);
            }
        }

        private string usedNicotinStrengthLastValidInput = "";
        private double usedNicotineStrength;
        private void UsedNicotinStrengthTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (UsedNicotinStrengthTextBox.Text == "")
                {
                    usedNicotineStrength = 0;
                }
                else
                {
                    UsedNicotinStrengthTextBox.Text = UsedNicotinStrengthTextBox.Text.Replace(',', '.');
                    UsedNicotinStrengthTextBox.Select(UsedNicotinStrengthTextBox.Text.Length, 0);
                    usedNicotineStrength = Convert.ToDouble(UsedNicotinStrengthTextBox.Text);
                }

                usedNicotinStrengthLastValidInput = usedNicotineStrength.ToString();
            }
            catch
            {
                UsedNicotinStrengthTextBox.Text = usedNicotinStrengthLastValidInput;
                UsedNicotinStrengthTextBox.Select(UsedNicotinStrengthTextBox.Text.Length, 0);
            }
        }

        private string targetNicotinStrengthLastValidInput = "";
        private double targetNicotinStrength;
        private void TargetNicotinStrengthTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (TargetNicotinStrengthTextBox.Text == "")
                {
                    targetNicotinStrength = 0;
                }
                else
                {
                    TargetNicotinStrengthTextBox.Text = TargetNicotinStrengthTextBox.Text.Replace(',', '.');
                    TargetNicotinStrengthTextBox.Select(TargetNicotinStrengthTextBox.Text.Length, 0);
                    targetNicotinStrength = Convert.ToDouble(TargetNicotinStrengthTextBox.Text);
                }

                targetNicotinStrengthLastValidInput = targetNicotinStrength.ToString();
            }
            catch
            {
                TargetNicotinStrengthTextBox.Text = targetNicotinStrengthLastValidInput;
                TargetNicotinStrengthTextBox.Select(TargetNicotinStrengthTextBox.Text.Length, 0);
            }
        }

        private string usedAmountOfAromaLastValidInput = "";
        private double usedAmountOfAroma;
        private void UsedAmoutOfAromaTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (UsedAmoutOfAromaTextBox.Text == "")
                {
                    usedAmountOfAroma = 0;
                }
                else
                {
                    UsedAmoutOfAromaTextBox.Text = UsedAmoutOfAromaTextBox.Text.Replace(',', '.');
                    UsedAmoutOfAromaTextBox.Select(UsedAmoutOfAromaTextBox.Text.Length, 0);
                    usedAmountOfAroma = Convert.ToDouble(UsedAmoutOfAromaTextBox.Text);
                }

                usedAmountOfAromaLastValidInput = usedAmountOfAroma.ToString();
            }
            catch
            {
                UsedAmoutOfAromaTextBox.Text = usedAmountOfAromaLastValidInput;
                UsedAmoutOfAromaTextBox.Select(UsedAmoutOfAromaTextBox.Text.Length, 0);
            }
        }

        private string costNicotineConcentrateLastValidInput = "";
        private double costNicotineConcentrate;
        private void CostNicotineConcentrate_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (CostNicotineConcentrateTextBox.Text == "")
                {
                    costNicotineConcentrate = 0;
                }
                else
                {
                    CostNicotineConcentrateTextBox.Text = CostNicotineConcentrateTextBox.Text.Replace(',', '.');
                    CostNicotineConcentrateTextBox.Select(CostNicotineConcentrateTextBox.Text.Length, 0);
                    costNicotineConcentrate = Convert.ToDouble(CostNicotineConcentrateTextBox.Text);
                }

                costNicotineConcentrateLastValidInput = costNicotineConcentrate.ToString();
            }
            catch
            {
                CostNicotineConcentrateTextBox.Text = costNicotineConcentrateLastValidInput;
                CostNicotineConcentrateTextBox.Select(CostNicotineConcentrateTextBox.Text.Length, 0);
            }
        }

        private string costBaseLastValidInput = "";
        private double costBase;
        private void CostBaseTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (CostBaseTextBox.Text == "")
                {
                    costBase = 0;
                }
                else
                {
                    CostBaseTextBox.Text = CostBaseTextBox.Text.Replace(',', '.');
                    CostBaseTextBox.Select(CostBaseTextBox.Text.Length, 0);
                    costBase = Convert.ToDouble(CostBaseTextBox.Text);
                }

                costBaseLastValidInput = costBase.ToString();
            }
            catch
            {
                CostBaseTextBox.Text = costBaseLastValidInput;
                CostBaseTextBox.Select(CostBaseTextBox.Text.Length, 0);
            }
        }

        private string costAromaLastValidInput = "";
        private double costAroma;
        private void CostAromaTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (CostAromaTextBox.Text == "")
                {
                    costAroma = 0;
                }
                else
                {
                    CostAromaTextBox.Text = CostAromaTextBox.Text.Replace(',', '.');
                    CostAromaTextBox.Select(CostAromaTextBox.Text.Length, 0);
                    costAroma = Convert.ToDouble(CostAromaTextBox.Text);
                }

                costAromaLastValidInput = costAroma.ToString();
            }
            catch
            {
                CostAromaTextBox.Text = costAromaLastValidInput;
                CostAromaTextBox.Select(CostAromaTextBox.Text.Length, 0);
            }
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            double nicotineAmount = targetLiquidAmount / (usedNicotineStrength / targetNicotinStrength);
            double baseAmount = targetLiquidAmount - nicotineAmount - ((usedAmountOfAroma / 100.0) * targetLiquidAmount);
            double aromaAmout = (usedAmountOfAroma / 100.0) * targetLiquidAmount;
            double nicotineCost = nicotineAmount * (costNicotineConcentrate / 100.0);
            double baseCost = baseAmount * (costBase / 100.0);
            double aromaCost = aromaAmout * (costAroma / 100.0);
            double sum = nicotineCost + baseCost + aromaCost;

            NicotineResultTextBox.Text = nicotineAmount.ToString();
            BaseResultTextBox.Text = baseAmount.ToString();
            AromaResultTextBox.Text = aromaAmout.ToString();
            NicotineCostResultTextBox.Text = nicotineCost.ToString();
            BaseCostResultTextBox.Text = baseCost.ToString();
            AromaCostResultTextBox.Text = aromaCost.ToString();
            SumCostResultTextBox.Text = sum.ToString();
        }
    }
}
