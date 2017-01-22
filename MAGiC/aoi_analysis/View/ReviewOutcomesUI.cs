using System;
using System.Drawing;
using System.Windows.Forms;

namespace MAGiC
{
    public  class ReviewOutcomesUI : ParentUI
    {
        public TableLayoutPanel pnl_visualizeTrackingResults, pnl_findDetectionRatio, pnl_labelAOIMAnually, pnl_reanalyseAOI;

        public ReviewOutcomesUI(INavigationListener _navigationListener) : base(_navigationListener)
        {
            pnl_visualizeTrackingResults = CreateVisualizeTrackingResults();
            pnl_findDetectionRatio = CreateFindDetectionRatio();
            pnl_labelAOIMAnually = CreateLabelAOIMAnually();
            pnl_reanalyseAOI = CreateReanalyseAOI();
        }

        /* Visualize Tracking controls*/
        /**********************************************************************************************/
        public ToolTip tt_videoFile_visualizeTracking = new ToolTip();
        public ToolTip tt_2dlandmark_visualizeTracking = new ToolTip();
        public ToolTip tt_rawGazeDataFile_visualizeTracking = new ToolTip();
        public ToolTip tt_aois_visualizeTracking = new ToolTip();
        public ToolTip tt_imageSizeEyeTrackerWidth_visualizeTracking = new ToolTip();
        public ToolTip tt_imageSizeEyeTrackerHeight_visualizeTracking = new ToolTip();
        public ToolTip tt_confidenceThreshold_visualizeTracking = new ToolTip();
        public ToolTip tt_errorSizeEyeTrackerWidth_visualizeTracking = new ToolTip();
        public ToolTip tt_errorSizeEyeTrackerHeight_visualizeTracking = new ToolTip();
        public ToolTip tt_visualizeJustExpIntervalFileName_visualizeTracking = new ToolTip();
        public ToolTip tt_visualizeJustExpIntervalFrequency_visualizeTracking = new ToolTip();
        public ToolTip tt_rbOptionFirstParticipant_visualizeTracking = new ToolTip();
        public ToolTip tt_rbOptionSecondParticipant_visualizeTracking = new ToolTip();
        public ToolTip tt_rbOptionSingleParticipant_visualizeTracking = new ToolTip();
        public ToolTip tt_visualizeJustExpIntervalParticipantNo_visualizeTracking = new ToolTip();

        public Button btn_gotoWalkthrough_visualizeTracking = new Button { Text = "Go to Walkthrough", AutoSize = true, BackColor = Color.AliceBlue, Font = new Font("Arial", 10, FontStyle.Bold) };
        public Label lbl_emptyrow_under_info_visualizeTracking = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };

        public Label lbl_videoFile_visualizeTracking = new Label { Text = "Video File:", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public TextBox txt_videoFile_visualizeTracking = new TextBox { AutoSize = true, Width = 600 };
        public OpenFileDialog ofd_videoFile_visualizeTracking = new OpenFileDialog();
        public Button btn_browsevideoFile_visualizeTracking = new Button { Text = "...", AutoSize = true, BackColor = Color.AliceBlue, Width = 30, Font = new Font("Arial", 10, FontStyle.Bold) };
        public Label lbl_empty_videoFile_visualizeTracking = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };


        public Label lbl_2dlandmark_visualizeTracking = new Label { Text = "2d Landmark File:", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public TextBox txt_2dlandmark_visualizeTracking = new TextBox { AutoSize = true, Width = 600 };
        public Button btn_browse2dlandmark_visualizeTracking = new Button { Text = "...", AutoSize = true, BackColor = Color.AliceBlue, Width = 30, Font = new Font("Arial", 10, FontStyle.Bold) };
        public Label lbl_empty_2dlandmark_visualizeTracking = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };
        public OpenFileDialog ofd_2dlandmark_visualizeTracking = new OpenFileDialog();


        public Label lbl_rawGazeDataFile_visualizeTracking = new Label { Text = "Raw Gaze-Data File:", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public TextBox txt_rawGazeDataFile_visualizeTracking = new TextBox { AutoSize = true, Width = 600 };
        public Button btn_browseRawGazeDataFile_visualizeTracking = new Button { Text = "...", AutoSize = true, BackColor = Color.AliceBlue, Width = 30, Font = new Font("Arial", 10, FontStyle.Bold) };
        public Label lbl_empty_rawGazeDataFile_visualizeTracking = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };
        public OpenFileDialog ofd_rawGazeDataFile_visualizeTracking = new OpenFileDialog();

        public Label lbl_aois_visualizeTracking = new Label { Text = "AOIs File (Optional):", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public TextBox txt_aois_visualizeTracking = new TextBox { AutoSize = true, Width = 600 };
        public Button btn_browseaois_visualizeTracking = new Button { Text = "...", AutoSize = true, BackColor = Color.AliceBlue, Width = 30, Font = new Font("Arial", 10, FontStyle.Bold) };
        public Label lbl_empty_aois_visualizeTracking = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };
        public OpenFileDialog ofd_aois_visualizeTracking = new OpenFileDialog();
        

