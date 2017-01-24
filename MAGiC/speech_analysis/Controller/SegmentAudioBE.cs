using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAGiC
{
    public class SegmentAudioBE
    {
        private SegmentAudioUI controls;

        public SegmentAudioBE(SegmentAudioUI _controls)
        {
            controls = _controls;
            initialize();
        }

        public SegmentAudioBE()
        {
            initialize();
        }

        public void initialize()
        {
            controls.btn_browse_wavFile_segment.Click += new System.EventHandler(this.btn_browse_Click);
            controls.btn_openFolder_segment.Click += new System.EventHandler(this.btn_browseOutputFolder_Click);
            controls.btn_segment.Click += new System.EventHandler(this.btn_segment_Click);
            controls.btn_gotoWalkthrough_segment.Click += new System.EventHandler(this.btn_gotoWalkthrough_Click);

        }

        public void btn_browseOutputFolder_Click(object sender, EventArgs e)
        {
            string folderName = "";
            controls.fbd_outputFolder_segment.SelectedPath = "";

            DialogResult result = controls.fbd_outputFolder_segment.ShowDialog();
            if (result == DialogResult.OK)
            {
                folderName = controls.fbd_outputFolder_segment.SelectedPath;
                if (String.IsNullOrEmpty(folderName) || String.IsNullOrWhiteSpace(folderName))
                {
                    controls.errorProvider_segment_outputFolder.SetError(controls.txt_outputFolder_segment, Constants.MESSAGE_SELECT_OUTPUT_FOLDER);
                    return;
                }

                controls.txt_outputFolder_segment.Text = folderName;

            }

        }

        public void btn_browse_Click(object sender, EventArgs e)
        {
            string fileName = "";

            controls.ofd_wavFile_segment.InitialDirectory = "c:\\";
            controls.ofd_wavFile_segment.Filter = "wav files (*.wav)|*.wav";
            // ofd_aviFile.FilterIndex = 2;
            controls.ofd_wavFile_segment.RestoreDirectory = true;

            DialogResult result = controls.ofd_wavFile_segment.ShowDialog();

            fileName = controls.ofd_wavFile_segment.FileName;
            controls.txt_wavFile_segment.Text = fileName;

        }

        public void btn_segment_Click(object sender, EventArgs e)
        {


            bool error = false;
            if (String.IsNullOrEmpty(controls.txt_outputFolder_segment.Text) || String.IsNullOrWhiteSpace(controls.txt_outputFolder_segment.Text))
            {
                controls.errorProvider_segment_outputFolder.SetError(controls.txt_outputFolder_segment, Constants.MESSAGE_SELECT_OUTPUT_FOLDER);
                error = true;
            }
            else
            {
                controls.errorProvider_segment_outputFolder.Clear();
                controls.errorProvider_segment_outputFolder.SetError(controls.txt_outputFolder_segment, "");
            }

            string fileName = "";
            fileName = controls.txt_wavFile_segment.Text;
            if (String.IsNullOrEmpty(fileName) || String.IsNullOrWhiteSpace(fileName))
            {
                controls.errorProvider_segment_wavFile.SetError(controls.txt_wavFile_segment, Constants.MESSAGE_SELECT_WAV_FILE);
                error = true;
            }
            else
            {
                controls.errorProvider_segment_wavFile.Clear();
                controls.errorProvider_segment_wavFile.SetError(controls.txt_wavFile_segment, "");
            }
            if (error)
                return;

            string _javadir = UtilityFunctions.LocateJava();
            ProcessStartInfo start = new ProcessStartInfo();
            if (!_javadir.Equals(String.Empty))
            {
                start.FileName = _javadir + "java.exe";
            }
            else
            {
                start.FileName = "java.exe";
            }
            start.Arguments = "-cp " + Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\speech_analysis\\Sphinx4Files\\sphinx4-core-all-1.0.jar edu.cmu.sphinx.tools.endpoint.Segmenter -i " + fileName + " -o " + controls.txt_outputFolder_segment.Text + "\\ -a " + controls.txt_outputFolder_segment.Text + "\\";
            start.UseShellExecute = false;
            start.RedirectStandardInput = true;
            start.RedirectStandardOutput = true;

            //Start the Process
            Process java = new Process();
            java.StartInfo = start;
            java.Start();
            java.WaitForExit();
            int exitCode = java.ExitCode;
            java.Close();

            MessageBox.Show("Succesfully segmented!!");
        }

        public void btn_gotoWalkthrough_Click(object sender, EventArgs e)
        {
            controls.navigationListener.navigateToSegmentAudioWalkthrough();
        }
    }
}
