using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAGiC
{
    public class Constants
    {

        //LEFTPANE
        public static string LEFTPANE_HOME = "Home";
        public static string LEFTPANE_SPEECHANALYSIS = "\n\n1) Speech Analysis";
        public static string LEFTPANE_AOIANALYSIS = "\n\n2) AOI Analysis";
        public static string LEFTPANE_SUMMARY = "\n\n3) Summary";

        //MESSAGES
        public static string MESSAGE_ENTER_SPEECH_ACT = "Please Enter Speech-Act";
        public static string MESSAGE_SELECT_OUTPUT_FOLDER = "Please Select Output Folder";
        public static string MESSAGE_SELECT_WAV_FILE = "Please Select Formatted Wav File";
        public static string MESSAGE_SELECT_AVI_FILE = "Please Select Avi File";
        public static string MESSAGE_SELECT_OUTPUT_FILE = "Please Select Output File";
        public static string MESSAGE_SELECT_AVI_FOLDER = "Please Select Avi Folder";
        public static string MESSAGE_SELECT_SEGMENTS_INTERVAL_FILE = "Please Select Segments Interval File";
        public static string MESSAGE_ENTER_POSITIVE_INTEGER_VALUE = "Please Enter Positive Integer Value";
        public static string MESSAGE_ENTER_DOUBLE_VALUE = "Please Enter Double Value";
        public static string MESSAGE_BASE_FOLDER_SELECTED = "Base Folder Selected";
        public static string MESSAGE_ENTER_GREATER_VALUE = "Second value should be greater than the first one";
        public static string MESSAGE_SELECT_ONE_OF_PARTICIPANT = "Please select one of the partiicpant in the pair";
        public static string MESSAGE_LOAD_AUDIO_FILES = "Please Load Audio Files";
        public static string MESSAGE_LOAD_SEGMENTS_INTERVAL_OF_LOADED_AUDIO_FILES = "Please Load Segments-Interval File of Loaded Audio Files";
        public static string MESSAGE_SELECT_AUDIO_FILE = "Please Select Audio File to Annotate";
        public static string MESSAGE_SELECT_SPEECH_ACT = "Please Select Speech-Act(s)  to Annotate Selected Audio File";
        public static string MESSAGE_SELECT_TRAINING_IMAGE_FILE = "Please Select Training Image File(s) ";
        public static string MESSAGE_SELECT_TESTING_IMAGE_FILE = "Please Select Testing Image File(s)";
        public static string MESSAGE_SELECT_RAW_GAZE_DATA_FILE = "Please Select Raw Gaze-Data File";
        public static string MESSAGE_SELECT_2dLANDMARK_FILE = "Please Select 2dlandmark File";
        public static string MESSAGE_SELECT_IMAGE_SIZE_TRACKING_FRAMEWORK_FILE = "Please select file involvingimage size that tracking framework working on it";
        public static string MESSAGE_ENTER_EYE_TRACKER_IMAGE_RESOLUTION = "Please Enter Eye Tracker Image Resolution (Width-Height)";
        public static string MESSAGE_SELECT_EXPERIMENT_INTERVAL_FILE = "Please Select Experiment Interval File";
        public static string MESSAGE_SELECT_AOI_FILE = "Please Select AOI File";
        public static string MESSAGE_SELECT_EXISTING_AOI_FILE = "Please Select Existing AOIs File";
        public static string MESSAGE_ENTER_NUMBER_BETWEEN_0_1 = "Enter a number between 0 and 1";
        public static string MESSAGE_SELECT_MANUALLY_LABELLED_AOIs_FILE = "Please Select Manually Labelled AOIs File";
        public static string MESSAGE_SELECT_SPEECHANNOTATION_FILE = "Please Select Speech-Annotation File";

        public static string ERROR_JAVA_CALL = "Java error is thrown. Please review the walkhthroug to provide prerequiset for running Java app!";
        public static string ERROR_FILE_FORMAT_IS_WRONG = "Selected File format is wrong, please read the walkthrough to see the expected file format!";


        public static string BASE_FOLDER = "";
        public static string FILE_NAME_SPEECH_ACTS = "SpeechActs.txt";



        //TOOLTIP
        public static string TOOLTIP_ENTER_POSITIVE_INTEGER_VALUE = "Please enter a valid positive integer value.";
        public static string TOOLTIP_OUTPUTFOLDER_FILE = "Please make sure that the path does not contain spaces or unusual characters. \r\nE.g. 'C://Program Files// is a wrong path because of a space character inside 'Program Files'";
        public static string TOOLTIP_OUTPUTFILE_CREATEORLOAD = "Create a new file or open an existing file. \r\nPlease make sure that the path does not contain spaces or unusual characters. \r\nE.g. 'C://Program Files// is a wrong path because of a space character inside 'Program Files'";
        public static string TOOLTIP_VIDEORECORDING = "Please select a video recording in avi format.";
        public static string TOOLTIP_AUDIOFILE = "Please select an audio file that was generated in the previous 'Extract and Format Audio' step.";
        public static string TOOLTIP_ENTER_DECIMAL_VALUE_BETWEEN_O_1 = "Please enter a decimal value between 0 and 1.";
        public static string TOOLTIP_EXP_INTERVAL = "Please enter the starting and ending audio names without extension. E.g. 3 - 150";
        public static string TOOLTIP_SELECT_ACTOR_OF_SPEECH_ACT = "Select which participant performs the selected speech-act(s). \r\nYou can choose empty option if speech-act is not associated with any participants. ";
        public static string TOOLTIP_LISTOF_AUDIO_FILES = "List of audio files";
        public static string TOOLTIP_LISTOF_SPEECHACTS = "List of speech-acts";
        public static string TOOLTIP_OUTPUTFILE_CONTENT = "This is an editable field. \r\nYou can re-arrange the text that will be stored as an output file.";
        public static string TOOLTIP_SEGMENTSINTERVAL_FILE = "This file was generated in the previous 'Segment Audio' step. \r\nIt was automatically named 'segments_interval.txt'. \r\nYou can visit the related walkthrough page to see the file format.";
        public static string TOOLTIP_PARTICIPANTID = "Please enter a unique positive integer value.";
        public static string TOOLTIP_MULTIPLE_SELECTION = "Multiple selection is available";
        public static string TOOLTIP_ANNOTATE = "Annotate";
        public static string TOOLTIP_ANNOTATE_PLAYNEXT = "Annotate and Play Next File";
        public static string TOOLTIP_LOADSEGMENTSINERVAL = "Load Segments-Interval File of Loaded Audio Files";
        public static string TOOLTIP_SPEECHANNOTATION_FILE = "Please select a speech-annotation file";

        public static string TOOLTIP_LISTOF_TRAININGIMAGES = "Please select images for training";
        public static string TOOLTIP_LISTOF_TESTINGIMAGES = "Please select images for testing";
        public static string TOOLTIP_RAWGAZEDATA_FILE = "Please select a raw gaze-dat file extracted from an eye tracker. \r\nYou can visit the related walkthrough page to see the file format.";
        public static string TOOLTIP_2dLANDMARK_FILE = "Please select 2d-landmark file. \r\nIt was obtained during face tracking. \r\nYou can visit the related walkthrough page to see the file format.";
        public static string TOOLTIP_IMAGESIZE_FILE = "Please select width-height text file. \r\nIt was obtained during face tracking. \r\nYou can visit the related walkthrough page to see the file format.";
        public static string TOOLTIP_IMAGESIZE = "Please enter Size of an image captured from an eye tracker in pixels (width-height)";
        public static string TOOLTIP_FIXATION_ERRORSIZE = "Please enter the Fixation-Error in pixels. \r\nIt is specific to the eye tracker device and \r\nrespresents the difference between estimated point of regard and true location";
        public static string TOOLTIP_AOI_FILE = "Please select AOIs file. \r\nIt was obtained during AOIs analyse. \r\nYou can visit the related walkthrough page to see the file format.";
        public static string TOOLTIP_CONFIDENCE_THRESHOLD = "Please enter Confidence threshold of face detection certainty. \r\nIt is a decimal value between 0 to 1, where 1 represents highest certainty";
        public static string TOOLTIP_EXPINTERVAL_FILE = "Please select Experiment Interval File. \r\nIt was obtained after execution of 'Time Interval Estimation' \r\nunder Speech Analysis Module with the name 'exp_time_interval'";
        public static string TOOLTIP_WHICHPARTICIPANT_INEXPINTERVALFILE = "Please choose the participant wearing eye glasses that record the selected video file.'";
        public static string TOOLTIP_PARTICIPANTID_INEXPINTERVALFILE = "Please enter Participant Id as written in Experiment Interval File";
        public static string TOOLTIP_MANUALLYLABELLED_AOI = "Please select manually labelled AOIs File. \r\nIt is the output of 'Label AOIs Manually' function.";


        //re-segment
        public static string base_file_path = "";
        public static string ref_file_path = "";
        public static string output_path_resegment = "";
        public static string starting_segment_num_base = "", starting_segment_num_ref = "";
        public static string ending_segment_num_base = "", ending_segment_num_ref = "";
        public static int synchronize_base = 0, synchronize_ref = 0;


        public static string EyeTrackerEmptyLineTxt = "Unclassified";
        public static string EyeTrackerNotEmptyLineTxt = "Fixation";

        public static string FaceDetectionEmpty = "FaceDetectionEmpty";
        public static string BothFaceDetectionGazeRawDataEmpty = "BothFaceDetectionGazeRawDataEmpty";
        public static string GazeRawDataEmpty = "GazeRawDataEmpty";


        public static string left_eye = "left_eye";
        public static string right_eye = "right_eye";
        public static string eye_rect = "eye_rect";
        public static string face = "face";
        public static string nose = "nose";
        public static string nose_rect = "nose_rect";
        public static string mouth = "mouth";
        public static string mouth_rect = "mouth_rect";
        public static int offset_x = 0;
        public static int offset_y = 0;

        public static string AOI_a = "a";
        public static string AOI_b = "b";
        public static string AOI_c = "c";
        public static string AOI_d = "d";
        public static string AOI_e = "e";
        public static string AOI_f = "f";
        public static string AOI_g = "g";
        public static string AOI_h = "h";
        public static string AOI_i = "i";


        //TREE NODE COLORS
        public static Color thirdLevelColor = Color.FromArgb(134, 190, 203);
        public static Color secondLevelColor = Color.FromArgb(26, 163, 163);
        public static Color firstLevelColor = Color.FromArgb(11, 94, 86);
        public static Color rootColor = Color.FromArgb(5, 41, 38);


        //walkthrough titles
        public static string WalkthroughTitleExtractFormatAudio = " Walkthrough - Extract and Format Audio";
        public static string WalkthroughTitleSegmentAudio = "Walkthrough - Segment Audio";
        public static string WalkthroughTitleTimeIntervalEstimation = "Walkthrough - Time Interval Estimation & Synchronization";
        public static string WalkthroughTitleDefineSpeechActs = "Walkthrough - Define Speech-Acts";
        public static string WalkthroughTitleAnnotation = "Walkthrough - Speech Annotation";
        public static string WalkthroughTitleFaceTrackingDefaultDetector = "Walkthrough - Face Tracking (wtih default detector)";
        public static string WalkthroughTitleFaceTrackingTrainedDetector = "Walkthrough - Face Tracking (with trained detector)";
        public static string WalkthroughTitlePreProcessGazeData = "Walkthrough - Pre-Process Gaze Data";
        public static string WalkthroughTitleFaceasAOI = "Walkthrough - Face as AOI";
        public static string WalkthroughTitleVisualizeTracking = "Walkthrough - Visualize Tracking";
        public static string WalkthroughTitleFindAOIsDetectionRatio = "Walkthrough - Find AOIs Detection Ratio";
        public static string WalkthroughTitleLabelAOIsManually = "Walkthrough - Label AOIs Manually";
        public static string WalkthroughTitleReanalyseAOIs = "Walkthrough - Re-analyse AOIs(considering manually labeled AOIs)";
        public static string WalkthroughTitleSummary = "Walkthrough - Summary";

        public struct SpeechActs
        {
            public string Name;
            public string Id;

            public override string ToString()
            {
                return Name;
            }

            public SpeechActs(string _id, string _name)
            {
                Id = _id;
                Name = _name;
            }

        }

        public class AudioFilesNameAndPath
        {
            public string Name;
            public string Path;
            public string Interval;

            public override string ToString()
            {
                return Interval == "" ? Name : Name + " " + "(Interval:" + Interval + ")";
            }

            public AudioFilesNameAndPath(string _name, string _path)
            {
                Name = _name;
                Path = _path;
                Interval = "";
            }


        }

        public struct ExpIntervalofPair
        {
            public string starting_time_pair1;
            public string ending_time_pair_1;
            public string starting_time_pair2;
            public string ending_time_pair_2;

            public ExpIntervalofPair(string _starting_time_pair1, string _ending_time_pair_1, string _starting_time_pair2, string _ending_time_pair_2)
            {

                starting_time_pair1 = _starting_time_pair1;
                ending_time_pair_1 = _ending_time_pair_1;
                starting_time_pair2 = _starting_time_pair2;
                ending_time_pair_2 = _ending_time_pair_2;


            }

        }

        public struct FilesForAOIDetection
        {
            public System.IO.StreamReader file_2d_landmarks;
            public System.IO.StreamReader file_gaze_raw_data;
            public string file_manuallyLabelledAOIs_path;


            public FilesForAOIDetection(System.IO.StreamReader _file_2d_landmarks, System.IO.StreamReader _file_gaze_raw_data)
            {
                file_2d_landmarks = _file_2d_landmarks;
                file_gaze_raw_data = _file_gaze_raw_data;
                file_manuallyLabelledAOIs_path = null;
            }

            public FilesForAOIDetection(System.IO.StreamReader _file_2d_landmarks, System.IO.StreamReader _file_gaze_raw_data, string _file_manuallyLabelledAOIs_path)
            {
                file_2d_landmarks = _file_2d_landmarks;
                file_gaze_raw_data = _file_gaze_raw_data;
                file_manuallyLabelledAOIs_path = _file_manuallyLabelledAOIs_path;
            }
        }

        public struct ImageFilesNameAndPath
        {
            public string Name;
            public string Path;

            public override string ToString()
            {
                return Name;
            }

            public ImageFilesNameAndPath(string _name, string _path)
            {
                Name = _name;
                Path = _path;
            }

        }

        public enum ParticipantInfo
        {
            Single,
            First,
            Second
        }

        public static Color BUTTON_BACKCOLOR = Color.AliceBlue;
        public static Color BUTTON_FORECOLOR = Color.DodgerBlue;
        public static Font BUTTON_FONT = new Font("Arial", 10, FontStyle.Bold);



    }
}
