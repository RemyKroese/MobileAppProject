﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HartRevalidatieApplication.ViewModels
{
    public sealed class RegisterPageViewModel
    {
        public static RegisterPageViewModel SingleInstance { get; } = new RegisterPageViewModel();

        public RegisterPageViewModel()
        {

        }
    }
}
