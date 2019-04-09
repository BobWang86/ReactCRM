using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using Color = System.Drawing.Color;
using HorizontalAlignment = System.Windows.HorizontalAlignment;
using Panel = System.Windows.Controls.Panel;

namespace ReactCRM.UserControls
{
    public partial class UC_Home : System.Windows.Forms.UserControl
    {
        private Color BackColor;

        public UC_Home()
        {
            InitializeComponent();

            StackChart();

            FunnelChart();
        }

        private void StackChart()
        {
            cartesianChart1.Series = new SeriesCollection
            {
                new StackedAreaSeries
                {
                    Title = "Africa",
                    Values = new ChartValues<DateTimePoint>
                    {
                        new DateTimePoint(new System.DateTime(1950, 1, 1), .228),
                        new DateTimePoint(new System.DateTime(1960, 1, 1), .285),
                        new DateTimePoint(new System.DateTime(1970, 1, 1), .366),
                        new DateTimePoint(new System.DateTime(1980, 1, 1), .478),
                        new DateTimePoint(new System.DateTime(1990, 1, 1), .629),
                        new DateTimePoint(new System.DateTime(2000, 1, 1), .808),
                        new DateTimePoint(new System.DateTime(2010, 1, 1), 1.031),
                        new DateTimePoint(new System.DateTime(2013, 1, 1), 1.110)
                    },
                    LineSmoothness = 0
                },
                new StackedAreaSeries
                {
                    Title = "N & S America",
                    Values = new ChartValues<DateTimePoint>
                    {
                        new DateTimePoint(new System.DateTime(1950, 1, 1), .339),
                        new DateTimePoint(new System.DateTime(1960, 1, 1), .424),
                        new DateTimePoint(new System.DateTime(1970, 1, 1), .519),
                        new DateTimePoint(new System.DateTime(1980, 1, 1), .618),
                        new DateTimePoint(new System.DateTime(1990, 1, 1), .727),
                        new DateTimePoint(new System.DateTime(2000, 1, 1), .841),
                        new DateTimePoint(new System.DateTime(2010, 1, 1), .942),
                        new DateTimePoint(new System.DateTime(2013, 1, 1), .972)
                    },
                    LineSmoothness = 0
                },
                new StackedAreaSeries
                {
                    Title = "Asia",
                    Values = new ChartValues<DateTimePoint>
                    {
                        new DateTimePoint(new System.DateTime(1950, 1, 1), 1.395),
                        new DateTimePoint(new System.DateTime(1960, 1, 1), 1.694),
                        new DateTimePoint(new System.DateTime(1970, 1, 1), 2.128),
                        new DateTimePoint(new System.DateTime(1980, 1, 1), 2.634),
                        new DateTimePoint(new System.DateTime(1990, 1, 1), 3.213),
                        new DateTimePoint(new System.DateTime(2000, 1, 1), 3.717),
                        new DateTimePoint(new System.DateTime(2010, 1, 1), 4.165),
                        new DateTimePoint(new System.DateTime(2013, 1, 1), 4.298)
                    },
                    LineSmoothness = 0
                },
                new StackedAreaSeries
                {
                    Title = "Europe",
                    Values = new ChartValues<DateTimePoint>
                    {
                        new DateTimePoint(new System.DateTime(1950, 1, 1), .549),
                        new DateTimePoint(new System.DateTime(1960, 1, 1), .605),
                        new DateTimePoint(new System.DateTime(1970, 1, 1), .657),
                        new DateTimePoint(new System.DateTime(1980, 1, 1), .694),
                        new DateTimePoint(new System.DateTime(1990, 1, 1), .723),
                        new DateTimePoint(new System.DateTime(2000, 1, 1), .729),
                        new DateTimePoint(new System.DateTime(2010, 1, 1), .740),
                        new DateTimePoint(new System.DateTime(2013, 1, 1), .742)
                    },
                    LineSmoothness = 0
                }
            };

            cartesianChart1.AxisX.Add(new Axis
            {
                LabelFormatter = val => new System.DateTime((long)val).ToString("yyyy")
            });
            cartesianChart1.AxisY.Add(new Axis
            {
                LabelFormatter = val => val.ToString("N") + " M"
            });
        }

