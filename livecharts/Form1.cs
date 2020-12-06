﻿using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace livecharts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cartesianChart1.Series = new SeriesCollection
            {
               new LineSeries
               {
                   Values = new ChartValues<ObservablePoint>
                   {
                       new ObservablePoint(0,10),
                       new ObservablePoint(4,12),
                       new ObservablePoint(5,14),
                       new ObservablePoint(7,18),


                   },
                   PointGeometrySize = 15
               }

            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
