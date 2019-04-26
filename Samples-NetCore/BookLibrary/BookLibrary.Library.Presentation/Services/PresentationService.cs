﻿using System.ComponentModel.Composition;
using System.Globalization;
using System.Windows;
using System.Windows.Markup;
using Waf.BookLibrary.Library.Applications.Services;

namespace Waf.BookLibrary.Library.Presentation.Services
{
    [Export(typeof(IPresentationService))]
    public class PresentationService : IPresentationService
    {
        public double VirtualScreenWidth => SystemParameters.VirtualScreenWidth;

        public double VirtualScreenHeight => SystemParameters.VirtualScreenHeight;
        
        public void InitializeCultures()
        {
            FrameworkElement.LanguageProperty.OverrideMetadata(typeof(FrameworkElement), new FrameworkPropertyMetadata(
                XmlLanguage.GetLanguage(CultureInfo.CurrentCulture.IetfLanguageTag)));
        }
    }
}
