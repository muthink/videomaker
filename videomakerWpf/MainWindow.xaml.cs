using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Media.Animation;

namespace videomakerWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += new RoutedEventHandler(Page_Loaded);
        }
        TextBlock text(string text, int x, int y)
        {
            TextBlock returns = new TextBlock();
            double X = ((this.Width*((double)x))/100.0);
            double Y = ((this.Height*(double)y)/100.0);
            Canvas.SetLeft(returns,X);
            Canvas.SetTop(returns,Y);
            returns.Text = text;
            returns.FontSize = 20;
            returns.Opacity = 0.5;
            returns.Foreground = new SolidColorBrush(Colors.Black);
            this.mainCanvas.Children.Add(returns);
            return returns;
        }
        void Page_Loaded(object sender, RoutedEventArgs e)
        {
            TextBlock leftText = text("This is a test", 10, 10);
            Storyboard sb = new Storyboard();
            mainCanvas.Resources.Add("mainStoryboard", sb);
            DoubleAnimation transformX = new DoubleAnimation(0.0,1.0,new Duration(TimeSpan.FromSeconds(2.0)));
            transformX.RepeatBehavior = RepeatBehavior.Forever;
            Storyboard.SetTarget(transformX,mainCanvas.Children[0]);
            PropertyPath path = new PropertyPath(TextBlock.OpacityProperty);
            Storyboard.SetTargetProperty(transformX, path);
            sb.Begin();
        }
    }
}
