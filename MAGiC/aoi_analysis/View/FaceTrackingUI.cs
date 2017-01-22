using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAGiC
{
    public class FaceTrackingUI : ParentUI
    {


        public TableLayoutPanel pnl_trackingWithDefaultDetector, pnl_trackingWithTrainedDetector;

        public FaceTrackingUI(INavigationListener _navigationListener) : base(_navigationListener)
        {
            pnl_trackingWithDefaultDetector = CreateFaceTrackingWithDefaultDetector();
            pnl_trackingWithTrainedDetector = CreateFaceTrackingWithTrainedDetector();
        }


        /* Face Tracking with default detector controls*/
        /**********************************************************************************************/
        public ToolTip tt_output_folder_trackingWithDefaultDetector = new ToolTip();
        public ToolTip tt_videoFile_trackingWithDefaultDetector = new ToolTip();

        public Button btn_gotoWalkthrough_trackingWithDefaultDetector = new Button { Text = "Go to Walkthrough", AutoSize = true, BackColor = Color.AliceBlue, Font = new Font("Arial", 10, FontStyle.Bold) };
        public Label lbl_emptyrow_under_info_trackingWithDefaultDetector = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };

        public Label lbl_output_folder_trackingWithDefaultDetector = new Label { Text = "Output Folder:", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public TextBox txt_output_folder_trackingWithDefaultDetector = new TextBox { AutoSize = true, Width = 600 };
        public Button btn_output_folder_trackingWithDefaultDetector =new Button{ Text = "...", AutoSize = true, BackColor = Color.AliceBlue, Width = 30, Font = new Font("Arial", 10, FontStyle.Bold) };
        public FolderBrowserDialog fbd_output_folder_trackingWithDefaultDetector = new FolderBrowserDialog();
        public Label lbl_empty_txt_output_folder_trackingWithDefaultDetector = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };

        public Label lbl_videoFile_trackingWithDefaultDetector = new Label { Text = "Video File:", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public TextBox txt_videoFile_trackingWithDefaultDetector = new TextBox { AutoSize = true, Width = 600 };
        public OpenFileDialog ofd_videoFile_trackingWithDefaultDetector = new OpenFileDialog();
        public Button btn_videoFile_trackingWithDefaultDetector = new Button { Text = "...", AutoSize = true, BackColor = Color.AliceBlue, Width = 30, Font = new Font("Arial", 10, FontStyle.Bold) };
        public Label lbl_empty_txt_videoFile_trackingWithDefaultDetector = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };

        public CheckBox cb_visualizeDuringTracking_trackingWithDefaultDetector = new CheckBox {  Text= "Visualize During Tracking", Font = new Font("Arial", 11, FontStyle.Bold), AutoSize = true };

        public Label lbl_emptyrow_before_selectOutputFiles_trackingWithDefaultDetector = new Label { Text = "", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public Label lbl_selectOutputFiles_trackingWithDefaultDetector = new Label { Text = "Output Files:", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public CheckBox cb_2dLandmark_trackingWithDefaultDetector = new CheckBox { Text = "Create 2d Landmarks File", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public CheckBox cb_3dLandmark_trackingWithDefaultDetector = new CheckBox { Text = "Create 3d Landmarks File", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public CheckBox cb_pose_trackingWithDefaultDetector = new CheckBox { Text = "Create Estimated Pose File", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public CheckBox cb_modelParams_trackingWithDefaultDetector = new CheckBox { Text = "Create Model Parameters File", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public CheckBox cb_AUs_trackingWithDefaultDetector = new CheckBox { Text = "Create Action Units File", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public CheckBox cb_gazeEstimation_trackingWithDefaultDetector = new CheckBox { Text = "Create Estimated Gaze File", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public CheckBox cb_widthHegith_trackingWithDefaultDetector = new CheckBox { Text = "Create Image-Size File", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };

        public Button btn_track_trackingWithDefaultDetector = new Button { Text = "Track", AutoSize = true, Width = 30, BackColor = Constants.BUTTON_BACKCOLOR, ForeColor = Constants.BUTTON_FORECOLOR, Font = Constants.BUTTON_FONT };

        public ErrorProvider errorProvider_output_folder_trackingWithDefaultDetector = new System.Windows.Forms.ErrorProvider();
        public ErrorProvider errorProvider_videoFile_trackingWithDefaultDetector = new System.Windows.Forms.ErrorProvider();

        /*End of Face Tracking with default detector controls */


        /* Face Tracking with trained detector controls*/
        /**********************************************************************************************/
        public ToolTip tt_output_folder_frames_trainedDetector = new ToolTip();
        public ToolTip tt_videoFile_frames_trainedDetector = new ToolTip();
        public ToolTip tt_output_folder_train_trainedDetector = new ToolTip();
        public ToolTip tt_select_trainingimages_trainedDetector = new ToolTip();
        public ToolTip tt_select_test_trainedDetector = new ToolTip();
        public ToolTip tt_output_folder_track_trainedDetector = new ToolTip();


        public Button btn_gotoWalkthrough_trainedDetector = new Button { Text = "Go to Walkthrough", AutoSize = true, BackColor = Color.AliceBlue, Font = new Font("Arial", 10, FontStyle.Bold) };
        public Label lbl_emptyrow_under_info_trainedDetector = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };

        //Export Frames
        public Label lbl_output_folder_frames_trainedDetector = new Label { Text = "Output Folder:", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public TextBox txt_output_folder_frames_trainedDetector = new TextBox { AutoSize = true, Width = 600 };
        public Button btn_output_folder_frames_trainedDetector = new Button { Text = "...", AutoSize = true, BackColor = Color.AliceBlue, Width = 30, Font = new Font("Arial", 10, FontStyle.Bold) };
        public FolderBrowserDialog fbd_output_folder_frames_trainedDetector = new FolderBrowserDialog();
        public Label lbl_empty_txt_output_folder_frames_trainedDetector = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };

        public Label lbl_videoFile_frames_trainedDetector = new Label { Text = "Video File:", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public TextBox txt_videoFile_frames_trainedDetector = new TextBox { AutoSize = true, Width = 600 };
        public OpenFileDialog ofd_videoFile_frames_trainedDetector = new OpenFileDialog();
        public Button btn_videoFile_frames_trainedDetector = new Button { Text = "...", AutoSize = true, BackColor = Color.AliceBlue, Width = 30, Font = new Font("Arial", 10, FontStyle.Bold) };
        public Label lbl_empty_txt_videoFile_frames_trainedDetector = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };
        public Label lbl_emptyrow_under_frames_trainedDetector = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };
        public Button btn_exportFrames_trainedDetector = new Button { Text = "Export", AutoSize = true, BackColor = Constants.BUTTON_BACKCOLOR, ForeColor = Constants.BUTTON_FORECOLOR, Font = Constants.BUTTON_FONT };
        public GroupBox gb_exportframes_trainedDetector;

        //Training
        public Label lbl_output_folder_train_trainedDetector = new Label { Text = "Output Folder:", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public TextBox txt_output_folder_train_trainedDetector = new TextBox { AutoSize = true, Width = 600 };
        public Button btn_output_folder_train_trainedDetector = new Button { Text = "...", AutoSize = true, BackColor = Color.AliceBlue, Width = 30, Font = new Font("Arial", 10, FontStyle.Bold) };
        public FolderBrowserDialog fbd_output_folder_train_trainedDetector = new FolderBrowserDialog();
        public Label lbl_empty_txt_output_folder_train_trainedDetector = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };

        public Label lbl_select_images_training_trainedDetector = new Label { Text = "Select Images for Training:", AutoSize = true, TextAlign = ContentAlignment.BottomLeft, Font = new Font("Arial", 11, FontStyle.Bold) };
        public ListBox lb_images_training_trainedDetector = new ListBox { HorizontalScrollbar = true, Size = new System.Drawing.Size(350, 390), Font = new Font("Arial", 11, FontStyle.Bold), SelectionMode = SelectionMode.MultiExtended };
       
        public Label lbl_empty_column_selectImages_trainedDetector = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };
        public Label lbl_select_images_test_trainedDetector = new Label { Text = "Select Images for Testing:", AutoSize = true, TextAlign = ContentAlignment.BottomLeft, Font = new Font("Arial", 11, FontStyle.Bold) };
        public ListBox lb_images_test_trainedDetector = new ListBox { HorizontalScrollbar = true, Size = new System.Drawing.Size(350, 390), Font = new Font("Arial", 11, FontStyle.Bold), SelectionMode = SelectionMode.MultiExtended };
        

        public Button btn_movetoRightList_trainedDetector = new Button { Image = global::MAGiC.Properties.Resources.arrow_right_shrinked, BackColor = Color.AliceBlue, Size = new Size(60, 35) };
        public Button btn_movetoLeftList_trainedDetector = new Button { Image = global::MAGiC.Properties.Resources.arrow_left_shrinked,  BackColor = Color.AliceBlue, Size = new Size(60, 35) };


        public Button btn_training_trainedDetector = new Button { Text = "Train", AutoSize = true, BackColor = Constants.BUTTON_BACKCOLOR, ForeColor = Constants.BUTTON_FORECOLOR, Font = Constants.BUTTON_FONT };
        public Label lbl_emptyrow_under_training_trainedDetector = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };
        public GroupBox gb_train_trainedDetector;

        //Tracking
        public Label lbl_output_folder_track_trainedDetector = new Label { Text = "Output Folder:", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public TextBox txt_output_folder_track_trainedDetector = new TextBox { AutoSize = true, Width = 600 };
        public Button btn_output_folder_track_trainedDetector = new Button { Text = "...", AutoSize = true, BackColor = Color.AliceBlue, Width = 30, Font = new Font("Arial", 10, FontStyle.Bold) };
        public FolderBrowserDialog fbd_output_folder_track_trainedDetector = new FolderBrowserDialog();
        public Label lbl_empty_txt_output_folder_track_trainedDetector = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };

        public CheckBox cb_visualizeDuringTracking_trainedDetector = new CheckBox { Text = "Visualize During Tracking", Font = new Font("Arial", 11, FontStyle.Bold), AutoSize = true };

        public Label lbl_emptyrow_before_selectOutputFiles_trainedDetector = new Label { Text = "", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public Label lbl_selectOutputFiles_trainedDetector = new Label { Text = "Output Files:", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public CheckBox cb_2dLandmark_trainedDetector = new CheckBox { Text = "Create 2d Landmarks File", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public CheckBox cb_3dLandmark_trainedDetector = new CheckBox { Text = "Create 3d Landmarks File", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public CheckBox cb_pose_trainedDetector = new CheckBox { Text = "Create Estimated Pose File", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public CheckBox cb_modelParams_trainedDetector = new CheckBox { Text = "Create Model Parameters File", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public CheckBox cb_AUs_trainedDetector = new CheckBox { Text = "Create Action Units File", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public CheckBox cb_gazeEstimation_trainedDetector = new CheckBox { Text = "Create Estimated Gaze File", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public CheckBox cb_widthHegith_trainedDetector = new CheckBox { Text = "Create Image-Size File", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };

        public Button btn_track_trainedDetector = new Button { Text = "Track", AutoSize = true, Width = 30, BackColor = Constants.BUTTON_BACKCOLOR, ForeColor = Constants.BUTTON_FORECOLOR, Font = Constants.BUTTON_FONT };
        public GroupBox gb_track_trainedDetector;



        public ErrorProvider errorProvider_output_folder_frames_trainedDetector = new System.Windows.Forms.ErrorProvider();
        public ErrorProvider errorProvider_output_folder_train_trainedDetector = new System.Windows.Forms.ErrorProvider();
        public ErrorProvider errorProvider_output_folder_track_trainedDetector = new System.Windows.Forms.ErrorProvider();
        public ErrorProvider errorProvider_videoFile_trainedDetector = new System.Windows.Forms.ErrorProvider();
        public ErrorProvider errorProvider_lb_images_training_trainedDetector = new System.Windows.Forms.ErrorProvider();
        public ErrorProvider errorProvider_lb_images_test_trainedDetector = new System.Windows.Forms.ErrorProvider();

        /*End of Face Tracking with default detector controls */

        private TableLayoutPanel CreateFaceTrackingWithDefaultDetector()
        {
            TableLayoutPanel pnl_faceTrackingWithDefaultDetector = new TableLayoutPanel { Dock = DockStyle.Fill, AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_faceTrackingWithDefaultDetector.Margin = new Padding(0);
            pnl_faceTrackingWithDefaultDetector.ColumnCount = 6;
            pnl_faceTrackingWithDefaultDetector.RowCount = 11;

            TableLayoutPanel pnl_info_faceTrackingWithDefaultDetector = new TableLayoutPanel { Dock = DockStyle.Fill, AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_info_faceTrackingWithDefaultDetector.Margin = new Padding(0);
            pnl_info_faceTrackingWithDefaultDetector.BackColor = System.Drawing.Color.LightBlue;
            pnl_info_faceTrackingWithDefaultDetector.Controls.Add(btn_gotoWalkthrough_trackingWithDefaultDetector);
            pnl_faceTrackingWithDefaultDetector.Controls.Add(pnl_info_faceTrackingWithDefaultDetector, 0, 0);
            pnl_faceTrackingWithDefaultDetector.SetColumnSpan(pnl_info_faceTrackingWithDefaultDetector, 6);
            pnl_faceTrackingWithDefaultDetector.Controls.Add(lbl_emptyrow_under_info_trackingWithDefaultDetector,0,1);

            pnl_faceTrackingWithDefaultDetector.Controls.Add(lbl_output_folder_trackingWithDefaultDetector, 0, 2);
            pnl_faceTrackingWithDefaultDetector.Controls.Add(txt_output_folder_trackingWithDefaultDetector, 1, 2);
            pnl_faceTrackingWithDefaultDetector.SetColumnSpan(txt_output_folder_trackingWithDefaultDetector, 3);
            tt_output_folder_trackingWithDefaultDetector.SetToolTip(txt_output_folder_trackingWithDefaultDetector,Constants.TOOLTIP_OUTPUTFOLDER_FILE);
            pnl_faceTrackingWithDefaultDetector.Controls.Add(lbl_empty_txt_output_folder_trackingWithDefaultDetector, 4, 2);
            pnl_faceTrackingWithDefaultDetector.Controls.Add(btn_output_folder_trackingWithDefaultDetector, 5, 2);

            pnl_faceTrackingWithDefaultDetector.Controls.Add(lbl_videoFile_trackingWithDefaultDetector, 0, 3);
            pnl_faceTrackingWithDefaultDetector.Controls.Add(txt_videoFile_trackingWithDefaultDetector, 1, 3);
            pnl_faceTrackingWithDefaultDetector.SetColumnSpan(txt_videoFile_trackingWithDefaultDetector, 3);
            tt_videoFile_trackingWithDefaultDetector.SetToolTip(txt_videoFile_trackingWithDefaultDetector, Constants.TOOLTIP_VIDEORECORDING);
            pnl_faceTrackingWithDefaultDetector.Controls.Add(lbl_empty_txt_videoFile_trackingWithDefaultDetector, 4, 3);
            pnl_faceTrackingWithDefaultDetector.Controls.Add(btn_videoFile_trackingWithDefaultDetector, 5, 3);

            pnl_faceTrackingWithDefaultDetector.Controls.Add(cb_visualizeDuringTracking_trackingWithDefaultDetector, 0, 4);
            pnl_faceTrackingWithDefaultDetector.SetColumnSpan(cb_visualizeDuringTracking_trackingWithDefaultDetector, 6);

            pnl_faceTrackingWithDefaultDetector.Controls.Add(lbl_emptyrow_before_selectOutputFiles_trackingWithDefaultDetector, 0, 5);
   

            pnl_faceTrackingWithDefaultDetector.Controls.Add(lbl_selectOutputFiles_trackingWithDefaultDetector, 0, 6);

            pnl_faceTrackingWithDefaultDetector.Controls.Add(cb_2dLandmark_trackingWithDefaultDetector, 0, 7);
            pnl_faceTrackingWithDefaultDetector.SetColumnSpan(cb_2dLandmark_trackingWithDefaultDetector, 2);
            pnl_faceTrackingWithDefaultDetector.Controls.Add(cb_widthHegith_trackingWithDefaultDetector, 2, 7);
            pnl_faceTrackingWithDefaultDetector.SetColumnSpan(cb_widthHegith_trackingWithDefaultDetector, 2);
            cb_widthHegith_trackingWithDefaultDetector.Enabled = false;
            cb_widthHegith_trackingWithDefaultDetector.Checked = true;
       

            pnl_faceTrackingWithDefaultDetector.Controls.Add(cb_pose_trackingWithDefaultDetector, 0, 8);
            pnl_faceTrackingWithDefaultDetector.SetColumnSpan(cb_pose_trackingWithDefaultDetector, 2);
            pnl_faceTrackingWithDefaultDetector.Controls.Add(cb_AUs_trackingWithDefaultDetector, 2, 8);
            pnl_faceTrackingWithDefaultDetector.SetColumnSpan(cb_AUs_trackingWithDefaultDetector, 2);

            //pnl_faceTrackingWithDefaultDetector.Controls.Add(cb_modelParams_trackingWithDefaultDetector, 0, 9);
            //pnl_faceTrackingWithDefaultDetector.SetColumnSpan(cb_modelParams_trackingWithDefaultDetector, 2);
            //pnl_faceTrackingWithDefaultDetector.Controls.Add(cb_gazeEstimation_trackingWithDefaultDetector, 2, 9);
            //pnl_faceTrackingWithDefaultDetector.SetColumnSpan(cb_gazeEstimation_trackingWithDefaultDetector, 2);


            pnl_faceTrackingWithDefaultDetector.Controls.Add(cb_3dLandmark_trackingWithDefaultDetector, 0, 9);
            pnl_faceTrackingWithDefaultDetector.SetColumnSpan(cb_3dLandmark_trackingWithDefaultDetector, 2);

            pnl_faceTrackingWithDefaultDetector.Controls.Add(btn_track_trackingWithDefaultDetector, 0, 10);
            cb_2dLandmark_trackingWithDefaultDetector.Checked = true;
            cb_2dLandmark_trackingWithDefaultDetector.Enabled = false;
            return pnl_faceTrackingWithDefaultDetector;
        }

        private TableLayoutPanel CreateFaceTrackingWithTrainedDetector()
        {
            TableLayoutPanel pnl_faceTrackingWithTrainedDetector = new TableLayoutPanel { Dock = DockStyle.Fill, AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_faceTrackingWithTrainedDetector.Margin = new Padding(0);
            pnl_faceTrackingWithTrainedDetector.ColumnCount = 6;
            pnl_faceTrackingWithTrainedDetector.RowCount = 11;

            TableLayoutPanel pnl_info_faceTrackingWithTrainedDetector = new TableLayoutPanel { Dock = DockStyle.Fill, AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_info_faceTrackingWithTrainedDetector.Margin = new Padding(0);
            pnl_info_faceTrackingWithTrainedDetector.BackColor = System.Drawing.Color.LightBlue;
            pnl_info_faceTrackingWithTrainedDetector.Controls.Add(btn_gotoWalkthrough_trainedDetector);

            pnl_faceTrackingWithTrainedDetector.Controls.Add(pnl_info_faceTrackingWithTrainedDetector, 0, 0);
            pnl_faceTrackingWithTrainedDetector.SetColumnSpan(pnl_info_faceTrackingWithTrainedDetector, 6);
            pnl_faceTrackingWithTrainedDetector.Controls.Add(lbl_emptyrow_under_info_trainedDetector, 0, 1);


            //Export Frames
            TableLayoutPanel pnl_exportFrames_faceTrackingWithTrainedDetector = new TableLayoutPanel { Dock = DockStyle.Fill, AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_exportFrames_faceTrackingWithTrainedDetector.Margin = new Padding(0);
            pnl_exportFrames_faceTrackingWithTrainedDetector.ColumnCount = 6;
            pnl_exportFrames_faceTrackingWithTrainedDetector.RowCount = 3;
            pnl_exportFrames_faceTrackingWithTrainedDetector.Controls.Add(lbl_output_folder_frames_trainedDetector, 0, 0);
            pnl_exportFrames_faceTrackingWithTrainedDetector.Controls.Add(txt_output_folder_frames_trainedDetector, 1, 0);
            pnl_exportFrames_faceTrackingWithTrainedDetector.SetColumnSpan(txt_output_folder_frames_trainedDetector, 3);
            tt_output_folder_frames_trainedDetector.SetToolTip(txt_output_folder_frames_trainedDetector, Constants.TOOLTIP_OUTPUTFOLDER_FILE);
            pnl_exportFrames_faceTrackingWithTrainedDetector.Controls.Add(lbl_empty_txt_output_folder_frames_trainedDetector, 4, 0);
            pnl_exportFrames_faceTrackingWithTrainedDetector.Controls.Add(btn_output_folder_frames_trainedDetector, 5, 0);
            pnl_exportFrames_faceTrackingWithTrainedDetector.Controls.Add(lbl_videoFile_frames_trainedDetector, 0, 1);
            pnl_exportFrames_faceTrackingWithTrainedDetector.Controls.Add(txt_videoFile_frames_trainedDetector, 1, 1);
            pnl_exportFrames_faceTrackingWithTrainedDetector.SetColumnSpan(txt_videoFile_frames_trainedDetector, 3);
            tt_videoFile_frames_trainedDetector.SetToolTip(txt_videoFile_frames_trainedDetector,Constants.TOOLTIP_VIDEORECORDING);
            pnl_exportFrames_faceTrackingWithTrainedDetector.Controls.Add(lbl_empty_txt_videoFile_frames_trainedDetector, 4, 1);
            pnl_exportFrames_faceTrackingWithTrainedDetector.Controls.Add(btn_videoFile_frames_trainedDetector, 5, 1);
            pnl_exportFrames_faceTrackingWithTrainedDetector.Controls.Add(btn_exportFrames_trainedDetector, 1, 2);

            gb_exportframes_trainedDetector = CreateGBox("Export Frames", new Label(), pnl_exportFrames_faceTrackingWithTrainedDetector);
            pnl_faceTrackingWithTrainedDetector.Controls.Add(gb_exportframes_trainedDetector, 0, 2);
            pnl_faceTrackingWithTrainedDetector.SetColumnSpan(gb_exportframes_trainedDetector, 6);
            pnl_faceTrackingWithTrainedDetector.Controls.Add(lbl_emptyrow_under_frames_trainedDetector, 0, 3);
 


            //Train
            TableLayoutPanel pnl_trainDetector_faceTrackingWithTrainedDetector = new TableLayoutPanel { Dock = DockStyle.Fill, AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_trainDetector_faceTrackingWithTrainedDetector.Margin = new Padding(0);
            pnl_trainDetector_faceTrackingWithTrainedDetector.ColumnCount = 6;
            pnl_trainDetector_faceTrackingWithTrainedDetector.RowCount = 3;
            pnl_trainDetector_faceTrackingWithTrainedDetector.Controls.Add(lbl_output_folder_train_trainedDetector, 0, 0);
            pnl_trainDetector_faceTrackingWithTrainedDetector.Controls.Add(txt_output_folder_train_trainedDetector, 1, 0);
            pnl_trainDetector_faceTrackingWithTrainedDetector.SetColumnSpan(txt_output_folder_train_trainedDetector, 3);
            tt_output_folder_train_trainedDetector.SetToolTip(txt_output_folder_train_trainedDetector, Constants.TOOLTIP_OUTPUTFOLDER_FILE);
            pnl_trainDetector_faceTrackingWithTrainedDetector.Controls.Add(lbl_empty_txt_output_folder_train_trainedDetector, 4, 0);
            pnl_trainDetector_faceTrackingWithTrainedDetector.Controls.Add(btn_output_folder_train_trainedDetector, 5, 0);
            pnl_trainDetector_faceTrackingWithTrainedDetector.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));

            TableLayoutPanel pnl_trainDetector_select_images = new TableLayoutPanel { Dock = DockStyle.Fill, AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_trainDetector_select_images.Margin = new Padding(0);
            pnl_trainDetector_select_images.ColumnCount = 8;
            pnl_trainDetector_select_images.RowCount = 3;
            pnl_trainDetector_select_images.Controls.Add(lbl_select_images_training_trainedDetector, 0, 0);
            //pnl_trainDetector_select_images.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            pnl_trainDetector_select_images.Controls.Add(lb_images_training_trainedDetector, 0, 2);
            pnl_trainDetector_select_images.SetColumnSpan(lb_images_training_trainedDetector, 3);
            tt_select_trainingimages_trainedDetector.SetToolTip(lb_images_training_trainedDetector,Constants.TOOLTIP_LISTOF_TRAININGIMAGES);
            pnl_trainDetector_select_images.Controls.Add(lbl_empty_column_selectImages_trainedDetector, 3, 2);


            //TableLayoutPanel pnl_side_buttons = new TableLayoutPanel { Dock = DockStyle.Fill, AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            //pnl_side_buttons.Margin = new Padding(0);
            //pnl_side_buttons.ColumnCount = 1;
            //pnl_side_buttons.RowCount = 4;
            //pnl_side_buttons.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));

            //pnl_side_buttons.Controls.Add(new Label { Height = 70 }, 0, 0);
            //pnl_side_buttons.Controls.Add(new Label { Height = 70 }, 0, 1);
            //pnl_side_buttons.Controls.Add(btn_movetoRightList_trainedDetector, 0, 2);
            //tt_movetoRightList_trainedDetector.SetToolTip(btn_movetoRightList_trainedDetector, "Select Images for Training");
            //pnl_side_buttons.Controls.Add(btn_movetoLeftList_trainedDetector, 0, 3);
            //tt_movetoLeftList_trainedDetector.SetToolTip(btn_movetoLeftList_trainedDetector, "Remove Images from Training-Set ");
          
            //pnl_trainDetector_select_images.Controls.Add(pnl_side_buttons, 4, 1);
            //pnl_trainDetector_select_images.SetRowSpan(pnl_side_buttons, 2);

            pnl_trainDetector_select_images.Controls.Add(lbl_select_images_test_trainedDetector, 5, 0);
            pnl_trainDetector_select_images.Controls.Add(lb_images_test_trainedDetector, 5, 2);
            pnl_trainDetector_select_images.SetColumnSpan(lb_images_test_trainedDetector, 3);
            tt_select_test_trainedDetector.SetToolTip(lb_images_test_trainedDetector,Constants.TOOLTIP_LISTOF_TESTINGIMAGES);

            pnl_trainDetector_faceTrackingWithTrainedDetector.Controls.Add(pnl_trainDetector_select_images, 0, 2);
            pnl_trainDetector_faceTrackingWithTrainedDetector.SetColumnSpan(pnl_trainDetector_select_images, 6);
            pnl_trainDetector_faceTrackingWithTrainedDetector.Controls.Add(btn_training_trainedDetector, 0, 3);


            gb_train_trainedDetector = CreateGBox("Training", new Label(), pnl_trainDetector_faceTrackingWithTrainedDetector);
            pnl_faceTrackingWithTrainedDetector.Controls.Add(gb_train_trainedDetector, 0, 3);
            pnl_faceTrackingWithTrainedDetector.SetColumnSpan(gb_train_trainedDetector, 6);
            pnl_faceTrackingWithTrainedDetector.Controls.Add(lbl_emptyrow_under_training_trainedDetector, 0, 3);
            gb_train_trainedDetector.Enabled = false;


            //Tracking
            TableLayoutPanel pnl_tracking_WithTrainedDetector = new TableLayoutPanel { Dock = DockStyle.Fill, AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_tracking_WithTrainedDetector.Margin = new Padding(0);
            pnl_tracking_WithTrainedDetector.ColumnCount = 6;
            pnl_tracking_WithTrainedDetector.RowCount = 8;


            pnl_tracking_WithTrainedDetector.Controls.Add(lbl_output_folder_track_trainedDetector, 0, 0);
            pnl_tracking_WithTrainedDetector.Controls.Add(txt_output_folder_track_trainedDetector, 1, 0);
            pnl_tracking_WithTrainedDetector.SetColumnSpan(txt_output_folder_track_trainedDetector, 3);
            tt_output_folder_track_trainedDetector.SetToolTip(txt_output_folder_track_trainedDetector,Constants.TOOLTIP_OUTPUTFOLDER_FILE);
            pnl_tracking_WithTrainedDetector.Controls.Add(lbl_empty_txt_output_folder_track_trainedDetector, 4, 0);
            pnl_tracking_WithTrainedDetector.Controls.Add(btn_output_folder_track_trainedDetector, 5, 0);


            pnl_tracking_WithTrainedDetector.Controls.Add(cb_visualizeDuringTracking_trainedDetector, 0, 1);
            pnl_tracking_WithTrainedDetector.SetColumnSpan(cb_visualizeDuringTracking_trainedDetector, 6);

            pnl_tracking_WithTrainedDetector.Controls.Add(lbl_emptyrow_before_selectOutputFiles_trainedDetector, 0, 2);


            pnl_tracking_WithTrainedDetector.Controls.Add(lbl_selectOutputFiles_trainedDetector, 0, 3);

            pnl_tracking_WithTrainedDetector.Controls.Add(cb_2dLandmark_trainedDetector, 0, 4);
            pnl_tracking_WithTrainedDetector.SetColumnSpan(cb_2dLandmark_trainedDetector, 2);
            pnl_tracking_WithTrainedDetector.Controls.Add(cb_widthHegith_trainedDetector, 2, 4);
            pnl_tracking_WithTrainedDetector.SetColumnSpan(cb_widthHegith_trainedDetector, 2);
            cb_widthHegith_trainedDetector.Enabled = false;
            cb_widthHegith_trainedDetector.Checked = true;
  

            pnl_tracking_WithTrainedDetector.Controls.Add(cb_pose_trainedDetector, 0, 5);
            pnl_tracking_WithTrainedDetector.SetColumnSpan(cb_pose_trainedDetector, 2);
            pnl_tracking_WithTrainedDetector.Controls.Add(cb_AUs_trainedDetector, 2, 5);
            pnl_tracking_WithTrainedDetector.SetColumnSpan(cb_AUs_trainedDetector, 2);

            //pnl_tracking_WithTrainedDetector.Controls.Add(cb_modelParams_trainedDetector, 0, 6);
            //pnl_tracking_WithTrainedDetector.SetColumnSpan(cb_modelParams_trainedDetector, 2);
            //pnl_tracking_WithTrainedDetector.Controls.Add(cb_gazeEstimation_trainedDetector, 2, 6);
            //pnl_tracking_WithTrainedDetector.SetColumnSpan(cb_gazeEstimation_trainedDetector, 2);


            pnl_tracking_WithTrainedDetector.Controls.Add(cb_3dLandmark_trainedDetector, 0, 6);
            pnl_tracking_WithTrainedDetector.SetColumnSpan(cb_3dLandmark_trainedDetector, 2);

            pnl_tracking_WithTrainedDetector.Controls.Add(btn_track_trainedDetector, 0, 7);
            cb_2dLandmark_trainedDetector.Checked = true;
            cb_2dLandmark_trainedDetector.Enabled = false;

            gb_track_trainedDetector = CreateGBox("Tracking", new Label(), pnl_tracking_WithTrainedDetector);
            pnl_faceTrackingWithTrainedDetector.Controls.Add(gb_track_trainedDetector, 0, 4);
            pnl_faceTrackingWithTrainedDetector.SetColumnSpan(gb_track_trainedDetector, 6);
            gb_track_trainedDetector.Enabled = false;

            return pnl_faceTrackingWithTrainedDetector;
        }





    }
}
