using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAGiC
{
    public class ExtractAndFormatAudioUI : ParentUI
    {
        public TableLayoutPanel pnl_extractAndFormatAudio;

        public ExtractAndFormatAudioUI(INavigationListener _navigationListener) : base(_navigationListener)
        {
            pnl_extractAndFormatAudio=getLayout();
        }


        /*Extract and Format Audio controls*/
        /**********************************************************************************************/
        public ToolTip tt_outputFolder_extractFormat = new ToolTip();
        public ToolTip tt_aviFile_extractFormat = new ToolTip();


        public Button btn_gotoWalkthrough_extractFormat = new Button { Text = "Go to Walkthrough", AutoSize = true, BackColor = Color.AliceBlue, Font = new Font("Arial", 10, FontStyle.Bold) };
        public Label lbl_output_extractFormat = new Label { Text = "Output Folder:", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public TextBox txt_outputFolder_extractFormat = new TextBox { AutoSize = true, Width = 600 };
        public Button btn_openFolder_extractFormat = new Button {Text = "...", AutoSize = true,  BackColor = Color.AliceBlue, Width = 30, Font = new Font("Arial", 10, FontStyle.Bold) };
        public Label lbl_empty_outputFolder_extractFormat = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };
        public FolderBrowserDialog fbd_outputFolder_extractFormat = new FolderBrowserDialog();
        
        // radio buttons TabStop is false by default... weird.
        //public RadioButton rbOption1 = new RadioButton { Text = "Single File", AutoSize = true, TabStop = true, Font = new Font("Arial", 11, FontStyle.Bold) };

        //public RadioButton rbOption2 = new RadioButton { Text = "Multiple Files", AutoSize = true, TabStop = true, Font = new Font("Arial", 11, FontStyle.Bold) };

        public Label lbl_avi_extractFormat = new Label { Text = "Avi File:", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        public TextBox txt_aviFile_extractFormat = new TextBox { AutoSize = true, Width = 600 };
        public Button btn_browseSingleFile_extractFormat = new Button { Text = "...", AutoSize = true, BackColor = Color.AliceBlue, Width=30, Font = new Font("Arial", 10, FontStyle.Bold) };
        public Button btn_convertSingleFile_extractFormat = new Button { Text = "Convert", AutoSize = true, BackColor = Constants.BUTTON_BACKCOLOR, ForeColor = Constants.BUTTON_FORECOLOR, Font = Constants.BUTTON_FONT };
        public Label lbl_empty_singleFile_extractFormat = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };
        public OpenFileDialog ofd_aviFile_extractFormat = new OpenFileDialog();

        //public Label lbl_aviFolder = new Label { Text = "Avi Folder:", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) };
        //public TextBox txt_aviFolder = new TextBox { AutoSize = true, Width = 900 };
        //public Button btn_browseMultipleFiles = new Button { Text = "...", AutoSize = true, BackColor = Color.AliceBlue };
        //public Button btn_convertMultipleFiles = new Button { Text = "Convert", AutoSize = true, BackColor = Color.AliceBlue };
        //public Label lbl_empty_MultipleFiles = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };
        //public FolderBrowserDialog fbd_aviFiles = new FolderBrowserDialog();

        //public TableLayoutPanel pnl_singleFile, pnl_multipleFile;

        public ErrorProvider errorProvider_outputFolder_extractFormat = new System.Windows.Forms.ErrorProvider();
        public ErrorProvider errorProvider_aviFile_extractFormat = new System.Windows.Forms.ErrorProvider();
        public ErrorProvider errorProvider_aviFolder_extractFormat = new System.Windows.Forms.ErrorProvider();
      
        /*End of Extract and Format Audio controls*/

   

        private TableLayoutPanel getLayout()
        {
            //start to design interface 
            TableLayoutPanel pnl_main_formatAudio = new TableLayoutPanel { Dock = DockStyle.Fill, AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_main_formatAudio.Margin = new Padding(0);
            pnl_main_formatAudio.ColumnCount = 4;
            pnl_main_formatAudio.RowCount = 2;

            TableLayoutPanel pnl_info = new TableLayoutPanel { Dock = DockStyle.Fill, AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_info.Margin = new Padding(0);
            pnl_info.BackColor = System.Drawing.Color.LightBlue;
            pnl_info.Controls.Add(btn_gotoWalkthrough_extractFormat);

            TableLayoutPanel pnl_inner = new TableLayoutPanel { Dock = DockStyle.Fill, AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_inner.Margin = new Padding(0);
            pnl_inner.ColumnCount = 4;
            pnl_inner.RowCount = 5;
            pnl_inner.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));

            pnl_inner.Controls.Add(lbl_output_extractFormat, 0, 2);
            pnl_inner.Controls.Add(txt_outputFolder_extractFormat, 1, 2);
            tt_outputFolder_extractFormat.SetToolTip(txt_outputFolder_extractFormat, Constants.TOOLTIP_OUTPUTFOLDER_FILE);
            pnl_inner.Controls.Add(lbl_empty_outputFolder_extractFormat, 2, 2);
            pnl_inner.Controls.Add(btn_openFolder_extractFormat, 3, 2);


            pnl_inner.Controls.Add(lbl_avi_extractFormat, 0, 3);
            pnl_inner.Controls.Add(txt_aviFile_extractFormat, 1, 3);
            tt_aviFile_extractFormat.SetToolTip(txt_aviFile_extractFormat, Constants.TOOLTIP_VIDEORECORDING);
            pnl_inner.Controls.Add(lbl_empty_singleFile_extractFormat, 2, 3);
            pnl_inner.Controls.Add(btn_browseSingleFile_extractFormat, 3, 3);

            pnl_inner.Controls.Add(btn_convertSingleFile_extractFormat, 1, 4);

            //pnl_singleFile = new TableLayoutPanel { Dock = DockStyle.Fill, AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            //pnl_singleFile.Margin = new Padding(0);
            //pnl_singleFile.ColumnCount = 4;
            //pnl_singleFile.RowCount = 2;

            //pnl_singleFile.Controls.Add(lbl_avi, 0, 0);
            //pnl_singleFile.Controls.Add(txt_aviFile, 1, 0);
            //pnl_singleFile.Controls.Add(lbl_empty_singleFile, 2, 0);
            //pnl_singleFile.Controls.Add(btn_browseSingleFile, 3, 0);
            //pnl_singleFile.Controls.Add(btn_convertSingleFile, 3, 1);


            //pnl_multipleFile = new TableLayoutPanel { Dock = DockStyle.Fill, AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            //pnl_multipleFile.Margin = new Padding(0);
            //pnl_multipleFile.ColumnCount = 4;
            //pnl_multipleFile.RowCount = 2;

            //pnl_multipleFile.Controls.Add(lbl_aviFolder, 0, 0);
            //pnl_multipleFile.Controls.Add(txt_aviFolder, 1, 0);
            //pnl_multipleFile.Controls.Add(lbl_empty_MultipleFiles, 2, 0);
            //pnl_multipleFile.Controls.Add(btn_browseMultipleFiles, 3, 0);
            //pnl_multipleFile.Controls.Add(btn_convertMultipleFiles, 3, 1);

            GroupBox gb = null;

            //efa = new ExtractAndFormatAudioBE(this);
            //btn_openFolder_extractFormat.Click += delegate(object sender, EventArgs e)
            //{
            //    efa.btn_browseOutputFolder_Click(sender,e);
            //};

            //rbOption1.CheckedChanged += delegate
            //{
            //    if (rbOption1.Checked)
            //    {
            //        if (gb != null)
            //            pnl_inner.Controls.Remove(gb);
            //        gb = CreateGBox("", rbOption1, rbOption2,
            //            new Label(), pnl_singleFile
            //           );

            //        pnl_inner.Controls.Add(gb, 0, 3);
            //        pnl_inner.SetColumnSpan(gb, 4);

            //    }
            //};

            //rbOption2.CheckedChanged += delegate
            //{
            //    if (rbOption2.Checked)
            //    {
            //        if (gb != null)
            //            pnl_inner.Controls.Remove(gb);
            //        gb = CreateGBox("", rbOption1, rbOption2,
            //            new Label(), pnl_multipleFile
            //           );

            //        pnl_inner.Controls.Add(gb, 0, 3);
            //        pnl_inner.SetColumnSpan(gb, 4);
            //    }
            //};


            //btn_browseSingleFile_extractFormat.Click += delegate (object sender, EventArgs e)
            //{
            //    efa.btn_browseSingleFile_Click(sender, e);
            //};

            //btn_convertSingleFile_extractFormat.Click += delegate (object sender, EventArgs e)
            //{
            //    efa.btn_convertSingleFile_Click(sender, e);
            //};
            //btn_gotoWalkthrough.Click += delegate (object sender, EventArgs e)
            //{
            //    navigationListener.navigateToExtractFormatAudioWalkthrough();
            //};

            //btn_gotoWalkthrough.Click += delegate
            //{

            //}

            //rbOption1.Checked = true;
            pnl_main_formatAudio.Controls.Add(pnl_info, 0, 0);
            pnl_main_formatAudio.SetColumnSpan(pnl_info, 4);
            pnl_main_formatAudio.Controls.Add(pnl_inner, 0, 1);
            pnl_main_formatAudio.SetColumnSpan(pnl_inner, 3);

            return pnl_main_formatAudio;
         
        }
    }
}
