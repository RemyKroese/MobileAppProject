﻿using HartRevalidatieApplication.Helpers;
using HartRevalidatieApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace HartRevalidatieApplication.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class RegisterPage3 : Page
    {
        public RegisterPage3()
        {
            this.InitializeComponent();
            DataContext = RegisterPageViewModel.SingleInstance;
        }

        private async void Register_Click(object sender, RoutedEventArgs e)
        {
            if (Consultant_IsValidInput())
            {
                RegisterPageViewModel.SingleInstance.SetThirdRegisterPageUserData(ConsultantTextBox.SelectedValue.ToString());
                await RegisterPageViewModel.SingleInstance.Register();

                ((Frame)Window.Current.Content).Navigate(typeof(RegisterPageFinished));
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            GlobalClickMethods.Back_Click(sender, e);
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            GlobalClickMethods.Back_Click(sender, e);
        }

        private void ConsultantTextBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Consultant_IsValidInput();
        }

        private bool Consultant_IsValidInput()
        {
            if (ConsultantTextBox.SelectedValue == null)
            {
                ConsultantTextBox.BorderThickness = new Thickness(1);
                ConsultantTextBox.BorderBrush = new SolidColorBrush(Colors.Red);
                ConsultantError.Visibility = Visibility.Visible;

                return false;
            }

            else
            {
                ConsultantTextBox.BorderThickness = new Thickness(0);
                ConsultantError.Visibility = Visibility.Collapsed;

                return true;
            }
        }
    }
}