        public Label lbl_imageSizeEyeTracker_visualizeTracking = new Label { Text = "Image-Size:", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public TextBox txt_imageSizeEyeTrackerWidth_visualizeTracking = new TextBox { AutoSize = true, Width = 100 };
        public Label lbl_imageSizeEyeTrackerTo_visualizeTracking = new Label { Text = "  ", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public TextBox txt_imageSizeEyeTrackerHeight_visualizeTracking = new TextBox { AutoSize = true, Width = 100 };
        public Label lbl_empty_imageSizeEyeTracker_visualizeTracking = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };

        public Label lbl_confidenceThreshold_visualizeTracking = new Label { Text = "Confidence Threshold (Optional):", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public TextBox txt_confidenceThreshold_visualizeTracking = new TextBox { AutoSize = true, Width = 100 };
        public Label lbl_empty_confidenceThreshold_visualizeTracking = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };
       

        public Label lbl_errorSizeEyeTracker_visualizeTracking = new Label { Text = "Fixation Error(Optional):", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public TextBox txt_errorSizeEyeTrackerWidth_visualizeTracking = new TextBox { AutoSize = true, Width = 100 };
        public Label lbl_errorSizeEyeTrackerTo_visualizeTracking = new Label { Text = "  ", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public TextBox txt_errorSizeEyeTrackerHeight_visualizeTracking = new TextBox { AutoSize = true, Width = 100 };
        public Label lbl_empty_errorSizeEyeTracker_visualizeTracking = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };
        
        
        public CheckBox cb_visualizeJustExpInterval_visualizeTracking = new CheckBox { Checked = true, AutoSize = true, Text = "Visualize Just Experimental Interval (Optional)", Font = new Font("Arial", 11, FontStyle.Bold) };
        public Label lbl_visualizeJustExpIntervalFileName_visualizeTracking = new Label { Text = "Experiment Interval File:", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public TextBox txt_visualizeJustExpIntervalFileName_visualizeTracking = new TextBox { AutoSize = true, Width = 600 };
        public Button btn_browseVisualizeJustExpIntervalFileName_visualizeTracking = new Button { Text = "...", AutoSize = true, BackColor = Color.AliceBlue, Width = 30, Font = new Font("Arial", 10, FontStyle.Bold) };
        public Label lbl_empty_visualizeJustExpIntervalFileName_visualizeTracking = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };
        public OpenFileDialog ofd_visualizeJustExpIntervalFileName_visualizeTracking = new OpenFileDialog();

        public Label lbl_visualizeJustExpIntervalParticipantNo_visualizeTracking = new Label { Text = "Participant Id:", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public TextBox txt_visualizeJustExpIntervalParticipantNo_visualizeTracking = new TextBox { AutoSize = true, Width = 100 };
        public Label lbl_empty_visualizeJustExpIntervalParticipantNo_visualizeTracking = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };

        public RadioButton rbOptionFirstParticipant_visualizeTracking = new RadioButton { Text = "First Participant", AutoSize = true, TabStop = true,  Font = new Font("Arial", 11, FontStyle.Bold) };
        public RadioButton rbOptionSecondParticipant_visualizeTracking = new RadioButton { Text = "Second Participant", AutoSize = true, TabStop = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public RadioButton rbOptionSingleParticipant_visualizeTracking = new RadioButton { Text = "Single Participant", AutoSize = true, TabStop = true,  Font = new Font("Arial", 11, FontStyle.Bold) };

        public Label lbl_visualizeJustExpIntervalFrequency_visualizeTracking = new Label { Text = "Eye Tracker Frequency:", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public TextBox txt_visualizeJustExpIntervalFrequency_visualizeTracking = new TextBox { AutoSize = true, Width = 100 };
        public Label lbl_empty_visualizeJustExpIntervalFrequency_visualizeTracking = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };
        public Label lbl_visualizeJustExpIntervalFrequencyHz_visualizeTracking = new Label { Text = " Hz. ", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };

        public Button btn_visualize_visualizeTracking = new Button { Text = "Visualize", AutoSize = true, BackColor = Constants.BUTTON_BACKCOLOR, ForeColor = Constants.BUTTON_FORECOLOR, Font = Constants.BUTTON_FONT };



        public ErrorProvider errorProvider_videoFile_visualizeTracking = new System.Windows.Forms.ErrorProvider();
        public ErrorProvider errorProvider_2dlandmark_visualizeTracking = new System.Windows.Forms.ErrorProvider();
        public ErrorProvider errorProvider_rawGazeDataFile_visualizeTracking = new System.Windows.Forms.ErrorProvider();
        public ErrorProvider errorProvider_aois_visualizeTracking = new System.Windows.Forms.ErrorProvider();
        public ErrorProvider errorProvider_confidenceThreshold_visualizeTracking = new System.Windows.Forms.ErrorProvider();
        public ErrorProvider errorProvider_imageSizeEyeTracker_visualizeTracking = new System.Windows.Forms.ErrorProvider();
        public ErrorProvider errorProvider_errorSizeEyeTracker_visualizeTracking = new System.Windows.Forms.ErrorProvider();
        public ErrorProvider errorProvider_visualizeJustExpIntervalFileName_visualizeTracking = new System.Windows.Forms.ErrorProvider();
        public ErrorProvider errorProvider_visualizeJustExpIntervalParticipantNo_visualizeTracking = new System.Windows.Forms.ErrorProvider();
        public ErrorProvider errorProvider_visualizeJustExpIntervalHz_visualizeTracking = new System.Windows.Forms.ErrorProvider();

        public TableLayoutPanel pnl_visualizeJustExpInterval;
        /*End of Visualize Tracking  controls */


        /* AOIs Detection Ratio controls*/
        /**********************************************************************************************/
        public ToolTip tt_aois_AOIDetectionRatio = new ToolTip();
        public ToolTip tt_ExpIntervalFileName_AOIDetectionRatio = new ToolTip();
        public ToolTip tt_ExpIntervalFrequency_AOIDetectionRatio = new ToolTip();
        public ToolTip tt_rbOptionFirstParticipant_AOIDetectionRatio = new ToolTip();
        public ToolTip tt_rbOptionSecondParticipant_AOIDetectionRatio = new ToolTip();
        public ToolTip tt_rbOptionSingleParticipant_AOIDetectionRatio = new ToolTip();
        public ToolTip tt_ExpIntervalParticipantNo_AOIDetectionRatio = new ToolTip();


        public Button btn_gotoWalkthrough_AOIDetectionRatio = new Button { Text = "Go to Walkthrough", AutoSize = true, BackColor = Color.AliceBlue, Font = new Font("Arial", 10, FontStyle.Bold) };
        public Label lbl_emptyrow_under_info_AOIDetectionRatio = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };

        public Label lbl_aois_AOIDetectionRatio = new Label { Text = "AOIs File:", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public TextBox txt_aois_AOIDetectionRatio = new TextBox { AutoSize = true, Width = 600 };
        public Button btn_browseaois_AOIDetectionRatio = new Button { Text = "...", AutoSize = true, BackColor = Color.AliceBlue, Width = 30, Font = new Font("Arial", 10, FontStyle.Bold) };
        public Label lbl_empty_aois_AOIDetectionRatio = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };
        public OpenFileDialog ofd_aois_AOIDetectionRatio = new OpenFileDialog();

        
        public Label lbl_ExpIntervalFileName_AOIDetectionRatio = new Label { Text = "Experiment Interval File:", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public TextBox txt_ExpIntervalFileName_AOIDetectionRatio = new TextBox { AutoSize = true, Width = 600 };
        public Button btn_browseExpIntervalFileName_AOIDetectionRatio = new Button { Text = "...", AutoSize = true, BackColor = Color.AliceBlue, Width = 30, Font = new Font("Arial", 10, FontStyle.Bold) };
        public Label lbl_empty_ExpIntervalFileName_AOIDetectionRatio = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };
        public OpenFileDialog ofd_ExpIntervalFileName_AOIDetectionRatio = new OpenFileDialog();

        public Label lbl_ExpIntervalParticipantNo_AOIDetectionRatio = new Label { Text = "Participant Id:", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public TextBox txt_ExpIntervalParticipantNo_AOIDetectionRatio = new TextBox { AutoSize = true, Width = 100 };
        public Label lbl_empty_ExpIntervalParticipantNo_AOIDetectionRatio = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };

        public RadioButton rbOptionFirstParticipant_AOIDetectionRatio = new RadioButton { Text = "First Participant", AutoSize = true, TabStop = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public RadioButton rbOptionSecondParticipant_AOIDetectionRatio = new RadioButton { Text = "Second Participant", AutoSize = true, TabStop = true,  Font = new Font("Arial", 11, FontStyle.Bold) };
        public RadioButton rbOptionSingleParticipant_AOIDetectionRatio = new RadioButton { Text = "Single Participant", AutoSize = true, TabStop = true,  Font = new Font("Arial", 11, FontStyle.Bold) };

        public Label lbl_ExpIntervalFrequency_AOIDetectionRatio = new Label { Text = "Eye Tracker Frequency:", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public TextBox txt_ExpIntervalFrequency_AOIDetectionRatio = new TextBox { AutoSize = true, Width = 100 };
        public Label lbl_empty_ExpIntervalFrequency_AOIDetectionRatio = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };
        public Label lbl_ExpIntervalFrequencyHz_AOIDetectionRatio = new Label { Text = " Hz. ", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };

        public Button btn_findRatio_AOIDetectionRatio = new Button { Text = "Find", AutoSize = true, BackColor = Constants.BUTTON_BACKCOLOR, ForeColor = Constants.BUTTON_FORECOLOR, Font = Constants.BUTTON_FONT };

        public ErrorProvider errorProvider_aois_AOIDetectionRatio = new System.Windows.Forms.ErrorProvider();
        public ErrorProvider errorProvider_ExpIntervalFileName_AOIDetectionRatio = new System.Windows.Forms.ErrorProvider();
        public ErrorProvider errorProvider_ExpIntervalParticipantNo_AOIDetectionRatio = new System.Windows.Forms.ErrorProvider();
        public ErrorProvider errorProvider_ExpIntervalHz_AOIDetectionRatio = new System.Windows.Forms.ErrorProvider();

        /*End of AOIs Detection Ratio  controls */


        /* Label AOIs manually controls*/
        /**********************************************************************************************/
        public ToolTip tt_outputFile_labelROIManually = new ToolTip();
        public ToolTip tt_videoFile_labelROIManually = new ToolTip();
        public ToolTip tt_2dlandmark_labelROIManually = new ToolTip();
        public ToolTip tt_rawGazeDataFile_labelROIManually = new ToolTip();
        public ToolTip tt_aois_labelROIManually = new ToolTip();
        public ToolTip tt_imageSizeEyeTrackerWidth_labelROIManually = new ToolTip();
        public ToolTip tt_imageSizeEyeTrackerHeight_labelROIManually = new ToolTip();
        public ToolTip tt_confidenceThreshold_labelROIManually = new ToolTip();
        public ToolTip tt_errorSizeEyeTrackerWidth_labelROIManually = new ToolTip();
        public ToolTip tt_errorSizeEyeTrackerHeight_labelROIManually = new ToolTip();
        public ToolTip tt_visualizeJustExpIntervalFileName_labelROIManually = new ToolTip();
        public ToolTip tt_visualizeJustExpIntervalFrequency_labelROIManually = new ToolTip();
        public ToolTip tt_rbOptionFirstParticipant_labelROIManually = new ToolTip();
        public ToolTip tt_rbOptionSecondParticipant_labelROIManually = new ToolTip();
        public ToolTip tt_rbOptionSingleParticipant_labelROIManually = new ToolTip();
        public ToolTip tt_visualizeJustExpIntervalParticipantNo_labelROIManually = new ToolTip();

        public Button btn_gotoWalkthrough_labelROIManually = new Button { Text = "Go to Walkthrough", AutoSize = true, BackColor = Color.AliceBlue, Font = new Font("Arial", 10, FontStyle.Bold) };
        public Label lbl_emptyrow_under_info_labelROIManually = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };

        public Label lbl_outputFile_labelROIManually = new Label { Text = "Output File:", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public TextBox txt_outputFile_labelROIManually = new TextBox { AutoSize = true, Width = 600 };
        public Button btn_createOutputFile_labelROIManually = new Button { Text = "Create", AutoSize = true, BackColor = Color.AliceBlue, Width = 30, Font = new Font("Arial", 10, FontStyle.Bold) };
        public Label lbl_empty_outputFile_labelROIManually = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };
        public SaveFileDialog sfd_outputFile_labelROIManually = new SaveFileDialog();

        public Label lbl_videoFile_labelROIManually = new Label { Text = "Video File:", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public TextBox txt_videoFile_labelROIManually = new TextBox { AutoSize = true, Width = 600 };
        public OpenFileDialog ofd_videoFile_labelROIManually = new OpenFileDialog();
        public Button btn_browsevideoFile_labelROIManually = new Button { Text = "...", AutoSize = true, BackColor = Color.AliceBlue, Width = 30, Font = new Font("Arial", 10, FontStyle.Bold) };
        public Label lbl_empty_videoFile_labelROIManually = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };


        public Label lbl_2dlandmark_labelROIManually = new Label { Text = "2d Landmark File:", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public TextBox txt_2dlandmark_labelROIManually = new TextBox { AutoSize = true, Width = 600 };
        public Button btn_browse2dlandmark_labelROIManually = new Button { Text = "...", AutoSize = true, BackColor = Color.AliceBlue, Width = 30, Font = new Font("Arial", 10, FontStyle.Bold) };
        public Label lbl_empty_2dlandmark_labelROIManually = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };
        public OpenFileDialog ofd_2dlandmark_labelROIManually = new OpenFileDialog();


        public Label lbl_rawGazeDataFile_labelROIManually = new Label { Text = "Raw Gaze-Data File:", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public TextBox txt_rawGazeDataFile_labelROIManually = new TextBox { AutoSize = true, Width = 600 };
        public Button btn_browseRawGazeDataFile_labelROIManually = new Button { Text = "...", AutoSize = true, BackColor = Color.AliceBlue, Width = 30, Font = new Font("Arial", 10, FontStyle.Bold) };
        public Label lbl_empty_rawGazeDataFile_labelROIManually = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };
        public OpenFileDialog ofd_rawGazeDataFile_labelROIManually = new OpenFileDialog();

        public Label lbl_aois_labelROIManually = new Label { Text = "AOIs File (Optional):", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public TextBox txt_aois_labelROIManually = new TextBox { AutoSize = true, Width = 600 };
        public Button btn_browseaois_labelROIManually = new Button { Text = "...", AutoSize = true, BackColor = Color.AliceBlue, Width = 30, Font = new Font("Arial", 10, FontStyle.Bold) };
        public Label lbl_empty_aois_labelROIManually = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };
        public OpenFileDialog ofd_aois_labelROIManually = new OpenFileDialog();


        public Label lbl_imageSizeEyeTracker_labelROIManually = new Label { Text = "Image-Size:", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public TextBox txt_imageSizeEyeTrackerWidth_labelROIManually = new TextBox { AutoSize = true, Width = 100 };
        public Label lbl_imageSizeEyeTrackerTo_labelROIManually = new Label { Text = "  ", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public TextBox txt_imageSizeEyeTrackerHeight_labelROIManually = new TextBox { AutoSize = true, Width = 100 };
        public Label lbl_empty_imageSizeEyeTracker_labelROIManually = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };

        public Label lbl_confidenceThreshold_labelROIManually = new Label { Text = "Confidence Threshold (Optional):", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public TextBox txt_confidenceThreshold_labelROIManually = new TextBox { AutoSize = true, Width = 100 };
        public Label lbl_empty_confidenceThreshold_labelROIManually = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };


        public Label lbl_errorSizeEyeTracker_labelROIManually = new Label { Text = "Fixation Error(Optional):", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public TextBox txt_errorSizeEyeTrackerWidth_labelROIManually = new TextBox { AutoSize = true, Width = 100 };
        public Label lbl_errorSizeEyeTrackerTo_labelROIManually = new Label { Text = "  ", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public TextBox txt_errorSizeEyeTrackerHeight_labelROIManually = new TextBox { AutoSize = true, Width = 100 };
        public Label lbl_empty_errorSizeEyeTracker_labelROIManually = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };


        public CheckBox cb_visualizeJustExpInterval_labelROIManually = new CheckBox { Checked = true, AutoSize = true, Text = "Visualize Just Experimental Interval (Optional)", Font = new Font("Arial", 11, FontStyle.Bold) };
        public Label lbl_visualizeJustExpIntervalFileName_labelROIManually = new Label { Text = "Experiment Interval File:", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public TextBox txt_visualizeJustExpIntervalFileName_labelROIManually = new TextBox { AutoSize = true, Width = 600 };
        public Button btn_browseVisualizeJustExpIntervalFileName_labelROIManually = new Button { Text = "...", AutoSize = true, BackColor = Color.AliceBlue, Width = 30, Font = new Font("Arial", 10, FontStyle.Bold) };
        public Label lbl_empty_visualizeJustExpIntervalFileName_labelROIManually = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };
        public OpenFileDialog ofd_visualizeJustExpIntervalFileName_labelROIManually = new OpenFileDialog();

        public Label lbl_visualizeJustExpIntervalParticipantNo_labelROIManually = new Label { Text = "Participant Id:", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public TextBox txt_visualizeJustExpIntervalParticipantNo_labelROIManually = new TextBox { AutoSize = true, Width = 100 };
        public Label lbl_empty_visualizeJustExpIntervalParticipantNo_labelROIManually = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };

        public RadioButton rbOptionFirstParticipant_labelROIManually = new RadioButton { Text = "First Participant", AutoSize = true, TabStop = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public RadioButton rbOptionSecondParticipant_labelROIManually = new RadioButton { Text = "Second Participant", AutoSize = true, TabStop = true,  Font = new Font("Arial", 11, FontStyle.Bold) };
        public RadioButton rbOptionSingleParticipant_labelROIManually = new RadioButton { Text = "Single Participant", AutoSize = true, TabStop = true,  Font = new Font("Arial", 11, FontStyle.Bold) };

        public Label lbl_visualizeJustExpIntervalFrequency_labelROIManually = new Label { Text = "Eye Tracker Frequency:", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public TextBox txt_visualizeJustExpIntervalFrequency_labelROIManually = new TextBox { AutoSize = true, Width = 100 };
        public Label lbl_empty_visualizeJustExpIntervalFrequency_labelROIManually = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };
        public Label lbl_visualizeJustExpIntervalFrequencyHz_labelROIManually = new Label { Text = " Hz. ", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };

        public Button btn_labelROIManually = new Button { Text = "Label", AutoSize = true, BackColor = Constants.BUTTON_BACKCOLOR, ForeColor = Constants.BUTTON_FORECOLOR, Font = Constants.BUTTON_FONT };

  

        public ErrorProvider errorProvider_outputFile_labelROIManually = new System.Windows.Forms.ErrorProvider();
        public ErrorProvider errorProvider_videoFile_labelROIManually = new System.Windows.Forms.ErrorProvider();
        public ErrorProvider errorProvider_2dlandmark_labelROIManually = new System.Windows.Forms.ErrorProvider();
        public ErrorProvider errorProvider_rawGazeDataFile_labelROIManually = new System.Windows.Forms.ErrorProvider();
        public ErrorProvider errorProvider_aois_labelROIManually = new System.Windows.Forms.ErrorProvider();
        public ErrorProvider errorProvider_confidenceThreshold_labelROIManually = new System.Windows.Forms.ErrorProvider();
        public ErrorProvider errorProvider_imageSizeEyeTracker_labelROIManually = new System.Windows.Forms.ErrorProvider();
        public ErrorProvider errorProvider_errorSizeEyeTracker_labelROIManually = new System.Windows.Forms.ErrorProvider();
        public ErrorProvider errorProvider_visualizeJustExpIntervalFileName_labelROIManually = new System.Windows.Forms.ErrorProvider();
        public ErrorProvider errorProvider_visualizeJustExpIntervalParticipantNo_labelROIManually = new System.Windows.Forms.ErrorProvider();
        public ErrorProvider errorProvider_visualizeJustExpIntervalHz_labelROIManually = new System.Windows.Forms.ErrorProvider();

        public TableLayoutPanel pnl_visualizeJustExpInterval_labelROIManually;
        /*End of Label AOIs manually  controls */

        /* Reanalyze Face as AOI controls*/
        /**********************************************************************************************/
        public ToolTip tt_outputFile_reanalyzeAOI = new ToolTip();
        public ToolTip tt_manuallyLabeled_reanalyzeAOI = new ToolTip();
        public ToolTip tt_rawGazeDataFile_reanalyzeAOI = new ToolTip();
        public ToolTip tt_2dlandmark_reanalyzeAOI = new ToolTip();
        public ToolTip tt_imageSizeTrakingFramework_reanalyzeAOI = new ToolTip();
        public ToolTip tt_imageSizeEyeTrackerWidth_reanalyzeAOI = new ToolTip();
        public ToolTip tt_imageSizeEyeTrackerHeight_reanalyzeAOI = new ToolTip();

        public Button btn_gotoWalkthrough_reanalyzeAOI = new Button { Text = "Go to Walkthrough", AutoSize = true, BackColor = Color.AliceBlue, Font = new Font("Arial", 10, FontStyle.Bold) };
        public Label lbl_emptyrow_under_info_reanalyzeAOI = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };

        public Label lbl_outputFile_reanalyzeAOI = new Label { Text = "Output File:", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public TextBox txt_outputFile_reanalyzeAOI = new TextBox { AutoSize = true, Width = 600 };
        public Button btn_createOutputFile_reanalyzeAOI = new Button { Text = "Create", AutoSize = true, BackColor = Color.AliceBlue, Width = 30, Font = new Font("Arial", 10, FontStyle.Bold) };
        public Label lbl_empty_outputFile_reanalyzeAOI = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };
        public SaveFileDialog sfd_outputFile_reanalyzeAOI = new SaveFileDialog();

        public Label lbl_manuallyLabeled_reanalyzeAOI = new Label { Text = "AOIs File:", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public TextBox txt_manuallyLabeled_reanalyzeAOI = new TextBox { AutoSize = true, Width = 600 };
        public Button btn_browseManuallyLabeled_reanalyzeAOI = new Button { Text = "...", AutoSize = true, BackColor = Color.AliceBlue, Width = 30, Font = new Font("Arial", 10, FontStyle.Bold) };
        public Label lbl_empty_manuallyLabeled_reanalyzeAOI = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };
        public OpenFileDialog ofd_manuallyLabeled_reanalyzeAOI = new OpenFileDialog();

        public Label lbl_rawGazeDataFile_reanalyzeAOI = new Label { Text = "Raw Gaze-Data File:", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public TextBox txt_rawGazeDataFile_reanalyzeAOI = new TextBox { AutoSize = true, Width = 600 };
        public Button btn_browseRawGazeDataFile_reanalyzeAOI = new Button { Text = "...", AutoSize = true, BackColor = Color.AliceBlue, Width = 30, Font = new Font("Arial", 10, FontStyle.Bold) };
        public Label lbl_empty_rawGazeDataFile_reanalyzeAOI = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };
        public OpenFileDialog ofd_rawGazeDataFile_reanalyzeAOI = new OpenFileDialog();

        public Label lbl_2dlandmark_reanalyzeAOI = new Label { Text = "2d Landmark File:", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public TextBox txt_2dlandmark_reanalyzeAOI = new TextBox { AutoSize = true, Width = 600 };
        public Button btn_browse2dlandmark_reanalyzeAOI = new Button { Text = "...", AutoSize = true, BackColor = Color.AliceBlue, Width = 30, Font = new Font("Arial", 10, FontStyle.Bold) };
        public Label lbl_empty_2dlandmark_reanalyzeAOI = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };
        public OpenFileDialog ofd_2dlandmark_reanalyzeAOI = new OpenFileDialog();

        public Label lbl_imageSizeTrakingFramework_reanalyzeAOI = new Label { Text = "Image-Size File:", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public TextBox txt_imageSizeTrakingFramework_reanalyzeAOI = new TextBox { AutoSize = true, Width = 600 };
        public Button btn_browseImageSizeTrakingFramework_reanalyzeAOI = new Button { Text = "...", AutoSize = true, BackColor = Color.AliceBlue, Width = 30, Font = new Font("Arial", 10, FontStyle.Bold) };
        public Label lbl_empty_imageSizeTrakingFramework_reanalyzeAOI = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };
        public OpenFileDialog ofd_imageSizeTrakingFramework_reanalyzeAOI = new OpenFileDialog();

        public Label lbl_imageSizeEyeTracker_reanalyzeAOI = new Label { Text = "Image-Size:", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public TextBox txt_imageSizeEyeTrackerWidth_reanalyzeAOI = new TextBox { AutoSize = true, Width = 100 };
        public TextBox txt_imageSizeEyeTrackerHeight_reanalyzeAOI = new TextBox { AutoSize = true, Width = 100 };
        public Label lbl_empty_imageSizeEyeTracker_reanalyzeAOI = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };



        public Button btn_analyse_reanalyzeAOI = new Button { Text = "Analyse", AutoSize = true, BackColor = Constants.BUTTON_BACKCOLOR, ForeColor = Constants.BUTTON_FORECOLOR, Font = Constants.BUTTON_FONT };

       

        public ErrorProvider errorProvider_outputFile_reanalyzeAOI = new System.Windows.Forms.ErrorProvider();
        public ErrorProvider errorProvider_manuallyLabeled_reanalyzeAOI = new System.Windows.Forms.ErrorProvider();
        public ErrorProvider errorProvider_rawGazeDataFile_reanalyzeAOI = new System.Windows.Forms.ErrorProvider();
        public ErrorProvider errorProvider_2dlandmark_reanalyzeAOI = new System.Windows.Forms.ErrorProvider();
        public ErrorProvider errorProvider_imageSizeTrakingFramework_reanalyzeAOI = new System.Windows.Forms.ErrorProvider();
        public ErrorProvider errorProvider_imageSizeEyeTracker_reanalyzeAOI = new System.Windows.Forms.ErrorProvider();
        /*End of Reanalyze Face as AOI controls */

        private TableLayoutPanel CreateVisualizeTrackingResults()
        {
            TableLayoutPanel pnl_visualizeTrackingResults = new TableLayoutPanel { Dock = DockStyle.Fill, AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_visualizeTrackingResults.Margin = new Padding(0);
            pnl_visualizeTrackingResults.ColumnCount = 7;
            pnl_visualizeTrackingResults.RowCount = 12;

            TableLayoutPanel pnl_info_visualizeTrackingResults = new TableLayoutPanel { Dock = DockStyle.Fill, AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_info_visualizeTrackingResults.Margin = new Padding(0);
            pnl_info_visualizeTrackingResults.BackColor = System.Drawing.Color.LightBlue;
            pnl_info_visualizeTrackingResults.Controls.Add(btn_gotoWalkthrough_visualizeTracking);
            pnl_visualizeTrackingResults.Controls.Add(pnl_info_visualizeTrackingResults, 0, 0);
            pnl_visualizeTrackingResults.SetColumnSpan(pnl_info_visualizeTrackingResults, 7);
            pnl_visualizeTrackingResults.Controls.Add(lbl_emptyrow_under_info_visualizeTracking, 0, 1);

            pnl_visualizeTrackingResults.Controls.Add(lbl_videoFile_visualizeTracking, 0, 2);
            pnl_visualizeTrackingResults.Controls.Add(txt_videoFile_visualizeTracking, 1, 2);
            pnl_visualizeTrackingResults.SetColumnSpan(txt_videoFile_visualizeTracking, 3);
            tt_videoFile_visualizeTracking.SetToolTip(txt_videoFile_visualizeTracking, Constants.TOOLTIP_VIDEORECORDING);
            pnl_visualizeTrackingResults.Controls.Add(lbl_empty_videoFile_visualizeTracking, 4, 2);
            pnl_visualizeTrackingResults.Controls.Add(btn_browsevideoFile_visualizeTracking, 5, 2);

            pnl_visualizeTrackingResults.Controls.Add(lbl_2dlandmark_visualizeTracking, 0, 3);
            pnl_visualizeTrackingResults.Controls.Add(txt_2dlandmark_visualizeTracking, 1, 3);
            pnl_visualizeTrackingResults.SetColumnSpan(txt_2dlandmark_visualizeTracking, 3);
            tt_2dlandmark_visualizeTracking.SetToolTip(txt_2dlandmark_visualizeTracking, Constants.TOOLTIP_2dLANDMARK_FILE);
            pnl_visualizeTrackingResults.Controls.Add(lbl_empty_2dlandmark_visualizeTracking, 4, 3);
            pnl_visualizeTrackingResults.Controls.Add(btn_browse2dlandmark_visualizeTracking, 5, 3);

            pnl_visualizeTrackingResults.Controls.Add(lbl_rawGazeDataFile_visualizeTracking, 0, 4);
            pnl_visualizeTrackingResults.Controls.Add(txt_rawGazeDataFile_visualizeTracking, 1, 4);
            pnl_visualizeTrackingResults.SetColumnSpan(txt_rawGazeDataFile_visualizeTracking, 3);
            tt_rawGazeDataFile_visualizeTracking.SetToolTip(txt_rawGazeDataFile_visualizeTracking, Constants.TOOLTIP_RAWGAZEDATA_FILE);
            pnl_visualizeTrackingResults.Controls.Add(lbl_empty_rawGazeDataFile_visualizeTracking, 4, 4);
            pnl_visualizeTrackingResults.Controls.Add(btn_browseRawGazeDataFile_visualizeTracking, 5, 4);

            pnl_visualizeTrackingResults.Controls.Add(lbl_aois_visualizeTracking, 0, 5);
            pnl_visualizeTrackingResults.Controls.Add(txt_aois_visualizeTracking, 1, 5);
            pnl_visualizeTrackingResults.SetColumnSpan(txt_aois_visualizeTracking, 3);
            tt_aois_visualizeTracking.SetToolTip(txt_aois_visualizeTracking, Constants.TOOLTIP_AOI_FILE);
            pnl_visualizeTrackingResults.Controls.Add(lbl_empty_aois_visualizeTracking, 4, 5);
            pnl_visualizeTrackingResults.Controls.Add(btn_browseaois_visualizeTracking, 5, 5);

            pnl_visualizeTrackingResults.Controls.Add(lbl_imageSizeEyeTracker_visualizeTracking, 0, 6);
            pnl_visualizeTrackingResults.Controls.Add(txt_imageSizeEyeTrackerWidth_visualizeTracking, 1, 6);
            tt_imageSizeEyeTrackerWidth_visualizeTracking.SetToolTip(txt_imageSizeEyeTrackerWidth_visualizeTracking, Constants.TOOLTIP_IMAGESIZE);
            pnl_visualizeTrackingResults.Controls.Add(lbl_imageSizeEyeTrackerTo_visualizeTracking, 2, 6);
            pnl_visualizeTrackingResults.Controls.Add(txt_imageSizeEyeTrackerHeight_visualizeTracking, 3, 6);
            tt_imageSizeEyeTrackerHeight_visualizeTracking.SetToolTip(txt_imageSizeEyeTrackerHeight_visualizeTracking, Constants.TOOLTIP_IMAGESIZE);

            pnl_visualizeTrackingResults.Controls.Add(lbl_confidenceThreshold_visualizeTracking, 0, 7);
            pnl_visualizeTrackingResults.Controls.Add(txt_confidenceThreshold_visualizeTracking, 1, 7);
            tt_confidenceThreshold_visualizeTracking.SetToolTip(txt_confidenceThreshold_visualizeTracking, Constants.TOOLTIP_CONFIDENCE_THRESHOLD);
            pnl_visualizeTrackingResults.Controls.Add(lbl_empty_confidenceThreshold_visualizeTracking, 2, 7);

            pnl_visualizeTrackingResults.Controls.Add(lbl_errorSizeEyeTracker_visualizeTracking, 0, 8);
            pnl_visualizeTrackingResults.Controls.Add(txt_errorSizeEyeTrackerWidth_visualizeTracking, 1, 8);
            tt_errorSizeEyeTrackerWidth_visualizeTracking.SetToolTip(txt_errorSizeEyeTrackerWidth_visualizeTracking, Constants.TOOLTIP_FIXATION_ERRORSIZE);
            pnl_visualizeTrackingResults.Controls.Add(lbl_errorSizeEyeTrackerTo_visualizeTracking, 2, 8);
            pnl_visualizeTrackingResults.Controls.Add(txt_errorSizeEyeTrackerHeight_visualizeTracking, 3, 8);
            tt_errorSizeEyeTrackerHeight_visualizeTracking.SetToolTip(txt_errorSizeEyeTrackerHeight_visualizeTracking, Constants.TOOLTIP_FIXATION_ERRORSIZE);
            pnl_visualizeTrackingResults.Controls.Add(lbl_empty_errorSizeEyeTracker_visualizeTracking, 4, 8);

            pnl_visualizeTrackingResults.Controls.Add(cb_visualizeJustExpInterval_visualizeTracking, 0, 9);
            pnl_visualizeTrackingResults.SetColumnSpan(cb_visualizeJustExpInterval_visualizeTracking, 2);

            pnl_visualizeJustExpInterval = new TableLayoutPanel { Dock = DockStyle.Fill, AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_visualizeJustExpInterval.Margin = new Padding(0);
            pnl_visualizeJustExpInterval.ColumnCount = 7;
            pnl_visualizeJustExpInterval.RowCount = 4;

            pnl_visualizeJustExpInterval.Controls.Add(lbl_visualizeJustExpIntervalFileName_visualizeTracking, 0, 0);
            pnl_visualizeJustExpInterval.Controls.Add(txt_visualizeJustExpIntervalFileName_visualizeTracking, 1, 0);
            pnl_visualizeJustExpInterval.SetColumnSpan(txt_visualizeJustExpIntervalFileName_visualizeTracking, 2);
            tt_visualizeJustExpIntervalFileName_visualizeTracking.SetToolTip(txt_visualizeJustExpIntervalFileName_visualizeTracking, Constants.TOOLTIP_EXPINTERVAL_FILE);
            pnl_visualizeJustExpInterval.Controls.Add(lbl_empty_visualizeJustExpIntervalFileName_visualizeTracking, 3, 0);
            pnl_visualizeJustExpInterval.Controls.Add(btn_browseVisualizeJustExpIntervalFileName_visualizeTracking, 4, 0);

            pnl_visualizeJustExpInterval.Controls.Add(lbl_visualizeJustExpIntervalFrequency_visualizeTracking, 0, 1);
            pnl_visualizeJustExpInterval.Controls.Add(txt_visualizeJustExpIntervalFrequency_visualizeTracking, 1, 1);
            tt_visualizeJustExpIntervalFrequency_visualizeTracking.SetToolTip(txt_visualizeJustExpIntervalFrequency_visualizeTracking, Constants.TOOLTIP_ENTER_POSITIVE_INTEGER_VALUE);
            pnl_visualizeJustExpInterval.Controls.Add(lbl_visualizeJustExpIntervalFrequencyHz_visualizeTracking, 2, 1);


            TableLayoutPanel pnl_radioButtons = new TableLayoutPanel { Dock = DockStyle.Fill, AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_radioButtons.Margin = new Padding(0);
            pnl_radioButtons.ColumnCount = 3;
            pnl_radioButtons.RowCount = 1;
            pnl_radioButtons.Controls.Add(rbOptionSingleParticipant_visualizeTracking, 0, 0);
            tt_rbOptionFirstParticipant_visualizeTracking.SetToolTip(rbOptionSingleParticipant_visualizeTracking, Constants.TOOLTIP_WHICHPARTICIPANT_INEXPINTERVALFILE);
            pnl_radioButtons.Controls.Add(rbOptionFirstParticipant_visualizeTracking, 1, 0);
            tt_rbOptionSecondParticipant_visualizeTracking.SetToolTip(rbOptionFirstParticipant_visualizeTracking, Constants.TOOLTIP_WHICHPARTICIPANT_INEXPINTERVALFILE);
            pnl_radioButtons.Controls.Add(rbOptionSecondParticipant_visualizeTracking, 2, 0);
            tt_rbOptionSecondParticipant_visualizeTracking.SetToolTip(rbOptionSecondParticipant_visualizeTracking, Constants.TOOLTIP_WHICHPARTICIPANT_INEXPINTERVALFILE);
            pnl_visualizeJustExpInterval.Controls.Add(pnl_radioButtons, 0, 2);
            pnl_visualizeJustExpInterval.SetColumnSpan(pnl_radioButtons, 3);


            pnl_visualizeJustExpInterval.Controls.Add(lbl_visualizeJustExpIntervalParticipantNo_visualizeTracking, 0, 3);
            pnl_visualizeJustExpInterval.Controls.Add(txt_visualizeJustExpIntervalParticipantNo_visualizeTracking, 1, 3);
            tt_visualizeJustExpIntervalParticipantNo_visualizeTracking.SetToolTip(txt_visualizeJustExpIntervalParticipantNo_visualizeTracking, Constants.TOOLTIP_PARTICIPANTID_INEXPINTERVALFILE);

            GroupBox gb_visualizeJustExpInterval_visualizeTracking = CreateGBox("", new Label(), pnl_visualizeJustExpInterval);


            pnl_visualizeTrackingResults.Controls.Add(gb_visualizeJustExpInterval_visualizeTracking, 0, 10);
            pnl_visualizeTrackingResults.SetColumnSpan(gb_visualizeJustExpInterval_visualizeTracking, 6);

            pnl_visualizeTrackingResults.Controls.Add(btn_visualize_visualizeTracking, 0, 11);


            return pnl_visualizeTrackingResults;
        }

        private TableLayoutPanel CreateFindDetectionRatio()
        {
           
            TableLayoutPanel pnl_findDetectionRatio = new TableLayoutPanel { Dock = DockStyle.Fill, AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_findDetectionRatio.Margin = new Padding(0);
            pnl_findDetectionRatio.ColumnCount = 6;
            pnl_findDetectionRatio.RowCount = 8;

            TableLayoutPanel pnl_info_findDetectionRatio = new TableLayoutPanel { Dock = DockStyle.Fill, AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_info_findDetectionRatio.Margin = new Padding(0);
            pnl_info_findDetectionRatio.BackColor = System.Drawing.Color.LightBlue;
            pnl_info_findDetectionRatio.Controls.Add(btn_gotoWalkthrough_AOIDetectionRatio);
            pnl_findDetectionRatio.Controls.Add(pnl_info_findDetectionRatio, 0, 0);
            pnl_findDetectionRatio.SetColumnSpan(pnl_info_findDetectionRatio, 6);
            pnl_findDetectionRatio.Controls.Add(lbl_emptyrow_under_info_AOIDetectionRatio, 0, 1);

            pnl_findDetectionRatio.Controls.Add(lbl_aois_AOIDetectionRatio, 0, 2);
            pnl_findDetectionRatio.Controls.Add(txt_aois_AOIDetectionRatio, 1, 2);
            pnl_findDetectionRatio.SetColumnSpan(txt_aois_AOIDetectionRatio, 2);
            tt_aois_AOIDetectionRatio.SetToolTip(txt_aois_AOIDetectionRatio, Constants.TOOLTIP_AOI_FILE);
            pnl_findDetectionRatio.Controls.Add(lbl_empty_aois_AOIDetectionRatio, 3, 2);
            pnl_findDetectionRatio.Controls.Add(btn_browseaois_AOIDetectionRatio, 4, 2);

            pnl_findDetectionRatio.Controls.Add(lbl_ExpIntervalFileName_AOIDetectionRatio, 0, 3);
            pnl_findDetectionRatio.Controls.Add(txt_ExpIntervalFileName_AOIDetectionRatio, 1, 3);
            pnl_findDetectionRatio.SetColumnSpan(txt_ExpIntervalFileName_AOIDetectionRatio, 2);
            tt_ExpIntervalFileName_AOIDetectionRatio.SetToolTip(txt_ExpIntervalFileName_AOIDetectionRatio, Constants.TOOLTIP_EXPINTERVAL_FILE);
            pnl_findDetectionRatio.Controls.Add(lbl_empty_ExpIntervalFileName_AOIDetectionRatio, 3, 3);
            pnl_findDetectionRatio.Controls.Add(btn_browseExpIntervalFileName_AOIDetectionRatio, 4, 3);

            pnl_findDetectionRatio.Controls.Add(lbl_ExpIntervalFrequency_AOIDetectionRatio, 0, 4);
            pnl_findDetectionRatio.Controls.Add(txt_ExpIntervalFrequency_AOIDetectionRatio, 1, 4);
            tt_ExpIntervalFrequency_AOIDetectionRatio.SetToolTip(txt_ExpIntervalFrequency_AOIDetectionRatio, Constants.TOOLTIP_ENTER_POSITIVE_INTEGER_VALUE);
            pnl_findDetectionRatio.Controls.Add(lbl_ExpIntervalFrequencyHz_AOIDetectionRatio, 2, 4);



            TableLayoutPanel pnl_radioButtons = new TableLayoutPanel { Dock = DockStyle.Fill, AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_radioButtons.Margin = new Padding(0);
            pnl_radioButtons.ColumnCount = 3;
            pnl_radioButtons.RowCount = 1;
            pnl_radioButtons.Controls.Add(rbOptionSingleParticipant_AOIDetectionRatio, 0, 0);
            tt_rbOptionSingleParticipant_AOIDetectionRatio.SetToolTip(rbOptionSingleParticipant_AOIDetectionRatio, Constants.TOOLTIP_WHICHPARTICIPANT_INEXPINTERVALFILE);
            pnl_radioButtons.Controls.Add(rbOptionFirstParticipant_AOIDetectionRatio, 1, 0);
            tt_rbOptionFirstParticipant_AOIDetectionRatio.SetToolTip(rbOptionFirstParticipant_AOIDetectionRatio, Constants.TOOLTIP_WHICHPARTICIPANT_INEXPINTERVALFILE);
            pnl_radioButtons.Controls.Add(rbOptionSecondParticipant_AOIDetectionRatio, 2, 0);
            tt_rbOptionSecondParticipant_AOIDetectionRatio.SetToolTip(rbOptionSecondParticipant_AOIDetectionRatio, Constants.TOOLTIP_WHICHPARTICIPANT_INEXPINTERVALFILE);
            pnl_findDetectionRatio.Controls.Add(pnl_radioButtons, 0, 5);
            pnl_findDetectionRatio.SetColumnSpan(pnl_radioButtons, 3);

            pnl_findDetectionRatio.Controls.Add(lbl_ExpIntervalParticipantNo_AOIDetectionRatio, 0, 6);
            pnl_findDetectionRatio.Controls.Add(txt_ExpIntervalParticipantNo_AOIDetectionRatio, 1, 6);
            tt_ExpIntervalParticipantNo_AOIDetectionRatio.SetToolTip(txt_ExpIntervalParticipantNo_AOIDetectionRatio, Constants.TOOLTIP_PARTICIPANTID_INEXPINTERVALFILE);


            pnl_findDetectionRatio.Controls.Add(btn_findRatio_AOIDetectionRatio, 1, 7);

            return pnl_findDetectionRatio;
        }

        private TableLayoutPanel CreateLabelAOIMAnually()
        {
            TableLayoutPanel pnl_labelROIManually = new TableLayoutPanel { Dock = DockStyle.Fill, AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_labelROIManually.Margin = new Padding(0);
            pnl_labelROIManually.ColumnCount = 7;
            pnl_labelROIManually.RowCount = 13;

            TableLayoutPanel pnl_info_labelROIManuall = new TableLayoutPanel { Dock = DockStyle.Fill, AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_info_labelROIManuall.Margin = new Padding(0);
            pnl_info_labelROIManuall.BackColor = System.Drawing.Color.LightBlue;
            pnl_info_labelROIManuall.Controls.Add(btn_gotoWalkthrough_labelROIManually);
            pnl_labelROIManually.Controls.Add(pnl_info_labelROIManuall, 0, 0);
            pnl_labelROIManually.SetColumnSpan(pnl_info_labelROIManuall, 7);
            pnl_labelROIManually.Controls.Add(lbl_emptyrow_under_info_labelROIManually, 0, 1);

            pnl_labelROIManually.Controls.Add(lbl_outputFile_labelROIManually,0,2);
            pnl_labelROIManually.Controls.Add(txt_outputFile_labelROIManually,1,2);
            pnl_labelROIManually.SetColumnSpan(txt_outputFile_labelROIManually,3);
            tt_outputFile_labelROIManually.SetToolTip(txt_outputFile_labelROIManually, Constants.TOOLTIP_OUTPUTFOLDER_FILE);
            pnl_labelROIManually.Controls.Add(lbl_empty_outputFile_labelROIManually, 4, 2);
            pnl_labelROIManually.Controls.Add(btn_createOutputFile_labelROIManually, 5,2);
          


            pnl_labelROIManually.Controls.Add(lbl_videoFile_labelROIManually, 0, 3);
            pnl_labelROIManually.Controls.Add(txt_videoFile_labelROIManually, 1, 3);
            pnl_labelROIManually.SetColumnSpan(txt_videoFile_labelROIManually, 3);
            tt_videoFile_labelROIManually.SetToolTip(txt_videoFile_labelROIManually, Constants.TOOLTIP_VIDEORECORDING);
            pnl_labelROIManually.Controls.Add(lbl_empty_videoFile_labelROIManually, 4, 3);
            pnl_labelROIManually.Controls.Add(btn_browsevideoFile_labelROIManually, 5, 3);

            pnl_labelROIManually.Controls.Add(lbl_2dlandmark_labelROIManually, 0, 4);
            pnl_labelROIManually.Controls.Add(txt_2dlandmark_labelROIManually, 1, 4);
            pnl_labelROIManually.SetColumnSpan(txt_2dlandmark_labelROIManually, 3);
            tt_2dlandmark_labelROIManually.SetToolTip(txt_2dlandmark_labelROIManually, Constants.TOOLTIP_2dLANDMARK_FILE);
            pnl_labelROIManually.Controls.Add(lbl_empty_2dlandmark_labelROIManually, 4, 4);
            pnl_labelROIManually.Controls.Add(btn_browse2dlandmark_labelROIManually, 5, 4);

            pnl_labelROIManually.Controls.Add(lbl_rawGazeDataFile_labelROIManually, 0, 5);
            pnl_labelROIManually.Controls.Add(txt_rawGazeDataFile_labelROIManually, 1, 5);
            pnl_labelROIManually.SetColumnSpan(txt_rawGazeDataFile_labelROIManually, 3);
            tt_rawGazeDataFile_labelROIManually.SetToolTip(txt_rawGazeDataFile_labelROIManually, Constants.TOOLTIP_RAWGAZEDATA_FILE);
            pnl_labelROIManually.Controls.Add(lbl_empty_rawGazeDataFile_labelROIManually, 4, 5);
            pnl_labelROIManually.Controls.Add(btn_browseRawGazeDataFile_labelROIManually, 5, 5);

            pnl_labelROIManually.Controls.Add(lbl_aois_labelROIManually, 0, 6);
            pnl_labelROIManually.Controls.Add(txt_aois_labelROIManually, 1, 6);
            pnl_labelROIManually.SetColumnSpan(txt_aois_labelROIManually, 3);
            tt_aois_labelROIManually.SetToolTip(txt_aois_labelROIManually, Constants.TOOLTIP_AOI_FILE);
            pnl_labelROIManually.Controls.Add(lbl_empty_aois_labelROIManually, 4, 6);
            pnl_labelROIManually.Controls.Add(btn_browseaois_labelROIManually, 5, 6);

            pnl_labelROIManually.Controls.Add(lbl_imageSizeEyeTracker_labelROIManually, 0, 7);
            pnl_labelROIManually.Controls.Add(txt_imageSizeEyeTrackerWidth_labelROIManually, 1, 7);
            tt_imageSizeEyeTrackerWidth_labelROIManually.SetToolTip(txt_imageSizeEyeTrackerWidth_labelROIManually, Constants.TOOLTIP_IMAGESIZE);
            pnl_labelROIManually.Controls.Add(lbl_imageSizeEyeTrackerTo_labelROIManually, 2, 7);
            pnl_labelROIManually.Controls.Add(txt_imageSizeEyeTrackerHeight_labelROIManually, 3, 7);
            tt_imageSizeEyeTrackerHeight_labelROIManually.SetToolTip(txt_imageSizeEyeTrackerHeight_labelROIManually, Constants.TOOLTIP_IMAGESIZE);

            pnl_labelROIManually.Controls.Add(lbl_confidenceThreshold_labelROIManually, 0, 8);
            pnl_labelROIManually.Controls.Add(txt_confidenceThreshold_labelROIManually, 1, 8);
            tt_confidenceThreshold_labelROIManually.SetToolTip(txt_confidenceThreshold_labelROIManually, Constants.TOOLTIP_CONFIDENCE_THRESHOLD);
            pnl_labelROIManually.Controls.Add(lbl_empty_confidenceThreshold_labelROIManually, 2, 8);

            pnl_labelROIManually.Controls.Add(lbl_errorSizeEyeTracker_labelROIManually, 0, 9);
            pnl_labelROIManually.Controls.Add(txt_errorSizeEyeTrackerWidth_labelROIManually, 1, 9);
            tt_errorSizeEyeTrackerWidth_labelROIManually.SetToolTip(txt_errorSizeEyeTrackerWidth_labelROIManually, Constants.TOOLTIP_FIXATION_ERRORSIZE);
            pnl_labelROIManually.Controls.Add(lbl_errorSizeEyeTrackerTo_labelROIManually, 2, 9);
            pnl_labelROIManually.Controls.Add(txt_errorSizeEyeTrackerHeight_labelROIManually, 3, 9);
            tt_errorSizeEyeTrackerHeight_labelROIManually.SetToolTip(txt_errorSizeEyeTrackerHeight_labelROIManually, Constants.TOOLTIP_FIXATION_ERRORSIZE);
            pnl_labelROIManually.Controls.Add(lbl_empty_errorSizeEyeTracker_labelROIManually, 4, 9);

            pnl_labelROIManually.Controls.Add(cb_visualizeJustExpInterval_labelROIManually, 0, 10);
            pnl_labelROIManually.SetColumnSpan(cb_visualizeJustExpInterval_labelROIManually, 2);

            pnl_visualizeJustExpInterval_labelROIManually = new TableLayoutPanel { Dock = DockStyle.Fill, AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_visualizeJustExpInterval_labelROIManually.Margin = new Padding(0);
            pnl_visualizeJustExpInterval_labelROIManually.ColumnCount = 7;
            pnl_visualizeJustExpInterval_labelROIManually.RowCount = 4;

            pnl_visualizeJustExpInterval_labelROIManually.Controls.Add(lbl_visualizeJustExpIntervalFileName_labelROIManually, 0, 0);
            pnl_visualizeJustExpInterval_labelROIManually.Controls.Add(txt_visualizeJustExpIntervalFileName_labelROIManually, 1, 0);
            pnl_visualizeJustExpInterval_labelROIManually.SetColumnSpan(txt_visualizeJustExpIntervalFileName_labelROIManually, 2);
            tt_visualizeJustExpIntervalFileName_labelROIManually.SetToolTip(txt_visualizeJustExpIntervalFileName_labelROIManually, Constants.TOOLTIP_EXPINTERVAL_FILE);
            pnl_visualizeJustExpInterval_labelROIManually.Controls.Add(lbl_empty_visualizeJustExpIntervalFileName_labelROIManually, 3, 0);
            pnl_visualizeJustExpInterval_labelROIManually.Controls.Add(btn_browseVisualizeJustExpIntervalFileName_labelROIManually, 4, 0);

            pnl_visualizeJustExpInterval_labelROIManually.Controls.Add(lbl_visualizeJustExpIntervalFrequency_labelROIManually, 0, 1);
            pnl_visualizeJustExpInterval_labelROIManually.Controls.Add(txt_visualizeJustExpIntervalFrequency_labelROIManually, 1, 1);
            tt_visualizeJustExpIntervalFrequency_labelROIManually.SetToolTip(txt_visualizeJustExpIntervalFrequency_labelROIManually, Constants.TOOLTIP_ENTER_POSITIVE_INTEGER_VALUE);
            pnl_visualizeJustExpInterval_labelROIManually.Controls.Add(lbl_visualizeJustExpIntervalFrequencyHz_labelROIManually, 2, 1);


            TableLayoutPanel pnl_radioButtons = new TableLayoutPanel { Dock = DockStyle.Fill, AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_radioButtons.Margin = new Padding(0);
            pnl_radioButtons.ColumnCount = 3;
            pnl_radioButtons.RowCount = 1;
            pnl_radioButtons.Controls.Add(rbOptionSingleParticipant_labelROIManually, 0, 0);
            tt_rbOptionSingleParticipant_labelROIManually.SetToolTip(rbOptionSingleParticipant_labelROIManually, Constants.TOOLTIP_WHICHPARTICIPANT_INEXPINTERVALFILE);
            pnl_radioButtons.Controls.Add(rbOptionFirstParticipant_labelROIManually, 1, 0);
            tt_rbOptionFirstParticipant_labelROIManually.SetToolTip(rbOptionFirstParticipant_labelROIManually, Constants.TOOLTIP_WHICHPARTICIPANT_INEXPINTERVALFILE);
            pnl_radioButtons.Controls.Add(rbOptionSecondParticipant_labelROIManually, 2, 0);
            tt_rbOptionSecondParticipant_labelROIManually.SetToolTip(rbOptionSecondParticipant_labelROIManually, Constants.TOOLTIP_WHICHPARTICIPANT_INEXPINTERVALFILE);
            pnl_visualizeJustExpInterval_labelROIManually.Controls.Add(pnl_radioButtons, 0, 2);
            pnl_visualizeJustExpInterval_labelROIManually.SetColumnSpan(pnl_radioButtons, 3);

            pnl_visualizeJustExpInterval_labelROIManually.Controls.Add(lbl_visualizeJustExpIntervalParticipantNo_labelROIManually, 0, 3);
            pnl_visualizeJustExpInterval_labelROIManually.Controls.Add(txt_visualizeJustExpIntervalParticipantNo_labelROIManually, 1, 3);
            tt_visualizeJustExpIntervalParticipantNo_labelROIManually.SetToolTip(txt_visualizeJustExpIntervalParticipantNo_labelROIManually, Constants.TOOLTIP_PARTICIPANTID_INEXPINTERVALFILE);


            GroupBox gb_visualizeJustExpInterval_visualizeTracking = CreateGBox("", new Label(), pnl_visualizeJustExpInterval_labelROIManually);


            pnl_labelROIManually.Controls.Add(gb_visualizeJustExpInterval_visualizeTracking, 0, 11);
            pnl_labelROIManually.SetColumnSpan(gb_visualizeJustExpInterval_visualizeTracking, 6);

            pnl_labelROIManually.Controls.Add(btn_labelROIManually, 0, 12);


            return pnl_labelROIManually;
        }

        private TableLayoutPanel CreateReanalyseAOI()
        {
            TableLayoutPanel pnl_reanalyzeAOI = new TableLayoutPanel { Dock = DockStyle.Fill, AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_reanalyzeAOI.Margin = new Padding(0);
            pnl_reanalyzeAOI.ColumnCount = 5;
            pnl_reanalyzeAOI.RowCount = 9;

            TableLayoutPanel pnl_info_reanalyzeAOI = new TableLayoutPanel { Dock = DockStyle.Fill, AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_info_reanalyzeAOI.Margin = new Padding(0);
            pnl_info_reanalyzeAOI.BackColor = System.Drawing.Color.LightBlue;
            pnl_info_reanalyzeAOI.Controls.Add(btn_gotoWalkthrough_reanalyzeAOI);
            pnl_reanalyzeAOI.Controls.Add(pnl_info_reanalyzeAOI, 0, 0);
            pnl_reanalyzeAOI.SetColumnSpan(pnl_info_reanalyzeAOI, 5);
            pnl_reanalyzeAOI.Controls.Add(lbl_emptyrow_under_info_reanalyzeAOI, 0, 1);

            pnl_reanalyzeAOI.Controls.Add(lbl_outputFile_reanalyzeAOI, 0, 2);
            pnl_reanalyzeAOI.Controls.Add(txt_outputFile_reanalyzeAOI, 1, 2);
            pnl_reanalyzeAOI.SetColumnSpan(txt_outputFile_reanalyzeAOI, 2);
            tt_outputFile_reanalyzeAOI.SetToolTip(txt_outputFile_reanalyzeAOI, Constants.TOOLTIP_OUTPUTFOLDER_FILE);
            pnl_reanalyzeAOI.Controls.Add(lbl_empty_outputFile_reanalyzeAOI, 3, 2);
            pnl_reanalyzeAOI.Controls.Add(btn_createOutputFile_reanalyzeAOI, 4, 2);

            pnl_reanalyzeAOI.Controls.Add(lbl_manuallyLabeled_reanalyzeAOI, 0, 3);
            pnl_reanalyzeAOI.Controls.Add(txt_manuallyLabeled_reanalyzeAOI, 1, 3);
            pnl_reanalyzeAOI.SetColumnSpan(txt_manuallyLabeled_reanalyzeAOI, 2);
            tt_manuallyLabeled_reanalyzeAOI.SetToolTip(txt_manuallyLabeled_reanalyzeAOI, Constants.TOOLTIP_MANUALLYLABELLED_AOI);
            pnl_reanalyzeAOI.Controls.Add(lbl_empty_manuallyLabeled_reanalyzeAOI, 3, 3);
            pnl_reanalyzeAOI.Controls.Add(btn_browseManuallyLabeled_reanalyzeAOI, 4, 3);

            pnl_reanalyzeAOI.Controls.Add(lbl_rawGazeDataFile_reanalyzeAOI, 0, 4);
            pnl_reanalyzeAOI.Controls.Add(txt_rawGazeDataFile_reanalyzeAOI, 1, 4);
            pnl_reanalyzeAOI.SetColumnSpan(txt_rawGazeDataFile_reanalyzeAOI, 2);
            tt_rawGazeDataFile_reanalyzeAOI.SetToolTip(txt_rawGazeDataFile_reanalyzeAOI, Constants.TOOLTIP_RAWGAZEDATA_FILE);
            pnl_reanalyzeAOI.Controls.Add(lbl_empty_rawGazeDataFile_reanalyzeAOI, 3, 4);
            pnl_reanalyzeAOI.Controls.Add(btn_browseRawGazeDataFile_reanalyzeAOI, 4, 4);

            pnl_reanalyzeAOI.Controls.Add(lbl_2dlandmark_reanalyzeAOI, 0, 5);
            pnl_reanalyzeAOI.Controls.Add(txt_2dlandmark_reanalyzeAOI, 1, 5);
            pnl_reanalyzeAOI.SetColumnSpan(txt_2dlandmark_reanalyzeAOI, 2);
            tt_2dlandmark_reanalyzeAOI.SetToolTip(txt_2dlandmark_reanalyzeAOI, Constants.TOOLTIP_2dLANDMARK_FILE);
            pnl_reanalyzeAOI.Controls.Add(lbl_empty_2dlandmark_reanalyzeAOI, 3, 5);
            pnl_reanalyzeAOI.Controls.Add(btn_browse2dlandmark_reanalyzeAOI, 4, 5);

            pnl_reanalyzeAOI.Controls.Add(lbl_imageSizeTrakingFramework_reanalyzeAOI, 0, 6);
            pnl_reanalyzeAOI.Controls.Add(txt_imageSizeTrakingFramework_reanalyzeAOI, 1, 6);
            pnl_reanalyzeAOI.SetColumnSpan(txt_imageSizeTrakingFramework_reanalyzeAOI, 2);
            tt_imageSizeTrakingFramework_reanalyzeAOI.SetToolTip(txt_imageSizeTrakingFramework_reanalyzeAOI, Constants.TOOLTIP_IMAGESIZE_FILE);
            pnl_reanalyzeAOI.Controls.Add(lbl_empty_imageSizeTrakingFramework_reanalyzeAOI, 3, 6);
            pnl_reanalyzeAOI.Controls.Add(btn_browseImageSizeTrakingFramework_reanalyzeAOI, 4, 6);

            pnl_reanalyzeAOI.Controls.Add(lbl_imageSizeEyeTracker_reanalyzeAOI, 0, 7);
            pnl_reanalyzeAOI.Controls.Add(txt_imageSizeEyeTrackerWidth_reanalyzeAOI, 1, 7);
            tt_imageSizeEyeTrackerWidth_reanalyzeAOI.SetToolTip(txt_imageSizeEyeTrackerWidth_reanalyzeAOI, Constants.TOOLTIP_IMAGESIZE);
            pnl_reanalyzeAOI.Controls.Add(txt_imageSizeEyeTrackerHeight_reanalyzeAOI, 2, 7);
            tt_imageSizeEyeTrackerHeight_reanalyzeAOI.SetToolTip(txt_imageSizeEyeTrackerHeight_reanalyzeAOI, Constants.TOOLTIP_IMAGESIZE);
            pnl_reanalyzeAOI.Controls.Add(lbl_empty_imageSizeEyeTracker_reanalyzeAOI, 3, 7);

            pnl_reanalyzeAOI.Controls.Add(btn_analyse_reanalyzeAOI, 1, 8);

            return pnl_reanalyzeAOI;
        }

    }
}