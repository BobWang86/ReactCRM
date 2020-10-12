using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using LiveCharts;
using LiveCharts.Wpf;
using Panel = System.Windows.Controls.Panel;
using HorizontalAlignment = System.Windows.HorizontalAlignment;
using Separator = LiveCharts.Wpf.Separator;
using ReactCRM.dbConn;

namespace ReactCRM.UserControls
{
    public partial class UC_Home : System.Windows.Forms.UserControl
    {
        dbSale sales = new dbSale();

        dbClient clients = new dbClient();

        dbExpense expenses = new dbExpense();

        public UC_Home()
        {
            InitializeComponent();

            LineChart();

            FunnelChart();
        }

        public LineSeries RevenueSeries { get; set; }
        public LineSeries ExpenseSeries { get; set; }
        public LineSeries ProfitSeries { get; set; }

        private void cbRevenue_CheckedChanged(object sender, EventArgs e)
        {
            RevenueSeries.Visibility = RevenueSeries.Visibility == Visibility.Visible
                ? Visibility.Hidden
                : Visibility.Visible;
        }

        private void cbExpense_CheckedChanged(object sender, EventArgs e)
        {
            ExpenseSeries.Visibility = ExpenseSeries.Visibility == Visibility.Visible
               ? Visibility.Hidden
               : Visibility.Visible;
        }

        private void cbProfit_CheckedChanged(object sender, EventArgs e)
        {
            ProfitSeries.Visibility = ProfitSeries.Visibility == Visibility.Visible
                ? Visibility.Hidden
                : Visibility.Visible;
        }

        private void LineChart()
        {
            cartesianChart1.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 255, 255));

            List<double> Revenue = sales.GetSalesByDate(sales);

            List<double> Expenditure = expenses.GetExpensesByDate(expenses);

            RevenueSeries = new LineSeries
            {
                Title = "Revenue",
                Values = new ChartValues<double> { Revenue[0], Revenue[1], Revenue[2], Revenue[3], Revenue[4], Revenue[5] },
                LineSmoothness = 1
            };
            ExpenseSeries = new LineSeries
            {
                Title = "Expense",
                Values = new ChartValues<double> { Expenditure[0], Expenditure[1], Expenditure[2], Expenditure[3], Expenditure[4], Expenditure[5] },
                LineSmoothness = 1
            };
            ProfitSeries = new LineSeries
            {
                Title = "Profit",
                Values = new ChartValues<double> { Revenue[0]-Expenditure[0], Revenue[1]- Expenditure[1], Revenue[2]- Expenditure[2], Revenue[3]- Expenditure[3], Revenue[4]-Expenditure[4], Revenue[5]-Expenditure[5] },
                LineSmoothness = 1
            };

            cartesianChart1.Series = new SeriesCollection
            {
                RevenueSeries,
                ExpenseSeries,
                ProfitSeries
            };

            cartesianChart1.AxisX.Add(new Axis
            {
                Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May", "June" },
                Separator = new Separator
                {
                    Step = 1,
                    IsEnabled = false
                },
                LabelsRotation = 15
            });

            cartesianChart1.AxisY.Add(new Axis
            {
                LabelFormatter = value => value.ToString("C")
            });
        }

        private void FunnelChart()
        {
            cartesianChart2.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 255, 255));

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

            List<double> Percentages = new List<double>();

            int totalClients = clients.GetClientCount(clients);

            List<double> salesPipeline = clients.GetClientByPipeline(clients);

            foreach (var item in salesPipeline)
            {
                Percentages.Add(Math.Round(item/totalClients, 4) * 100);
            }

            var ve1 = new VisualElement
            {
                X = 0.75,
                Y = 150,
                VerticalAlignment = VerticalAlignment.Bottom,
                HorizontalAlignment = HorizontalAlignment.Center,
                UIElement = new StackPanel
                {
                    Children =
                    {
                        new System.Windows.Controls.Image {Source = new BitmapImage(userUri)},
                        new TextBlock { Text = "Awareness", FontSize = 16, Foreground = System.Windows.Media.Brushes.Black}
                    }
                }
            };
            var ve2 = new VisualElement
            {
                X = 0.75,
                Y = 0,
                VerticalAlignment = VerticalAlignment.Center,
                HorizontalAlignment = HorizontalAlignment.Center,
                UIElement = new TextBlock { Text = $"{Percentages[0]}%", FontSize = 40, Foreground = System.Windows.Media.Brushes.Black }
            };

            var ve3 = new VisualElement
            {
                X = 1.9,
                Y = 150,
                VerticalAlignment = VerticalAlignment.Bottom,
                HorizontalAlignment = HorizontalAlignment.Center,
                UIElement = new StackPanel
                {
                    Children =
                    {
                        new System.Windows.Controls.Image {Source = new BitmapImage(viewUri)},
                        new TextBlock { Text = "Interest", FontSize = 16, Foreground = System.Windows.Media.Brushes.Black}
                    }
                }
            };

            var ve4 = new VisualElement
            {
                X = 1.9,
                Y = 0,
                VerticalAlignment = VerticalAlignment.Center,
                HorizontalAlignment = HorizontalAlignment.Center,
                UIElement = new TextBlock { Text = $"{Percentages[1]}%", FontSize = 40, Foreground = System.Windows.Media.Brushes.Black }
            };

            var ve5 = new VisualElement
            {
                X = 3.1,
                Y = 150,
                VerticalAlignment = VerticalAlignment.Bottom,
                HorizontalAlignment = HorizontalAlignment.Center,
                UIElement = new StackPanel
                {
                    Children =
                    {
                        new System.Windows.Controls.Image {Source = new BitmapImage(fingerUri)},
                        new TextBlock { Text = "Decision", FontSize = 16, Foreground = System.Windows.Media.Brushes.Black}
                    }
                }
            };
            var ve6 = new VisualElement
            {
                X = 3.1,
                Y = 0,
                VerticalAlignment = VerticalAlignment.Center,
                HorizontalAlignment = HorizontalAlignment.Center,
                UIElement = new TextBlock { Text = $"{Percentages[2]}%", FontSize = 40, Foreground = System.Windows.Media.Brushes.Black }
            };

            var ve7 = new VisualElement
            {
                X = 4.25,
                Y = 150,
                VerticalAlignment = VerticalAlignment.Bottom,
                HorizontalAlignment = HorizontalAlignment.Center,
                UIElement = new StackPanel
                {
                    Children =
                    {
                        new System.Windows.Controls.Image {Source = new BitmapImage(fingerUri)},
                        new TextBlock { Text = "Action", FontSize = 16, Foreground = System.Windows.Media.Brushes.Black}
                    }
                }
            };
            var ve8 = new VisualElement
            {
                X = 4.25,
                Y = 0,
                VerticalAlignment = VerticalAlignment.Center,
                HorizontalAlignment = HorizontalAlignment.Center,
                UIElement = new TextBlock { Text = $"{Percentages[3]}%", FontSize = 40, Foreground = System.Windows.Media.Brushes.Black }
            };

            cartesianChart2.VisualElements.AddRange(new[]
            {
                ve1, ve2, ve3, ve4, ve5, ve6, ve7, ve8
            });
        }
    }
}
