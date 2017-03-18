﻿using System;
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
                if(TargetLiquidAmountTextBox.Text == "")
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

        private void UsedNicotinStrengthTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TargetNicotinStrengthTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void UsedAmoutOfAromaTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void CostNicotineConcentrate_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void CostBaseTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void CostAromaTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
