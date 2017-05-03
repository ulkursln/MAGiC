using MAGiC.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAGiC
{

    public partial class HomeScreen : Form, INavigationListener
    {

        //CollapsibleSplitContainer splitPane = new CollapsibleSplitContainer { Orientation = Orientation.Vertical, Dock = DockStyle.Fill, BorderStyle = BorderStyle.Fixed3D, SplitterWidth = 6 };
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeScreen));
        CollapsibleSplitContainer splitter = new CollapsibleSplitContainer();
        TabControl tc = new TabControl { Dock = DockStyle.Fill };
        //WalkthroughSpeechAnalysis walkthroughSpeechAnalysis ;
        //WalkthroughAOIAnalysis walkthroughAOIAnalysis;
        SpeechAnalysisTab speechAnalysisTab;
        AOIAnalysisTab aoiAnalysisTab;
        SummaryTab summaryTab;
        TabPage tp_walkthrough = new TabPage("Walkthrough Tree");
        TabPage tp_walkthrough_nodes = new TabPage("Walkthrough");
        TabPage tp_speechAnalysis = new TabPage("Speech Anaylsis");
        TabPage tp_aoiAnalysis = new TabPage("AOI Analysis");
        TabPage tp_summary = new TabPage("Summary");

        SpeechAnalysisWalkthroughUI speechAnalysisWalkthrougUI;
        AOIAnalysisWalkthroughUI aoiAnalysisWalkthroughUI;
        SummaryWalkthroughUI summaryWalkthroughUI;

        WalkthroughTree walkthroughTree;
        //---

        //Label lbl_steps = new Label
        //{
        //    //Text = Constants.LEFTPANE_HOME,
        //    Margin = Padding.Empty,
        //    AutoSize = true,
        //    //Font = new Font("Arial", 15, FontStyle.Bold | FontStyle.Underline),
        //    ForeColor = Color.Blue,
        //    Image= global::MAGiC.Properties.Resources.homePage2,


        //};


        OutlookBarButton outlookBarButtonWalkthrough = new OutlookBarButton();
        OutlookBarButton outlookBarButtonSpeechAnalysis = new OutlookBarButton();
        OutlookBarButton outlookBarButtonAOIAnalysis = new OutlookBarButton();
        OutlookBarButton outlookBarButtonSummary = new OutlookBarButton();


        OutlookBar outlookBar1 = new OutlookBar();


        Button lbl_steps = new Button
        {
            Margin = Padding.Empty,
            AutoSize = true,
            //Font = new Font("Arial", 15, FontStyle.Bold | FontStyle.Underline),
            ForeColor = Color.Blue,
            Image = global::MAGiC.Properties.Resources.homePage2Resized,
            Size = new Size(40, 40)

        };

        Label lbl_speechAnalysis = new Label
        {
            Text = Constants.LEFTPANE_SPEECHANALYSIS,
            AutoSize = true,
            Font = new Font("Arial", 15, FontStyle.Bold),
            ForeColor = Color.Blue
        };
        Label lbl_aoiAnalysis = new Label
        {
            Text = Constants.LEFTPANE_AOIANALYSIS,
            AutoSize = true,
            Font = new Font("Arial", 15, FontStyle.Bold),
            ForeColor = Color.Blue
        };
        Label lbl_summary = new Label
        {
            Text = Constants.LEFTPANE_SUMMARY,
            AutoSize = true,
            Font = new Font("Arial", 15, FontStyle.Bold),
            ForeColor = Color.Blue
        };

        // FlowLayoutPanel options = new FlowLayoutPanel() { Dock = DockStyle.Fill, FlowDirection = FlowDirection.TopDown, WrapContents = false, AutoScroll = true };
        ColorDialog dialogColor = new ColorDialog();

        public HomeScreen()
        {


            speechAnalysisTab = new SpeechAnalysisTab(this);
            aoiAnalysisTab = new AOIAnalysisTab(this);
            summaryTab = new SummaryTab(this);

            speechAnalysisWalkthrougUI = new SpeechAnalysisWalkthroughUI(this);
            speechAnalysisWalkthrougUI.initializeController();
            aoiAnalysisWalkthroughUI = new AOIAnalysisWalkthroughUI(this);
            aoiAnalysisWalkthroughUI.initializeController();
            summaryWalkthroughUI = new SummaryWalkthroughUI(this);
            summaryWalkthroughUI.initializeController();

            Text = "MAGiC v1.0";
            this.Icon = global::MAGiC.Properties.Resources.top;
            ClientSize = new System.Drawing.Size(1000, 700);

            //splitPane.Size = new System.Drawing.Size(1000, 1);
            //splitPane.SplitterDistance = 400;
            //splitPane.FixedPanel = FixedPanel.Panel1;

            ((System.ComponentModel.ISupportInitialize)(this.splitter)).BeginInit();
            this.splitter.SuspendLayout();
            SuspendLayout();
            createOutlookBarComponentItems();

            this.splitter.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitter.Location = new System.Drawing.Point(0, 24);
            this.splitter.Name = "splitter";
            this.splitter.Size = new System.Drawing.Size(384, 237);
            //this.splitter.SplitterButtonBitmap = ((System.Drawing.Bitmap)(resources.GetObject("splitter.SplitterButtonBitmap")));
            this.splitter.SplitterButtonStyle = ButtonStyle.PushButton;
            this.splitter.SplitterDistance = 60;
            this.splitter.SplitterWidth = 22;
            this.splitter.TabIndex = 2;

            splitter.Panel1.Controls.Add(outlookBar1);
            splitter.Panel2.Controls.Add(tc);
            splitter.SplitterButtonStyle = ButtonStyle.ScrollBar;
            splitter.SplitterButtonPosition = ButtonPosition.Center;

            this.Controls.Add(this.splitter);


            tc.ItemSize = new Size(250, 50);
            tc.Appearance = TabAppearance.Buttons;
            ImageList imageList1 = new ImageList();
            imageList1.ImageSize = new Size(35, 35);
            imageList1.Images.Add("walkthroughImage", global::MAGiC.Properties.Resources.walkthroughResized);
            imageList1.Images.Add("speechAnalysisImage", global::MAGiC.Properties.Resources.sound);
            imageList1.Images.Add("AOIAnalysisImage", global::MAGiC.Properties.Resources.face);
            imageList1.Images.Add("summaryImage", global::MAGiC.Properties.Resources.notebook_1);
            tc.ImageList = imageList1;


            tc.TabPages.Add(tp_walkthrough);

            tc.Font = new Font("Arial", 12, FontStyle.Bold);

            tp_walkthrough.Controls.Add(walkthroughHomeScreen());
            tp_walkthrough.ImageKey = "walkthroughImage";


            tp_speechAnalysis.Controls.Add(speechAnalysisTab);
            tp_speechAnalysis.ImageKey = "speechAnalysisImage";

            tp_aoiAnalysis.Controls.Add(aoiAnalysisTab);
            tp_aoiAnalysis.ImageKey = "AOIAnalysisImage";

            tp_summary.Controls.Add(summaryTab.getLayout());
            tp_summary.ImageKey = "summaryImage";

            outlookBar1.SelectedButton = outlookBarButtonWalkthrough;

            //---

            Accordion[] accs = new[] { speechAnalysisTab.acc, aoiAnalysisTab.acc };
            foreach (var a in accs)
            {
                a.OpenOneOnly = true;
                a.Close(null);
            }


            this.WindowState = FormWindowState.Maximized;
    

            //---
            //Controls.Add(splitPane);
            tc.SelectedTab = tp_walkthrough;

            ((System.ComponentModel.ISupportInitialize)(this.splitter)).EndInit();

            this.splitter.ResumeLayout(false);
            //this.outlookBar1.ResumeLayout();
            // ResumeLayout(true);

            this.ResumeLayout(true);
            this.PerformLayout();

        }

        private void createOutlookBarComponentItems()
        {
            this.outlookBar1.BackColor = System.Drawing.SystemColors.Highlight;
            this.outlookBar1.ButtonHeight = 50;

            outlookBarButtonWalkthrough.Enabled = true;
            outlookBarButtonWalkthrough.Image = (global::MAGiC.Properties.Resources.walkthroughResized);
            outlookBarButtonWalkthrough.Tag = null;
            outlookBarButtonWalkthrough.Text = "Walkthrough Tree";

            outlookBarButtonSpeechAnalysis.Enabled = true;
            outlookBarButtonSpeechAnalysis.Image = (global::MAGiC.Properties.Resources.sound);
            outlookBarButtonSpeechAnalysis.Tag = null;
            outlookBarButtonSpeechAnalysis.Text = "Speech Analysis";

            outlookBarButtonAOIAnalysis.Enabled = true;
            outlookBarButtonAOIAnalysis.Image = (global::MAGiC.Properties.Resources.face);
            outlookBarButtonAOIAnalysis.Tag = null;
            outlookBarButtonAOIAnalysis.Text = "AOI Analysis";

            outlookBarButtonSummary.Enabled = true;
            outlookBarButtonSummary.Image = (global::MAGiC.Properties.Resources.notebook_1);
            outlookBarButtonSummary.Tag = null;
            outlookBarButtonSummary.Text = "Summary";



            this.outlookBar1.Buttons.Add(outlookBarButtonWalkthrough);
            this.outlookBar1.Buttons.Add(outlookBarButtonSpeechAnalysis);
            this.outlookBar1.Buttons.Add(outlookBarButtonAOIAnalysis);
            this.outlookBar1.Buttons.Add(outlookBarButtonSummary);


            this.outlookBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.outlookBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.outlookBar1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.outlookBar1.GradientButtonHoverDark = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(192)))), ((int)(((byte)(91)))));
            this.outlookBar1.GradientButtonHoverLight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.outlookBar1.GradientButtonNormalDark = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(193)))), ((int)(((byte)(140)))));
            this.outlookBar1.GradientButtonNormalLight = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(207)))));
            this.outlookBar1.GradientButtonSelectedDark = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(150)))), ((int)(((byte)(21)))));
            this.outlookBar1.GradientButtonSelectedLight = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.outlookBar1.Location = new System.Drawing.Point(3, 64);
            this.outlookBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.outlookBar1.Name = "outlookBar1";
            this.outlookBar1.SelectedButton = null;
            this.outlookBar1.Size = new System.Drawing.Size(217, 250);
            this.outlookBar1.TabIndex = 0;
            this.outlookBar1.Click += new OutlookBar.ButtonClickEventHandler(this.outlookBar1_Click);
        }

        private void outlookBar1_Click(object sender, OutlookBar.ButtonClickEventArgs e)
        {
            int idx = outlookBar1.Buttons.IndexOf(e.SelectedButton);
            switch (idx)
            {
                case 0: // Walkthrough
                    if (!tc.TabPages.Contains(tp_walkthrough))
                    {

                        tc.TabPages.Insert(1, tp_walkthrough);
                        tc.TabPages.RemoveAt(0);
                        tc.SelectedTab = tp_walkthrough;
                        tp_walkthrough.ImageKey = "walkthroughImage";
                    }
                    break;
                case 1: // Speech Analysis
                    if (!tc.TabPages.Contains(tp_speechAnalysis))
                    {

                        tc.TabPages.Insert(1, tp_speechAnalysis);
                        tc.TabPages.RemoveAt(0);
                        tc.SelectedTab = tp_speechAnalysis;
                        tp_speechAnalysis.ImageKey = "speechAnalysisImage";
                    }
                    break;
                case 2: // AOI Analysis
                    if (!tc.TabPages.Contains(tp_aoiAnalysis))
                    {
                        tc.TabPages.Insert(1, tp_aoiAnalysis);
                        tc.TabPages.RemoveAt(0);
                        tc.SelectedTab = tp_aoiAnalysis;
                        tp_aoiAnalysis.ImageKey = "AOIAnalysisImage";

                    }
                    break;
                case 3: // Summary
                    if (!tc.TabPages.Contains(tp_summary))
                    {
                        tc.TabPages.Insert(1, tp_summary);
                        tc.TabPages.RemoveAt(0);
                        tc.SelectedTab = tp_summary;
                        tp_summary.ImageKey = "summaryImage";
                    }
                    break;

            }

        }

        public Control walkthroughHomeScreen()
        {
            ImageList imageListTreeView = new ImageList();
            imageListTreeView.ImageSize = new Size(25, 25);
            imageListTreeView.Images.Add("clickableItem", global::MAGiC.Properties.Resources.mouseHand);

            walkthroughTree = new WalkthroughTree();
            CustomTree treeView = new CustomTree();

            treeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            treeView.BackColor = System.Drawing.SystemColors.Info;
             treeView.FullRowSelect = true;
             treeView.ImageIndex = 0;
            treeView.ImageList = imageListTreeView;
            treeView.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(168)))), ((int)(((byte)(153)))));
            treeView.Location = new System.Drawing.Point(0, 0);
            treeView.Name = "walkthrough";
            treeView.SelectedImageIndex = 0;
            treeView.Size = new System.Drawing.Size(234, 216);
            treeView.TabIndex = 0;

            walkthroughTree.ensureDefaultImageIndex(treeView);
            treeView.DrawMode = TreeViewDrawMode.OwnerDrawAll;
            walkthroughTree.loadTree(treeView);
            treeView.Nodes[0].ExpandAll();


            treeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(tv_NodeMouseClick);

            return treeView;

        }



        private void tv_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
           

            bool changeWalkthrouhPage = createWalkthrougPage(e, walkthroughTree);

            if (changeWalkthrouhPage)
            {
                tc.TabPages.RemoveAt(0);
                tc.TabPages.Insert(0, tp_walkthrough_nodes);
                tc.SelectedTab = tp_walkthrough_nodes;
                tp_walkthrough_nodes.ImageKey = "walkthroughImage";
            }
        }

        private bool createWalkthrougPage(TreeNodeMouseClickEventArgs e, WalkthroughTree walkthroughTree)
        {
            bool changeWalkthrouhPage = false;
            if (e.Node == walkthroughTree.node_analysis_speech_extractFormatAudio)
            {

                /*Extract and Format Audio Tab*/
                /**************************************************************************/
                TableLayoutPanel pnl_extractAndFormatAudio = speechAnalysisWalkthrougUI.getExtractAndFormatAudioWalkthroughLayout();
                /*End of Extract and Format Audio*/
                tp_walkthrough_nodes = new TabPage( Constants.WalkthroughTitleExtractFormatAudio);
                tp_walkthrough_nodes.Controls.Add(pnl_extractAndFormatAudio);
                changeWalkthrouhPage = true;

            }
            else if (e.Node == walkthroughTree.node_analysis_speech_segmentAudio)
            {

                /*Segment Audio*/
                /**************************************************************************/
                TableLayoutPanel pnl_SegmentAudio = speechAnalysisWalkthrougUI.getSegmentAudioWalkthroughLayout();
                /*End of Segment Audio*/
                tp_walkthrough_nodes = new TabPage(Constants.WalkthroughTitleSegmentAudio);
                tp_walkthrough_nodes.Controls.Add(pnl_SegmentAudio);
                changeWalkthrouhPage = true;

            }
            else if (e.Node == walkthroughTree.node_analysis_speech_timeIntervalEstimation)
            {


                /*Time Interval Specification (also,Synchronization for Multiple Recordings) Tab*/
                /**************************************************************************/
                TableLayoutPanel pnl_specifyTimeInterval = speechAnalysisWalkthrougUI.getSpecifyTimeIntervalWalkthroughLayout();
                /*End of Time Interval Specification (also, Synchronization for Multiple Recordings) Tab*/
                tp_walkthrough_nodes = new TabPage(Constants.WalkthroughTitleTimeIntervalEstimation);
                tp_walkthrough_nodes.Controls.Add(pnl_specifyTimeInterval);
                changeWalkthrouhPage = true;

            }
            else if (e.Node == walkthroughTree.node_analysis_speech_speechAnnotation_defineSpeechActs)
            {

                /*DefineSpeechAct Tab*/
                /**************************************************************************/
                TableLayoutPanel pnl_defineSpeechAct = speechAnalysisWalkthrougUI.getDefineSpeechActWalkthroughLayout();
                /*DefineSpeechActTab*/
                tp_walkthrough_nodes = new TabPage(Constants.WalkthroughTitleDefineSpeechActs);
                tp_walkthrough_nodes.Controls.Add(pnl_defineSpeechAct);
                changeWalkthrouhPage = true;
            }
            else if (e.Node == walkthroughTree.node_analysis_speech_speechAnnotation_annotation)
            {

                /*Annotation Tab*/
                /**************************************************************************/
                TableLayoutPanel pnl_annotation = speechAnalysisWalkthrougUI.getAnnotationWalkthroughLayout();
                /*Annotation Tab*/
                tp_walkthrough_nodes = new TabPage(Constants.WalkthroughTitleAnnotation);
                tp_walkthrough_nodes.Controls.Add(pnl_annotation);
                changeWalkthrouhPage = true;
            }

            else if (e.Node == walkthroughTree.node_analysis_aoi_faceTracking_defaultDetector)
            {

                /*Face Tracking With Default Detector Tab*/
                /**************************************************************************/
                TableLayoutPanel pnl_faceTrackingWithDefaultDetector = aoiAnalysisWalkthroughUI.getFaceTrackingWithDefaultDetectorWalkthroughLayout();
                /*End of Face Tracking With Default Detector*/
                tp_walkthrough_nodes = new TabPage(Constants.WalkthroughTitleFaceTrackingDefaultDetector);
                tp_walkthrough_nodes.Controls.Add(pnl_faceTrackingWithDefaultDetector);
                changeWalkthrouhPage = true;

            }
            else if (e.Node == walkthroughTree.node_analysis_aoi_faceTracking_trainedDetector)
            {

                /*Face Tracking With Trained Detector Tab*/
                /**************************************************************************/
                TableLayoutPanel pnl_faceTrackingWithTrainedDetector = aoiAnalysisWalkthroughUI.getFaceTrackingWithTrainedDetectorWalkthroughLayout();
                /*End of Face Tracking With Default Detector*/
                tp_walkthrough_nodes = new TabPage(Constants.WalkthroughTitleFaceTrackingTrainedDetector);
                tp_walkthrough_nodes.Controls.Add(pnl_faceTrackingWithTrainedDetector);
                changeWalkthrouhPage = true;

            }
            else if (e.Node == walkthroughTree.node_analysis_aoi_aoiAnaylse_preProcessGazeData)
            {

                TableLayoutPanel pnl_preProcessGazeData = aoiAnalysisWalkthroughUI.getPreProcessGazeDataWalkthroughLayout();
                tp_walkthrough_nodes = new TabPage(Constants.WalkthroughTitlePreProcessGazeData);
                tp_walkthrough_nodes.Controls.Add(pnl_preProcessGazeData);
                changeWalkthrouhPage = true;

            }
            else if (e.Node == walkthroughTree.node_analysis_aoi_aoiAnaylse_faceasAOI)
            {

                TableLayoutPanel pnl_detectAOI = aoiAnalysisWalkthroughUI.getDetectAOIWalkthroughLayout();
                tp_walkthrough_nodes = new TabPage(Constants.WalkthroughTitleFaceasAOI);
                tp_walkthrough_nodes.Controls.Add(pnl_detectAOI);
                changeWalkthrouhPage = true;

            }
            else if (e.Node == walkthroughTree.node_analysis_aoi_reviewOutcomes_visualizeTracking)
            {

                TableLayoutPanel pnl_visualizeTracking = aoiAnalysisWalkthroughUI.getVisualizeTrackingWalkthroughLayout();
                tp_walkthrough_nodes = new TabPage(Constants.WalkthroughTitleVisualizeTracking);
                tp_walkthrough_nodes.Controls.Add(pnl_visualizeTracking);
                changeWalkthrouhPage = true;

            }
            else if (e.Node == walkthroughTree.node_analysis_aoi_reviewOutcomes_findAOIsDetectionRatio)
            {

                TableLayoutPanel pnl_findDetectionRatio = aoiAnalysisWalkthroughUI.getFindDetectionRatioWalkthroughLayout();
                tp_walkthrough_nodes = new TabPage(Constants.WalkthroughTitleFindAOIsDetectionRatio);
                tp_walkthrough_nodes.Controls.Add(pnl_findDetectionRatio);
                changeWalkthrouhPage = true;

            }
            else if (e.Node == walkthroughTree.node_analysis_aoi_reviewOutcomes_labelAOIsManually)
            {

                TableLayoutPanel pnl_labelAOIManually = aoiAnalysisWalkthroughUI.getLabelAOIManuallyWalkthroughLayout();
                tp_walkthrough_nodes = new TabPage(Constants.WalkthroughTitleLabelAOIsManually);
                tp_walkthrough_nodes.Controls.Add(pnl_labelAOIManually);
                changeWalkthrouhPage = true;

            }

            else if (e.Node == walkthroughTree.node_analysis_aoi_reviewOutcomes_reanalyseAOIs)
            {

                TableLayoutPanel pnl_reanalyseAOI = aoiAnalysisWalkthroughUI.getReanalyseAOIWalkthroughLayout();
                tp_walkthrough_nodes = new TabPage(Constants.WalkthroughTitleReanalyseAOIs);
                tp_walkthrough_nodes.Controls.Add(pnl_reanalyseAOI);
                changeWalkthrouhPage = true;

            }

            else if (e.Node == walkthroughTree.node_analysis_summary)
            {

                TableLayoutPanel pnl_summary = summaryWalkthroughUI.getLayout();
                tp_walkthrough_nodes = new TabPage(Constants.WalkthroughTitleSummary);
                tp_walkthrough_nodes.Controls.Add(pnl_summary);
                changeWalkthrouhPage = true;

            }

            return changeWalkthrouhPage;
        }


        public abstract class AccordionPanel : Panel
        {

            public Accordion acc = new Accordion();

            public AccordionPanel()
            {
                Dock = DockStyle.Fill;
                Controls.Add(acc);
            }

        }



        public class SpeechAnalysisTab : AccordionPanel
        {

            HomeScreen homeScreen;
            Accordion accNested;
            public SpeechAnalysisTab(HomeScreen _homeScreen)
            {

                homeScreen = _homeScreen;
                List<CheckBox> checkboxList = new List<CheckBox>();

                TableLayoutPanel pnl_main_speechAnalysis = new TableLayoutPanel { Dock = DockStyle.Fill, BackColor = Color.WhiteSmoke, Size = new Size(800, 800), AutoSizeMode = AutoSizeMode.GrowAndShrink };
                pnl_main_speechAnalysis.Margin = new Padding(0);
                pnl_main_speechAnalysis.ColumnCount = 1;
                pnl_main_speechAnalysis.RowCount = 1;

                Accordion accParent = acc;
                acc.Insets = new Padding(10);
                acc.ContentPadding = new Padding(10);
                acc.ContentMargin = new Padding(0);
                acc.CheckBoxMargin = new Padding(0);

                /*Extract and Format Audio Tab*/
                /**************************************************************************/
                ExtractAndFormatAudioUI extractAndFormatAudioUI = new ExtractAndFormatAudioUI(homeScreen);
                ExtractAndFormatAudioBE efa = new ExtractAndFormatAudioBE(extractAndFormatAudioUI);
                checkboxList.Add(accParent.Add(extractAndFormatAudioUI.pnl_extractAndFormatAudio, "Extract and Format Audio", "ToolTip 1"));
                /*End of Extract and Format Audio*/


                /*Segment Audio*/
                /**************************************************************************/
                SegmentAudioUI segmentAudioUI = new SegmentAudioUI(homeScreen);
                SegmentAudioBE sa = new SegmentAudioBE(segmentAudioUI);
                checkboxList.Add(accParent.Add(segmentAudioUI.pnl_SegmentAudio, "Segment Audio", "ToolTip 2"));
                /*End of Segment Audio*/

                /*Time Interval Specification (also,Synchronization for Multiple Recordings) Tab*/
                /**************************************************************************/
                SpecifyTimeIntervalUI specifyTimeIntervalUI = new SpecifyTimeIntervalUI(homeScreen);
                SpecifyTimeIntervalBE sti = new SpecifyTimeIntervalBE(specifyTimeIntervalUI);
                checkboxList.Add(accParent.Add(specifyTimeIntervalUI.pnl_specifyTimeInterval, "Time Interval Estimation (also, Syncronization for Multiple Recordings)", "ToolTip 3"));
                /*End of Time Interval Specification (also, Synchronization for Multiple Recordings) Tab*/

                /*Speech-Act Annotation Tab*/
                /**************************************************************************/
                SpeechActAnnotationUI speechActAnnotationUI = new SpeechActAnnotationUI(homeScreen);
                SpeechActAnnotationBE saa = new SpeechActAnnotationBE(speechActAnnotationUI);
                accNested = new Accordion() { Dock = DockStyle.Fill, OpenOneOnly = true };
                checkboxList.Add(accNested.Add(speechActAnnotationUI.pnl_defineSpeechAct, "Define Speech-Acts"));
                checkboxList.Add(accNested.Add(speechActAnnotationUI.pnl_annotation, "Annotation"));
                checkboxList.Add(accParent.Add(accNested, "Speech Annotation", "ToolTip 4"));
                /*Speech-Act Annotation Tab*/

                pnl_main_speechAnalysis.Controls.Add(acc);
                Controls.Add(pnl_main_speechAnalysis);
                // Controls.Add(acc);

            }

            public void selectExtactAndFormatAudioItem()
            {

                acc.Controls[0].Select();
                ((CheckBox)acc.Controls[0]).Checked = true;
            }

            public void selectSegmentAudioItem()
            {

                acc.Controls[2].Select();
                // acc.Controls[2].Show();
                ((CheckBox)acc.Controls[2]).Checked = true;
            }

            public void selectSpecifyTimeIntervalItem()
            {
                acc.Controls[4].Select();
                ((CheckBox)acc.Controls[4]).Checked = true;
            }

            public void selectDefineSpeechActItem()
            {
                acc.Controls[6].Select();
                ((CheckBox)acc.Controls[6]).Checked = true;
                ((CheckBox)accNested.Controls[0]).Checked = true;
            }
            public void selectAnnotationItem()
            {
                acc.Controls[6].Select();
                ((CheckBox)acc.Controls[6]).Checked = true;
                ((CheckBox)accNested.Controls[2]).Checked = true;
            }


        }

        public class AOIAnalysisTab : AccordionPanel
        {

            HomeScreen homeScreen;
            Accordion accNestedaccParentfaceTracking, accNestedaccParentdetectROI, accNestedaccParentreviewOutcomes;
            public AOIAnalysisTab(HomeScreen _homeScreen)
            {

                homeScreen = _homeScreen;
                List<CheckBox> checkboxListFaceTracking = new List<CheckBox>();
                TableLayoutPanel pnl_main_AOIAnalysis = new TableLayoutPanel { Dock = DockStyle.Fill, BackColor = Color.WhiteSmoke, Size = new Size(800, 800), AutoSizeMode = AutoSizeMode.GrowAndShrink};
                pnl_main_AOIAnalysis.Margin = new Padding(0);
                pnl_main_AOIAnalysis.ColumnCount = 1;
                pnl_main_AOIAnalysis.RowCount = 1;

                Accordion accParentfaceTracking = acc;

                acc.Insets = new Padding(10);
                acc.ContentPadding = new Padding(10);
                acc.ContentMargin = new Padding(0);
                acc.CheckBoxMargin = new Padding(0);


                /*Face Tracking Tab*/
                /**************************************************************************/
                FaceTrackingUI faceTrackingUI = new FaceTrackingUI(homeScreen);
                FaceTrackingBE ft = new FaceTrackingBE(faceTrackingUI);
                accNestedaccParentfaceTracking = new Accordion() { Dock = DockStyle.Fill, OpenOneOnly = true };
                checkboxListFaceTracking.Add(accNestedaccParentfaceTracking.Add(faceTrackingUI.pnl_trackingWithDefaultDetector, "Face Tracking (wtih default detector)"));
                checkboxListFaceTracking.Add(accNestedaccParentfaceTracking.Add(faceTrackingUI.pnl_trackingWithTrainedDetector, "Face Tracking (with trained detector)"));
                checkboxListFaceTracking.Add(accParentfaceTracking.Add(accNestedaccParentfaceTracking, "Face Tracking", "ToolTip 1"));
                /*End of Face Tracking*/



                /*Detect ROI */
                /**************************************************************************/
                DetectROIUI detectROIUI = new DetectROIUI(homeScreen);
                DetectROIBE droi = new DetectROIBE(detectROIUI);
                accNestedaccParentdetectROI = new Accordion() { Dock = DockStyle.Fill, OpenOneOnly = true };
                checkboxListFaceTracking.Add(accNestedaccParentdetectROI.Add(detectROIUI.pnl_preProcessGazeData, "Pre-Process Gaze Data"));
                checkboxListFaceTracking.Add(accNestedaccParentdetectROI.Add(detectROIUI.pnl_faceAsAOI, " Face as AOI"));
                checkboxListFaceTracking.Add(accParentfaceTracking.Add(accNestedaccParentdetectROI, "AOI Anaylse", "ToolTip 1"));
                /*End of Detect ROI*/

                /*Review Outcomes */
                /**************************************************************************/
                ReviewOutcomesUI reviewOutcomesUI = new ReviewOutcomesUI(homeScreen);
                ReviewOutcomesBE ro = new ReviewOutcomesBE(reviewOutcomesUI);
                accNestedaccParentreviewOutcomes = new Accordion() { Dock = DockStyle.Fill, OpenOneOnly = true };
                checkboxListFaceTracking.Add(accNestedaccParentreviewOutcomes.Add(reviewOutcomesUI.pnl_visualizeTrackingResults, "Visualize Tracking"));
                checkboxListFaceTracking.Add(accNestedaccParentreviewOutcomes.Add(reviewOutcomesUI.pnl_findDetectionRatio, "Find AOIs Detection Ratio"));
                checkboxListFaceTracking.Add(accNestedaccParentreviewOutcomes.Add(reviewOutcomesUI.pnl_labelAOIMAnually, "Label AOIs Manually"));
                checkboxListFaceTracking.Add(accNestedaccParentreviewOutcomes.Add(reviewOutcomesUI.pnl_reanalyseAOI, "Re-analyse AOIs (considering manually labeled AOIs)"));
                checkboxListFaceTracking.Add(accParentfaceTracking.Add(accNestedaccParentreviewOutcomes, "Review Outcomes", "ToolTip 1"));

                /*End of Review Outcomes*/

                pnl_main_AOIAnalysis.Controls.Add(acc);
                Controls.Add(pnl_main_AOIAnalysis);

            }

            public void selectFaceTrackingWithDefaultDetectorItem()
            {
                acc.Controls[0].Select();
                ((CheckBox)acc.Controls[0]).Checked = true;
                ((CheckBox)accNestedaccParentfaceTracking.Controls[0]).Checked = true;
            }

            public void selectFaceTrackingWithTrainedDetectorItem()
            {
                acc.Controls[0].Select();
                ((CheckBox)acc.Controls[0]).Checked = true;
                ((CheckBox)accNestedaccParentfaceTracking.Controls[2]).Checked = true;
            }

            public void selectPreProcessGazeDataItem()
            {
                acc.Controls[2].Select();
                ((CheckBox)acc.Controls[2]).Checked = true;
                ((CheckBox)accNestedaccParentdetectROI.Controls[0]).Checked = true;
            }

            public void selectDetectAOIItem()
            {
                acc.Controls[2].Select();
                ((CheckBox)acc.Controls[2]).Checked = true;
                ((CheckBox)accNestedaccParentdetectROI.Controls[2]).Checked = true;
            }
            public void selectVisualizeTrackingResultsItem()
            {
                acc.Controls[4].Select();
                ((CheckBox)acc.Controls[4]).Checked = true;
                ((CheckBox)accNestedaccParentreviewOutcomes.Controls[0]).Checked = true;
            }
            public void selectFindDetectionRatioItem()
            {
                acc.Controls[4].Select();
                ((CheckBox)acc.Controls[4]).Checked = true;
                ((CheckBox)accNestedaccParentreviewOutcomes.Controls[2]).Checked = true;
            }
            public void selectLabelAOIManuallyItem()
            {
                acc.Controls[4].Select();
                ((CheckBox)acc.Controls[4]).Checked = true;
                ((CheckBox)accNestedaccParentreviewOutcomes.Controls[4]).Checked = true;
            }
            public void selectReanalyseAOIItem()
            {
                acc.Controls[4].Select();
                ((CheckBox)acc.Controls[4]).Checked = true;
                ((CheckBox)accNestedaccParentreviewOutcomes.Controls[6]).Checked = true;
            }


        }

        //internal class AP33 : AccordionPanel
        //{

        //    class TextBox2 : TextBox
        //    {

        //        public TextBox2()
        //        {
        //            MinimumSize = new Size(100, 5);
        //            MaximumSize = new Size(300, 90);
        //            Multiline = true;
        //        }

        //        public override Size GetPreferredSize(Size proposedSize)
        //        {
        //            return new Size(120, 40);
        //        }
        //    }

        //    public AP33()
        //    {

        //        this.Size = new Size(700, 400);
        //        this.Padding = new Padding(10);
        //        this.BackColor = Color.LightBlue;

        //        acc.SuspendLayout();
        //        acc.BackColor = Color.LightYellow;
        //        acc.Padding = new Padding(5, 10, 15, 20);
        //        String text1 = "Minimum Size = (100, 5)\r\nMaximum Size = (300, 90)\r\nPreferred Size = (120, 40)\r\nUncheck ControlMinimumHeightIsItsPreferredHeight to allow to shrink to the minimum height.";
        //        TextBox2 tb1 = new TextBox2 { Text = text1, Dock = DockStyle.Fill, Margin = new Padding(1, 2, 3, 4), ScrollBars = ScrollBars.Vertical };
        //        acc.Add(tb1, "Min and Max Constraints (fillWt:1.0)", fillWt: 1.0, contentBackColor: Color.Red, contentMargin: new Padding(10), addResizeBar: true);

        //        String text2 = "This textbox's height will grow and shrink slower than the above textbox's height if the above textbox hasn't reached its limits.";
        //        acc.Add(new TextBox { Text = text2, Multiline = true, Dock = DockStyle.Fill }, "No Constraints (fillWt:0.5)", fillWt: 0.5, contentBackColor: Color.LightGreen, resizeBarMargin: new Padding(100));
        //        acc.ResumeLayout();
        //    }
        //}

        public class SummaryTab
        {

            HomeScreen homeScreen;
            SummaryUI summaryUI;
            SummaryBE summaryBE;

            public SummaryTab(HomeScreen _homeScreen)
            {

                homeScreen = _homeScreen;
                summaryUI = new SummaryUI(homeScreen);
                summaryBE = new SummaryBE(summaryUI);


            }
            public Control getLayout()
            {
                return summaryUI.getLayout();
            }


        }


        //navigate to tab items

        //speech analysis
        public void navigateToExtractFormatAudio()
        {
            arrangeApperanceOfRelatedTab(1);
            tc.SelectedTab = tp_speechAnalysis;
            speechAnalysisTab.selectExtactAndFormatAudioItem();

        }

        public void navigateToSegmentAudio()
        {
            arrangeApperanceOfRelatedTab(1);
            tc.SelectedTab = tp_speechAnalysis;
            speechAnalysisTab.selectSegmentAudioItem();
        }

        public void navigateToSpecifyTimeInterval()
        {
            arrangeApperanceOfRelatedTab(1);
            tc.SelectedTab = tp_speechAnalysis;
            speechAnalysisTab.selectSpecifyTimeIntervalItem();
        }

        public void navigateToDefineSpeechAct()
        {
            arrangeApperanceOfRelatedTab(1);
            tc.SelectedTab = tp_speechAnalysis;
            speechAnalysisTab.selectDefineSpeechActItem();
        }

        public void navigateToAnnotation()
        {
            arrangeApperanceOfRelatedTab(1);
            tc.SelectedTab = tp_speechAnalysis;
            speechAnalysisTab.selectAnnotationItem();
        }

        //AOI analysis
        public void navigateToFaceTrackingWithDefaultDetector()
        {
            arrangeApperanceOfRelatedTab(2);
            tc.SelectedTab = tp_aoiAnalysis;
            aoiAnalysisTab.selectFaceTrackingWithDefaultDetectorItem();
        }
        public void navigateToFaceTrackingWithTrainedDetector()
        {
            arrangeApperanceOfRelatedTab(2);
            tc.SelectedTab = tp_aoiAnalysis;
            aoiAnalysisTab.selectFaceTrackingWithTrainedDetectorItem();
        }
        public void navigateToPreProcessGazeData()
        {
            arrangeApperanceOfRelatedTab(2);
            tc.SelectedTab = tp_aoiAnalysis;
            aoiAnalysisTab.selectPreProcessGazeDataItem();
        }
        public void navigateToDetectAOI()
        {
            arrangeApperanceOfRelatedTab(2);
            tc.SelectedTab = tp_aoiAnalysis;
            aoiAnalysisTab.selectDetectAOIItem();
        }
        public void navigateToVisualizeTrackingResults()
        {
            arrangeApperanceOfRelatedTab(2);
            tc.SelectedTab = tp_aoiAnalysis;
            aoiAnalysisTab.selectVisualizeTrackingResultsItem();
        }
        public void navigateToFindDetectionRatio()
        {
            arrangeApperanceOfRelatedTab(2);
            tc.SelectedTab = tp_aoiAnalysis;
            aoiAnalysisTab.selectFindDetectionRatioItem();
        }
        public void navigateToLabelAOIManually()
        {
            arrangeApperanceOfRelatedTab(2);
            tc.SelectedTab = tp_aoiAnalysis;
            aoiAnalysisTab.selectLabelAOIManuallyItem();
        }
        public void navigateToReanalyseAOI()
        {
            arrangeApperanceOfRelatedTab(2);
            tc.SelectedTab = tp_aoiAnalysis;
            aoiAnalysisTab.selectReanalyseAOIItem();
        }

        public void navigateToSummary()
        {
            arrangeApperanceOfRelatedTab(3);
            tc.SelectedTab = tp_summary;

        }

        public void navigateToWalkthroughHome()
        {
            outlookBar1.SelectedButton = outlookBarButtonWalkthrough;

            tc.TabPages.Insert(1, tp_walkthrough);
            tc.TabPages.RemoveAt(0);
            tc.SelectedTab = tp_walkthrough;
        }

        public void navigateToExtractFormatAudioWalkthrough()
        {
            outlookBar1.SelectedButton = outlookBarButtonWalkthrough;
            TreeNodeMouseClickEventArgs e = new TreeNodeMouseClickEventArgs(walkthroughTree.node_analysis_speech_extractFormatAudio, new MouseButtons(), 0, 0, 0);
            //tp_walkthrough_nodes.Text = Constants.WalkthroughTitleExtractFormatAudio;
            tv_NodeMouseClick(new object(), e);
        }

        public void navigateToSegmentAudioWalkthrough()
        {
            outlookBar1.SelectedButton = outlookBarButtonWalkthrough;
            TreeNodeMouseClickEventArgs e = new TreeNodeMouseClickEventArgs(walkthroughTree.node_analysis_speech_segmentAudio, new MouseButtons(), 0, 0, 0);
            //tp_walkthrough_nodes.Text = Constants.WalkthroughTitleSegmentAudio;
            tv_NodeMouseClick(new object(), e);
        }

        public void navigateToSpecifyTimeIntervalWalkthrough()
        {
            outlookBar1.SelectedButton = outlookBarButtonWalkthrough;
            TreeNodeMouseClickEventArgs e = new TreeNodeMouseClickEventArgs(walkthroughTree.node_analysis_speech_timeIntervalEstimation, new MouseButtons(), 0, 0, 0);
            //tp_walkthrough_nodes.Text = Constants.WalkthroughTitleTimeIntervalEstimation;
            tv_NodeMouseClick(new object(), e);
        }

        public void navigateToDefineSpeechActWalkthrough()
        {
            outlookBar1.SelectedButton = outlookBarButtonWalkthrough;
            TreeNodeMouseClickEventArgs e = new TreeNodeMouseClickEventArgs(walkthroughTree.node_analysis_speech_speechAnnotation_defineSpeechActs, new MouseButtons(), 0, 0, 0);
            //tp_walkthrough_nodes.Text = Constants.WalkthroughTitleDefineSpeechActs;
            tv_NodeMouseClick(new object(), e);
        }

        public void navigateToAnnotationWalkthrough()
        {
            outlookBar1.SelectedButton = outlookBarButtonWalkthrough;
            TreeNodeMouseClickEventArgs e = new TreeNodeMouseClickEventArgs(walkthroughTree.node_analysis_speech_speechAnnotation_annotation, new MouseButtons(), 0, 0, 0);
            //tp_walkthrough_nodes.Text = Constants.WalkthroughTitleAnnotation;
            tv_NodeMouseClick(new object(), e);
        }

        public void navigateToFaceTrackingWithDefaultDetectorWalkthrough()
        {
            outlookBar1.SelectedButton = outlookBarButtonWalkthrough;
            TreeNodeMouseClickEventArgs e = new TreeNodeMouseClickEventArgs(walkthroughTree.node_analysis_aoi_faceTracking_defaultDetector, new MouseButtons(), 0, 0, 0);
            //tp_walkthrough_nodes.Text = Constants.WalkthroughTitleFaceTrackingDefaultDetector;
            tv_NodeMouseClick(new object(), e);
        }

        public void navigateToFaceTrackingWithTrainedDetectorWalkthrough()
        {
            outlookBar1.SelectedButton = outlookBarButtonWalkthrough;
            TreeNodeMouseClickEventArgs e = new TreeNodeMouseClickEventArgs(walkthroughTree.node_analysis_aoi_faceTracking_trainedDetector, new MouseButtons(), 0, 0, 0);
            //tp_walkthrough_nodes.Text = Constants.WalkthroughTitleFaceTrackingTrainedDetector;
            tv_NodeMouseClick(new object(), e);
        }

        public void navigateToPreProcessGazeDataWalkthrough()
        {
            outlookBar1.SelectedButton = outlookBarButtonWalkthrough;
            TreeNodeMouseClickEventArgs e = new TreeNodeMouseClickEventArgs(walkthroughTree.node_analysis_aoi_aoiAnaylse_preProcessGazeData, new MouseButtons(), 0, 0, 0);
            tp_walkthrough_nodes.Text = Constants.WalkthroughTitlePreProcessGazeData;
            tv_NodeMouseClick(new object(), e);
        }

        public void navigateToDetectAOIWalkthrough()
        {
            outlookBar1.SelectedButton = outlookBarButtonWalkthrough;
            TreeNodeMouseClickEventArgs e = new TreeNodeMouseClickEventArgs(walkthroughTree.node_analysis_aoi_aoiAnaylse_faceasAOI, new MouseButtons(), 0, 0, 0);
            //tp_walkthrough_nodes.Text = Constants.WalkthroughTitleFaceasAOI;
            tv_NodeMouseClick(new object(), e);
        }

        public void navigateToVisualizeTrackingResultsWalkthrough()
        {
            outlookBar1.SelectedButton = outlookBarButtonWalkthrough;
            TreeNodeMouseClickEventArgs e = new TreeNodeMouseClickEventArgs(walkthroughTree.node_analysis_aoi_reviewOutcomes_visualizeTracking, new MouseButtons(), 0, 0, 0);
            //tp_walkthrough_nodes.Text = Constants.WalkthroughTitleVisualizeTracking;
            tv_NodeMouseClick(new object(), e);
        }

        public void navigateToFindDetectionRatioWalkthrough()
        {
            outlookBar1.SelectedButton = outlookBarButtonWalkthrough;
            TreeNodeMouseClickEventArgs e = new TreeNodeMouseClickEventArgs(walkthroughTree.node_analysis_aoi_reviewOutcomes_findAOIsDetectionRatio, new MouseButtons(), 0, 0, 0);
            //tp_walkthrough_nodes.Text = Constants.WalkthroughTitleFindAOIsDetectionRatio;
            tv_NodeMouseClick(new object(), e);
        }

        public void navigateToLabelAOIManuallyWalkthrough()
        {
            outlookBar1.SelectedButton = outlookBarButtonWalkthrough;
            TreeNodeMouseClickEventArgs e = new TreeNodeMouseClickEventArgs(walkthroughTree.node_analysis_aoi_reviewOutcomes_labelAOIsManually, new MouseButtons(), 0, 0, 0);
            //tp_walkthrough_nodes.Text = Constants.WalkthroughTitleLabelAOIsManually;
            tv_NodeMouseClick(new object(), e);
        }

        public void navigateToReanalyseAOIWalkthrough()
        {
            outlookBar1.SelectedButton = outlookBarButtonWalkthrough;
            TreeNodeMouseClickEventArgs e = new TreeNodeMouseClickEventArgs(walkthroughTree.node_analysis_aoi_reviewOutcomes_reanalyseAOIs, new MouseButtons(), 0, 0, 0);
            //tp_walkthrough_nodes.Text = Constants.WalkthroughTitleReanalyseAOIs;
            tv_NodeMouseClick(new object(), e);
        }

        public void navigateToSummaryWalkthrough()
        {
            outlookBar1.SelectedButton = outlookBarButtonWalkthrough;
            TreeNodeMouseClickEventArgs e = new TreeNodeMouseClickEventArgs(walkthroughTree.node_analysis_summary, new MouseButtons(), 0, 0, 0);
            //tp_walkthrough_nodes.Text = Constants.WalkthroughTitleSummary;
            tv_NodeMouseClick(new object(), e);
        }

        private void arrangeApperanceOfRelatedTab(int idx)
        {

            switch (idx)
            {
                case 0: // Walkthrough
                    if (!tc.TabPages.Contains(tp_walkthrough))
                    {
                        outlookBar1.SelectedButton = outlookBarButtonWalkthrough;
                        tc.TabPages.Insert(1, tp_walkthrough);
                        tc.TabPages.RemoveAt(0);
                        tc.SelectedTab = tp_walkthrough;
                        tp_walkthrough.ImageKey = "walkthroughImage";
                    }
                    break;
                case 1: // Speech Analysis
                    if (!tc.TabPages.Contains(tp_speechAnalysis))
                    {
                        outlookBar1.SelectedButton = outlookBarButtonSpeechAnalysis;
                        tc.TabPages.Insert(1, tp_speechAnalysis);
                        tc.TabPages.RemoveAt(0);
                        tc.SelectedTab = tp_speechAnalysis;
                        tp_speechAnalysis.ImageKey = "speechAnalysisImage";
                    }
                    break;
                case 2: // AOI Analysis
                    if (!tc.TabPages.Contains(tp_aoiAnalysis))
                    {
                        outlookBar1.SelectedButton = outlookBarButtonAOIAnalysis;
                        tc.TabPages.Insert(1, tp_aoiAnalysis);
                        tc.TabPages.RemoveAt(0);
                        tc.SelectedTab = tp_aoiAnalysis;
                        tp_aoiAnalysis.ImageKey = "AOIAnalysisImage";
                    }
                    break;
                case 3: // Summary
                    if (!tc.TabPages.Contains(tp_summary))
                    {
                        outlookBar1.SelectedButton = outlookBarButtonSummary;
                        tc.TabPages.Insert(1, tp_summary);
                        tc.TabPages.RemoveAt(0);
                        tc.SelectedTab = tp_summary;
                        tp_summary.ImageKey = "summaryImage";
                    }
                    break;

            }
        }


    }
}
