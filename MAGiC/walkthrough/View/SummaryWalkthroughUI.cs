using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAGiC
{
    public class SummaryWalkthroughUI : ParentUI
    {
        public SummaryWalkthroughBE swBe;


        public SummaryWalkthroughUI(INavigationListener _navigationListener) : base(_navigationListener) { }

        public void initializeController()
        {
            swBe = new SummaryWalkthroughBE(this);
        }

        public Label lbl_infotext_summary = new Label
        {
            Text = Info.TEXT_INFO,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_INFOTEXT

        };

        public Label lbl_stepstext_summary = new Label
        {
            Text = Info.TEXT_STEPS,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPSTEXT

        };

        public Label lbl_info_summary = new Label
        {
            Text = Info.INFO_SUMMARY,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_INFO

        };

        public Label lbl_steps_1_summary = new Label
        {
            Text = Info.STEPS_OUTPUTFILE_SUMMARY,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_steps_2_summary = new Label
        {
            Text = Info.STEPS_SPEECH_ANNOTATION_SUMMARY,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_steps_3_summary = new Label
        {
            Text = Info.STEPS_SINGLEOTPAIR_SUMMARY,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_steps_4_summary = new Label
        {
            Text = Info.STEPS_AOIFILE_SUMMARY,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_steps_5_summary = new Label
        {
            Text = Info.STEPS_EXPINTERVALFILE_SUMMARY,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_steps_6_summary = new Label
        {
            Text = Info.STEPS_PARTICIPANTID_SUMMARY,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_steps_7_summary = new Label
        {
            Text = Info.STEPS_EYETRACKERFREQUENCY_SUMMARY,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_steps_8_summary = new Label
        {
            Text = Info.STEPS_SAVEBUTTON_SUMMARY,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_outputstext_summary = new Label
        {
            Text = Info.TEXT_OUTPUT,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_OUTPUTTEXT

        };

        public Label lbl_outputs_summary = new Label
        {
            Text = Info.OUTPUT_SUMMARY,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_OUTPUT

        };

        public Label lbl_sample_outputfile_summary = new LinkLabel
        {
            Text = Info.SAMPLE_OUTPUTFILE_SUMMARY,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };

        public LinkLabel linklbl_sample_speech_annotation_summary = new LinkLabel
        {
            Text = Info.SAMPLE_SPEECH_ANNOTATION_SUMMARY,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };
        public LinkLabel linklbl_sample_aoifile_summary = new LinkLabel
        {
            Text = Info.SAMPLE_AOIFILE_SUMMARY,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };
        public LinkLabel linklbl_sample_expintervalfile_summary = new LinkLabel
        {
            Text = Info.SAMPLE_EXPINTERVALFILE_SUMMARY,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };

        public Label lbl_sample_participantid_summary = new LinkLabel
        {
            Text = Info.SAMPLE_PARTICIPANTID_SUMMARY,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };

        public Label lbl_sample_eyetrackerfrequency_summary = new LinkLabel
        {
            Text = Info.SAMPLE_EYETRACKERFREQUENCY_SUMMARY,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };

        public LinkLabel linklbl_sample_output_summary = new LinkLabel
        {
            Text = Info.SAMPLE_OUTPUT_SUMMARY,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };

        public Button btn_gotoFunction_home_summary = new Button { Text = Info.TEXT_BUTTON_GOTOHOME, AutoSize = true, BackColor = Color.AliceBlue, Font = new Font("Arial", 10, FontStyle.Bold) };
        public Button btn_gotoFunction_summary = new Button { Text = Info.TEXT_BUTTON_GOTOFUNCTION, AutoSize = true, BackColor = Color.AliceBlue, Font = new Font("Arial", 10, FontStyle.Bold) };

        public TableLayoutPanel getLayout()
        {
            TableLayoutPanel pnl_main_summary = new TableLayoutPanel { Dock = DockStyle.Fill, AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink, AutoScroll = true };
            pnl_main_summary.Margin = new Padding(0);
            pnl_main_summary.ColumnCount = 2;
            pnl_main_summary.RowCount = 2;

            TableLayoutPanel pnl_info = new TableLayoutPanel { Dock = DockStyle.Fill, Size = new Size(800, 800), AutoSizeMode = AutoSizeMode.GrowAndShrink, AutoScroll = true };
            pnl_info.Margin = new Padding(0);
            pnl_info.ColumnCount = 2;
            pnl_info.RowCount = 9;
            pnl_info.BackColor = System.Drawing.Color.LightBlue;
            pnl_info.Controls.Add(lbl_infotext_summary, 0, 0);
            pnl_info.Controls.Add(lbl_info_summary, 0, 1);
            pnl_info.SetColumnSpan(lbl_info_summary, 2);
            pnl_info.Controls.Add(lbl_stepstext_summary, 0, 2);

            TableLayoutPanel pnl_steps_1 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_1.Margin = new Padding(0);
            pnl_steps_1.ColumnCount = 2;
            pnl_steps_1.RowCount = 1;
            pnl_steps_1.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_1.Controls.Add(lbl_steps_1_summary, 0, 0);
            pnl_steps_1.Controls.Add(lbl_sample_outputfile_summary, 1, 0);
            pnl_info.Controls.Add(pnl_steps_1, 0, 3);
            pnl_info.SetColumnSpan(pnl_steps_1, 2);


            TableLayoutPanel pnl_steps_2 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_2.Margin = new Padding(0);
            pnl_steps_2.ColumnCount = 2;
            pnl_steps_2.RowCount = 1;
            pnl_steps_2.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_2.Controls.Add(lbl_steps_2_summary, 0, 0);
            pnl_steps_2.Controls.Add(linklbl_sample_speech_annotation_summary, 1, 0);
            linklbl_sample_speech_annotation_summary.Links.Clear();
            linklbl_sample_speech_annotation_summary.Links.Add(new LinkLabel.Link(0, 50, Info.LINK_SPEECH_ANNOTATION));
            this.linklbl_sample_speech_annotation_summary.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_LinkClicked);
            pnl_info.Controls.Add(pnl_steps_2, 0, 4);
            pnl_info.SetColumnSpan(pnl_steps_2, 2);


            TableLayoutPanel pnl_steps_3 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_3.Margin = new Padding(0);
            pnl_steps_3.ColumnCount = 2;
            pnl_steps_3.RowCount = 1;
            pnl_steps_3.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_3.Controls.Add(lbl_steps_3_summary, 0, 0);
            pnl_info.Controls.Add(pnl_steps_3, 0, 5);
            pnl_info.SetColumnSpan(pnl_steps_3, 2);

            TableLayoutPanel pnl_steps_4 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_4.Margin = new Padding(0);
            pnl_steps_4.ColumnCount = 2;
            pnl_steps_4.RowCount = 1;
            pnl_steps_4.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_4.Controls.Add(lbl_steps_4_summary, 0, 0);
            pnl_steps_4.Controls.Add(linklbl_sample_aoifile_summary, 1, 0);
            linklbl_sample_aoifile_summary.Links.Clear();
            linklbl_sample_aoifile_summary.Links.Add(new LinkLabel.Link(0, 50, Info.LINK_AOI_FILE));
            this.linklbl_sample_aoifile_summary.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_LinkClicked);
            pnl_info.Controls.Add(pnl_steps_4, 0, 6);
            pnl_info.SetColumnSpan(pnl_steps_4, 2);

            TableLayoutPanel pnl_steps_5 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_5.Margin = new Padding(0);
            pnl_steps_5.ColumnCount = 2;
            pnl_steps_5.RowCount = 1;
            pnl_steps_5.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_5.Controls.Add(lbl_steps_5_summary, 0, 0);
            pnl_steps_5.Controls.Add(linklbl_sample_expintervalfile_summary, 1, 0);
            linklbl_sample_expintervalfile_summary.Links.Clear();
            linklbl_sample_expintervalfile_summary.Links.Add(new LinkLabel.Link(0, 50, Info.LINK_EXP_INTERVAL));
            this.linklbl_sample_expintervalfile_summary.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_LinkClicked);
            pnl_info.Controls.Add(pnl_steps_5, 0, 7);
            pnl_info.SetColumnSpan(pnl_steps_5, 2);

            TableLayoutPanel pnl_steps_6 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_6.Margin = new Padding(0);
            pnl_steps_6.ColumnCount = 2;
            pnl_steps_6.RowCount = 1;
            pnl_steps_6.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_6.Controls.Add(lbl_steps_6_summary, 0, 0);
            pnl_steps_6.Controls.Add(lbl_sample_participantid_summary, 1, 0);
            pnl_info.Controls.Add(pnl_steps_6, 0, 8);
            pnl_info.SetColumnSpan(pnl_steps_6, 2);

            TableLayoutPanel pnl_steps_7 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_7.Margin = new Padding(0);
            pnl_steps_7.ColumnCount = 2;
            pnl_steps_7.RowCount = 1;
            pnl_steps_7.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_7.Controls.Add(lbl_steps_7_summary, 0, 0);
            pnl_steps_7.Controls.Add(lbl_sample_eyetrackerfrequency_summary, 1, 0);
            pnl_info.Controls.Add(pnl_steps_7, 0, 9);
            pnl_info.SetColumnSpan(pnl_steps_7, 2);

            TableLayoutPanel pnl_steps_8 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_8.Margin = new Padding(0);
            pnl_steps_8.ColumnCount = 2;
            pnl_steps_8.RowCount = 1;
            pnl_steps_8.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_8.Controls.Add(lbl_steps_8_summary, 0, 0);
            pnl_info.Controls.Add(pnl_steps_8, 0, 10);
            pnl_info.SetColumnSpan(pnl_steps_8, 2);

            pnl_info.Controls.Add(lbl_outputstext_summary, 0, 11);

            TableLayoutPanel pnl_output = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_output.Margin = new Padding(0);
            pnl_output.ColumnCount = 2;
            pnl_output.RowCount = 1;
            pnl_output.BackColor = System.Drawing.Color.LightBlue;
            pnl_output.Controls.Add(lbl_outputs_summary, 0, 0);
            pnl_output.Controls.Add(linklbl_sample_output_summary, 1, 0);
            linklbl_sample_output_summary.Links.Clear();
            linklbl_sample_output_summary.Links.Add(new LinkLabel.Link(0, 50, Info.LINK_SUMMARY_FILE));
            this.linklbl_sample_output_summary.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_LinkClicked);
            pnl_info.Controls.Add(pnl_output, 0, 12);
            pnl_info.SetColumnSpan(pnl_output, 2);


            pnl_main_summary.Controls.Add(pnl_info, 0, 0);
            pnl_main_summary.SetColumnSpan(pnl_info, 2);
            pnl_main_summary.Controls.Add(btn_gotoFunction_summary, 1, 1);
            pnl_main_summary.Controls.Add(btn_gotoFunction_home_summary, 0, 1);

            return pnl_main_summary;
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
