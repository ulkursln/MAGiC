using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAGiC
{
    public class SpecifyTimeIntervalUI : ParentUI
    {
        public TableLayoutPanel pnl_specifyTimeInterval;

        public SpecifyTimeIntervalUI(INavigationListener _navigationListener) : base(_navigationListener)
        {
            pnl_specifyTimeInterval=getLayout();
        }

        /* Time Interval Specification (also, Synchronization for Multiple Recordings) controls*/
        /**********************************************************************************************/
        public Button btn_gotoWalkthrough_determine_interval = new Button { Text = "Go to Walkthrough", AutoSize = true, BackColor = Color.AliceBlue, Font = new Font("Arial", 10, FontStyle.Bold) };
        // radio buttons TabStop is false by default... weird.
        public RadioButton rbOptionSingle_determine_interval = new RadioButton { Text = "Single Participant", AutoSize = true, TabStop = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public RadioButton rbOptionMultiple_determine_interval = new RadioButton { Text = "Pair", AutoSize = true, TabStop = true, Font = new Font("Arial", 11, FontStyle.Bold) };

        public Label lbl_output_file_determine_interval = new Label { Text = "Output File:", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public TextBox txt_outputFile_determine_interval = new TextBox { AutoSize = true, Width = 600 };
        public Button btn_openFileOutput_determine_interval = new Button { Text = "Create or Load..",  AutoSize = true, BackColor = Color.AliceBlue, Font = new Font("Arial", 10, FontStyle.Bold) };
        public OpenFileDialog ofd_outputFileOutput_determine_interval = new OpenFileDialog();
        public FolderBrowserDialog fbd_outputFolder_interval_create = new FolderBrowserDialog();

        public TableLayoutPanel pnl_singleFile_interval, pnl_multipleFile_interval, pnl_multipleFile_resegment;
        public ErrorProvider errorProvider_outputFile_interval = new System.Windows.Forms.ErrorProvider();

        //Single
        public ToolTip tt_interval_file_determine_interval_single = new ToolTip();
        public ToolTip tt_id_determine_interval_single = new ToolTip();
        public ToolTip tt_starting_number_determine_interval_single = new ToolTip();
        public ToolTip tt_final_number_determine_interval_single = new ToolTip();
        public ToolTip tt_output_file_determine_interval_single = new ToolTip();

        public Label lbl_interval_file_determine_interval_single = new Label { Text = "File (Segments-Intervals):", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public TextBox txt_interval_determine_interval_single = new TextBox { AutoSize = true, Width = 600 };
        public Button btn_openFileInterval_determine_interval_single = new Button { Text = "...", AutoSize = true, BackColor = Color.AliceBlue, Width = 30, Font = new Font("Arial", 11, FontStyle.Bold) };
        public OpenFileDialog ofd_openFileInterval_determine_interval_single = new OpenFileDialog();

        public Label lbl_starting_number_determine_interval_single = new Label { Text = "Experiment Interval:", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public TextBox txt_starting_number_determine_interval_single = new TextBox { AutoSize = true, Width = 100 };
        public Label lbl_interval_to_text = new Label { Text = " to ", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };

        public TextBox txt_final_number_determine_interval_single = new TextBox { AutoSize = true, Width = 100 };

        public Label lbl_id_determine_interval_single = new Label { Text = "Id:", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public TextBox txt_id_determine_interval_single = new TextBox { AutoSize = true, Width = 100 };

        public Button btn_save_determine_interval_single = new Button { Text = "Save", AutoSize = true, BackColor = Color.AliceBlue, ForeColor=Color.DodgerBlue, Font = new Font("Arial", 10, FontStyle.Bold) };


        public ErrorProvider errorProvider_segmentsIntervalFile_single = new System.Windows.Forms.ErrorProvider();
        public ErrorProvider errorProvider_starting_segment_single = new System.Windows.Forms.ErrorProvider();
        public ErrorProvider errorProvider_final_segment_single = new System.Windows.Forms.ErrorProvider();
        public ErrorProvider errorProvider_id_single = new System.Windows.Forms.ErrorProvider();

        public Label lbl_empty_txt_interval_determine_interval_single = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };
        public Label lbl_empty_outputFile_determine_interval = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };
        public Label lbl_empty_txt_final_number_determine_interval_single = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };



        //Multiple
        public ToolTip tt_id_determine_interval_multiple = new ToolTip();
        public ToolTip tt_interval_determine_interval_multiple_1 = new ToolTip();
        public ToolTip tt_starting_number_determine_interval_multiple_1 = new ToolTip();
        public ToolTip tt_final_number_determine_interval_multiple_1 = new ToolTip();
        public ToolTip tt_interval_determine_interval_multiple_2 = new ToolTip();
        public ToolTip tt_starting_number_determine_interval_multiple_2 = new ToolTip();
        public ToolTip tt_final_number_determine_interval_multiple_2 = new ToolTip();
        public ToolTip tt_resegment_file = new ToolTip();
        public ToolTip tt_outputFolder_resegment = new ToolTip();

        public Label lbl_id_determine_interval_multiple = new Label { Text = "Id:", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public TextBox txt_id_determine_interval_multiple = new TextBox { AutoSize = true, Width = 100 };


        public ErrorProvider errorProvider_id_multiple = new System.Windows.Forms.ErrorProvider();
        public Button btn_save_determine_interval_multiple = new Button { Text = "Save", AutoSize = true, BackColor = Constants.BUTTON_BACKCOLOR, ForeColor = Constants.BUTTON_FORECOLOR, Font = Constants.BUTTON_FONT };
        public Button btn_save_resegment_determine_interval_multiple = new Button { Text = "Save && Re-Segment", AutoSize = true, BackColor = Constants.BUTTON_BACKCOLOR, ForeColor = Constants.BUTTON_FORECOLOR, Font = Constants.BUTTON_FONT };
        public Label cb_resegment = new Label {  AutoSize = true, Text = "Re-Segment with Synchronization Info ", Font = new Font("Arial", 11, FontStyle.Bold) };

        public Label lbl_empty_txt_interval_determine_interval_multiple_1 = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };
        public Label lbl_empty_txt_final_number_determine_interval_multiple_1 = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };
        public Label lbl_empty_txt_interval_determine_interval_multiple_2 = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };
        public Label lbl_empty_txt_final_number_determine_interval_multiple_2 = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };

        //Pair-1
        public Label lbl_interval_file_multiple_1 = new Label { Text = "First Participant:", AutoSize = true,  Font = new Font("Arial", 11, FontStyle.Bold) };
        public Label lbl_interval_file_determine_interval_multiple_1 = new Label { Text = "File (Segments-Intervals):", AutoSize = true, ForeColor = Color.DarkSlateGray, Font = new Font("Arial", 10, FontStyle.Bold) };
        public TextBox txt_interval_determine_interval_multiple_1 = new TextBox { AutoSize = true, Width = 600 };
        public Button btn_openFileInterval_determine_interval_multiple_1 = new Button { Text = "...", AutoSize = true, BackColor = Color.AliceBlue, Width = 30, Font = new Font("Arial", 10, FontStyle.Bold) };
        public OpenFileDialog ofd_openFileInterval_determine_interval_multiple_1 = new OpenFileDialog();

        public Label lbl_starting_number_determine_interval_multiple_1 = new Label { Text = "Experiment Interval:", AutoSize = true, ForeColor = Color.DarkSlateGray, Font = new Font("Arial", 10, FontStyle.Bold) };
        public TextBox txt_starting_number_determine_interval_multiple_1 = new TextBox { AutoSize = true, Width = 100 };
        public Label lbl_interval_to_text_multiple_1 = new Label { Text = " to ", AutoSize = true, ForeColor = Color.DarkSlateGray, Font = new Font("Arial", 10, FontStyle.Bold) };
        public TextBox txt_final_number_determine_interval_multiple_1 = new TextBox { AutoSize = true, Width = 100 };

        public ErrorProvider errorProvider_segmentsIntervalFile_multiple_1 = new System.Windows.Forms.ErrorProvider();
        public ErrorProvider errorProvider_starting_segment_multiple_1 = new System.Windows.Forms.ErrorProvider();
        public ErrorProvider errorProvider_final_segment_multiple_1 = new System.Windows.Forms.ErrorProvider();

        //Pair-2
        public Label lbl_interval_file_multiple_2 = new Label { Text = "Second Participant:", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public Label lbl_interval_file_determine_interval_multiple_2 = new Label { Text = "File (Segments-Intervals):", AutoSize = true, ForeColor = Color.DarkSlateGray, Font = new Font("Arial", 10, FontStyle.Bold) };
        public TextBox txt_interval_determine_interval_multiple_2 = new TextBox { AutoSize = true, Width = 600 };
        public Button btn_openFileInterval_determine_interval_multiple_2 = new Button { Text = "...", AutoSize = true, BackColor = Color.AliceBlue, Width = 30, Font = new Font("Arial", 10, FontStyle.Bold) };
        public OpenFileDialog ofd_openFileInterval_determine_interval_multiple_2 = new OpenFileDialog();

        public Label lbl_starting_number_determine_interval_multiple_2 = new Label { Text = "Experiment Interval:", AutoSize = true, ForeColor = Color.DarkSlateGray, Font = new Font("Arial", 10, FontStyle.Bold) };
        public TextBox txt_starting_number_determine_interval_multiple_2 = new TextBox { AutoSize = true, Width = 100 };
        public Label lbl_interval_to_text_multiple_2 = new Label { Text = " to ", AutoSize = true, ForeColor = Color.DarkSlateGray, Font = new Font("Arial", 10, FontStyle.Bold) };
        public TextBox txt_final_number_determine_interval_multiple_2 = new TextBox { AutoSize = true, Width = 100 };

        public ErrorProvider errorProvider_segmentsIntervalFile_multiple_2 = new System.Windows.Forms.ErrorProvider();
        public ErrorProvider errorProvider_starting_segment_multiple_2 = new System.Windows.Forms.ErrorProvider();
        public ErrorProvider errorProvider_final_segment_multiple_2 = new System.Windows.Forms.ErrorProvider();

        //Resegment
        public Label lbl_output_file_resegment = new Label { Text = "Output Folder:", AutoSize = true, Font = new Font("Arial", 10, FontStyle.Bold) };
        public TextBox txt_outputFolder_resegment = new TextBox { AutoSize = true, Width = 600 };
        public Button btn_openFolderOutput_resegment = new Button { Text = "...", AutoSize = true, BackColor = Color.AliceBlue, Width = 30, Font = new Font("Arial", 10, FontStyle.Bold) };
        public FolderBrowserDialog fbd_outputFile_resegment = new FolderBrowserDialog();

        public Label lbl_select_participant_in_pair_resegment = new Label { Text = "Select one participant in the pair (preferably the one who talk more):", AutoSize = true, Font = new Font("Arial", 10, FontStyle.Bold) };
        public RadioButton rbOptionFirstParticipant_determine_interval_resegment = new RadioButton { Text = "First Participant", AutoSize = true, TabStop = true, ForeColor = Color.DarkSlateGray, Font = new Font("Arial", 11, FontStyle.Bold) };
        public RadioButton rbOptionSecondParticipant_determine_interval_resegment = new RadioButton { Text = "Second Participant", AutoSize = true, TabStop = true, ForeColor = Color.DarkSlateGray, Font = new Font("Arial", 11, FontStyle.Bold) };

        public Label lbl_resegment_file_ = new Label { Text = "Formatted Wav File:", AutoSize = true, ForeColor = Color.DarkSlateGray, Font = new Font("Arial", 10, FontStyle.Bold) };
        public TextBox txt_resegment_file = new TextBox { AutoSize = true, Width = 600 };
        public Button btn_openFile_resegment = new Button { Text = "...", AutoSize = true, BackColor = Color.AliceBlue, Width = 30, Font = new Font("Arial", 10, FontStyle.Bold) };
        public OpenFileDialog ofd_openFile_resegment = new OpenFileDialog();

        public Label lbl_empty_txt_resegment_file = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };
        public Label lbl_empty_txt_outputFolder_resegment = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };

        public ErrorProvider errorProvider_openFile_resegment = new System.Windows.Forms.ErrorProvider();
        public ErrorProvider errorProvider_outputFolder_resegment = new System.Windows.Forms.ErrorProvider();
        public ErrorProvider errorProvider_first_or_second_partiicpant_resegment = new System.Windows.Forms.ErrorProvider();


        /*End of Time Interval Specification (also, Synchronization for Multiple Recordings) controls*/


        private TableLayoutPanel getLayout()
        {
            //start to design interface
            TableLayoutPanel pnl_main_intervalAudio = new TableLayoutPanel { Dock = DockStyle.Fill, AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_main_intervalAudio.Margin = new Padding(0);
            pnl_main_intervalAudio.ColumnCount = 9;
            pnl_main_intervalAudio.RowCount = 3;

            TableLayoutPanel pnl_info_interval = new TableLayoutPanel { Dock = DockStyle.Fill, AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_info_interval.Margin = new Padding(0);
            pnl_info_interval.BackColor = System.Drawing.Color.LightBlue;
            pnl_info_interval.Controls.Add(btn_gotoWalkthrough_determine_interval);

            TableLayoutPanel pnl_inner_interval = new TableLayoutPanel { Dock = DockStyle.Fill, Height=800};
            pnl_inner_interval.Margin = new Padding(0);
            pnl_inner_interval.ColumnCount = 9;
            pnl_inner_interval.RowCount = 4;

            pnl_inner_interval.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));

            pnl_inner_interval.Controls.Add(lbl_output_file_determine_interval, 0, 2);
            pnl_inner_interval.Controls.Add(txt_outputFile_determine_interval, 1, 2);
            pnl_inner_interval.Controls.Add(lbl_empty_outputFile_determine_interval, 2, 2);
            pnl_inner_interval.Controls.Add(btn_openFileOutput_determine_interval, 3, 2);
            tt_output_file_determine_interval_single.SetToolTip(txt_outputFile_determine_interval, Constants.TOOLTIP_OUTPUTFILE_CREATEORLOAD);

            pnl_singleFile_interval = new TableLayoutPanel { Dock = DockStyle.Fill, AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_singleFile_interval.Margin = new Padding(0);
            pnl_singleFile_interval.ColumnCount = 8;
            pnl_singleFile_interval.RowCount = 8;

            pnl_singleFile_interval.Controls.Add(lbl_id_determine_interval_single, 0, 0);
            pnl_singleFile_interval.Controls.Add(txt_id_determine_interval_single, 1, 0);
            tt_id_determine_interval_single.SetToolTip(txt_id_determine_interval_single,Constants.TOOLTIP_PARTICIPANTID);
            pnl_singleFile_interval.Controls.Add(lbl_empty, 2, 0);

            pnl_singleFile_interval.Controls.Add(lbl_interval_file_determine_interval_single, 0, 1);
            pnl_singleFile_interval.Controls.Add(txt_interval_determine_interval_single, 1, 1);
            pnl_singleFile_interval.SetColumnSpan(txt_interval_determine_interval_single, 4);
            tt_interval_file_determine_interval_single.SetToolTip(txt_interval_determine_interval_single, Constants.TOOLTIP_SEGMENTSINTERVAL_FILE);
            pnl_singleFile_interval.Controls.Add(lbl_empty_txt_interval_determine_interval_single, 6, 1);
            pnl_singleFile_interval.Controls.Add(btn_openFileInterval_determine_interval_single, 7, 1);


            pnl_singleFile_interval.Controls.Add(lbl_starting_number_determine_interval_single, 0, 2);
            pnl_singleFile_interval.Controls.Add(txt_starting_number_determine_interval_single, 1, 2);
            tt_starting_number_determine_interval_single.SetToolTip(txt_starting_number_determine_interval_single, Constants.TOOLTIP_EXP_INTERVAL);
            pnl_singleFile_interval.Controls.Add(lbl_interval_to_text, 2, 2);
            pnl_singleFile_interval.Controls.Add(txt_final_number_determine_interval_single, 3, 2);
            tt_final_number_determine_interval_single.SetToolTip(txt_final_number_determine_interval_single, Constants.TOOLTIP_EXP_INTERVAL);
            pnl_singleFile_interval.Controls.Add(lbl_empty_txt_final_number_determine_interval_single, 4, 2);




            pnl_singleFile_interval.Controls.Add(btn_save_determine_interval_single, 0, 3);


            pnl_multipleFile_interval = new TableLayoutPanel { Dock = DockStyle.Fill, Height=800};
            pnl_multipleFile_interval.Margin = new Padding(0);
            pnl_multipleFile_interval.ColumnCount = 9;
            pnl_multipleFile_interval.RowCount = 12;

            pnl_multipleFile_interval.Controls.Add(lbl_id_determine_interval_multiple, 0, 0);
            pnl_multipleFile_interval.Controls.Add(txt_id_determine_interval_multiple, 1, 0);
            tt_id_determine_interval_multiple.SetToolTip(txt_id_determine_interval_multiple, Constants.TOOLTIP_PARTICIPANTID);
            pnl_multipleFile_interval.Controls.Add(lbl_empty, 2, 0);

            pnl_multipleFile_interval.Controls.Add(lbl_interval_file_multiple_1, 0, 1);
            pnl_multipleFile_interval.Controls.Add(lbl_interval_file_determine_interval_multiple_1, 1, 2);
            pnl_multipleFile_interval.Controls.Add(txt_interval_determine_interval_multiple_1, 2, 2);
            pnl_multipleFile_interval.SetColumnSpan(txt_interval_determine_interval_multiple_1, 4);
            tt_interval_determine_interval_multiple_1.SetToolTip(txt_interval_determine_interval_multiple_1, Constants.TOOLTIP_SEGMENTSINTERVAL_FILE);
            pnl_multipleFile_interval.Controls.Add(lbl_empty_txt_interval_determine_interval_multiple_1, 7, 2);
            pnl_multipleFile_interval.Controls.Add(btn_openFileInterval_determine_interval_multiple_1, 8, 2);



            pnl_multipleFile_interval.Controls.Add(lbl_starting_number_determine_interval_multiple_1, 1, 3);
            pnl_multipleFile_interval.Controls.Add(txt_starting_number_determine_interval_multiple_1, 2, 3);
            tt_starting_number_determine_interval_multiple_1.SetToolTip(txt_starting_number_determine_interval_multiple_1, Constants.TOOLTIP_EXP_INTERVAL);
            pnl_multipleFile_interval.Controls.Add(lbl_interval_to_text_multiple_1, 3, 3);
            pnl_multipleFile_interval.Controls.Add(txt_final_number_determine_interval_multiple_1, 4, 3);
            tt_final_number_determine_interval_multiple_1.SetToolTip(txt_final_number_determine_interval_multiple_1, Constants.TOOLTIP_EXP_INTERVAL);
            pnl_multipleFile_interval.Controls.Add(lbl_empty_txt_final_number_determine_interval_multiple_1, 5, 3);


            pnl_multipleFile_interval.Controls.Add(lbl_interval_file_multiple_2, 0, 4);

            pnl_multipleFile_interval.Controls.Add(lbl_interval_file_determine_interval_multiple_2, 1, 5);
            pnl_multipleFile_interval.Controls.Add(txt_interval_determine_interval_multiple_2, 2, 5);
            pnl_multipleFile_interval.SetColumnSpan(txt_interval_determine_interval_multiple_2, 4);
            tt_interval_determine_interval_multiple_2.SetToolTip(txt_interval_determine_interval_multiple_2, Constants.TOOLTIP_SEGMENTSINTERVAL_FILE);
            pnl_multipleFile_interval.Controls.Add(lbl_empty_txt_interval_determine_interval_multiple_2, 7, 5);
            pnl_multipleFile_interval.Controls.Add(btn_openFileInterval_determine_interval_multiple_2, 8, 5);

            pnl_multipleFile_interval.Controls.Add(lbl_starting_number_determine_interval_multiple_2, 1, 6);
            pnl_multipleFile_interval.Controls.Add(txt_starting_number_determine_interval_multiple_2, 2, 6);
            tt_starting_number_determine_interval_multiple_2.SetToolTip(txt_starting_number_determine_interval_multiple_2, Constants.TOOLTIP_EXP_INTERVAL);
            pnl_multipleFile_interval.Controls.Add(lbl_interval_to_text_multiple_2, 3, 6);
            pnl_multipleFile_interval.Controls.Add(txt_final_number_determine_interval_multiple_2, 4, 6);
            tt_final_number_determine_interval_multiple_2.SetToolTip(txt_final_number_determine_interval_multiple_2, Constants.TOOLTIP_EXP_INTERVAL);
            pnl_multipleFile_interval.Controls.Add(lbl_empty_txt_final_number_determine_interval_multiple_2, 5, 6);

            //pnl_multipleFile_interval.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            pnl_multipleFile_interval.Controls.Add(new Label { Height = 50 }, 0, 7);
            pnl_multipleFile_interval.Controls.Add(cb_resegment, 0, 8);
            pnl_multipleFile_interval.SetColumnSpan(cb_resegment, 9);


            //resegment
            pnl_multipleFile_resegment = new TableLayoutPanel { Dock = DockStyle.Fill, AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_multipleFile_resegment.Margin = new Padding(0);
            pnl_multipleFile_resegment.ColumnCount = 8;
            pnl_multipleFile_resegment.RowCount = 4;

            pnl_multipleFile_resegment.Controls.Add(lbl_output_file_resegment, 0, 0);
            pnl_multipleFile_resegment.Controls.Add(txt_outputFolder_resegment, 1, 0);
            pnl_multipleFile_resegment.SetColumnSpan(txt_outputFolder_resegment, 3);
            tt_outputFolder_resegment.SetToolTip(txt_outputFolder_resegment, Constants.TOOLTIP_OUTPUTFOLDER_FILE);
            pnl_multipleFile_resegment.Controls.Add(lbl_empty_txt_outputFolder_resegment, 4, 0);
            pnl_multipleFile_resegment.Controls.Add(btn_openFolderOutput_resegment, 5, 0);


            pnl_multipleFile_resegment.Controls.Add(lbl_select_participant_in_pair_resegment, 0, 1);
            pnl_multipleFile_resegment.SetColumnSpan(lbl_select_participant_in_pair_resegment, 5);



            TableLayoutPanel pnl_formattedWavFile_resegment= new TableLayoutPanel { Dock = DockStyle.Fill, AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_formattedWavFile_resegment.Margin = new Padding(0);
            pnl_formattedWavFile_resegment.ColumnCount = 6;
            pnl_formattedWavFile_resegment.RowCount = 1;

            pnl_formattedWavFile_resegment.Controls.Add(lbl_resegment_file_, 0, 0);
            pnl_formattedWavFile_resegment.Controls.Add(txt_resegment_file, 1, 0);
            pnl_formattedWavFile_resegment.SetColumnSpan(txt_resegment_file, 3);
            tt_resegment_file.SetToolTip(txt_resegment_file,Constants.TOOLTIP_AUDIOFILE);
            pnl_formattedWavFile_resegment.Controls.Add(lbl_empty_txt_resegment_file, 4,0);
            pnl_formattedWavFile_resegment.Controls.Add(btn_openFile_resegment, 5, 0);

            GroupBox gb_first_or_second_partiicpant = CreateGBox("", rbOptionFirstParticipant_determine_interval_resegment, rbOptionSecondParticipant_determine_interval_resegment,
           new Label(), pnl_formattedWavFile_resegment);

            pnl_multipleFile_resegment.Controls.Add(gb_first_or_second_partiicpant, 1, 2);
            pnl_multipleFile_resegment.SetColumnSpan(gb_first_or_second_partiicpant, 7);


        
            pnl_multipleFile_interval.Controls.Add(pnl_multipleFile_resegment, 0, 9);
            pnl_multipleFile_interval.SetColumnSpan(pnl_multipleFile_resegment, 8);

            pnl_multipleFile_interval.Controls.Add(btn_save_resegment_determine_interval_multiple, 0, 11);

            errorProvider_final_segment_multiple_1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider_final_segment_multiple_2.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider_final_segment_single.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider_id_multiple.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider_id_single.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider_openFile_resegment.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider_outputFile_interval.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider_outputFolder_resegment.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider_segmentsIntervalFile_multiple_1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider_segmentsIntervalFile_multiple_2.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider_segmentsIntervalFile_single.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider_starting_segment_multiple_1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider_starting_segment_multiple_2.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider_starting_segment_single.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider_first_or_second_partiicpant_resegment.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            GroupBox gb_interval = null;
      

            rbOptionSingle_determine_interval.CheckedChanged += delegate
            {
                if (rbOptionSingle_determine_interval.Checked)
                {

                    if (gb_interval != null)
                        pnl_inner_interval.Controls.Remove(gb_interval);
                    gb_interval = CreateGBox("", rbOptionSingle_determine_interval, rbOptionMultiple_determine_interval,
                        new Label(), pnl_singleFile_interval
                       );

                    pnl_inner_interval.Controls.Add(gb_interval, 0, 3);
                    pnl_inner_interval.SetColumnSpan(gb_interval, 9);
                }
            };

            rbOptionMultiple_determine_interval.CheckedChanged += delegate
            {
                if (rbOptionMultiple_determine_interval.Checked)
                {

                    if (gb_interval != null)
                        pnl_inner_interval.Controls.Remove(gb_interval);
                    gb_interval = CreateGBox("", rbOptionSingle_determine_interval, rbOptionMultiple_determine_interval,
                       new Label(), pnl_multipleFile_interval);

                    pnl_inner_interval.Controls.Add(gb_interval, 0, 3);
                    pnl_inner_interval.SetColumnSpan(gb_interval, 9);

                }
            };


            //cb_resegment.CheckedChanged += delegate
            //{
            //    if (!cb_resegment.Checked)
            //    {
            //        pnl_multipleFile_resegment.Enabled = false;
            //        pnl_multipleFile_interval.Controls.Remove(btn_save_resegment_determine_interval_multiple);
            //        pnl_multipleFile_interval.Controls.Add(btn_save_determine_interval_multiple, 0, 11);

            //    }
            //    else
            //    {

            //        pnl_multipleFile_resegment.Enabled = true;
            //        pnl_multipleFile_interval.Controls.Remove(btn_save_determine_interval_multiple);
            //        pnl_multipleFile_interval.Controls.Add(btn_save_resegment_determine_interval_multiple, 0, 11);

            //    }

            //};


           


            rbOptionSingle_determine_interval.Checked = true;
            pnl_main_intervalAudio.Controls.Add(pnl_info_interval, 0, 0);
            pnl_main_intervalAudio.SetColumnSpan(pnl_info_interval, 9);
            pnl_main_intervalAudio.Controls.Add(pnl_inner_interval, 0, 1);
            pnl_main_intervalAudio.SetColumnSpan(pnl_inner_interval, 9);

            return pnl_main_intervalAudio;

        }
    }
}
