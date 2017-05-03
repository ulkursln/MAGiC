using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAGiC
{
    public class SummaryUI : ParentUI
    {
        public TableLayoutPanel pnl_summary;

        public SummaryUI(INavigationListener _navigationListener) : base(_navigationListener)
        {
            pnl_summary = getLayout();
        }

        /* Summary controls*/
        /**********************************************************************************************/
        public ToolTip tt_output_folder_summary = new ToolTip();
        public ToolTip tt_speechAnnotation_file_summary = new ToolTip();
        

        public Button btn_gotoWalkthrough_summary = new Button { Text = "Go to Walkthrough", AutoSize = true, BackColor = Color.AliceBlue, Font = new Font("Arial", 10, FontStyle.Bold) };
 

        //public Label lbl_output_file_summary = new Label { Text = "Output File:", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        //public TextBox txt_outputFile_summary = new TextBox { AutoSize = true, Width = 600 };
        //public Button btn_createFileOutput_summary = new Button { Text = "Create", AutoSize = true, BackColor = Color.AliceBlue, Font = new Font("Arial", 10, FontStyle.Bold) };
        //public SaveFileDialog sfd_outputFile_summary_create = new SaveFileDialog();

        public Label lbl_output_folder_summary = new Label { Text = "Output Folder:", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public TextBox txt_output_folder_summary = new TextBox { AutoSize = true, Width = 600 };
        public Button btn_output_folder_summary = new Button { Text = "...", AutoSize = true, BackColor = Color.AliceBlue, Width = 30, Font = new Font("Arial", 10, FontStyle.Bold) };
        public FolderBrowserDialog fbd_output_folder_summary = new FolderBrowserDialog();
        public Label lbl_empty_txt_output_folder_summary = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };


        public Label lbl_speechAnnotation_summary = new Label { Text = "Speech Annotation File:", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public TextBox txt_speechAnnotation_summary = new TextBox { AutoSize = true, Width = 600 };
        public Button btn_openFileSpeechAnnotation_summary = new Button { Text = "...", AutoSize = true, BackColor = Color.AliceBlue, Width = 30, Font = new Font("Arial", 11, FontStyle.Bold) };
        public OpenFileDialog ofd_openFileSpeechAnnotation_summary = new OpenFileDialog();

        public RadioButton rbOptionSingle_summary = new RadioButton { Text = "Single Participant", AutoSize = true, TabStop = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public RadioButton rbOptionPair_summary = new RadioButton { Text = "Pair", AutoSize = true, TabStop = true, Font = new Font("Arial", 11, FontStyle.Bold) };

        public TableLayoutPanel pnl_single_summary, pnl_multiple_summary;

        public ErrorProvider errorProvider_outputFolder_summary = new System.Windows.Forms.ErrorProvider();
        public ErrorProvider errorProvider_speechAnnotation_file_summary = new System.Windows.Forms.ErrorProvider();
        
        public Label lbl_empty_outputfolder_summary = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };
        public Label lbl_empty_speechAnnotationfile_summary = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };

        //Single
        public ToolTip tt_AOI_file_summary_single = new ToolTip();
        public ToolTip tt_expInterval_summary_single = new ToolTip();
        public ToolTip tt_eyetrackerFrequency_single = new ToolTip();
        public ToolTip tt_participantID_single = new ToolTip();

        public Label lbl_AOI_file_summary_single = new Label { Text = "AOIs File:", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public TextBox txt_AOI_file_summary_single = new TextBox { AutoSize = true, Width = 600 };
        public Button btn_openFileAOI_single_summary = new Button { Text = "...", AutoSize = true, BackColor = Color.AliceBlue, Width = 30, Font = new Font("Arial", 11, FontStyle.Bold) };
        public OpenFileDialog ofd_openFileAOI_single_summary = new OpenFileDialog();

        public Label lbl_ExpInterval_file_summary_single = new Label { Text = "Experiment Interval File:", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public TextBox txt_ExpInterval_file_summary_single = new TextBox { AutoSize = true, Width = 600 };
        public Button btn_openExpInterval_single_summary = new Button { Text = "...", AutoSize = true, BackColor = Color.AliceBlue, Width = 30, Font = new Font("Arial", 11, FontStyle.Bold) };
        public OpenFileDialog ofd_openFileExpInterval_single_summary = new OpenFileDialog();

        public Label lbl_ExpIntervalParticipantNo_summary_single = new Label { Text = "Participant Id:", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public TextBox txt_ExpIntervalParticipantNo_summary_single = new TextBox { AutoSize = true, Width = 100 };
        public Label lbl_empty_ExpIntervalParticipantNo_summary_single = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };

        public Label lbl_ExpIntervalFrequency_summary_single = new Label { Text = "Eye Tracker Frequency:", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public TextBox txt_ExpIntervalFrequency_summary_single = new TextBox { AutoSize = true, Width = 100 };
        public Label lbl_empty_ExpIntervalFrequency_summary_single = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };
        public Label lbl_ExpIntervalFrequencyHz_summary_single = new Label { Text = "  ", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };

    
        public Button btn_save_summary_single = new Button { Text = "Save", AutoSize = true, BackColor = Color.AliceBlue, ForeColor = Color.DodgerBlue, Font = new Font("Arial", 10, FontStyle.Bold) };
        
        public ErrorProvider errorProvider_AOI_file_summary_single = new System.Windows.Forms.ErrorProvider();
        public ErrorProvider errorProvider_expInterval_summary_single = new System.Windows.Forms.ErrorProvider();
        public ErrorProvider errorProvider_eyetrackerFrequency_single = new System.Windows.Forms.ErrorProvider();
        public ErrorProvider errorProvider_participantID_single= new System.Windows.Forms.ErrorProvider();

        public Label lbl_empty_AOIfile_summary_single = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };
        public Label lbl_empty_expInterval_summary_single = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };
        public Label lbl_empty_eyetrackerFrequency_single = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };
        public Label lbl_empty_participantID_single = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };


        //Multiple
        public ToolTip tt_AOI_file_summary_first_pair = new ToolTip();
        public ToolTip tt_AOI_file_summary_second_pair = new ToolTip();
        public ToolTip tt_expInterval_summary_pair = new ToolTip();
        public ToolTip tt_eyetrackerFrequency_pair = new ToolTip();
        public ToolTip tt_participantID_pair = new ToolTip();
        public ToolTip tt_rbOptionFirstParticipant_summary_pair = new ToolTip();
        public ToolTip tt_rbOptionSecondParticipant_summary_pair = new ToolTip();

        public Label lbl_AOI_file_summary_first_pair = new Label { Text = "AOIs File (First Participant):", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public TextBox txt_AOI_file_summary_first_pair = new TextBox { AutoSize = true, Width = 600 };
        public Button btn_openFileAOI_summary_first_pair = new Button { Text = "...", AutoSize = true, BackColor = Color.AliceBlue, Width = 30, Font = new Font("Arial", 11, FontStyle.Bold) };
        public OpenFileDialog ofd_openFileAOI_summary_first_pair = new OpenFileDialog();

        public Label lbl_AOI_file_summary_second_pair = new Label { Text = "AOIs File (Second Participant):", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public TextBox txt_AOI_file_summary_second_pair = new TextBox { AutoSize = true, Width = 600 };
        public Button btn_openFileAOI_summary_second_pair = new Button { Text = "...", AutoSize = true, BackColor = Color.AliceBlue, Width = 30, Font = new Font("Arial", 11, FontStyle.Bold) };
        public OpenFileDialog ofd_openFileAOI_summary_second_pair = new OpenFileDialog();

        public Label lbl_ExpInterval_file_summary_pair = new Label { Text = "Experiment Interval File:", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public TextBox txt_ExpInterval_file_summary_pair = new TextBox { AutoSize = true, Width = 600 };
        public Button btn_openExpInterval_pair_summary = new Button { Text = "...", AutoSize = true, BackColor = Color.AliceBlue, Width = 30, Font = new Font("Arial", 11, FontStyle.Bold) };
        public OpenFileDialog ofd_openFileExpInterval_pair_summary = new OpenFileDialog();

        public Label lbl_ExpIntervalParticipantNo_summary_pair = new Label { Text = "Pair Id:", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public TextBox txt_ExpIntervalParticipantNo_summary_pair = new TextBox { AutoSize = true, Width = 100 };
        public Label lbl_empty_ExpIntervalParticipantNo_summary_pair = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };

        public Label lbl_ExpIntervalFrequency_summary_pair = new Label { Text = "Eye Tracker Frequency:", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public TextBox txt_ExpIntervalFrequency_summary_pair = new TextBox { AutoSize = true, Width = 100 };
        public Label lbl_empty_ExpIntervalFrequency_summary_pair = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };
        public Label lbl_ExpIntervalFrequencyHz_summary_pair = new Label { Text = " ", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };

        public RadioButton rbOptionFirstParticipant_summary_pair = new RadioButton { Text = "First Participant", AutoSize = true, TabStop = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public RadioButton rbOptionSecondParticipant_summary_pair = new RadioButton { Text = "Second Participant", AutoSize = true, TabStop = true, Font = new Font("Arial", 11, FontStyle.Bold) };

        public Button btn_save_summary_pair = new Button { Text = "Save", AutoSize = true, BackColor = Color.AliceBlue, ForeColor = Color.DodgerBlue, Font = new Font("Arial", 10, FontStyle.Bold) };

        public ErrorProvider errorProvider_AOI_file_summary_first_pair = new System.Windows.Forms.ErrorProvider();
        public ErrorProvider errorProvider_AOI_file_summary_second_pair = new System.Windows.Forms.ErrorProvider();
        public ErrorProvider errorProvider_expInterval_summary_pair = new System.Windows.Forms.ErrorProvider();
        public ErrorProvider errorProvider_eyetrackerFrequency_pair = new System.Windows.Forms.ErrorProvider();
        public ErrorProvider errorProvider_participantID_pair = new System.Windows.Forms.ErrorProvider();

        public Label lbl_empty_AOIfile_summary_first_pair = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };
        public Label lbl_empty_AOIfile_summary_second_pair = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };
        public Label lbl_empty_expInterval_summary_pair = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };
        public Label lbl_empty_eyetrackerFrequency_pair = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };
        public Label lbl_empty_participantID_pair = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };



        public TableLayoutPanel getLayout()
        {
            //start to design interface
            TableLayoutPanel pnl_main_summary = new TableLayoutPanel { Dock = DockStyle.Fill, AutoSize = true, BackColor=Color.WhiteSmoke, AutoSizeMode = AutoSizeMode.GrowAndShrink , Height = 800 };
            pnl_main_summary.Margin = new Padding(0);
            pnl_main_summary.ColumnCount = 4;
            pnl_main_summary.RowCount = 3;

            TableLayoutPanel pnl_info_summary = new TableLayoutPanel { Dock = DockStyle.Fill, AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_info_summary.Margin = new Padding(0);
            pnl_info_summary.BackColor = System.Drawing.Color.LightBlue;
            pnl_info_summary.Controls.Add(btn_gotoWalkthrough_summary);

            TableLayoutPanel pnl_inner_summary = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 800 };
            pnl_inner_summary.Margin = new Padding(0);
            pnl_inner_summary.ColumnCount = 4;
            pnl_inner_summary.RowCount = 8;

            pnl_inner_summary.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));

            pnl_inner_summary.Controls.Add(lbl_output_folder_summary, 0, 2);
            pnl_inner_summary.Controls.Add(txt_output_folder_summary, 1, 2);
            tt_output_folder_summary.SetToolTip(txt_output_folder_summary, Constants.TOOLTIP_OUTPUTFOLDER_FILE);
            pnl_inner_summary.Controls.Add(lbl_empty_outputfolder_summary, 2, 2);
            pnl_inner_summary.Controls.Add(btn_output_folder_summary, 3, 2);
            

            pnl_inner_summary.Controls.Add(lbl_speechAnnotation_summary, 0, 3);
            pnl_inner_summary.Controls.Add(txt_speechAnnotation_summary, 1, 3);
            pnl_inner_summary.Controls.Add(lbl_empty_speechAnnotationfile_summary, 2, 3);
            pnl_inner_summary.Controls.Add(btn_openFileSpeechAnnotation_summary, 3, 3);
            tt_speechAnnotation_file_summary.SetToolTip(txt_speechAnnotation_summary, Constants.TOOLTIP_SPEECHANNOTATION_FILE);

            pnl_single_summary = new TableLayoutPanel { Dock = DockStyle.Fill, AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink};
            pnl_single_summary.Margin = new Padding(0);
            pnl_single_summary.ColumnCount = 4;
            pnl_single_summary.RowCount = 5;

            pnl_single_summary.Controls.Add(lbl_AOI_file_summary_single, 0, 0);
            pnl_single_summary.Controls.Add(txt_AOI_file_summary_single, 1, 0);
            pnl_single_summary.Controls.Add(lbl_empty_AOIfile_summary_single, 2, 0);
            pnl_single_summary.Controls.Add(btn_openFileAOI_single_summary, 3, 0);
            tt_AOI_file_summary_single.SetToolTip(txt_AOI_file_summary_single, Constants.TOOLTIP_AOI_FILE);

            pnl_single_summary.Controls.Add(lbl_ExpInterval_file_summary_single, 0, 1);
            pnl_single_summary.Controls.Add(txt_ExpInterval_file_summary_single, 1, 1);
            pnl_single_summary.Controls.Add(lbl_empty_expInterval_summary_single, 2, 1);
            pnl_single_summary.Controls.Add(btn_openExpInterval_single_summary, 3, 1);
            tt_expInterval_summary_single.SetToolTip(txt_ExpInterval_file_summary_single, Constants.TOOLTIP_EXPINTERVAL_FILE);


            pnl_single_summary.Controls.Add(lbl_ExpIntervalParticipantNo_summary_single, 0, 2);
            pnl_single_summary.Controls.Add(txt_ExpIntervalParticipantNo_summary_single, 1, 2);
            tt_participantID_single.SetToolTip(txt_ExpIntervalParticipantNo_summary_single, Constants.TOOLTIP_PARTICIPANTID);
            pnl_single_summary.Controls.Add(lbl_empty_ExpIntervalParticipantNo_summary_single, 2, 2);


            pnl_single_summary.Controls.Add(lbl_ExpIntervalFrequency_summary_single, 0, 3);
            pnl_single_summary.Controls.Add(txt_ExpIntervalFrequency_summary_single, 1, 3);
            tt_eyetrackerFrequency_single.SetToolTip(txt_ExpIntervalFrequency_summary_single, Constants.TOOLTIP_ENTER_POSITIVE_INTEGER_VALUE);
            pnl_single_summary.Controls.Add(lbl_ExpIntervalFrequencyHz_summary_single, 2, 3);

            pnl_single_summary.Controls.Add(btn_save_summary_single, 0, 4);


            pnl_multiple_summary = new TableLayoutPanel { Dock = DockStyle.Fill, AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_multiple_summary.Margin = new Padding(0);
            pnl_multiple_summary.ColumnCount = 4;
            pnl_multiple_summary.RowCount = 5;

            pnl_multiple_summary.Controls.Add(lbl_AOI_file_summary_first_pair, 0, 0);
            pnl_multiple_summary.Controls.Add(txt_AOI_file_summary_first_pair, 1, 0);
            pnl_multiple_summary.Controls.Add(lbl_empty_AOIfile_summary_first_pair, 2, 0);
            pnl_multiple_summary.Controls.Add(btn_openFileAOI_summary_first_pair, 3, 0);
            tt_AOI_file_summary_first_pair.SetToolTip(txt_AOI_file_summary_first_pair, Constants.TOOLTIP_AOI_FILE);

            pnl_multiple_summary.Controls.Add(lbl_AOI_file_summary_second_pair, 0, 1);
            pnl_multiple_summary.Controls.Add(txt_AOI_file_summary_second_pair, 1, 1);
            pnl_multiple_summary.Controls.Add(lbl_empty_AOIfile_summary_second_pair, 2, 1);
            pnl_multiple_summary.Controls.Add(btn_openFileAOI_summary_second_pair, 3, 1);
            tt_AOI_file_summary_second_pair.SetToolTip(txt_AOI_file_summary_second_pair, Constants.TOOLTIP_AOI_FILE);

            pnl_multiple_summary.Controls.Add(lbl_ExpInterval_file_summary_pair, 0, 2);
            pnl_multiple_summary.Controls.Add(txt_ExpInterval_file_summary_pair, 1, 2);
            pnl_multiple_summary.Controls.Add(lbl_empty_expInterval_summary_pair, 2, 2);
            pnl_multiple_summary.Controls.Add(btn_openExpInterval_pair_summary, 3, 2);
            tt_expInterval_summary_pair.SetToolTip(txt_ExpInterval_file_summary_pair, Constants.TOOLTIP_EXPINTERVAL_FILE);


            pnl_multiple_summary.Controls.Add(lbl_ExpIntervalParticipantNo_summary_pair, 0, 3);
            pnl_multiple_summary.Controls.Add(txt_ExpIntervalParticipantNo_summary_pair, 1, 3);
            tt_participantID_pair.SetToolTip(txt_ExpIntervalParticipantNo_summary_pair, Constants.TOOLTIP_PARTICIPANTID);
            pnl_multiple_summary.Controls.Add(lbl_empty_ExpIntervalParticipantNo_summary_pair, 2, 3);


            pnl_multiple_summary.Controls.Add(lbl_ExpIntervalFrequency_summary_pair, 0, 4);
            pnl_multiple_summary.Controls.Add(txt_ExpIntervalFrequency_summary_pair, 1, 4);
            tt_eyetrackerFrequency_pair.SetToolTip(txt_ExpIntervalFrequency_summary_pair, Constants.TOOLTIP_ENTER_POSITIVE_INTEGER_VALUE);
            pnl_multiple_summary.Controls.Add(lbl_ExpIntervalFrequencyHz_summary_pair, 2, 4);

            TableLayoutPanel pnl_radioButtons = new TableLayoutPanel { Dock = DockStyle.Fill, AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_radioButtons.Margin = new Padding(0);
            pnl_radioButtons.ColumnCount = 3;
            pnl_radioButtons.RowCount = 1;
            pnl_radioButtons.Controls.Add(rbOptionFirstParticipant_summary_pair, 0, 0);
            tt_rbOptionFirstParticipant_summary_pair.SetToolTip(rbOptionFirstParticipant_summary_pair, Constants.TOOLTIP_WHICHPARTICIPANT_INEXPINTERVALFILE);
            pnl_radioButtons.Controls.Add(rbOptionSecondParticipant_summary_pair, 1, 0);
            tt_rbOptionSecondParticipant_summary_pair.SetToolTip(rbOptionSecondParticipant_summary_pair, Constants.TOOLTIP_WHICHPARTICIPANT_INEXPINTERVALFILE);

            //pnl_multiple_summary.Controls.Add(pnl_radioButtons, 0, 5);
            //pnl_multiple_summary.SetColumnSpan(pnl_radioButtons, 4);

            pnl_multiple_summary.Controls.Add(btn_save_summary_pair, 0, 6);

                  

            errorProvider_AOI_file_summary_first_pair.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider_AOI_file_summary_second_pair.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider_AOI_file_summary_single.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider_expInterval_summary_pair.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider_expInterval_summary_single.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider_eyetrackerFrequency_pair.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider_eyetrackerFrequency_single.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider_outputFolder_summary.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider_participantID_pair.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider_speechAnnotation_file_summary.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            
            GroupBox gb_inner_controls = null;


            rbOptionSingle_summary.CheckedChanged += delegate
            {
                if (rbOptionSingle_summary.Checked)
                {

                    if (gb_inner_controls != null)
                        pnl_inner_summary.Controls.Remove(gb_inner_controls);
                    gb_inner_controls = CreateGBox("", rbOptionSingle_summary, rbOptionPair_summary,
                        new Label(), pnl_single_summary
                       );

                    pnl_inner_summary.Controls.Add(gb_inner_controls, 0, 4);
                    pnl_inner_summary.SetColumnSpan(gb_inner_controls, 4);
                   
                }
            };

            rbOptionPair_summary.CheckedChanged += delegate
            {
                if (rbOptionPair_summary.Checked)
                {

                    if (gb_inner_controls != null)
                        pnl_inner_summary.Controls.Remove(gb_inner_controls);
                    gb_inner_controls = CreateGBox("", rbOptionSingle_summary, rbOptionPair_summary,
                       new Label(), pnl_multiple_summary);

                    pnl_inner_summary.Controls.Add(gb_inner_controls, 0, 4);
                    pnl_inner_summary.SetColumnSpan(gb_inner_controls, 4);

                }
            };




           rbOptionSingle_summary.Checked = true;

            if (gb_inner_controls != null)
                pnl_inner_summary.Controls.Remove(gb_inner_controls);
            gb_inner_controls = CreateGBox("", rbOptionSingle_summary, rbOptionPair_summary,
                new Label(), pnl_single_summary
               );

            pnl_inner_summary.Controls.Add(gb_inner_controls, 0, 4);
            pnl_inner_summary.SetColumnSpan(gb_inner_controls, 4);

            pnl_main_summary.Controls.Add(pnl_info_summary, 0, 0);
            pnl_main_summary.SetColumnSpan(pnl_info_summary, 4);
            pnl_main_summary.Controls.Add(pnl_inner_summary, 0, 1);
            pnl_main_summary.SetColumnSpan(pnl_inner_summary, 4);

            return pnl_main_summary;

        }
    }
}

