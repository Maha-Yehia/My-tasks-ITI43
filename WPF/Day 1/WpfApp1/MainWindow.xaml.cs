using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public object FilterStream { get; private set; }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void changeColor(object sender, RoutedEventArgs e)
        {
           switch(((RadioButton)sender).Content.ToString())
            {
                case "red":
                    inkCan.DefaultDrawingAttributes.Color = Colors.Red;
                    break;
                case "green":
                    inkCan.DefaultDrawingAttributes.Color = Colors.Green;
                    break;
                case "blue":
                    inkCan.DefaultDrawingAttributes.Color = Colors.Blue;
                    break;
                case "magenta":
                    inkCan.DefaultDrawingAttributes.Color = Colors.Magenta;
                    break;
            }

           
        }

        private void changeMode(object sender, RoutedEventArgs e)
        {
            switch (((RadioButton)sender).Content.ToString())
            {
                case "ink":
                    inkCan.EditingMode = InkCanvasEditingMode.Ink;
                    break;
                case "select":
                    inkCan.EditingMode = InkCanvasEditingMode.Select;
                    break;
                case "erase":
                    inkCan.EditingMode = InkCanvasEditingMode.EraseByPoint;
                    break;
                case "erase by stroke":
                    inkCan.EditingMode = InkCanvasEditingMode.EraseByStroke;
                    break;
            }
        }

        private void changeShape(object sender, RoutedEventArgs e)
        {
            switch (((RadioButton)sender).Content.ToString())
            {
                case "ellipse":
                    inkCan.DefaultDrawingAttributes.StylusTip = StylusTip.Ellipse;
                    break;
                case "rectangle":
                    inkCan.DefaultDrawingAttributes.StylusTip = StylusTip.Rectangle;
                    break;
                   
            }
        }

        private void changeSize(object sender, RoutedEventArgs e)
        {
            switch (((RadioButton)sender).Content.ToString())
            {
                case "small":
                    inkCan.DefaultDrawingAttributes.Width = 2  ;
                    inkCan.DefaultDrawingAttributes.Height = 2 ;
                    break;
                case "normal":
                    inkCan.DefaultDrawingAttributes.Width = 6;
                    inkCan.DefaultDrawingAttributes.Height = 6;
                    break;
                case "large":
                    inkCan.DefaultDrawingAttributes.Width = 14;
                    inkCan.DefaultDrawingAttributes.Height = 14;
                    break;
            }
        }

        private void btnNew(object sender, RoutedEventArgs e)
        {
            inkCan.Strokes.Clear();
        }


        private void btnCopy(object sender, RoutedEventArgs e)
        {
            inkCan.CopySelection(); 
        }
        private void btnCut(object sender, RoutedEventArgs e)
        {
            inkCan.CutSelection();
        }
        private void btnPaste(object sender, RoutedEventArgs e)
        {
            inkCan.Paste();
        }
        private void btnSave(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "InkCanvas Format|*.png";
            saveFileDialog.Title = "Save InkCanvas File";
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName == "") return;
            FileStream fs = File.Open(saveFileDialog.FileName, FileMode.OpenOrCreate);
            inkCan.Strokes.Save(fs);
            fs.Close();

        }

        private void btnLoad(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "InkCanvas Format(.asmaa)|*.png";
            openFileDialog.Title = "Load InkCanvas File";
            openFileDialog.DefaultExt = "Asmaa";
            openFileDialog.ShowDialog();
            if (openFileDialog.FileName == "") return;
            FileStream fs = File.Open(openFileDialog.FileName, FileMode.Open);
            StrokeCollection strclc = new StrokeCollection(fs);
            inkCan.Strokes = strclc;
            fs.Close();

        }
    }
}
