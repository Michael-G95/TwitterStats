using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Linq;
namespace Social_Media
{
    public partial class GraphForm : Form
    {
        // Form to display a graph of a list of ints
        List<int> Data { get; set; }
        string DataName { get; set; }

        public GraphForm(List<int> data, string dataName)
        {
            // Constructor for form - taking in the data that will be graphed
            InitializeComponent();
            this.Data = data;
            DataName = dataName;
        }

        private void GraphForm_Load(object sender, EventArgs e)
        {
            // Empty the demo data from designer
            Graph.Series.Clear();

            // Create new data series - setting properties. X index is hidden as it is just showing tweets, no scale
            Series series = new Series();
            series.Name = DataName;
            series.Color = Color.FromArgb(0, 132, 180);
            series.IsVisibleInLegend = false;
            series.IsXValueIndexed = false;
            // Ensures the top of the graph is slightly higher than biggest data point for presentation
            Graph.ChartAreas[0].AxisY.Maximum = Data.Max() + (Data.Max() * 0.2);
            series.ChartType = SeriesChartType.Line;

            // Add the data into the series

            foreach (int point in Data)
            {
                series.Points.Add(point);
            }
            Graph.Series.Add(series);

            // Force redraw of graph    
            Graph.Invalidate();

            // Add the description
            lblInfo.Text = "Graph showing number of " + DataName + " on y axis,\nTweet number on x axis.";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Exit button event for form
            this.Close();
        }

        private void GraphForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
