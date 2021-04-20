using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFDragDropSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void DragGestureRecognizer_DragStarting(System.Object sender, Xamarin.Forms.DragStartingEventArgs e)
        {
            var label = (sender as Element)?.Parent as Label;
            e.Data.Properties.Add("Text", label.Text);
        }

        void DropGestureRecognizer_Drop(System.Object sender, Xamarin.Forms.DropEventArgs e)
        {
            var data = e.Data.Properties["Text"].ToString();
            var frame = (sender as Element)?.Parent as Frame;
            frame.Content = new Label
            {
                Text = data
            };
        }
    }
}