        private void FunnelChart()
        {
            BackColor = Color.FromArgb(255, 20, 20, 75);

            cartesianChart2.Series.Add(new LineSeries
            {
                Values = new ChartValues<double> { 100, 85, 50, 35, 5, 3 },
                Fill = new SolidColorBrush(System.Windows.Media.Color.FromRgb(33, 106, 254)),
                PointGeometry = null,
                AreaLimit = 0,
                StrokeThickness = 0
            });
            cartesianChart2.Series.Add(new LineSeries
            {
                Values = new ChartValues<double> { -100, -85, -50, -35, -5, 3 },
                Fill = new SolidColorBrush(System.Windows.Media.Color.FromRgb(33, 106, 254)),
                PointGeometry = null,
                AreaLimit = 0,
                StrokeThickness = 0
            });

            var s2 = new LineSeries
            {
                Values = new ChartValues<double> { 110, 94, 60, 40, 10, 10 },
                Fill = new SolidColorBrush(System.Windows.Media.Color.FromRgb(34, 44, 120)),
                PointGeometry = null,
                AreaLimit = 0,
                StrokeThickness = 0
            };
            var s3 = new LineSeries
            {
                Values = new ChartValues<double> { -110, -94, -60, -40, -10, -10 },
                Fill = new SolidColorBrush(System.Windows.Media.Color.FromRgb(34, 44, 120)),
                PointGeometry = null,
                AreaLimit = 0,
                StrokeThickness = 0
            };
            var s4 = new LineSeries
            {
                Values = new ChartValues<double> { 120, 104, 70, 50, 15, 15 },
                Fill = new SolidColorBrush(System.Windows.Media.Color.FromRgb(20, 24, 89)),
                PointGeometry = null,
                AreaLimit = 0,
                StrokeThickness = 0
            };
            var s5 = new LineSeries
            {
                Values = new ChartValues<double> { -120, -104, -70, -50, -15, -15 },
                Fill = new SolidColorBrush(System.Windows.Media.Color.FromRgb(20, 24, 89)),
                PointGeometry = null,
                AreaLimit = 0,
                StrokeThickness = 0
            };

            Panel.SetZIndex(s2, -1);
            Panel.SetZIndex(s3, -1);
            Panel.SetZIndex(s4, -2);
            Panel.SetZIndex(s5, -2);

            cartesianChart2.Series.Add(s2);
            cartesianChart2.Series.Add(s3);
            cartesianChart2.Series.Add(s4);
            cartesianChart2.Series.Add(s5);

            cartesianChart2.AxisY.Add(new Axis { IsEnabled = false, ShowLabels = false });
            var section1 = new AxisSection
            {
                Value = 1.5,
                Stroke = new SolidColorBrush(System.Windows.Media.Color.FromArgb(38, 255, 255, 255)),
                StrokeThickness = 5
            };
            var section2 = new AxisSection
            {
                Value = 3.5,
                Stroke = new SolidColorBrush(System.Windows.Media.Color.FromArgb(38, 255, 255, 255)),
                StrokeThickness = 5
            };
            Panel.SetZIndex(section1, 1);
            Panel.SetZIndex(section2, 1);
            cartesianChart2.AxisX.Add(new Axis
            {
                IsEnabled = false,
                ShowLabels = false,
                Sections = new SectionsCollection
                {
                    section1,
                    section2
                }
            });

            var userUri = new Uri(@"Cartesian/FunnelChart/Resources/user.png", UriKind.Relative);
            var fingerUri = new Uri("Cartesian/FunnelChart/Resources/fingerprint.png", UriKind.Relative);
            var viewUri = new Uri("Cartesian/FunnelChart/Resources/view.png", UriKind.Relative);

            var ve1 = new VisualElement
            {
                X = 0.75,
                Y = 120,
                VerticalAlignment = VerticalAlignment.Bottom,
                HorizontalAlignment = HorizontalAlignment.Center,
                UIElement = new StackPanel
                {
                    Children =
                    {
                        new System.Windows.Controls.Image {Source = new BitmapImage(userUri)},
                        new TextBlock { Text = "LOADED THE AD", FontSize = 16, Foreground = System.Windows.Media.Brushes.White}
                    }
                }
            };
            var ve2 = new VisualElement
            {
                X = 0.75,
                Y = 0,
                VerticalAlignment = VerticalAlignment.Center,
                HorizontalAlignment = HorizontalAlignment.Center,
                UIElement = new TextBlock { Text = "100 %", FontSize = 40, Foreground = System.Windows.Media.Brushes.White }
            };

            var ve3 = new VisualElement
            {
                X = 2.5,
                Y = 120,
                VerticalAlignment = VerticalAlignment.Bottom,
                HorizontalAlignment = HorizontalAlignment.Center,
                UIElement = new StackPanel
                {
                    Children =
                    {
                        new System.Windows.Controls.Image {Source = new BitmapImage(viewUri)},
                        new TextBlock { Text = "SAW THE AD", FontSize = 16, Foreground = System.Windows.Media.Brushes.White}
                    }
                }
            };

            var ve4 = new VisualElement
            {
                X = 2.5,
                Y = 0,
                VerticalAlignment = VerticalAlignment.Center,
                HorizontalAlignment = HorizontalAlignment.Center,
                UIElement = new TextBlock { Text = "50 %", FontSize = 40, Foreground = System.Windows.Media.Brushes.White }
            };

            var ve5 = new VisualElement
            {
                X = 4.25,
                Y = 120,
                VerticalAlignment = VerticalAlignment.Bottom,
                HorizontalAlignment = HorizontalAlignment.Center,
                UIElement = new StackPanel
                {
                    Children =
                    {
                        new System.Windows.Controls.Image {Source = new BitmapImage(fingerUri)},
                        new TextBlock { Text = "INTERACTED", FontSize = 16, Foreground = System.Windows.Media.Brushes.White}
                    }
                }
            };
            var ve6 = new VisualElement
            {
                X = 4.25,
                Y = 0,
                VerticalAlignment = VerticalAlignment.Center,
                HorizontalAlignment = HorizontalAlignment.Center,
                UIElement = new TextBlock { Text = "100 %", FontSize = 40, Foreground = System.Windows.Media.Brushes.White }
            };

            cartesianChart2.VisualElements.AddRange(new[]
            {
                ve1, ve2, ve3, ve4, ve5, ve6
            });
        }
    }
}
