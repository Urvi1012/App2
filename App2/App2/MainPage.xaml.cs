﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            // slider.Value = 0.5;
        }

        //void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        //{
        //    label.Text = String.Format("Value is {0:F2}", e.NewValue);
        //}
    }
}
