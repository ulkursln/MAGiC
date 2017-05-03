using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAGiC
{
    public class AOIAnalysisWalkthroughUI : ParentUI
    {
        public AOIAnalysisWalkthroughBE aoia;


        public AOIAnalysisWalkthroughUI(INavigationListener _navigationListener) : base(_navigationListener) { }

        public void initializeController()
        {
            aoia = new AOIAnalysisWalkthroughBE(this);
        }

        #region Face Tracking with default detector controls*/
        /**********************************************************************************************/
        public Label lbl_infotext_trackingWithDefaultDetector = new Label
        {
            Text = Info.TEXT_INFO,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_INFOTEXT

        };

        public Label lbl_stepstext_trackingWithDefaultDetector = new Label
        {
            Text = Info.TEXT_STEPS,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPSTEXT

        };

        public Label lbl_info_trackingWithDefaultDetector = new Label
        {
            Text = Info.INFO_AOI_TRACKINGWITHDEFAULTDETECTOR,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_INFO

        };

        public Label lbl_steps_1_trackingWithDefaultDetector = new Label
        {
            Text = Info.STEPS_OUTPUTFOLDER_AOI_TRACKINGWITHDEFAULTDETECTOR,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_steps_2_trackingWithDefaultDetector = new Label
        {
            Text = Info.STEPS_AVI_AOI_TRACKINGWITHDEFAULTDETECTOR,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_steps_3_trackingWithDefaultDetector = new Label
        {
            Text = Info.STEPS_VISUALIZEDURING_AOI_TRACKINGWITHDEFAULTDETECTOR,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_steps_4_trackingWithDefaultDetector = new Label
        {
            Text = Info.STEPS_CHECKOUTPUTFILES_AOI_TRACKINGWITHDEFAULTDETECTOR,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_steps_5_trackingWithDefaultDetector = new Label
        {
            Text = Info.STEPS_TRACKBUTTON_AOI_TRACKINGWITHDEFAULTDETECTOR,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_outputstext_trackingWithDefaultDetector = new Label
        {
            Text = Info.TEXT_OUTPUT,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_OUTPUTTEXT

        };

        public Label lbl_outputs_1_trackingWithDefaultDetector = new Label
        {
            Text = Info.OUTPUT_2dLANDMARK_AOI_TRACKINGWITHDEFAULTDETECTOR,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_OUTPUT

        };

        public Label lbl_outputs_2_trackingWithDefaultDetector = new Label
        {
            Text = Info.OUTPUT_3dLANDMARK_AOI_TRACKINGWITHDEFAULTDETECTOR,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_OUTPUT

        };

        public Label lbl_outputs_3_trackingWithDefaultDetector = new Label
        {
            Text = Info.OUTPUT_IMAGESIZEFILE_AOI_TRACKINGWITHDEFAULTDETECTOR,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_OUTPUT

        };

        public Label lbl_outputs_4_trackingWithDefaultDetector = new Label
        {
            Text = Info.OUTPUT_ESTIMATEDPOSE_AOI_TRACKINGWITHDEFAULTDETECTOR,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_OUTPUT

        };

        public Label lbl_outputs_5_trackingWithDefaultDetector = new Label
        {
            Text = Info.OUTPUT_ACTIONUNIT_AOI_TRACKINGWITHDEFAULTDETECTOR,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_OUTPUT

        };

        public Label lbl_sample_outputfolder_trackingwithdefaultdetector = new LinkLabel
        {
            Text = Info.SAMPLE_OUTPUTFOLDER_EXTRACTANDFORMAT,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };

        public LinkLabel linklbl_sample_avi_aoi_trackingwithdefaultdetector = new LinkLabel
        {
            Text = Info.SAMPLE_AVI_AOI_TRACKINGWITHDEFAULTDETECTOR,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };
        public LinkLabel linklbl_sample_output_2dlandmark_aoi_trackingwithdefaultdetector = new LinkLabel
        {
            Text = Info.SAMPLE_OUTPUT_2dLANDMARK_AOI_TRACKINGWITHDEFAULTDETECTOR,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };

        public LinkLabel linklbl_sample_output_3dlandmark_aoi_trackingwithdefaultdetector = new LinkLabel
        {
            Text = Info.SAMPLE_OUTPUT_3dLANDMARK_AOI_TRACKINGWITHDEFAULTDETECTOR,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };

        public LinkLabel linklbl_sample_output_imagesizefile_aoi_trackingwithdefaultdetector = new LinkLabel
        {
            Text = Info.SAMPLE_OUTPUT_IMAGESIZEFILE_AOI_TRACKINGWITHDEFAULTDETECTOR,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };

        public LinkLabel linklbl_sample_output_estimatedpose_aoi_trackingwithdefaultdetector = new LinkLabel
        {
            Text = Info.SAMPLE_OUTPUT_ESTIMATEDPOSE_AOI_TRACKINGWITHDEFAULTDETECTOR,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };

        public LinkLabel linklbl_sample_output_actionunit_aoi_trackingwithdefaultdetector = new LinkLabel
        {
            Text = Info.SAMPLE_OUTPUT_ACTIONUNIT_AOI_TRACKINGWITHDEFAULTDETECTOR,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };


        public Button btn_gotoFunction_home_trackingWithDefaultDetector_AOIAnalysis = new Button { Text = Info.TEXT_BUTTON_GOTOHOME, AutoSize = true, BackColor = Color.AliceBlue, Font = new Font("Arial", 10, FontStyle.Bold) };
        public Button btn_gotoFunction_trackingWithDefaultDetector_AOIAnalysis = new Button { Text = Info.TEXT_BUTTON_GOTOFUNCTION, AutoSize = true, BackColor = Color.AliceBlue, Font = new Font("Arial", 10, FontStyle.Bold) };
        #endregion


        #region Face Tracking with trained detector controls*/
        /**********************************************************************************************/
        public Label lbl_infotext_trackingWithTrainedDetector = new Label
        {
            Text = Info.TEXT_INFO,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_INFOTEXT

        };

        public Label lbl_stepstext_trackingWithTrainedDetector = new Label
        {
            Text = Info.TEXT_STEPS,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPSTEXT

        };

        public Label lbl_info_trackingWithTrainedDetector = new Label
        {
            Text = Info.INFO_AOI_TRACKINGWITHTRAINEDDETECTOR,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_INFO

        };

        public Label lbl_steps_1_trackingWithTrainedDetector = new Label
        {
            Text = Info.STEPS_EXTRACT_AOI_TRACKINGWITHTRAINEDDETECTOR,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_steps_11_trackingWithTrainedDetector = new Label
        {
            Text = Info.STEPS_EXTRACT_INNER1_AOI_TRACKINGWITHTRAINEDDETECTOR,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_steps_12_trackingWithTrainedDetector = new Label
        {
            Text = Info.STEPS_EXTRACT_INNER2_AOI_TRACKINGWITHTRAINEDDETECTOR,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_steps_13_trackingWithTrainedDetector = new Label
        {
            Text = Info.STEPS_EXTRACT_INNER3_AOI_TRACKINGWITHTRAINEDDETECTOR,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };


        public Label lbl_steps_2_trackingWithTrainedDetector = new Label
        {
            Text = Info.STEPS_TRAINING_AOI_TRACKINGWITHTRAINEDDETECTOR,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_steps_21_trackingWithTrainedDetector = new Label
        {
            Text = Info.STEPS_TRAINING_INNER1_AOI_TRACKINGWITHTRAINEDDETECTOR,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_steps_22_trackingWithTrainedDetector = new Label
        {
            Text = Info.STEPS_TRAINING_INNER2_AOI_TRACKINGWITHTRAINEDDETECTOR,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_steps_23_trackingWithTrainedDetector = new Label
        {
            Text = Info.STEPS_TRAINING_INNER3_AOI_TRACKINGWITHTRAINEDDETECTOR,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_steps_24_trackingWithTrainedDetector = new Label
        {
            Text = Info.STEPS_TRAINING_INNER4_AOI_TRACKINGWITHTRAINEDDETECTOR,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_steps_25_trackingWithTrainedDetector = new Label
        {
            Text = Info.STEPS_TRAINING_INNER5_AOI_TRACKINGWITHTRAINEDDETECTOR,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_steps_26_trackingWithTrainedDetector = new Label
        {
            Text = Info.STEPS_TRAINING_INNER6_AOI_TRACKINGWITHTRAINEDDETECTOR,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_steps_3_trackingWithTrainedDetector = new Label
        {
            Text = Info.STEPS_TRACKING_AOI_TRACKINGWITHTRAINEDDETECTOR,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_steps_31_trackingWithTrainedDetector = new Label
        {
            Text = Info.STEPS_TRACKING_INNER1_AOI_TRACKINGWITHTRAINEDDETECTOR,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_steps_32_trackingWithTrainedDetector = new Label
        {
            Text = Info.STEPS_TRACKING_INNER2_AOI_TRACKINGWITHTRAINEDDETECTOR,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_steps_33_trackingWithTrainedDetector = new Label
        {
            Text = Info.STEPS_TRACKING_INNER3_AOI_TRACKINGWITHTRAINEDDETECTOR,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_steps_34_trackingWithTrainedDetector = new Label
        {
            Text = Info.STEPS_TRACKING_INNER4_AOI_TRACKINGWITHTRAINEDDETECTOR,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };


        public Label lbl_outputstext_trackingWithTrainedDetector = new Label
        {
            Text = Info.TEXT_OUTPUT,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_OUTPUTTEXT

        };

        public Label lbl_outputs_1_trackingWithTrainedDetector = new Label
        {
            Text = Info.OUTPUT_FRAMES_EXTRACT_AOI_TRACKINGWITHTRAINEDDETECTOR,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_OUTPUT

        };

        public Label lbl_outputs_2_trackingWithTrainedDetector = new Label
        {
            Text = Info.OUTPUT_FACEDETECTOR_AOI_TRACKINGWITHTRAINEDDETECTOR,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_OUTPUT

        };

        public Label lbl_outputs_3_trackingWithTrainedDetector = new Label
        {
            Text = Info.OUTPUT_2dLANDMARK_AOI_TRACKINGWITHTRAINEDDETECTOR,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_OUTPUT

        };

        public Label lbl_outputs_4_trackingWithTrainedDetector = new Label
        {
            Text = Info.OUTPUT_3dLANDMARK_AOI_TRACKINGWITHTRAINEDDETECTOR,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_OUTPUT

        };

        public Label lbl_outputs_5_trackingWithTrainedDetector = new Label
        {
            Text = Info.OUTPUT_IMAGESIZEFILE_AOI_TRACKINGWITHTRAINEDDETECTOR,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_OUTPUT

        };

        public Label lbl_outputs_6_trackingWithTrainedDetector = new Label
        {
            Text = Info.OUTPUT_ESTIMATEDPOSE_AOI_TRACKINGWITHTRAINEDDETECTOR,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_OUTPUT

        };

        public Label lbl_outputs_7_trackingWithTrainedDetector = new Label
        {
            Text = Info.OUTPUT_ACTIONUNIT_AOI_TRACKINGWITHTRAINEDDETECTOR,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_OUTPUT

        };

        public Label lbl_sample_outputfolder_extract_aoi_trackingwithtraineddetector = new LinkLabel
        {
            Text = Info.SAMPLE_OUTPUTFOLDER_EXTRACT_AOI_TRACKINGWITHTRAINEDDETECTOR,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };

        public LinkLabel linklbl_sample_avi_extract_aoi_trackingwithtraineddetector = new LinkLabel
        {
            Text = Info.SAMPLE_AVI_EXTRACT_AOI_TRACKINGWITHTRAINEDDETECTOR,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };

        public Label lbl_sample_outputfolder_training_aoi_trackingwithtraineddetector = new LinkLabel
        {
            Text = Info.SAMPLE_OUTPUTFOLDER_TRAINING_AOI_TRACKINGWITHTRAINEDDETECTOR,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };

        public Label lbl_sample_outputfolder_tracking_aoi_trackingwithtraineddetector = new LinkLabel
        {
            Text = Info.SAMPLE_OUTPUTFOLDER_TRACKING_AOI_TRACKINGWITHTRAINEDDETECTOR,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };

        public LinkLabel linklbl_sample_output_frames_extract_aoi_trackingwithtraineddetector = new LinkLabel
        {
            Text = Info.SAMPLE_OUTPUT_FRAMES_EXTRACT_AOI_TRACKINGWITHTRAINEDDETECTOR,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };

        public LinkLabel linklbl_sample_output_facedetector_aoi_trackingwithtraineddetector = new LinkLabel
        {
            Text = Info.SAMPLE_OUTPUT_FACEDETECTOR_AOI_TRACKINGWITHTRAINEDDETECTOR,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };

        public LinkLabel linklbl_sample_output_2dlandmark_aoi_trackingwithtraineddetector = new LinkLabel
        {
            Text = Info.SAMPLE_OUTPUT_2dLANDMARK_AOI_TRACKINGWITHTRAINEDDETECTOR,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };

        public LinkLabel linklbl_sample_output_3dlandmark_aoi_trackingwithtraineddetector = new LinkLabel
        {
            Text = Info.SAMPLE_OUTPUT_3dLANDMARK_AOI_TRACKINGWITHTRAINEDDETECTOR,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };

        public LinkLabel linklbl_sample_output_imagesizefile_aoi_trackingwithtraineddetector = new LinkLabel
        {
            Text = Info.SAMPLE_OUTPUT_IMAGESIZEFILE_AOI_TRACKINGWITHTRAINEDDETECTOR,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };

        public LinkLabel linklbl_sample_output_estimatedpose_aoi_trackingwithtraineddetector = new LinkLabel
        {
            Text = Info.SAMPLE_OUTPUT_ESTIMATEDPOSE_AOI_TRACKINGWITHTRAINEDDETECTOR,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };

        public LinkLabel linklbl_sample_output_actionunit_aoi_trackingwithtraineddetector = new LinkLabel
        {
            Text = Info.SAMPLE_OUTPUT_ACTIONUNIT_AOI_TRACKINGWITHTRAINEDDETECTOR,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };

        public Button btn_gotoFunction_home_trackingWithTrainedDetector_AOIAnalysis = new Button { Text = Info.TEXT_BUTTON_GOTOHOME, AutoSize = true, BackColor = Color.AliceBlue, Font = new Font("Arial", 10, FontStyle.Bold) };
        public Button btn_gotoFunction_trackingWithTrainedDetector_AOIAnalysis = new Button { Text = Info.TEXT_BUTTON_GOTOFUNCTION, AutoSize = true, BackColor = Color.AliceBlue, Font = new Font("Arial", 10, FontStyle.Bold) };
        #endregion


        #region Preprocess Gaze Data controls*/
        /**********************************************************************************************/
        public Label lbl_infotext_preprocessGazeData = new Label
        {
            Text = Info.TEXT_INFO,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_INFOTEXT

        };

        public Label lbl_stepstext_preprocessGazeData = new Label
        {
            Text = Info.TEXT_STEPS,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPSTEXT

        };

        public Label lbl_info_preprocessGazeData = new Label
        {
            Text = Info.INFO_AOI_PREPROCESSGAZEDATA,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_INFO

        };

        public Label lbl_steps_1_preprocessGazeData = new Label
        {
            Text = Info.STEPS_OUTPUTFILE_AOI_PREPROCESSGAZEDATA,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };


        public Label lbl_steps_2_preprocessGazeData = new Label
        {
            Text = Info.STEPS_RAWGAZEDATA_AOI_PREPROCESSGAZEDATA,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };


        public Label lbl_steps_3_preprocessGazeData = new Label
        {
            Text = Info.STEPS_MAXGAPLENGTH_AOI_PREPROCESSGAZEDATA,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };


        public Label lbl_steps_4_preprocessGazeData = new Label
        {
            Text = Info.STEPS_FILLBUTTON_AOI_PREPROCESSGAZEDATA,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_outputstext_preprocessGazeData = new Label
        {
            Text = Info.TEXT_OUTPUT,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_OUTPUTTEXT

        };

        public Label lbl_outputs_preprocessGazeData = new Label
        {
            Text = Info.OUTPUT_FILLEDRAWGAZEDATA_AOI_PREPROCESSGAZEDATA,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_OUTPUT

        };

        public Label lbl_sample_outputfile_aoi_preprocessgazedata = new LinkLabel
        {
            Text = Info.SAMPLE_OUTPUTFILE_AOI_PREPROCESSGAZEDATA,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };

        public LinkLabel linklbl_sample_rawgazedata_aoi_preprocessgazedata = new LinkLabel
        {
            Text = Info.SAMPLE_RAWGAZEDATA_AOI_PREPROCESSGAZEDATA,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };

        public Label lbl_sample_maxgaplength_aoi_preprocessgazedata = new LinkLabel
        {
            Text = Info.SAMPLE_MAXGAPLENGTH_AOI_PREPROCESSGAZEDATA,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };

        public LinkLabel linklbl_sample_output_filledrawgazedata_aoi_preprocessgazedata = new LinkLabel
        {
            Text = Info.SAMPLE_OUTPUT_FILLEDRAWGAZEDATA_AOI_PREPROCESSGAZEDATA,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };

        public Button btn_gotoFunction_home_preprocessGazeData_AOIAnalysis = new Button { Text = Info.TEXT_BUTTON_GOTOHOME, AutoSize = true, BackColor = Color.AliceBlue, Font = new Font("Arial", 10, FontStyle.Bold) };
        public Button btn_gotoFunction_preprocessGazeData_AOIAnalysis = new Button { Text = Info.TEXT_BUTTON_GOTOFUNCTION, AutoSize = true, BackColor = Color.AliceBlue, Font = new Font("Arial", 10, FontStyle.Bold) };
        #endregion End of Preprocess Gaze Data controls*/


        #region Detect AOIs controls*/
        /**********************************************************************************************/
        public Label lbl_infotext_detectAOIs = new Label
        {
            Text = Info.TEXT_INFO,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_INFOTEXT

        };

        public Label lbl_stepstext_detectAOIs = new Label
        {
            Text = Info.TEXT_STEPS,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPSTEXT

        };

        public Label lbl_info_detectAOIs = new Label
        {
            Text = Info.INFO_AOI_FACEASAOI,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_INFO

        };

        public Label lbl_steps_1_detectAOIs = new Label
        {
            Text = Info.STEPS_OUTPUTFILE_AOI_FACEASAOI,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_steps_2_detectAOIs = new Label
        {
            Text = Info.STEPS_RAWGAZEDATA_AOI_FACEASAOI,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_steps_3_detectAOIs = new Label
        {
            Text = Info.STEPS_2dLANDMARK_AOI_FACEASAOI,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_steps_4_detectAOIs = new Label
        {
            Text = Info.STEPS_IMAGESIZEFILE_AOI_FACEASAOI,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_steps_5_detectAOIs = new Label
        {
            Text = Info.STEPS_IMAGESIZE_AOI_FACEASAOI,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_steps_6_detectAOIs = new Label
        {
            Text = Info.STEPS_FIXATIONERROR_AOI_FACEASAOI,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_steps_7_detectAOIs = new Label
        {
            Text = Info.STEPS_ANALYSEBUTTON_AOI_FACEASAOI,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_outputstext_detectAOIs = new Label
        {
            Text = Info.TEXT_OUTPUT,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_OUTPUTTEXT

        };

        public Label lbl_outputs_detectAOIs = new Label
        {
            Text = Info.OUTPUT_AOIS_AOI_FACEASAOI,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_OUTPUT

        };

        public Label lbl_sample_outputfile_aoi_faceasaoi = new LinkLabel
        {
            Text = Info.SAMPLE_OUTPUTFILE_AOI_FACEASAOI,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };

        public LinkLabel linklbl_sample_rawgazedata_aoi_faceasaoi = new LinkLabel
        {
            Text = Info.SAMPLE_RAWGAZEDATA_AOI_FACEASAOI,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };

        public LinkLabel linklbl_sample_2dlandmark_aoi_faceasaoi = new LinkLabel
        {
            Text = Info.SAMPLE_2dLANDMARK_AOI_FACEASAOI,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };

        public LinkLabel linklbl_sample_imagesizefile_aoi_faceasaoi = new LinkLabel
        {
            Text = Info.SAMPLE_IMAGESIZEFILE_AOI_FACEASAOI,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };


        public Label lbl_sample_imagesize_aoi_faceasaoi = new LinkLabel
        {
            Text = Info.SAMPLE_IMAGESIZE_AOI_FACEASAOI,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };


        public Label lbl_sample_fixationerror_aoi_faceasaoi = new LinkLabel
        {
            Text = Info.SAMPLE_FIXATIONERROR_AOI_FACEASAOI,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };

        public LinkLabel linklbl_sample_output_aois_aoi_faceasaoi = new LinkLabel
        {
            Text = Info.SAMPLE_OUTPUT_AOIS_AOI_FACEASAOI,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };

        public Button btn_gotoFunction_home_detectAOIs_AOIAnalysis = new Button { Text = Info.TEXT_BUTTON_GOTOHOME, AutoSize = true, BackColor = Color.AliceBlue, Font = new Font("Arial", 10, FontStyle.Bold) };
        public Button btn_gotoFunction_detectAOIs_AOIAnalysis = new Button { Text = Info.TEXT_BUTTON_GOTOFUNCTION, AutoSize = true, BackColor = Color.AliceBlue, Font = new Font("Arial", 10, FontStyle.Bold) };
        #endregion End of Detect AOIs controls*/


        #region Visualize Tracking controls*/
        /**********************************************************************************************/
        public Label lbl_infotext_visualizeTracking = new Label
        {
            Text = Info.TEXT_INFO,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_INFOTEXT

        };

        public Label lbl_stepstext_visualizeTracking = new Label
        {
            Text = Info.TEXT_STEPS,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPSTEXT

        };

        public Label lbl_info_visualizeTracking = new Label
        {
            Text = Info.INFO_AOI_VISUALIZETRACKING,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_INFO

        };

        public Label lbl_steps_1_visualizeTracking = new Label
        {
            Text = Info.STEPS_AVI_AOI_VISUALIZETRACKING,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_steps_2_visualizeTracking = new Label
        {
            Text = Info.STEPS_2dLANDMARK_AOI_VISUALIZETRACKING,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_steps_3_visualizeTracking = new Label
        {
            Text = Info.STEPS_RAWGAZEDATA_AOI_VISUALIZETRACKING,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_steps_4_visualizeTracking = new Label
        {
            Text = Info.STEPS_AOIS_AOI_VISUALIZETRACKING,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_steps_5_visualizeTracking = new Label
        {
            Text = Info.STEPS_IMAGESIZE_AOI_VISUALIZETRACKING,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_steps_6_visualizeTracking = new Label
        {
            Text = Info.STEPS_CONFIDENCETHRESHOLD_AOI_VISUALIZETRACKING,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_steps_7_visualizeTracking = new Label
        {
            Text = Info.STEPS_FIXATIONERROR_AOI_VISUALIZETRACKING,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_steps_8_visualizeTracking = new Label
        {
            Text = Info.STEPS_JUSTEXPINTERVAL_AOI_VISUALIZETRACKING,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_steps_81_visualizeTracking = new Label
        {
            Text = Info.STEPS_JUSTEXPINTERVAL_INNER1_AOI_VISUALIZETRACKING,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_steps_82_visualizeTracking = new Label
        {
            Text = Info.STEPS_JUSTEXPINTERVAL_INNER2_AOI_VISUALIZETRACKING,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_steps_83_visualizeTracking = new Label
        {
            Text = Info.STEPS_JUSTEXPINTERVAL_INNER3_AOI_VISUALIZETRACKING,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_steps_84_visualizeTracking = new Label
        {
            Text = Info.STEPS_JUSTEXPINTERVAL_INNER4_AOI_VISUALIZETRACKING,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_steps_9_visualizeTracking = new Label
        {
            Text = Info.STEPS_VISUALIZEBUTTON_AOI_VISUALIZETRACKING,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_outputstext_visualizeTracking = new Label
        {
            Text = Info.TEXT_OUTPUT,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_OUTPUTTEXT

        };

        public Label lbl_outputs_visualizeTracking = new Label
        {
            Text = Info.OUTPUT_AOI_VISUALIZETRACKING,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_OUTPUT

        };

        public LinkLabel linklbl_sample_avi_aoi_visualizetracking = new LinkLabel
        {
            Text = Info.SAMPLE_AVI_AOI_VISUALIZETRACKING,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };

        public LinkLabel linklbl_sample_2dlandmark_aoi_visualizetracking = new LinkLabel
        {
            Text = Info.SAMPLE_2dLANDMARK_AOI_VISUALIZETRACKING,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };

        public LinkLabel linklbl_sample_rawgazedata_aoi_visualizetracking = new LinkLabel
        {
            Text = Info.SAMPLE_RAWGAZEDATA_AOI_VISUALIZETRACKING,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };

        public LinkLabel linklbl_sample_aois_aoi_visualizetracking = new LinkLabel
        {
            Text = Info.SAMPLE_AOIS_AOI_VISUALIZETRACKING,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };

        public Label lbl_sample_imagesize_aoi_visualizetracking = new LinkLabel
        {
            Text = Info.SAMPLE_IMAGESIZE_AOI_VISUALIZETRACKING,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };

        public Label lbl_sample_confidencethreshold_aoi_visualizetracking = new LinkLabel
        {
            Text = Info.SAMPLE_CONFIDENCETHRESHOLD_AOI_VISUALIZETRACKING,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };

        public Label lbl_sample_fixationerror_aoi_visualizetracking = new LinkLabel
        {
            Text = Info.SAMPLE_FIXATIONERROR_AOI_VISUALIZETRACKING,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };
        public LinkLabel linklbl_sample_expintervalfile_aoi_visualizetracking = new LinkLabel
        {
            Text = Info.SAMPLE_EXPINTERVALFILE_AOI_VISUALIZETRACKING,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };

        public Label lbl_sample_eyetrackerfrequency_aoi_visualizetracking = new LinkLabel
        {
            Text = Info.SAMPLE_EYETRACKERFREQUENCY_AOI_VISUALIZETRACKING,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };

        public Label lbl_sample_participantid_aoi_visualizetracking = new LinkLabel
        {
            Text = Info.SAMPLE_PARTICIPANTID_AOI_VISUALIZETRACKING,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };

        public Button btn_gotoFunction_home_visualizeTracking_AOIAnalysis = new Button { Text = Info.TEXT_BUTTON_GOTOHOME, AutoSize = true, BackColor = Color.AliceBlue, Font = new Font("Arial", 10, FontStyle.Bold) };
        public Button btn_gotoFunction_visualizeTracking_AOIAnalysis = new Button { Text = Info.TEXT_BUTTON_GOTOFUNCTION, AutoSize = true, BackColor = Color.AliceBlue, Font = new Font("Arial", 10, FontStyle.Bold) };
        #endregion End of Visualize Tracking controls*/


        #region find AOIs Detection Ratio controls*/
        /**********************************************************************************************/
        public Label lbl_infotext_findAOIsDetectionRatio = new Label
        {
            Text = Info.TEXT_INFO,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_INFOTEXT

        };

        public Label lbl_stepstext_findAOIsDetectionRatio = new Label
        {
            Text = Info.TEXT_STEPS,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPSTEXT

        };

        public Label lbl_info_findAOIsDetectionRatio = new Label
        {
            Text = Info.INFO_AOI_AOIDETECTIONRATIO,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_INFO

        };

        public Label lbl_steps_1_findAOIsDetectionRatio = new Label
        {
            Text = Info.STEPS_AOIs_AOI_AOIDETECTIONRATIO,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_steps_2_findAOIsDetectionRatio = new Label
        {
            Text = Info.STEPS_EXPINTERVALFILE_AOI_AOIDETECTIONRATIO,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_steps_3_findAOIsDetectionRatio = new Label
        {
            Text = Info.STEPS_EYETRACKERFREQUENCY_AOI_AOIDETECTIONRATIO,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_steps_4_findAOIsDetectionRatio = new Label
        {
            Text = Info.STEPS_WHICHPARTICIPANT_AOI_AOIDETECTIONRATIO,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_steps_5_findAOIsDetectionRatio = new Label
        {
            Text = Info.STEPS_PARTICIPANTID_AOI_AOIDETECTIONRATIO,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_steps_6_findAOIsDetectionRatio = new Label
        {
            Text = Info.STEPS_FINDBUTTON_AOI_AOIDETECTIONRATIO,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_outputstext_findAOIsDetectionRatio = new Label
        {
            Text = Info.TEXT_OUTPUT,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_OUTPUTTEXT

        };

        public Label lbl_outputs_findAOIsDetectionRatio = new Label
        {
            Text = Info.OUTPUT_RATIO_AOI_AOIDETECTIONRATIO,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_OUTPUT

        };

        public LinkLabel linklbl_sample_aois_aoi_aoidetectionratio = new LinkLabel
        {
            Text = Info.SAMPLE_AOIs_AOI_AOIDETECTIONRATIO,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };

        public LinkLabel linklbl_sample_expintervalfile_aoi_aoidetectionratio = new LinkLabel
        {
            Text = Info.SAMPLE_EXPINTERVALFILE_AOI_AOIDETECTIONRATIO,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };

        public Label lbl_sample_eyetrackerfrequency_aoi_aoidetectionratio = new LinkLabel
        {
            Text = Info.SAMPLE_EYETRACKERFREQUENCY_AOI_AOIDETECTIONRATIO,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };

        public Label lbl_sample_participantid_aoi_aoidetectionratio = new LinkLabel
        {
            Text = Info.SAMPLE_PARTICIPANTID_AOI_AOIDETECTIONRATIO,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };

        public Button btn_gotoFunction_home_findAOIsDetectionRatio_AOIAnalysis = new Button { Text = Info.TEXT_BUTTON_GOTOHOME, AutoSize = true, BackColor = Color.AliceBlue, Font = new Font("Arial", 10, FontStyle.Bold) };
        public Button btn_gotoFunction_findAOIsDetectionRatio_AOIAnalysis = new Button { Text = Info.TEXT_BUTTON_GOTOFUNCTION, AutoSize = true, BackColor = Color.AliceBlue, Font = new Font("Arial", 10, FontStyle.Bold) };
        #endregion End of find AOIs Detection Ratio controls*/


        #region Label AOIs Manually controls*/
        /**********************************************************************************************/
        public Label lbl_infotext_labelAOIsManually = new Label
        {
            Text = Info.TEXT_INFO,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_INFOTEXT

        };

        public Label lbl_stepstext_labelAOIsManually = new Label
        {
            Text = Info.TEXT_STEPS,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPSTEXT

        };

        public Label lbl_info_labelAOIsManually = new Label
        {
            Text = Info.INFO_AOI_LABELMANUALLY,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_INFO

        };

        public Label lbl_steps_1_labelAOIsManually = new Label
        {
            Text = Info.STEPS_OUTPUTFILE_AOI_LABELMANUALLY,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_steps_2_labelAOIsManually = new Label
        {
            Text = Info.STEPS_AVI_AOI_LABELMANUALLY,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_steps_3_labelAOIsManually = new Label
        {
            Text = Info.STEPS_2dLANDMARK_AOI_LABELMANUALLY,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_steps_4_labelAOIsManually = new Label
        {
            Text = Info.STEPS_RAWGAZEDATA_AOI_LABELMANUALLY,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_steps_5_labelAOIsManually = new Label
        {
            Text = Info.STEPS_AOIS_AOI_LABELMANUALLY,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_steps_6_labelAOIsManually = new Label
        {
            Text = Info.STEPS_IMAGESIZE_AOI_LABELMANUALLY,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_steps_7_labelAOIsManually = new Label
        {
            Text = Info.STEPS_CONFIDENCETHRESHOLD_AOI_LABELMANUALLY,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_steps_8_labelAOIsManually = new Label
        {
            Text = Info.STEPS_FIXATIONERROR_AOI_LABELMANUALLY,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_steps_9_labelAOIsManually = new Label
        {
            Text = Info.STEPS_JUSTEXPINTERVAL_AOI_LABELMANUALLY,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_steps_91_labelAOIsManually = new Label
        {
            Text = Info.STEPS_JUSTEXPINTERVAL_INNER1_AOI_LABELMANUALLY,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_steps_92_labelAOIsManually = new Label
        {
            Text = Info.STEPS_JUSTEXPINTERVAL_INNER2_AOI_LABELMANUALLY,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_steps_93_labelAOIsManually = new Label
        {
            Text = Info.STEPS_JUSTEXPINTERVAL_INNER3_AOI_LABELMANUALLY,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_steps_94_labelAOIsManually = new Label
        {
            Text = Info.STEPS_JUSTEXPINTERVAL_INNER4_AOI_LABELMANUALLY,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_steps_10_labelAOIsManually = new Label
        {
            Text = Info.STEPS_LABELBUTTON_AOI_LABELMANUALLY,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_outputstext_labelAOIsManually = new Label
        {
            Text = Info.TEXT_OUTPUT,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_OUTPUTTEXT

        };

        public Label lbl_outputs_labelAOIsManually = new Label
        {
            Text = Info.OUTPUT_MANUALLYLABELLED_AOI_VISUALIZETRACKING,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_OUTPUT

        };

        public Label lbl_sample_outputfile_aoi_labelmanually = new LinkLabel
        {
            Text = Info.SAMPLE_OUTPUTFILE_AOI_LABELMANUALLY,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };

        public LinkLabel linklbl_sample_avi_aoi_labelAOIsManually = new LinkLabel
        {
            Text = Info.SAMPLE_AVI_AOI_LABELMANUALLY,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };

        public LinkLabel linklbl_sample_2dlandmark_aoi_labelAOIsManually = new LinkLabel
        {
            Text = Info.SAMPLE_2dLANDMARK_AOI_LABELMANUALLY,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };

        public LinkLabel linklbl_sample_rawgazedata_aoi_labelAOIsManually = new LinkLabel
        {
            Text = Info.SAMPLE_RAWGAZEDATA_AOI_LABELMANUALLY,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };

        public LinkLabel linklbl_sample_aois_aoi_labelAOIsManually = new LinkLabel
        {
            Text = Info.SAMPLE_AOIS_AOI_LABELMANUALLY,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };

        public Label lbl_sample_imagesize_aoi_labelAOIsManually = new LinkLabel
        {
            Text = Info.SAMPLE_IMAGESIZE_AOI_LABELMANUALLY,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };

        public Label lbl_sample_confidencethreshold_aoi_labelAOIsManually = new LinkLabel
        {
            Text = Info.SAMPLE_CONFIDENCETHRESHOLD_AOI_LABELMANUALLY,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };

        public Label lbl_sample_fixationerror_aoi_labelAOIsManually = new LinkLabel
        {
            Text = Info.SAMPLE_FIXATIONERROR_AOI_LABELMANUALLY,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };
        public LinkLabel linklbl_sample_expintervalfile_aoi_labelAOIsManually = new LinkLabel
        {
            Text = Info.SAMPLE_EXPINTERVALFILE_AOI_LABELMANUALLY,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };

        public Label lbl_sample_eyetrackerfrequency_aoi_labelAOIsManually = new LinkLabel
        {
            Text = Info.SAMPLE_EYETRACKERFREQUENCY_AOI_LABELMANUALLY,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };

        public Label lbl_sample_participantid_aoi_labelAOIsManually = new LinkLabel
        {
            Text = Info.SAMPLE_PARTICIPANTID_AOI_LABELMANUALLY,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };
        public LinkLabel linklbl_sample_output_manuallylabelled_aoi_visualizetracking = new LinkLabel
        {
            Text = Info.SAMPLE_OUTPUT_MANUALLYLABELLED_AOI_VISUALIZETRACKING,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };

        public Button btn_gotoFunction_home_labelAOIsManually_AOIAnalysis = new Button { Text = Info.TEXT_BUTTON_GOTOHOME, AutoSize = true, BackColor = Color.AliceBlue, Font = new Font("Arial", 10, FontStyle.Bold) };
        public Button btn_gotoFunction_labelAOIsManually_AOIAnalysis = new Button { Text = Info.TEXT_BUTTON_GOTOFUNCTION, AutoSize = true, BackColor = Color.AliceBlue, Font = new Font("Arial", 10, FontStyle.Bold) };
        #endregion End of Label AOIs Manually controls*/


        #region Re-analyse AOIs controls*/
        /**********************************************************************************************/
        public Label lbl_infotext_reanalyseAOIs = new Label
        {
            Text = Info.TEXT_INFO,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_INFOTEXT

        };

        public Label lbl_stepstext_reanalyseAOIs = new Label
        {
            Text = Info.TEXT_STEPS,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPSTEXT

        };

        public Label lbl_info_reanalyseAOIs = new Label
        {
            Text = Info.INFO_AOI_REANALYZE,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_INFO

        };

        public Label lbl_steps_1_reanalyseAOIs = new Label
        {
            Text = Info.STEPS_OUTPUTFILE_AOI_REANALYZE,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_steps_2_reanalyseAOIs = new Label
        {
            Text = Info.STEPS_MANUALLYLABELLEDAOI_AOI_REANALYZE,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_steps_3_reanalyseAOIs = new Label
        {
            Text = Info.STEPS_RAWGAZEDATA_AOI_REANALYZE,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_steps_4_reanalyseAOIs = new Label
        {
            Text = Info.STEPS_2dLANDMARK_AOI_REANALYZE,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_steps_5_reanalyseAOIs = new Label
        {
            Text = Info.STEPS_IMAGESIZEFILE_AOI_REANALYZE,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_steps_6_reanalyseAOIs = new Label
        {
            Text = Info.STEPS_IMAGESIZE_AOI_REANALYZE,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_steps_7_reanalyseAOIs = new Label
        {
            Text = Info.STEPS_ANALYSEBUTTON_AOI_REANALYZE,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_outputstext_reanalyseAOIs = new Label
        {
            Text = Info.TEXT_OUTPUT,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_OUTPUTTEXT

        };

        public Label lbl_outputs_reanalyseAOIs = new Label
        {
            Text = Info.OUTPUT_REANALYZEDAOI_AOI_VISUALIZETRACKING,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_OUTPUT

        };

        public Label lbl_sample_outputfile_aoi_reanalyze = new LinkLabel
        {
            Text = Info.SAMPLE_OUTPUTFILE_AOI_REANALYZE,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };

        public LinkLabel linklbl_sample_manuallylabelledaoi_aoi_reanalyze = new LinkLabel
        {
            Text = Info.SAMPLE_MANUALLYLABELLEDAOI_AOI_REANALYZE,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };

        public LinkLabel linklbl_sample_rawgazedata_aoi_reanalyze = new LinkLabel
        {
            Text = Info.SAMPLE_RAWGAZEDATA_AOI_REANALYZE,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };

        public LinkLabel linklbl_sample_2dlandmark_aoi_reanalyze = new LinkLabel
        {
            Text = Info.SAMPLE_2dLANDMARK_AOI_REANALYZE,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };

        public LinkLabel linklbl_sample_imagesizefile_aoi_reanalyze = new LinkLabel
        {
            Text = Info.SAMPLE_IMAGESIZEFILE_AOI_REANALYZE,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };
        public Label lbl_sample_imagesize_aoi_reanalyzE = new LinkLabel
        {
            Text = Info.SAMPLE_IMAGESIZE_AOI_REANALYZE,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };

        public LinkLabel linklbl_sample_output_reanalyzedaoi_aoi_visualizetracking = new LinkLabel
        {
            Text = Info.SAMPLE_OUTPUT_REANALYZEDAOI_AOI_VISUALIZETRACKING,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };


        public Button btn_gotoFunction_home_reanalyseAOIs_AOIAnalysis = new Button { Text = Info.TEXT_BUTTON_GOTOHOME, AutoSize = true, BackColor = Color.AliceBlue, Font = new Font("Arial", 10, FontStyle.Bold) };
        public Button btn_gotoFunction_reanalyseAOIs_AOIAnalysis = new Button { Text = Info.TEXT_BUTTON_GOTOFUNCTION, AutoSize = true, BackColor = Color.AliceBlue, Font = new Font("Arial", 10, FontStyle.Bold) };
        #endregion End of Re-analyse AOIs controls*/

        public TableLayoutPanel getFaceTrackingWithDefaultDetectorWalkthroughLayout()
        {
            TableLayoutPanel pnl_main_faceTrackingWithDefaultDetector = new TableLayoutPanel { Dock = DockStyle.Fill, AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink, AutoScroll = true };
            pnl_main_faceTrackingWithDefaultDetector.Margin = new Padding(0);
            pnl_main_faceTrackingWithDefaultDetector.ColumnCount = 2;
            pnl_main_faceTrackingWithDefaultDetector.RowCount = 2;

            TableLayoutPanel pnl_info = new TableLayoutPanel { Dock = DockStyle.Fill, Size = new Size(800, 800), AutoSizeMode = AutoSizeMode.GrowAndShrink, AutoScroll = true};
            pnl_info.Margin = new Padding(0);
            pnl_info.ColumnCount = 2;
            pnl_info.RowCount = 13;
            pnl_info.BackColor = System.Drawing.Color.LightBlue;
            pnl_info.Controls.Add(lbl_infotext_trackingWithDefaultDetector, 0, 0);
            pnl_info.Controls.Add(lbl_info_trackingWithDefaultDetector, 0, 1);
            pnl_info.SetColumnSpan(lbl_info_trackingWithDefaultDetector, 2);
            pnl_info.Controls.Add(lbl_stepstext_trackingWithDefaultDetector, 0, 2);


            TableLayoutPanel pnl_steps_1 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_1.Margin = new Padding(0);
            pnl_steps_1.ColumnCount = 2;
            pnl_steps_1.RowCount = 1;
            pnl_steps_1.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_1.Controls.Add(lbl_steps_1_trackingWithDefaultDetector, 0, 0);
            pnl_steps_1.Controls.Add(lbl_sample_outputfolder_trackingwithdefaultdetector, 1, 0);
            pnl_info.Controls.Add(pnl_steps_1, 0, 3);
            pnl_info.SetColumnSpan(pnl_steps_1, 2);

            TableLayoutPanel pnl_steps_2 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_2.Margin = new Padding(0);
            pnl_steps_2.ColumnCount = 2;
            pnl_steps_2.RowCount = 1;
            pnl_steps_2.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_2.Controls.Add(lbl_steps_2_trackingWithDefaultDetector, 0, 0);
            pnl_steps_2.Controls.Add(linklbl_sample_avi_aoi_trackingwithdefaultdetector, 1, 0);
            linklbl_sample_avi_aoi_trackingwithdefaultdetector.Links.Clear();
            linklbl_sample_avi_aoi_trackingwithdefaultdetector.Links.Add(new LinkLabel.Link(0, 50, Info.LINK_AVI_FILE));
            this.linklbl_sample_avi_aoi_trackingwithdefaultdetector.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_LinkClicked);
            pnl_info.Controls.Add(pnl_steps_2, 0, 4);
            pnl_info.SetColumnSpan(pnl_steps_2, 2);

            TableLayoutPanel pnl_steps_3 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_3.Margin = new Padding(0);
            pnl_steps_3.ColumnCount = 2;
            pnl_steps_3.RowCount = 1;
            pnl_steps_3.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_3.Controls.Add(lbl_steps_3_trackingWithDefaultDetector, 0, 0);
            pnl_info.Controls.Add(pnl_steps_3, 0, 5);
            pnl_info.SetColumnSpan(pnl_steps_3, 2);

            TableLayoutPanel pnl_steps_4 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_4.Margin = new Padding(0);
            pnl_steps_4.ColumnCount = 2;
            pnl_steps_4.RowCount = 1;
            pnl_steps_4.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_4.Controls.Add(lbl_steps_4_trackingWithDefaultDetector, 0, 0);
            pnl_info.Controls.Add(pnl_steps_4, 0, 6);
            pnl_info.SetColumnSpan(pnl_steps_4, 2);

            TableLayoutPanel pnl_steps_5 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_5.Margin = new Padding(0);
            pnl_steps_5.ColumnCount = 2;
            pnl_steps_5.RowCount = 1;
            pnl_steps_5.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_5.Controls.Add(lbl_steps_5_trackingWithDefaultDetector, 0, 0);
            pnl_info.Controls.Add(pnl_steps_5, 0, 7);
            pnl_info.SetColumnSpan(pnl_steps_5, 2);

            pnl_info.Controls.Add(lbl_outputstext_trackingWithDefaultDetector, 0, 8);

            TableLayoutPanel pnl_output_1 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_output_1.Margin = new Padding(0);
            pnl_output_1.ColumnCount = 2;
            pnl_output_1.RowCount = 1;
            pnl_output_1.BackColor = System.Drawing.Color.LightBlue;
            pnl_output_1.Controls.Add(lbl_outputs_1_trackingWithDefaultDetector, 0, 0);
            pnl_output_1.Controls.Add(linklbl_sample_output_2dlandmark_aoi_trackingwithdefaultdetector, 1, 0);
            linklbl_sample_output_2dlandmark_aoi_trackingwithdefaultdetector.Links.Clear();
            linklbl_sample_output_2dlandmark_aoi_trackingwithdefaultdetector.Links.Add(new LinkLabel.Link(0, 50, Info.LINK_2DLANDMARK));
            this.linklbl_sample_output_2dlandmark_aoi_trackingwithdefaultdetector.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_LinkClicked);
            pnl_info.Controls.Add(pnl_output_1, 0, 9);
            pnl_info.SetColumnSpan(pnl_output_1, 2);

            TableLayoutPanel pnl_output_2 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_output_2.Margin = new Padding(0);
            pnl_output_2.ColumnCount = 2;
            pnl_output_2.RowCount = 1;
            pnl_output_2.BackColor = System.Drawing.Color.LightBlue;
            pnl_output_2.Controls.Add(lbl_outputs_2_trackingWithDefaultDetector, 0, 0);
            pnl_output_2.Controls.Add(linklbl_sample_output_3dlandmark_aoi_trackingwithdefaultdetector, 1, 0);
            linklbl_sample_output_3dlandmark_aoi_trackingwithdefaultdetector.Links.Clear();
            linklbl_sample_output_3dlandmark_aoi_trackingwithdefaultdetector.Links.Add(new LinkLabel.Link(0, 50, Info.LINK_3DLANDMARK));
            this.linklbl_sample_output_3dlandmark_aoi_trackingwithdefaultdetector.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_LinkClicked);
            pnl_info.Controls.Add(pnl_output_2, 0, 10);
            pnl_info.SetColumnSpan(pnl_output_2, 2);

            TableLayoutPanel pnl_output_3 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_output_3.Margin = new Padding(0);
            pnl_output_3.ColumnCount = 2;
            pnl_output_3.RowCount = 1;
            pnl_output_3.BackColor = System.Drawing.Color.LightBlue;
            pnl_output_3.Controls.Add(lbl_outputs_3_trackingWithDefaultDetector, 0, 0);
            pnl_output_3.Controls.Add(linklbl_sample_output_imagesizefile_aoi_trackingwithdefaultdetector, 1, 0);
            linklbl_sample_output_imagesizefile_aoi_trackingwithdefaultdetector.Links.Clear();
            linklbl_sample_output_imagesizefile_aoi_trackingwithdefaultdetector.Links.Add(new LinkLabel.Link(0, 50, Info.LINK_IMAGESIZEFILE));
            this.linklbl_sample_output_imagesizefile_aoi_trackingwithdefaultdetector.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_LinkClicked);
            pnl_info.Controls.Add(pnl_output_3, 0, 11);
            pnl_info.SetColumnSpan(pnl_output_3, 2);

            TableLayoutPanel pnl_output_4 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_output_4.Margin = new Padding(0);
            pnl_output_4.ColumnCount = 2;
            pnl_output_4.RowCount = 1;
            pnl_output_4.BackColor = System.Drawing.Color.LightBlue;
            pnl_output_4.Controls.Add(lbl_outputs_4_trackingWithDefaultDetector, 0, 0);
            pnl_output_4.Controls.Add(linklbl_sample_output_estimatedpose_aoi_trackingwithdefaultdetector, 1, 0);
            linklbl_sample_output_estimatedpose_aoi_trackingwithdefaultdetector.Links.Clear();
            linklbl_sample_output_estimatedpose_aoi_trackingwithdefaultdetector.Links.Add(new LinkLabel.Link(0, 50, Info.LINK_ESTIMATED_POSE));
            this.linklbl_sample_output_estimatedpose_aoi_trackingwithdefaultdetector.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_LinkClicked);
            pnl_info.Controls.Add(pnl_output_4, 0, 12);
            pnl_info.SetColumnSpan(pnl_output_4, 2);

            TableLayoutPanel pnl_output_5 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_output_5.Margin = new Padding(0);
            pnl_output_5.ColumnCount = 2;
            pnl_output_5.RowCount = 1;
            pnl_output_5.BackColor = System.Drawing.Color.LightBlue;
            pnl_output_5.Controls.Add(lbl_outputs_5_trackingWithDefaultDetector, 0, 0);
            pnl_output_5.Controls.Add(linklbl_sample_output_actionunit_aoi_trackingwithdefaultdetector, 1, 0);
            linklbl_sample_output_actionunit_aoi_trackingwithdefaultdetector.Links.Clear();
            linklbl_sample_output_actionunit_aoi_trackingwithdefaultdetector.Links.Add(new LinkLabel.Link(0, 50, Info.LINK_ACTION_UNITS));
            this.linklbl_sample_output_actionunit_aoi_trackingwithdefaultdetector.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_LinkClicked);
            pnl_info.Controls.Add(pnl_output_5, 0, 13);
            pnl_info.SetColumnSpan(pnl_output_5, 2);

            pnl_main_faceTrackingWithDefaultDetector.Controls.Add(pnl_info, 0, 0);
            pnl_main_faceTrackingWithDefaultDetector.SetColumnSpan(pnl_info, 2);
            pnl_main_faceTrackingWithDefaultDetector.Controls.Add(btn_gotoFunction_trackingWithDefaultDetector_AOIAnalysis, 1, 1);
            pnl_main_faceTrackingWithDefaultDetector.Controls.Add(btn_gotoFunction_home_trackingWithDefaultDetector_AOIAnalysis, 0, 1);

            return pnl_main_faceTrackingWithDefaultDetector;
        }

        public TableLayoutPanel getFaceTrackingWithTrainedDetectorWalkthroughLayout()
        {
            TableLayoutPanel pnl_main_faceTrackingWithTrainedDetector = new TableLayoutPanel { Dock = DockStyle.Fill, AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink, AutoScroll = true };
            pnl_main_faceTrackingWithTrainedDetector.Margin = new Padding(0);
            pnl_main_faceTrackingWithTrainedDetector.ColumnCount = 2;
            pnl_main_faceTrackingWithTrainedDetector.RowCount = 2;

            TableLayoutPanel pnl_info = new TableLayoutPanel { Dock = DockStyle.Fill, Size = new Size(800, 800), AutoSizeMode = AutoSizeMode.GrowAndShrink, AutoScroll = true };
            pnl_info.Margin = new Padding(0);
            pnl_info.ColumnCount = 2;
            pnl_info.RowCount = 27;
            pnl_info.BackColor = System.Drawing.Color.LightBlue;
            pnl_info.Controls.Add(lbl_infotext_trackingWithTrainedDetector, 0, 0);
            pnl_info.Controls.Add(lbl_info_trackingWithTrainedDetector, 0, 1);
            pnl_info.SetColumnSpan(lbl_info_trackingWithTrainedDetector, 2);
            pnl_info.Controls.Add(lbl_stepstext_trackingWithTrainedDetector, 0, 2);

            TableLayoutPanel pnl_steps_1 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_1.Margin = new Padding(0);
            pnl_steps_1.ColumnCount = 2;
            pnl_steps_1.RowCount = 1;
            pnl_steps_1.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_1.Controls.Add(lbl_steps_1_trackingWithTrainedDetector, 0, 0);
            pnl_info.Controls.Add(pnl_steps_1, 0, 3);
            pnl_info.SetColumnSpan(pnl_steps_1, 2);

            TableLayoutPanel pnl_steps_11 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_11.Margin = new Padding(0);
            pnl_steps_11.ColumnCount = 2;
            pnl_steps_11.RowCount = 1;
            pnl_steps_11.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_11.Controls.Add(lbl_steps_11_trackingWithTrainedDetector, 0, 0);
            pnl_steps_11.Controls.Add(lbl_sample_outputfolder_extract_aoi_trackingwithtraineddetector, 1, 0);
            pnl_info.Controls.Add(pnl_steps_11, 0, 4);
            pnl_info.SetColumnSpan(pnl_steps_11, 2);

            TableLayoutPanel pnl_steps_12 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_12.Margin = new Padding(0);
            pnl_steps_12.ColumnCount = 2;
            pnl_steps_12.RowCount = 1;
            pnl_steps_12.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_12.Controls.Add(lbl_steps_12_trackingWithTrainedDetector, 0, 0);
            pnl_steps_12.Controls.Add(linklbl_sample_avi_extract_aoi_trackingwithtraineddetector, 1, 0);
            linklbl_sample_avi_extract_aoi_trackingwithtraineddetector.Links.Clear();
            linklbl_sample_avi_extract_aoi_trackingwithtraineddetector.Links.Add(new LinkLabel.Link(0, 50, Info.LINK_AVI_FILE));
            this.linklbl_sample_avi_extract_aoi_trackingwithtraineddetector.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_LinkClicked);
            pnl_info.Controls.Add(pnl_steps_12, 0, 5);
            pnl_info.SetColumnSpan(pnl_steps_12, 2);

            TableLayoutPanel pnl_steps_13 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_13.Margin = new Padding(0);
            pnl_steps_13.ColumnCount = 2;
            pnl_steps_13.RowCount = 1;
            pnl_steps_13.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_13.Controls.Add(lbl_steps_13_trackingWithTrainedDetector, 0, 0);
            pnl_info.Controls.Add(pnl_steps_13, 0, 6);
            pnl_info.SetColumnSpan(pnl_steps_13, 2);

            TableLayoutPanel pnl_steps_2 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_2.Margin = new Padding(0);
            pnl_steps_2.ColumnCount = 2;
            pnl_steps_2.RowCount = 1;
            pnl_steps_2.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_2.Controls.Add(lbl_steps_2_trackingWithTrainedDetector, 0, 0);
            pnl_info.Controls.Add(pnl_steps_2, 0, 7);
            pnl_info.SetColumnSpan(pnl_steps_2, 2);

            TableLayoutPanel pnl_steps_21 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_21.Margin = new Padding(0);
            pnl_steps_21.ColumnCount = 2;
            pnl_steps_21.RowCount = 1;
            pnl_steps_21.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_21.Controls.Add(lbl_steps_21_trackingWithTrainedDetector, 0, 0);
            pnl_steps_21.Controls.Add(lbl_sample_outputfolder_training_aoi_trackingwithtraineddetector, 1, 0);
            pnl_info.Controls.Add(pnl_steps_21, 0, 8);
            pnl_info.SetColumnSpan(pnl_steps_21, 2);

            TableLayoutPanel pnl_steps_22 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_22.Margin = new Padding(0);
            pnl_steps_22.ColumnCount = 2;
            pnl_steps_22.RowCount = 1;
            pnl_steps_22.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_22.Controls.Add(lbl_steps_22_trackingWithTrainedDetector, 0, 0);
            pnl_info.Controls.Add(pnl_steps_22, 0, 9);
            pnl_info.SetColumnSpan(pnl_steps_22, 2);

            TableLayoutPanel pnl_steps_23 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_23.Margin = new Padding(0);
            pnl_steps_23.ColumnCount = 2;
            pnl_steps_23.RowCount = 1;
            pnl_steps_23.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_23.Controls.Add(lbl_steps_23_trackingWithTrainedDetector, 0, 0);
            pnl_info.Controls.Add(pnl_steps_23, 0, 10);
            pnl_info.SetColumnSpan(pnl_steps_23, 2);

            TableLayoutPanel pnl_steps_24 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_24.Margin = new Padding(0);
            pnl_steps_24.ColumnCount = 2;
            pnl_steps_24.RowCount = 1;
            pnl_steps_24.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_24.Controls.Add(lbl_steps_24_trackingWithTrainedDetector, 0, 0);
            pnl_info.Controls.Add(pnl_steps_24, 0, 11);
            pnl_info.SetColumnSpan(pnl_steps_24, 2);

            TableLayoutPanel pnl_steps_25 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_25.Margin = new Padding(0);
            pnl_steps_25.ColumnCount = 2;
            pnl_steps_25.RowCount = 1;
            pnl_steps_25.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_25.Controls.Add(lbl_steps_25_trackingWithTrainedDetector, 0, 0);
            pnl_info.Controls.Add(pnl_steps_25, 0, 12);
            pnl_info.SetColumnSpan(pnl_steps_25, 2);

            TableLayoutPanel pnl_steps_26 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_26.Margin = new Padding(0);
            pnl_steps_26.ColumnCount = 2;
            pnl_steps_26.RowCount = 1;
            pnl_steps_26.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_26.Controls.Add(lbl_steps_26_trackingWithTrainedDetector, 0, 0);
            pnl_info.Controls.Add(pnl_steps_26, 0, 13);
            pnl_info.SetColumnSpan(pnl_steps_26, 2);

            TableLayoutPanel pnl_steps_3 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_3.Margin = new Padding(0);
            pnl_steps_3.ColumnCount = 2;
            pnl_steps_3.RowCount = 1;
            pnl_steps_3.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_3.Controls.Add(lbl_steps_3_trackingWithTrainedDetector, 0, 0);
            pnl_info.Controls.Add(pnl_steps_3, 0, 14);
            pnl_info.SetColumnSpan(pnl_steps_3, 2);

            TableLayoutPanel pnl_steps_31 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_31.Margin = new Padding(0);
            pnl_steps_31.ColumnCount = 2;
            pnl_steps_31.RowCount = 1;
            pnl_steps_31.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_31.Controls.Add(lbl_steps_31_trackingWithTrainedDetector, 0, 0);
            pnl_steps_31.Controls.Add(lbl_sample_outputfolder_tracking_aoi_trackingwithtraineddetector, 1, 0);
            pnl_info.Controls.Add(pnl_steps_31, 0, 15);
            pnl_info.SetColumnSpan(pnl_steps_31, 2);

            TableLayoutPanel pnl_steps_32 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_32.Margin = new Padding(0);
            pnl_steps_32.ColumnCount = 2;
            pnl_steps_32.RowCount = 1;
            pnl_steps_32.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_32.Controls.Add(lbl_steps_32_trackingWithTrainedDetector, 0, 0);
            pnl_info.Controls.Add(pnl_steps_32, 0, 16);
            pnl_info.SetColumnSpan(pnl_steps_32, 2);

            TableLayoutPanel pnl_steps_33 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_33.Margin = new Padding(0);
            pnl_steps_33.ColumnCount = 2;
            pnl_steps_33.RowCount = 1;
            pnl_steps_33.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_33.Controls.Add(lbl_steps_33_trackingWithTrainedDetector, 0, 0);
            pnl_info.Controls.Add(pnl_steps_33, 0, 17);
            pnl_info.SetColumnSpan(pnl_steps_33, 2);

            TableLayoutPanel pnl_steps_34 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_34.Margin = new Padding(0);
            pnl_steps_34.ColumnCount = 2;
            pnl_steps_34.RowCount = 1;
            pnl_steps_34.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_34.Controls.Add(lbl_steps_34_trackingWithTrainedDetector, 0, 0);
            pnl_info.Controls.Add(pnl_steps_34, 0, 18);
            pnl_info.SetColumnSpan(pnl_steps_34, 2);

            pnl_info.Controls.Add(lbl_outputstext_trackingWithTrainedDetector, 0, 19);

            TableLayoutPanel pnl_output_1 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_output_1.Margin = new Padding(0);
            pnl_output_1.ColumnCount = 2;
            pnl_output_1.RowCount = 1;
            pnl_output_1.BackColor = System.Drawing.Color.LightBlue;
            pnl_output_1.Controls.Add(lbl_outputs_1_trackingWithTrainedDetector, 0, 0);
            pnl_output_1.Controls.Add(linklbl_sample_output_frames_extract_aoi_trackingwithtraineddetector, 1, 0);
            linklbl_sample_output_frames_extract_aoi_trackingwithtraineddetector.Links.Clear();
            linklbl_sample_output_frames_extract_aoi_trackingwithtraineddetector.Links.Add(new LinkLabel.Link(0, 50, Info.LINK_EXPORTEDFRAME));
            this.linklbl_sample_output_frames_extract_aoi_trackingwithtraineddetector.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_LinkClicked);
            pnl_info.Controls.Add(pnl_output_1, 0, 20);
            pnl_info.SetColumnSpan(pnl_output_1, 2);

            TableLayoutPanel pnl_output_2 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_output_2.Margin = new Padding(0);
            pnl_output_2.ColumnCount = 2;
            pnl_output_2.RowCount = 1;
            pnl_output_2.BackColor = System.Drawing.Color.LightBlue;
            pnl_output_2.Controls.Add(lbl_outputs_2_trackingWithTrainedDetector, 0, 0);
            pnl_output_2.Controls.Add(linklbl_sample_output_facedetector_aoi_trackingwithtraineddetector, 1, 0);
            linklbl_sample_output_facedetector_aoi_trackingwithtraineddetector.Links.Clear();
            linklbl_sample_output_facedetector_aoi_trackingwithtraineddetector.Links.Add(new LinkLabel.Link(0, 50, Info.LINK_FACE_DETECTOR));
            this.linklbl_sample_output_facedetector_aoi_trackingwithtraineddetector.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_LinkClicked);
            pnl_info.Controls.Add(pnl_output_2, 0, 21);
            pnl_info.SetColumnSpan(pnl_output_2, 2);

            TableLayoutPanel pnl_output_3 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_output_3.Margin = new Padding(0);
            pnl_output_3.ColumnCount = 2;
            pnl_output_3.RowCount = 1;
            pnl_output_3.BackColor = System.Drawing.Color.LightBlue;
            pnl_output_3.Controls.Add(lbl_outputs_3_trackingWithTrainedDetector, 0, 0);
            pnl_output_3.Controls.Add(linklbl_sample_output_2dlandmark_aoi_trackingwithtraineddetector, 1, 0);
            linklbl_sample_output_2dlandmark_aoi_trackingwithtraineddetector.Links.Clear();
            linklbl_sample_output_2dlandmark_aoi_trackingwithtraineddetector.Links.Add(new LinkLabel.Link(0, 50, Info.LINK_2DLANDMARK));
            this.linklbl_sample_output_2dlandmark_aoi_trackingwithtraineddetector.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_LinkClicked);
            pnl_info.Controls.Add(pnl_output_3, 0, 22);
            pnl_info.SetColumnSpan(pnl_output_3, 2);

            TableLayoutPanel pnl_output_4 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_output_4.Margin = new Padding(0);
            pnl_output_4.ColumnCount = 2;
            pnl_output_4.RowCount = 1;
            pnl_output_4.BackColor = System.Drawing.Color.LightBlue;
            pnl_output_4.Controls.Add(lbl_outputs_4_trackingWithTrainedDetector, 0, 0);
            pnl_output_4.Controls.Add(linklbl_sample_output_3dlandmark_aoi_trackingwithtraineddetector, 1, 0);
            linklbl_sample_output_3dlandmark_aoi_trackingwithtraineddetector.Links.Clear();
            linklbl_sample_output_3dlandmark_aoi_trackingwithtraineddetector.Links.Add(new LinkLabel.Link(0, 50, Info.LINK_3DLANDMARK));
            this.linklbl_sample_output_3dlandmark_aoi_trackingwithtraineddetector.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_LinkClicked);
            pnl_info.Controls.Add(pnl_output_4, 0, 23);
            pnl_info.SetColumnSpan(pnl_output_4, 2);

            TableLayoutPanel pnl_output_5 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_output_5.Margin = new Padding(0);
            pnl_output_5.ColumnCount = 2;
            pnl_output_5.RowCount = 1;
            pnl_output_5.BackColor = System.Drawing.Color.LightBlue;
            pnl_output_5.Controls.Add(lbl_outputs_5_trackingWithTrainedDetector, 0, 0);
            pnl_output_5.Controls.Add(linklbl_sample_output_imagesizefile_aoi_trackingwithtraineddetector, 1, 0);
            linklbl_sample_output_imagesizefile_aoi_trackingwithtraineddetector.Links.Clear();
            linklbl_sample_output_imagesizefile_aoi_trackingwithtraineddetector.Links.Add(new LinkLabel.Link(0, 50, Info.LINK_IMAGESIZEFILE));
            this.linklbl_sample_output_imagesizefile_aoi_trackingwithtraineddetector.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_LinkClicked);
            pnl_info.Controls.Add(pnl_output_5, 0, 24);
            pnl_info.SetColumnSpan(pnl_output_5, 2);

            TableLayoutPanel pnl_output_6 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_output_6.Margin = new Padding(0);
            pnl_output_6.ColumnCount = 2;
            pnl_output_6.RowCount = 1;
            pnl_output_6.BackColor = System.Drawing.Color.LightBlue;
            pnl_output_6.Controls.Add(lbl_outputs_6_trackingWithTrainedDetector, 0, 0);
            pnl_output_6.Controls.Add(linklbl_sample_output_estimatedpose_aoi_trackingwithtraineddetector, 1, 0);
            linklbl_sample_output_estimatedpose_aoi_trackingwithtraineddetector.Links.Clear();
            linklbl_sample_output_estimatedpose_aoi_trackingwithtraineddetector.Links.Add(new LinkLabel.Link(0, 50, Info.LINK_ESTIMATED_POSE));
            this.linklbl_sample_output_estimatedpose_aoi_trackingwithtraineddetector.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_LinkClicked);
            pnl_info.Controls.Add(pnl_output_6, 0, 25);
            pnl_info.SetColumnSpan(pnl_output_6, 2);

            TableLayoutPanel pnl_output_7 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_output_7.Margin = new Padding(0);
            pnl_output_7.ColumnCount = 2;
            pnl_output_7.RowCount = 1;
            pnl_output_7.BackColor = System.Drawing.Color.LightBlue;
            pnl_output_7.Controls.Add(lbl_outputs_7_trackingWithTrainedDetector, 0, 0);
            pnl_output_7.Controls.Add(linklbl_sample_output_actionunit_aoi_trackingwithtraineddetector, 1, 0);
            linklbl_sample_output_actionunit_aoi_trackingwithtraineddetector.Links.Clear();
            linklbl_sample_output_actionunit_aoi_trackingwithtraineddetector.Links.Add(new LinkLabel.Link(0, 50, Info.LINK_ACTION_UNITS));
            this.linklbl_sample_output_actionunit_aoi_trackingwithtraineddetector.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_LinkClicked);
            pnl_info.Controls.Add(pnl_output_7, 0, 26);
            pnl_info.SetColumnSpan(pnl_output_7, 2);

            pnl_main_faceTrackingWithTrainedDetector.Controls.Add(pnl_info, 0, 0);
            pnl_main_faceTrackingWithTrainedDetector.SetColumnSpan(pnl_info, 2);
            pnl_main_faceTrackingWithTrainedDetector.Controls.Add(btn_gotoFunction_trackingWithTrainedDetector_AOIAnalysis, 1, 1);
            pnl_main_faceTrackingWithTrainedDetector.Controls.Add(btn_gotoFunction_home_trackingWithTrainedDetector_AOIAnalysis, 0, 1);

            return pnl_main_faceTrackingWithTrainedDetector;
        }

        public TableLayoutPanel getPreProcessGazeDataWalkthroughLayout()
        {
            TableLayoutPanel pnl_main_preProcessGazeData = new TableLayoutPanel { Dock = DockStyle.Fill, AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink, AutoScroll = true };
            pnl_main_preProcessGazeData.Margin = new Padding(0);
            pnl_main_preProcessGazeData.ColumnCount = 2;
            pnl_main_preProcessGazeData.RowCount = 2;

            TableLayoutPanel pnl_info = new TableLayoutPanel { Dock = DockStyle.Fill, Size = new Size(800, 800), AutoSizeMode = AutoSizeMode.GrowAndShrink, AutoScroll = true };
            pnl_info.Margin = new Padding(0);
            pnl_info.ColumnCount = 2;
            pnl_info.RowCount = 9;
            pnl_info.BackColor = System.Drawing.Color.LightBlue;
            pnl_info.Controls.Add(lbl_infotext_preprocessGazeData, 0, 0);
            pnl_info.Controls.Add(lbl_info_preprocessGazeData, 0, 1);
            pnl_info.SetColumnSpan(lbl_info_preprocessGazeData, 2);
            pnl_info.Controls.Add(lbl_stepstext_preprocessGazeData, 0, 2);

            TableLayoutPanel pnl_steps_1 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_1.Margin = new Padding(0);
            pnl_steps_1.ColumnCount = 2;
            pnl_steps_1.RowCount = 1;
            pnl_steps_1.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_1.Controls.Add(lbl_steps_1_preprocessGazeData, 0, 0);
            pnl_steps_1.Controls.Add(lbl_sample_outputfile_aoi_preprocessgazedata, 1, 0);
            pnl_info.Controls.Add(pnl_steps_1, 0, 3);
            pnl_info.SetColumnSpan(pnl_steps_1, 2);

            TableLayoutPanel pnl_steps_2 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_2.Margin = new Padding(0);
            pnl_steps_2.ColumnCount = 2;
            pnl_steps_2.RowCount = 1;
            pnl_steps_2.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_2.Controls.Add(lbl_steps_2_preprocessGazeData, 0, 0);
            pnl_steps_2.Controls.Add(linklbl_sample_rawgazedata_aoi_preprocessgazedata, 1, 0);
            linklbl_sample_rawgazedata_aoi_preprocessgazedata.Links.Clear();
            linklbl_sample_rawgazedata_aoi_preprocessgazedata.Links.Add(new LinkLabel.Link(0, 50, Info.LINK_RAW_GAZEDATA));
            this.linklbl_sample_rawgazedata_aoi_preprocessgazedata.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_LinkClicked);
            pnl_info.Controls.Add(pnl_steps_2, 0, 4);
            pnl_info.SetColumnSpan(pnl_steps_2, 2);

            TableLayoutPanel pnl_steps_3 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_3.Margin = new Padding(0);
            pnl_steps_3.ColumnCount = 2;
            pnl_steps_3.RowCount = 1;
            pnl_steps_3.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_3.Controls.Add(lbl_steps_3_preprocessGazeData, 0, 0);
            pnl_steps_3.Controls.Add(lbl_sample_maxgaplength_aoi_preprocessgazedata, 1, 0);
            pnl_info.Controls.Add(pnl_steps_3, 0, 5);
            pnl_info.SetColumnSpan(pnl_steps_3, 2);

            TableLayoutPanel pnl_steps_4 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_4.Margin = new Padding(0);
            pnl_steps_4.ColumnCount = 2;
            pnl_steps_4.RowCount = 1;
            pnl_steps_4.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_4.Controls.Add(lbl_steps_4_preprocessGazeData, 0, 0);
            pnl_info.Controls.Add(pnl_steps_4, 0, 6);
            pnl_info.SetColumnSpan(pnl_steps_4, 2);

            pnl_info.Controls.Add(lbl_outputstext_preprocessGazeData, 0, 7);

            TableLayoutPanel pnl_output = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_output.Margin = new Padding(0);
            pnl_output.ColumnCount = 2;
            pnl_output.RowCount = 1;
            pnl_output.BackColor = System.Drawing.Color.LightBlue;
            pnl_output.Controls.Add(lbl_outputs_preprocessGazeData, 0, 0);
            pnl_output.Controls.Add(linklbl_sample_output_filledrawgazedata_aoi_preprocessgazedata, 1, 0);
            linklbl_sample_output_filledrawgazedata_aoi_preprocessgazedata.Links.Clear();
            linklbl_sample_output_filledrawgazedata_aoi_preprocessgazedata.Links.Add(new LinkLabel.Link(0, 50, Info.LINK_FILLED_RAW_GAZEDATA));
            this.linklbl_sample_output_filledrawgazedata_aoi_preprocessgazedata.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_LinkClicked);
            pnl_info.Controls.Add(pnl_output, 0, 8);
            pnl_info.SetColumnSpan(pnl_output, 2);

            pnl_main_preProcessGazeData.Controls.Add(pnl_info, 0, 0);
            pnl_main_preProcessGazeData.SetColumnSpan(pnl_info, 2);
            pnl_main_preProcessGazeData.Controls.Add(btn_gotoFunction_preprocessGazeData_AOIAnalysis, 1, 1);
            pnl_main_preProcessGazeData.Controls.Add(btn_gotoFunction_home_preprocessGazeData_AOIAnalysis, 0, 1);

            return pnl_main_preProcessGazeData;
        }

        public TableLayoutPanel getDetectAOIWalkthroughLayout()
        {
            TableLayoutPanel pnl_main_detectAOI = new TableLayoutPanel { Dock = DockStyle.Fill, AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink, AutoScroll = true };
            pnl_main_detectAOI.Margin = new Padding(0);
            pnl_main_detectAOI.ColumnCount = 2;
            pnl_main_detectAOI.RowCount = 2;

            TableLayoutPanel pnl_info = new TableLayoutPanel { Dock = DockStyle.Fill, Size = new Size(800, 800), AutoSizeMode = AutoSizeMode.GrowAndShrink, AutoScroll = true };
            pnl_info.Margin = new Padding(0);
            pnl_info.ColumnCount = 2;
            pnl_info.RowCount = 12;
            pnl_info.BackColor = System.Drawing.Color.LightBlue;
            pnl_info.Controls.Add(lbl_infotext_detectAOIs, 0, 0);
            pnl_info.Controls.Add(lbl_info_detectAOIs, 0, 1);
            pnl_info.SetColumnSpan(lbl_info_detectAOIs, 2);
            pnl_info.Controls.Add(lbl_stepstext_detectAOIs, 0, 2);

            TableLayoutPanel pnl_steps_1 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_1.Margin = new Padding(0);
            pnl_steps_1.ColumnCount = 2;
            pnl_steps_1.RowCount = 1;
            pnl_steps_1.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_1.Controls.Add(lbl_steps_1_detectAOIs, 0, 0);
            pnl_steps_1.Controls.Add(lbl_sample_outputfile_aoi_faceasaoi, 1, 0);
            pnl_info.Controls.Add(pnl_steps_1, 0, 3);
            pnl_info.SetColumnSpan(pnl_steps_1, 2);

            TableLayoutPanel pnl_steps_2 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_2.Margin = new Padding(0);
            pnl_steps_2.ColumnCount = 2;
            pnl_steps_2.RowCount = 1;
            pnl_steps_2.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_2.Controls.Add(lbl_steps_2_detectAOIs, 0, 0);
            pnl_steps_2.Controls.Add(linklbl_sample_rawgazedata_aoi_faceasaoi, 1, 0);
            linklbl_sample_rawgazedata_aoi_faceasaoi.Links.Clear();
            linklbl_sample_rawgazedata_aoi_faceasaoi.Links.Add(new LinkLabel.Link(0, 50, Info.LINK_FILLED_RAW_GAZEDATA));
            this.linklbl_sample_rawgazedata_aoi_faceasaoi.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_LinkClicked);
            pnl_info.Controls.Add(pnl_steps_2, 0, 4);
            pnl_info.SetColumnSpan(pnl_steps_2, 2);

            TableLayoutPanel pnl_steps_3 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_3.Margin = new Padding(0);
            pnl_steps_3.ColumnCount = 2;
            pnl_steps_3.RowCount = 1;
            pnl_steps_3.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_3.Controls.Add(lbl_steps_3_detectAOIs, 0, 0);
            pnl_steps_3.Controls.Add(linklbl_sample_2dlandmark_aoi_faceasaoi, 1, 0);
            linklbl_sample_2dlandmark_aoi_faceasaoi.Links.Clear();
            linklbl_sample_2dlandmark_aoi_faceasaoi.Links.Add(new LinkLabel.Link(0, 50, Info.LINK_2DLANDMARK));
            this.linklbl_sample_2dlandmark_aoi_faceasaoi.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_LinkClicked);
            pnl_info.Controls.Add(pnl_steps_3, 0, 5);
            pnl_info.SetColumnSpan(pnl_steps_3, 2);

            TableLayoutPanel pnl_steps_4 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_4.Margin = new Padding(0);
            pnl_steps_4.ColumnCount = 2;
            pnl_steps_4.RowCount = 1;
            pnl_steps_4.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_4.Controls.Add(lbl_steps_4_detectAOIs, 0, 0);
            pnl_steps_4.Controls.Add(linklbl_sample_imagesizefile_aoi_faceasaoi, 1, 0);
            linklbl_sample_imagesizefile_aoi_faceasaoi.Links.Clear();
            linklbl_sample_imagesizefile_aoi_faceasaoi.Links.Add(new LinkLabel.Link(0, 50, Info.LINK_IMAGESIZEFILE));
            this.linklbl_sample_imagesizefile_aoi_faceasaoi.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_LinkClicked);
            pnl_info.Controls.Add(pnl_steps_4, 0, 6);
            pnl_info.SetColumnSpan(pnl_steps_4, 2);

            TableLayoutPanel pnl_steps_5 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_5.Margin = new Padding(0);
            pnl_steps_5.ColumnCount = 2;
            pnl_steps_5.RowCount = 1;
            pnl_steps_5.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_5.Controls.Add(lbl_steps_5_detectAOIs, 0, 0);
            pnl_steps_5.Controls.Add(lbl_sample_imagesize_aoi_faceasaoi, 1, 0);
            pnl_info.Controls.Add(pnl_steps_5, 0, 7);
            pnl_info.SetColumnSpan(pnl_steps_5, 2);

            TableLayoutPanel pnl_steps_6 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_6.Margin = new Padding(0);
            pnl_steps_6.ColumnCount = 2;
            pnl_steps_6.RowCount = 1;
            pnl_steps_6.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_6.Controls.Add(lbl_steps_6_detectAOIs, 0, 0);
            pnl_steps_6.Controls.Add(lbl_sample_fixationerror_aoi_faceasaoi, 1, 0);
            pnl_info.Controls.Add(pnl_steps_6, 0, 8);
            pnl_info.SetColumnSpan(pnl_steps_6, 2);

            TableLayoutPanel pnl_steps_7 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_7.Margin = new Padding(0);
            pnl_steps_7.ColumnCount = 2;
            pnl_steps_7.RowCount = 1;
            pnl_steps_7.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_7.Controls.Add(lbl_steps_7_detectAOIs, 0, 0);
            pnl_info.Controls.Add(pnl_steps_7, 0, 9);
            pnl_info.SetColumnSpan(pnl_steps_7, 2);

            pnl_info.Controls.Add(lbl_outputstext_detectAOIs, 0, 10);

            TableLayoutPanel pnl_output = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_output.Margin = new Padding(0);
            pnl_output.ColumnCount = 2;
            pnl_output.RowCount = 1;
            pnl_output.BackColor = System.Drawing.Color.LightBlue;
            pnl_output.Controls.Add(lbl_outputs_detectAOIs, 0, 0);
            pnl_output.Controls.Add(linklbl_sample_output_aois_aoi_faceasaoi, 1, 0);
            linklbl_sample_output_aois_aoi_faceasaoi.Links.Clear();
            linklbl_sample_output_aois_aoi_faceasaoi.Links.Add(new LinkLabel.Link(0, 50, Info.LINK_AOI_FILE));
            this.linklbl_sample_output_aois_aoi_faceasaoi.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_LinkClicked);
            pnl_info.Controls.Add(pnl_output, 0, 11);
            pnl_info.SetColumnSpan(pnl_output, 2);

            pnl_main_detectAOI.Controls.Add(pnl_info, 0, 0);
            pnl_main_detectAOI.SetColumnSpan(pnl_info, 2);
            pnl_main_detectAOI.Controls.Add(btn_gotoFunction_detectAOIs_AOIAnalysis, 1, 1);
            pnl_main_detectAOI.Controls.Add(btn_gotoFunction_home_detectAOIs_AOIAnalysis, 0, 1);

            return pnl_main_detectAOI;
        }

        public TableLayoutPanel getVisualizeTrackingWalkthroughLayout()
        {
            TableLayoutPanel pnl_main_visualizeTracking = new TableLayoutPanel { Dock = DockStyle.Fill, AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink, AutoScroll = true };
            pnl_main_visualizeTracking.Margin = new Padding(0);
            pnl_main_visualizeTracking.ColumnCount = 2;
            pnl_main_visualizeTracking.RowCount = 2;

            TableLayoutPanel pnl_info = new TableLayoutPanel { Dock = DockStyle.Fill, Size = new Size(800, 800), AutoSizeMode = AutoSizeMode.GrowAndShrink, AutoScroll = true };
            pnl_info.Margin = new Padding(0);
            pnl_info.ColumnCount = 2;
            pnl_info.RowCount = 18;
            pnl_info.BackColor = System.Drawing.Color.LightBlue;
            pnl_info.Controls.Add(lbl_infotext_visualizeTracking, 0, 0);
            pnl_info.Controls.Add(lbl_info_visualizeTracking, 0, 1);
            pnl_info.SetColumnSpan(lbl_info_visualizeTracking, 2);
            pnl_info.Controls.Add(lbl_stepstext_visualizeTracking, 0, 2);

            TableLayoutPanel pnl_steps_1 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_1.Margin = new Padding(0);
            pnl_steps_1.ColumnCount = 2;
            pnl_steps_1.RowCount = 1;
            pnl_steps_1.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_1.Controls.Add(lbl_steps_1_visualizeTracking, 0, 0);
            pnl_steps_1.Controls.Add(linklbl_sample_avi_aoi_visualizetracking, 1, 0);
            linklbl_sample_avi_aoi_visualizetracking.Links.Clear();
            linklbl_sample_avi_aoi_visualizetracking.Links.Add(new LinkLabel.Link(0, 50, Info.LINK_AVI_FILE));
            this.linklbl_sample_avi_aoi_visualizetracking.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_LinkClicked);
            pnl_info.Controls.Add(pnl_steps_1, 0, 3);
            pnl_info.SetColumnSpan(pnl_steps_1, 2);

            TableLayoutPanel pnl_steps_2 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_2.Margin = new Padding(0);
            pnl_steps_2.ColumnCount = 2;
            pnl_steps_2.RowCount = 1;
            pnl_steps_2.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_2.Controls.Add(lbl_steps_2_visualizeTracking, 0, 0);
            pnl_steps_2.Controls.Add(linklbl_sample_2dlandmark_aoi_visualizetracking, 1, 0);
            linklbl_sample_2dlandmark_aoi_visualizetracking.Links.Clear();
            linklbl_sample_2dlandmark_aoi_visualizetracking.Links.Add(new LinkLabel.Link(0, 50, Info.LINK_2DLANDMARK));
            this.linklbl_sample_2dlandmark_aoi_visualizetracking.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_LinkClicked);
            pnl_info.Controls.Add(pnl_steps_2, 0, 4);
            pnl_info.SetColumnSpan(pnl_steps_2, 2);

            TableLayoutPanel pnl_steps_3 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_3.Margin = new Padding(0);
            pnl_steps_3.ColumnCount = 2;
            pnl_steps_3.RowCount = 1;
            pnl_steps_3.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_3.Controls.Add(lbl_steps_3_visualizeTracking, 0, 0);
            pnl_steps_3.Controls.Add(linklbl_sample_rawgazedata_aoi_visualizetracking, 1, 0);
            linklbl_sample_rawgazedata_aoi_visualizetracking.Links.Clear();
            linklbl_sample_rawgazedata_aoi_visualizetracking.Links.Add(new LinkLabel.Link(0, 50, Info.LINK_FILLED_RAW_GAZEDATA));
            this.linklbl_sample_rawgazedata_aoi_visualizetracking.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_LinkClicked);
            pnl_info.Controls.Add(pnl_steps_3, 0, 5);
            pnl_info.SetColumnSpan(pnl_steps_3, 2);

            TableLayoutPanel pnl_steps_4 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_4.Margin = new Padding(0);
            pnl_steps_4.ColumnCount = 2;
            pnl_steps_4.RowCount = 1;
            pnl_steps_4.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_4.Controls.Add(lbl_steps_4_visualizeTracking, 0, 0);
            pnl_steps_4.Controls.Add(linklbl_sample_aois_aoi_visualizetracking, 1, 0);
            linklbl_sample_aois_aoi_visualizetracking.Links.Clear();
            linklbl_sample_aois_aoi_visualizetracking.Links.Add(new LinkLabel.Link(0, 50, Info.LINK_AOI_FILE));
            this.linklbl_sample_aois_aoi_visualizetracking.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_LinkClicked);
            pnl_info.Controls.Add(pnl_steps_4, 0, 6);
            pnl_info.SetColumnSpan(pnl_steps_4, 2);

            TableLayoutPanel pnl_steps_5 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_5.Margin = new Padding(0);
            pnl_steps_5.ColumnCount = 2;
            pnl_steps_5.RowCount = 1;
            pnl_steps_5.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_5.Controls.Add(lbl_steps_5_visualizeTracking, 0, 0);
            pnl_steps_5.Controls.Add(lbl_sample_imagesize_aoi_visualizetracking, 1, 0);
            pnl_info.Controls.Add(pnl_steps_5, 0, 7);
            pnl_info.SetColumnSpan(pnl_steps_5, 2);

            TableLayoutPanel pnl_steps_6 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_6.Margin = new Padding(0);
            pnl_steps_6.ColumnCount = 2;
            pnl_steps_6.RowCount = 1;
            pnl_steps_6.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_6.Controls.Add(lbl_steps_6_visualizeTracking, 0, 0);
            pnl_steps_6.Controls.Add(lbl_sample_confidencethreshold_aoi_visualizetracking, 1, 0);
            pnl_info.Controls.Add(pnl_steps_6, 0, 8);
            pnl_info.SetColumnSpan(pnl_steps_6, 2);

            TableLayoutPanel pnl_steps_7 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_7.Margin = new Padding(0);
            pnl_steps_7.ColumnCount = 2;
            pnl_steps_7.RowCount = 1;
            pnl_steps_7.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_7.Controls.Add(lbl_steps_7_visualizeTracking, 0, 0);
            pnl_steps_7.Controls.Add(lbl_sample_fixationerror_aoi_visualizetracking, 1, 0);
            pnl_info.Controls.Add(pnl_steps_7, 0, 9);
            pnl_info.SetColumnSpan(pnl_steps_7, 2);

            TableLayoutPanel pnl_steps_8 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_8.Margin = new Padding(0);
            pnl_steps_8.ColumnCount = 2;
            pnl_steps_8.RowCount = 1;
            pnl_steps_8.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_8.Controls.Add(lbl_steps_8_visualizeTracking, 0, 0);
            pnl_info.Controls.Add(pnl_steps_8, 0, 10);
            pnl_info.SetColumnSpan(pnl_steps_8, 2);

            TableLayoutPanel pnl_steps_81 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_81.Margin = new Padding(0);
            pnl_steps_81.ColumnCount = 2;
            pnl_steps_81.RowCount = 1;
            pnl_steps_81.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_81.Controls.Add(lbl_steps_81_visualizeTracking, 0, 0);
            pnl_steps_81.Controls.Add(linklbl_sample_expintervalfile_aoi_visualizetracking, 1, 0);
            linklbl_sample_expintervalfile_aoi_visualizetracking.Links.Clear();
            linklbl_sample_expintervalfile_aoi_visualizetracking.Links.Add(new LinkLabel.Link(0, 50, Info.LINK_EXP_INTERVAL));
            this.linklbl_sample_expintervalfile_aoi_visualizetracking.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_LinkClicked);
            pnl_info.Controls.Add(pnl_steps_81, 0, 11);
            pnl_info.SetColumnSpan(pnl_steps_81, 2);

            TableLayoutPanel pnl_steps_82 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_82.Margin = new Padding(0);
            pnl_steps_82.ColumnCount = 2;
            pnl_steps_82.RowCount = 1;
            pnl_steps_82.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_82.Controls.Add(lbl_steps_82_visualizeTracking, 0, 0);
            pnl_steps_82.Controls.Add(lbl_sample_eyetrackerfrequency_aoi_visualizetracking, 1, 0);
            pnl_info.Controls.Add(pnl_steps_82, 0, 12);
            pnl_info.SetColumnSpan(pnl_steps_82, 2);

            TableLayoutPanel pnl_steps_83 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_83.Margin = new Padding(0);
            pnl_steps_83.ColumnCount = 2;
            pnl_steps_83.RowCount = 1;
            pnl_steps_83.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_83.Controls.Add(lbl_steps_83_visualizeTracking, 0, 0);
            pnl_info.Controls.Add(pnl_steps_83, 0, 13);
            pnl_info.SetColumnSpan(pnl_steps_83, 2);

            TableLayoutPanel pnl_steps_84 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_84.Margin = new Padding(0);
            pnl_steps_84.ColumnCount = 2;
            pnl_steps_84.RowCount = 1;
            pnl_steps_84.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_84.Controls.Add(lbl_steps_84_visualizeTracking, 0, 0);
            pnl_steps_84.Controls.Add(lbl_sample_participantid_aoi_visualizetracking, 1, 0);
            pnl_info.Controls.Add(pnl_steps_84, 0, 14);
            pnl_info.SetColumnSpan(pnl_steps_84, 2);

            TableLayoutPanel pnl_steps_9 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_9.Margin = new Padding(0);
            pnl_steps_9.ColumnCount = 2;
            pnl_steps_9.RowCount = 1;
            pnl_steps_9.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_9.Controls.Add(lbl_steps_9_visualizeTracking, 0, 0);
            pnl_info.Controls.Add(pnl_steps_9, 0, 15);
            pnl_info.SetColumnSpan(pnl_steps_9, 2);


            pnl_info.Controls.Add(lbl_outputstext_visualizeTracking, 0, 16);

            TableLayoutPanel pnl_output = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_output.Margin = new Padding(0);
            pnl_output.ColumnCount = 2;
            pnl_output.RowCount = 1;
            pnl_output.BackColor = System.Drawing.Color.LightBlue;
            pnl_output.Controls.Add(lbl_outputs_visualizeTracking, 0, 0);
            pnl_info.Controls.Add(pnl_output, 0, 17);
            pnl_info.SetColumnSpan(pnl_output, 2);

            pnl_main_visualizeTracking.Controls.Add(pnl_info, 0, 0);
            pnl_main_visualizeTracking.SetColumnSpan(pnl_info, 2);
            pnl_main_visualizeTracking.Controls.Add(btn_gotoFunction_visualizeTracking_AOIAnalysis, 1, 1);
            pnl_main_visualizeTracking.Controls.Add(btn_gotoFunction_home_visualizeTracking_AOIAnalysis, 0, 1);

            return pnl_main_visualizeTracking;
        }

        public TableLayoutPanel getFindDetectionRatioWalkthroughLayout()
        {
            TableLayoutPanel pnl_main_findDetectionRatio = new TableLayoutPanel { Dock = DockStyle.Fill, AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink, AutoScroll = true };
            pnl_main_findDetectionRatio.Margin = new Padding(0);
            pnl_main_findDetectionRatio.ColumnCount = 2;
            pnl_main_findDetectionRatio.RowCount = 2;

            TableLayoutPanel pnl_info = new TableLayoutPanel { Dock = DockStyle.Fill, Size = new Size(800, 800), AutoSizeMode = AutoSizeMode.GrowAndShrink, AutoScroll = true };
            pnl_info.Margin = new Padding(0);
            pnl_info.ColumnCount = 2;
            pnl_info.RowCount = 11;
            pnl_info.BackColor = System.Drawing.Color.LightBlue;
            pnl_info.Controls.Add(lbl_infotext_findAOIsDetectionRatio, 0, 0);
            pnl_info.Controls.Add(lbl_info_findAOIsDetectionRatio, 0, 1);
            pnl_info.SetColumnSpan(lbl_info_findAOIsDetectionRatio, 2);
            pnl_info.Controls.Add(lbl_stepstext_findAOIsDetectionRatio, 0, 2);

            TableLayoutPanel pnl_steps_1 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_1.Margin = new Padding(0);
            pnl_steps_1.ColumnCount = 2;
            pnl_steps_1.RowCount = 1;
            pnl_steps_1.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_1.Controls.Add(lbl_steps_1_findAOIsDetectionRatio, 0, 0);
            pnl_steps_1.Controls.Add(linklbl_sample_aois_aoi_aoidetectionratio, 1, 0);
            linklbl_sample_aois_aoi_aoidetectionratio.Links.Clear();
            linklbl_sample_aois_aoi_aoidetectionratio.Links.Add(new LinkLabel.Link(0, 50, Info.LINK_AOI_FILE));
            this.linklbl_sample_aois_aoi_aoidetectionratio.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_LinkClicked);
            pnl_info.Controls.Add(pnl_steps_1, 0, 3);
            pnl_info.SetColumnSpan(pnl_steps_1, 2);

            TableLayoutPanel pnl_steps_2 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_2.Margin = new Padding(0);
            pnl_steps_2.ColumnCount = 2;
            pnl_steps_2.RowCount = 1;
            pnl_steps_2.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_2.Controls.Add(lbl_steps_2_findAOIsDetectionRatio, 0, 0);
            pnl_steps_2.Controls.Add(linklbl_sample_expintervalfile_aoi_aoidetectionratio, 1, 0);
            linklbl_sample_expintervalfile_aoi_aoidetectionratio.Links.Clear();
            linklbl_sample_expintervalfile_aoi_aoidetectionratio.Links.Add(new LinkLabel.Link(0, 50, Info.LINK_EXP_INTERVAL));
            this.linklbl_sample_expintervalfile_aoi_aoidetectionratio.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_LinkClicked);
            pnl_info.Controls.Add(pnl_steps_2, 0, 4);
            pnl_info.SetColumnSpan(pnl_steps_2, 2);

            TableLayoutPanel pnl_steps_3 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_3.Margin = new Padding(0);
            pnl_steps_3.ColumnCount = 2;
            pnl_steps_3.RowCount = 1;
            pnl_steps_3.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_3.Controls.Add(lbl_steps_3_findAOIsDetectionRatio, 0, 0);
            pnl_steps_3.Controls.Add(lbl_sample_eyetrackerfrequency_aoi_aoidetectionratio, 1, 0);
            pnl_info.Controls.Add(pnl_steps_3, 0, 5);
            pnl_info.SetColumnSpan(pnl_steps_3, 2);

            TableLayoutPanel pnl_steps_4 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_4.Margin = new Padding(0);
            pnl_steps_4.ColumnCount = 2;
            pnl_steps_4.RowCount = 1;
            pnl_steps_4.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_4.Controls.Add(lbl_steps_4_findAOIsDetectionRatio, 0, 0);
            pnl_info.Controls.Add(pnl_steps_4, 0, 6);
            pnl_info.SetColumnSpan(pnl_steps_4, 2);

            TableLayoutPanel pnl_steps_5 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_5.Margin = new Padding(0);
            pnl_steps_5.ColumnCount = 2;
            pnl_steps_5.RowCount = 1;
            pnl_steps_5.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_5.Controls.Add(lbl_steps_5_findAOIsDetectionRatio, 0, 0);
            pnl_steps_5.Controls.Add(lbl_sample_participantid_aoi_aoidetectionratio, 1, 0);
            pnl_info.Controls.Add(pnl_steps_5, 0, 7);
            pnl_info.SetColumnSpan(pnl_steps_5, 2);

            TableLayoutPanel pnl_steps_6 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_6.Margin = new Padding(0);
            pnl_steps_6.ColumnCount = 2;
            pnl_steps_6.RowCount = 1;
            pnl_steps_6.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_6.Controls.Add(lbl_steps_6_findAOIsDetectionRatio, 0, 0);
            pnl_info.Controls.Add(pnl_steps_6, 0, 8);
            pnl_info.SetColumnSpan(pnl_steps_6, 2);

            pnl_info.Controls.Add(lbl_outputstext_findAOIsDetectionRatio, 0, 9);

            TableLayoutPanel pnl_output = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_output.Margin = new Padding(0);
            pnl_output.ColumnCount = 2;
            pnl_output.RowCount = 1;
            pnl_output.BackColor = System.Drawing.Color.LightBlue;
            pnl_output.Controls.Add(lbl_outputs_findAOIsDetectionRatio, 0, 0);
            pnl_info.Controls.Add(pnl_output, 0, 10);
            pnl_info.SetColumnSpan(pnl_output, 2);

            pnl_main_findDetectionRatio.Controls.Add(pnl_info, 0, 0);
            pnl_main_findDetectionRatio.SetColumnSpan(pnl_info, 2);
            pnl_main_findDetectionRatio.Controls.Add(btn_gotoFunction_findAOIsDetectionRatio_AOIAnalysis, 1, 1);
            pnl_main_findDetectionRatio.Controls.Add(btn_gotoFunction_home_findAOIsDetectionRatio_AOIAnalysis, 0, 1);

            return pnl_main_findDetectionRatio;
        }

        public TableLayoutPanel getLabelAOIManuallyWalkthroughLayout()
        {
            TableLayoutPanel pnl_main_labelAOIManually = new TableLayoutPanel { Dock = DockStyle.Fill, AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink, AutoScroll = true };
            pnl_main_labelAOIManually.Margin = new Padding(0);
            pnl_main_labelAOIManually.ColumnCount = 2;
            pnl_main_labelAOIManually.RowCount = 2;

            TableLayoutPanel pnl_info = new TableLayoutPanel { Dock = DockStyle.Fill, Size = new Size(800, 800), AutoSizeMode = AutoSizeMode.GrowAndShrink, AutoScroll = true };
            pnl_info.Margin = new Padding(0);
            pnl_info.ColumnCount = 2;
            pnl_info.RowCount = 19;
            pnl_info.BackColor = System.Drawing.Color.LightBlue;
            pnl_info.Controls.Add(lbl_infotext_labelAOIsManually, 0, 0);
            pnl_info.Controls.Add(lbl_info_labelAOIsManually, 0, 1);
            pnl_info.SetColumnSpan(lbl_info_labelAOIsManually, 2);
            pnl_info.Controls.Add(lbl_stepstext_labelAOIsManually, 0, 2);

            TableLayoutPanel pnl_steps_1 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_1.Margin = new Padding(0);
            pnl_steps_1.ColumnCount = 2;
            pnl_steps_1.RowCount = 1;
            pnl_steps_1.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_1.Controls.Add(lbl_steps_1_labelAOIsManually, 0, 0);
            pnl_steps_1.Controls.Add(lbl_sample_outputfile_aoi_labelmanually, 1, 0);
            pnl_info.Controls.Add(pnl_steps_1, 0, 3);
            pnl_info.SetColumnSpan(pnl_steps_1, 2);

            TableLayoutPanel pnl_steps_2 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_2.Margin = new Padding(0);
            pnl_steps_2.ColumnCount = 2;
            pnl_steps_2.RowCount = 1;
            pnl_steps_2.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_2.Controls.Add(lbl_steps_2_labelAOIsManually, 0, 0);
            pnl_steps_2.Controls.Add(linklbl_sample_avi_aoi_labelAOIsManually, 1, 0);
            linklbl_sample_avi_aoi_labelAOIsManually.Links.Clear();
            linklbl_sample_avi_aoi_labelAOIsManually.Links.Add(new LinkLabel.Link(0, 50, Info.LINK_AVI_FILE));
            this.linklbl_sample_avi_aoi_labelAOIsManually.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_LinkClicked);
            pnl_info.Controls.Add(pnl_steps_2, 0, 4);
            pnl_info.SetColumnSpan(pnl_steps_2, 2);

            TableLayoutPanel pnl_steps_3 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_3.Margin = new Padding(0);
            pnl_steps_3.ColumnCount = 2;
            pnl_steps_3.RowCount = 1;
            pnl_steps_3.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_3.Controls.Add(lbl_steps_3_labelAOIsManually, 0, 0);
            pnl_steps_3.Controls.Add(linklbl_sample_2dlandmark_aoi_labelAOIsManually, 1, 0);
            linklbl_sample_2dlandmark_aoi_labelAOIsManually.Links.Clear();
            linklbl_sample_2dlandmark_aoi_labelAOIsManually.Links.Add(new LinkLabel.Link(0, 50, Info.LINK_2DLANDMARK));
            this.linklbl_sample_2dlandmark_aoi_labelAOIsManually.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_LinkClicked);
            pnl_info.Controls.Add(pnl_steps_3, 0, 5);
            pnl_info.SetColumnSpan(pnl_steps_3, 2);

            TableLayoutPanel pnl_steps_4 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_4.Margin = new Padding(0);
            pnl_steps_4.ColumnCount = 2;
            pnl_steps_4.RowCount = 1;
            pnl_steps_4.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_4.Controls.Add(lbl_steps_4_labelAOIsManually, 0, 0);
            pnl_steps_4.Controls.Add(linklbl_sample_rawgazedata_aoi_labelAOIsManually, 1, 0);
            linklbl_sample_rawgazedata_aoi_labelAOIsManually.Links.Clear();
            linklbl_sample_rawgazedata_aoi_labelAOIsManually.Links.Add(new LinkLabel.Link(0, 50, Info.LINK_FILLED_RAW_GAZEDATA));
            this.linklbl_sample_rawgazedata_aoi_labelAOIsManually.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_LinkClicked);
            pnl_info.Controls.Add(pnl_steps_4, 0, 6);
            pnl_info.SetColumnSpan(pnl_steps_4, 2);

            TableLayoutPanel pnl_steps_5 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_5.Margin = new Padding(0);
            pnl_steps_5.ColumnCount = 2;
            pnl_steps_5.RowCount = 1;
            pnl_steps_5.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_5.Controls.Add(lbl_steps_5_labelAOIsManually, 0, 0);
            pnl_steps_5.Controls.Add(linklbl_sample_aois_aoi_labelAOIsManually, 1, 0);
            linklbl_sample_aois_aoi_labelAOIsManually.Links.Clear();
            linklbl_sample_aois_aoi_labelAOIsManually.Links.Add(new LinkLabel.Link(0, 50, Info.LINK_MANUALLY_LABELLED_AOI));
            this.linklbl_sample_aois_aoi_labelAOIsManually.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_LinkClicked);
            pnl_info.Controls.Add(pnl_steps_5, 0, 7);
            pnl_info.SetColumnSpan(pnl_steps_5, 2);

            TableLayoutPanel pnl_steps_6 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_6.Margin = new Padding(0);
            pnl_steps_6.ColumnCount = 2;
            pnl_steps_6.RowCount = 1;
            pnl_steps_6.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_6.Controls.Add(lbl_steps_6_labelAOIsManually, 0, 0);
            pnl_steps_6.Controls.Add(lbl_sample_imagesize_aoi_labelAOIsManually, 1, 0);
            pnl_info.Controls.Add(pnl_steps_6, 0, 8);
            pnl_info.SetColumnSpan(pnl_steps_6, 2);

            TableLayoutPanel pnl_steps_7 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_7.Margin = new Padding(0);
            pnl_steps_7.ColumnCount = 2;
            pnl_steps_7.RowCount = 1;
            pnl_steps_7.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_7.Controls.Add(lbl_steps_7_labelAOIsManually, 0, 0);
            pnl_steps_7.Controls.Add(lbl_sample_confidencethreshold_aoi_labelAOIsManually, 1, 0);
            pnl_info.Controls.Add(pnl_steps_7, 0, 9);
            pnl_info.SetColumnSpan(pnl_steps_7, 2);

            TableLayoutPanel pnl_steps_8 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_8.Margin = new Padding(0);
            pnl_steps_8.ColumnCount = 2;
            pnl_steps_8.RowCount = 1;
            pnl_steps_8.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_8.Controls.Add(lbl_steps_8_labelAOIsManually, 0, 0);
            pnl_steps_8.Controls.Add(lbl_sample_fixationerror_aoi_labelAOIsManually, 1, 0);
            pnl_info.Controls.Add(pnl_steps_8, 0, 10);
            pnl_info.SetColumnSpan(pnl_steps_8, 2);

            TableLayoutPanel pnl_steps_9 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_9.Margin = new Padding(0);
            pnl_steps_9.ColumnCount = 2;
            pnl_steps_9.RowCount = 1;
            pnl_steps_9.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_9.Controls.Add(lbl_steps_9_labelAOIsManually, 0, 0);
            pnl_info.Controls.Add(pnl_steps_9, 0, 11);
            pnl_info.SetColumnSpan(pnl_steps_9, 2);

            TableLayoutPanel pnl_steps_91 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_91.Margin = new Padding(0);
            pnl_steps_91.ColumnCount = 2;
            pnl_steps_91.RowCount = 1;
            pnl_steps_91.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_91.Controls.Add(lbl_steps_91_labelAOIsManually, 0, 0);
            pnl_steps_91.Controls.Add(linklbl_sample_expintervalfile_aoi_labelAOIsManually, 1, 0);
            linklbl_sample_expintervalfile_aoi_labelAOIsManually.Links.Clear();
            linklbl_sample_expintervalfile_aoi_labelAOIsManually.Links.Add(new LinkLabel.Link(0, 50, Info.LINK_EXP_INTERVAL));
            this.linklbl_sample_expintervalfile_aoi_labelAOIsManually.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_LinkClicked);
            pnl_info.Controls.Add(pnl_steps_91, 0, 12);
            pnl_info.SetColumnSpan(pnl_steps_91, 2);

            TableLayoutPanel pnl_steps_92 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_92.Margin = new Padding(0);
            pnl_steps_92.ColumnCount = 2;
            pnl_steps_92.RowCount = 1;
            pnl_steps_92.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_92.Controls.Add(lbl_steps_92_labelAOIsManually, 0, 0);
            pnl_steps_92.Controls.Add(lbl_sample_eyetrackerfrequency_aoi_labelAOIsManually, 1, 0);
            pnl_info.Controls.Add(pnl_steps_92, 0, 13);
            pnl_info.SetColumnSpan(pnl_steps_92, 2);

            TableLayoutPanel pnl_steps_93 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_93.Margin = new Padding(0);
            pnl_steps_93.ColumnCount = 2;
            pnl_steps_93.RowCount = 1;
            pnl_steps_93.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_93.Controls.Add(lbl_steps_93_labelAOIsManually, 0, 0);
            pnl_info.Controls.Add(pnl_steps_93, 0, 14);
            pnl_info.SetColumnSpan(pnl_steps_93, 2);

            TableLayoutPanel pnl_steps_94 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_94.Margin = new Padding(0);
            pnl_steps_94.ColumnCount = 2;
            pnl_steps_94.RowCount = 1;
            pnl_steps_94.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_94.Controls.Add(lbl_steps_94_labelAOIsManually, 0, 0);
            pnl_steps_94.Controls.Add(lbl_sample_participantid_aoi_labelAOIsManually, 1, 0);
            pnl_info.Controls.Add(pnl_steps_94, 0, 15);
            pnl_info.SetColumnSpan(pnl_steps_94, 2);

            TableLayoutPanel pnl_steps_10 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_10.Margin = new Padding(0);
            pnl_steps_10.ColumnCount = 2;
            pnl_steps_10.RowCount = 1;
            pnl_steps_10.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_10.Controls.Add(lbl_steps_10_labelAOIsManually, 0, 0);
            pnl_info.Controls.Add(pnl_steps_10, 0, 16);
            pnl_info.SetColumnSpan(pnl_steps_10, 2);


            pnl_info.Controls.Add(lbl_outputstext_labelAOIsManually, 0, 17);

            TableLayoutPanel pnl_output = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_output.Margin = new Padding(0);
            pnl_output.ColumnCount = 2;
            pnl_output.RowCount = 1;
            pnl_output.BackColor = System.Drawing.Color.LightBlue;
            pnl_output.Controls.Add(lbl_outputs_labelAOIsManually, 0, 0);
            pnl_output.Controls.Add(linklbl_sample_output_manuallylabelled_aoi_visualizetracking, 1, 0);
            linklbl_sample_output_manuallylabelled_aoi_visualizetracking.Links.Clear();
            linklbl_sample_output_manuallylabelled_aoi_visualizetracking.Links.Add(new LinkLabel.Link(0, 50, Info.LINK_MANUALLY_LABELLED_AOI));
            this.linklbl_sample_output_manuallylabelled_aoi_visualizetracking.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_LinkClicked);
            pnl_info.Controls.Add(pnl_output, 0, 18);
            pnl_info.SetColumnSpan(pnl_output, 2);

            pnl_main_labelAOIManually.Controls.Add(pnl_info, 0, 0);
            pnl_main_labelAOIManually.SetColumnSpan(pnl_info, 2);
            pnl_main_labelAOIManually.Controls.Add(btn_gotoFunction_labelAOIsManually_AOIAnalysis, 1, 1);
            pnl_main_labelAOIManually.Controls.Add(btn_gotoFunction_home_labelAOIsManually_AOIAnalysis, 0, 1);

            return pnl_main_labelAOIManually;
        }

        public TableLayoutPanel getReanalyseAOIWalkthroughLayout()
        {
            TableLayoutPanel pnl_main_reanalyseAOI = new TableLayoutPanel { Dock = DockStyle.Fill, AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink, AutoScroll = true };
            pnl_main_reanalyseAOI.Margin = new Padding(0);
            pnl_main_reanalyseAOI.ColumnCount = 2;
            pnl_main_reanalyseAOI.RowCount = 2;

            TableLayoutPanel pnl_info = new TableLayoutPanel { Dock = DockStyle.Fill, Size = new Size(800, 800), AutoSizeMode = AutoSizeMode.GrowAndShrink, AutoScroll = true };
            pnl_info.Margin = new Padding(0);
            pnl_info.ColumnCount = 2;
            pnl_info.RowCount = 12;
            pnl_info.BackColor = System.Drawing.Color.LightBlue;
            pnl_info.Controls.Add(lbl_infotext_reanalyseAOIs, 0, 0);
            pnl_info.Controls.Add(lbl_info_reanalyseAOIs, 0, 1);
            pnl_info.SetColumnSpan(lbl_info_reanalyseAOIs, 2);
            pnl_info.Controls.Add(lbl_stepstext_reanalyseAOIs, 0, 2);


            TableLayoutPanel pnl_steps_1 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_1.Margin = new Padding(0);
            pnl_steps_1.ColumnCount = 2;
            pnl_steps_1.RowCount = 1;
            pnl_steps_1.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_1.Controls.Add(lbl_steps_1_reanalyseAOIs, 0, 0);
            pnl_steps_1.Controls.Add(lbl_sample_outputfile_aoi_reanalyze, 1, 0);
            pnl_info.Controls.Add(pnl_steps_1, 0, 3);
            pnl_info.SetColumnSpan(pnl_steps_1, 2);

            TableLayoutPanel pnl_steps_2 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_2.Margin = new Padding(0);
            pnl_steps_2.ColumnCount = 2;
            pnl_steps_2.RowCount = 1;
            pnl_steps_2.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_2.Controls.Add(lbl_steps_2_reanalyseAOIs, 0, 0);
            pnl_steps_2.Controls.Add(linklbl_sample_manuallylabelledaoi_aoi_reanalyze, 1, 0);
            linklbl_sample_manuallylabelledaoi_aoi_reanalyze.Links.Clear();
            linklbl_sample_manuallylabelledaoi_aoi_reanalyze.Links.Add(new LinkLabel.Link(0, 50, Info.LINK_MANUALLY_LABELLED_AOI));
            this.linklbl_sample_manuallylabelledaoi_aoi_reanalyze.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_LinkClicked);
            pnl_info.Controls.Add(pnl_steps_2, 0, 4);
            pnl_info.SetColumnSpan(pnl_steps_2, 2);

            TableLayoutPanel pnl_steps_3 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_3.Margin = new Padding(0);
            pnl_steps_3.ColumnCount = 2;
            pnl_steps_3.RowCount = 1;
            pnl_steps_3.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_3.Controls.Add(lbl_steps_3_reanalyseAOIs, 0, 0);
            pnl_steps_3.Controls.Add(linklbl_sample_rawgazedata_aoi_reanalyze, 1, 0);
            linklbl_sample_rawgazedata_aoi_reanalyze.Links.Clear();
            linklbl_sample_rawgazedata_aoi_reanalyze.Links.Add(new LinkLabel.Link(0, 50, Info.LINK_FILLED_RAW_GAZEDATA));
            this.linklbl_sample_rawgazedata_aoi_reanalyze.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_LinkClicked);
            pnl_info.Controls.Add(pnl_steps_3, 0, 5);
            pnl_info.SetColumnSpan(pnl_steps_3, 2);

            TableLayoutPanel pnl_steps_4 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_4.Margin = new Padding(0);
            pnl_steps_4.ColumnCount = 2;
            pnl_steps_4.RowCount = 1;
            pnl_steps_4.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_4.Controls.Add(lbl_steps_4_reanalyseAOIs, 0, 0);
            pnl_steps_4.Controls.Add(linklbl_sample_2dlandmark_aoi_reanalyze, 1, 0);
            linklbl_sample_2dlandmark_aoi_reanalyze.Links.Clear();
            linklbl_sample_2dlandmark_aoi_reanalyze.Links.Add(new LinkLabel.Link(0, 50, Info.LINK_2DLANDMARK));
            this.linklbl_sample_2dlandmark_aoi_reanalyze.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_LinkClicked);
            pnl_info.Controls.Add(pnl_steps_4, 0, 6);
            pnl_info.SetColumnSpan(pnl_steps_4, 2);

            TableLayoutPanel pnl_steps_5 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_5.Margin = new Padding(0);
            pnl_steps_5.ColumnCount = 2;
            pnl_steps_5.RowCount = 1;
            pnl_steps_5.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_5.Controls.Add(lbl_steps_5_reanalyseAOIs, 0, 0);
            pnl_steps_5.Controls.Add(linklbl_sample_imagesizefile_aoi_reanalyze, 1, 0);
            linklbl_sample_imagesizefile_aoi_reanalyze.Links.Clear();
            linklbl_sample_imagesizefile_aoi_reanalyze.Links.Add(new LinkLabel.Link(0, 50, Info.LINK_IMAGESIZEFILE));
            this.linklbl_sample_imagesizefile_aoi_reanalyze.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_LinkClicked);
            pnl_info.Controls.Add(pnl_steps_5, 0, 7);
            pnl_info.SetColumnSpan(pnl_steps_5, 2);


            TableLayoutPanel pnl_steps_6 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_6.Margin = new Padding(0);
            pnl_steps_6.ColumnCount = 2;
            pnl_steps_6.RowCount = 1;
            pnl_steps_6.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_6.Controls.Add(lbl_steps_6_reanalyseAOIs, 0, 0);
            pnl_steps_6.Controls.Add(lbl_sample_imagesize_aoi_reanalyzE, 1, 0);
            pnl_info.Controls.Add(pnl_steps_6, 0, 8);
            pnl_info.SetColumnSpan(pnl_steps_6, 2);

            TableLayoutPanel pnl_steps_7 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_7.Margin = new Padding(0);
            pnl_steps_7.ColumnCount = 2;
            pnl_steps_7.RowCount = 1;
            pnl_steps_7.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_7.Controls.Add(lbl_steps_7_reanalyseAOIs, 0, 0);
            pnl_info.Controls.Add(pnl_steps_7, 0, 9);
            pnl_info.SetColumnSpan(pnl_steps_7, 2);

            pnl_info.Controls.Add(lbl_outputstext_reanalyseAOIs, 0, 10);

            TableLayoutPanel pnl_output = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_output.Margin = new Padding(0);
            pnl_output.ColumnCount = 2;
            pnl_output.RowCount = 1;
            pnl_output.BackColor = System.Drawing.Color.LightBlue;
            pnl_output.Controls.Add(lbl_outputs_reanalyseAOIs, 0, 0);
            pnl_output.Controls.Add(linklbl_sample_output_reanalyzedaoi_aoi_visualizetracking, 1, 0);
            linklbl_sample_output_reanalyzedaoi_aoi_visualizetracking.Links.Clear();
            linklbl_sample_output_reanalyzedaoi_aoi_visualizetracking.Links.Add(new LinkLabel.Link(0, 50, Info.LINK_REANALYZE_AOI_OUTPUT));
            this.linklbl_sample_output_reanalyzedaoi_aoi_visualizetracking.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_LinkClicked);
            pnl_info.Controls.Add(pnl_output, 0, 11);
            pnl_info.SetColumnSpan(pnl_output, 2);

            pnl_main_reanalyseAOI.Controls.Add(pnl_info, 0, 0);
            pnl_main_reanalyseAOI.SetColumnSpan(pnl_info, 2);
            pnl_main_reanalyseAOI.Controls.Add(btn_gotoFunction_reanalyseAOIs_AOIAnalysis, 1, 1);
            pnl_main_reanalyseAOI.Controls.Add(btn_gotoFunction_home_reanalyseAOIs_AOIAnalysis, 0, 1);

            return pnl_main_reanalyseAOI;
        }

        private void linklbl_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            string target = e.Link.LinkData as string;

            // If the value looks like a URL, navigate to it.
            // Otherwise, display it in a message box.
            if (null != target && target.StartsWith("https:"))
            {
                System.Diagnostics.Process.Start(target);
            }
            else
            {
                MessageBox.Show("Item clicked: " + target);
            }

        }
    }
}
