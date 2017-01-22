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
        TabPage tp_walkthrough = new TabPage("Walkthrough");
        TabPage tp_walkthrough_nodes = new TabPage("Walkthrough");
        TabPage tp_speechAnalysis = new TabPage("Speech Anaylsis");
        TabPage tp_aoiAnalysis = new TabPage("AOI Analysis");
        TabPage tp_summary = new TabPage("Summary");

        SpeechAnalysisWalkthroughUI speechAnalysisWalkthrougUI;
        AOIAnalysisWalkthroughUI aoiAnalysisWalkthroughUI;
        SummaryWalkthroughUI summaryWalkthroughUI;

        WalkthroughTree walkthroughTree;
        //---

        Label lbl_steps = new Label
        {
            Text = Constants.LEFTPANE_HOME,
            Margin = Padding.Empty,
            AutoSize = true,
            Font = new Font("Arial", 15, FontStyle.Bold | FontStyle.Underline),
            ForeColor = Color.Blue
        };
        Label lbl_speechAnalysis = new Label
        {
            Text = Constants.LEFTPANE_SPEECHANALYSIS,
            AutoSize = true,
            Font = new Font("Arial", 15, FontStyle.Bold | FontStyle.Underline),
            ForeColor = Color.Blue
        };
        Label lbl_aoiAnalysis = new Label
        {
            Text = Constants.LEFTPANE_AOIANALYSIS,
            AutoSize = true,
            Font = new Font("Arial", 15, FontStyle.Bold | FontStyle.Underline),
            ForeColor = Color.Blue
        };
        Label lbl_summary = new Label
        {
            Text = Constants.LEFTPANE_SUMMARY,
            AutoSize = true,
            Font = new Font("Arial", 15, FontStyle.Bold | FontStyle.Underline),
            ForeColor = Color.Blue
        };

        FlowLayoutPanel options = new FlowLayoutPanel() { Dock = DockStyle.Fill, FlowDirection = FlowDirection.TopDown, WrapContents = false, AutoScroll = true };
        ColorDialog dialogColor = new ColorDialog();

        public HomeScreen()
        {


            speechAnalysisTab = new SpeechAnalysisTab(this);
            aoiAnalysisTab = new AOIAnalysisTab(this);
            summaryTab = new SummaryTab(this);

            walkthroughTree = new WalkthroughTree();

            speechAnalysisWalkthrougUI = new SpeechAnalysisWalkthroughUI(this);
            speechAnalysisWalkthrougUI.initializeController();
            aoiAnalysisWalkthroughUI = new AOIAnalysisWalkthroughUI(this);
            aoiAnalysisWalkthroughUI.initializeController();
            summaryWalkthroughUI = new SummaryWalkthroughUI(this);
            summaryWalkthroughUI.initializeController();

            Text = "MAGiC v1.0";
            this.Icon = global::MAGiC.Properties.Resources.icon;
            ClientSize = new System.Drawing.Size(1000, 700);
            //splitPane.Size = new System.Drawing.Size(1000, 1);
            //splitPane.SplitterDistance = 400;
            //splitPane.FixedPanel = FixedPanel.Panel1;

            ((System.ComponentModel.ISupportInitialize)(this.splitter)).BeginInit();
            this.splitter.SuspendLayout();
            SuspendLayout();

            this.splitter.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitter.Location = new System.Drawing.Point(0, 24);
            this.splitter.Name = "splitter";
            this.splitter.Size = new System.Drawing.Size(384, 237);
            //this.splitter.SplitterButtonBitmap = ((System.Drawing.Bitmap)(resources.GetObject("splitter.SplitterButtonBitmap")));
            this.splitter.SplitterButtonStyle = ButtonStyle.PushButton;
            this.splitter.SplitterDistance = 128;
            this.splitter.SplitterWidth = 22;
            this.splitter.TabIndex = 2;

            options.Controls.Add(lbl_steps);
            options.Controls.Add(lbl_speechAnalysis);
            options.Controls.Add(lbl_aoiAnalysis);
            options.Controls.Add(lbl_summary);
            this.Controls.Add(this.splitter);


            //---
            //splitPane.Panel1.Controls.Add(options);
            //splitPane.Panel2.Controls.Add(tc);
            splitter.Panel1.Controls.Add(options);
            splitter.Panel2.Controls.Add(tc);
            splitter.SplitterButtonStyle = ButtonStyle.ScrollBar;
            splitter.SplitterButtonPosition = ButtonPosition.Center;


            tc.TabPages.Add(tp_walkthrough);
            tc.TabPages.Add(tp_speechAnalysis);
            tc.TabPages.Add(tp_aoiAnalysis);
            tc.TabPages.Add(tp_summary);




            tp_walkthrough.Controls.Add(walkthroughHomeScreen());

            tp_speechAnalysis.Controls.Add(speechAnalysisTab);
            tp_aoiAnalysis.Controls.Add(aoiAnalysisTab);
            tp_summary.Controls.Add(summaryTab.getLayout());


            //---

            Accordion[] accs = new[] { speechAnalysisTab.acc, aoiAnalysisTab.acc, };
            foreach (var a in accs)
            {
                a.OpenOneOnly = true;
                a.Close(null);
            }


            //---
            lbl_speechAnalysis.Click += delegate
            {
                tc.SelectedTab = tp_speechAnalysis;

            };

            //---
            lbl_aoiAnalysis.Click += delegate
            {
                tc.SelectedTab = tp_aoiAnalysis;

            };

            //---
            lbl_summary.Click += delegate
            {
                tc.SelectedTab = tp_summary;

            };

            lbl_steps.Click += delegate
            {
                tc.SelectedTab = tp_walkthrough;

            };


            //---
            //Controls.Add(splitPane);
            tc.SelectedTab = tp_walkthrough;

            ((System.ComponentModel.ISupportInitialize)(this.splitter)).EndInit();
            this.splitter.ResumeLayout(false);
            ResumeLayout(true);

        }

        //public Control walkthroughScreen()
        //{
        //    TableLayoutPanel pnl_walkthrough = new TableLayoutPanel { Dock = DockStyle.Fill, AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink };
        //    pnl_walkthrough.Margin = new Padding(0);
        //    pnl_walkthrough.ColumnCount = 1;
        //    pnl_walkthrough.RowCount = 13;

        //    pnl_walkthrough.Controls.Add(new Label { Text = " ", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) }, 0, 0);
        //    pnl_walkthrough.Controls.Add(new Label { Text = "Speech Analysis", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) }, 0, 1);
        //    pnl_walkthrough.Controls.Add(walkthroughSpeechAnalysis, 0, 2);
        //    pnl_walkthrough.SetRowSpan(walkthroughSpeechAnalysis, 5);

        //    pnl_walkthrough.Controls.Add(new Label { Text = " ", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) }, 0, 7);
        //    pnl_walkthrough.Controls.Add(new Label { Text = "AOI Analysis", AutoSize = true, Font = new Font("Arial", 11, FontStyle.Bold) }, 0,8);
        //    pnl_walkthrough.Controls.Add(walkthroughAOIAnalysis, 0, 9);
        //    pnl_walkthrough.SetRowSpan(walkthroughAOIAnalysis, 5);

        //    return pnl_walkthrough;
        //}

        public Control walkthroughHomeScreen()
        {
            TableLayoutPanel pnl_main_faceTrackingWithDefaultDetector = new TableLayoutPanel { Dock = DockStyle.Fill, Size = new Size(800, 800), AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_main_faceTrackingWithDefaultDetector.Margin = new Padding(0);
            pnl_main_faceTrackingWithDefaultDetector.ColumnCount = 1;
            pnl_main_faceTrackingWithDefaultDetector.RowCount = 1;


            TreeView tv = walkthroughTree.treeView;


            tv.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(tv_NodeMouseClick);

            pnl_main_faceTrackingWithDefaultDetector.Controls.Add(tv);
            return tv;
            //tp_walkthrough.Controls.Add(pnl_main_faceTrackingWithDefaultDetector);


            //tc.TabPages.Insert(1, tp_walkthrough);
            //tc.TabPages.RemoveAt(0);
            //tc.SelectedTab = tp_walkthrough;
        }

        private void tv_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            tp_walkthrough_nodes = new TabPage("Walkthrough");

            bool changeWalkthrouhPage = createWalkthrougPage(e, walkthroughTree);

            if (changeWalkthrouhPage)
            {
                tc.TabPages.Insert(1, tp_walkthrough_nodes);
                tc.TabPages.RemoveAt(0);
                tc.SelectedTab = tp_walkthrough_nodes;
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

                tp_walkthrough_nodes.Controls.Add(pnl_extractAndFormatAudio);
                changeWalkthrouhPage = true;

            }
            else if (e.Node == walkthroughTree.node_analysis_speech_segmentAudio)
            {

                /*Segment Audio*/
                /**************************************************************************/
                TableLayoutPanel pnl_SegmentAudio = speechAnalysisWalkthrougUI.getSegmentAudioWalkthroughLayout();
                /*End of Segment Audio*/

                tp_walkthrough_nodes.Controls.Add(pnl_SegmentAudio);
                changeWalkthrouhPage = true;

            }
            else if (e.Node == walkthroughTree.node_analysis_speech_timeIntervalEstimation)
            {


                /*Time Interval Specification (also,Synchronization for Multiple Recordings) Tab*/
                /**************************************************************************/
                TableLayoutPanel pnl_specifyTimeInterval = speechAnalysisWalkthrougUI.getSpecifyTimeIntervalWalkthroughLayout();
                /*End of Time Interval Specification (also, Synchronization for Multiple Recordings) Tab*/

                tp_walkthrough_nodes.Controls.Add(pnl_specifyTimeInterval);
                changeWalkthrouhPage = true;

            }
            else if (e.Node == walkthroughTree.node_analysis_speech_speechAnnotation_defineSpeechActs)
            {

                /*DefineSpeechAct Tab*/
                /**************************************************************************/
                TableLayoutPanel pnl_defineSpeechAct = speechAnalysisWalkthrougUI.getDefineSpeechActWalkthroughLayout();
                /*DefineSpeechActTab*/

                tp_walkthrough_nodes.Controls.Add(pnl_defineSpeechAct);
                changeWalkthrouhPage = true;
            }
            else if (e.Node == walkthroughTree.node_analysis_speech_speechAnnotation_annotation)
            {

                /*Annotation Tab*/
                /**************************************************************************/
                TableLayoutPanel pnl_annotation = speechAnalysisWalkthrougUI.getAnnotationWalkthroughLayout();
                /*Annotation Tab*/

                tp_walkthrough_nodes.Controls.Add(pnl_annotation);
                changeWalkthrouhPage = true;
            }

            else if (e.Node == walkthroughTree.node_analysis_aoi_faceTracking_defaultDetector)
            {

                /*Face Tracking With Default Detector Tab*/
                /**************************************************************************/
                TableLayoutPanel pnl_faceTrackingWithDefaultDetector = aoiAnalysisWalkthroughUI.getFaceTrackingWithDefaultDetectorWalkthroughLayout();
                /*End of Face Tracking With Default Detector*/

                tp_walkthrough_nodes.Controls.Add(pnl_faceTrackingWithDefaultDetector);
                changeWalkthrouhPage = true;

            }
            else if (e.Node == walkthroughTree.node_analysis_aoi_faceTracking_trainedDetector)
            {

                /*Face Tracking With Trained Detector Tab*/
                /**************************************************************************/
                TableLayoutPanel pnl_faceTrackingWithTrainedDetector = aoiAnalysisWalkthroughUI.getFaceTrackingWithTrainedDetectorWalkthroughLayout();
                /*End of Face Tracking With Default Detector*/

                tp_walkthrough_nodes.Controls.Add(pnl_faceTrackingWithTrainedDetector);
                changeWalkthrouhPage = true;

            }
            else if (e.Node == walkthroughTree.node_analysis_aoi_aoiAnaylse_preProcessGazeData)
            {

                TableLayoutPanel pnl_preProcessGazeData = aoiAnalysisWalkthroughUI.getPreProcessGazeDataWalkthroughLayout();
                tp_walkthrough_nodes.Controls.Add(pnl_preProcessGazeData);
                changeWalkthrouhPage = true;

            }
            else if (e.Node == walkthroughTree.node_analysis_aoi_aoiAnaylse_faceasAOI)
            {

                TableLayoutPanel pnl_detectAOI = aoiAnalysisWalkthroughUI.getDetectAOIWalkthroughLayout();
                tp_walkthrough_nodes.Controls.Add(pnl_detectAOI);
                changeWalkthrouhPage = true;

            }
            else if (e.Node == walkthroughTree.node_analysis_aoi_reviewOutcomes_visualizeTracking)
            {

                TableLayoutPanel pnl_visualizeTracking = aoiAnalysisWalkthroughUI.getVisualizeTrackingWalkthroughLayout();
                tp_walkthrough_nodes.Controls.Add(pnl_visualizeTracking);
                changeWalkthrouhPage = true;

            }
            else if (e.Node == walkthroughTree.node_analysis_aoi_reviewOutcomes_findAOIsDetectionRatio)
            {

                TableLayoutPanel pnl_findDetectionRatio = aoiAnalysisWalkthroughUI.getFindDetectionRatioWalkthroughLayout();
                tp_walkthrough_nodes.Controls.Add(pnl_findDetectionRatio);
                changeWalkthrouhPage = true;

            }
            else if (e.Node == walkthroughTree.node_analysis_aoi_reviewOutcomes_labelAOIsManually)
            {

                TableLayoutPanel pnl_labelAOIManually = aoiAnalysisWalkthroughUI.getLabelAOIManuallyWalkthroughLayout();
                tp_walkthrough_nodes.Controls.Add(pnl_labelAOIManually);
                changeWalkthrouhPage = true;

            }

            else if (e.Node == walkthroughTree.node_analysis_aoi_reviewOutcomes_reanalyseAOIs)
            {

                TableLayoutPanel pnl_reanalyseAOI = aoiAnalysisWalkthroughUI.getReanalyseAOIWalkthroughLayout();
                tp_walkthrough_nodes.Controls.Add(pnl_reanalyseAOI);
                changeWalkthrouhPage = true;

            }

            else if (e.Node == walkthroughTree.node_analysis_summary)
            {

                TableLayoutPanel pnl_summary = summaryWalkthroughUI.getLayout();
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

                Controls.Add(acc);

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


                Controls.Add(acc);

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
            tc.SelectedTab = tp_speechAnalysis;
            speechAnalysisTab.selectExtactAndFormatAudioItem();

        }

        public void navigateToSegmentAudio()
        {
            tc.SelectedTab = tp_speechAnalysis;
            speechAnalysisTab.selectSegmentAudioItem();
        }

        public void navigateToSpecifyTimeInterval()
        {
            tc.SelectedTab = tp_speechAnalysis;
            speechAnalysisTab.selectSpecifyTimeIntervalItem();
        }

        public void navigateToDefineSpeechAct()
        {
            tc.SelectedTab = tp_speechAnalysis;
            speechAnalysisTab.selectDefineSpeechActItem();
        }

        public void navigateToAnnotation()
        {
            tc.SelectedTab = tp_speechAnalysis;
            speechAnalysisTab.selectAnnotationItem();
        }

        //AOI analysis
        public void navigateToFaceTrackingWithDefaultDetector()
        {
            tc.SelectedTab = tp_aoiAnalysis;
            aoiAnalysisTab.selectFaceTrackingWithDefaultDetectorItem();
        }
        public void navigateToFaceTrackingWithTrainedDetector()
        {
            tc.SelectedTab = tp_aoiAnalysis;
            aoiAnalysisTab.selectFaceTrackingWithTrainedDetectorItem();
        }
        public void navigateToPreProcessGazeData()
        {
            tc.SelectedTab = tp_aoiAnalysis;
            aoiAnalysisTab.selectPreProcessGazeDataItem();
        }
        public void navigateToDetectAOI()
        {
            tc.SelectedTab = tp_aoiAnalysis;
            aoiAnalysisTab.selectDetectAOIItem();
        }
        public void navigateToVisualizeTrackingResults()
        {
            tc.SelectedTab = tp_aoiAnalysis;
            aoiAnalysisTab.selectVisualizeTrackingResultsItem();
        }
        public void navigateToFindDetectionRatio()
        {
            tc.SelectedTab = tp_aoiAnalysis;
            aoiAnalysisTab.selectFindDetectionRatioItem();
        }
        public void navigateToLabelAOIManually()
        {
            tc.SelectedTab = tp_aoiAnalysis;
            aoiAnalysisTab.selectLabelAOIManuallyItem();
        }
        public void navigateToReanalyseAOI()
        {
            tc.SelectedTab = tp_aoiAnalysis;
            aoiAnalysisTab.selectReanalyseAOIItem();
        }

        public void navigateToSummary()
        {
            tc.SelectedTab = tp_summary;

        }

        public void navigateToWalkthroughHome()
        {
            tc.SelectedTab = tp_aoiAnalysis;

            tc.TabPages.Insert(1, tp_walkthrough);
            tc.TabPages.RemoveAt(0);
            tc.SelectedTab = tp_walkthrough;
        }

        public void navigateToExtractFormatAudioWalkthrough()
        {
            TreeNodeMouseClickEventArgs e = new TreeNodeMouseClickEventArgs(walkthroughTree.node_analysis_speech_extractFormatAudio, new MouseButtons(), 0, 0, 0);
            tv_NodeMouseClick(new object(), e);
        }

        public void navigateToSegmentAudioWalkthrough()
        {
            TreeNodeMouseClickEventArgs e = new TreeNodeMouseClickEventArgs(walkthroughTree.node_analysis_speech_segmentAudio, new MouseButtons(), 0, 0, 0);
            tv_NodeMouseClick(new object(), e);
        }

        public void navigateToSpecifyTimeIntervalWalkthrough()
        {
            TreeNodeMouseClickEventArgs e = new TreeNodeMouseClickEventArgs(walkthroughTree.node_analysis_speech_timeIntervalEstimation, new MouseButtons(), 0, 0, 0);
            tv_NodeMouseClick(new object(), e);
        }

        public void navigateToDefineSpeechActWalkthrough()
        {
            TreeNodeMouseClickEventArgs e = new TreeNodeMouseClickEventArgs(walkthroughTree.node_analysis_speech_speechAnnotation_defineSpeechActs, new MouseButtons(), 0, 0, 0);
            tv_NodeMouseClick(new object(), e);
        }

        public void navigateToAnnotationWalkthrough()
        {
            TreeNodeMouseClickEventArgs e = new TreeNodeMouseClickEventArgs(walkthroughTree.node_analysis_speech_speechAnnotation_annotation, new MouseButtons(), 0, 0, 0);
            tv_NodeMouseClick(new object(), e);
        }

        public void navigateToFaceTrackingWithDefaultDetectorWalkthrough()
        {
            TreeNodeMouseClickEventArgs e = new TreeNodeMouseClickEventArgs(walkthroughTree.node_analysis_aoi_faceTracking_defaultDetector, new MouseButtons(), 0, 0, 0);
            tv_NodeMouseClick(new object(), e);
        }

        public void navigateToFaceTrackingWithTrainedDetectorWalkthrough()
        {
            TreeNodeMouseClickEventArgs e = new TreeNodeMouseClickEventArgs(walkthroughTree.node_analysis_aoi_faceTracking_trainedDetector, new MouseButtons(), 0, 0, 0);
            tv_NodeMouseClick(new object(), e);
        }

        public void navigateToPreProcessGazeDataWalkthrough()
        {
            TreeNodeMouseClickEventArgs e = new TreeNodeMouseClickEventArgs(walkthroughTree.node_analysis_aoi_aoiAnaylse_preProcessGazeData, new MouseButtons(), 0, 0, 0);
            tv_NodeMouseClick(new object(), e);
        }

        public void navigateToDetectAOIWalkthrough()
        {
            TreeNodeMouseClickEventArgs e = new TreeNodeMouseClickEventArgs(walkthroughTree.node_analysis_aoi_aoiAnaylse_faceasAOI, new MouseButtons(), 0, 0, 0);
            tv_NodeMouseClick(new object(), e);
        }

        public void navigateToVisualizeTrackingResultsWalkthrough()
        {
            TreeNodeMouseClickEventArgs e = new TreeNodeMouseClickEventArgs(walkthroughTree.node_analysis_aoi_reviewOutcomes_visualizeTracking, new MouseButtons(), 0, 0, 0);
            tv_NodeMouseClick(new object(), e);
        }

        public void navigateToFindDetectionRatioWalkthrough()
        {
            TreeNodeMouseClickEventArgs e = new TreeNodeMouseClickEventArgs(walkthroughTree.node_analysis_aoi_reviewOutcomes_findAOIsDetectionRatio, new MouseButtons(), 0, 0, 0);
            tv_NodeMouseClick(new object(), e);
        }

        public void navigateToLabelAOIManuallyWalkthrough()
        {
            TreeNodeMouseClickEventArgs e = new TreeNodeMouseClickEventArgs(walkthroughTree.node_analysis_aoi_reviewOutcomes_labelAOIsManually, new MouseButtons(), 0, 0, 0);
            tv_NodeMouseClick(new object(), e);
        }

        public void navigateToReanalyseAOIWalkthrough()
        {
            TreeNodeMouseClickEventArgs e = new TreeNodeMouseClickEventArgs(walkthroughTree.node_analysis_aoi_reviewOutcomes_reanalyseAOIs, new MouseButtons(), 0, 0, 0);
            tv_NodeMouseClick(new object(), e);
        }

        public void navigateToSummaryWalkthrough()
        {
            TreeNodeMouseClickEventArgs e = new TreeNodeMouseClickEventArgs(walkthroughTree.node_analysis_summary, new MouseButtons(), 0, 0, 0);
            tv_NodeMouseClick(new object(), e);
        }


    }
}
