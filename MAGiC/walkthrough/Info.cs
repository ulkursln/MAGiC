using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAGiC
{
    public static class Info
    {

        #region SPEECH ANALYSIS INFO

        #region EXTRACTANDFORMAT
        public static string INFO_SPEECH_EXTRACTANDFORMAT = "\n This will convert avi file into wav file and also format it for further sphinx analysis.Sphinx requires '16 kHz', '16 bit' 'mono', 'little-endian' audio. \n\n";

        public static string STEPS_OUTPUTFOLDER_SPEECH_EXTRACTANDFORMAT = "    1)Select an output folder  ";
        public static string STEPS_AVIFILE_SPEECH_EXTRACTANDFORMAT = "    2)Select an avi file  ";
        public static string STEPS_CONVERTBUTTON_SPEECH_EXTRACTANDFORMAT = "    3)Click Convert button  ";

        public static string OUTPUT_SPEECH_EXTRACTANDFORMAT = "    An audio file  ";

        public static string SAMPLE_OUTPUTFOLDER_EXTRACTANDFORMAT = "(Sample: D:\\MagicTest\\SpeechAnalysis)";
        public static string SAMPLE_AVI_SPEECH_EXTRACTANDFORMAT = "(Sample files)";
        public static string SAMPLE_WAV_SPEECH_EXTRACTANDFORMAT = "(Sample file)";
        #endregion
        /// *******************************************************************************

        #region SEGMENT
        public static string INFO_SPEECH_SEGMENT = "\n Audio file will be segmented into smaller chnunks including sub-words and pauses. Also, segmented-interval file will be created under the specified output folder. \n\n";

        public static string STEPS_OUTPUTFOLDER_SPEECH_SEGMENT =    "    1)Select an output folder  ";
        public static string STEPS_WAVFILE_SPEECH_SEGMENT =         "    2)Select a formatted wav file  ";
        public static string STEPS_SEGMENTBUTTON_SPEECH_SEGMENT =   "    3)Click Segment button  ";

        public static string OUTPUT_AUDIOSEGMENTS_SPEECH_SEGMENT = "    Audio-Segments  ";
        public static string OUTPUT_SEGMENTSINTERVAL_SPEECH_SEGMENT = "    Segments Interval File  ";

        public static string SAMPLE_OUTPUTFOLDER_SPEECH_SEGMENT = "(Sample: D:\\MagicTest\\SpeechAnalysis\\1\\)";
        public static string SAMPLE_WAV_SPEECH_SEGMENT = "(Sample file)";
        public static string SAMPLE_AUDIOSEGMENTS_SPEECH_SEGMENT= "(Sample file)";
        public static string SAMPLE_SEGMENTSINTERVAL_SPEECH_SEGMENT = "(Sample file)";
        #endregion
        /// *******************************************************************************

        #region DETERMINEINTERVAL
        public static string INFO_SPEECH_DETERMINEINTERVAL = "\n This can be used to estimate time interval of an experiment by specifiying both initial and the final audio-segments. \n " +
            "Once the automatic segmentation is complete, a human annotator must still listen to audio-segments in order to specify first and last segment of each experiment. \n\n " +
            "It is recommended to start an experiment with a distinguishbale 'bip' like sound which eases the determination of the initial segment.\n " +
            "Time intervals of an experiment will be set from right after the end of the initial segment to the end of the final segment.\n " +
            "This panel is also provide a function to syncronize recordings comming from two different sources for further speech analysis. \n\n ";

        
        public static string STEPS_OUTPUTFOLDER_SPEECH_DETERMINEINTERVAL =              "    1)Select an output file (Create a new file or load an existing file to append intervals to the end of it)  ";
        public static string STEPS_WHICHPARTICIPANT_SPEECH_DETERMINEINTERVAL =          "    2)Select either a Single Participant or Pair option  ";
        public static string STEPS_PARTICIPANTID_SPEECH_DETERMINEINTERVAL =             "    3)Enter the unique id of a particpant or a pair.  ";
        public static string STEPS_SEGMENTINTERVAL_SPEECH_DETERMINEINTERVAL =           "    4)Select the segment-interval file (Created in the previous 'Segment Audio' step)  ";
        public static string STEPS_EXPERIMENTINTERVAL_SPEECH_DETERMINEINTERVAL =        "    5)Enter the experiment interval  ";
        public static string STEPS_EXPERIMENTINTERVAL_INNER1_SPEECH_DETERMINEINTERVAL = "            Enter starting-segment number (Listen segmented audio files, and enter the number of last segment including bip-like sound)  ";
        public static string STEPS_EXPERIMENTINTERVAL_INNER2_SPEECH_DETERMINEINTERVAL = "            Enter the final-segment number  ";
        public static string STEPS_RESEGMENT_SPEECH_DETERMINEINTERVAL =                 "    6)You can re-segment selected audio file by utilizing synchronization info  ";
        public static string STEPS_RESEGMENT_INNER1_SPEECH_DETERMINEINTERVAL =          "            Select an output folder to specify a path where the audio-segments  and segment-interval file would be stored  ";
        public static string STEPS_RESEGMENT_INNER2_SPEECH_DETERMINEINTERVAL =          "            Select a particular participant in the pair (preferably the one who talk more)  ";
        public static string STEPS_RESEGMENT_INNER3_SPEECH_DETERMINEINTERVAL =          "            Select the formatted audio file of selected particpant in the pair. This audio will be re-segmented  ";
        public static string STEPS_SAVEBUTTON_SPEECH_DETERMINEINTERVAL =                "    7)Click Save or Save&&Re-Segment button  ";

        public static string OUTPUT_EXPERIMENTINTERVAL_SPEECH_DETERMINEINTERVAL =   "    Experiment Interval File  ";
        public static string OUTPUT_RESEGMENTSINTERVAL_SPEECH_DETERMINEINTERVAL =   "    Merged Segments Interval File  ";
        public static string OUTPUT_AUDIORESEGMENTS_SPEECH_DETERMINEINTERVAL =      "    Audio-Segments  ";

        public static string SAMPLE_OUTPUTFILE_SPEECH_DETERMINEINTERVAL = "(Sample: D:\\MagicTest\\SpeechAnalysis\\exp_time_interval.txt)";
        public static string SAMPLE_ID_SPEECH_DETERMINEINTERVAL = "(Sample: 1)";
        public static string SAMPLE_SEGMENTINTERVAL_SPEECH_DETERMINEINTERVAL = "(Sample file)";
        public static string SAMPLE_EXPERIMENTINTERVAL_SPEECH_DETERMINEINTERVAL = "(Sample: 5 - 100)";
        public static string SAMPLE_RESEGMENT_INNER1_SPEECH_DETERMINEINTERVAL = "(Sample: D:\\MagicTest\\SpeechAnalysis\\Pair1)";
        public static string SAMPLE_RESEGMENT_INNER3_SPEECH_DETERMINEINTERVAL = "(Sample file)";
        public static string SAMPLE_OUTPUT_EXPERIMENTINTERVAL_SPEECH_DETERMINEINTERVAL = "(Sample file)";
        public static string SAMPLE_OUTPUT_RESEGMENTSINTERVAL_SPEECH_DETERMINEINTERVAL = "(Sample file)";
        public static string SAMPLE_OUTPUT_AUDIORESEGMENTS_SPEECH_DETERMINEINTERVAL = "(Sample file)";
        #endregion
        /// *******************************************************************************

        #region DEFINESPEECHACT
        public static string INFO_SPEECH_DEFINESPEECHACT = "\n This can be used to define and to store speech-acts under the specified output file. \n Once speech act(s) are added to the list " +
        "you have to click Save button to save them all under the specified output file.\n\n ";

        public static string STEPS_OUTPUTFILE_SPEECH_DEFINESPEECHACT =          "    1)Select an output file (create a new file or load an existing file to append speech-acts to the end of it)  ";
        public static string STEPS_ENTERSPEECHACT_SPEECH_DEFINESPEECHACT =      "    2)Enter speech-act and click Add button  ";
        public static string STEPS_REARRANGEORDER_SPEECH_DEFINESPEECHACT =      "    3)You can re-arrange the order of speech-acts in a list by selecting item and then clicking the move up or move down buttons located next to the list  ";
        public static string STEPS_REMOVE_SPEECH_DEFINESPEECHACT =              "    4)You can remove speech-act(s) in a list by selecting item(s) and then clicking the remove button located next to the list  ";
        public static string STEPS_RENAME_SPEECH_DEFINESPEECHACT =              "    5)You can rename speech-act in a list by double clicking item in the list  ";
        public static string STEPS_SAVEBUTTON_SPEECH_DEFINESPEECHACT =          "    6)Click Save button  ";

        public static string OUTPUT_SPEECHACTS_SPEECH_DEFINESPEECHACT = "    Speech-act(s) File  ";

        public static string SAMPLE_OUTPUTFILE_SPEECH_DEFINESPEECHACT = "(Sample: D:\\MagicTest\\SpeechAnalysis\\SpeechActs.txt)";
        public static string SAMPLE_ENTERSPEECHACT_SPEECH_DEFINESPEECHACT = "(Sample: Speech Pause, Speech, Ask)";
        public static string SAMPLE_OUTPUT_SPEECHACTS_SPEECH_DEFINESPEECHACT = "(Sample file)";
        #endregion
        /// *******************************************************************************

        #region SPEECHACTANNOTATION
        public static string INFO_SPEECH_SPEECHACTANNOTATION = "\n This can be used to annotate uadio-segments  with pre-defined speech-acts. \n Once speech act(s) corresponding to the audio-segments are selected and Annotate (or Annotate and Play Next) button is pressed, \n " +
        "speech-act(s) with time interval will be displayed under the output text-area. \n Do not forget to click save button to save your annotations!!\n\n ";

        public static string STEPS_OUTPUTFILE_SPEECH_SPEECHACTANNOTATION =          "    1)Select an output file (create a new file or load an existing file to append annotations to the end of it)  ";
        public static string STEPS_SEGMENTSINTERVAL_SPEECH_SPEECHACTANNOTATION =    "    2)Select segments-interval file (If you chose re-segment in the previous step, you should select re-segments interval file)  ";
        public static string STEPS_AUDIOSEGMENTS_SPEECH_SPEECHACTANNOTATION =       "    3)Select audio-segments folder (If you chose re-segment in the previous step, you should select re-segment output folder)  ";
        public static string STEPS_SPEECHACT_SPEECH_SPEECHACTANNOTATION =           "    4)Select Speech-Act File  ";
        public static string STEPS_SELECTAUDIO_SPEECH_SPEECHACTANNOTATION =         "    5)Select the first audio called 0, listed under the media player and hit play button to listen the audio  ";
        public static string STEPS_SELECTSPPECHACT_SPEECH_SPEECHACTANNOTATION =     "    6)Select corresponding speech-act(s) and a participant(if any)  ";
        public static string STEPS_ANNOTATEBUTTONS_SPEECH_SPEECHACTANNOTATION =     "    7)Click Annotate or Annotate and Play Next icons located next to the speech-act list. (Repeat 5. and 6. steps until the end of audio-segments)  ";
        public static string STEPS_SAVEBUTTON_SPEECH_SPEECHACTANNOTATION =          "    8)Click Save button  ";

        public static string OUTPUT_ANNOTATION_SPEECH_SPEECHACTANNOTATION =         "    Speech Annotation File  ";

        public static string SAMPLE_OUTPUTFILE_SPEECH_SPEECHACTANNOTATION = "(Sample: D:\\MagicTest\\SpeechAnalysis\\Pair1\\SpeechAnnotation.txt)";
        public static string SAMPLE_SEGMENTSINTERVAL_SPEECH_SPEECHACTANNOTATION = "(Sample file)";
        public static string SAMPLE_AUDIOSEGMENTS_SPEECH_SPEECHACTANNOTATION = "(Sample file)";
        public static string SAMPLE_SPEECHACT_SPEECH_SPEECHACTANNOTATION = "(Sample file)";
        public static string SAMPLE_OUTPUT_ANNOTATION_SPEECH_SPEECHACTANNOTATION = "(Sample file)";
        #endregion

        #endregion
        


        #region AOI ANALYSIS INFO

        #region TRACKINGWITHDEFAULTDETECTOR
        public static string INFO_AOI_TRACKINGWITHDEFAULTDETECTOR = "\n This is used to track face with default detector.\r\n You can check the success ratio of tracking in one of four ways:\r\n"+
            "   a)select 'visualize during tracking' to see detected faces during tracking\n" +
            "   b)after tracking is finished, run steps under the 'Visualize Tracking'\n" +
            "   c)after tracking and AOI-analyse are finished, run steps under the 'Find AOIs Detection Ratio'\n" +
            "   d)after tracking is finished, open generated 2d landmarks file and manually check the confidence level and zero-value columns\n  " +
            " If tracking is not good enough you can track with trained detector )\n\n ";

        public static string STEPS_OUTPUTFOLDER_AOI_TRACKINGWITHDEFAULTDETECTOR =       "    1)Select an output folder where the output files that are requested to be created, will be saved under  ";
        public static string STEPS_AVI_AOI_TRACKINGWITHDEFAULTDETECTOR =                "    2)Select an input video file  ";
        public static string STEPS_VISUALIZEDURING_AOI_TRACKINGWITHDEFAULTDETECTOR =    "    3)Check Visualize During Tracking (if you want)  ";
        public static string STEPS_CHECKOUTPUTFILES_AOI_TRACKINGWITHDEFAULTDETECTOR =   "    4)Check output files that you want to be created (2d-landmarks-file and tracking-framework-image-size file are selected by default)  ";
        public static string STEPS_TRACKBUTTON_AOI_TRACKINGWITHDEFAULTDETECTOR =        "    5)Click Track button  ";


        public static string OUTPUT_2dLANDMARK_AOI_TRACKINGWITHDEFAULTDETECTOR =        "    2d Landmarks File  ";
        public static string OUTPUT_3dLANDMARK_AOI_TRACKINGWITHDEFAULTDETECTOR =        "    3d Landmarks File  ";
        public static string OUTPUT_IMAGESIZEFILE_AOI_TRACKINGWITHDEFAULTDETECTOR =     "    Image-Size File  ";
        public static string OUTPUT_ESTIMATEDPOSE_AOI_TRACKINGWITHDEFAULTDETECTOR =     "    Estimated Pose File  ";
        public static string OUTPUT_ACTIONUNIT_AOI_TRACKINGWITHDEFAULTDETECTOR =        "    Action Units File  ";
        

        public static string SAMPLE_OUTPUTFOLDER_AOI_TRACKINGWITHDEFAULTDETECTOR = "(Sample: D:\\MagicTest\\AOIAnalysis\\1)";
        public static string SAMPLE_AVI_AOI_TRACKINGWITHDEFAULTDETECTOR = "(Sample files)";
        public static string SAMPLE_OUTPUT_2dLANDMARK_AOI_TRACKINGWITHDEFAULTDETECTOR = "(Sample file)";
        public static string SAMPLE_OUTPUT_3dLANDMARK_AOI_TRACKINGWITHDEFAULTDETECTOR = "(Sample file)";
        public static string SAMPLE_OUTPUT_IMAGESIZEFILE_AOI_TRACKINGWITHDEFAULTDETECTOR = "(Sample file)";
        public static string SAMPLE_OUTPUT_ESTIMATEDPOSE_AOI_TRACKINGWITHDEFAULTDETECTOR = "(Sample file)";
        public static string SAMPLE_OUTPUT_ACTIONUNIT_AOI_TRACKINGWITHDEFAULTDETECTOR = "(Sample file)";
        #endregion
        /// *******************************************************************************

        #region TRACKINGWITHTRAINEDDETECTOR
        public static string INFO_AOI_TRACKINGWITHTRAINEDDETECTOR = "\n In a case when user is not satisfied with the tracking results, this can be used to perform face tracking after building a custom face-detector.  \n "+
            "This panel involves three sub-steps: Export Frames, Training and Tracking \n\n ";

        public static string STEPS_EXTRACT_AOI_TRACKINGWITHTRAINEDDETECTOR =                "    1)The first step is extraction of image-frames from the video  ";
        public static string STEPS_EXTRACT_INNER1_AOI_TRACKINGWITHTRAINEDDETECTOR =         "            Select an output folder where the exported images will be saved under  ";
        public static string STEPS_EXTRACT_INNER2_AOI_TRACKINGWITHTRAINEDDETECTOR =         "            Select a video file  ";
        public static string STEPS_EXTRACT_INNER3_AOI_TRACKINGWITHTRAINEDDETECTOR =         "            Click Export Frames Button (Once all images are exported, the training sub-panel turns into an editable mode)  ";
        public static string STEPS_TRAINING_AOI_TRACKINGWITHTRAINEDDETECTOR =               "    2)The second step is training  ";
        public static string STEPS_TRAINING_INNER1_AOI_TRACKINGWITHTRAINEDDETECTOR =        "            Select an output folder where the exported images will be saved under  ";
        public static string STEPS_TRAINING_INNER2_AOI_TRACKINGWITHTRAINEDDETECTOR =        "            Specify a group of images for training ans testing by selecting images from the corresponding lists  ";
        public static string STEPS_TRAINING_INNER3_AOI_TRACKINGWITHTRAINEDDETECTOR =        "            Click Train button  ";
        public static string STEPS_TRAINING_INNER4_AOI_TRACKINGWITHTRAINEDDETECTOR =        "            A new window, listing all the selected images, will be appeared  ";
        public static string STEPS_TRAINING_INNER5_AOI_TRACKINGWITHTRAINEDDETECTOR =        "            It is expected to label faces in each image by drawing boxes around the faces by holding the shift key, left clicking and dragging the mouse  ";
        public static string STEPS_TRAINING_INNER6_AOI_TRACKINGWITHTRAINEDDETECTOR =        "            After completing labelling, Save the labels by clicking Save button under the File menu  ";
        public static string STEPS_TRACKING_AOI_TRACKINGWITHTRAINEDDETECTOR =               "    3)The third step is tracking  ";
        public static string STEPS_TRACKING_INNER1_AOI_TRACKINGWITHTRAINEDDETECTOR =        "            Select an output folder where the output files that are requested to be created, will be saved under  ";
        public static string STEPS_TRACKING_INNER2_AOI_TRACKINGWITHTRAINEDDETECTOR =        "            Check Visualize During Tracking (if you want)  ";
        public static string STEPS_TRACKING_INNER3_AOI_TRACKINGWITHTRAINEDDETECTOR =        "            Check output files that you want to be created (2d-landmarks-file and tracking-framework-image-size file are selected by default)  ";
        public static string STEPS_TRACKING_INNER4_AOI_TRACKINGWITHTRAINEDDETECTOR =        "            Click Track button  ";
        

        public static string OUTPUT_FRAMES_EXTRACT_AOI_TRACKINGWITHTRAINEDDETECTOR = "    Video Frames  ";
        public static string OUTPUT_FACEDETECTOR_AOI_TRACKINGWITHTRAINEDDETECTOR = "    Face Detector  ";
        public static string OUTPUT_2dLANDMARK_AOI_TRACKINGWITHTRAINEDDETECTOR = "    2d Landmarks File  ";
        public static string OUTPUT_3dLANDMARK_AOI_TRACKINGWITHTRAINEDDETECTOR = "    3d Landmarks File  ";
        public static string OUTPUT_IMAGESIZEFILE_AOI_TRACKINGWITHTRAINEDDETECTOR = "    Image-Size File  ";
        public static string OUTPUT_ESTIMATEDPOSE_AOI_TRACKINGWITHTRAINEDDETECTOR = "    Estimated Pose File  ";
        public static string OUTPUT_ACTIONUNIT_AOI_TRACKINGWITHTRAINEDDETECTOR = "    Action Units File  ";

        public static string SAMPLE_OUTPUTFOLDER_EXTRACT_AOI_TRACKINGWITHTRAINEDDETECTOR = "(Sample: D:\\MagicTest\\AOIAnalysis\\1\\Frames)";
        public static string SAMPLE_AVI_EXTRACT_AOI_TRACKINGWITHTRAINEDDETECTOR = "(Sample files)";
        public static string SAMPLE_OUTPUTFOLDER_TRAINING_AOI_TRACKINGWITHTRAINEDDETECTOR = "(Sample: D:\\MagicTest\\AOIAnalysis\\1)";
        public static string SAMPLE_OUTPUTFOLDER_TRACKING_AOI_TRACKINGWITHTRAINEDDETECTOR = "(Sample: D:\\MagicTest\\AOIAnalysis\\1\\TrackingWithTrainedDetector)";
        public static string SAMPLE_OUTPUT_FRAMES_EXTRACT_AOI_TRACKINGWITHTRAINEDDETECTOR = "(Sample file)";
        public static string SAMPLE_OUTPUT_FACEDETECTOR_AOI_TRACKINGWITHTRAINEDDETECTOR = "(Sample file)";
        public static string SAMPLE_OUTPUT_2dLANDMARK_AOI_TRACKINGWITHTRAINEDDETECTOR = "(Sample file)";
        public static string SAMPLE_OUTPUT_3dLANDMARK_AOI_TRACKINGWITHTRAINEDDETECTOR = "(Sample file)";
        public static string SAMPLE_OUTPUT_IMAGESIZEFILE_AOI_TRACKINGWITHTRAINEDDETECTOR = "(Sample file)";
        public static string SAMPLE_OUTPUT_ESTIMATEDPOSE_AOI_TRACKINGWITHTRAINEDDETECTOR = "(Sample file)";
        public static string SAMPLE_OUTPUT_ACTIONUNIT_AOI_TRACKINGWITHTRAINEDDETECTOR = "(Sample file)";

        #endregion
        /// *******************************************************************************

        #region PREPROCESSGAZEDATA
        public static string INFO_AOI_PREPROCESSGAZEDATA = "\n This is used to fill the missing data in raw gaze-data  gathered from an eye tracker. \n " +
            "The fill-in function fills the gaps with linear interpolation according to an entered maximum gap length \n\n ";

        public static string STEPS_OUTPUTFILE_AOI_PREPROCESSGAZEDATA =      "    1)Create an output file which will provide filled raw gaze-data  ";
        public static string STEPS_RAWGAZEDATA_AOI_PREPROCESSGAZEDATA =     "    2)Select raw gaze-data file  ";
        public static string STEPS_MAXGAPLENGTH_AOI_PREPROCESSGAZEDATA =    "    3)Enter Max-Gap-Length as decimal value (Gap-length value can be taken from the eye-tracker specific manual. It is generally equal and smaller than 100 ms)  ";
        public static string STEPS_FILLBUTTON_AOI_PREPROCESSGAZEDATA =      "    4)Click Fill button  ";

        public static string OUTPUT_FILLEDRAWGAZEDATA_AOI_PREPROCESSGAZEDATA = "    Filled Raw Gaze-Data File  ";

        public static string SAMPLE_OUTPUTFILE_AOI_PREPROCESSGAZEDATA = "(Sample: D:\\MagicTest\\AOIAnalysis\\1\\gapFilledRawGazeData.txt)";
        public static string SAMPLE_RAWGAZEDATA_AOI_PREPROCESSGAZEDATA = "(Sample file)";
        public static string SAMPLE_MAXGAPLENGTH_AOI_PREPROCESSGAZEDATA = "(Sample: 2)";
        public static string SAMPLE_OUTPUT_FILLEDRAWGAZEDATA_AOI_PREPROCESSGAZEDATA = "(Sample file)";
        #endregion
        /// *******************************************************************************

        #region FACEASAOI
        public static string INFO_AOI_FACEASAOI = "\n This can be used to define the boundary of a face and then to test whether the raw gaze-data is within a face. \n " +
            "If the gaze data was inside the detected face, ‘e’ character is assigned as an AOI-label. \n " +
            "Otherwise, image-frames are theoretically divided into 3x3 area-of-interests (AOIs). \n " +
            "When the gaze location is outside the face boundary, based on the direction of regions relative to the face area, \n 1 of 8 character values, namely, ‘a’ ‘b’ ‘c’ ‘d’ ‘f’ ‘g ‘h’ ‘i’, is assigned\n\n ";

        public static string STEPS_OUTPUTFILE_AOI_FACEASAOI =       "    1)Create an output file which will provide AOI-label of each frame  ";
        public static string STEPS_RAWGAZEDATA_AOI_FACEASAOI =      "    2)Select raw gaze-data file (if you filled gaze raw data in the previous step, please select the filled file  ";
        public static string STEPS_2dLANDMARK_AOI_FACEASAOI =       "    3)Select 2d-landmark file (It was obtained during face tracking)  ";
        public static string STEPS_IMAGESIZEFILE_AOI_FACEASAOI =    "    4)Select Image-Size file (It was obtained during face tracking)  ";
        public static string STEPS_IMAGESIZE_AOI_FACEASAOI =        "    5)Enter Size of an image captured from an eye tracker (width-height)  ";
        public static string STEPS_FIXATIONERROR_AOI_FACEASAOI =    "    6)Enter Fixation Error Size in pixels (It is specific to eye tracker device and respresents the difference between estimated point of regard and true location)  ";
        public static string STEPS_ANALYSEBUTTON_AOI_FACEASAOI =    "    7)Click Analyse button  ";

        public static string OUTPUT_AOIS_AOI_FACEASAOI = "    AOIs File  ";

        public static string SAMPLE_OUTPUTFILE_AOI_FACEASAOI = "(Sample: D:\\MagicTest\\AOIAnalysis\\1\\faceAsROI.txt)";
        public static string SAMPLE_RAWGAZEDATA_AOI_FACEASAOI = "(Sample file)";
        public static string SAMPLE_2dLANDMARK_AOI_FACEASAOI = "(Sample file)";
        public static string SAMPLE_IMAGESIZEFILE_AOI_FACEASAOI = "(Sample file)";
        public static string SAMPLE_IMAGESIZE_AOI_FACEASAOI = "(Sample: 640 - 480)";
        public static string SAMPLE_FIXATIONERROR_AOI_FACEASAOI = "(Sample: 4.84  - 5.34 )";
        public static string SAMPLE_OUTPUT_AOIS_AOI_FACEASAOI = "(Sample file)";
        #endregion
        /// *******************************************************************************

        #region VISUALIZETRACKING
        public static string INFO_AOI_VISUALIZETRACKING = "\n This enables user to watch the video file overlaid by facial landmarks, AOI-label and gaze point location.  \n " +
            "Confidence value of tracking might be specified to draw facial landmarks those that \n their confidence-level are equal to or higher than the entered threshold. \n " +
            "Moreover, the error rate of an eye tracker can be specified in order to draw recorded gaze point as an area \n considering drifts caused by fixation errors. \n " +
            "Lastly, the user has an option to visualize just the experimental interval by skipping the remaining frames.\n\n ";

        public static string STEPS_AVI_AOI_VISUALIZETRACKING =                  "    1)Select the video file  ";
        public static string STEPS_2dLANDMARK_AOI_VISUALIZETRACKING =           "    2)Select 2d-landmark file (It was obtained during face tracking)  ";
        public static string STEPS_RAWGAZEDATA_AOI_VISUALIZETRACKING =          "    3)Select raw gaze-data file(if you filled gaze raw data in the previous step, please select the filled file  ";
        public static string STEPS_AOIS_AOI_VISUALIZETRACKING =                 "    4)Select AOIs file (It was obtained during AOIs analyse)  ";
        public static string STEPS_IMAGESIZE_AOI_VISUALIZETRACKING =            "    5)Enter Size of an image captured from an eye tracker (width-height)  ";
        public static string STEPS_CONFIDENCETHRESHOLD_AOI_VISUALIZETRACKING =  "    6)Enter Confidence threshold, enter as a decimal value between 0 to 1  ";
        public static string STEPS_FIXATIONERROR_AOI_VISUALIZETRACKING =        "    7)Enter Fixation Error Size in pixels (It is specific to eye tracker device and respresents the difference between estimated point of regard and true location)  ";
        public static string STEPS_JUSTEXPINTERVAL_AOI_VISUALIZETRACKING =      "    8)Select Visualize Just Experimental Interval (This option requires that the Time Interval Estimation under Speech Analysis has already been executed.)   ";
        public static string STEPS_JUSTEXPINTERVAL_INNER1_AOI_VISUALIZETRACKING = "            Select Experiment Interval File  ";
        public static string STEPS_JUSTEXPINTERVAL_INNER2_AOI_VISUALIZETRACKING = "            Enter Eye Tracker Frequency  ";
        public static string STEPS_JUSTEXPINTERVAL_INNER3_AOI_VISUALIZETRACKING = "            Choose one of the option as selected during time interval estimation  ";
        public static string STEPS_JUSTEXPINTERVAL_INNER4_AOI_VISUALIZETRACKING = "            Enter Participant Id as written in Experiment Interval File  ";
        public static string STEPS_VISUALIZEBUTTON_AOI_VISUALIZETRACKING =        "    9)Click Visualize button  ";


        public static string OUTPUT_AOI_VISUALIZETRACKING = "    Each frame that is overlaid by facial landmarks, AOI-label and gaze point location will be presented.  ";

        public static string SAMPLE_AVI_AOI_VISUALIZETRACKING = "(Sample files)";
        public static string SAMPLE_2dLANDMARK_AOI_VISUALIZETRACKING = "(Sample file)";
        public static string SAMPLE_RAWGAZEDATA_AOI_VISUALIZETRACKING = "(Sample file)";
        public static string SAMPLE_AOIS_AOI_VISUALIZETRACKING = "(Sample file)";
        public static string SAMPLE_IMAGESIZE_AOI_VISUALIZETRACKING = "(Sample: 640 - 480)";
        public static string SAMPLE_CONFIDENCETHRESHOLD_AOI_VISUALIZETRACKING = "(Sample: 0.7)";
        public static string SAMPLE_FIXATIONERROR_AOI_VISUALIZETRACKING = "(Sample: 4.84  - 5.34 )";
        public static string SAMPLE_EXPINTERVALFILE_AOI_VISUALIZETRACKING = "(Sample file)";
        public static string SAMPLE_EYETRACKERFREQUENCY_AOI_VISUALIZETRACKING = "(Sample: 30)";
        public static string SAMPLE_PARTICIPANTID_AOI_VISUALIZETRACKING = "(Sample: 1)";
        #endregion
        /// *******************************************************************************

        #region AOIDETECTIONRATIO
        public static string INFO_AOI_AOIDETECTIONRATIO = "\n This delivers the number and percentage of not detected AOIs during an experiment \n " +
        "The underlying reason for not detected AOIs could be any of following, lack of raw-data, lack of detected face and lack of both raw-data and detected face . \n " +
        "At the end of the execution, message dialog box will be presented including following values: \n " +
        "Number of Not Detected AOIs, Number of Empty Face Detection, Number of Empty Gaze Raw Data and Number of Both Empty Face Detection and Gaze Raw Data \n " +
        "This function requires that the Time Interval Estimation under Speech Analysis has already been executed.\n\n ";

        public static string STEPS_AOIs_AOI_AOIDETECTIONRATIO =                 "    1)Select AOIs file (It was obtained during AOIs analyse)  ";
        public static string STEPS_EXPINTERVALFILE_AOI_AOIDETECTIONRATIO =      "    2)Select Experiment Interval File  ";
        public static string STEPS_EYETRACKERFREQUENCY_AOI_AOIDETECTIONRATIO =  "    3)Enter Eye Tracker Frequency  ";
        public static string STEPS_WHICHPARTICIPANT_AOI_AOIDETECTIONRATIO =     "    4)Choose one of the option as selected during time interval estimation  ";
        public static string STEPS_PARTICIPANTID_AOI_AOIDETECTIONRATIO =        "    5)Enter Participant Id as written in Experiment Interval File  ";
        public static string STEPS_FINDBUTTON_AOI_AOIDETECTIONRATIO =           "    6)Click Find button  ";

        public static string OUTPUT_RATIO_AOI_AOIDETECTIONRATIO = "    The number and percentage of empty raw gaze-data  and face-detection will be presented.  ";

        public static string SAMPLE_AOIs_AOI_AOIDETECTIONRATIO = "(Sample file)";
        public static string SAMPLE_EXPINTERVALFILE_AOI_AOIDETECTIONRATIO = "(Sample file)";
        public static string SAMPLE_EYETRACKERFREQUENCY_AOI_AOIDETECTIONRATIO = "(Sample: 30)";
        public static string SAMPLE_PARTICIPANTID_AOI_AOIDETECTIONRATIO = "(Sample: 1)";

        #endregion
        /// *******************************************************************************

        #region LABELMANUALLY
        public static string INFO_AOI_LABELMANUALLY = "\n This enables to label AOI of each frame manually \n " +
                   "If the detection-ratio is not sufficient enough to meet the experiment-dependent considerations, user can either re-track with trained detector or label AOIs manually. \n " +
                   "Unlike “Visualize Tracking”, it requires the user to press a keyboard button in order to move to the next frame. \n " +
                   "As presented in the below figure, frames can be labelled by using numeric keypad. For instance, pressing the button 5 will assign “e” \n " +
                   "and pressing enter button will skip the current frame without annotating. \n\n ";

        public static string STEPS_OUTPUTFILE_AOI_LABELMANUALLY =           "    1)Select an output file to store AOI-label  ";
        public static string STEPS_AVI_AOI_LABELMANUALLY =                  "    2)Select the video file  ";
        public static string STEPS_2dLANDMARK_AOI_LABELMANUALLY =           "    3)Select 2d-landmark file (It was obtained during face tracking)  ";
        public static string STEPS_RAWGAZEDATA_AOI_LABELMANUALLY =          "    4)Select raw gaze-data file(if you filled gaze raw data in the previous step, please select the filled file  ";
        public static string STEPS_AOIS_AOI_LABELMANUALLY =                 "    5)Select AOIs file (It was obtained during AOIs analyse)  ";
        public static string STEPS_IMAGESIZE_AOI_LABELMANUALLY =            "    6)Enter Size of an image captured from an eye tracker (width-height)  ";
        public static string STEPS_CONFIDENCETHRESHOLD_AOI_LABELMANUALLY =  "    7)Enter Confidence threshold as a decimal value between 0 to 1  ";
        public static string STEPS_FIXATIONERROR_AOI_LABELMANUALLY =        "    8)Enter Fixation Error Size in pixels (It is specific to the eye tracker device and respresents the difference between estimated point of regard and true location)  ";
        public static string STEPS_JUSTEXPINTERVAL_AOI_LABELMANUALLY =      "    9)Select Visualize Just Experimental Interval (This option requires that the Time Interval Estimation under Speech Analysis has already been executed)   ";
        public static string STEPS_JUSTEXPINTERVAL_INNER1_AOI_LABELMANUALLY = "            Select Experiment Interval File  ";
        public static string STEPS_JUSTEXPINTERVAL_INNER2_AOI_LABELMANUALLY = "            Enter Eye Tracker Frequency  ";
        public static string STEPS_JUSTEXPINTERVAL_INNER3_AOI_LABELMANUALLY = "            Choose one of the option as selected during time interval estimation  ";
        public static string STEPS_JUSTEXPINTERVAL_INNER4_AOI_LABELMANUALLY = "            Enter Participant Id as written in Experiment Interval File  ";
        public static string STEPS_LABELBUTTON_AOI_LABELMANUALLY =            "    10)Click Label button  ";


        public static string OUTPUT_MANUALLYLABELLED_AOI_VISUALIZETRACKING = "    Manually  Labelled AOIs File ";

        public static string SAMPLE_OUTPUTFILE_AOI_LABELMANUALLY = "(Sample: D:\\MagicTest\\AOIAnalysis\\1\\correctedFrames.txt)"; 
        public static string SAMPLE_AVI_AOI_LABELMANUALLY = "(Sample files)";
        public static string SAMPLE_2dLANDMARK_AOI_LABELMANUALLY = "(Sample file)";
        public static string SAMPLE_RAWGAZEDATA_AOI_LABELMANUALLY = "(Sample file)";
        public static string SAMPLE_AOIS_AOI_LABELMANUALLY = "(Sample file)";
        public static string SAMPLE_IMAGESIZE_AOI_LABELMANUALLY = "(Sample: 640 - 480)";
        public static string SAMPLE_CONFIDENCETHRESHOLD_AOI_LABELMANUALLY = "(Sample: 0.7)";
        public static string SAMPLE_FIXATIONERROR_AOI_LABELMANUALLY = "(Sample: 4.84  - 5.34 )";
        public static string SAMPLE_EXPINTERVALFILE_AOI_LABELMANUALLY = "(Sample file)";
        public static string SAMPLE_EYETRACKERFREQUENCY_AOI_LABELMANUALLY = "(Sample: 30)";
        public static string SAMPLE_PARTICIPANTID_AOI_LABELMANUALLY = "(Sample: 1)";
        public static string SAMPLE_OUTPUT_MANUALLYLABELLED_AOI_VISUALIZETRACKING = "(Sample file)";

        #endregion
        /// *******************************************************************************

        #region REANALYZE
        public static string INFO_AOI_REANALYZE = "\n This function should be run to merge automatically extracted and manually labelled AOIs. \n " +
            "In a case, when both manual and automatic label exist for a particular frame, manually given label overwrites the automatically set one. \n\n ";

        public static string STEPS_OUTPUTFILE_AOI_REANALYZE =           "    1)Select an output file to store AOI-lables under  ";
        public static string STEPS_MANUALLYLABELLEDAOI_AOI_REANALYZE =  "    2)Select manually labelled AOIs File  ";
        public static string STEPS_RAWGAZEDATA_AOI_REANALYZE =          "    3)Select raw gaze-data file(if you filled gaze raw data in the previous step, please select the filled file  ";
        public static string STEPS_2dLANDMARK_AOI_REANALYZE =           "    4)Select 2d-landmark file (It was obtained during face tracking)  ";
        public static string STEPS_IMAGESIZEFILE_AOI_REANALYZE =        "    5)Select Image-Size file(It was obtained during face tracking)  ";
        public static string STEPS_IMAGESIZE_AOI_REANALYZE =            "    6)Enter Size of an image captured from an eye tracker (width-height)  ";
        public static string STEPS_ANALYSEBUTTON_AOI_REANALYZE =        "    7)Click Analyse button  ";

        public static string OUTPUT_REANALYZEDAOI_AOI_VISUALIZETRACKING = "    File that combines data residing in two files: automatically-assigned AOI file, manually-labelled AOIs file ";

        public static string SAMPLE_OUTPUTFILE_AOI_REANALYZE = "(Sample: D:\\MagicTest\\AOIAnalysis\\1\\faceAsROI_mergedManual.txt)";
        public static string SAMPLE_MANUALLYLABELLEDAOI_AOI_REANALYZE = "(Sample file)";
        public static string SAMPLE_RAWGAZEDATA_AOI_REANALYZE = "(Sample file)";
        public static string SAMPLE_2dLANDMARK_AOI_REANALYZE = "(Sample file)";
        public static string SAMPLE_IMAGESIZEFILE_AOI_REANALYZE = "(Sample file)";
        public static string SAMPLE_IMAGESIZE_AOI_REANALYZE = "(Sample: 640 - 480)";
        public static string SAMPLE_OUTPUT_REANALYZEDAOI_AOI_VISUALIZETRACKING = "(Sample file)";
        #endregion

        #endregion

        #region Summary

        #region SummaryPage
        public static string INFO_SUMMARY = "\n This can be used to create a summary file. The lines in a file represent consecutive frames and consist of according speech-act and aoi information. \n " +
            "This function requires to perform Speech Analysis and AOI Analysis previously . \n\n " ;


        public static string STEPS_OUTPUTFILE_SUMMARY       =                   "    1)Select an output path to create a file (Create a new file)";
        public static string STEPS_SPEECH_ANNOTATION_SUMMARY =                  "    2)Select speech-annotation file (Created in the  'Speech Annotation' step )  ";
        public static string STEPS_SINGLEOTPAIR_SUMMARY =                       "    3)Select either a Single Participant or Pair option  ";
        public static string STEPS_AOIFILE_SUMMARY =                            "    4)Select AOI file for a single participant or participants in a pair  ";
        public static string STEPS_EXPINTERVALFILE_SUMMARY =                    "    5)Select Experiment Interval file for a single participant or a pair  ";
        public static string STEPS_PARTICIPANTID_SUMMARY =                      "    6)Enter the unique id of a particpant or a pair.  ";
        public static string STEPS_EYETRACKERFREQUENCY_SUMMARY =                "    7)Enter eye tracker frequency in Hz  ";
        public static string STEPS_SAVEBUTTON_SUMMARY =                         "    8)Click Save button  ";

        public static string OUTPUT_SUMMARY = "    Summary File  ";


        public static string SAMPLE_OUTPUTFILE_SUMMARY = "(Sample: D:\\MagicTest\\summary.txt)";
        public static string SAMPLE_SPEECH_ANNOTATION_SUMMARY = "(Sample file)";
        public static string SAMPLE_AOIFILE_SUMMARY = "(Sample file)";
        public static string SAMPLE_EXPINTERVALFILE_SUMMARY = "(Sample file)";
        public static string SAMPLE_PARTICIPANTID_SUMMARY = "(Sample: 1)";
        public static string SAMPLE_EYETRACKERFREQUENCY_SUMMARY = "(Sample: 30)";
        public static string SAMPLE_OUTPUT_SUMMARY = "(Sample file)";
        #endregion
        /// *******************************************************************************
        #endregion

        public static string TEXT_INFO = "Info";
        public static string TEXT_STEPS = "Steps:";
        public static string TEXT_BUTTON_GOTOHOME = "Go to Walkthrough-Tree";
        public static string TEXT_BUTTON_GOTOFUNCTION = "Go to Function";
        public static string TEXT_OUTPUT = "Output";
        public static string TEXT_SAMPLES = "Samples";

        public static Font FONT_INFOTEXT = new Font("Arial", 11, FontStyle.Bold);
        public static Font FONT_STEPSTEXT = new Font("Arial", 11, FontStyle.Bold);
        public static Font FONT_INFO = new Font("Arial", 11, FontStyle.Regular);
        public static Font FONT_STEPS = new Font("Arial", 11, FontStyle.Italic);
        public static Font FONT_OUTPUTTEXT= new Font("Arial", 11, FontStyle.Bold);
        public static Font FONT_OUTPUT = new Font("Arial", 11, FontStyle.Italic);
        public static Font FONT_SAMPLESTEXT = new Font("Arial", 11, FontStyle.Bold);
        public static Font FONT_SAMPLES = new Font("Arial", 11, FontStyle.Italic);

        // public static string LINK_AVI_FILE = "https://drive.google.com/open?id=0B-DfZx3YFEzgYXhFTVhsM0ltNUE";

        public static string LINK_AVI_FILE = "https://drive.google.com/open?id=0B-DfZx3YFEzgODhhcnUySFZ3MlE";
        public static string LINK_WAV_FILE = "https://drive.google.com/open?id=0B-DfZx3YFEzgYmh3RjZaYTdEZ1k";
        public static string LINK_SEGMENT_AUDIO = "https://drive.google.com/open?id=0B-DfZx3YFEzgeE1KaTQ3QURqWVk";
        public static string LINK_SEGMENT_INTERVAL = "https://drive.google.com/open?id=0B-DfZx3YFEzgaU5yUGMwZWo0MkU";
        public static string LINK_EXP_INTERVAL = "https://drive.google.com/open?id=0B-DfZx3YFEzgcllGMmJrejVLdTQ";
        public static string LINK_RESEGMENTED_INTERVAL = "https://drive.google.com/open?id=0B-DfZx3YFEzgRmNFTnpTYmx3NTA";
        public static string LINK_RESEGMENTED_AUDIO = "https://drive.google.com/open?id=0B-DfZx3YFEzgdHNfQ21KZ1dVWmM";
        public static string LINK_SPEECH_ACTS = "https://drive.google.com/open?id=0B-DfZx3YFEzgVmlGU0RiWnJmU1k";
        public static string LINK_SPEECH_ANNOTATION = "https://drive.google.com/open?id=0B-DfZx3YFEzgd3ZmajNRM1dxekk";
        public static string LINK_2DLANDMARK = "https://drive.google.com/open?id=0B-DfZx3YFEzgYnM0MEFKZDhwQ3c";              
        public static string LINK_IMAGESIZEFILE = "https://drive.google.com/open?id=0B-DfZx3YFEzgWG03cTh0VlBUcVE"; 
        public static string LINK_ESTIMATED_POSE = "https://drive.google.com/open?id=0B-DfZx3YFEzgTGhUMExfZmZDR1U";           
        public static string LINK_ACTION_UNITS = "https://drive.google.com/open?id=0B-DfZx3YFEzgVHlMRkkwV0VOWXM";
        public static string LINK_3DLANDMARK = "https://drive.google.com/open?id=0B-DfZx3YFEzgS3ZCbzlGbmRXek0";             
        public static string LINK_EXPORTEDFRAME = "https://drive.google.com/open?id=0B-DfZx3YFEzgUUx4QmlTc09mZXc"; 
        public static string LINK_TEST_XML = "https://drive.google.com/open?id=0B-DfZx3YFEzgcjFjeFM3TVFrVEk";  
        public static string LINK_TRAINING_XML = "https://drive.google.com/open?id=0B-DfZx3YFEzgamd2WF9lNjZjaFk"; 
        public static string LINK_FACE_DETECTOR = "https://drive.google.com/open?id=0B-DfZx3YFEzgcDJVVUdfR0VBQ1k";  
        public static string LINK_RAW_GAZEDATA = "https://drive.google.com/open?id=0B-DfZx3YFEzgU2RoU1BuYmN3UzQ";       
        public static string LINK_FILLED_RAW_GAZEDATA = "https://drive.google.com/open?id=0B-DfZx3YFEzgdEtkUDNWTFhIbFU"; 
        public static string LINK_AOI_FILE = "https://drive.google.com/open?id=0B-DfZx3YFEzgU0F2dHpuWlpWeVk"; 
        public static string LINK_MANUALLY_LABELLED_AOI = "https://drive.google.com/open?id=0B-DfZx3YFEzgbXFZSEhOcHpJdWM"; 
        public static string LINK_REANALYZE_AOI_OUTPUT = "https://drive.google.com/open?id=0B-DfZx3YFEzgNlFrMjJmcURJX0E"; 
        public static string LINK_SUMMARY_FILE = "https://drive.google.com/open?id=0B-DfZx3YFEzgOVRQTnkzd1RPWXc";
    }
}
