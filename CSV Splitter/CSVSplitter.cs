using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CSV_Splitter
{
    public partial class CSVSplitter : Form
    {
        private int numberOfLines = 0;
        private static string recordsToSplitDefault = "5000";

        private int intRecordsToSplit;
        //private int numberLeftOff;

        //stores the file contents from the CSV file
        private List<string> sFileContents = new List<string>();

        //stores head from CSV if needed
        private string sHeader;

        //All Batch Data
        Dictionary<int, List<string>> fileBatches = new Dictionary<int, List<string>>();
 
        public CSVSplitter()
        {
            InitializeComponent();
            //recordsToSplit default value
            recordsToSplit.Text = recordsToSplitDefault;
        }

        private void updateNumberOfLinesAndStoreFileContents()
        {
            //Reset
            numberOfLines = 0;
            sHeader = null;
            //Set intRecordsToSplit
            intRecordsToSplit = int.Parse(recordsToSplit.Text);
            StreamReader sr = new StreamReader(openFileDialog1.FileName);

            try
            {
                //Count Lines
                while (!sr.EndOfStream)
                {
                    string srLine = sr.ReadLine();

                    //Copy Header
                    if (firstRowIsHeader.Checked && numberOfLines == 0 && sHeader == null)
                    {
                        sHeader = srLine;
                    }
                    else
                    {
                        sFileContents.Add(srLine);
                        numberOfLines++;
                    }   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                                ex.Message.ToString() + Environment.NewLine +
                                ex.Data + Environment.NewLine +
                                ex.InnerException + Environment.NewLine +
                                ex.Source + Environment.NewLine +
                                ex.StackTrace
                                );
            }
            finally
            {
                sr.Close();
                UpdateStatus();
            }
        }

        private int getRecordStartNumber(int batch)
        {
            int StartNum = (batch * intRecordsToSplit) - intRecordsToSplit;
            return StartNum;
        }

        private int getRecordEndNumber(int batch)
        {
            int EndNum = getRecordStartNumber(batch) + intRecordsToSplit;
            return EndNum;
        }

        private void save_Click(object sender, EventArgs e)
        {
            //Set intRecordsToSplit
            intRecordsToSplit = int.Parse(recordsToSplit.Text);

            for(int batchNum = 0; batchNum < numberOfBatchesToCreate(); batchNum++) 
            {
                int currentBatchNumber = batchNum + 1;
                fillBatch(currentBatchNumber);
            }

            //now lets see the preview
            int i = 1;
            foreach (KeyValuePair<int, List<String>> entry in fileBatches)
            {
                List<string> tempFileContents = new List<string>();
                foreach (string s in entry.Value) 
                {
                    //Add to temp file contents
                    tempFileContents.Add(s);
                    //For Preview Only
                    listBox1.Items.Add(s);
                }
                //now create the csv file
                createFile(i,tempFileContents);

                i++;
            }

            Application.Exit();
            
        }

        private void createFile(int batch, List<string> fileContents)
        {
            if (saveLocation.Text != "")
            {
                if (Directory.Exists(saveLocation.Text))
                {
                    string newPath = Path.Combine(saveLocation.Text, "Batch_" + batch + ".csv");
                    //we will overwrite any file with this name so we will not need to check if it already exists
                    using ( StreamWriter sw = new StreamWriter(newPath) )
                    {
                        if (copyHeaders.Checked) 
                        { 
                            sw.WriteLine(sHeader); 
                        }
                        foreach (string s in fileContents)
                        {
                            if (s != sHeader)
                            {
                                sw.WriteLine(s);
                            }
                        }
                        sw.Close();
                    }
                }
                else
                {
                    MessageBox.Show("The directory does not exist. Please create one and try again.");
                }
            }
        }

        private int numberOfBatchesToCreate()
        {
            if (recordsToSplit.Text == null || recordsToSplit.Text == "") { return 0; }

            if (numberOfLines == 0) { return 0; }

            if (int.Parse(recordsToSplit.Text.ToString()) > numberOfLines) { return 1; }

            decimal numBatches = (decimal)numberOfLines / (decimal)intRecordsToSplit;

            return (int)Math.Ceiling(numBatches);
        }

        private int getCurrentBatchNumber(int currentArrayNumber)
        {
            int batchNum = 0;
            int numBatches = numberOfBatchesToCreate();

            if (numBatches == 0) { return 0; }

            for (int initBatchNumber = 1; initBatchNumber < numBatches; initBatchNumber++)
            {
                if (currentArrayNumber <= initBatchNumber * intRecordsToSplit)
                {
                    batchNum = initBatchNumber;
                }
            }
            return batchNum;
        }

        public void fillBatch(int batchNumber) 
        {
            if (sFileContents.Count > 0)
            {
                try
                {   
                    //Read Lines of File Contents in batches

                    List<string> tempList = new List<string>();
                    int recStartNum = getRecordStartNumber(batchNumber);
                    int recEndNum = getRecordEndNumber(batchNumber);
                    if (recEndNum > numberOfLines) { recEndNum = numberOfLines; }
                    for (int startNum = recStartNum; startNum < recEndNum; startNum++)
                    {
                        tempList.Add(sFileContents[startNum]);
                    }

                    //fill batch with temp list
                    fileBatches.Add(batchNumber, tempList);
                }
                catch (Exception ex)
                {
                    MessageBox.Show( 
                                    ex.Message.ToString() + Environment.NewLine + 
                                    ex.Data + Environment.NewLine + 
                                    ex.InnerException  + Environment.NewLine + 
                                    ex.Source  + Environment.NewLine + 
                                    ex.StackTrace
                                    );
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (firstRowIsHeader.Checked)
            {
                copyHeaders.Enabled = true;
            }
            else
            {
                copyHeaders.Enabled = false;
            }
            if (fileToSplit.Text != "")
            {
                updateNumberOfLinesAndStoreFileContents();
            }
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listBox1.Items.Count+" Items in the list");
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UpdateStatus()
        {
            toolStripStatusLabel1.Text = "This app will create " + numberOfBatchesToCreate() + " CSV Files from a total of " + numberOfLines + " rows... ";
        }

        private void recordsToSplit_TextChanged(object sender, EventArgs e)
        {
            if (recordsToSplit.Text == null || recordsToSplit.Text == "") { recordsToSplit.Text = recordsToSplitDefault; }
            UpdateStatus();
        }

        private void fileToSplit_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                updateNumberOfLinesAndStoreFileContents();
            }
        }

        private void saveLocation_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                saveLocation.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            fileToSplit.Text = openFileDialog1.FileName.ToString();
        }

    }
}
