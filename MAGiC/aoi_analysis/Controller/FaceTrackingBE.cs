using System;
using System.Collections;
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
    public class FaceTrackingBE
    {
        private FaceTrackingUI controls;
        public FaceTrackingBE(FaceTrackingUI _controls)
        {
            controls = _controls;
            initialize();
        }

        public FaceTrackingBE()
        {
            initialize();

        }


        private void initialize()
        {

            //Face Tracking with Default Detector
            controls.btn_output_folder_trackingWithDefaultDetector.Click += new System.EventHandler(this.btn_output_folder_trackingWithDefaultDetector_Click);
            controls.btn_videoFile_trackingWithDefaultDetector.Click += new System.EventHandler(this.btn_videoFile_trackingWithDefaultDetector_Click);
            controls.btn_track_trackingWithDefaultDetector.Click += new System.EventHandler(this.btn_track_trackingWithDefaultDetector_Click);
            controls.btn_gotoWalkthrough_trackingWithDefaultDetector.Click += new System.EventHandler(this.btn_gotoWalkthrough_defaultDetector_Click);

            //Facetracking with trained detector
            controls.btn_output_folder_frames_trainedDetector.Click += new System.EventHandler(this.btn_output_folder_frames_trainedDetector_Click);
            controls.btn_videoFile_frames_trainedDetector.Click += new System.EventHandler(this.btn_videoFile_frames_trainedDetector_Click);
            controls.btn_exportFrames_trainedDetector.Click += new System.EventHandler(this.btn_exportFrames_trainedDetector_Click);

            controls.btn_output_folder_train_trainedDetector.Click += new System.EventHandler(this.btn_output_folder_train_trainedDetector_Click);
            controls.btn_training_trainedDetector.Click += new System.EventHandler(this.btn_training_trainedDetector_Click);
            controls.btn_output_folder_track_trainedDetector.Click += new System.EventHandler(this.btn_output_folder_track_trainedDetector_Click);
            controls.btn_track_trainedDetector.Click += new System.EventHandler(this.btn_track_trainedDetector_Click);
            controls.btn_gotoWalkthrough_trainedDetector.Click += new System.EventHandler(this.btn_gotoWalkthrough_trainedDetector_Click);
            controls.btn_movetoLeftList_trainedDetector.Click += new System.EventHandler(this.btn_movetoLeftList_trainedDetector_Click);
            controls.btn_movetoRightList_trainedDetector.Click += new System.EventHandler(this.btn_movetoRightList_trainedDetector_Click);



        }

        private void btn_movetoRightList_trainedDetector_Click(object sender, EventArgs e)
        {
            if (controls.lb_images_training_trainedDetector != null && controls.lb_images_training_trainedDetector.Items != null && controls.lb_images_training_trainedDetector.Items.Count > 0)
            {

                foreach (Constants.ImageFilesNameAndPath item in controls.lb_images_training_trainedDetector.SelectedItems)
                {
                    if (!controls.lb_images_test_trainedDetector.Items.Contains(item))
                    {
                            controls.lb_images_test_trainedDetector.Items.Add(item);
                        
                    }

                }

                sortListBox();
            }

        }

        private void sortListBox()
        {
            List<Constants.ImageFilesNameAndPath> allItemsSorted = new List<Constants.ImageFilesNameAndPath>();
            foreach (Constants.ImageFilesNameAndPath item in controls.lb_images_test_trainedDetector.Items)
            {

                int name = Convert.ToInt32(item.Name);
                if (allItemsSorted.Count > name)
                {
                    allItemsSorted.Insert(name, item);
                }
                else
                {
                    if (allItemsSorted.Count > 0)
                    {
                        if (Convert.ToInt32(allItemsSorted.Last().Name) > name)
                            allItemsSorted.Insert((allItemsSorted.Count - 1), item);
                        else
                            allItemsSorted.Add(item);
                    }

                    else
                    {
                        allItemsSorted.Add(item);
                    }
                }
           
            }
            controls.lb_images_test_trainedDetector.Items.Clear();

            foreach(Constants.ImageFilesNameAndPath item in allItemsSorted)
                controls.lb_images_test_trainedDetector.Items.Add(item);
        }

        private void btn_movetoLeftList_trainedDetector_Click(object sender, EventArgs e)
        {
            if (controls.lb_images_test_trainedDetector != null && controls.lb_images_test_trainedDetector.Items != null && controls.lb_images_test_trainedDetector.Items.Count > 0)
            {
                List<Constants.ImageFilesNameAndPath> allSelectedItems = new List<Constants.ImageFilesNameAndPath>();
                foreach (Constants.ImageFilesNameAndPath item in controls.lb_images_test_trainedDetector.SelectedItems)
                {
                    allSelectedItems.Add(item);
                    
                }
                foreach (Constants.ImageFilesNameAndPath item in allSelectedItems)
                    controls.lb_images_test_trainedDetector.Items.Remove(item);
            }
        }

        private void btn_track_trainedDetector_Click(object sender, EventArgs e)
        {
            bool errror = false;
            string fileName = controls.txt_videoFile_frames_trainedDetector.Text;
            if (String.IsNullOrEmpty(fileName) || String.IsNullOrWhiteSpace(fileName) || !File.Exists(fileName))
            {

                controls.errorProvider_videoFile_trainedDetector.SetError(controls.txt_videoFile_frames_trainedDetector, Constants.MESSAGE_SELECT_AVI_FILE);
                errror = true;
            }

            else
            {
                controls.errorProvider_videoFile_trainedDetector.Clear();
                controls.errorProvider_videoFile_trainedDetector.SetError(controls.txt_videoFile_frames_trainedDetector, "");
            }

            string folderName = controls.txt_output_folder_track_trainedDetector.Text;
            if (String.IsNullOrEmpty(folderName) || String.IsNullOrWhiteSpace(folderName) || !Directory.Exists(folderName))
            {

                controls.errorProvider_output_folder_track_trainedDetector.SetError(controls.txt_output_folder_track_trainedDetector, Constants.MESSAGE_SELECT_OUTPUT_FOLDER);
                errror = true;
            }

            else
            {
                controls.errorProvider_output_folder_track_trainedDetector.Clear();
                controls.errorProvider_output_folder_track_trainedDetector.SetError(controls.txt_output_folder_track_trainedDetector, "");
            }

            if (errror)
                return;

            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                //startInfo.FileName = @"C:\Users\ulku\Documents\Visual Studio 2015\Projects\FaceAndEyeDetection\FaceAndEyeDetection\bin\Debug\FaceAndEyeDetection.exe";
                startInfo.FileName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\aoi_analysis\\OpenFaceFiles\\FeatureExtraction.exe";

                string arguments = " -f " + fileName +
                                   " -outroot " + folderName +
                                   " -doTracking " + (controls.cb_visualizeDuringTracking_trainedDetector.Checked == true ? " 1 " : " 0 ") +
                                   " -detector " + controls.txt_output_folder_train_trainedDetector.Text + "\\face_detector.svm " +
                                   " -detectedFaces " + folderName + "\\detectedFaces.txt " +
                                   (controls.cb_2dLandmark_trainedDetector.Checked == true ? "" : " -no2Dfp ") +
                                   (controls.cb_3dLandmark_trainedDetector.Checked == true ? "" : " -no3Dfp ") +
                                   (controls.cb_AUs_trainedDetector.Checked == true ? "" : " -noAUs ") +
                                   //(controls.cb_gazeEstimation_trainedDetector.Checked == true ? "" : " -noGaze ") +
                                   //(controls.cb_modelParams_trainedDetector.Checked == true ? "" : " -noMparams ") +
                                   (controls.cb_pose_trackingWithDefaultDetector.Checked == true ? "" : " -noPose ")
                                     + " -noGaze -noMparams ";

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

        private void btn_output_folder_track_trainedDetector_Click(object sender, EventArgs e)
        {
            string folderName = "";

            DialogResult result = controls.fbd_output_folder_track_trainedDetector.ShowDialog();
            if (result == DialogResult.OK)
            {
                folderName = controls.fbd_output_folder_track_trainedDetector.SelectedPath;
                if (String.IsNullOrEmpty(folderName) || String.IsNullOrWhiteSpace(folderName))
                {

                    controls.errorProvider_output_folder_track_trainedDetector.SetError(controls.txt_output_folder_track_trainedDetector, Constants.MESSAGE_SELECT_OUTPUT_FOLDER);
                    return;
                }

                else
                {
                    controls.errorProvider_output_folder_track_trainedDetector.Clear();
                    controls.errorProvider_output_folder_track_trainedDetector.SetError(controls.txt_output_folder_track_trainedDetector, "");
                }


                controls.txt_output_folder_track_trainedDetector.Text = folderName;

    

            }
        }

        private void btn_training_trainedDetector_Click(object sender, EventArgs e)
        {
            bool errror = false;
            string destinationDirectoryTraining = "", destinationDirectoryTest = "";


            string folderName = controls.txt_output_folder_train_trainedDetector.Text;
            if (String.IsNullOrEmpty(folderName) || String.IsNullOrWhiteSpace(folderName) || !Directory.Exists(folderName))
            {

                controls.errorProvider_output_folder_train_trainedDetector.SetError(controls.txt_output_folder_train_trainedDetector, Constants.MESSAGE_SELECT_OUTPUT_FOLDER);
                errror = true;
            }

            else
            {
                controls.errorProvider_output_folder_train_trainedDetector.Clear();
                controls.errorProvider_output_folder_train_trainedDetector.SetError(controls.txt_output_folder_train_trainedDetector, "");
            }

            if (controls.lb_images_training_trainedDetector.SelectedItems == null || controls.lb_images_training_trainedDetector.SelectedItems.Count < 0)
            {
                controls.errorProvider_lb_images_training_trainedDetector.SetError(controls.lb_images_training_trainedDetector, Constants.MESSAGE_SELECT_TRAINING_IMAGE_FILE);
                return;
            }
            else
            {
                controls.errorProvider_lb_images_training_trainedDetector.Clear();
                controls.errorProvider_lb_images_training_trainedDetector.SetError(controls.lb_images_training_trainedDetector, "");
                destinationDirectoryTraining = folderName + "\\trainingImages";
                if (!Directory.Exists(destinationDirectoryTraining))
                {
                    Directory.CreateDirectory(destinationDirectoryTraining);
                }


                for (int i = 0; i < controls.lb_images_training_trainedDetector.SelectedItems.Count; i++)
                {
                    string fileToCopy = ((Constants.ImageFilesNameAndPath)controls.lb_images_training_trainedDetector.SelectedItems[i]).Path;
                    File.Copy(fileToCopy, destinationDirectoryTraining + "\\" + Path.GetFileName(fileToCopy), true);
                }
            }

            if (controls.lb_images_test_trainedDetector.SelectedItems == null || controls.lb_images_test_trainedDetector.SelectedItems.Count < 0)
            {
                controls.errorProvider_lb_images_test_trainedDetector.SetError(controls.lb_images_test_trainedDetector, Constants.MESSAGE_SELECT_TESTING_IMAGE_FILE);
                return;
            }
            else
            {
                controls.errorProvider_lb_images_test_trainedDetector.Clear();
                controls.errorProvider_lb_images_test_trainedDetector.SetError(controls.lb_images_test_trainedDetector, "");
                destinationDirectoryTest = folderName + "\\testImages";
                if (!Directory.Exists(destinationDirectoryTest))
                {
                    Directory.CreateDirectory(destinationDirectoryTest);
                }


                for (int i = 0; i < controls.lb_images_test_trainedDetector.SelectedItems.Count; i++)
                {
                    string fileToCopy = ((Constants.ImageFilesNameAndPath)controls.lb_images_test_trainedDetector.SelectedItems[i]).Path;
                    File.Copy(fileToCopy, destinationDirectoryTest + "\\" + Path.GetFileName(fileToCopy), true);
                }
            }

            if (errror)
                return;

            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();

                //---- Define training images
                startInfo.FileName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\aoi_analysis\\imglabFiles\\imglab.exe";
                string arguments = " -c " + folderName + "\\training.xml " + destinationDirectoryTraining;
                startInfo.Arguments = arguments;
                using (Process exeProcess = Process.Start(startInfo))
                {
                    exeProcess.WaitForExit();
                }

                //----Define test images
                arguments = " -c " + folderName + "\\test.xml " + destinationDirectoryTest;
                startInfo.Arguments = arguments;
                using (Process exeProcess = Process.Start(startInfo))
                {
                    exeProcess.WaitForExit();
                }


                //----Draw face boundary box
                arguments = folderName + "\\training.xml ";
                startInfo.Arguments = arguments;
                using (Process exeProcess = Process.Start(startInfo))
                {
                    exeProcess.WaitForExit();
                }


                //----Call detector for training and test trained model 
                arguments = "--detector " + folderName + " training.xml test.xml " + folderName + "\\face_detector.svm";
                startInfo.Arguments = arguments;
                using (Process exeProcess = Process.Start(startInfo))
                {
                    exeProcess.WaitForExit();
                }

                controls.gb_track_trainedDetector.Enabled = true;
                //controls.gb_train_trainedDetector.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not start program " + ex);
            }
        }

        private void btn_output_folder_train_trainedDetector_Click(object sender, EventArgs e)
        {
            string folderName = "";

            DialogResult result = controls.fbd_output_folder_train_trainedDetector.ShowDialog();
            if (result == DialogResult.OK)
            {
                folderName = controls.fbd_output_folder_train_trainedDetector.SelectedPath;
                if (String.IsNullOrEmpty(folderName) || String.IsNullOrWhiteSpace(folderName))
                {

                    controls.errorProvider_output_folder_train_trainedDetector.SetError(controls.txt_output_folder_train_trainedDetector, Constants.MESSAGE_SELECT_OUTPUT_FOLDER);
                    return;
                }

                else
                {
                    controls.errorProvider_output_folder_train_trainedDetector.Clear();
                    controls.errorProvider_output_folder_train_trainedDetector.SetError(controls.txt_output_folder_train_trainedDetector, "");
                    string destinationDirectoryTraining = folderName + "\\trainingImages";
                    string destinationDirectoryTest = folderName + "\\testImages";
                    if (Directory.Exists(destinationDirectoryTraining))
                    {
                        foreach (string file in Directory.GetFiles(destinationDirectoryTraining))
                        {
                            int index = controls.lb_images_training_trainedDetector.FindStringExact(Path.GetFileNameWithoutExtension(file));
                            if (index != -1)
                                controls.lb_images_training_trainedDetector.SetSelected(index, true);
                        }



                    }

                    if (Directory.Exists(destinationDirectoryTraining))
                    {
                        foreach (string file in Directory.GetFiles(destinationDirectoryTest))
                        {
                            int index = controls.lb_images_test_trainedDetector.FindStringExact(Path.GetFileNameWithoutExtension(file));
                            if (index != -1)
                                controls.lb_images_test_trainedDetector.SetSelected(index, true);
                        }
                    }
                }


                controls.txt_output_folder_train_trainedDetector.Text = folderName;

            }
        }

        private void btn_exportFrames_trainedDetector_Click(object sender, EventArgs e)
        {
            bool errror = false;
            string fileName = controls.txt_videoFile_frames_trainedDetector.Text;
            if (String.IsNullOrEmpty(fileName) || String.IsNullOrWhiteSpace(fileName) || !File.Exists(fileName))
            {

                controls.errorProvider_videoFile_trainedDetector.SetError(controls.txt_videoFile_frames_trainedDetector, Constants.MESSAGE_SELECT_AVI_FILE);
                errror = true;
            }

            else
            {
                controls.errorProvider_videoFile_trainedDetector.Clear();
                controls.errorProvider_videoFile_trainedDetector.SetError(controls.txt_videoFile_frames_trainedDetector, "");
            }

            string folderName = controls.txt_output_folder_frames_trainedDetector.Text;
            if (String.IsNullOrEmpty(folderName) || String.IsNullOrWhiteSpace(folderName) || !Directory.Exists(folderName))
            {

                controls.errorProvider_output_folder_frames_trainedDetector.SetError(controls.txt_output_folder_frames_trainedDetector, Constants.MESSAGE_SELECT_OUTPUT_FOLDER);
                errror = true;
            }

            else
            {
                controls.errorProvider_output_folder_frames_trainedDetector.Clear();
                controls.errorProvider_output_folder_frames_trainedDetector.SetError(controls.txt_output_folder_frames_trainedDetector, "");
            }

            if (errror)
                return;

            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                //startInfo.FileName = @"C:\Users\ulku\Documents\Visual Studio 2015\Projects\FaceAndEyeDetection\FaceAndEyeDetection\bin\Debug\FaceAndEyeDetection.exe";
                startInfo.FileName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\aoi_analysis\\OpenFaceFiles\\FeatureExtraction.exe";

                string arguments = " -exportFrames " + fileName + " " + folderName;
                startInfo.Arguments = arguments;
                //startInfo.CreateNoWindow = true;
                //startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                using (Process exeProcess = Process.Start(startInfo))
                {
                    exeProcess.WaitForExit();
                }
                controls.gb_train_trainedDetector.Enabled = true;
                //controls.gb_exportframes_trainedDetector.Enabled = false;
                loadExportedImages(folderName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not start program " + ex);
            }

        }

        private void loadExportedImages(string folderName)
        {


            controls.lb_images_training_trainedDetector.Items.Clear();
            controls.lb_images_test_trainedDetector.Items.Clear();
            IOrderedEnumerable<FileSystemInfo> fileSystemInfos = new DirectoryInfo(folderName).GetFileSystemInfos("*.png").OrderBy(fs => int.Parse(fs.Name.Split('.')[0]));

            foreach (FileSystemInfo f in fileSystemInfos)
            {
                controls.lb_images_training_trainedDetector.Items.Add(new Constants.ImageFilesNameAndPath(Path.GetFileNameWithoutExtension(f.FullName), f.FullName));
                controls.lb_images_test_trainedDetector.Items.Add(new Constants.ImageFilesNameAndPath(Path.GetFileNameWithoutExtension(f.FullName), f.FullName));
            }

        }

        private void btn_videoFile_frames_trainedDetector_Click(object sender, EventArgs e)
        {
            string fileName = "";

            controls.ofd_videoFile_frames_trainedDetector.InitialDirectory = "c:\\";
            controls.ofd_videoFile_frames_trainedDetector.Filter = "avi files (*.avi)|*.avi";
            controls.ofd_videoFile_frames_trainedDetector.FilterIndex = 2;
            controls.ofd_videoFile_frames_trainedDetector.RestoreDirectory = true;

            DialogResult result = controls.ofd_videoFile_frames_trainedDetector.ShowDialog();
            if (result == DialogResult.OK)
            {
                fileName = controls.ofd_videoFile_frames_trainedDetector.FileName;
                if (String.IsNullOrEmpty(fileName) || String.IsNullOrWhiteSpace(fileName))
                {

                    controls.errorProvider_videoFile_trainedDetector.SetError(controls.txt_videoFile_frames_trainedDetector, Constants.MESSAGE_SELECT_AVI_FILE);
                    return;
                }

                else
                {
                    controls.errorProvider_videoFile_trainedDetector.Clear();
                    controls.errorProvider_videoFile_trainedDetector.SetError(controls.txt_videoFile_frames_trainedDetector, "");
                }
                controls.txt_videoFile_frames_trainedDetector.Text = fileName;

            }
        }

        private void btn_output_folder_frames_trainedDetector_Click(object sender, EventArgs e)
        {
            string folderName = "";

            DialogResult result = controls.fbd_output_folder_frames_trainedDetector.ShowDialog();
            if (result == DialogResult.OK)
            {
                folderName = controls.fbd_output_folder_frames_trainedDetector.SelectedPath;
                if (String.IsNullOrEmpty(folderName) || String.IsNullOrWhiteSpace(folderName))
                {

                    controls.errorProvider_output_folder_frames_trainedDetector.SetError(controls.txt_output_folder_frames_trainedDetector, Constants.MESSAGE_SELECT_OUTPUT_FOLDER);
                    return;
                }

                else
                {
                    controls.errorProvider_output_folder_frames_trainedDetector.Clear();
                    controls.errorProvider_output_folder_frames_trainedDetector.SetError(controls.txt_output_folder_frames_trainedDetector, "");
                }


                controls.txt_output_folder_frames_trainedDetector.Text = folderName;

            }

        }

        private void btn_track_trackingWithDefaultDetector_Click(object sender, EventArgs e)
        {
            bool errror = false;
            string fileName = controls.txt_videoFile_trackingWithDefaultDetector.Text;
            if (String.IsNullOrEmpty(fileName) || String.IsNullOrWhiteSpace(fileName) || !File.Exists(fileName))
            {

                controls.errorProvider_videoFile_trackingWithDefaultDetector.SetError(controls.txt_videoFile_trackingWithDefaultDetector, Constants.MESSAGE_SELECT_AVI_FILE);
                errror = true;
            }

            else
            {
                controls.errorProvider_videoFile_trackingWithDefaultDetector.Clear();
                controls.errorProvider_videoFile_trackingWithDefaultDetector.SetError(controls.txt_videoFile_trackingWithDefaultDetector, "");
            }

            string folderName = controls.txt_output_folder_trackingWithDefaultDetector.Text;
            if (String.IsNullOrEmpty(folderName) || String.IsNullOrWhiteSpace(folderName) || !Directory.Exists(folderName))
            {

                controls.errorProvider_output_folder_trackingWithDefaultDetector.SetError(controls.txt_output_folder_trackingWithDefaultDetector, Constants.MESSAGE_SELECT_OUTPUT_FOLDER);
                errror = true;
            }

            else
            {
                controls.errorProvider_output_folder_trackingWithDefaultDetector.Clear();
                controls.errorProvider_output_folder_trackingWithDefaultDetector.SetError(controls.txt_output_folder_trackingWithDefaultDetector, "");
            }

            if (errror)
                return;

            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                //startInfo.FileName = @"C:\Users\ulku\Documents\Visual Studio 2015\Projects\FaceAndEyeDetection\FaceAndEyeDetection\bin\Debug\FaceAndEyeDetection.exe";
                startInfo.FileName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\aoi_analysis\\OpenFaceFiles\\FeatureExtraction.exe";

                string arguments = " -f " + controls.txt_videoFile_trackingWithDefaultDetector.Text +
                                   " -outroot " + controls.txt_output_folder_trackingWithDefaultDetector.Text +
                                   " -doTracking " + (controls.cb_visualizeDuringTracking_trackingWithDefaultDetector.Checked == true ? " 1 " : " 0 ") +
                                   " -detectedFaces " + controls.txt_output_folder_trackingWithDefaultDetector.Text + "\\detectedFaces.txt " +
                                   (controls.cb_2dLandmark_trackingWithDefaultDetector.Checked == true ? "" : " -no2Dfp ") +
                                   (controls.cb_3dLandmark_trackingWithDefaultDetector.Checked == true ? "" : " -no3Dfp ") +
                                   (controls.cb_AUs_trackingWithDefaultDetector.Checked == true ? "" : " -noAUs ") +
                                   //(controls.cb_gazeEstimation_trackingWithDefaultDetector.Checked == true ? "" : " -noGaze ") +
                                   //(controls.cb_modelParams_trackingWithDefaultDetector.Checked == true ? "" : " -noMparams ") +
                                   (controls.cb_pose_trackingWithDefaultDetector.Checked == true ? "" : " -noPose ")
                                   + " -noGaze -noMparams ";
                //MessageBox.Show("FileName: " + startInfo.FileName);
                //MessageBox.Show("Parameters: " + arguments);

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

        private void btn_videoFile_trackingWithDefaultDetector_Click(object sender, EventArgs e)
        {
            string fileName = "";

            controls.ofd_videoFile_trackingWithDefaultDetector.InitialDirectory = "c:\\";
            controls.ofd_videoFile_trackingWithDefaultDetector.Filter = "avi files (*.avi)|*.avi";
            controls.ofd_videoFile_trackingWithDefaultDetector.FilterIndex = 2;
            controls.ofd_videoFile_trackingWithDefaultDetector.RestoreDirectory = true;

            DialogResult result = controls.ofd_videoFile_trackingWithDefaultDetector.ShowDialog();
            if (result == DialogResult.OK)
            {
                fileName = controls.ofd_videoFile_trackingWithDefaultDetector.FileName;
                if (String.IsNullOrEmpty(fileName) || String.IsNullOrWhiteSpace(fileName))
                {

                    controls.errorProvider_videoFile_trackingWithDefaultDetector.SetError(controls.txt_videoFile_trackingWithDefaultDetector, Constants.MESSAGE_SELECT_AVI_FILE);
                    return;
                }

                else
                {
                    controls.errorProvider_videoFile_trackingWithDefaultDetector.Clear();
                    controls.errorProvider_videoFile_trackingWithDefaultDetector.SetError(controls.txt_videoFile_trackingWithDefaultDetector, "");
                }
                controls.txt_videoFile_trackingWithDefaultDetector.Text = fileName;

            }
        }

        private void btn_output_folder_trackingWithDefaultDetector_Click(object sender, EventArgs e)
        {
            string folderName = "";

            DialogResult result = controls.fbd_output_folder_trackingWithDefaultDetector.ShowDialog();
            if (result == DialogResult.OK)
            {
                folderName = controls.fbd_output_folder_trackingWithDefaultDetector.SelectedPath;
                if (String.IsNullOrEmpty(folderName) || String.IsNullOrWhiteSpace(folderName))
                {

                    controls.errorProvider_output_folder_trackingWithDefaultDetector.SetError(controls.txt_output_folder_trackingWithDefaultDetector, Constants.MESSAGE_SELECT_OUTPUT_FOLDER);
                    return;
                }

                else
                {
                    controls.errorProvider_output_folder_trackingWithDefaultDetector.Clear();
                    controls.errorProvider_output_folder_trackingWithDefaultDetector.SetError(controls.txt_output_folder_trackingWithDefaultDetector, "");
                }


                controls.txt_output_folder_trackingWithDefaultDetector.Text = folderName;

            }
        }

        public void btn_gotoWalkthrough_defaultDetector_Click(object sender, EventArgs e)
        {
            controls.navigationListener.navigateToFaceTrackingWithDefaultDetectorWalkthrough();
        }

        public void btn_gotoWalkthrough_trainedDetector_Click(object sender, EventArgs e)
        {
            controls.navigationListener.navigateToFaceTrackingWithTrainedDetectorWalkthrough();
        }
    }
}
