using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace TimeTrackerUiWpf.Utils
{
    static class ResourceUtils
    {
        public static void SetLanguageDictionary(Application a)
        {
            ResourceDictionary dict = new ResourceDictionary();
            switch (Thread.CurrentThread.CurrentCulture.ToString())
            {
                case "en-US":
                    dict.Source = new Uri("..\\Resources\\StringResources.xaml",
                                  UriKind.Relative);
                    break;
                case "hu-HU":
                    dict.Source = new Uri("..\\Resources\\StringResources.hu-HU.xaml",
                                       UriKind.Relative);
                    break;
                default:
                    dict.Source = new Uri("..\\Resources\\StringResources.xaml",
                                      UriKind.Relative);
                    break;
            }
            a.Resources.MergedDictionaries.Add(dict);
        }
    }
}
