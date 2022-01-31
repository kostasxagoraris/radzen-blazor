using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;

namespace Radzen.Blazor
{
    /// <summary>
    /// RadzenCurrency component.Based on RadzenNumeric component. Handles numbers that represent currency values. According to the currency provided the value displayed is formatted to include the currency symbol
    /// </summary>
    /// <typeparam name="TValue">The type of the t value.</typeparam>
    /// <example>
    /// <code>
    /// &lt;RadzenCurrency TValue="decimal" Min="0"  ISOCurrencySymbol="EUR" Change=@(args => Console.WriteLine($"Value: {args}")) /&gt;
    /// </code>
    /// </example>
    public partial class RadzenCurrencyNumeric<TValue> : FormComponent<TValue>
    {
        /// <summary>
        /// Gets or sets the 3 digits ISO currency symbol used to provide the currency symbol .
        /// </summary>
        /// <value>The 3 digits ISO currency symbol.</value>
        [Parameter]
        public string ISOCurrencySymbol { get; set; }
        [Parameter]
        public int Decimals { get; set; } = 2;








        private string Format => $"C{Decimals}";

        /// <summary>
        /// Gets or sets the step.
        /// </summary>
        /// <value>The step.</value>
        [Parameter]
        public string Step { get; set; }

       
        /// <summary>
        /// Gets or sets a value indicating whether is read only.
        /// </summary>
        /// <value><c>true</c> if is read only; otherwise, <c>false</c>.</value>
        [Parameter]
        public bool ReadOnly { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether input automatic complete is enabled.
        /// </summary>
        /// <value><c>true</c> if input automatic complete is enabled; otherwise, <c>false</c>.</value>
        [Parameter]
        public bool AutoComplete { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether up down buttons are shown.
        /// </summary>
        /// <value><c>true</c> if up down buttons are shown; otherwise, <c>false</c>.</value>
        [Parameter]
        public bool ShowUpDown { get; set; } = true;


       

       /// <summary>
        /// Determines the minimum value.
        /// </summary>
        /// <value>The minimum value.</value>
        [Parameter]
        public decimal? Min { get; set; }

        /// <summary>
        /// Determines the maximum value.
        /// </summary>
        /// <value>The maximum value.</value>
        [Parameter]
        public decimal? Max { get; set; }
        /// <summary>
        /// Gets or sets the formatted value.
        /// </summary>
        /// <value>The formatted value.</value>
        private CultureInfo CurrencyCulture
        {
            get { 
                
                       string symbol = GetCurrencySymbol(ISOCurrencySymbol);

                if (!string.IsNullOrWhiteSpace(symbol))
                {
                    var myCulture = new CultureInfo(this.Culture.Name);
                    myCulture.NumberFormat.CurrencySymbol = symbol;
                    return myCulture;
                }
                return Culture;
                }

        }

        private static string GetCurrencySymbol(string ISOCurrencySymbol)
        {
            if (string.IsNullOrWhiteSpace(ISOCurrencySymbol))
            {
                return null;
            }
            return CultureInfo
                .GetCultures(CultureTypes.AllCultures)
                .Where(c => !c.IsNeutralCulture)
                .Select(culture =>
                {
                    try
                    {
                        return new RegionInfo(culture.Name);
                    }
                    catch
                    {
                        return null;
                    }
                })
                .Where(ri => ri != null && ri.ISOCurrencySymbol == ISOCurrencySymbol)
                .Select(ri => ri.CurrencySymbol)
                .FirstOrDefault();
        }

    }
}
