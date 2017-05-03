using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAGiC
{
    public class WalkthroughTree
    {
        public TreeNode node_analysis, node_analysis_speech, node_analysis_speech_extractFormatAudio, node_analysis_speech_segmentAudio, node_analysis_speech_timeIntervalEstimation,
            node_analysis_speech_speechAnnotation, node_analysis_speech_speechAnnotation_defineSpeechActs, node_analysis_speech_speechAnnotation_annotation, node_analysis_aoi,
            node_analysis_aoi_faceTracking, node_analysis_aoi_faceTracking_defaultDetector, node_analysis_aoi_faceTracking_trainedDetector, node_analysis_aoi_aoiAnaylse,
            node_analysis_aoi_aoiAnaylse_preProcessGazeData, node_analysis_aoi_aoiAnaylse_faceasAOI, node_analysis_aoi_reviewOutcomes, node_analysis_aoi_reviewOutcomes_visualizeTracking,
            node_analysis_aoi_reviewOutcomes_findAOIsDetectionRatio, node_analysis_aoi_reviewOutcomes_labelAOIsManually, node_analysis_aoi_reviewOutcomes_reanalyseAOIs, node_analysis_summary;





        public WalkthroughTree()
        {
            //treeView=createTree();
        }

        public void ensureDefaultImageIndex(CustomTree treeView)
        {
            if (treeView.ImageList != null)
            {
                treeView.ImageIndex = treeView.ImageList.Images.Count;
                treeView.SelectedImageIndex = treeView.ImageList.Images.Count;
            }
        }

        public TreeView loadTree(CustomTree treeView)
        {

            //tv.ForeColor = Color.Black;
            treeView.BackColor = Color.WhiteSmoke;
            Font f = new Font("Arial", 12, FontStyle.Bold);
            treeView.Font = f;
            treeView.Dock = DockStyle.Fill;


            node_analysis = new TreeNode();
            node_analysis.Name = "analysis";
            node_analysis.Text = "Analysis";
            node_analysis.ForeColor = Constants.rootColor;

          

            node_analysis_speech = new TreeNode();
            node_analysis_speech.Name = "SpeechAnalysis";
            node_analysis_speech.Text = "Speech Analysis";
            node_analysis_speech.ForeColor = Constants.firstLevelColor;
            node_analysis.Nodes.Add(node_analysis_speech);
        

            node_analysis_speech_extractFormatAudio = new TreeNode();
            node_analysis_speech_extractFormatAudio.Name = "ExtractFormatAudio";
            node_analysis_speech_extractFormatAudio.Text = "Extract and Format Audio";
            node_analysis_speech.Nodes.Add(node_analysis_speech_extractFormatAudio);
            node_analysis_speech_extractFormatAudio.ForeColor = Constants.secondLevelColor;
            node_analysis_speech_extractFormatAudio.ImageKey = "clickableItem";
            node_analysis_speech_extractFormatAudio.SelectedImageIndex = 0;

            node_analysis_speech_segmentAudio = new TreeNode();
            node_analysis_speech_segmentAudio.Name = "SegmentAudio";
            node_analysis_speech_segmentAudio.Text = "Segment Audio";
            node_analysis_speech.Nodes.Add(node_analysis_speech_segmentAudio);
            node_analysis_speech_segmentAudio.ForeColor = Constants.secondLevelColor;
            node_analysis_speech_segmentAudio.ImageKey = "clickableItem";

            node_analysis_speech_timeIntervalEstimation = new TreeNode();
            node_analysis_speech_timeIntervalEstimation.Name = "TimeIntervalEstimation";
            node_analysis_speech_timeIntervalEstimation.Text = "Time Interval Estimation (also, Syncronization for Multiple Recordings)";
            node_analysis_speech.Nodes.Add(node_analysis_speech_timeIntervalEstimation);
            node_analysis_speech_timeIntervalEstimation.ForeColor = Constants.secondLevelColor;
            node_analysis_speech_timeIntervalEstimation.ImageKey = "clickableItem";


            node_analysis_speech_speechAnnotation = new TreeNode();
            node_analysis_speech_speechAnnotation.Name = "SpeechAnnotation";
            node_analysis_speech_speechAnnotation.Text = "Speech Annotation";
            node_analysis_speech.Nodes.Add(node_analysis_speech_speechAnnotation);
            node_analysis_speech_speechAnnotation.ForeColor = Constants.secondLevelColor;

            node_analysis_speech_speechAnnotation_defineSpeechActs = new TreeNode();
            node_analysis_speech_speechAnnotation_defineSpeechActs.Name = "DefineSpeechActs";
            node_analysis_speech_speechAnnotation_defineSpeechActs.Text = "Define Speech-Acts";
            node_analysis_speech_speechAnnotation.Nodes.Add(node_analysis_speech_speechAnnotation_defineSpeechActs);
            node_analysis_speech_speechAnnotation_defineSpeechActs.ForeColor = Constants.thirdLevelColor;
            node_analysis_speech_speechAnnotation_defineSpeechActs.ImageKey = "clickableItem";

            node_analysis_speech_speechAnnotation_annotation = new TreeNode();
            node_analysis_speech_speechAnnotation_annotation.Name = "Annotation";
            node_analysis_speech_speechAnnotation_annotation.Text = "Annotation";
            node_analysis_speech_speechAnnotation.Nodes.Add(node_analysis_speech_speechAnnotation_annotation);
            node_analysis_speech_speechAnnotation_annotation.ForeColor = Constants.thirdLevelColor;
            node_analysis_speech_speechAnnotation_annotation.ImageKey = "clickableItem";

            node_analysis_aoi = new TreeNode();
            node_analysis_aoi.Name = "AOIAnalysis";
            node_analysis_aoi.Text = "AOI Analysis";
            node_analysis.Nodes.Add(node_analysis_aoi);
            node_analysis_aoi.ForeColor = Constants.firstLevelColor;

            node_analysis_aoi_faceTracking = new TreeNode();
            node_analysis_aoi_faceTracking.Name = "FaceTracking";
            node_analysis_aoi_faceTracking.Text = "Face Tracking";
            node_analysis_aoi.Nodes.Add(node_analysis_aoi_faceTracking);
            node_analysis_aoi_faceTracking.ForeColor = Constants.secondLevelColor;

            node_analysis_aoi_faceTracking_defaultDetector = new TreeNode();
            node_analysis_aoi_faceTracking_defaultDetector.Name = "FaceTrackingDefaultDetector";
            node_analysis_aoi_faceTracking_defaultDetector.Text = "Face Tracking (wtih default detector)";
            node_analysis_aoi_faceTracking.Nodes.Add(node_analysis_aoi_faceTracking_defaultDetector);
            node_analysis_aoi_faceTracking_defaultDetector.ForeColor = Constants.thirdLevelColor;
            node_analysis_aoi_faceTracking_defaultDetector.ImageKey = "clickableItem";

            node_analysis_aoi_faceTracking_trainedDetector = new TreeNode();
            node_analysis_aoi_faceTracking_trainedDetector.Name = "FaceTrackingTrainedDetector";
            node_analysis_aoi_faceTracking_trainedDetector.Text = "Face Tracking (with trained detector)";
            node_analysis_aoi_faceTracking.Nodes.Add(node_analysis_aoi_faceTracking_trainedDetector);
            node_analysis_aoi_faceTracking_trainedDetector.ForeColor = Constants.thirdLevelColor;
            node_analysis_aoi_faceTracking_trainedDetector.ImageKey = "clickableItem";

            node_analysis_aoi_aoiAnaylse = new TreeNode();
            node_analysis_aoi_aoiAnaylse.Name = "AOIAnaylse";
            node_analysis_aoi_aoiAnaylse.Text = "AOI Anaylse";
            node_analysis_aoi.Nodes.Add(node_analysis_aoi_aoiAnaylse);
            node_analysis_aoi_aoiAnaylse.ForeColor = Constants.secondLevelColor;

            node_analysis_aoi_aoiAnaylse_preProcessGazeData = new TreeNode();
            node_analysis_aoi_aoiAnaylse_preProcessGazeData.Name = "PreProcessGazeData";
            node_analysis_aoi_aoiAnaylse_preProcessGazeData.Text = "Pre-Process Gaze Data";
            node_analysis_aoi_aoiAnaylse.Nodes.Add(node_analysis_aoi_aoiAnaylse_preProcessGazeData);
            node_analysis_aoi_aoiAnaylse_preProcessGazeData.ForeColor = Constants.thirdLevelColor;
            node_analysis_aoi_aoiAnaylse_preProcessGazeData.ImageKey = "clickableItem";

            node_analysis_aoi_aoiAnaylse_faceasAOI = new TreeNode();
            node_analysis_aoi_aoiAnaylse_faceasAOI.Name = "FaceasAOI";
            node_analysis_aoi_aoiAnaylse_faceasAOI.Text = "Face as AOI";
            node_analysis_aoi_aoiAnaylse.Nodes.Add(node_analysis_aoi_aoiAnaylse_faceasAOI);
            node_analysis_aoi_aoiAnaylse_faceasAOI.ForeColor = Constants.thirdLevelColor;
            node_analysis_aoi_aoiAnaylse_faceasAOI.ImageKey = "clickableItem";

            node_analysis_aoi_reviewOutcomes = new TreeNode();
            node_analysis_aoi_reviewOutcomes.Name = "ReviewOutcomes";
            node_analysis_aoi_reviewOutcomes.Text = "Review Outcomes";
            node_analysis_aoi.Nodes.Add(node_analysis_aoi_reviewOutcomes);
            node_analysis_aoi_reviewOutcomes.ForeColor = Constants.secondLevelColor;

            node_analysis_aoi_reviewOutcomes_visualizeTracking = new TreeNode();
            node_analysis_aoi_reviewOutcomes_visualizeTracking.Name = "VisualizeTracking";
            node_analysis_aoi_reviewOutcomes_visualizeTracking.Text = "Visualize Tracking";
            node_analysis_aoi_reviewOutcomes.Nodes.Add(node_analysis_aoi_reviewOutcomes_visualizeTracking);
            node_analysis_aoi_reviewOutcomes_visualizeTracking.ForeColor = Constants.thirdLevelColor;
            node_analysis_aoi_reviewOutcomes_visualizeTracking.ImageKey = "clickableItem";

            node_analysis_aoi_reviewOutcomes_findAOIsDetectionRatio = new TreeNode();
            node_analysis_aoi_reviewOutcomes_findAOIsDetectionRatio.Name = "FindAOIsDetectionRatio";
            node_analysis_aoi_reviewOutcomes_findAOIsDetectionRatio.Text = "Find AOIs Detection Ratio";
            node_analysis_aoi_reviewOutcomes.Nodes.Add(node_analysis_aoi_reviewOutcomes_findAOIsDetectionRatio);
            node_analysis_aoi_reviewOutcomes_findAOIsDetectionRatio.ForeColor = Constants.thirdLevelColor;
            node_analysis_aoi_reviewOutcomes_findAOIsDetectionRatio.ImageKey = "clickableItem";


            node_analysis_aoi_reviewOutcomes_labelAOIsManually = new TreeNode();
            node_analysis_aoi_reviewOutcomes_labelAOIsManually.Name = "LabelAOIsManually";
            node_analysis_aoi_reviewOutcomes_labelAOIsManually.Text = "Label AOIs Manually";
            node_analysis_aoi_reviewOutcomes.Nodes.Add(node_analysis_aoi_reviewOutcomes_labelAOIsManually);
            node_analysis_aoi_reviewOutcomes_labelAOIsManually.ForeColor = Constants.thirdLevelColor;
            node_analysis_aoi_reviewOutcomes_labelAOIsManually.ImageKey = "clickableItem";


            node_analysis_aoi_reviewOutcomes_reanalyseAOIs = new TreeNode();
            node_analysis_aoi_reviewOutcomes_reanalyseAOIs.Name = "ReanalyseAOIs";
            node_analysis_aoi_reviewOutcomes_reanalyseAOIs.Text = "Re-analyse AOIs(considering manually labeled AOIs)";
            node_analysis_aoi_reviewOutcomes.Nodes.Add(node_analysis_aoi_reviewOutcomes_reanalyseAOIs);
            node_analysis_aoi_reviewOutcomes_reanalyseAOIs.ForeColor = Constants.thirdLevelColor;
            node_analysis_aoi_reviewOutcomes_reanalyseAOIs.ImageKey = "clickableItem";

            node_analysis_summary = new TreeNode();
            node_analysis_summary.Name = "Summary";
            node_analysis_summary.Text = "Summary";
            node_analysis.Nodes.Add(node_analysis_summary);
            node_analysis_summary.ForeColor = Constants.firstLevelColor;
            node_analysis_summary.ImageKey = "clickableItem";

            treeView.Nodes.Add(node_analysis);
            treeView.ExpandAll();

            return treeView;
        }
    }
}
