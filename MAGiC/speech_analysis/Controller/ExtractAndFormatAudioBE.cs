using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAGiC
{
    public class ExtractAndFormatAudioBE
    {
        private ExtractAndFormatAudioUI controls;
        public ExtractAndFormatAudioBE(ExtractAndFormatAudioUI _controls)
        {
            controls = _controls;
            initialize();
        }

        public ExtractAndFormatAudioBE()
        {
            initialize();
        }



        private void initialize()
        {

            controls.btn_openFolder_extractFormat.Click += new System.EventHandler(this.btn_browseOutputFolder_Click);
            controls.btn_browseSingleFile_extractFormat.Click += new System.EventHandler(this.btn_browseSingleFile_Click);
            controls.btn_convertSingleFile_extractFormat.Click += new System.EventHandler(this.btn_convertSingleFile_Click);
            controls.btn_gotoWalkthrough_extractFormat.Click += new System.EventHandler(this.btn_gotoWalkthrough_Click);
        }


        public void btn_browseOutputFolder_Click(object sender, EventArgs e)
        {
            string folderName = "";
            controls.fbd_outputFolder_extractFormat.SelectedPath = "";

            DialogResult result = controls.fbd_outputFolder_extractFormat.ShowDialog();
            if (result == DialogResult.OK)
            {
                folderName = controls.fbd_outputFolder_extractFormat.SelectedPath;
                if (String.IsNullOrEmpty(folderName) || String.IsNullOrWhiteSpace(folderName))
                {
                    MessageBox.Show("You have to select outputFolder'!!");
                    return;
                }

                controls.txt_outputFolder_extractFormat.Text = folderName;

            }

        }

        public void btn_gotoWalkthrough_Click(object sender, EventArgs e)
        {
            controls.navigationListener.navigateToExtractFormatAudioWalkthrough();
        }


        public void btn_browseSingleFile_Click(object sender, EventArgs e)
        {
            string fileName = "";
            if (String.IsNullOrEmpty(controls.txt_outputFolder_extractFormat.Text) || String.IsNullOrWhiteSpace(controls.txt_outputFolder_extractFormat.Text))
            {
                controls.errorProvider_outputFolder_extractFormat.SetError(controls.txt_outputFolder_extractFormat, Constants.MESSAGE_SELECT_OUTPUT_FOLDER);
                return;
            }
            else
            {

                controls.ofd_aviFile_extractFormat.InitialDirectory = "c:\\";
                controls.ofd_aviFile_extractFormat.Filter = "avi files (*.avi)|*.avi";
                // ofd_aviFile.FilterIndex = 2;
                controls.ofd_aviFile_extractFormat.RestoreDirectory = true;

                DialogResult result = controls.ofd_aviFile_extractFormat.ShowDialog();

                fileName = controls.ofd_aviFile_extractFormat.FileName;
                controls.txt_aviFile_extractFormat.Text = fileName;

            }
        }

        public void btn_convertSingleFile_Click(object sender, EventArgs e)
        {
            bool errror = false;
            string fileName = "";
            fileName = controls.txt_aviFile_extractFormat.Text;
            if (String.IsNullOrEmpty(fileName) || String.IsNullOrWhiteSpace(fileName))
            {
                controls.errorProvider_aviFile_extractFormat.SetError(controls.txt_aviFile_extractFormat, Constants.MESSAGE_SELECT_AVI_FILE);
                errror = true;
            }
            else
            {
                controls.errorProvider_aviFile_extractFormat.Clear();
                controls.errorProvider_aviFile_extractFormat.SetError(controls.txt_aviFile_extractFormat, "");
            }

            string folderName = controls.txt_outputFolder_extractFormat.Text;
            if (String.IsNullOrEmpty(folderName) || String.IsNullOrWhiteSpace(folderName))
            {
                controls.errorProvider_outputFolder_extractFormat.SetError(controls.txt_outputFolder_extractFormat, Constants.MESSAGE_SELECT_OUTPUT_FOLDER);
                errror = true;
            }
            else
            {
                controls.errorProvider_outputFolder_extractFormat.Clear();
                controls.errorProvider_outputFolder_extractFormat.SetError(controls.txt_outputFolder_extractFormat, "");
            }
            if (errror)
                return;

            AviToWav(fileName);
            MessageBox.Show("Successfully converted..");
        }

        private async void AviToWav(string filepath)
        {
            if (String.IsNullOrEmpty(controls.txt_outputFolder_extractFormat.Text) || String.IsNullOrWhiteSpace(controls.txt_outputFolder_extractFormat.Text))
            {
                MessageBox.Show("You have to select outputFolder'!!");
                return;
            }

            //Path.get
            string filename = Path.GetFileNameWithoutExtension(filepath);

            // Convert
            filename = AviConverter.RemoveInvalidFilenameCharacters(filename);
            string dstFilepath = AviConverter.EnsureUniqueFilepath($"{controls.txt_outputFolder_extractFormat.Text}\\{filename}.wav");
            await AviConverter.FFmpegConvertToWavAsync(filepath, dstFilepath);

        }

        //public void btn_browseMultipleFile_Click()
        //{

        //    string folderName = "";
        //    controls.fbd_aviFiles.SelectedPath = "";

        //    if (String.IsNullOrEmpty(controls.txt_outputFolder.Text) || String.IsNullOrWhiteSpace(controls.txt_outputFolder.Text))
        //    {
        //        controls.errorProvider_outputFolder.SetError(controls.txt_outputFolder, Constants.MESSAGE_SELECT_OUTPUT_FOLDER);
        //        return;
        //    }
        //    else
        //    {
        //        DialogResult result = controls.fbd_aviFiles.ShowDialog();

        //        folderName = controls.fbd_aviFiles.SelectedPath;
        //        if (String.IsNullOrEmpty(folderName) || String.IsNullOrWhiteSpace(folderName))
        //        {
        //            controls.errorProvider_aviFolder.SetError(controls.txt_aviFolder, Constants.MESSAGE_SELECT_AVI_FOLDER);
        //            //MessageBox.Show("You have to select folder of .avi files'!!");
        //            return;
        //        }

        //        controls.txt_aviFolder.Text = folderName;


        //        foreach (string file in Directory.EnumerateFiles(folderName, "*.xml"))
        //        {
        //            string contents = File.ReadAllText(file);
        //        }
        //    }
        //}

        //public void btn_convertMultipleFile_Click()
        //{

        //    bool errror = false;
        //    string folderName = "";
        //    folderName = controls.txt_aviFolder.Text;
        //    if (String.IsNullOrEmpty(folderName) || String.IsNullOrWhiteSpace(folderName))
        //    {
        //        controls.errorProvider_aviFile.SetError(controls.txt_aviFolder, Constants.MESSAGE_SELECT_AVI_FOLDER);
        //        errror = true;
        //    }

        //    string folderNameOutput = controls.txt_outputFolder.Text;
        //    if (String.IsNullOrEmpty(folderNameOutput) || String.IsNullOrWhiteSpace(folderNameOutput))
        //    {
        //        controls.errorProvider_outputFolder.SetError(controls.txt_outputFolder, Constants.MESSAGE_SELECT_OUTPUT_FOLDER);
        //        errror = true;
        //    }
        //    if (errror)
        //        return;


        //    foreach (string file in Directory.EnumerateFiles(folderName, "*.xml"))
        //    {
        //        string contents = File.ReadAllText(file);
        //    }
        //}
    }
}
