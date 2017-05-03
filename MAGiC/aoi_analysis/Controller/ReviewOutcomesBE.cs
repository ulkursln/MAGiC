using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace MAGiC
{
    public class ReviewOutcomesBE
    {

        private ReviewOutcomesUI controls;
        public ReviewOutcomesBE(ReviewOutcomesUI _controls)
        {
            controls = _controls;
            initialize();
        }

        public ReviewOutcomesBE()
        {
            initialize();

        }


        private void initialize()
        {
            //Visualize Tracking
            controls.btn_browsevideoFile_visualizeTracking.Click += new System.EventHandler(this.btn_browsevideoFile_visualizeTracking_Click);
            controls.btn_browse2dlandmark_visualizeTracking.Click += new System.EventHandler(this.btn_browse2dlandmark_visualizeTracking_Click);
            controls.btn_browseRawGazeDataFile_visualizeTracking.Click += new System.EventHandler(this.btn_browseRawGazeDataFile_visualizeTracking_Click);
            controls.btn_browseaois_visualizeTracking.Click += new System.EventHandler(this.btn_browseaois_visualizeTracking_Click);
            controls.btn_browseVisualizeJustExpIntervalFileName_visualizeTracking.Click += new System.EventHandler(this.btn_browseVisualizeJustExpIntervalFileName_visualizeTracking_Click);
            controls.btn_visualize_visualizeTracking.Click += new System.EventHandler(this.btn_visualize_visualizeTracking_Click);
            controls.cb_visualizeJustExpInterval_visualizeTracking.CheckedChanged += new System.EventHandler(this.cb_visualizeJustExpInterval_visualizeTracking_CheckedChanged);
            controls.btn_gotoWalkthrough_visualizeTracking.Click += new System.EventHandler(this.btn_gotoWalkthrough_visualizeTrackingResults_Click);
            controls.rbOptionSingleParticipant_visualizeTracking.Checked = true;

            //Detect AOI ratio
            controls.btn_browseaois_AOIDetectionRatio.Click += new System.EventHandler(this.btn_browseaois_AOIDetectionRatio_Click);
            controls.btn_browseExpIntervalFileName_AOIDetectionRatio.Click += new System.EventHandler(this.btn_browseExpIntervalFileName_AOIDetectionRatio_Click);
            controls.btn_findRatio_AOIDetectionRatio.Click += new System.EventHandler(this.btn_findRatio_AOIDetectionRatio_Click);
            controls.btn_gotoWalkthrough_AOIDetectionRatio.Click += new System.EventHandler(this.btn_gotoWalkthrough_findDetectionRatio_Click);
            controls.rbOptionSingleParticipant_AOIDetectionRatio.Checked = true;

            //LabelAOIsManually Tracking
            controls.btn_createOutputFile_labelROIManually.Click += new System.EventHandler(this.btn_createOutputFile_labelROIManually_Click);
            controls.btn_browsevideoFile_labelROIManually.Click += new System.EventHandler(this.btn_browsevideoFile_labelROIManually_Click);
            controls.btn_browse2dlandmark_labelROIManually.Click += new System.EventHandler(this.btn_browse2dlandmark_labelROIManually_Click);
            controls.btn_browseRawGazeDataFile_labelROIManually.Click += new System.EventHandler(this.btn_browseRawGazeDataFile_labelROIManually_Click);
            controls.btn_browseaois_labelROIManually.Click += new System.EventHandler(this.btn_browseaois_labelROIManually_Click);
            controls.btn_browseVisualizeJustExpIntervalFileName_labelROIManually.Click += new System.EventHandler(this.btn_browseVisualizeJustExpIntervalFileName_labelROIManually_Click);
            controls.btn_labelROIManually.Click += new System.EventHandler(this.btn_labelROIManually_Click);
            controls.cb_visualizeJustExpInterval_labelROIManually.CheckedChanged += new System.EventHandler(this.cb_visualizeJustExpInterval_labelROIManually_CheckedChanged);
            controls.btn_gotoWalkthrough_labelROIManually.Click += new System.EventHandler(this.btn_gotoWalkthrough_labelAOIMAnually_Click);
            controls.rbOptionSingleParticipant_labelROIManually.Checked = true;

            //Reanalyze
            controls.btn_createOutputFile_reanalyzeAOI.Click += new System.EventHandler(this.btn_createOutputFile_reanalyzeAOI_Click);
            controls.btn_browseManuallyLabeled_reanalyzeAOI.Click += new System.EventHandler(this.btn_browseManuallyLabeled_reanalyzeAOI_Click);
            controls.btn_browseRawGazeDataFile_reanalyzeAOI.Click += new System.EventHandler(this.btn_browseRawGazeDataFile_reanalyzeAOI_Click);
            controls.btn_browse2dlandmark_reanalyzeAOI.Click += new System.EventHandler(this.btn_browse2dlandmark_reanalyzeAOI_Click);
            controls.btn_browseImageSizeTrakingFramework_reanalyzeAOI.Click += new System.EventHandler(this.btn_browseImageSizeTrakingFramework_reanalyzeAOI_Click);
            controls.btn_analyse_reanalyzeAOI.Click += new System.EventHandler(this.btn_analyse_reanalyzeAOI_Click);
            controls.btn_gotoWalkthrough_reanalyzeAOI.Click += new System.EventHandler(this.btn_gotoWalkthrough_reanalyseAOI_Click);
        }



        private void btn_findRatio_AOIDetectionRatio_Click(object sender, EventArgs e)
        {
            bool errror = false;
            string aoiFileName = controls.txt_aois_AOIDetectionRatio.Text;
            if (String.IsNullOrEmpty(aoiFileName) || String.IsNullOrWhiteSpace(aoiFileName) || !File.Exists(aoiFileName))
            {

                controls.errorProvider_aois_AOIDetectionRatio.SetError(controls.txt_aois_AOIDetectionRatio, Constants.MESSAGE_SELECT_AOI_FILE);
                errror = true;
            }

            else
            {
                controls.errorProvider_aois_AOIDetectionRatio.Clear();
                controls.errorProvider_aois_AOIDetectionRatio.SetError(controls.txt_aois_AOIDetectionRatio, "");
            }

            string fileNameExpInterval = controls.txt_ExpIntervalFileName_AOIDetectionRatio.Text;
            if (String.IsNullOrEmpty(fileNameExpInterval) || String.IsNullOrWhiteSpace(fileNameExpInterval) || !File.Exists(fileNameExpInterval))
            {

                controls.errorProvider_ExpIntervalFileName_AOIDetectionRatio.SetError(controls.txt_ExpIntervalFileName_AOIDetectionRatio, Constants.MESSAGE_SELECT_EXPERIMENT_INTERVAL_FILE);
                errror = true;
            }

            else
            {
                controls.errorProvider_ExpIntervalFileName_AOIDetectionRatio.Clear();
                controls.errorProvider_ExpIntervalFileName_AOIDetectionRatio.SetError(controls.txt_ExpIntervalFileName_AOIDetectionRatio, "");
            }



            int participantNo = -1, frequency = -1;
            string participantNostr = controls.txt_ExpIntervalParticipantNo_AOIDetectionRatio.Text;

            if (String.IsNullOrEmpty(participantNostr) || String.IsNullOrWhiteSpace(participantNostr) || (!int.TryParse(participantNostr, out participantNo)))
            {
                controls.errorProvider_ExpIntervalParticipantNo_AOIDetectionRatio.SetError(controls.txt_ExpIntervalParticipantNo_AOIDetectionRatio, Constants.MESSAGE_ENTER_POSITIVE_INTEGER_VALUE);
                errror = true;
            }
            else
            {
                controls.errorProvider_ExpIntervalParticipantNo_AOIDetectionRatio.Clear();
                controls.errorProvider_ExpIntervalParticipantNo_AOIDetectionRatio.SetError(controls.txt_ExpIntervalParticipantNo_AOIDetectionRatio, "");
            }

            string frequencystr = controls.txt_ExpIntervalFrequency_AOIDetectionRatio.Text;

            if (String.IsNullOrEmpty(frequencystr) || String.IsNullOrWhiteSpace(frequencystr) || (!int.TryParse(frequencystr, out frequency)))
            {
                controls.errorProvider_ExpIntervalHz_AOIDetectionRatio.SetError(controls.txt_ExpIntervalFrequency_AOIDetectionRatio, Constants.MESSAGE_ENTER_POSITIVE_INTEGER_VALUE);
                errror = true;
            }
            else
            {
                controls.errorProvider_ExpIntervalHz_AOIDetectionRatio.Clear();
                controls.errorProvider_ExpIntervalHz_AOIDetectionRatio.SetError(controls.txt_ExpIntervalFrequency_AOIDetectionRatio, "");
            }

            if (errror)
                return;

            string ratio = findAOIDetectionRatio(aoiFileName, fileNameExpInterval, frequency, participantNo);

            MessageBox.Show("Succesfully done!!\n" + ratio);

        }

        private string findAOIDetectionRatio(String fileName_aoi, String fileName_expInterval, int frequency, int participantNo)
        {
            char[] delimiterChars = { ' ', '\t' };

            string writeToFileStr = "";

            string line_aois = "";
            string[] arr_line_aois = null;
            int numberofNotDetectedAOIs = 0, numberOFEmptyGazeRawData = 0, numberofEmptyBoth = 0, numberofEmptyFaceDetection = 0;

            System.IO.StreamReader file_aois = new System.IO.StreamReader(fileName_aoi);

            int first_frame_num = 0, last_frame_num = 0, total_frame = 0;

     
           Constants.ParticipantInfo participantInfo = Constants.ParticipantInfo.Single;
           if (controls.rbOptionSingleParticipant_AOIDetectionRatio.Checked) participantInfo = Constants.ParticipantInfo.Single;
           else if (controls.rbOptionFirstParticipant_AOIDetectionRatio.Checked) participantInfo = Constants.ParticipantInfo.First;
           else if (controls.rbOptionSecondParticipant_AOIDetectionRatio.Checked) participantInfo = Constants.ParticipantInfo.Second;
           UtilityFunctions.findStartingEndingFrameNo(fileName_expInterval, participantNo, participantInfo, frequency, ref first_frame_num, ref last_frame_num);

            

            total_frame = last_frame_num - first_frame_num + 1;

            while ((line_aois = file_aois.ReadLine()) != null)
            {

                arr_line_aois = line_aois.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
                int frameNo = Convert.ToInt32(arr_line_aois[0]);
                if (frameNo >= first_frame_num) break;

            }

            while ((line_aois = file_aois.ReadLine()) != null)
            {

                arr_line_aois = line_aois.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
                int frameNo = Convert.ToInt32(arr_line_aois[0]);
                if (frameNo > last_frame_num) break;

                arr_line_aois = line_aois.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);

                int line_num = Convert.ToInt32(arr_line_aois[0]);

                if (arr_line_aois.Length < 2)
                    numberofNotDetectedAOIs++;
                else if (String.IsNullOrEmpty(arr_line_aois[1]) || Constants.FaceDetectionEmpty.Equals(arr_line_aois[1]) || Constants.BothFaceDetectionGazeRawDataEmpty.Equals(arr_line_aois[1]) || Constants.GazeRawDataEmpty.Equals(arr_line_aois[1]))
                    numberofNotDetectedAOIs++;
                if (Constants.FaceDetectionEmpty.Equals(arr_line_aois[1]))
                    numberofEmptyFaceDetection++;
                if (Constants.BothFaceDetectionGazeRawDataEmpty.Equals(arr_line_aois[1]))
                    numberofEmptyBoth++;
                if (Constants.GazeRawDataEmpty.Equals(arr_line_aois[1]))
                    numberOFEmptyGazeRawData++;


            }

            writeToFileStr += " Number of Not Detected AOIs:" + numberofNotDetectedAOIs + "\n Number of Total Frame:" + total_frame + "\n Ratio of Not Detected:" + Math.Round(((double)numberofNotDetectedAOIs / (double)total_frame) * 100, 2) + "\n\n";
            writeToFileStr += " Number of Empty Face Detection(both + just face detection empty):" + (numberofEmptyFaceDetection + numberofEmptyBoth )+ "\n Number of Total Frame:" + total_frame + "\n Ratio of Not Detected:" + Math.Round(((double)(numberofEmptyFaceDetection + numberofEmptyBoth) / (double)total_frame) * 100, 2) + "\n\n";
            writeToFileStr += " Number of Empty Gaze Raw Data(both + just raw data empty):" + (numberOFEmptyGazeRawData + numberofEmptyBoth ) + "\n Number of Total Frame:" + total_frame + "\n Ratio of Not Detected:" + Math.Round(((double)(numberOFEmptyGazeRawData + numberofEmptyBoth) / (double)total_frame) * 100, 2) + "\n\n";
            writeToFileStr += " Number of Empty Both Face Detection and Empty Gaze Raw Data:" + numberofEmptyBoth + "\n Number of Total Frame:" + total_frame + "\n Ratio of Not Detected:" + Math.Round(((double)numberofEmptyBoth / (double)total_frame) * 100, 2) + "\n\n";
            writeToFileStr += "\n";


            return writeToFileStr;
        }

        private void btn_browseExpIntervalFileName_AOIDetectionRatio_Click(object sender, EventArgs e)
        {
            controls.ofd_ExpIntervalFileName_AOIDetectionRatio.InitialDirectory = "c:\\";
            controls.ofd_ExpIntervalFileName_AOIDetectionRatio.Filter = "txt files (*.txt)|*.txt";
            // ofd_aviFile.FilterIndex = 2;
            controls.ofd_ExpIntervalFileName_AOIDetectionRatio.RestoreDirectory = true;

            DialogResult result = controls.ofd_ExpIntervalFileName_AOIDetectionRatio.ShowDialog();

            string fileName = controls.ofd_ExpIntervalFileName_AOIDetectionRatio.FileName;
            controls.txt_ExpIntervalFileName_AOIDetectionRatio.Text = fileName;
            if (String.IsNullOrEmpty(fileName) || String.IsNullOrWhiteSpace(fileName))
            {
                controls.errorProvider_ExpIntervalFileName_AOIDetectionRatio.SetError(controls.txt_ExpIntervalFileName_AOIDetectionRatio, Constants.MESSAGE_SELECT_EXPERIMENT_INTERVAL_FILE);
                return;
            }
            else
            {
                controls.errorProvider_ExpIntervalFileName_AOIDetectionRatio.Clear();
                controls.errorProvider_ExpIntervalFileName_AOIDetectionRatio.SetError(controls.txt_ExpIntervalFileName_AOIDetectionRatio, "");
            }
        }

        private void btn_browseaois_AOIDetectionRatio_Click(object sender, EventArgs e)
        {
            controls.ofd_aois_AOIDetectionRatio.InitialDirectory = "c:\\";
            controls.ofd_aois_AOIDetectionRatio.Filter = "txt files (*.txt)|*.txt";
            // ofd_aviFile.FilterIndex = 2;
            controls.ofd_aois_AOIDetectionRatio.RestoreDirectory = true;

            DialogResult result = controls.ofd_aois_AOIDetectionRatio.ShowDialog();

            string fileName = controls.ofd_aois_AOIDetectionRatio.FileName;
            controls.txt_aois_AOIDetectionRatio.Text = fileName;
            if (String.IsNullOrEmpty(fileName) || String.IsNullOrWhiteSpace(fileName))
            {
                controls.errorProvider_aois_AOIDetectionRatio.SetError(controls.txt_aois_AOIDetectionRatio, Constants.MESSAGE_SELECT_AOI_FILE);
                return;
            }
            else
            {
                controls.errorProvider_aois_AOIDetectionRatio.Clear();
                controls.errorProvider_aois_AOIDetectionRatio.SetError(controls.txt_aois_AOIDetectionRatio, "");
            }
        }

        private void btn_browsevideoFile_visualizeTracking_Click(object sender, EventArgs e)
        {
            controls.ofd_videoFile_visualizeTracking.InitialDirectory = "c:\\";
            controls.ofd_videoFile_visualizeTracking.Filter = "avi files (*.avi)|*.avi";
            // ofd_aviFile.FilterIndex = 2;
            controls.ofd_videoFile_visualizeTracking.RestoreDirectory = true;

            DialogResult result = controls.ofd_videoFile_visualizeTracking.ShowDialog();

            string fileName = controls.ofd_videoFile_visualizeTracking.FileName;
            controls.txt_videoFile_visualizeTracking.Text = fileName;
            if (String.IsNullOrEmpty(fileName) || String.IsNullOrWhiteSpace(fileName))
            {
                controls.errorProvider_videoFile_visualizeTracking.SetError(controls.txt_videoFile_visualizeTracking, Constants.MESSAGE_SELECT_AVI_FILE);
                return;
            }
            else
            {
                controls.errorProvider_videoFile_visualizeTracking.Clear();
                controls.errorProvider_videoFile_visualizeTracking.SetError(controls.txt_videoFile_visualizeTracking, "");
            }
        }

        private void cb_visualizeJustExpInterval_visualizeTracking_CheckedChanged(object sender, EventArgs e)
        {
            if (!controls.cb_visualizeJustExpInterval_visualizeTracking.Checked)
                controls.pnl_visualizeJustExpInterval.Enabled = false;
            else
                controls.pnl_visualizeJustExpInterval.Enabled = true;
        }

        private void btn_visualize_visualizeTracking_Click(object sender, EventArgs e)
        {


            bool errror = false;
            string videoFileName = controls.txt_videoFile_visualizeTracking.Text;
            if (String.IsNullOrEmpty(videoFileName) || String.IsNullOrWhiteSpace(videoFileName) || !File.Exists(videoFileName))
            {

                controls.errorProvider_videoFile_visualizeTracking.SetError(controls.txt_videoFile_visualizeTracking, Constants.MESSAGE_SELECT_AVI_FILE);
                errror = true;
            }

            else
            {
                controls.errorProvider_videoFile_visualizeTracking.Clear();
                controls.errorProvider_videoFile_visualizeTracking.SetError(controls.txt_videoFile_visualizeTracking, "");
            }

            string fileName = controls.txt_2dlandmark_visualizeTracking.Text;
            if (String.IsNullOrEmpty(fileName) || String.IsNullOrWhiteSpace(fileName) || !File.Exists(fileName))
            {

                controls.errorProvider_2dlandmark_visualizeTracking.SetError(controls.txt_2dlandmark_visualizeTracking, Constants.MESSAGE_SELECT_2dLANDMARK_FILE);
                errror = true;
            }

            else
            {
                controls.errorProvider_2dlandmark_visualizeTracking.Clear();
                controls.errorProvider_2dlandmark_visualizeTracking.SetError(controls.txt_2dlandmark_visualizeTracking, "");
            }

            string fileName_rawGazeDataFile = controls.txt_rawGazeDataFile_visualizeTracking.Text;
            if (String.IsNullOrEmpty(fileName_rawGazeDataFile) || String.IsNullOrWhiteSpace(fileName_rawGazeDataFile) || !File.Exists(fileName_rawGazeDataFile))
            {

                controls.errorProvider_rawGazeDataFile_visualizeTracking.SetError(controls.txt_rawGazeDataFile_visualizeTracking, Constants.MESSAGE_SELECT_RAW_GAZE_DATA_FILE);
                errror = true;
            }

            else
            {
                controls.errorProvider_rawGazeDataFile_visualizeTracking.Clear();
                controls.errorProvider_rawGazeDataFile_visualizeTracking.SetError(controls.txt_rawGazeDataFile_visualizeTracking, "");
            }

            string fileName_experimentInterval = "";
            int participantNo = -1, frequency = -1;
            if (controls.cb_visualizeJustExpInterval_visualizeTracking.Checked)
            {
                fileName_experimentInterval = controls.txt_visualizeJustExpIntervalFileName_visualizeTracking.Text;
                if (String.IsNullOrEmpty(fileName_experimentInterval) || String.IsNullOrWhiteSpace(fileName_experimentInterval) || !File.Exists(fileName_experimentInterval))
                {

                    controls.errorProvider_visualizeJustExpIntervalFileName_visualizeTracking.SetError(controls.txt_visualizeJustExpIntervalFileName_visualizeTracking, Constants.MESSAGE_SELECT_RAW_GAZE_DATA_FILE);
                    errror = true;
                }

                else
                {
                    controls.errorProvider_visualizeJustExpIntervalFileName_visualizeTracking.Clear();
                    controls.errorProvider_visualizeJustExpIntervalFileName_visualizeTracking.SetError(controls.txt_visualizeJustExpIntervalFileName_visualizeTracking, "");
                }


                string participantNostr = controls.txt_visualizeJustExpIntervalParticipantNo_visualizeTracking.Text;

                if (String.IsNullOrEmpty(participantNostr) || String.IsNullOrWhiteSpace(participantNostr) || (!int.TryParse(participantNostr, out participantNo)))
                {
                    controls.errorProvider_visualizeJustExpIntervalParticipantNo_visualizeTracking.SetError(controls.txt_visualizeJustExpIntervalParticipantNo_visualizeTracking, Constants.MESSAGE_ENTER_POSITIVE_INTEGER_VALUE);
                    errror = true;
                }
                else
                {
                    controls.errorProvider_visualizeJustExpIntervalParticipantNo_visualizeTracking.Clear();
                    controls.errorProvider_visualizeJustExpIntervalParticipantNo_visualizeTracking.SetError(controls.txt_visualizeJustExpIntervalParticipantNo_visualizeTracking, "");
                }

                string frequencystr = controls.txt_visualizeJustExpIntervalFrequency_visualizeTracking.Text;

                if (String.IsNullOrEmpty(frequencystr) || String.IsNullOrWhiteSpace(frequencystr) || (!int.TryParse(frequencystr, out frequency)))
                {
                    controls.errorProvider_visualizeJustExpIntervalHz_visualizeTracking.SetError(controls.txt_visualizeJustExpIntervalFrequency_visualizeTracking, Constants.MESSAGE_ENTER_POSITIVE_INTEGER_VALUE);
                    errror = true;
                }
                else
                {
                    controls.errorProvider_visualizeJustExpIntervalHz_visualizeTracking.Clear();
                    controls.errorProvider_visualizeJustExpIntervalHz_visualizeTracking.SetError(controls.txt_visualizeJustExpIntervalFrequency_visualizeTracking, "");
                }
            }

            string fileName_aois = "";
            if (controls.txt_aois_visualizeTracking.Text != null && !String.IsNullOrEmpty(controls.txt_aois_visualizeTracking.Text))
            {
                fileName_aois = controls.txt_aois_visualizeTracking.Text;
                if (!File.Exists(fileName_aois))
                {

                    controls.errorProvider_aois_visualizeTracking.SetError(controls.txt_aois_visualizeTracking, Constants.MESSAGE_SELECT_EXISTING_AOI_FILE);
                    errror = true;
                }
            }

            else
            {
                controls.errorProvider_aois_visualizeTracking.Clear();
                controls.errorProvider_aois_visualizeTracking.SetError(controls.txt_aois_visualizeTracking, "");
            }


            string eyetrackerImageWidth = controls.txt_imageSizeEyeTrackerWidth_visualizeTracking.Text;
            string eyetrackerImageHeight = controls.txt_imageSizeEyeTrackerHeight_visualizeTracking.Text;
            int eye_tracker_width = 0, eye_tracker_height = 0;
            if (String.IsNullOrEmpty(eyetrackerImageWidth) || String.IsNullOrWhiteSpace(eyetrackerImageWidth) || (!int.TryParse(eyetrackerImageWidth, out eye_tracker_width)) ||
                 String.IsNullOrEmpty(eyetrackerImageHeight) || String.IsNullOrWhiteSpace(eyetrackerImageHeight) || (!int.TryParse(eyetrackerImageHeight, out eye_tracker_height)))
            {
                controls.errorProvider_imageSizeEyeTracker_visualizeTracking.SetError(controls.txt_imageSizeEyeTrackerHeight_visualizeTracking, Constants.MESSAGE_ENTER_EYE_TRACKER_IMAGE_RESOLUTION);
                errror = true;
            }
            else
            {
                controls.errorProvider_imageSizeEyeTracker_visualizeTracking.Clear();
                controls.errorProvider_imageSizeEyeTracker_visualizeTracking.SetError(controls.txt_imageSizeEyeTrackerHeight_visualizeTracking, "");
            }

            double confidenceThreshold = -1;
            if (controls.txt_confidenceThreshold_visualizeTracking.Text != null && !String.IsNullOrEmpty(controls.txt_confidenceThreshold_visualizeTracking.Text))
            {

                if (!double.TryParse(controls.txt_confidenceThreshold_visualizeTracking.Text, out confidenceThreshold))
                {
                    controls.errorProvider_confidenceThreshold_visualizeTracking.SetError(controls.txt_confidenceThreshold_visualizeTracking, Constants.MESSAGE_ENTER_NUMBER_BETWEEN_0_1);
                    errror = true;
                }
                else if (confidenceThreshold > 1 || confidenceThreshold < 0)
                {
                    controls.errorProvider_confidenceThreshold_visualizeTracking.SetError(controls.txt_confidenceThreshold_visualizeTracking, Constants.MESSAGE_ENTER_NUMBER_BETWEEN_0_1);
                    errror = true;
                }
            }
            else
            {
                controls.errorProvider_confidenceThreshold_visualizeTracking.Clear();
                controls.errorProvider_confidenceThreshold_visualizeTracking.SetError(controls.txt_confidenceThreshold_visualizeTracking, "");
            }



            string eyetrackerImageErrorWidth = controls.txt_errorSizeEyeTrackerWidth_visualizeTracking.Text;
            string eyetrackerImageErrorHeight = controls.txt_errorSizeEyeTrackerHeight_visualizeTracking.Text;
            double eye_tracker_error_width = -1, eye_tracker_error_height = -1;

            bool error_in_errorValue = false;
            if (!String.IsNullOrEmpty(eyetrackerImageErrorWidth) && !String.IsNullOrWhiteSpace(eyetrackerImageErrorWidth))
            {
                if (!double.TryParse(eyetrackerImageErrorWidth, out eye_tracker_error_width))
                {
                    controls.errorProvider_errorSizeEyeTracker_visualizeTracking.SetError(controls.txt_errorSizeEyeTrackerHeight_visualizeTracking, Constants.MESSAGE_ENTER_DOUBLE_VALUE);
                    errror = true;
                    error_in_errorValue = true;

                }

            }

            if (!String.IsNullOrEmpty(eyetrackerImageErrorHeight) && !String.IsNullOrWhiteSpace(eyetrackerImageErrorHeight))
            {
                if (!double.TryParse(eyetrackerImageErrorHeight, out eye_tracker_error_height))
                {
                    controls.errorProvider_errorSizeEyeTracker_visualizeTracking.SetError(controls.txt_errorSizeEyeTrackerHeight_visualizeTracking, Constants.MESSAGE_ENTER_DOUBLE_VALUE);
                    errror = true;
                    error_in_errorValue = true;
                }

            }
            if (!error_in_errorValue)
            {
                controls.errorProvider_errorSizeEyeTracker_visualizeTracking.Clear();
                controls.errorProvider_errorSizeEyeTracker_visualizeTracking.SetError(controls.txt_errorSizeEyeTrackerHeight_visualizeTracking, "");
            }




            if (errror)
                return;

            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\aoi_analysis\\OpenFaceFiles\\FeatureExtraction.exe";

                int startingFrameNo = 0, endingFrameNo = 0;

                if (controls.cb_visualizeJustExpInterval_visualizeTracking.Checked)
                {
                    Constants.ParticipantInfo participantInfo= Constants.ParticipantInfo.Single;
                    if (controls.rbOptionSingleParticipant_visualizeTracking.Checked) participantInfo = Constants.ParticipantInfo.Single;
                    else if (controls.rbOptionFirstParticipant_visualizeTracking.Checked) participantInfo = Constants.ParticipantInfo.First;
                    else if (controls.rbOptionSecondParticipant_visualizeTracking.Checked) participantInfo = Constants.ParticipantInfo.Second;

                    UtilityFunctions.findStartingEndingFrameNo(fileName_experimentInterval, participantNo, participantInfo, frequency, ref startingFrameNo, ref endingFrameNo);

                }


                string arguments = " -showResults " +
                                   " -f " + videoFileName +
                                   ((!String.IsNullOrEmpty(fileName) && !String.IsNullOrWhiteSpace(fileName)) ? (" -lf " + fileName) : " ") +
                                   ((!String.IsNullOrEmpty(fileName_rawGazeDataFile) && !String.IsNullOrWhiteSpace(fileName_rawGazeDataFile)) ? (" -tfd " + fileName_rawGazeDataFile) : " ") +
                                    ((!String.IsNullOrEmpty(fileName_aois) && !String.IsNullOrWhiteSpace(fileName_aois)) ? (" -aoi " + fileName_aois) : " ") +
                                    " -etiWidth " + eyetrackerImageWidth + " -etiHeight " + eyetrackerImageHeight +
                                    (confidenceThreshold == -1 ? "" : (" -confidence " + confidenceThreshold.ToString())) +
                                    (eye_tracker_error_width == -1 ? "" : (" -eteX " + eye_tracker_error_width.ToString())) +
                                    (eye_tracker_error_height == -1 ? "" : (" -eteY " + eye_tracker_error_height.ToString())) +
                                   (controls.cb_visualizeJustExpInterval_visualizeTracking.Checked ? (" -sf " + startingFrameNo + " -ef " + endingFrameNo) : "");

                startInfo.Arguments = arguments;
                //startInfo.CreateNoWindow = true;
                //startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                using (Process exeProcess = Process.Start(startInfo))
                {
                    exeProcess.WaitForExit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not start program " + ex);
            }
        }



        private void btn_browseVisualizeJustExpIntervalFileName_visualizeTracking_Click(object sender, EventArgs e)
        {
            controls.ofd_visualizeJustExpIntervalFileName_visualizeTracking.InitialDirectory = "c:\\";
            controls.ofd_visualizeJustExpIntervalFileName_visualizeTracking.Filter = "txt files (*.txt)|*.txt";
            // ofd_aviFile.FilterIndex = 2;
            controls.ofd_visualizeJustExpIntervalFileName_visualizeTracking.RestoreDirectory = true;

            DialogResult result = controls.ofd_visualizeJustExpIntervalFileName_visualizeTracking.ShowDialog();

            string fileName = controls.ofd_visualizeJustExpIntervalFileName_visualizeTracking.FileName;
            controls.txt_visualizeJustExpIntervalFileName_visualizeTracking.Text = fileName;
            //if (String.IsNullOrEmpty(fileName) || String.IsNullOrWhiteSpace(fileName))
            //{
            //    controls.errorProvider_visualizeJustExpIntervalFileName_visualizeTracking.SetError(controls.txt_visualizeJustExpIntervalFileName_visualizeTracking, Constants.MESSAGE_SELECT_EXPERIMENT_INTERVAL_FILE);
            //    return;
            //}
            //else
            //{
            //    controls.errorProvider_visualizeJustExpIntervalFileName_visualizeTracking.Clear();
            //    controls.errorProvider_visualizeJustExpIntervalFileName_visualizeTracking.SetError(controls.txt_visualizeJustExpIntervalFileName_visualizeTracking, "");
            //}
        }

        private void btn_browseaois_visualizeTracking_Click(object sender, EventArgs e)
        {
            controls.ofd_aois_visualizeTracking.InitialDirectory = "c:\\";
            controls.ofd_aois_visualizeTracking.Filter = "txt files (*.txt)|*.txt";
            // ofd_aviFile.FilterIndex = 2;
            controls.ofd_aois_visualizeTracking.RestoreDirectory = true;

            DialogResult result = controls.ofd_aois_visualizeTracking.ShowDialog();

            string fileName = controls.ofd_aois_visualizeTracking.FileName;
            controls.txt_aois_visualizeTracking.Text = fileName;
            //if (String.IsNullOrEmpty(fileName) || String.IsNullOrWhiteSpace(fileName))
            //{
            //    controls.errorProvider_aois_visualizeTracking.SetError(controls.txt_aois_visualizeTracking, Constants.MESSAGE_SELECT_AOI_FILE);
            //    return;
            //}
            //else
            //{
            //    controls.errorProvider_aois_visualizeTracking.Clear();
            //    controls.errorProvider_aois_visualizeTracking.SetError(controls.txt_aois_visualizeTracking, "");
            //}
        }

        private void btn_browseRawGazeDataFile_visualizeTracking_Click(object sender, EventArgs e)
        {
            controls.ofd_rawGazeDataFile_visualizeTracking.InitialDirectory = "c:\\";
            controls.ofd_rawGazeDataFile_visualizeTracking.Filter = "txt files (*.txt)|*.txt";
            // ofd_aviFile.FilterIndex = 2;
            controls.ofd_rawGazeDataFile_visualizeTracking.RestoreDirectory = true;

            DialogResult result = controls.ofd_rawGazeDataFile_visualizeTracking.ShowDialog();

            string fileName = controls.ofd_rawGazeDataFile_visualizeTracking.FileName;
            controls.txt_rawGazeDataFile_visualizeTracking.Text = fileName;
            if (String.IsNullOrEmpty(fileName) || String.IsNullOrWhiteSpace(fileName))
            {
                controls.errorProvider_rawGazeDataFile_visualizeTracking.SetError(controls.txt_rawGazeDataFile_visualizeTracking, Constants.MESSAGE_SELECT_RAW_GAZE_DATA_FILE);
                return;
            }
            else
            {
                controls.errorProvider_rawGazeDataFile_visualizeTracking.Clear();
                controls.errorProvider_rawGazeDataFile_visualizeTracking.SetError(controls.txt_rawGazeDataFile_visualizeTracking, "");
            }
        }

        private void btn_browse2dlandmark_visualizeTracking_Click(object sender, EventArgs e)
        {
            controls.ofd_2dlandmark_visualizeTracking.InitialDirectory = "c:\\";
            controls.ofd_2dlandmark_visualizeTracking.Filter = "txt files (*.txt)|*.txt";
            // ofd_aviFile.FilterIndex = 2;
            controls.ofd_2dlandmark_visualizeTracking.RestoreDirectory = true;

            DialogResult result = controls.ofd_2dlandmark_visualizeTracking.ShowDialog();

            string fileName = controls.ofd_2dlandmark_visualizeTracking.FileName;
            controls.txt_2dlandmark_visualizeTracking.Text = fileName;
            if (String.IsNullOrEmpty(fileName) || String.IsNullOrWhiteSpace(fileName))
            {
                controls.errorProvider_2dlandmark_visualizeTracking.SetError(controls.txt_2dlandmark_visualizeTracking, Constants.MESSAGE_SELECT_2dLANDMARK_FILE);
                return;
            }
            else
            {
                controls.errorProvider_2dlandmark_visualizeTracking.Clear();
                controls.errorProvider_2dlandmark_visualizeTracking.SetError(controls.txt_2dlandmark_visualizeTracking, "");
            }
        }

        private void btn_createOutputFile_labelROIManually_Click(object sender, EventArgs e)
        {
            controls.sfd_outputFile_labelROIManually.InitialDirectory = @"C:\";
            controls.sfd_outputFile_labelROIManually.Title = "Save text File";
            controls.sfd_outputFile_labelROIManually.FileName = "correctedFrames.txt";
            controls.sfd_outputFile_labelROIManually.CheckPathExists = true;
            controls.sfd_outputFile_labelROIManually.DefaultExt = "txt";
            controls.sfd_outputFile_labelROIManually.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            controls.sfd_outputFile_labelROIManually.FilterIndex = 2;
            controls.sfd_outputFile_labelROIManually.RestoreDirectory = true;

            if (controls.sfd_outputFile_labelROIManually.ShowDialog() == DialogResult.OK)
            {
                controls.txt_outputFile_labelROIManually.Text = controls.sfd_outputFile_labelROIManually.FileName;
            }
        }

        private void cb_visualizeJustExpInterval_labelROIManually_CheckedChanged(object sender, EventArgs e)
        {
            if (!controls.cb_visualizeJustExpInterval_labelROIManually.Checked)
                controls.pnl_visualizeJustExpInterval_labelROIManually.Enabled = false;
            else
                controls.pnl_visualizeJustExpInterval_labelROIManually.Enabled = true;
        }

        private void btn_labelROIManually_Click(object sender, EventArgs e)
        {

     

            bool errror = false;

            string outputFile = controls.txt_outputFile_labelROIManually.Text;
            if (String.IsNullOrEmpty(outputFile) || String.IsNullOrWhiteSpace(outputFile))
            {

                controls.errorProvider_outputFile_labelROIManually.SetError(controls.txt_outputFile_labelROIManually, Constants.MESSAGE_SELECT_OUTPUT_FILE);
                errror = true;
            }

            else
            {
                controls.errorProvider_outputFile_labelROIManually.Clear();
                controls.errorProvider_outputFile_labelROIManually.SetError(controls.txt_outputFile_labelROIManually, "");
            }


            string videoFileName = controls.txt_videoFile_labelROIManually.Text;
            if (String.IsNullOrEmpty(videoFileName) || String.IsNullOrWhiteSpace(videoFileName) || !File.Exists(videoFileName))
            {

                controls.errorProvider_videoFile_labelROIManually.SetError(controls.txt_videoFile_labelROIManually, Constants.MESSAGE_SELECT_AVI_FILE);
                errror = true;
            }

            else
            {
                controls.errorProvider_videoFile_labelROIManually.Clear();
                controls.errorProvider_videoFile_labelROIManually.SetError(controls.txt_videoFile_labelROIManually, "");
            }

            string fileName = controls.txt_2dlandmark_labelROIManually.Text;
            if (String.IsNullOrEmpty(fileName) || String.IsNullOrWhiteSpace(fileName) || !File.Exists(fileName))
            {

                controls.errorProvider_2dlandmark_labelROIManually.SetError(controls.txt_2dlandmark_labelROIManually, Constants.MESSAGE_SELECT_2dLANDMARK_FILE);
                errror = true;
            }

            else
            {
                controls.errorProvider_2dlandmark_labelROIManually.Clear();
                controls.errorProvider_2dlandmark_labelROIManually.SetError(controls.txt_2dlandmark_labelROIManually, "");
            }

            string fileName_rawGazeDataFile = controls.txt_rawGazeDataFile_labelROIManually.Text;
            if (String.IsNullOrEmpty(fileName_rawGazeDataFile) || String.IsNullOrWhiteSpace(fileName_rawGazeDataFile) || !File.Exists(fileName_rawGazeDataFile))
            {

                controls.errorProvider_rawGazeDataFile_labelROIManually.SetError(controls.txt_rawGazeDataFile_labelROIManually, Constants.MESSAGE_SELECT_RAW_GAZE_DATA_FILE);
                errror = true;
            }

            else
            {
                controls.errorProvider_rawGazeDataFile_labelROIManually.Clear();
                controls.errorProvider_rawGazeDataFile_labelROIManually.SetError(controls.txt_rawGazeDataFile_labelROIManually, "");
            }

            string fileName_experimentInterval = "";
            int participantNo = -1, frequency = -1;
            if (controls.cb_visualizeJustExpInterval_labelROIManually.Checked)
            {
                fileName_experimentInterval = controls.txt_visualizeJustExpIntervalFileName_labelROIManually.Text;
                if (String.IsNullOrEmpty(fileName_experimentInterval) || String.IsNullOrWhiteSpace(fileName_experimentInterval) || !File.Exists(fileName_experimentInterval))
                {

                    controls.errorProvider_visualizeJustExpIntervalFileName_labelROIManually.SetError(controls.txt_visualizeJustExpIntervalFileName_labelROIManually, Constants.MESSAGE_SELECT_RAW_GAZE_DATA_FILE);
                    errror = true;
                }

                else
                {
                    controls.errorProvider_visualizeJustExpIntervalFileName_labelROIManually.Clear();
                    controls.errorProvider_visualizeJustExpIntervalFileName_labelROIManually.SetError(controls.txt_visualizeJustExpIntervalFileName_labelROIManually, "");
                }


                string participantNostr = controls.txt_visualizeJustExpIntervalParticipantNo_labelROIManually.Text;

                if (String.IsNullOrEmpty(participantNostr) || String.IsNullOrWhiteSpace(participantNostr) || (!int.TryParse(participantNostr, out participantNo)))
                {
                    controls.errorProvider_visualizeJustExpIntervalParticipantNo_labelROIManually.SetError(controls.txt_visualizeJustExpIntervalParticipantNo_labelROIManually, Constants.MESSAGE_ENTER_POSITIVE_INTEGER_VALUE);
                    errror = true;
                }
                else
                {
                    controls.errorProvider_visualizeJustExpIntervalParticipantNo_labelROIManually.Clear();
                    controls.errorProvider_visualizeJustExpIntervalParticipantNo_labelROIManually.SetError(controls.txt_visualizeJustExpIntervalParticipantNo_labelROIManually, "");
                }

                string frequencystr = controls.txt_visualizeJustExpIntervalFrequency_labelROIManually.Text;

                if (String.IsNullOrEmpty(frequencystr) || String.IsNullOrWhiteSpace(frequencystr) || (!int.TryParse(frequencystr, out frequency)))
                {
                    controls.errorProvider_visualizeJustExpIntervalHz_labelROIManually.SetError(controls.txt_visualizeJustExpIntervalFrequency_labelROIManually, Constants.MESSAGE_ENTER_POSITIVE_INTEGER_VALUE);
                    errror = true;
                }
                else
                {
                    controls.errorProvider_visualizeJustExpIntervalHz_labelROIManually.Clear();
                    controls.errorProvider_visualizeJustExpIntervalHz_labelROIManually.SetError(controls.txt_visualizeJustExpIntervalFrequency_labelROIManually, "");
                }
            }

            string fileName_aois = "";
            if (controls.txt_aois_labelROIManually.Text != null && !String.IsNullOrEmpty(controls.txt_aois_labelROIManually.Text))
            {
                fileName_aois = controls.txt_aois_labelROIManually.Text;
                if (!File.Exists(fileName_aois))
                {

                    controls.errorProvider_aois_labelROIManually.SetError(controls.txt_aois_labelROIManually, Constants.MESSAGE_SELECT_EXISTING_AOI_FILE);
                    errror = true;
                }
            }

            else
            {
                controls.errorProvider_aois_labelROIManually.Clear();
                controls.errorProvider_aois_labelROIManually.SetError(controls.txt_aois_labelROIManually, "");
            }


            string eyetrackerImageWidth = controls.txt_imageSizeEyeTrackerWidth_labelROIManually.Text;
            string eyetrackerImageHeight = controls.txt_imageSizeEyeTrackerHeight_labelROIManually.Text;
            int eye_tracker_width = 0, eye_tracker_height = 0;
            if (String.IsNullOrEmpty(eyetrackerImageWidth) || String.IsNullOrWhiteSpace(eyetrackerImageWidth) || (!int.TryParse(eyetrackerImageWidth, out eye_tracker_width)) ||
                 String.IsNullOrEmpty(eyetrackerImageHeight) || String.IsNullOrWhiteSpace(eyetrackerImageHeight) || (!int.TryParse(eyetrackerImageHeight, out eye_tracker_height)))
            {
                controls.errorProvider_imageSizeEyeTracker_labelROIManually.SetError(controls.txt_imageSizeEyeTrackerHeight_labelROIManually, Constants.MESSAGE_ENTER_EYE_TRACKER_IMAGE_RESOLUTION);
                errror = true;
            }
            else
            {
                controls.errorProvider_imageSizeEyeTracker_labelROIManually.Clear();
                controls.errorProvider_imageSizeEyeTracker_labelROIManually.SetError(controls.txt_imageSizeEyeTrackerHeight_labelROIManually, "");
            }

            double confidenceThreshold = -1;
            if (controls.txt_confidenceThreshold_labelROIManually.Text != null && !String.IsNullOrEmpty(controls.txt_confidenceThreshold_labelROIManually.Text))
            {

                if (!double.TryParse(controls.txt_confidenceThreshold_labelROIManually.Text, out confidenceThreshold))
                {
                    controls.errorProvider_confidenceThreshold_labelROIManually.SetError(controls.txt_confidenceThreshold_labelROIManually, Constants.MESSAGE_ENTER_NUMBER_BETWEEN_0_1);
                    errror = true;
                }
                else if (confidenceThreshold > 1 || confidenceThreshold < 0)
                {
                    controls.errorProvider_confidenceThreshold_labelROIManually.SetError(controls.txt_confidenceThreshold_labelROIManually, Constants.MESSAGE_ENTER_NUMBER_BETWEEN_0_1);
                    errror = true;
                }
            }
            else
            {
                controls.errorProvider_confidenceThreshold_labelROIManually.Clear();
                controls.errorProvider_confidenceThreshold_labelROIManually.SetError(controls.txt_confidenceThreshold_labelROIManually, "");
            }



            string eyetrackerImageErrorWidth = controls.txt_errorSizeEyeTrackerWidth_labelROIManually.Text;
            string eyetrackerImageErrorHeight = controls.txt_errorSizeEyeTrackerHeight_labelROIManually.Text;
            double eye_tracker_error_width = -1, eye_tracker_error_height = -1;

            bool error_in_errorValue = false;
            if (!String.IsNullOrEmpty(eyetrackerImageErrorWidth) && !String.IsNullOrWhiteSpace(eyetrackerImageErrorWidth))
            {
                if (!double.TryParse(eyetrackerImageErrorWidth, out eye_tracker_error_width))
                {
                    controls.errorProvider_errorSizeEyeTracker_labelROIManually.SetError(controls.txt_errorSizeEyeTrackerHeight_labelROIManually, Constants.MESSAGE_ENTER_DOUBLE_VALUE);
                    errror = true;
                    error_in_errorValue = true;

                }

            }

            if (!String.IsNullOrEmpty(eyetrackerImageErrorHeight) && !String.IsNullOrWhiteSpace(eyetrackerImageErrorHeight))
            {
                if (!double.TryParse(eyetrackerImageErrorHeight, out eye_tracker_error_height))
                {
                    controls.errorProvider_errorSizeEyeTracker_labelROIManually.SetError(controls.txt_errorSizeEyeTrackerHeight_labelROIManually, Constants.MESSAGE_ENTER_DOUBLE_VALUE);
                    errror = true;
                    error_in_errorValue = true;
                }

            }
            if (!error_in_errorValue)
            {
                controls.errorProvider_errorSizeEyeTracker_labelROIManually.Clear();
                controls.errorProvider_errorSizeEyeTracker_labelROIManually.SetError(controls.txt_errorSizeEyeTrackerHeight_labelROIManually, "");
            }




            if (errror)
                return;

            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\aoi_analysis\\OpenFaceFiles\\FeatureExtraction.exe";

                int startingFrameNo = 0, endingFrameNo = 0;

                if (controls.cb_visualizeJustExpInterval_labelROIManually.Checked)
                {
                    Constants.ParticipantInfo participantInfo = Constants.ParticipantInfo.Single;
                    if (controls.rbOptionSingleParticipant_labelROIManually.Checked) participantInfo = Constants.ParticipantInfo.Single;
                    else if (controls.rbOptionFirstParticipant_labelROIManually.Checked) participantInfo = Constants.ParticipantInfo.First;
                    else if (controls.rbOptionSecondParticipant_labelROIManually.Checked) participantInfo = Constants.ParticipantInfo.Second;
                    UtilityFunctions.findStartingEndingFrameNo(fileName_experimentInterval, participantNo, participantInfo, frequency, ref startingFrameNo, ref endingFrameNo);

                }


                string arguments = " -manualAOILabeling " + " -cpf " + outputFile +
                                   " -f " + videoFileName +
                                   ((!String.IsNullOrEmpty(fileName) && !String.IsNullOrWhiteSpace(fileName)) ? (" -lf " + fileName) : " ") +
                                   ((!String.IsNullOrEmpty(fileName_rawGazeDataFile) && !String.IsNullOrWhiteSpace(fileName_rawGazeDataFile)) ? (" -tfd " + fileName_rawGazeDataFile) : " ") +
                                    ((!String.IsNullOrEmpty(fileName_aois) && !String.IsNullOrWhiteSpace(fileName_aois)) ? (" -aoi " + fileName_aois) : " ") +
                                    " -etiWidth " + eyetrackerImageWidth + " -etiHeight " + eyetrackerImageHeight +
                                    (confidenceThreshold == -1 ? "" : (" -confidence " + confidenceThreshold.ToString())) +
                                    (eye_tracker_error_width == -1 ? "" : (" -eteX " + eye_tracker_error_width.ToString())) +
                                    (eye_tracker_error_height == -1 ? "" : (" -eteY " + eye_tracker_error_height.ToString())) +
                                   (controls.cb_visualizeJustExpInterval_labelROIManually.Checked ? (" -sf " + startingFrameNo + " -ef " + endingFrameNo) : "");

                startInfo.Arguments = arguments;
                //startInfo.CreateNoWindow = true;
                //startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                using (Process exeProcess = Process.Start(startInfo))
                {
                    exeProcess.WaitForExit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not start program " + ex);
            }
        }

        private void btn_browseVisualizeJustExpIntervalFileName_labelROIManually_Click(object sender, EventArgs e)
        {
            controls.ofd_visualizeJustExpIntervalFileName_labelROIManually.InitialDirectory = "c:\\";
            controls.ofd_visualizeJustExpIntervalFileName_labelROIManually.Filter = "txt files (*.txt)|*.txt";
            // ofd_aviFile.FilterIndex = 2;
            controls.ofd_visualizeJustExpIntervalFileName_labelROIManually.RestoreDirectory = true;

            DialogResult result = controls.ofd_visualizeJustExpIntervalFileName_labelROIManually.ShowDialog();

            string fileName = controls.ofd_visualizeJustExpIntervalFileName_labelROIManually.FileName;
            controls.txt_visualizeJustExpIntervalFileName_labelROIManually.Text = fileName;
            //if (String.IsNullOrEmpty(fileName) || String.IsNullOrWhiteSpace(fileName))
            //{
            //    controls.errorProvider_visualizeJustExpIntervalFileName_labelROIManually.SetError(controls.txt_visualizeJustExpIntervalFileName_labelROIManually, Constants.MESSAGE_SELECT_EXPERIMENT_INTERVAL_FILE);
            //    return;
            //}
            //else
            //{
            //    controls.errorProvider_visualizeJustExpIntervalFileName_labelROIManually.Clear();
            //    controls.errorProvider_visualizeJustExpIntervalFileName_labelROIManually.SetError(controls.txt_visualizeJustExpIntervalFileName_labelROIManually, "");
            //}
        }

        private void btn_browseaois_labelROIManually_Click(object sender, EventArgs e)
        {
            controls.ofd_aois_labelROIManually.InitialDirectory = "c:\\";
            controls.ofd_aois_labelROIManually.Filter = "txt files (*.txt)|*.txt";
            // ofd_aviFile.FilterIndex = 2;
            controls.ofd_aois_labelROIManually.RestoreDirectory = true;

            DialogResult result = controls.ofd_aois_labelROIManually.ShowDialog();

            string fileName = controls.ofd_aois_labelROIManually.FileName;
            controls.txt_aois_labelROIManually.Text = fileName;
            //if (String.IsNullOrEmpty(fileName) || String.IsNullOrWhiteSpace(fileName))
            //{
            //    controls.errorProvider_aois_labelROIManually.SetError(controls.txt_aois_labelROIManually, Constants.MESSAGE_SELECT_AOI_FILE);
            //    return;
            //}
            //else
            //{
            //    controls.errorProvider_aois_labelROIManually.Clear();
            //    controls.errorProvider_aois_labelROIManually.SetError(controls.txt_aois_labelROIManually, "");
            //}
        }

        private void btn_browseRawGazeDataFile_labelROIManually_Click(object sender, EventArgs e)
        {
            controls.ofd_rawGazeDataFile_labelROIManually.InitialDirectory = "c:\\";
            controls.ofd_rawGazeDataFile_labelROIManually.Filter = "txt files (*.txt)|*.txt";
            // ofd_aviFile.FilterIndex = 2;
            controls.ofd_rawGazeDataFile_labelROIManually.RestoreDirectory = true;

            DialogResult result = controls.ofd_rawGazeDataFile_labelROIManually.ShowDialog();

            string fileName = controls.ofd_rawGazeDataFile_labelROIManually.FileName;
            controls.txt_rawGazeDataFile_labelROIManually.Text = fileName;
            if (String.IsNullOrEmpty(fileName) || String.IsNullOrWhiteSpace(fileName))
            {
                controls.errorProvider_rawGazeDataFile_labelROIManually.SetError(controls.txt_rawGazeDataFile_labelROIManually, Constants.MESSAGE_SELECT_RAW_GAZE_DATA_FILE);
                return;
            }
            else
            {
                controls.errorProvider_rawGazeDataFile_labelROIManually.Clear();
                controls.errorProvider_rawGazeDataFile_labelROIManually.SetError(controls.txt_rawGazeDataFile_labelROIManually, "");
            }
        }

        private void btn_browse2dlandmark_labelROIManually_Click(object sender, EventArgs e)
        {
            controls.ofd_2dlandmark_labelROIManually.InitialDirectory = "c:\\";
            controls.ofd_2dlandmark_labelROIManually.Filter = "txt files (*.txt)|*.txt";
            // ofd_aviFile.FilterIndex = 2;
            controls.ofd_2dlandmark_labelROIManually.RestoreDirectory = true;

            DialogResult result = controls.ofd_2dlandmark_labelROIManually.ShowDialog();

            string fileName = controls.ofd_2dlandmark_labelROIManually.FileName;
            controls.txt_2dlandmark_labelROIManually.Text = fileName;
            if (String.IsNullOrEmpty(fileName) || String.IsNullOrWhiteSpace(fileName))
            {
                controls.errorProvider_2dlandmark_labelROIManually.SetError(controls.txt_2dlandmark_labelROIManually, Constants.MESSAGE_SELECT_2dLANDMARK_FILE);
                return;
            }
            else
            {
                controls.errorProvider_2dlandmark_labelROIManually.Clear();
                controls.errorProvider_2dlandmark_labelROIManually.SetError(controls.txt_2dlandmark_labelROIManually, "");
            }
        }

        private void btn_browsevideoFile_labelROIManually_Click(object sender, EventArgs e)
        {
            controls.ofd_videoFile_labelROIManually.InitialDirectory = "c:\\";
            controls.ofd_videoFile_labelROIManually.Filter = "avi files (*.avi)|*.avi";
            // ofd_aviFile.FilterIndex = 2;
            controls.ofd_videoFile_labelROIManually.RestoreDirectory = true;

            DialogResult result = controls.ofd_videoFile_labelROIManually.ShowDialog();

            string fileName = controls.ofd_videoFile_labelROIManually.FileName;
            controls.txt_videoFile_labelROIManually.Text = fileName;
            if (String.IsNullOrEmpty(fileName) || String.IsNullOrWhiteSpace(fileName))
            {
                controls.errorProvider_videoFile_labelROIManually.SetError(controls.txt_videoFile_labelROIManually, Constants.MESSAGE_SELECT_AVI_FILE);
                return;
            }
            else
            {
                controls.errorProvider_videoFile_labelROIManually.Clear();
                controls.errorProvider_videoFile_labelROIManually.SetError(controls.txt_videoFile_labelROIManually, "");
            }
        }


        private void btn_analyse_reanalyzeAOI_Click(object sender, EventArgs e)
        {
            bool errror = false;
            string outputFileName = controls.txt_outputFile_reanalyzeAOI.Text;
            if (String.IsNullOrEmpty(outputFileName) || String.IsNullOrWhiteSpace(outputFileName))
            {
                controls.errorProvider_outputFile_reanalyzeAOI.SetError(controls.txt_outputFile_reanalyzeAOI, Constants.MESSAGE_SELECT_OUTPUT_FILE);
                errror = true;
            }
            else
            {
                controls.errorProvider_outputFile_reanalyzeAOI.Clear();
                controls.errorProvider_outputFile_reanalyzeAOI.SetError(controls.txt_outputFile_reanalyzeAOI, "");
            }

            string manuallyLabelledFileName = controls.txt_manuallyLabeled_reanalyzeAOI.Text;
            if (String.IsNullOrEmpty(outputFileName) || String.IsNullOrWhiteSpace(outputFileName))
            {
                controls.errorProvider_manuallyLabeled_reanalyzeAOI.SetError(controls.txt_manuallyLabeled_reanalyzeAOI, Constants.MESSAGE_SELECT_MANUALLY_LABELLED_AOIs_FILE);
                errror = true;
            }
            else
            {
                controls.errorProvider_manuallyLabeled_reanalyzeAOI.Clear();
                controls.errorProvider_manuallyLabeled_reanalyzeAOI.SetError(controls.txt_manuallyLabeled_reanalyzeAOI, "");
            }

            string rawGazeDataFileName = controls.txt_rawGazeDataFile_reanalyzeAOI.Text;
            if (String.IsNullOrEmpty(rawGazeDataFileName) || String.IsNullOrWhiteSpace(rawGazeDataFileName) || !File.Exists(rawGazeDataFileName))
            {
                controls.errorProvider_rawGazeDataFile_reanalyzeAOI.SetError(controls.txt_rawGazeDataFile_reanalyzeAOI, Constants.MESSAGE_SELECT_RAW_GAZE_DATA_FILE);
                errror = true;
            }
            else
            {
                controls.errorProvider_rawGazeDataFile_reanalyzeAOI.Clear();
                controls.errorProvider_rawGazeDataFile_reanalyzeAOI.SetError(controls.txt_rawGazeDataFile_reanalyzeAOI, "");
            }

            string landmarkFileName = controls.txt_2dlandmark_reanalyzeAOI.Text;
            if (String.IsNullOrEmpty(landmarkFileName) || String.IsNullOrWhiteSpace(landmarkFileName) || !File.Exists(landmarkFileName))
            {
                controls.errorProvider_2dlandmark_reanalyzeAOI.SetError(controls.txt_2dlandmark_reanalyzeAOI, Constants.MESSAGE_SELECT_2dLANDMARK_FILE);
                errror = true;
            }
            else
            {
                controls.errorProvider_2dlandmark_reanalyzeAOI.Clear();
                controls.errorProvider_2dlandmark_reanalyzeAOI.SetError(controls.txt_2dlandmark_reanalyzeAOI, "");
            }

            string imageSizeTrackingFrameworkFileName = controls.txt_imageSizeTrakingFramework_reanalyzeAOI.Text;
            if (String.IsNullOrEmpty(imageSizeTrackingFrameworkFileName) || String.IsNullOrWhiteSpace(imageSizeTrackingFrameworkFileName) || !File.Exists(imageSizeTrackingFrameworkFileName))
            {
                controls.errorProvider_imageSizeTrakingFramework_reanalyzeAOI.SetError(controls.txt_imageSizeTrakingFramework_reanalyzeAOI, Constants.MESSAGE_SELECT_IMAGE_SIZE_TRACKING_FRAMEWORK_FILE);
                errror = true;
            }
            else
            {
                controls.errorProvider_imageSizeTrakingFramework_reanalyzeAOI.Clear();
                controls.errorProvider_imageSizeTrakingFramework_reanalyzeAOI.SetError(controls.txt_imageSizeTrakingFramework_reanalyzeAOI, "");
            }

            string eyetrackerImageWidth = controls.txt_imageSizeEyeTrackerWidth_reanalyzeAOI.Text;
            string eyetrackerImageHeight = controls.txt_imageSizeEyeTrackerHeight_reanalyzeAOI.Text;
            int eye_tracker_width = 0, eye_tracker_height = 0;
            if (String.IsNullOrEmpty(eyetrackerImageWidth) || String.IsNullOrWhiteSpace(eyetrackerImageWidth) || (!int.TryParse(eyetrackerImageWidth, out eye_tracker_width)) ||
                 String.IsNullOrEmpty(eyetrackerImageHeight) || String.IsNullOrWhiteSpace(eyetrackerImageHeight) || (!int.TryParse(eyetrackerImageHeight, out eye_tracker_height)))
            {
                controls.errorProvider_imageSizeEyeTracker_reanalyzeAOI.SetError(controls.txt_imageSizeEyeTrackerHeight_reanalyzeAOI, Constants.MESSAGE_ENTER_EYE_TRACKER_IMAGE_RESOLUTION);
                errror = true;
            }
            else
            {
                controls.errorProvider_imageSizeEyeTracker_reanalyzeAOI.Clear();
                controls.errorProvider_imageSizeEyeTracker_reanalyzeAOI.SetError(controls.txt_imageSizeEyeTrackerHeight_reanalyzeAOI, "");
            }

            if (errror)
                return;


            System.IO.StreamReader file_2d_landmarks = new System.IO.StreamReader(landmarkFileName);
            System.IO.StreamReader file_gaze_raw_data = new System.IO.StreamReader(rawGazeDataFileName);
            System.IO.StreamReader file_image_size_trackingframework = new System.IO.StreamReader(imageSizeTrackingFrameworkFileName);

            if (file_image_size_trackingframework != null)
                file_image_size_trackingframework.ReadLine(); //skip header

            string[] tracking_framework_image_size;
            char[] delimiterChars = { ' ', '\t', ',' };
            tracking_framework_image_size = file_image_size_trackingframework.ReadLine().Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
            ImageConversion imageConversion = new ImageConversion(eye_tracker_width, eye_tracker_height, Convert.ToInt32(tracking_framework_image_size[0]), Convert.ToInt32(tracking_framework_image_size[1]));

            Constants.FilesForAOIDetection filesForAOIDetection = new Constants.FilesForAOIDetection(file_2d_landmarks, file_gaze_raw_data, manuallyLabelledFileName);
            string AOIs = UtilityFunctions.getAOIsofFile_OpenFace(filesForAOIDetection, imageConversion);

            file_2d_landmarks.Close();
            file_gaze_raw_data.Close();
            file_image_size_trackingframework.Close();

            System.IO.File.WriteAllText(outputFileName, AOIs);
            MessageBox.Show("Successfully Done!!");
        }

        private void btn_browseImageSizeTrakingFramework_reanalyzeAOI_Click(object sender, EventArgs e)
        {
            controls.ofd_imageSizeTrakingFramework_reanalyzeAOI.InitialDirectory = "c:\\";
            controls.ofd_imageSizeTrakingFramework_reanalyzeAOI.Filter = "txt files (*.txt)|*.txt";
            // ofd_aviFile.FilterIndex = 2;
            controls.ofd_imageSizeTrakingFramework_reanalyzeAOI.RestoreDirectory = true;

            DialogResult result = controls.ofd_imageSizeTrakingFramework_reanalyzeAOI.ShowDialog();

            string fileName = controls.ofd_imageSizeTrakingFramework_reanalyzeAOI.FileName;
            controls.txt_imageSizeTrakingFramework_reanalyzeAOI.Text = fileName;
            if (String.IsNullOrEmpty(fileName) || String.IsNullOrWhiteSpace(fileName))
            {
                controls.errorProvider_imageSizeTrakingFramework_reanalyzeAOI.SetError(controls.txt_imageSizeTrakingFramework_reanalyzeAOI, Constants.MESSAGE_SELECT_IMAGE_SIZE_TRACKING_FRAMEWORK_FILE);
                return;
            }
            else
            {
                controls.errorProvider_imageSizeTrakingFramework_reanalyzeAOI.Clear();
                controls.errorProvider_imageSizeTrakingFramework_reanalyzeAOI.SetError(controls.txt_imageSizeTrakingFramework_reanalyzeAOI, "");
            }
        }

        private void btn_browse2dlandmark_reanalyzeAOI_Click(object sender, EventArgs e)
        {
            controls.ofd_2dlandmark_reanalyzeAOI.InitialDirectory = "c:\\";
            controls.ofd_2dlandmark_reanalyzeAOI.Filter = "txt files (*.txt)|*.txt";
            // ofd_aviFile.FilterIndex = 2;
            controls.ofd_2dlandmark_reanalyzeAOI.RestoreDirectory = true;

            DialogResult result = controls.ofd_2dlandmark_reanalyzeAOI.ShowDialog();

            string fileName = controls.ofd_2dlandmark_reanalyzeAOI.FileName;
            controls.txt_2dlandmark_reanalyzeAOI.Text = fileName;
            if (String.IsNullOrEmpty(fileName) || String.IsNullOrWhiteSpace(fileName))
            {
                controls.errorProvider_2dlandmark_reanalyzeAOI.SetError(controls.txt_2dlandmark_reanalyzeAOI, Constants.MESSAGE_SELECT_2dLANDMARK_FILE);
                return;
            }
            else
            {
                controls.errorProvider_2dlandmark_reanalyzeAOI.Clear();
                controls.errorProvider_2dlandmark_reanalyzeAOI.SetError(controls.txt_2dlandmark_reanalyzeAOI, "");
            }
        }

        private void btn_browseRawGazeDataFile_reanalyzeAOI_Click(object sender, EventArgs e)
        {
            controls.ofd_rawGazeDataFile_reanalyzeAOI.InitialDirectory = "c:\\";
            controls.ofd_rawGazeDataFile_reanalyzeAOI.Filter = "txt files (*.txt)|*.txt";
            // ofd_aviFile.FilterIndex = 2;
            controls.ofd_rawGazeDataFile_reanalyzeAOI.RestoreDirectory = true;

            DialogResult result = controls.ofd_rawGazeDataFile_reanalyzeAOI.ShowDialog();

            string fileName = controls.ofd_rawGazeDataFile_reanalyzeAOI.FileName;
            controls.txt_rawGazeDataFile_reanalyzeAOI.Text = fileName;
            if (String.IsNullOrEmpty(fileName) || String.IsNullOrWhiteSpace(fileName))
            {
                controls.errorProvider_rawGazeDataFile_reanalyzeAOI.SetError(controls.txt_rawGazeDataFile_reanalyzeAOI, Constants.MESSAGE_SELECT_RAW_GAZE_DATA_FILE);
                return;
            }
            else
            {
                controls.errorProvider_rawGazeDataFile_reanalyzeAOI.Clear();
                controls.errorProvider_rawGazeDataFile_reanalyzeAOI.SetError(controls.txt_rawGazeDataFile_reanalyzeAOI, "");
            }
        }

        private void btn_browseManuallyLabeled_reanalyzeAOI_Click(object sender, EventArgs e)
        {
            controls.ofd_manuallyLabeled_reanalyzeAOI.InitialDirectory = "c:\\";
            controls.ofd_manuallyLabeled_reanalyzeAOI.Filter = "txt files (*.txt)|*.txt";
            // ofd_aviFile.FilterIndex = 2;
            controls.ofd_manuallyLabeled_reanalyzeAOI.RestoreDirectory = true;

            DialogResult result = controls.ofd_manuallyLabeled_reanalyzeAOI.ShowDialog();

            string fileName = controls.ofd_manuallyLabeled_reanalyzeAOI.FileName;
            controls.txt_manuallyLabeled_reanalyzeAOI.Text = fileName;
            if (String.IsNullOrEmpty(fileName) || String.IsNullOrWhiteSpace(fileName))
            {
                controls.errorProvider_manuallyLabeled_reanalyzeAOI.SetError(controls.txt_manuallyLabeled_reanalyzeAOI, Constants.MESSAGE_SELECT_MANUALLY_LABELLED_AOIs_FILE);
                return;
            }
            else
            {
                controls.errorProvider_manuallyLabeled_reanalyzeAOI.Clear();
                controls.errorProvider_manuallyLabeled_reanalyzeAOI.SetError(controls.txt_manuallyLabeled_reanalyzeAOI, "");
            }
        }

        private void btn_createOutputFile_reanalyzeAOI_Click(object sender, EventArgs e)
        {
            controls.sfd_outputFile_reanalyzeAOI.InitialDirectory = @"C:\";
            controls.sfd_outputFile_reanalyzeAOI.Title = "Save text File";
            controls.sfd_outputFile_reanalyzeAOI.FileName = "faceAsROI_mergedManual.txt";
            controls.sfd_outputFile_reanalyzeAOI.CheckPathExists = true;
            controls.sfd_outputFile_reanalyzeAOI.DefaultExt = "txt";
            controls.sfd_outputFile_reanalyzeAOI.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            controls.sfd_outputFile_reanalyzeAOI.FilterIndex = 2;
            controls.sfd_outputFile_reanalyzeAOI.RestoreDirectory = true;

            if (controls.sfd_outputFile_reanalyzeAOI.ShowDialog() == DialogResult.OK)
            {
                controls.txt_outputFile_reanalyzeAOI.Text = controls.sfd_outputFile_reanalyzeAOI.FileName;
            }
        }


        public void btn_gotoWalkthrough_visualizeTrackingResults_Click(object sender, EventArgs e)
        {
            controls.navigationListener.navigateToVisualizeTrackingResultsWalkthrough();
        }

        public void btn_gotoWalkthrough_findDetectionRatio_Click(object sender, EventArgs e)
        {
            controls.navigationListener.navigateToFindDetectionRatioWalkthrough();
        }

        public void btn_gotoWalkthrough_labelAOIMAnually_Click(object sender, EventArgs e)
        {
            controls.navigationListener.navigateToLabelAOIManuallyWalkthrough();
        }

        public void btn_gotoWalkthrough_reanalyseAOI_Click(object sender, EventArgs e)
        {
            controls.navigationListener.navigateToReanalyseAOIWalkthrough();
        }
    }
}