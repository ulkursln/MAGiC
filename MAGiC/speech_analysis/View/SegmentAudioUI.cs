using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAGiC
{
    public class SegmentAudioUI:ParentUI
    {
        public TableLayoutPanel pnl_SegmentAudio;

        public SegmentAudioUI(INavigationListener _navigationListener) : base(_navigationListener)
        {
            pnl_SegmentAudio=getLayout();
        }


        /*Segment Audio controls*/
        /**********************************************************************************************/
        public ToolTip tt_outputFolder_segment = new ToolTip();
        public ToolTip tt_wavFile_segment = new ToolTip();

        public Button btn_gotoWalkthrough_segment = new Button { Text = "Go to Walkthrough", AutoSize = true, BackColor = Color.AliceBlue, Font = new Font("Arial", 10, FontStyle.Bold) };
        public Label lbl_output_segment = new Label { Text = "Output Folder:", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public TextBox txt_outputFolder_segment = new TextBox { AutoSize = true, Width = 600 };
        public Button btn_openFolder_segment = new Button { Text = "...", AutoSize = true, BackColor = Color.AliceBlue, Width = 30, Font = new Font("Arial", 11, FontStyle.Bold) };
        public Label lbl_empty_outputFolder_segment = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };
        public FolderBrowserDialog fbd_outputFolder_segment = new FolderBrowserDialog();


        public Label lbl_wav_segment = new Label { Text = "Formatted Wav File:", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public TextBox txt_wavFile_segment = new TextBox { AutoSize = true, Width = 600 };
        public Button btn_browse_wavFile_segment = new Button { Text = "...", AutoSize = true, BackColor = Color.AliceBlue, Width = 30, Font = new Font("Arial", 11, FontStyle.Bold) };
        public Button btn_segment = new Button { Text = "Segment", AutoSize = true, BackColor = Constants.BUTTON_BACKCOLOR, ForeColor = Constants.BUTTON_FORECOLOR, Font = Constants.BUTTON_FONT };
        public Label lbl_empty_wavFile_segment = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };
        public OpenFileDialog ofd_wavFile_segment = new OpenFileDialog();

        public ErrorProvider errorProvider_segment_outputFolder = new System.Windows.Forms.ErrorProvider();
        public ErrorProvider errorProvider_segment_wavFile = new System.Windows.Forms.ErrorProvider();

        /*End of Segment Audio controls*/

        private TableLayoutPanel getLayout()
        {
            //start to design interface
            TableLayoutPanel pnl_main_segmentAudio = new TableLayoutPanel { Dock = DockStyle.Fill, AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_main_segmentAudio.Margin = new Padding(0);
            pnl_main_segmentAudio.ColumnCount = 4;
            pnl_main_segmentAudio.RowCount = 2;

            TableLayoutPanel pnl_info_segment = new TableLayoutPanel { Dock = DockStyle.Fill, AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_info_segment.Margin = new Padding(0);
            pnl_info_segment.BackColor = System.Drawing.Color.LightBlue;
            pnl_info_segment.Controls.Add(btn_gotoWalkthrough_segment);


            TableLayoutPanel pnl_inner_segment = new TableLayoutPanel { Dock = DockStyle.Fill, AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_inner_segment.Margin = new Padding(0);
            pnl_inner_segment.ColumnCount = 4;
            pnl_inner_segment.RowCount = 5;
            //p2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            //p2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            //p2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            pnl_inner_segment.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            // p2.Controls.Add(CreateHPanel(lbl_output, txt_outputFolder, btn_openFolder));
            pnl_inner_segment.Controls.Add(lbl_output_segment, 0, 2);
            pnl_inner_segment.Controls.Add(txt_outputFolder_segment, 1, 2);
            tt_outputFolder_segment.SetToolTip(txt_outputFolder_segment, Constants.TOOLTIP_OUTPUTFOLDER_FILE);
            pnl_inner_segment.Controls.Add(lbl_empty_outputFolder_segment, 2, 2);
            pnl_inner_segment.Controls.Add(btn_openFolder_segment, 3, 2);


            pnl_inner_segment.Controls.Add(lbl_wav_segment, 0, 3);
            pnl_inner_segment.Controls.Add(txt_wavFile_segment, 1, 3);
            tt_wavFile_segment.SetToolTip(txt_wavFile_segment, Constants.TOOLTIP_AUDIOFILE);
            pnl_inner_segment.Controls.Add(lbl_empty_wavFile_segment, 2, 3);
            pnl_inner_segment.Controls.Add(btn_browse_wavFile_segment, 3, 3);
            pnl_inner_segment.Controls.Add(btn_segment, 1, 4);

            pnl_main_segmentAudio.Controls.Add(pnl_info_segment, 0, 0);
            pnl_main_segmentAudio.SetColumnSpan(pnl_info_segment, 5);
            pnl_main_segmentAudio.Controls.Add(pnl_inner_segment, 0, 1);
            pnl_main_segmentAudio.SetColumnSpan(pnl_inner_segment, 5);

            return pnl_main_segmentAudio;
            
        }
    }
}
