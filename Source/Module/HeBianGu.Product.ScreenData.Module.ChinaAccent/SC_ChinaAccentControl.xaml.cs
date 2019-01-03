using System;
using System.Collections.Generic;
using System.Linq;
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

namespace HeBianGu.Product.ScreenData.Module.ChinaAccent
{
    /// <summary>
    /// SC_ChinaAccentControl.xaml 的交互逻辑
    /// </summary>
    public partial class SC_ChinaAccentControl : UserControl
    {
        public SC_ChinaAccentControl()
        {
            InitializeComponent();
        }

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.OnCloseClick();
        }


        //声明和注册路由事件
        public static readonly RoutedEvent CloseClickRoutedEvent =
            EventManager.RegisterRoutedEvent("CloseClick", RoutingStrategy.Bubble, typeof(EventHandler<RoutedEventArgs>), typeof(SC_ChinaAccentControl));
        //CLR事件包装
        public event RoutedEventHandler CloseClick
        {
            add { this.AddHandler(CloseClickRoutedEvent, value); }
            remove { this.RemoveHandler(CloseClickRoutedEvent, value); }
        }

        //激发路由事件,借用Click事件的激发方法

        protected void OnCloseClick()
        {
            RoutedEventArgs args = new RoutedEventArgs(CloseClickRoutedEvent, this);
            this.RaiseEvent(args);
        }

    }
}
