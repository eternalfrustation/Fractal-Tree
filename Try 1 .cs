/*
 * Created by SharpDevelop.
 * User: alphasamirpur
 * Date: 04/14/2020
 * Time: 17:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Fractal_Try1
{
	/// <summary>
	/// Interaction logic for Window1.xaml
	/// </summary>
	public partial class Window1 : Window
	{
	
		public Window1()
		{
			InitializeComponent();
		}
		
		void clicked(object sender, RoutedEventArgs e)
		{
			int iterations = Convert.ToInt16(textbox.Text);
			// changing the memory address while keeping the same value
			string x1s = Convert.ToString(canvas.ActualWidth/2);
			string y1s = Convert.ToString(canvas.ActualHeight);
			string x2s = Convert.ToString(canvas.ActualWidth/2);
			string y2s = Convert.ToString(canvas.ActualHeight/2);
	
			double x1 = Convert.ToDouble(x1s);	
			double y1 = Convert.ToDouble(y1s);	
			double x2 = Convert.ToDouble(x2s);
			double y2 = Convert.ToDouble(y2s);
			
			string x1s2 = Convert.ToString(canvas.ActualWidth/2);
			string y1s2 = Convert.ToString(canvas.ActualHeight);
			string x2s2 = Convert.ToString(canvas.ActualWidth/2);
			string y2s2 = Convert.ToString(canvas.ActualHeight/2);
	
			double x12 = Convert.ToDouble(x1s);	
			double y12 = Convert.ToDouble(y1s);	
			double x22 = Convert.ToDouble(x2s);
			double y22 = Convert.ToDouble(y2s);
			bool anglec = true;
			bool anglec2 = true;
			double a = 1;
			double a2 = 1;
			a = slider.Value;
			for (int i = 0; i < iterations; i++) {

				Line line = new Line();
				line.X1 = x1;
				line.Y1 = y1;
				line.Y2 = y2;
				line.X2 = x2;
				double length = Math.Sqrt(Math.Pow((line.X1 - line.X2), 2)+Math.Pow((line.Y1-line.Y2),2));
				x1 = x2;
				y1 = y2;
				switch (anglec) {
					case true:
						x2 = x2 + (length / 2  * Math.Cos(-a));
						y2 = y2 + (length / 2 *  Math.Sin(-a));
						anglec = false;
						break;
					
				
					case false:
						x2 = x2 + (length / 2  * Math.Cos(a));
						y2 = y2 + (length / 2 *  Math.Sin(a));
						anglec = true;
						break;
				}
				label.Content = length;
				line.Stroke = new SolidColorBrush(Colors.White);

				button.Content = line.X1 + " " + line.Y1 + " " + line.X2 + " " + line.Y2;
				
				
			canvas.Children.Add(line);
			}
			
			for (int i = 0; i < iterations; i++) {
				a2 = slider.Value;
				Line line2 = new Line();
				line2.X1 = x12;
				line2.Y1 = y12;
				line2.Y2 = y22;
				line2.X2 = x22;
				double length2 = Math.Sqrt(Math.Pow((line2.X1 - line2.X2), 2)+Math.Pow((line2.Y1-line2.Y2),2));
				x12 = x22 + 1 - 1;
				y12 = y22 + 1 - 1 ;
				switch (anglec2) {
					case true:
						x22 = x22 + (length2 / 2  * Math.Cos(a2));
						y22 = y22 + (length2 / 2 *  Math.Sin(a2));
						anglec2 = false;
						break;
					
				
					case false:
						x22 = x22 + (length2 / 2  * Math.Cos(-a2));
						y22 = y22 + (length2 / 2 *  Math.Sin(-a2));
						anglec2 = true;
						break;
				}
				label.Content = length2;
				
				line2.Stroke = new SolidColorBrush(Colors.Silver);

				button.Content = line2.X1 + " " + line2.Y1 + " " + line2.X2 + " " + line2.Y2;
				
				
			canvas.Children.Add(line2);
			}
		}
		
		
		}
	}

