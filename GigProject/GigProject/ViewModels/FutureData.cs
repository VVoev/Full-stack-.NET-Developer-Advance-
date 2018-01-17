﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace GigProject.ViewModels
{
    public class FutureData : ValidationAttribute
    {

        public override bool IsValid(object value)
        {
            DateTime datetime;
            var isValid = DateTime.TryParseExact(Convert.ToString(value),
                "d MMM yyyy",
                CultureInfo.CurrentCulture,
                DateTimeStyles.None,
                out datetime);
            return (isValid && datetime > DateTime.Now);
        }
    }
}