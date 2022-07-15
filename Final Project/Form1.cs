using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Final_Project
{
    public partial class Form1 : Form
    {

        int goodCount, readRows;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            DialogResult result;
            string fileName;
            
            double[] value = new double[0];

            using (OpenFileDialog fileChooser = new OpenFileDialog())
            {
                

                fileChooser.InitialDirectory = @"C:\Temp";  
                fileChooser.Title = "Browse Text Files";  
  
                fileChooser.CheckFileExists = true;  
                fileChooser.CheckPathExists = true;  
  
                fileChooser.DefaultExt = "txt";
                fileChooser.Filter = "txt files (*.txt)|*.txt";  
                fileChooser.FilterIndex = 2;
                fileChooser.RestoreDirectory = true;  
  
                fileChooser.ReadOnlyChecked = true;  
                fileChooser.ShowReadOnly = true;
                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName;

                if (result == DialogResult.OK)
                {
                    
                    fileBox.Text = fileName;
                    var lines = File.ReadAllLines(fileName);
                    double[] darray = new double[lines.Length];
                    List<double> goodRows = new List<double>();

                    //process file data into useable data type

                    for (int y = 0; y < lines.Length; y++) 
                    {
                        try
                        {
                            darray[y] = Convert.ToDouble(lines[y]);
                        }
                        catch { }
                    }


                    //process data for GUI
                    for (int x = 0; x < darray.Length; x++)
                    {
                        if (darray[x] == 99999)
                        {
                            break;
                        }
                        else if (darray[x] >= 0)
                        {
                            goodRows.Add(darray[x]);
                            goodCount++;
                            readRows++;
                        }
                        else
                        {
                            readRows++;
                        }
                    }
                    try
                    {
                        File.WriteAllLines(@"c:\temp\rainfall2.txt", goodRows.Select(d => d.ToString()));
                        MessageBox.Show(@"C:\Temp\rainfall2.txt complete.");
                    }
                    catch
                    {
                        MessageBox.Show("Unable to process file.");
                    }

                    try
                    {
                        readBox.Text = Convert.ToString(readRows);
                        goodBox.Text = Convert.ToString(goodCount);
                        minimumBox.Text = Convert.ToString(goodRows.Min());
                        maximumBox.Text = Convert.ToString(goodRows.Max());
                        averageBox.Text = Convert.ToString(goodRows.Average());
                    }
                    catch 
                    {
                        MessageBox.Show("Unable to analyze data from file.");
                    }

                    selectButton.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Unable to process selected file.");
                }
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
