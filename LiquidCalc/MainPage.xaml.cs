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

        }
    }
}
