using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAGiC
{
    public class DetectROIBE
    {

        private DetectROIUI controls;
        public DetectROIBE(DetectROIUI _controls)
        {
            controls = _controls;
            initialize();
        }

        public DetectROIBE()
        {
            initialize();

        }


        private void initialize()
        {

            //Pre-process Gaze Data
            controls.btn_createOutputFile_preProcessGazeData.Click += new System.EventHandler(this.btn_createOutputFile_preProcessGazeData_Click);
            controls.btn_browseRawGazeDataFile_preProcessGazeData.Click += new System.EventHandler(this.btn_browseRawGazeDataFile_preProcessGazeData_Click);
            controls.btn_fillGap_preProcessGazeData.Click += new System.EventHandler(this.btn_fillGap_preProcessGazeData_Click);
            controls.btn_gotoWalkthrough_preProcessGazeData.Click += new System.EventHandler(this.btn_gotoWalkthrough_preProcessGazeData_Click);

            //Face As ROI
            controls.btn_createOutputFile_faceAsROI.Click += new System.EventHandler(this.btn_createOutputFile_faceAsROI_Click);
            controls.btn_browseRawGazeDataFile_faceAsROI.Click += new System.EventHandler(this.btn_browseRawGazeDataFile_faceAsROI_Click);
            controls.btn_browse2dlandmark_faceAsROI.Click += new System.EventHandler(this.btn_browse2dlandmark_faceAsROI_Click);
            controls.btn_browseImageSizeTrakingFramework_faceAsROI.Click += new System.EventHandler(this.btn_browseImageSizeTrakingFramework_faceAsROI_Click);
            controls.btn_analyse_faceAsROI.Click += new System.EventHandler(this.btn_analyse_faceAsROI_Click);
            controls.btn_gotoWalkthrough_faceAsROI.Click += new System.EventHandler(this.btn_gotoWalkthrough_faceAsAOI_Click);
        }

        private void btn_browseImageSizeTrakingFramework_faceAsROI_Click(object sender, EventArgs e)
        {
            controls.ofd_imageSizeTrakingFramework_faceAsROI.InitialDirectory = "c:\\";
            controls.ofd_imageSizeTrakingFramework_faceAsROI.Filter = "txt files (*.txt)|*.txt";
            // ofd_aviFile.FilterIndex = 2;
            controls.ofd_imageSizeTrakingFramework_faceAsROI.RestoreDirectory = true;

            DialogResult result = controls.ofd_imageSizeTrakingFramework_faceAsROI.ShowDialog();

            string fileName = controls.ofd_imageSizeTrakingFramework_faceAsROI.FileName;
            controls.txt_imageSizeTrakingFramework_faceAsROI.Text = fileName;
            if (String.IsNullOrEmpty(fileName) || String.IsNullOrWhiteSpace(fileName))
            {
                controls.errorProvider_imageSizeTrakingFramework_faceAsROI.SetError(controls.txt_imageSizeTrakingFramework_faceAsROI, Constants.MESSAGE_SELECT_IMAGE_SIZE_TRACKING_FRAMEWORK_FILE);
                return;
            }
            else
            {
                controls.errorProvider_imageSizeTrakingFramework_faceAsROI.Clear();
                controls.errorProvider_imageSizeTrakingFramework_faceAsROI.SetError(controls.txt_imageSizeTrakingFramework_faceAsROI, "");
            }
        }

        private void btn_analyse_faceAsROI_Click(object sender, EventArgs e)
        {
            bool errror = false;
            string outputFileName = controls.txt_outputFile_faceAsROI.Text;
            if (String.IsNullOrEmpty(outputFileName) || String.IsNullOrWhiteSpace(outputFileName))
            {
                controls.errorProvider_outputFile_faceAsROI.SetError(controls.txt_outputFile_faceAsROI, Constants.MESSAGE_SELECT_OUTPUT_FILE);
                errror = true;
            }
            else
            {
                controls.errorProvider_outputFile_faceAsROI.Clear();
                controls.errorProvider_outputFile_faceAsROI.SetError(controls.txt_outputFile_faceAsROI, "");
            }

            string rawGazeDataFileName = controls.txt_rawGazeDataFile_faceAsROI.Text;
            if (String.IsNullOrEmpty(rawGazeDataFileName) || String.IsNullOrWhiteSpace(rawGazeDataFileName) || !File.Exists(rawGazeDataFileName))
            {
                controls.errorProvider_rawGazeDataFile_faceAsROI.SetError(controls.txt_rawGazeDataFile_faceAsROI, Constants.MESSAGE_SELECT_RAW_GAZE_DATA_FILE);
                errror = true;
            }
            else
            {
                controls.errorProvider_rawGazeDataFile_faceAsROI.Clear();
                controls.errorProvider_rawGazeDataFile_faceAsROI.SetError(controls.txt_rawGazeDataFile_faceAsROI, "");
            }

            string landmarkFileName = controls.txt_2dlandmark_faceAsROI.Text;
            if (String.IsNullOrEmpty(landmarkFileName) || String.IsNullOrWhiteSpace(landmarkFileName) || !File.Exists(landmarkFileName))
            {
                controls.errorProvider_2dlandmark_faceAsROI.SetError(controls.txt_2dlandmark_faceAsROI, Constants.MESSAGE_SELECT_2dLANDMARK_FILE);
                errror = true;
            }
            else
            {
                controls.errorProvider_2dlandmark_faceAsROI.Clear();
                controls.errorProvider_2dlandmark_faceAsROI.SetError(controls.txt_2dlandmark_faceAsROI, "");
            }

            string imageSizeTrackingFrameworkFileName = controls.txt_imageSizeTrakingFramework_faceAsROI.Text;
            if (String.IsNullOrEmpty(imageSizeTrackingFrameworkFileName) || String.IsNullOrWhiteSpace(imageSizeTrackingFrameworkFileName) || !File.Exists(imageSizeTrackingFrameworkFileName))
            {
                controls.errorProvider_imageSizeTrakingFramework_faceAsROI.SetError(controls.txt_imageSizeTrakingFramework_faceAsROI, Constants.MESSAGE_SELECT_IMAGE_SIZE_TRACKING_FRAMEWORK_FILE);
                errror = true;
            }
            else
            {
                controls.errorProvider_imageSizeTrakingFramework_faceAsROI.Clear();
                controls.errorProvider_imageSizeTrakingFramework_faceAsROI.SetError(controls.txt_imageSizeTrakingFramework_faceAsROI, "");
            }

            string eyetrackerImageWidth = controls.txt_imageSizeEyeTrackerWidth_faceAsROI.Text;
            string eyetrackerImageHeight = controls.txt_imageSizeEyeTrackerHeight_faceAsROI.Text;
            int eye_tracker_width = 0, eye_tracker_height = 0;
            if (String.IsNullOrEmpty(eyetrackerImageWidth) || String.IsNullOrWhiteSpace(eyetrackerImageWidth) || (!int.TryParse(eyetrackerImageWidth, out eye_tracker_width)) ||
                 String.IsNullOrEmpty(eyetrackerImageHeight) || String.IsNullOrWhiteSpace(eyetrackerImageHeight) || (!int.TryParse(eyetrackerImageHeight, out eye_tracker_height)))
            {
                controls.errorProvider_imageSizeEyeTracker_faceAsROI.SetError(controls.txt_imageSizeEyeTrackerHeight_faceAsROI, Constants.MESSAGE_ENTER_EYE_TRACKER_IMAGE_RESOLUTION);
                errror = true;
            }
            else
            {
                controls.errorProvider_imageSizeEyeTracker_faceAsROI.Clear();
                controls.errorProvider_imageSizeEyeTracker_faceAsROI.SetError(controls.txt_imageSizeEyeTrackerHeight_faceAsROI, "");
            }

            string eyetrackerImageErrorWidth = controls.txt_errorSizeEyeTrackerWidth_faceAsROI.Text;
            string eyetrackerImageErrorHeight = controls.txt_errorSizeEyeTrackerHeight_faceAsROI.Text;
            double eye_tracker_error_width = -1, eye_tracker_error_height = -1;

            bool error_in_errorValue = false;
            if (!String.IsNullOrEmpty(eyetrackerImageErrorWidth) && !String.IsNullOrWhiteSpace(eyetrackerImageErrorWidth))
            {
                if (!double.TryParse(eyetrackerImageErrorWidth, out eye_tracker_error_width))
                {
                    controls.errorProvider_errorSizeEyeTracker_visualizeTracking.SetError(controls.txt_errorSizeEyeTrackerHeight_faceAsROI, Constants.MESSAGE_ENTER_DOUBLE_VALUE);
                    errror = true;
                    error_in_errorValue = true;

                }

            }

            if (!String.IsNullOrEmpty(eyetrackerImageErrorHeight) && !String.IsNullOrWhiteSpace(eyetrackerImageErrorHeight))
            {
                if (!double.TryParse(eyetrackerImageErrorHeight, out eye_tracker_error_height))
                {
                    controls.errorProvider_errorSizeEyeTracker_visualizeTracking.SetError(controls.txt_errorSizeEyeTrackerHeight_faceAsROI, Constants.MESSAGE_ENTER_DOUBLE_VALUE);
                    errror = true;
                    error_in_errorValue = true;
                }

            }
            if (!error_in_errorValue)
            {
                controls.errorProvider_errorSizeEyeTracker_visualizeTracking.Clear();
                controls.errorProvider_errorSizeEyeTracker_visualizeTracking.SetError(controls.txt_errorSizeEyeTrackerHeight_faceAsROI, "");
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
            if (eye_tracker_error_width != -1 || eye_tracker_error_height != -1)
                imageConversion.set_errors_of_eye_tracker(eye_tracker_error_width<=0?0: eye_tracker_error_width, eye_tracker_error_height<=0?0:eye_tracker_error_height);

            Constants.FilesForAOIDetection filesForAOIDetection = new Constants.FilesForAOIDetection(file_2d_landmarks, file_gaze_raw_data);
            string AOIs = UtilityFunctions.getAOIsofFile_OpenFace(filesForAOIDetection, imageConversion);

            file_2d_landmarks.Close();
            file_gaze_raw_data.Close();
            file_image_size_trackingframework.Close();

            System.IO.File.WriteAllText(outputFileName, AOIs);
            MessageBox.Show("Successfully Done!!");
        }

        


        private void btn_browse2dlandmark_faceAsROI_Click(object sender, EventArgs e)
        {
            controls.ofd_2dlandmark_faceAsROI.InitialDirectory = "c:\\";
            controls.ofd_2dlandmark_faceAsROI.Filter = "txt files (*.txt)|*.txt";
            // ofd_aviFile.FilterIndex = 2;
            controls.ofd_2dlandmark_faceAsROI.RestoreDirectory = true;

            DialogResult result = controls.ofd_2dlandmark_faceAsROI.ShowDialog();

            string fileName = controls.ofd_2dlandmark_faceAsROI.FileName;
            controls.txt_2dlandmark_faceAsROI.Text = fileName;
            if (String.IsNullOrEmpty(fileName) || String.IsNullOrWhiteSpace(fileName))
            {
                controls.errorProvider_2dlandmark_faceAsROI.SetError(controls.txt_2dlandmark_faceAsROI, Constants.MESSAGE_SELECT_2dLANDMARK_FILE);
                return;
            }
            else
            {
                controls.errorProvider_2dlandmark_faceAsROI.Clear();
                controls.errorProvider_2dlandmark_faceAsROI.SetError(controls.txt_2dlandmark_faceAsROI, "");
            }
        }

        private void btn_browseRawGazeDataFile_faceAsROI_Click(object sender, EventArgs e)
        {
            controls.ofd_rawGazeDataFile_faceAsROI.InitialDirectory = "c:\\";
            controls.ofd_rawGazeDataFile_faceAsROI.Filter = "txt files (*.txt)|*.txt";
            // ofd_aviFile.FilterIndex = 2;
            controls.ofd_rawGazeDataFile_faceAsROI.RestoreDirectory = true;

            DialogResult result = controls.ofd_rawGazeDataFile_faceAsROI.ShowDialog();

            string fileName = controls.ofd_rawGazeDataFile_faceAsROI.FileName;
            controls.txt_rawGazeDataFile_faceAsROI.Text = fileName;
            if (String.IsNullOrEmpty(fileName) || String.IsNullOrWhiteSpace(fileName))
            {
                controls.errorProvider_rawGazeDataFile_faceAsROI.SetError(controls.txt_rawGazeDataFile_faceAsROI, Constants.MESSAGE_SELECT_RAW_GAZE_DATA_FILE);
                return;
            }
            else
            {
                controls.errorProvider_rawGazeDataFile_faceAsROI.Clear();
                controls.errorProvider_rawGazeDataFile_faceAsROI.SetError(controls.txt_rawGazeDataFile_faceAsROI, "");
            }
        }

        private void btn_createOutputFile_faceAsROI_Click(object sender, EventArgs e)
        {
            controls.sfd_outputFile_faceAsROI.InitialDirectory = @"C:\";
            controls.sfd_outputFile_faceAsROI.Title = "Save text File";
            controls.sfd_outputFile_faceAsROI.FileName = "faceAsROI.txt";
            controls.sfd_outputFile_faceAsROI.CheckPathExists = true;
            controls.sfd_outputFile_faceAsROI.DefaultExt = "txt";
            controls.sfd_outputFile_faceAsROI.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            controls.sfd_outputFile_faceAsROI.FilterIndex = 2;
            controls.sfd_outputFile_faceAsROI.RestoreDirectory = true;

            if (controls.sfd_outputFile_faceAsROI.ShowDialog() == DialogResult.OK)
            {
                controls.txt_outputFile_faceAsROI.Text = controls.sfd_outputFile_faceAsROI.FileName;
            }
        }

        private void btn_fillGap_preProcessGazeData_Click(object sender, EventArgs e)
        {
            bool errror = false;
            string outputFileName = controls.txt_outputFile_preProcessGazeData.Text;
            if (String.IsNullOrEmpty(outputFileName) || String.IsNullOrWhiteSpace(outputFileName))
            {
                controls.errorProvider_outputFile_preProcessGazeData.SetError(controls.txt_outputFile_preProcessGazeData, Constants.MESSAGE_SELECT_OUTPUT_FILE);
                errror = true;
            }
            else
            {
                controls.errorProvider_outputFile_preProcessGazeData.Clear();
                controls.errorProvider_outputFile_preProcessGazeData.SetError(controls.txt_outputFile_preProcessGazeData, "");
            }

            string rawGazeDataFileName = controls.txt_rawGazeDataFile_preProcessGazeData.Text;
            if (String.IsNullOrEmpty(rawGazeDataFileName) || String.IsNullOrWhiteSpace(rawGazeDataFileName) || !File.Exists(rawGazeDataFileName))
            {
                controls.errorProvider_rawGazeDataFile_preProcessGazeData.SetError(controls.txt_rawGazeDataFile_preProcessGazeData, Constants.MESSAGE_SELECT_RAW_GAZE_DATA_FILE);
                errror = true;
            }
            else
            {
                controls.errorProvider_rawGazeDataFile_preProcessGazeData.Clear();
                controls.errorProvider_rawGazeDataFile_preProcessGazeData.SetError(controls.txt_rawGazeDataFile_preProcessGazeData, "");
            }

            string maxGapLength = controls.txt_maxGapLength_preProcessGazeData.Text;
            int id = 0;
            if (String.IsNullOrEmpty(maxGapLength) || String.IsNullOrWhiteSpace(maxGapLength)
                || (!int.TryParse(maxGapLength, out id)))
            {
                controls.errorProvider_maxGapLength_preProcessGazeData.SetError(controls.txt_maxGapLength_preProcessGazeData, Constants.MESSAGE_ENTER_POSITIVE_INTEGER_VALUE);
                errror = true;
            }
            else
            {
                controls.errorProvider_maxGapLength_preProcessGazeData.Clear();
                controls.errorProvider_maxGapLength_preProcessGazeData.SetError(controls.txt_maxGapLength_preProcessGazeData, "");
            }

            if (errror)
                return;

            try
            {
                string ratio=fillGap();
                MessageBox.Show("Succesfully done!!\n" + ratio);
            }
            catch (Exception ex)
            {

            }
        }

        private string fillGap()
        {
            try
            {
                System.IO.StreamReader file_rawGazeData = new System.IO.StreamReader(controls.txt_rawGazeDataFile_preProcessGazeData.Text);

                string outputFile = controls.txt_outputFile_preProcessGazeData.Text;
                char[] delimiterChars = { ' ', '\t', ',' };
                string fixation_type = "", raw_x = "", raw_y = "";
                int frame_num = 0, last_valid_frame_num = 1000000;
                string line_rawGazeData = "";
                string[] words_rawGazeData_file;
                string write_rawGazeData_to_modifiedFile = "";
                string last_valid_raw_x = "", last_valid_raw_y = "";
                int gapDuration = 0;
                List<int> frame_index_of_gaps = new List<int>();
                int total_frame_no = 0, filled_gaps_no = 0;

                int maxGapLength = Convert.ToInt32(controls.txt_maxGapLength_preProcessGazeData.Text);
                maxGapLength++; //kafa karışıklığını önlemek için 3 derse 3 tane boşluk doldurur gibi.1dolu, 2 boş,3 boş, 4 dolu 4-1 =3 amaslında amacımız 2 tane max boşluğa izn vermekse 

                while ((line_rawGazeData = file_rawGazeData.ReadLine()) != null)
                {
                    total_frame_no++;
                    words_rawGazeData_file = line_rawGazeData.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
                    frame_num = Convert.ToInt32(words_rawGazeData_file[0]);

                    fixation_type = words_rawGazeData_file[1];

                    if (fixation_type == Constants.EyeTrackerNotEmptyLineTxt)
                    {
                        raw_x = words_rawGazeData_file[2];
                        raw_y = words_rawGazeData_file[3];
                        gapDuration = (frame_num - last_valid_frame_num);
                        if (gapDuration > 1 && gapDuration <= maxGapLength)
                        {
                            int fillGapwith_x = 0, fillGapwith_y = 0;

                            foreach (int indexGaps in frame_index_of_gaps)
                            {
                                double c = (indexGaps - last_valid_frame_num);
                                double scaleFactor = (c / gapDuration);
                                fillGapwith_x = (int)Math.Round(((scaleFactor * (Convert.ToInt32(raw_x) - Convert.ToInt32(last_valid_raw_x))) + Convert.ToInt32(last_valid_raw_x)), MidpointRounding.AwayFromZero);
                                fillGapwith_y = (int)Math.Round(((scaleFactor * (Convert.ToInt32(raw_y) - Convert.ToInt32(last_valid_raw_y))) + Convert.ToInt32(last_valid_raw_y)), MidpointRounding.AwayFromZero);
                                write_rawGazeData_to_modifiedFile += indexGaps + " " + Constants.EyeTrackerNotEmptyLineTxt + " " + fillGapwith_x + " " + fillGapwith_y + "\n";
                                filled_gaps_no++;
                            }


                            frame_index_of_gaps = new List<int>();
                        }
                        else if (gapDuration > maxGapLength)
                        {
                            foreach (int indexGaps in frame_index_of_gaps)
                            {
                                write_rawGazeData_to_modifiedFile += indexGaps + " " + Constants.EyeTrackerEmptyLineTxt + " " + "\n";
                            }
                            frame_index_of_gaps = new List<int>(); //bu gap dolmaz
                        }

                        write_rawGazeData_to_modifiedFile += line_rawGazeData + "\n";


                        last_valid_raw_x = raw_x;
                        last_valid_raw_y = raw_y;
                        last_valid_frame_num = frame_num;

                    }
                    else if (fixation_type == Constants.EyeTrackerEmptyLineTxt)
                    {

                        if (last_valid_frame_num == 1000000) //unclassifiedla başladı ise direk dosyaya öyle yaz
                            write_rawGazeData_to_modifiedFile += frame_num + " " + Constants.EyeTrackerEmptyLineTxt + " " + "\n";
                        else
                            frame_index_of_gaps.Add(frame_num);
                    }

                }


                if (frame_index_of_gaps.Count > 0)
                {

                    foreach (int indexGaps in frame_index_of_gaps)
                    {
                        write_rawGazeData_to_modifiedFile += indexGaps + " " + Constants.EyeTrackerEmptyLineTxt + " " + "\n";
                    }
                    frame_index_of_gaps = new List<int>(); //bu gap dolmaz
                }
                System.IO.File.WriteAllText(outputFile, write_rawGazeData_to_modifiedFile);

                file_rawGazeData.Close();

                string showOutcomes = "";
                showOutcomes += " Number of Filled Raw Data:" + filled_gaps_no + "\n Number of Total Frame:" + total_frame_no + "\n Ratio of Filled:" + Math.Round(((double)filled_gaps_no / (double)total_frame_no) * 100, 2) + "\n\n";
                return showOutcomes;

            }
            catch (Exception ex)
            {


                throw ex;
            }
        }

        private void btn_browseRawGazeDataFile_preProcessGazeData_Click(object sender, EventArgs e)
        {
            controls.ofd_rawGazeDataFile_preProcessGazeData.InitialDirectory = "c:\\";
            controls.ofd_rawGazeDataFile_preProcessGazeData.Filter = "txt files (*.txt)|*.txt";
            // ofd_aviFile.FilterIndex = 2;
            controls.ofd_rawGazeDataFile_preProcessGazeData.RestoreDirectory = true;

            DialogResult result = controls.ofd_rawGazeDataFile_preProcessGazeData.ShowDialog();

            string fileName = controls.ofd_rawGazeDataFile_preProcessGazeData.FileName;
            controls.txt_rawGazeDataFile_preProcessGazeData.Text = fileName;
            if (String.IsNullOrEmpty(fileName) || String.IsNullOrWhiteSpace(fileName))
            {
                controls.errorProvider_rawGazeDataFile_preProcessGazeData.SetError(controls.txt_rawGazeDataFile_preProcessGazeData, Constants.MESSAGE_SELECT_RAW_GAZE_DATA_FILE);
                return;
            }
            else
            {
                controls.errorProvider_rawGazeDataFile_preProcessGazeData.Clear();
                controls.errorProvider_rawGazeDataFile_preProcessGazeData.SetError(controls.txt_rawGazeDataFile_preProcessGazeData, "");
            }
        }

        private void btn_createOutputFile_preProcessGazeData_Click(object sender, EventArgs e)
        {

            controls.sfd_outputFile_preProcessGazeData.InitialDirectory = @"C:\";
            controls.sfd_outputFile_preProcessGazeData.Title = "Save text File";
            controls.sfd_outputFile_preProcessGazeData.FileName = "gapFilledRawGazeData.txt";
            controls.sfd_outputFile_preProcessGazeData.CheckPathExists = true;
            controls.sfd_outputFile_preProcessGazeData.DefaultExt = "txt";
            controls.sfd_outputFile_preProcessGazeData.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            controls.sfd_outputFile_preProcessGazeData.FilterIndex = 2;
            controls.sfd_outputFile_preProcessGazeData.RestoreDirectory = true;

            if (controls.sfd_outputFile_preProcessGazeData.ShowDialog() == DialogResult.OK)
            {
                controls.txt_outputFile_preProcessGazeData.Text = controls.sfd_outputFile_preProcessGazeData.FileName;
            }
        }

        public void btn_gotoWalkthrough_preProcessGazeData_Click(object sender, EventArgs e)
        {
            controls.navigationListener.navigateToPreProcessGazeDataWalkthrough();
        }

        public void btn_gotoWalkthrough_faceAsAOI_Click(object sender, EventArgs e)
        {
            controls.navigationListener.navigateToDetectAOIWalkthrough();
        }
    }
}
