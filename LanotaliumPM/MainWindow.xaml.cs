using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LanotaliumPM
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            foreach (var file in Directory.GetFiles("/StreamingAssets/Plugins"))
            {
                Assembly assembly = Assembly.LoadFrom(file);
                Type[] types = assembly.GetTypes();
                foreach (var type in types)
                {
                    //Creator Buttons
                    if (type.GetInterface("ILanotaliumPlugin") != null)
                    {
                        
                    }
                }
            }
            InitializeComponent();
        }
    }
}
