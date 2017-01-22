using System;
using System.Drawing;
using System.Windows.Forms;

namespace MAGiC
{
    public class DetectROIUI : ParentUI
    {

 
        public TableLayoutPanel pnl_preProcessGazeData, pnl_faceAsAOI;

        public DetectROIUI(INavigationListener _navigationListener) : base(_navigationListener)
        {
            pnl_preProcessGazeData = CreatePreProcessGazeData();
            pnl_faceAsAOI = CreateDetectAOI();
        }

        /* Fill gap controls*/
        /**********************************************************************************************/

        public ToolTip tt_outputFile_preProcessGazeData = new ToolTip();
        public ToolTip tt_rawGazeDataFile_preProcessGazeData = new ToolTip();
        public ToolTip tt_maxGapLength_preProcessGazeData = new ToolTip();


        public Button btn_gotoWalkthrough_preProcessGazeData = new Button { Text = "Go to Walkthrough", AutoSize = true, BackColor = Color.AliceBlue, Font = new Font("Arial", 10, FontStyle.Bold) };
        public Label lbl_emptyrow_under_info_preProcessGazeData = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };

        public Label lbl_outputFile_preProcessGazeData = new Label { Text = "Output File:", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public TextBox txt_outputFile_preProcessGazeData = new TextBox { AutoSize = true, Width = 600 };
        public Button btn_createOutputFile_preProcessGazeData = new Button { Text = "Create", AutoSize = true, BackColor = Color.AliceBlue, Width = 30, Font = new Font("Arial", 10, FontStyle.Bold) };
        public Label lbl_empty_outputFile_preProcessGazeData = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };
        public SaveFileDialog sfd_outputFile_preProcessGazeData = new SaveFileDialog();


        public Label lbl_rawGazeDataFile_preProcessGazeData = new Label { Text = "Raw Gaze-Data File:", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public TextBox txt_rawGazeDataFile_preProcessGazeData = new TextBox { AutoSize = true, Width = 600 };
        public Button btn_browseRawGazeDataFile_preProcessGazeData = new Button { Text = "...", AutoSize = true, BackColor = Color.AliceBlue, Width = 30, Font = new Font("Arial", 10, FontStyle.Bold) };
        public Label lbl_empty_rawGazeDataFile_preProcessGazeData = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };
        public OpenFileDialog ofd_rawGazeDataFile_preProcessGazeData = new OpenFileDialog();


        public Label lbl_maxGapLength_preProcessGazeData = new Label { Text = "Max Gap Length:", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public TextBox txt_maxGapLength_preProcessGazeData = new TextBox { AutoSize = true, Width = 100 };
        public Label lbl_empty_maxGapLength_preProcessGazeData = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };

        public Button btn_fillGap_preProcessGazeData = new Button { Text = "Fill", AutoSize = true, BackColor = Constants.BUTTON_BACKCOLOR, ForeColor = Constants.BUTTON_FORECOLOR, Font = Constants.BUTTON_FONT };


        public ErrorProvider errorProvider_outputFile_preProcessGazeData = new System.Windows.Forms.ErrorProvider();
        public ErrorProvider errorProvider_rawGazeDataFile_preProcessGazeData = new System.Windows.Forms.ErrorProvider();
        public ErrorProvider errorProvider_maxGapLength_preProcessGazeData = new System.Windows.Forms.ErrorProvider();
        /*End of DetectROI controls */


        /* Face as AOI controls*/
        /**********************************************************************************************/
        public ToolTip tt_outputFile_faceAsROI = new ToolTip();
        public ToolTip tt_rawGazeDataFile_faceAsROI = new ToolTip();
        public ToolTip tt_2dlandmark_faceAsROI = new ToolTip();
        public ToolTip tt_imagesizefile_faceAsROI = new ToolTip();
        public ToolTip tt_imagesize_faceAsROI = new ToolTip();
        public ToolTip tt_fixationerror_faceAsROI = new ToolTip();

