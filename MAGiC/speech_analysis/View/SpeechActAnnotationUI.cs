using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAGiC
{
    public class SpeechActAnnotationUI : ParentUI
    {
   

        public TableLayoutPanel pnl_defineSpeechAct, pnl_annotation;

        public SpeechActAnnotationUI(INavigationListener _navigationListener) : base(_navigationListener)
        {
            pnl_defineSpeechAct=CreateDefineSpeechActControls();
            pnl_annotation=CreateAnnotationControls();
        }


        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpeechActAnnotationUI));

        /* Define Speech-Act controls*/
        /**********************************************************************************************/
        public Button btn_gotoWalkthrough_speechAct = new Button { Text = "Go to Walkthrough", AutoSize = true, BackColor = Color.AliceBlue, Font = new Font("Arial", 10, FontStyle.Bold) };

        // Define Speech-Act
        public ToolTip tt_txt_outputFile_speechAct = new ToolTip();
        public ToolTip tt_lb_speechAct = new ToolTip();
        public ToolTip tt_remove_speechAct = new ToolTip();
        public ToolTip tt_up_speechAct = new ToolTip();
        public ToolTip tt_down_speechAct = new ToolTip();

        public Label lbl_output_file_speechAct = new Label { Text = "Output File:", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public TextBox txt_outputFile_speechAct = new TextBox { AutoSize = true, Width = 470 };
        public Button btn_browseAndLoad_speechAct = new Button { Text = "Create or Load..", AutoSize = true, BackColor = Color.AliceBlue, Font = new Font("Arial", 10, FontStyle.Bold) };
        public OpenFileDialog ofd_outputFileOutput_speechAct = new OpenFileDialog();
        public Label lbl_empty_txt_outputFile_speechAct = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };

        public Label lbl_add_speechAct = new Label { Text = "Speech Act:", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public TextBox txt_add_speechAct = new TextBox { AutoSize = true, Width = 300 };
        public Button btn_add_speechAct = new Button { Text = "Add", AutoSize = true, BackColor = Color.AliceBlue, Font = new Font("Arial", 10, FontStyle.Bold) };
        public Label lbl_empty_txt_add_speechAct = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };

        public Label lbl_list_speechAct = new Label { Text = "List of Speech-Acts:", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public ListBox lb_speechAct = new ListBox { HorizontalScrollbar = true, Size = new System.Drawing.Size(616, 412), Font = new Font("Arial", 11, FontStyle.Bold), SelectionMode = SelectionMode.MultiExtended };

        public Button btn_remove_speechAct = new Button { Image = global::MAGiC.Properties.Resources.remove, BackColor = Color.AliceBlue, Size = new Size(46, 30) };
        public Button btn_up_speechAct = new Button { Image = global::MAGiC.Properties.Resources.uparrow_1, AutoSize = true, BackColor = Color.AliceBlue, Size = new Size(46, 30) };
        public Button btn_down_speechAct = new Button { Image = global::MAGiC.Properties.Resources.downarrow, AutoSize = true, BackColor = Color.AliceBlue, Size = new Size(46, 30) };


        public Button btn_save_speechAct = new Button { Text = "Save", AutoSize = true, BackColor = Constants.BUTTON_BACKCOLOR, ForeColor = Constants.BUTTON_FORECOLOR, Font = Constants.BUTTON_FONT };
        public Button btn_saveas_speechAct = new Button { Text = "Save As..", AutoSize = true, BackColor = Constants.BUTTON_BACKCOLOR, ForeColor = Constants.BUTTON_FORECOLOR, Font = Constants.BUTTON_FONT };


        public ErrorProvider errorProvider_add_speechAct = new System.Windows.Forms.ErrorProvider();
        public ErrorProvider errorProvider_list_speechAct = new System.Windows.Forms.ErrorProvider();
        public ErrorProvider errorProvider_output_file_speechAct = new System.Windows.Forms.ErrorProvider();

        /*End of Define Speech-Act) controls*/


        /* Annotation controls*/
        /**********************************************************************************************/
        public ToolTip tt_outputFile_annotation = new ToolTip();
        public ToolTip tt_lb_audioFiles_annotation = new ToolTip();
        public ToolTip tt_rbOptionFirstParticipant_annotation = new ToolTip();
        public ToolTip tt_rbOptionSecondParticipant_annotation = new ToolTip();
        public ToolTip tt_rbOptionEmpty_annotation = new ToolTip();
        public ToolTip tt_assignAndPlayNext_annotation = new ToolTip();
        public ToolTip tt_assign_annotation = new ToolTip();
        public ToolTip tt_select_speechAct_annotation = new ToolTip();
        public ToolTip tt_load_segmentInterval_annotation = new ToolTip();
        public ToolTip tt_outputFileContent_annotation = new ToolTip();

        public Button btn_gotoWalkthrough_annotation = new Button { Text = "Go to Walkthrough", AutoSize = true, BackColor = Color.AliceBlue, Font = new Font("Arial", 10, FontStyle.Bold) };
        public Label lbl_output_file_annotation = new Label { Text = "Output File:", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public TextBox txt_outputFile_annotation = new TextBox { AutoSize = true, Width = 470 };
        public Button btn_createorLoad_output_annotation = new Button { Text = "Create or Load..", AutoSize = true, BackColor = Color.AliceBlue, Font = new Font("Arial", 10, FontStyle.Bold) };
        public OpenFileDialog ofd_outputFileOutput_annotation = new OpenFileDialog();
        public Label lbl_empty_txt_outputFile_annotation = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };


        public Label lbl_list_speechAct_annotation = new Label { Text = "List of Speech-Acts:", AutoSize = true, TextAlign=ContentAlignment.BottomLeft, Font = new Font("Arial", 11, FontStyle.Bold) };
        public Button btn_load_speechAct_annotation = new Button { Text = "Load",  AutoSize = true, BackColor = Color.AliceBlue, Font = new Font("Arial", 10, FontStyle.Bold) };
        public OpenFileDialog ofd_speechAct_file_annotation = new OpenFileDialog();
        public ListBox lb_speechAct_annotation = new ListBox { HorizontalScrollbar = true, Size = new System.Drawing.Size(420, 390),   Font = new Font("Arial", 11, FontStyle.Bold), SelectionMode = SelectionMode.MultiExtended };
        

        //public Button btn_assignAndPlayNext_annotation = new Button { Image = global::MAGiC.Properties.Resources.nextbutton, AutoSize = true, BackColor = Color.AliceBlue, Size = new Size(46, 30) };
        public Button btn_assign_annotation = new Button { Image = global::MAGiC.Properties.Resources.annotate_shrinked, BackColor = Color.AliceBlue, Size = new Size(56, 33) };
        public Button btn_assignAndPlayNext_annotation = new Button { Image = global::MAGiC.Properties.Resources.annotateandplaynext_shrinked, BackColor = Color.AliceBlue, Size = new Size(56, 33) };
        public Button btn_annotate_annotation = new Button { Text = "Annotate", AutoSize = true, BackColor = Color.AliceBlue };
        public Label lbl_empty_assignAndPlayNext_annotation = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };
        public Label lbl_empty_listBoxesAttheMiddle_annotation = new Label { Text = "  ", Width = 40, Font = new Font("Arial", 11, FontStyle.Bold) };

        public Label lbl_list_audioFiles_annotation = new Label { Text = "Audio Files:", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public Button btn_load_audioFiles_annotation = new Button { Text = "Load", AutoSize = true, BackColor = Color.AliceBlue, Font = new Font("Arial", 10, FontStyle.Bold) };
        public FolderBrowserDialog fbd_audioFiles_annotation = new FolderBrowserDialog();
        public Label lbl_segment_interval_annotation = new Label { Text = "Segment Interval:", AutoSize = true, TextAlign = ContentAlignment.BottomLeft, Font = new Font("Arial", 11, FontStyle.Bold) };
        public Button btn_load_segmentInterval_annotation = new Button { Text = "Load", AutoSize = true, BackColor = Color.AliceBlue, Font = new Font("Arial", 10, FontStyle.Bold) };
     
        public OpenFileDialog ofd_segmentInterval_annotation = new OpenFileDialog();
        public ListBox lb_audioFiles_annotation = new ListBox { HorizontalScrollbar = true, Size = new System.Drawing.Size(350, 300), Font = new Font("Arial", 11, FontStyle.Bold), SelectionMode = SelectionMode.One };
        public AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
        public System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
        public TextBox txt_duration_wmlayer_annotation = new TextBox { AutoSize = true, Width = 130 };
      

        public RadioButton rbOptionFirstParticipant_annotation = new RadioButton { Text = "First Participant", AutoSize = true, TabStop = true, ForeColor = Color.DarkSlateGray, Font = new Font("Arial", 11, FontStyle.Bold) };
        public RadioButton rbOptionSecondParticipant_annotation = new RadioButton { Text = "Second Participant", AutoSize = true, TabStop = true, ForeColor = Color.DarkSlateGray, Font = new Font("Arial", 11, FontStyle.Bold) };
        public RadioButton rbOptionEmpty_annotation = new RadioButton { Text = "Empty", AutoSize = true, TabStop = true, ForeColor = Color.DarkSlateGray, Font = new Font("Arial", 11, FontStyle.Bold) };

        public Label lbl_outputFileContent_annotation = new Label { Text = "Output File Content:", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        //public Label lbl_segment_interval_annotation = new Label { Text = "Open Segment-Interval File of Loaded Audio Files:", AutoSize = true, TextAlign = ContentAlignment.BottomLeft, Font = new Font("Arial", 11, FontStyle.Bold) };
        public TextBox txt_outputFileContent_annotation = new TextBox { ScrollBars = ScrollBars.Both, WordWrap = false, Size = new System.Drawing.Size(900, 400), Font = new Font("Arial", 11, FontStyle.Bold), Multiline=true };


        public Button btn_save_annotation = new Button { Text = "Save", AutoSize = true, BackColor = Constants.BUTTON_BACKCOLOR, ForeColor = Constants.BUTTON_FORECOLOR, Font = Constants.BUTTON_FONT };
        public ErrorProvider errorProvider_output_file_annotation = new System.Windows.Forms.ErrorProvider();
        public ErrorProvider errorProvider_assignAndPlayNext_annotation = new System.Windows.Forms.ErrorProvider();
        public ErrorProvider errorProvider_load_segmentInterval_annotation = new System.Windows.Forms.ErrorProvider();

        /*End of Annotation controls*/
        private TableLayoutPanel CreateAnnotationControls(Control tb = null)
        {
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();


            TableLayoutPanel pnl_annotations = new TableLayoutPanel { Dock = DockStyle.Fill, AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_annotations.Margin = new Padding(0);
            pnl_annotations.ColumnCount = 9;
            pnl_annotations.RowCount = 7;

         
            TableLayoutPanel pnl_info_annotations = new TableLayoutPanel { Dock = DockStyle.Fill, AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_info_annotations.Margin = new Padding(0);
            pnl_info_annotations.BackColor = System.Drawing.Color.LightBlue;
            pnl_info_annotations.Controls.Add(btn_gotoWalkthrough_annotation);
            pnl_annotations.Controls.Add(pnl_info_annotations, 0, 0);
            pnl_annotations.SetColumnSpan(pnl_info_annotations, 9);

            TableLayoutPanel pnl_outputfile_annotation = new TableLayoutPanel { Dock = DockStyle.Fill, AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_outputfile_annotation.Margin = new Padding(0);
            pnl_outputfile_annotation.ColumnCount = 6;
            pnl_outputfile_annotation.RowCount = 4;
            pnl_outputfile_annotation.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            pnl_outputfile_annotation.Controls.Add(lbl_output_file_annotation, 0, 2);
            pnl_outputfile_annotation.Controls.Add(txt_outputFile_annotation, 1, 2);
            pnl_outputfile_annotation.SetColumnSpan(txt_outputFile_annotation, 3);
            tt_outputFile_annotation.SetToolTip(txt_outputFile_annotation, Constants.TOOLTIP_OUTPUTFILE_CREATEORLOAD);
            pnl_outputfile_annotation.Controls.Add(lbl_empty_txt_outputFile_annotation, 4, 2);
            pnl_outputfile_annotation.Controls.Add(btn_createorLoad_output_annotation, 5, 2);
            pnl_annotations.Controls.Add(pnl_outputfile_annotation, 0, 3);
            pnl_annotations.SetColumnSpan(pnl_outputfile_annotation, 9);

            TableLayoutPanel pnl_list_speechAct_annotation = new TableLayoutPanel { Dock = DockStyle.Fill, AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_list_speechAct_annotation.Margin = new Padding(0);
            pnl_list_speechAct_annotation.ColumnCount = 5;
            pnl_list_speechAct_annotation.RowCount = 4;
            pnl_list_speechAct_annotation.Controls.Add(lbl_list_speechAct_annotation, 0, 0);
            pnl_list_speechAct_annotation.Controls.Add(btn_load_speechAct_annotation, 1, 0);

            TableLayoutPanel pnl_radioButtons = new TableLayoutPanel { Dock = DockStyle.Fill, AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_radioButtons.Margin = new Padding(0);
            pnl_radioButtons.ColumnCount = 3;
            pnl_radioButtons.RowCount = 1;
            pnl_radioButtons.Controls.Add(rbOptionFirstParticipant_annotation, 0, 0);
            tt_rbOptionFirstParticipant_annotation.SetToolTip(rbOptionFirstParticipant_annotation, Constants.TOOLTIP_SELECT_ACTOR_OF_SPEECH_ACT);
            pnl_radioButtons.Controls.Add(rbOptionSecondParticipant_annotation, 1, 0);
            tt_rbOptionSecondParticipant_annotation.SetToolTip(rbOptionSecondParticipant_annotation, Constants.TOOLTIP_SELECT_ACTOR_OF_SPEECH_ACT);
            pnl_radioButtons.Controls.Add(rbOptionEmpty_annotation, 2, 0);
            tt_rbOptionEmpty_annotation.SetToolTip(rbOptionEmpty_annotation, Constants.TOOLTIP_SELECT_ACTOR_OF_SPEECH_ACT);

            //GroupBox gb_first_or_second_participant = CreateGBox("", rbOptionFirstParticipant_annotation, rbOptionSecondParticipant_annotation);

            //pnl_list_speechAct_annotation.Controls.Add(gb_first_or_second_participant, 0, 1);
            //pnl_list_speechAct_annotation.SetColumnSpan(gb_first_or_second_participant, 4);

            pnl_list_speechAct_annotation.Controls.Add(pnl_radioButtons, 0, 1);
            pnl_list_speechAct_annotation.SetColumnSpan(pnl_radioButtons, 4);


            pnl_list_speechAct_annotation.Controls.Add(lb_speechAct_annotation, 0, 2);
            pnl_list_speechAct_annotation.SetColumnSpan(lb_speechAct_annotation, 3);
            pnl_list_speechAct_annotation.SetRowSpan(lb_speechAct_annotation, 3);
            tt_select_speechAct_annotation.SetToolTip(lb_speechAct_annotation, Constants.TOOLTIP_MULTIPLE_SELECTION);

            //pnl_list_speechAct_annotation.Controls.Add(btn_assign_annotation, 3, 2);
            //pnl_list_speechAct_annotation.Controls.Add(btn_assignAndPlayNext_annotation, 3, 3);
            //pnl_list_speechAct_annotation.Controls.Add(lbl_empty_assignAndPlayNext_annotation, 4, 3);
  

            TableLayoutPanel pnl_side_buttons = new TableLayoutPanel { Dock = DockStyle.Fill, AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_side_buttons.Margin = new Padding(0);
            pnl_side_buttons.ColumnCount = 1;
            pnl_side_buttons.RowCount = 4;
            pnl_side_buttons.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));

  
            pnl_side_buttons.Controls.Add(new Label { Height = 50 }, 0, 1);
            pnl_side_buttons.Controls.Add(new Label { Height = 50 }, 0, 2);
            pnl_side_buttons.Controls.Add(btn_assign_annotation, 0, 2);
         
            pnl_side_buttons.Controls.Add(btn_assign_annotation, 0, 3);
            tt_assign_annotation.SetToolTip(btn_assign_annotation, Constants.TOOLTIP_ANNOTATE);
            pnl_side_buttons.Controls.Add(btn_assignAndPlayNext_annotation, 0, 4);
            tt_assignAndPlayNext_annotation.SetToolTip(btn_assignAndPlayNext_annotation, Constants.TOOLTIP_ANNOTATE_PLAYNEXT);


            pnl_list_speechAct_annotation.Controls.Add(pnl_side_buttons, 4, 2);
            pnl_list_speechAct_annotation.SetRowSpan(pnl_side_buttons, 4);


            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
           // this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(350, 46);
            this.axWindowsMediaPlayer1.TabIndex = 14;
            this.axWindowsMediaPlayer1.UseWaitCursor = true;
     
            TableLayoutPanel pnl_list_audioFiles_annotation = new TableLayoutPanel { Dock = DockStyle.Fill, AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_list_audioFiles_annotation.Margin = new Padding(0);
            pnl_list_audioFiles_annotation.ColumnCount = 3;
            pnl_list_audioFiles_annotation.RowCount = 5;
            pnl_list_audioFiles_annotation.Controls.Add(lbl_list_audioFiles_annotation, 0, 0);
            pnl_list_audioFiles_annotation.Controls.Add(btn_load_audioFiles_annotation, 1, 0);
            pnl_list_audioFiles_annotation.Controls.Add(lbl_segment_interval_annotation,0,1);
            pnl_list_audioFiles_annotation.Controls.Add(btn_load_segmentInterval_annotation,1,1);
            tt_load_segmentInterval_annotation.SetToolTip(btn_load_segmentInterval_annotation, Constants.TOOLTIP_LOADSEGMENTSINERVAL);
            pnl_list_audioFiles_annotation.Controls.Add(lb_audioFiles_annotation, 0, 4);
            pnl_list_audioFiles_annotation.SetColumnSpan(lb_audioFiles_annotation, 3);
            tt_lb_audioFiles_annotation.SetToolTip(lb_audioFiles_annotation,Constants.TOOLTIP_LISTOF_AUDIO_FILES);
            pnl_list_audioFiles_annotation.Controls.Add(txt_duration_wmlayer_annotation, 2, 2);
            pnl_list_audioFiles_annotation.Controls.Add(axWindowsMediaPlayer1, 0, 3);
            pnl_list_audioFiles_annotation.SetColumnSpan(axWindowsMediaPlayer1, 3);
            TableLayoutPanel pnl_listBoxesAttheMiddle_annotation = new TableLayoutPanel { Dock = DockStyle.Fill, AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_listBoxesAttheMiddle_annotation.Margin = new Padding(0);
            pnl_listBoxesAttheMiddle_annotation.ColumnCount = 3;
            pnl_listBoxesAttheMiddle_annotation.RowCount = 4;
            pnl_listBoxesAttheMiddle_annotation.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            pnl_listBoxesAttheMiddle_annotation.Controls.Add(pnl_list_audioFiles_annotation, 0, 1);
            pnl_listBoxesAttheMiddle_annotation.SetRowSpan(pnl_list_audioFiles_annotation, 3);
            pnl_listBoxesAttheMiddle_annotation.Controls.Add(lbl_empty_listBoxesAttheMiddle_annotation, 1, 1);
            pnl_listBoxesAttheMiddle_annotation.SetRowSpan(lbl_empty_listBoxesAttheMiddle_annotation, 3);
            pnl_listBoxesAttheMiddle_annotation.Controls.Add(pnl_list_speechAct_annotation,2,1);
            pnl_listBoxesAttheMiddle_annotation.SetRowSpan(pnl_list_speechAct_annotation, 3);
            //pnl_listBoxesAttheMiddle_annotation.Controls.Add(btn_assignAndPlayNext_annotation,1,1);


            pnl_annotations.Controls.Add(pnl_listBoxesAttheMiddle_annotation, 0, 4);
            pnl_annotations.SetColumnSpan(pnl_listBoxesAttheMiddle_annotation, 9);

            TableLayoutPanel pnl_listBoxAttheBottom_annotation = new TableLayoutPanel { Dock = DockStyle.Fill, AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_listBoxAttheBottom_annotation.Margin = new Padding(0);
            pnl_listBoxAttheBottom_annotation.ColumnCount = 3;
            pnl_listBoxAttheBottom_annotation.RowCount = 2;
            pnl_listBoxAttheBottom_annotation.Controls.Add(lbl_outputFileContent_annotation,0,0);
            pnl_listBoxAttheBottom_annotation.Controls.Add(txt_outputFileContent_annotation, 0, 1);
            pnl_listBoxAttheBottom_annotation.SetColumnSpan(txt_outputFileContent_annotation, 3);
            tt_outputFileContent_annotation.SetToolTip(txt_outputFileContent_annotation, Constants.TOOLTIP_OUTPUTFILE_CONTENT);


            pnl_annotations.Controls.Add(pnl_listBoxAttheBottom_annotation, 0, 5);
            pnl_annotations.SetColumnSpan(pnl_listBoxAttheBottom_annotation, 9);
            pnl_annotations.Controls.Add(btn_save_annotation, 0, 6);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            return pnl_annotations;



        }

        private TableLayoutPanel CreateDefineSpeechActControls()
        {

            TableLayoutPanel pnl_define_sppechAct = new TableLayoutPanel { Dock = DockStyle.Fill, AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_define_sppechAct.Margin = new Padding(0);
            pnl_define_sppechAct.ColumnCount = 9;
            pnl_define_sppechAct.RowCount = 11;

            TableLayoutPanel pnl_info_define_speechAct = new TableLayoutPanel { Dock = DockStyle.Fill, AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_info_define_speechAct.Margin = new Padding(0);
            pnl_info_define_speechAct.BackColor = System.Drawing.Color.LightBlue;
            pnl_info_define_speechAct.Controls.Add(btn_gotoWalkthrough_speechAct);
            pnl_define_sppechAct.Controls.Add(pnl_info_define_speechAct, 0, 0);
            pnl_define_sppechAct.SetColumnSpan(pnl_info_define_speechAct, 9);

           

            pnl_define_sppechAct.Controls.Add(lbl_output_file_speechAct, 0, 1);
            pnl_define_sppechAct.Controls.Add(txt_outputFile_speechAct, 1, 1);
            pnl_define_sppechAct.SetColumnSpan(txt_outputFile_speechAct, 3);


            TableLayoutPanel pnl_browse_and_load = new TableLayoutPanel { Dock = DockStyle.Fill, AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_browse_and_load.Margin = new Padding(0);
            pnl_browse_and_load.ColumnCount = 6;
            pnl_browse_and_load.RowCount = 4;
            pnl_browse_and_load.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            pnl_browse_and_load.Controls.Add(lbl_output_file_speechAct, 0, 2);
            pnl_browse_and_load.Controls.Add(txt_outputFile_speechAct, 1, 2);
            pnl_browse_and_load.SetColumnSpan(txt_outputFile_speechAct, 3);
            pnl_browse_and_load.Controls.Add(lbl_empty_txt_outputFile_speechAct, 4, 2);
            pnl_browse_and_load.Controls.Add(btn_browseAndLoad_speechAct, 5, 2);

            pnl_browse_and_load.Controls.Add(lbl_add_speechAct, 0, 3);
            pnl_browse_and_load.Controls.Add(txt_add_speechAct, 1, 3);
            pnl_browse_and_load.SetColumnSpan(txt_add_speechAct, 3);
            pnl_browse_and_load.Controls.Add(lbl_empty_txt_add_speechAct, 4, 3);
            pnl_browse_and_load.Controls.Add(btn_add_speechAct, 5, 3);
            pnl_define_sppechAct.Controls.Add(pnl_browse_and_load, 0, 1);
            pnl_define_sppechAct.SetColumnSpan(pnl_browse_and_load, 6);
            pnl_define_sppechAct.SetRowSpan(pnl_browse_and_load, 2);



            pnl_define_sppechAct.Controls.Add(lbl_list_speechAct, 0, 3);
            pnl_define_sppechAct.Controls.Add(lb_speechAct, 0, 4);
            pnl_define_sppechAct.SetRowSpan(lb_speechAct, 4);
            pnl_define_sppechAct.SetColumnSpan(lb_speechAct, 4);


            TableLayoutPanel pnl_side_buttons = new TableLayoutPanel { Dock = DockStyle.Fill, AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_side_buttons.Margin = new Padding(0);
            pnl_side_buttons.ColumnCount = 1;
            pnl_side_buttons.RowCount = 7;
            pnl_side_buttons.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));

            pnl_side_buttons.Controls.Add(btn_remove_speechAct, 0, 0);
            tt_remove_speechAct.SetToolTip(btn_remove_speechAct, "Remove Selected Item(s)");
            pnl_side_buttons.Controls.Add(new Label { Height = 50 }, 0, 1);
            pnl_side_buttons.Controls.Add(new Label { Height = 50 }, 0, 2);
            pnl_side_buttons.Controls.Add(btn_up_speechAct, 0, 3);
            tt_up_speechAct.SetToolTip(btn_up_speechAct, "Move Selected Item Up");
            pnl_side_buttons.Controls.Add(btn_down_speechAct, 0, 4);
            tt_down_speechAct.SetToolTip(btn_down_speechAct, "Move Selected Item Down");

            pnl_define_sppechAct.Controls.Add(pnl_side_buttons, 4, 4);
            pnl_define_sppechAct.SetRowSpan(pnl_side_buttons, 4);

            TableLayoutPanel pnl_buttom_buttons = new TableLayoutPanel { Dock = DockStyle.Fill, AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_buttom_buttons.Margin = new Padding(0);
            pnl_buttom_buttons.ColumnCount = 2;
            pnl_buttom_buttons.RowCount = 1;
            pnl_buttom_buttons.Controls.Add(btn_save_speechAct, 0, 0);

            // button click action is also implemented, you should uncomment below line to use "save as" button functionality
            //pnl_buttom_buttons.Controls.Add(btn_saveas_speechAct, 1, 0); 


            pnl_define_sppechAct.Controls.Add(pnl_buttom_buttons, 0, 9);

            errorProvider_list_speechAct.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider_add_speechAct.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider_output_file_speechAct.BlinkStyle = ErrorBlinkStyle.NeverBlink;


            return pnl_define_sppechAct;
        }


    }
}
