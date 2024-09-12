using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Policy;
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

namespace lab4
{
   
    public partial class MainWindow : Window
    {  public void DefineQuarter( double x,  double y)
        {
            if (x > 0 && y > 0)
                LabelArea.Content = "Точка розташована в першій чверті";
            if (x < 0 && y > 0)
                LabelArea.Content = "Точка розташована в другій чверті"; 
            if (x < 0 && y < 0)
                LabelArea.Content = "Точка розташована в третій чверті"; 
            if (x > 0 && y < 0)
                LabelArea.Content = "Точка розташована в четвертій чверті";
            if (x == 0) { LabelArea.Content = "Точна розташована на осі Y"; }
            if (y == 0) { LabelArea.Content = "Точка розташована на осі X"; }
            if (x == 0 && y==0) { LabelArea.Content = "Точка розташована в центрі координат"; }



        }
        public void DrawCircle(ref double  x, ref double y)
        {
            CanvasPoints.Children.Clear();//очищення слоя з точками
            double centerX = CoordinateArea.ActualWidth / 2;
            double centerY = CoordinateArea.ActualHeight / 2;
            x = centerX+x;//координати точки
            y = centerY-y;
            Ellipse point = new Ellipse { Width = 10, Height = 10, Fill= Brushes.DarkSalmon };//ось тут можеш змінити колір точки
            Canvas.SetLeft(point, x-5);//розташування точки 
            Canvas.SetTop(point, y);//
           CanvasPoints.Children.Add(point);
            
            
        }
        public static Window1 CoordinatesWindow;
        public MainWindow()
        {
            InitializeComponent();       
        }
       
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
                CoordinatesWindow = new Window1(this);
                CoordinatesWindow.Show();
        }
    }
}