        public Button btn_gotoWalkthrough_faceAsROI = new Button { Text = "Go to Walkthrough", AutoSize = true, BackColor = Color.AliceBlue, Font = new Font("Arial", 10, FontStyle.Bold) };
        public Label lbl_emptyrow_under_info_faceAsROI = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };

        public Label lbl_outputFile_faceAsROI = new Label { Text = "Output File:", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public TextBox txt_outputFile_faceAsROI = new TextBox { AutoSize = true, Width = 600 };
        public Button btn_createOutputFile_faceAsROI = new Button { Text = "Create", AutoSize = true, BackColor = Color.AliceBlue, Width = 30, Font = new Font("Arial", 10, FontStyle.Bold) };
        public Label lbl_empty_outputFile_faceAsROI = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };
        public SaveFileDialog sfd_outputFile_faceAsROI = new SaveFileDialog();

        public Label lbl_rawGazeDataFile_faceAsROI = new Label { Text = "Raw Gaze-Data File:", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public TextBox txt_rawGazeDataFile_faceAsROI = new TextBox { AutoSize = true, Width = 600 };
        public Button btn_browseRawGazeDataFile_faceAsROI = new Button { Text = "...", AutoSize = true, BackColor = Color.AliceBlue, Width = 30, Font = new Font("Arial", 10, FontStyle.Bold) };
        public Label lbl_empty_rawGazeDataFile_faceAsROI = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };
        public OpenFileDialog ofd_rawGazeDataFile_faceAsROI = new OpenFileDialog();

        public Label lbl_2dlandmark_faceAsROI = new Label { Text = "2d Landmark File:", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public TextBox txt_2dlandmark_faceAsROI = new TextBox { AutoSize = true, Width = 600 };
        public Button btn_browse2dlandmark_faceAsROI = new Button { Text = "...", AutoSize = true, BackColor = Color.AliceBlue, Width = 30, Font = new Font("Arial", 10, FontStyle.Bold) };
        public Label lbl_empty_2dlandmark_faceAsROI = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };
        public OpenFileDialog ofd_2dlandmark_faceAsROI = new OpenFileDialog();

        public Label lbl_imageSizeTrakingFramework_faceAsROI = new Label { Text = "Image-Size File:", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public TextBox txt_imageSizeTrakingFramework_faceAsROI = new TextBox { AutoSize = true, Width = 600 };
        public Button btn_browseImageSizeTrakingFramework_faceAsROI = new Button { Text = "...", AutoSize = true, BackColor = Color.AliceBlue, Width = 30, Font = new Font("Arial", 10, FontStyle.Bold) };
        public Label lbl_empty_imageSizeTrakingFramework_faceAsROI = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };
        public OpenFileDialog ofd_imageSizeTrakingFramework_faceAsROI = new OpenFileDialog();

        public Label lbl_imageSizeEyeTracker_faceAsROI = new Label { Text = "Image-Size:", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public TextBox txt_imageSizeEyeTrackerWidth_faceAsROI = new TextBox { AutoSize = true, Width = 100 };
        public TextBox txt_imageSizeEyeTrackerHeight_faceAsROI = new TextBox { AutoSize = true, Width = 100 };
        public Label lbl_empty_imageSizeEyeTracker_faceAsROI = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };


        public Label lbl_errorSizeEyeTracker_faceAsROI = new Label { Text = "Fixation Error(Optional):", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public TextBox txt_errorSizeEyeTrackerWidth_faceAsROI = new TextBox { AutoSize = true, Width = 100 };
        public Label lbl_errorSizeEyeTrackerTo_faceAsROI = new Label { Text = " - ", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public TextBox txt_errorSizeEyeTrackerHeight_faceAsROI = new TextBox { AutoSize = true, Width = 100 };
        public Label lbl_empty_errorSizeEyeTracker_faceAsROI = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };



        public Button btn_analyse_faceAsROI = new Button { Text = "Analyse", AutoSize = true, BackColor = Constants.BUTTON_BACKCOLOR, ForeColor = Constants.BUTTON_FORECOLOR, Font = Constants.BUTTON_FONT };

       

        public ErrorProvider errorProvider_outputFile_faceAsROI = new System.Windows.Forms.ErrorProvider();
        public ErrorProvider errorProvider_rawGazeDataFile_faceAsROI = new System.Windows.Forms.ErrorProvider();
        public ErrorProvider errorProvider_2dlandmark_faceAsROI = new System.Windows.Forms.ErrorProvider();
        public ErrorProvider errorProvider_imageSizeTrakingFramework_faceAsROI = new System.Windows.Forms.ErrorProvider();
        public ErrorProvider errorProvider_imageSizeEyeTracker_faceAsROI = new System.Windows.Forms.ErrorProvider();
        public ErrorProvider errorProvider_errorSizeEyeTracker_visualizeTracking = new System.Windows.Forms.ErrorProvider();

        /*End of Face as AOI controls */

        private TableLayoutPanel CreatePreProcessGazeData()
        {
            TableLayoutPanel pnl_preProcessGazeData = new TableLayoutPanel { Dock = DockStyle.Fill, AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_preProcessGazeData.Margin = new Padding(0);
            pnl_preProcessGazeData.ColumnCount = 4;
            pnl_preProcessGazeData.RowCount = 6;

            TableLayoutPanel pnl_info_preProcessGazeData = new TableLayoutPanel { Dock = DockStyle.Fill, AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_info_preProcessGazeData.Margin = new Padding(0);
            pnl_info_preProcessGazeData.BackColor = System.Drawing.Color.LightBlue;
            pnl_info_preProcessGazeData.Controls.Add(btn_gotoWalkthrough_preProcessGazeData);
            pnl_preProcessGazeData.Controls.Add(pnl_info_preProcessGazeData, 0, 0);
            pnl_preProcessGazeData.SetColumnSpan(pnl_info_preProcessGazeData, 4);
            pnl_preProcessGazeData.Controls.Add(lbl_emptyrow_under_info_preProcessGazeData, 0, 1);

            pnl_preProcessGazeData.Controls.Add(lbl_outputFile_preProcessGazeData, 0, 2);
            pnl_preProcessGazeData.Controls.Add(txt_outputFile_preProcessGazeData, 1, 2);
            tt_outputFile_preProcessGazeData.SetToolTip(txt_outputFile_preProcessGazeData, Constants.TOOLTIP_OUTPUTFOLDER_FILE);
            pnl_preProcessGazeData.Controls.Add(lbl_empty_outputFile_preProcessGazeData, 2, 2);
            pnl_preProcessGazeData.Controls.Add(btn_createOutputFile_preProcessGazeData, 3, 2);


            pnl_preProcessGazeData.Controls.Add(lbl_rawGazeDataFile_preProcessGazeData, 0, 3);
            pnl_preProcessGazeData.Controls.Add(txt_rawGazeDataFile_preProcessGazeData, 1, 3);
            tt_rawGazeDataFile_preProcessGazeData.SetToolTip(txt_rawGazeDataFile_preProcessGazeData, Constants.TOOLTIP_RAWGAZEDATA_FILE);
            pnl_preProcessGazeData.Controls.Add(lbl_empty_rawGazeDataFile_preProcessGazeData, 2, 3);
            pnl_preProcessGazeData.Controls.Add(btn_browseRawGazeDataFile_preProcessGazeData, 3, 3);

            pnl_preProcessGazeData.Controls.Add(lbl_maxGapLength_preProcessGazeData, 0, 4);
            pnl_preProcessGazeData.Controls.Add(txt_maxGapLength_preProcessGazeData, 1, 4);
            tt_maxGapLength_preProcessGazeData.SetToolTip(txt_maxGapLength_preProcessGazeData, Constants.TOOLTIP_ENTER_POSITIVE_INTEGER_VALUE);
            pnl_preProcessGazeData.Controls.Add(lbl_empty_maxGapLength_preProcessGazeData, 2, 4);

            pnl_preProcessGazeData.Controls.Add(btn_fillGap_preProcessGazeData, 1, 5);

            return pnl_preProcessGazeData;
        }

        private TableLayoutPanel CreateDetectAOI()
        {
            TableLayoutPanel pnl_faceAsROI = new TableLayoutPanel { Dock = DockStyle.Fill, AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_faceAsROI.Margin = new Padding(0);
            pnl_faceAsROI.ColumnCount = 5;
            pnl_faceAsROI.RowCount = 8;

            TableLayoutPanel pnl_info_faceAsROI = new TableLayoutPanel { Dock = DockStyle.Fill, AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_info_faceAsROI.Margin = new Padding(0);
            pnl_info_faceAsROI.BackColor = System.Drawing.Color.LightBlue;
            pnl_info_faceAsROI.Controls.Add(btn_gotoWalkthrough_faceAsROI);
            pnl_faceAsROI.Controls.Add(pnl_info_faceAsROI, 0, 0);
            pnl_faceAsROI.SetColumnSpan(pnl_info_faceAsROI, 5);
            pnl_faceAsROI.Controls.Add(lbl_emptyrow_under_info_faceAsROI, 0, 1);

            pnl_faceAsROI.Controls.Add(lbl_outputFile_faceAsROI, 0, 2);
            pnl_faceAsROI.Controls.Add(txt_outputFile_faceAsROI, 1, 2);
            pnl_faceAsROI.SetColumnSpan(txt_outputFile_faceAsROI, 2);
            tt_outputFile_faceAsROI.SetToolTip(txt_outputFile_faceAsROI, Constants.TOOLTIP_OUTPUTFOLDER_FILE);
            pnl_faceAsROI.Controls.Add(lbl_empty_outputFile_faceAsROI, 3, 2);
            pnl_faceAsROI.Controls.Add(btn_createOutputFile_faceAsROI, 4, 2);

            pnl_faceAsROI.Controls.Add(lbl_rawGazeDataFile_faceAsROI, 0, 3);
            pnl_faceAsROI.Controls.Add(txt_rawGazeDataFile_faceAsROI, 1, 3);
            pnl_faceAsROI.SetColumnSpan(txt_rawGazeDataFile_faceAsROI, 2);
            tt_rawGazeDataFile_faceAsROI.SetToolTip(txt_rawGazeDataFile_faceAsROI, Constants.TOOLTIP_RAWGAZEDATA_FILE);
            pnl_faceAsROI.Controls.Add(lbl_empty_rawGazeDataFile_faceAsROI, 3, 3);
            pnl_faceAsROI.Controls.Add(btn_browseRawGazeDataFile_faceAsROI, 4, 3);

            pnl_faceAsROI.Controls.Add(lbl_2dlandmark_faceAsROI, 0, 4);
            pnl_faceAsROI.Controls.Add(txt_2dlandmark_faceAsROI, 1, 4);
            pnl_faceAsROI.SetColumnSpan(txt_2dlandmark_faceAsROI, 2);
            tt_2dlandmark_faceAsROI.SetToolTip(txt_2dlandmark_faceAsROI, Constants.TOOLTIP_2dLANDMARK_FILE);
            pnl_faceAsROI.Controls.Add(lbl_empty_2dlandmark_faceAsROI, 3, 4);
            pnl_faceAsROI.Controls.Add(btn_browse2dlandmark_faceAsROI, 4, 4);

            pnl_faceAsROI.Controls.Add(lbl_imageSizeTrakingFramework_faceAsROI, 0, 5);
            pnl_faceAsROI.Controls.Add(txt_imageSizeTrakingFramework_faceAsROI, 1, 5);
            pnl_faceAsROI.SetColumnSpan(txt_imageSizeTrakingFramework_faceAsROI, 2);
            tt_imagesizefile_faceAsROI.SetToolTip(txt_imageSizeTrakingFramework_faceAsROI, Constants.TOOLTIP_IMAGESIZE_FILE);
            pnl_faceAsROI.Controls.Add(lbl_empty_imageSizeTrakingFramework_faceAsROI, 3, 5);
            pnl_faceAsROI.Controls.Add(btn_browseImageSizeTrakingFramework_faceAsROI, 4, 5);

            pnl_faceAsROI.Controls.Add(lbl_imageSizeEyeTracker_faceAsROI, 0, 6);
            pnl_faceAsROI.Controls.Add(txt_imageSizeEyeTrackerWidth_faceAsROI, 1, 6);
            pnl_faceAsROI.Controls.Add(txt_imageSizeEyeTrackerHeight_faceAsROI, 2, 6);
            tt_imagesize_faceAsROI.SetToolTip(txt_imageSizeEyeTrackerHeight_faceAsROI, Constants.TOOLTIP_IMAGESIZE);
            pnl_faceAsROI.Controls.Add(lbl_empty_imageSizeEyeTracker_faceAsROI, 3, 6);

            pnl_faceAsROI.Controls.Add(lbl_errorSizeEyeTracker_faceAsROI, 0,7);
            pnl_faceAsROI.Controls.Add(txt_errorSizeEyeTrackerWidth_faceAsROI, 1, 7);
            pnl_faceAsROI.Controls.Add(txt_errorSizeEyeTrackerHeight_faceAsROI, 2, 7);
            tt_fixationerror_faceAsROI.SetToolTip(txt_errorSizeEyeTrackerHeight_faceAsROI, Constants.TOOLTIP_FIXATION_ERRORSIZE);
            pnl_faceAsROI.Controls.Add(lbl_empty_errorSizeEyeTracker_faceAsROI, 3, 7);

            pnl_faceAsROI.Controls.Add(btn_analyse_faceAsROI, 1, 8);

            return pnl_faceAsROI;
        }




    }
}