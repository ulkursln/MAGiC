using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAGiC
{
    public class SpeechAnalysisWalkthroughUI : ParentUI
    {
        public SpeechAnalysisWalkthroughBE sawBe;
  

        public SpeechAnalysisWalkthroughUI(INavigationListener _navigationListener) : base(_navigationListener) { }

        public void initializeController()
        {
            sawBe = new SpeechAnalysisWalkthroughBE(this);
        }

        #region Extract and Format Audio controls
        /**********************************************************************************************/
        public Label lbl_infotext_extractAndFormat = new Label
        {
            Text = Info.TEXT_INFO,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_INFOTEXT

        };

        public Label lbl_stepstext_extractAndFormat = new Label
        {
            Text = Info.TEXT_STEPS,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPSTEXT

        };

        public Label lbl_info_extractAndFormat = new Label
        {
            Text = Info.INFO_SPEECH_EXTRACTANDFORMAT,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock=DockStyle.Fill,
            Font = Info.FONT_INFO

        };

        public Label lbl_steps_1_extractAndFormat = new Label
        {
            Text = Info.STEPS_OUTPUTFOLDER_SPEECH_EXTRACTANDFORMAT,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };
        public Label lbl_steps_2_extractAndFormat = new Label
        {
            Text = Info.STEPS_AVIFILE_SPEECH_EXTRACTANDFORMAT,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };
        public Label lbl_steps_3_extractAndFormat = new Label
        {
            Text = Info.STEPS_CONVERTBUTTON_SPEECH_EXTRACTANDFORMAT,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };
        public Label lbl_outputstext_extractAndFormat = new Label
        {
            Text = Info.TEXT_OUTPUT,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_OUTPUTTEXT

        };

        public Label lbl_outputs_extractAndFormat = new Label
        {
            Text = Info.OUTPUT_SPEECH_EXTRACTANDFORMAT,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_OUTPUT

        };

        public Label lbl_samplestext_extractAndFormat = new Label
        {
            Text = Info.TEXT_SAMPLES,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLESTEXT

        };

        public Label lbl_sampleoutputfolder_extractAndFormat = new LinkLabel
        {
            Text = Info.SAMPLE_OUTPUTFOLDER_EXTRACTANDFORMAT,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };

        public LinkLabel linklbl_samplefile_avi_extractAndFormat = new LinkLabel
        {
            Text = Info.SAMPLE_AVI_SPEECH_EXTRACTANDFORMAT,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };

        public LinkLabel linklbl_samplefile_wav_extractAndFormat = new LinkLabel
        {
            Text = Info.SAMPLE_WAV_SPEECH_EXTRACTANDFORMAT,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES

        };

        public Button btn_gotoFunction_home_ExtractFormat_SpeechAnalysis = new Button { Text = Info.TEXT_BUTTON_GOTOHOME, AutoSize = true, BackColor = Color.AliceBlue, Font = new Font("Arial", 10, FontStyle.Bold) };
        public Button btn_gotoFunction_ExtractFormat_SpeechAnalysis = new Button { Text = Info.TEXT_BUTTON_GOTOFUNCTION, AutoSize = true, BackColor = Color.AliceBlue, Font = new Font("Arial", 10, FontStyle.Bold) };
        #endregion
       

        #region Segment Audio controls
        /**********************************************************************************************/
        public Label lbl_infotext_segment = new Label
        {
            Text = Info.TEXT_INFO,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_INFOTEXT

        };

        public Label lbl_stepstext_segment = new Label
        {
            Text = Info.TEXT_STEPS,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPSTEXT

        };

        public Label lbl_info_segment = new Label
        {
            Text = Info.INFO_SPEECH_SEGMENT,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_INFO

        };

        public Label lbl_steps_1_segment = new Label
        {
            Text = Info.STEPS_OUTPUTFOLDER_SPEECH_SEGMENT,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };
        public Label lbl_steps_2_segment = new Label
        {
            Text = Info.STEPS_WAVFILE_SPEECH_SEGMENT,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };
        public Label lbl_steps_3_segment = new Label
        {
            Text = Info.STEPS_SEGMENTBUTTON_SPEECH_SEGMENT,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_outputstext_segment = new Label
        {
            Text = Info.TEXT_OUTPUT,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_OUTPUTTEXT

        };

        public Label lbl_outputs_1_segment = new Label
        {
            Text = Info.OUTPUT_AUDIOSEGMENTS_SPEECH_SEGMENT,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_OUTPUT

        };
        public Label lbl_outputs_2_segment = new Label
        {
            Text = Info.OUTPUT_SEGMENTSINTERVAL_SPEECH_SEGMENT,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_OUTPUT

        };

        public Label lbl_sampleoutputfolder_segment = new LinkLabel
        {
            Text = Info.SAMPLE_OUTPUTFOLDER_SPEECH_SEGMENT,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };

        public LinkLabel linklbl_samplefile_wav_segment = new LinkLabel
        {
            Text = Info.SAMPLE_WAV_SPEECH_SEGMENT,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };
        public LinkLabel linklbl_samplefile_audiosegments_segment = new LinkLabel
        {
            Text = Info.SAMPLE_AUDIOSEGMENTS_SPEECH_SEGMENT,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };
        public LinkLabel linklbl_samplefile_segmentInterval_segment = new LinkLabel
        {
            Text = Info.SAMPLE_SEGMENTSINTERVAL_SPEECH_SEGMENT,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };


        public Button btn_gotoFunction_home_segment_SpeechAnalysis = new Button { Text = Info.TEXT_BUTTON_GOTOHOME, AutoSize = true, BackColor = Color.AliceBlue, Font = new Font("Arial", 10, FontStyle.Bold) };
        public Button btn_gotoFunction_SegmentAudio_SpeechAnalysis = new Button { Text = Info.TEXT_BUTTON_GOTOFUNCTION, AutoSize = true, BackColor = Color.AliceBlue, Font = new Font("Arial", 10, FontStyle.Bold) };
        #endregion
     
  
        #region Time Interval Specification (also, Synchronization for Multiple Recordings) controls*/
        /**********************************************************************************************/
        public Label lbl_infotext_determine_interval = new Label
        {
            Text = Info.TEXT_INFO,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_INFOTEXT

        };

        public Label lbl_stepstext_determine_interval = new Label
        {
            Text = Info.TEXT_STEPS,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPSTEXT

        };

        public Label lbl_info_determine_interval = new Label
        {
            Text = Info.INFO_SPEECH_DETERMINEINTERVAL,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_INFO

        };
        public Label lbl_steps_1_determine_interval = new Label
        {
            Text = Info.STEPS_OUTPUTFOLDER_SPEECH_DETERMINEINTERVAL,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_steps_2_determine_interval = new Label
        {
            Text = Info.STEPS_WHICHPARTICIPANT_SPEECH_DETERMINEINTERVAL,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_steps_3_determine_interval = new Label
        {
            Text = Info.STEPS_PARTICIPANTID_SPEECH_DETERMINEINTERVAL,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_steps_4_determine_interval = new Label
        {
            Text = Info.STEPS_SEGMENTINTERVAL_SPEECH_DETERMINEINTERVAL,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_steps_5_determine_interval = new Label
        {
            Text = Info.STEPS_EXPERIMENTINTERVAL_SPEECH_DETERMINEINTERVAL,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_steps_51_determine_interval = new Label
        {
            Text = Info.STEPS_EXPERIMENTINTERVAL_INNER1_SPEECH_DETERMINEINTERVAL,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_steps_52_determine_interval = new Label
        {
            Text = Info.STEPS_EXPERIMENTINTERVAL_INNER2_SPEECH_DETERMINEINTERVAL,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_steps_6_determine_interval = new Label
        {
            Text = Info.STEPS_RESEGMENT_SPEECH_DETERMINEINTERVAL,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_steps_61_determine_interval = new Label
        {
            Text = Info.STEPS_RESEGMENT_INNER1_SPEECH_DETERMINEINTERVAL,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_steps_62_determine_interval = new Label
        {
            Text = Info.STEPS_RESEGMENT_INNER2_SPEECH_DETERMINEINTERVAL,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_steps_63_determine_interval = new Label
        {
            Text = Info.STEPS_RESEGMENT_INNER3_SPEECH_DETERMINEINTERVAL,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_steps_7_determine_interval = new Label
        {
            Text = Info.STEPS_SAVEBUTTON_SPEECH_DETERMINEINTERVAL,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_outputstext_determine_interval = new Label
        {
            Text = Info.TEXT_OUTPUT,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_OUTPUTTEXT

        };

        public Label lbl_outputs_1_determine_interval = new Label
        {
            Text = Info.OUTPUT_EXPERIMENTINTERVAL_SPEECH_DETERMINEINTERVAL,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_OUTPUT

        };

        public Label lbl_outputs_2_determine_interval = new Label
        {
            Text = Info.OUTPUT_RESEGMENTSINTERVAL_SPEECH_DETERMINEINTERVAL,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_OUTPUT

        };

        public Label lbl_outputs_3_determine_interval = new Label
        {
            Text = Info.OUTPUT_AUDIORESEGMENTS_SPEECH_DETERMINEINTERVAL,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_OUTPUT

        };

        public Label lbl_sample_outputfile_speech_determineinterval = new LinkLabel
        {
            Text = Info.SAMPLE_OUTPUTFILE_SPEECH_DETERMINEINTERVAL,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };

        public Label lbl_sample_id_speech_determineinterval = new LinkLabel
        {
            Text = Info.SAMPLE_ID_SPEECH_DETERMINEINTERVAL,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };

        public LinkLabel linklbl_sample_segmentinterval_speech_determineinterval = new LinkLabel
        {
            Text = Info.SAMPLE_SEGMENTINTERVAL_SPEECH_DETERMINEINTERVAL,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };

        public Label lbl_sample_experimentinterval_speech_determineinterval = new LinkLabel
        {
            Text = Info.SAMPLE_EXPERIMENTINTERVAL_SPEECH_DETERMINEINTERVAL,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };

        public Label lbl_sample_resegment_inner1_speech_determineinterval = new LinkLabel
        {
            Text = Info.SAMPLE_RESEGMENT_INNER1_SPEECH_DETERMINEINTERVAL,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };

        public LinkLabel linklbl_sample_resegment_inner3_speech_determineinterval = new LinkLabel
        {
            Text = Info.SAMPLE_RESEGMENT_INNER3_SPEECH_DETERMINEINTERVAL,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };

        public LinkLabel linklbl_sample_output_experimentinterval_speech_determineinterval = new LinkLabel
        {
            Text = Info.SAMPLE_OUTPUT_EXPERIMENTINTERVAL_SPEECH_DETERMINEINTERVAL,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };

        public LinkLabel linklbl_sample_output_resegmentsinterval_speech_determineinterval = new LinkLabel
        {
            Text = Info.SAMPLE_OUTPUT_RESEGMENTSINTERVAL_SPEECH_DETERMINEINTERVAL,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };

        public LinkLabel linklbl_sample_output_audioresegments_speech_determineinterval = new LinkLabel
        {
            Text = Info.SAMPLE_OUTPUT_AUDIORESEGMENTS_SPEECH_DETERMINEINTERVAL,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };


        public Button btn_gotoFunction_home_determineInterval_SpeechAnalysis = new Button { Text = Info.TEXT_BUTTON_GOTOHOME, AutoSize = true, BackColor = Color.AliceBlue, Font = new Font("Arial", 10, FontStyle.Bold) };
        public Button btn_gotoFunction_TimeIntervalSpecification_SpeechAnalysis = new Button { Text = Info.TEXT_BUTTON_GOTOFUNCTION, AutoSize = true, BackColor = Color.AliceBlue, Font = new Font("Arial", 10, FontStyle.Bold) };
        #endregion
        

        #region Define Speech-Act controls*/
        /**********************************************************************************************/
        public Label lbl_infotext_defineSpeechAct = new Label
        {
            Text = Info.TEXT_INFO,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_INFOTEXT

        };

        public Label lbl_stepstext_defineSpeechAct = new Label
        {
            Text = Info.TEXT_STEPS,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPSTEXT

        };

        public Label lbl_info_defineSpeechAct = new Label
        {
            Text = Info.INFO_SPEECH_DEFINESPEECHACT,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_INFO

        };
        public Label lbl_steps_1_defineSpeechAct = new Label
        {
            Text = Info.STEPS_OUTPUTFILE_SPEECH_DEFINESPEECHACT,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_steps_2_defineSpeechAct = new Label
        {
            Text = Info.STEPS_ENTERSPEECHACT_SPEECH_DEFINESPEECHACT,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_steps_3_defineSpeechAct = new Label
        {
            Text = Info.STEPS_REARRANGEORDER_SPEECH_DEFINESPEECHACT,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_steps_4_defineSpeechAct = new Label
        {
            Text = Info.STEPS_REMOVE_SPEECH_DEFINESPEECHACT,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_steps_5_defineSpeechAct = new Label
        {
            Text = Info.STEPS_RENAME_SPEECH_DEFINESPEECHACT,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_steps_6_defineSpeechAct = new Label
        {
            Text = Info.STEPS_SAVEBUTTON_SPEECH_DEFINESPEECHACT,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_outputstext_defineSpeechAct = new Label
        {
            Text = Info.TEXT_OUTPUT,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_OUTPUTTEXT

        };

        public Label lbl_outputs_defineSpeechAct = new Label
        {
            Text = Info.OUTPUT_SPEECHACTS_SPEECH_DEFINESPEECHACT,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_OUTPUT

        };

        public Label lbl_sample_outputfile_speech_definespeechact = new LinkLabel
        {
            Text = Info.SAMPLE_OUTPUTFILE_SPEECH_DEFINESPEECHACT,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };

        public Label lbl_sample_enterspeechact_speech_definespeechact = new LinkLabel
        {
            Text = Info.SAMPLE_ENTERSPEECHACT_SPEECH_DEFINESPEECHACT,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };

        public LinkLabel linklbl_sample_output_speechacts_speech_definespeechact = new LinkLabel
        {
            Text = Info.SAMPLE_OUTPUT_SPEECHACTS_SPEECH_DEFINESPEECHACT,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };

        public Button btn_gotoFunction_home_defineSpeechAct_SpeechAnalysis = new Button { Text = Info.TEXT_BUTTON_GOTOHOME, AutoSize = true, BackColor = Color.AliceBlue, Font = new Font("Arial", 10, FontStyle.Bold) };
        public Button btn_gotoFunction_defineSpeechAct_SpeechAnalysis = new Button { Text = Info.TEXT_BUTTON_GOTOFUNCTION, AutoSize = true, BackColor = Color.AliceBlue, Font = new Font("Arial", 10, FontStyle.Bold) };
        #endregion
       

        #region Speech Act Annotation controls*/
        /**********************************************************************************************/
        public Label lbl_infotext_speechActAnnotation = new Label
        {
            Text = Info.TEXT_INFO,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_INFOTEXT

        };

        public Label lbl_stepstext_speechActAnnotation = new Label
        {
            Text = Info.TEXT_STEPS,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPSTEXT

        };

        public Label lbl_info_speechActAnnotation = new Label
        {
            Text = Info.INFO_SPEECH_SPEECHACTANNOTATION,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_INFO

        };
        public Label lbl_steps_1_speechActAnnotation = new Label
        {
            Text = Info.STEPS_OUTPUTFILE_SPEECH_SPEECHACTANNOTATION,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };
        public Label lbl_steps_2_speechActAnnotation = new Label
        {
            Text = Info.STEPS_SEGMENTSINTERVAL_SPEECH_SPEECHACTANNOTATION,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };
        public Label lbl_steps_3_speechActAnnotation = new Label
        {
            Text = Info.STEPS_AUDIOSEGMENTS_SPEECH_SPEECHACTANNOTATION,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };
        public Label lbl_steps_4_speechActAnnotation = new Label
        {
            Text = Info.STEPS_SPEECHACT_SPEECH_SPEECHACTANNOTATION,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };
        public Label lbl_steps_5_speechActAnnotation = new Label
        {
            Text = Info.STEPS_SELECTAUDIO_SPEECH_SPEECHACTANNOTATION,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };
        public Label lbl_steps_6_speechActAnnotation = new Label
        {
            Text = Info.STEPS_SELECTSPPECHACT_SPEECH_SPEECHACTANNOTATION,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };
        public Label lbl_steps_7_speechActAnnotation = new Label
        {
            Text = Info.STEPS_ANNOTATEBUTTONS_SPEECH_SPEECHACTANNOTATION,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };
        public Label lbl_steps_8_speechActAnnotation = new Label
        {
            Text = Info.STEPS_SAVEBUTTON_SPEECH_SPEECHACTANNOTATION,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_STEPS

        };

        public Label lbl_outputstext_speechActAnnotation = new Label
        {
            Text = Info.TEXT_OUTPUT,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_OUTPUTTEXT

        };

        public Label lbl_outputs_speechActAnnotation = new Label
        {
            Text = Info.OUTPUT_ANNOTATION_SPEECH_SPEECHACTANNOTATION,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_OUTPUT

        };

        public Label lbl_sample_outputfile_speech_speechactannotation = new LinkLabel
        {
            Text = Info.SAMPLE_OUTPUTFILE_SPEECH_SPEECHACTANNOTATION,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };

        public LinkLabel linklbl_sample_segmentsinterval_speech_speechactannotation = new LinkLabel
        {
            Text = Info.SAMPLE_SEGMENTSINTERVAL_SPEECH_SPEECHACTANNOTATION,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };

        public LinkLabel linklbl_sample_audiosegments_speech_speechactannotation = new LinkLabel
        {
            Text = Info.SAMPLE_AUDIOSEGMENTS_SPEECH_SPEECHACTANNOTATION,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };

        public LinkLabel linklbl_sample_speechact_speech_speechactannotation = new LinkLabel
        {
            Text = Info.SAMPLE_SPEECHACT_SPEECH_SPEECHACTANNOTATION,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };

        public LinkLabel linklbl_sample_output_annotation_speech_speechactannotation = new LinkLabel
        {
            Text = Info.SAMPLE_OUTPUT_ANNOTATION_SPEECH_SPEECHACTANNOTATION,
            Margin = Padding.Empty,
            AutoSize = true,
            Dock = DockStyle.Fill,
            Font = Info.FONT_SAMPLES,

        };


        public Button btn_gotoFunction_home_speechActAnnotation_SpeechAnalysis = new Button { Text = Info.TEXT_BUTTON_GOTOHOME, AutoSize = true, BackColor = Color.AliceBlue, Font = new Font("Arial", 10, FontStyle.Bold) };
        public Button btn_gotoFunction_speechActAnnotation_SpeechAnalysis = new Button { Text = Info.TEXT_BUTTON_GOTOFUNCTION, AutoSize = true, BackColor = Color.AliceBlue, Font = new Font("Arial", 10, FontStyle.Bold) };
        #endregion
       


        public TableLayoutPanel getExtractAndFormatAudioWalkthroughLayout()
        {
            //start to design interface 
            TableLayoutPanel pnl_main_formatAudio = new TableLayoutPanel { Dock = DockStyle.Fill, AutoSize = true,  AutoSizeMode = AutoSizeMode.GrowAndShrink, AutoScroll = true };
            pnl_main_formatAudio.Margin = new Padding(0);
            pnl_main_formatAudio.ColumnCount = 2;
            pnl_main_formatAudio.RowCount = 2;

            TableLayoutPanel pnl_info = new TableLayoutPanel { Dock = DockStyle.Fill, Size = new Size(800, 800), AutoSizeMode = AutoSizeMode.GrowAndShrink, AutoScroll=true };
            pnl_info.Margin = new Padding(0);
            pnl_info.ColumnCount = 2;
            pnl_info.RowCount = 9;
            pnl_info.BackColor = System.Drawing.Color.LightBlue;
            pnl_info.Controls.Add(lbl_infotext_extractAndFormat, 0, 0);
            pnl_info.Controls.Add(lbl_info_extractAndFormat,0,1);
            pnl_info.SetColumnSpan(lbl_info_extractAndFormat, 2);
            pnl_info.Controls.Add(lbl_stepstext_extractAndFormat, 0, 2);

            TableLayoutPanel pnl_steps_1 = new TableLayoutPanel { Dock = DockStyle.Fill,  Height=40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_1.Margin = new Padding(0);
            pnl_steps_1.ColumnCount = 2;
            pnl_steps_1.RowCount = 1;
            pnl_steps_1.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_1.Controls.Add(lbl_steps_1_extractAndFormat,0,0);
            pnl_steps_1.Controls.Add(lbl_sampleoutputfolder_extractAndFormat, 1, 0);
            pnl_info.Controls.Add(pnl_steps_1, 0, 3);
            pnl_info.SetColumnSpan(pnl_steps_1, 2);


            TableLayoutPanel pnl_steps_2 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40,  AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_2.Margin = new Padding(0);
            pnl_steps_2.ColumnCount = 2;
            pnl_steps_2.RowCount = 1;
            pnl_steps_2.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_2.Controls.Add(lbl_steps_2_extractAndFormat, 0, 0);
            pnl_steps_2.Controls.Add(linklbl_samplefile_avi_extractAndFormat, 1, 0);
            linklbl_samplefile_avi_extractAndFormat.Links.Clear();
            linklbl_samplefile_avi_extractAndFormat.Links.Add(new LinkLabel.Link(0, 50, Info.LINK_AVI_FILE));
            this.linklbl_samplefile_avi_extractAndFormat.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_LinkClicked);
            pnl_info.Controls.Add(pnl_steps_2, 0, 4);
            pnl_info.SetColumnSpan(pnl_steps_2, 2);

            TableLayoutPanel pnl_steps_3 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_3.Margin = new Padding(0);
            pnl_steps_3.ColumnCount = 2;
            pnl_steps_3.RowCount = 1;
            pnl_steps_3.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_3.Controls.Add(lbl_steps_3_extractAndFormat, 0, 0);
            pnl_info.Controls.Add(pnl_steps_3, 0, 5);
            pnl_info.SetColumnSpan(pnl_steps_3, 2);



            pnl_info.Controls.Add(lbl_outputstext_extractAndFormat, 0, 6);

            TableLayoutPanel pnl_output = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_output.Margin = new Padding(0);
            pnl_output.ColumnCount = 2;
            pnl_output.RowCount = 1;
            pnl_output.BackColor = System.Drawing.Color.LightBlue;
            pnl_output.Controls.Add(lbl_outputs_extractAndFormat, 0, 0);
            pnl_output.Controls.Add(linklbl_samplefile_wav_extractAndFormat, 1, 0);
            linklbl_samplefile_wav_extractAndFormat.Links.Clear();
            linklbl_samplefile_wav_extractAndFormat.Links.Add(new LinkLabel.Link(0, 50, Info.LINK_WAV_FILE));
            this.linklbl_samplefile_wav_extractAndFormat.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_LinkClicked);
            pnl_info.Controls.Add(pnl_output, 0, 7);
            pnl_info.SetColumnSpan(pnl_output, 2);

 
            pnl_main_formatAudio.Controls.Add(pnl_info, 0, 0);
            pnl_main_formatAudio.SetColumnSpan(pnl_info, 2);
            pnl_main_formatAudio.Controls.Add(btn_gotoFunction_ExtractFormat_SpeechAnalysis, 1, 1);
            pnl_main_formatAudio.Controls.Add(btn_gotoFunction_home_ExtractFormat_SpeechAnalysis, 0, 1);

            return pnl_main_formatAudio;
        }

        public TableLayoutPanel getSegmentAudioWalkthroughLayout()
        {
            TableLayoutPanel pnl_main_segmentAudio = new TableLayoutPanel { Dock = DockStyle.Fill, AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink, AutoScroll = true };
            pnl_main_segmentAudio.Margin = new Padding(0);
            pnl_main_segmentAudio.ColumnCount = 2;
            pnl_main_segmentAudio.RowCount = 2;

            TableLayoutPanel pnl_info = new TableLayoutPanel { Dock = DockStyle.Fill, Size = new Size(800, 800), AutoSizeMode = AutoSizeMode.GrowAndShrink, AutoScroll = true };
            pnl_info.Margin = new Padding(0);
            pnl_info.ColumnCount = 2;
            pnl_info.RowCount = 9;
            pnl_info.BackColor = System.Drawing.Color.LightBlue;
            pnl_info.Controls.Add(lbl_infotext_segment, 0, 0);
            pnl_info.Controls.Add(lbl_info_segment, 0, 1);
            pnl_info.SetColumnSpan(lbl_info_segment, 2);
            pnl_info.Controls.Add(lbl_stepstext_segment, 0, 2);


            TableLayoutPanel pnl_steps_1 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_1.Margin = new Padding(0);
            pnl_steps_1.ColumnCount = 2;
            pnl_steps_1.RowCount = 1;
            pnl_steps_1.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_1.Controls.Add(lbl_steps_1_segment, 0, 0);
            pnl_steps_1.Controls.Add(lbl_sampleoutputfolder_segment, 1, 0);
            pnl_info.Controls.Add(pnl_steps_1, 0, 3);
            pnl_info.SetColumnSpan(pnl_steps_1, 2);

            TableLayoutPanel pnl_steps_2 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_2.Margin = new Padding(0);
            pnl_steps_2.ColumnCount = 2;
            pnl_steps_2.RowCount = 1;
            pnl_steps_2.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_2.Controls.Add(lbl_steps_2_segment, 0, 0);
            pnl_steps_2.Controls.Add(linklbl_samplefile_wav_segment, 1, 0);
            linklbl_samplefile_wav_segment.Links.Clear();
            linklbl_samplefile_wav_segment.Links.Add(new LinkLabel.Link(0, 50, Info.LINK_WAV_FILE));
            this.linklbl_samplefile_wav_segment.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_LinkClicked);
            pnl_info.Controls.Add(pnl_steps_2, 0, 4);
            pnl_info.SetColumnSpan(pnl_steps_2, 2);

            TableLayoutPanel pnl_steps_3 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_3.Margin = new Padding(0);
            pnl_steps_3.ColumnCount = 2;
            pnl_steps_3.RowCount = 1;
            pnl_steps_3.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_3.Controls.Add(lbl_steps_3_segment, 0, 0);
            pnl_info.Controls.Add(pnl_steps_3, 0, 5);
            pnl_info.SetColumnSpan(pnl_steps_3, 2);

            pnl_info.Controls.Add(lbl_outputstext_segment, 0, 6);

            TableLayoutPanel pnl_output_1 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_output_1.Margin = new Padding(0);
            pnl_output_1.ColumnCount = 2;
            pnl_output_1.RowCount = 1;
            pnl_output_1.BackColor = System.Drawing.Color.LightBlue;
            pnl_output_1.Controls.Add(lbl_outputs_1_segment, 0, 0);
            pnl_output_1.Controls.Add(linklbl_samplefile_audiosegments_segment, 1, 0);
            linklbl_samplefile_audiosegments_segment.Links.Clear();
            linklbl_samplefile_audiosegments_segment.Links.Add(new LinkLabel.Link(0, 50, Info.LINK_SEGMENT_AUDIO));
            this.linklbl_samplefile_audiosegments_segment.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_LinkClicked);
            pnl_info.Controls.Add(pnl_output_1, 0, 7);
            pnl_info.SetColumnSpan(pnl_output_1, 2);

            TableLayoutPanel pnl_output_2 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_output_2.Margin = new Padding(0);
            pnl_output_2.ColumnCount = 2;
            pnl_output_2.RowCount = 1;
            pnl_output_2.BackColor = System.Drawing.Color.LightBlue;
            pnl_output_2.Controls.Add(lbl_outputs_2_segment, 0, 0);
            pnl_output_2.Controls.Add(linklbl_samplefile_segmentInterval_segment, 1, 0);
            linklbl_samplefile_segmentInterval_segment.Links.Clear();
            linklbl_samplefile_segmentInterval_segment.Links.Add(new LinkLabel.Link(0, 50, Info.LINK_SEGMENT_INTERVAL));
            this.linklbl_samplefile_segmentInterval_segment.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_LinkClicked);
            pnl_info.Controls.Add(pnl_output_2, 0, 8);
            pnl_info.SetColumnSpan(pnl_output_2, 2);

            pnl_main_segmentAudio.Controls.Add(pnl_info, 0, 0);
            pnl_main_segmentAudio.SetColumnSpan(pnl_info, 2);
            pnl_main_segmentAudio.Controls.Add(btn_gotoFunction_SegmentAudio_SpeechAnalysis, 1, 1);
            pnl_main_segmentAudio.Controls.Add(btn_gotoFunction_home_segment_SpeechAnalysis, 0, 1);

            return pnl_main_segmentAudio;
        }

        public TableLayoutPanel getSpecifyTimeIntervalWalkthroughLayout()
        {
            TableLayoutPanel pnl_main_specifyTimeInterval = new TableLayoutPanel { Dock = DockStyle.Fill, AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink, AutoScroll = true };
            pnl_main_specifyTimeInterval.Margin = new Padding(0);
            pnl_main_specifyTimeInterval.ColumnCount = 2;
            pnl_main_specifyTimeInterval.RowCount = 2;

            TableLayoutPanel pnl_info = new TableLayoutPanel { Dock = DockStyle.Fill, Size = new Size(800, 800), AutoSizeMode = AutoSizeMode.GrowAndShrink, AutoScroll = true };
            pnl_info.Margin = new Padding(0);
            pnl_info.ColumnCount = 2;
            pnl_info.RowCount = 18;
            pnl_info.BackColor = System.Drawing.Color.LightBlue;
            pnl_info.Controls.Add(lbl_infotext_determine_interval, 0, 0);
            pnl_info.Controls.Add(lbl_info_determine_interval, 0, 1);
            pnl_info.SetColumnSpan(lbl_info_determine_interval, 2);
            pnl_info.Controls.Add(lbl_stepstext_determine_interval, 0, 2);

            TableLayoutPanel pnl_steps_1 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_1.Margin = new Padding(0);
            pnl_steps_1.ColumnCount = 2;
            pnl_steps_1.RowCount = 1;
            pnl_steps_1.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_1.Controls.Add(lbl_steps_1_determine_interval, 0, 0);
            pnl_steps_1.Controls.Add(lbl_sample_outputfile_speech_determineinterval, 1, 0);
            pnl_info.Controls.Add(pnl_steps_1, 0, 3);
            pnl_info.SetColumnSpan(pnl_steps_1, 2);

            TableLayoutPanel pnl_steps_2 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_2.Margin = new Padding(0);
            pnl_steps_2.ColumnCount = 2;
            pnl_steps_2.RowCount = 1;
            pnl_steps_2.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_2.Controls.Add(lbl_steps_2_determine_interval, 0, 0);
            pnl_info.Controls.Add(pnl_steps_2, 0, 4);
            pnl_info.SetColumnSpan(pnl_steps_2, 2);

            TableLayoutPanel pnl_steps_3 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_3.Margin = new Padding(0);
            pnl_steps_3.ColumnCount = 2;
            pnl_steps_3.RowCount = 1;
            pnl_steps_3.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_3.Controls.Add(lbl_steps_3_determine_interval, 0, 0);
            pnl_steps_3.Controls.Add(lbl_sample_id_speech_determineinterval, 1, 0);
            pnl_info.Controls.Add(pnl_steps_3, 0, 5);
            pnl_info.SetColumnSpan(pnl_steps_3, 2);

            TableLayoutPanel pnl_steps_4 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_4.Margin = new Padding(0);
            pnl_steps_4.ColumnCount = 2;
            pnl_steps_4.RowCount = 1;
            pnl_steps_4.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_4.Controls.Add(lbl_steps_4_determine_interval, 0, 0);
            pnl_steps_4.Controls.Add(linklbl_sample_segmentinterval_speech_determineinterval, 1, 0);
            linklbl_sample_segmentinterval_speech_determineinterval.Links.Clear();
            linklbl_sample_segmentinterval_speech_determineinterval.Links.Add(new LinkLabel.Link(0, 50, Info.LINK_SEGMENT_INTERVAL));
            this.linklbl_sample_segmentinterval_speech_determineinterval.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_LinkClicked);
            pnl_info.Controls.Add(pnl_steps_4, 0, 6);
            pnl_info.SetColumnSpan(pnl_steps_4, 2);
            
            TableLayoutPanel pnl_steps_5 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_5.Margin = new Padding(0);
            pnl_steps_5.ColumnCount = 2;
            pnl_steps_5.RowCount = 1;
            pnl_steps_5.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_5.Controls.Add(lbl_steps_5_determine_interval, 0, 0);
            pnl_steps_5.Controls.Add(lbl_sample_experimentinterval_speech_determineinterval, 1, 0);
            pnl_info.Controls.Add(pnl_steps_5, 0, 7);
            pnl_info.SetColumnSpan(pnl_steps_5, 2);

            TableLayoutPanel pnl_steps_51 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_51.Margin = new Padding(0);
            pnl_steps_51.ColumnCount = 2;
            pnl_steps_51.RowCount = 1;
            pnl_steps_51.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_51.Controls.Add(lbl_steps_51_determine_interval, 0, 0);
            pnl_info.Controls.Add(pnl_steps_51, 0, 8);
            pnl_info.SetColumnSpan(pnl_steps_51, 2);

            TableLayoutPanel pnl_steps_52 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_52.Margin = new Padding(0);
            pnl_steps_52.ColumnCount = 2;
            pnl_steps_52.RowCount = 1;
            pnl_steps_52.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_52.Controls.Add(lbl_steps_52_determine_interval, 0, 0);
            pnl_info.Controls.Add(pnl_steps_52, 0, 9);
            pnl_info.SetColumnSpan(pnl_steps_52, 2);

            TableLayoutPanel pnl_steps_6 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_6.Margin = new Padding(0);
            pnl_steps_6.ColumnCount = 2;
            pnl_steps_6.RowCount = 1;
            pnl_steps_6.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_6.Controls.Add(lbl_steps_6_determine_interval, 0, 0);
            pnl_info.Controls.Add(pnl_steps_6, 0, 10);
            pnl_info.SetColumnSpan(pnl_steps_6, 2);

            TableLayoutPanel pnl_steps_61 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_61.Margin = new Padding(0);
            pnl_steps_61.ColumnCount = 2;
            pnl_steps_61.RowCount = 1;
            pnl_steps_61.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_61.Controls.Add(lbl_steps_61_determine_interval, 0, 0);
            pnl_steps_61.Controls.Add(lbl_sample_resegment_inner1_speech_determineinterval, 1, 0);
            pnl_info.Controls.Add(pnl_steps_61, 0, 11);
            pnl_info.SetColumnSpan(pnl_steps_61, 2);

            TableLayoutPanel pnl_steps_62 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_62.Margin = new Padding(0);
            pnl_steps_62.ColumnCount = 2;
            pnl_steps_62.RowCount = 1;
            pnl_steps_62.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_62.Controls.Add(lbl_steps_62_determine_interval, 0, 0);
            pnl_info.Controls.Add(pnl_steps_62, 0, 11);
            pnl_info.SetColumnSpan(pnl_steps_62, 2);

            TableLayoutPanel pnl_steps_63 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_63.Margin = new Padding(0);
            pnl_steps_63.ColumnCount = 2;
            pnl_steps_63.RowCount = 1;
            pnl_steps_63.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_63.Controls.Add(lbl_steps_63_determine_interval, 0, 0);
            pnl_steps_63.Controls.Add(linklbl_sample_resegment_inner3_speech_determineinterval, 1, 0);
            linklbl_sample_resegment_inner3_speech_determineinterval.Links.Clear();
            linklbl_sample_resegment_inner3_speech_determineinterval.Links.Add(new LinkLabel.Link(0, 50, Info.LINK_WAV_FILE));
            this.linklbl_sample_resegment_inner3_speech_determineinterval.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_LinkClicked);
            pnl_info.Controls.Add(pnl_steps_63, 0, 12);
            pnl_info.SetColumnSpan(pnl_steps_63, 2);

            TableLayoutPanel pnl_steps_7 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_7.Margin = new Padding(0);
            pnl_steps_7.ColumnCount = 2;
            pnl_steps_7.RowCount = 1;
            pnl_steps_7.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_7.Controls.Add(lbl_steps_7_determine_interval, 0, 0);
            pnl_info.Controls.Add(pnl_steps_7, 0, 13);
            pnl_info.SetColumnSpan(pnl_steps_7, 2);

            pnl_info.Controls.Add(lbl_outputstext_determine_interval, 0, 14);

            TableLayoutPanel pnl_output_1 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_output_1.Margin = new Padding(0);
            pnl_output_1.ColumnCount = 2;
            pnl_output_1.RowCount = 1;
            pnl_output_1.BackColor = System.Drawing.Color.LightBlue;
            pnl_output_1.Controls.Add(lbl_outputs_1_determine_interval, 0, 0);
            pnl_output_1.Controls.Add(linklbl_sample_output_experimentinterval_speech_determineinterval, 1, 0);
            linklbl_sample_output_experimentinterval_speech_determineinterval.Links.Clear();
            linklbl_sample_output_experimentinterval_speech_determineinterval.Links.Add(new LinkLabel.Link(0, 50, Info.LINK_EXP_INTERVAL));
            this.linklbl_sample_output_experimentinterval_speech_determineinterval.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_LinkClicked);
            pnl_info.Controls.Add(pnl_output_1, 0, 15);
            pnl_info.SetColumnSpan(pnl_output_1, 2);


            TableLayoutPanel pnl_output_2 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_output_2.Margin = new Padding(0);
            pnl_output_2.ColumnCount = 2;
            pnl_output_2.RowCount = 1;
            pnl_output_2.BackColor = System.Drawing.Color.LightBlue;
            pnl_output_2.Controls.Add(lbl_outputs_2_determine_interval, 0, 0);
            pnl_output_2.Controls.Add(linklbl_sample_output_resegmentsinterval_speech_determineinterval, 1, 0);
            linklbl_sample_output_resegmentsinterval_speech_determineinterval.Links.Clear();
            linklbl_sample_output_resegmentsinterval_speech_determineinterval.Links.Add(new LinkLabel.Link(0, 50, Info.LINK_RESEGMENTED_INTERVAL));
            this.linklbl_sample_output_resegmentsinterval_speech_determineinterval.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_LinkClicked);
            pnl_info.Controls.Add(pnl_output_2, 0, 16);
            pnl_info.SetColumnSpan(pnl_output_2, 2);

            TableLayoutPanel pnl_output_3 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_output_3.Margin = new Padding(0);
            pnl_output_3.ColumnCount = 2;
            pnl_output_3.RowCount = 1;
            pnl_output_3.BackColor = System.Drawing.Color.LightBlue;
            pnl_output_3.Controls.Add(lbl_outputs_3_determine_interval, 0, 0);
            pnl_output_3.Controls.Add(linklbl_sample_output_audioresegments_speech_determineinterval, 1, 0);
            linklbl_sample_output_audioresegments_speech_determineinterval.Links.Clear();
            linklbl_sample_output_audioresegments_speech_determineinterval.Links.Add(new LinkLabel.Link(0, 50, Info.LINK_RESEGMENTED_AUDIO));
            this.linklbl_sample_output_audioresegments_speech_determineinterval.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_LinkClicked);
            pnl_info.Controls.Add(pnl_output_3, 0, 17);
            pnl_info.SetColumnSpan(pnl_output_3, 2);


            pnl_main_specifyTimeInterval.Controls.Add(pnl_info, 0, 0);
            pnl_main_specifyTimeInterval.SetColumnSpan(pnl_info, 2);
            pnl_main_specifyTimeInterval.Controls.Add(btn_gotoFunction_TimeIntervalSpecification_SpeechAnalysis, 1, 1);
            pnl_main_specifyTimeInterval.Controls.Add(btn_gotoFunction_home_determineInterval_SpeechAnalysis, 0, 1);

            return pnl_main_specifyTimeInterval;
        }

        public TableLayoutPanel getDefineSpeechActWalkthroughLayout()
        {
            TableLayoutPanel pnl_main_defineSpeechAct = new TableLayoutPanel { Dock = DockStyle.Fill, AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink, AutoScroll = true };
            pnl_main_defineSpeechAct.Margin = new Padding(0);
            pnl_main_defineSpeechAct.ColumnCount = 2;
            pnl_main_defineSpeechAct.RowCount = 2;

            TableLayoutPanel pnl_info = new TableLayoutPanel { Dock = DockStyle.Fill, Size = new Size(800, 800), AutoSizeMode = AutoSizeMode.GrowAndShrink, AutoScroll=true };
            pnl_info.Margin = new Padding(0);
            pnl_info.ColumnCount = 2;
            pnl_info.RowCount = 10;
            pnl_info.BackColor = System.Drawing.Color.LightBlue;
            pnl_info.Controls.Add(lbl_infotext_defineSpeechAct, 0, 0);
            pnl_info.Controls.Add(lbl_info_defineSpeechAct, 0, 1);
            pnl_info.SetColumnSpan(lbl_info_defineSpeechAct, 2);
            pnl_info.Controls.Add(lbl_stepstext_defineSpeechAct, 0, 2);

            TableLayoutPanel pnl_steps_1 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_1.Margin = new Padding(0);
            pnl_steps_1.ColumnCount = 2;
            pnl_steps_1.RowCount = 1;
            pnl_steps_1.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_1.Controls.Add(lbl_steps_1_defineSpeechAct, 0, 0);
            pnl_steps_1.Controls.Add(lbl_sample_outputfile_speech_definespeechact, 1, 0);
            pnl_info.Controls.Add(pnl_steps_1, 0, 3);
            pnl_info.SetColumnSpan(pnl_steps_1, 2);

            TableLayoutPanel pnl_steps_2 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_2.Margin = new Padding(0);
            pnl_steps_2.ColumnCount = 2;
            pnl_steps_2.RowCount = 1;
            pnl_steps_2.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_2.Controls.Add(lbl_steps_2_defineSpeechAct, 0, 0);
            pnl_steps_2.Controls.Add(lbl_sample_enterspeechact_speech_definespeechact, 1, 0);
            pnl_info.Controls.Add(pnl_steps_2, 0, 4);
            pnl_info.SetColumnSpan(pnl_steps_2, 2);

            TableLayoutPanel pnl_steps_3 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_3.Margin = new Padding(0);
            pnl_steps_3.ColumnCount = 2;
            pnl_steps_3.RowCount = 1;
            pnl_steps_3.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_3.Controls.Add(lbl_steps_3_defineSpeechAct, 0, 0);
            pnl_info.Controls.Add(pnl_steps_3, 0, 5);
            pnl_info.SetColumnSpan(pnl_steps_3, 2);

            TableLayoutPanel pnl_steps_4 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_4.Margin = new Padding(0);
            pnl_steps_4.ColumnCount = 2;
            pnl_steps_4.RowCount = 1;
            pnl_steps_4.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_4.Controls.Add(lbl_steps_4_defineSpeechAct, 0, 0);
            pnl_info.Controls.Add(pnl_steps_4, 0, 6);
            pnl_info.SetColumnSpan(pnl_steps_4, 2);

            TableLayoutPanel pnl_steps_5 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_5.Margin = new Padding(0);
            pnl_steps_5.ColumnCount = 2;
            pnl_steps_5.RowCount = 1;
            pnl_steps_5.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_5.Controls.Add(lbl_steps_5_defineSpeechAct, 0, 0);
            pnl_info.Controls.Add(pnl_steps_5, 0, 7);
            pnl_info.SetColumnSpan(pnl_steps_5, 2);

            TableLayoutPanel pnl_steps_6 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_6.Margin = new Padding(0);
            pnl_steps_6.ColumnCount = 2;
            pnl_steps_6.RowCount = 1;
            pnl_steps_6.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_6.Controls.Add(lbl_steps_6_defineSpeechAct, 0, 0);
            pnl_info.Controls.Add(pnl_steps_6, 0, 7);
            pnl_info.SetColumnSpan(pnl_steps_6, 2);

            pnl_info.Controls.Add(lbl_outputstext_defineSpeechAct, 0, 8);

            TableLayoutPanel pnl_output = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_output.Margin = new Padding(0);
            pnl_output.ColumnCount = 2;
            pnl_output.RowCount = 1;
            pnl_output.BackColor = System.Drawing.Color.LightBlue;
            pnl_output.Controls.Add(lbl_outputs_defineSpeechAct, 0, 0);
            pnl_output.Controls.Add(linklbl_sample_output_speechacts_speech_definespeechact, 1, 0);
            linklbl_sample_output_speechacts_speech_definespeechact.Links.Clear();
            linklbl_sample_output_speechacts_speech_definespeechact.Links.Add(new LinkLabel.Link(0, 50, Info.LINK_SPEECH_ACTS));
            this.linklbl_sample_output_speechacts_speech_definespeechact.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_LinkClicked);
            pnl_info.Controls.Add(pnl_output, 0, 9);
            pnl_info.SetColumnSpan(pnl_output, 2);


            pnl_main_defineSpeechAct.Controls.Add(pnl_info, 0, 0);
            pnl_main_defineSpeechAct.SetColumnSpan(pnl_info, 2);
            pnl_main_defineSpeechAct.Controls.Add(btn_gotoFunction_defineSpeechAct_SpeechAnalysis, 1, 1);
            pnl_main_defineSpeechAct.Controls.Add(btn_gotoFunction_home_defineSpeechAct_SpeechAnalysis, 0, 1);

            return pnl_main_defineSpeechAct;
        }

        public TableLayoutPanel getAnnotationWalkthroughLayout()
        {
            TableLayoutPanel pnl_main_speechActAnnotation = new TableLayoutPanel { Dock = DockStyle.Fill, AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink, AutoScroll = true };
            pnl_main_speechActAnnotation.Margin = new Padding(0);
            pnl_main_speechActAnnotation.ColumnCount = 2;
            pnl_main_speechActAnnotation.RowCount = 2;

            TableLayoutPanel pnl_info = new TableLayoutPanel { Dock = DockStyle.Fill, Size = new Size(800, 800), AutoSizeMode = AutoSizeMode.GrowAndShrink, AutoScroll = true };
            pnl_info.Margin = new Padding(0);
            pnl_info.ColumnCount = 2;
            pnl_info.RowCount = 13;
            pnl_info.BackColor = System.Drawing.Color.LightBlue;
            pnl_info.Controls.Add(lbl_infotext_speechActAnnotation, 0, 0);
            pnl_info.Controls.Add(lbl_info_speechActAnnotation, 0, 1);
            pnl_info.SetColumnSpan(lbl_info_speechActAnnotation, 2);
            pnl_info.Controls.Add(lbl_stepstext_speechActAnnotation, 0, 2);

            TableLayoutPanel pnl_steps_1 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_1.Margin = new Padding(0);
            pnl_steps_1.ColumnCount = 2;
            pnl_steps_1.RowCount = 1;
            pnl_steps_1.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_1.Controls.Add(lbl_steps_1_speechActAnnotation, 0, 0);
            pnl_steps_1.Controls.Add(lbl_sample_outputfile_speech_speechactannotation, 1, 0);
            pnl_info.Controls.Add(pnl_steps_1, 0, 3);
            pnl_info.SetColumnSpan(pnl_steps_1, 2);

            TableLayoutPanel pnl_steps_2 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_2.Margin = new Padding(0);
            pnl_steps_2.ColumnCount = 2;
            pnl_steps_2.RowCount = 1;
            pnl_steps_2.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_2.Controls.Add(lbl_steps_2_speechActAnnotation, 0, 0);
            pnl_steps_2.Controls.Add(linklbl_sample_segmentsinterval_speech_speechactannotation, 1, 0);
            linklbl_sample_segmentsinterval_speech_speechactannotation.Links.Clear();
            linklbl_sample_segmentsinterval_speech_speechactannotation.Links.Add(new LinkLabel.Link(0, 50, Info.LINK_RESEGMENTED_INTERVAL));
            this.linklbl_sample_segmentsinterval_speech_speechactannotation.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_LinkClicked);
            pnl_info.Controls.Add(pnl_steps_2, 0, 4);
            pnl_info.SetColumnSpan(pnl_steps_2, 2);

            TableLayoutPanel pnl_steps_3 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_3.Margin = new Padding(0);
            pnl_steps_3.ColumnCount = 2;
            pnl_steps_3.RowCount = 1;
            pnl_steps_3.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_3.Controls.Add(lbl_steps_3_speechActAnnotation, 0, 0);
            pnl_steps_3.Controls.Add(linklbl_sample_audiosegments_speech_speechactannotation, 1, 0);
            linklbl_sample_audiosegments_speech_speechactannotation.Links.Clear();
            linklbl_sample_audiosegments_speech_speechactannotation.Links.Add(new LinkLabel.Link(0, 50, Info.LINK_RESEGMENTED_AUDIO));
            this.linklbl_sample_audiosegments_speech_speechactannotation.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_LinkClicked);
            pnl_info.Controls.Add(pnl_steps_3, 0, 5);
            pnl_info.SetColumnSpan(pnl_steps_3, 2);

            TableLayoutPanel pnl_steps_4 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_4.Margin = new Padding(0);
            pnl_steps_4.ColumnCount = 2;
            pnl_steps_4.RowCount = 1;
            pnl_steps_4.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_4.Controls.Add(lbl_steps_4_speechActAnnotation, 0, 0);
            pnl_steps_4.Controls.Add(linklbl_sample_speechact_speech_speechactannotation, 1, 0);
            linklbl_sample_speechact_speech_speechactannotation.Links.Clear();
            linklbl_sample_speechact_speech_speechactannotation.Links.Add(new LinkLabel.Link(0, 50, Info.LINK_SPEECH_ACTS));
            this.linklbl_sample_speechact_speech_speechactannotation.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_LinkClicked);
            pnl_info.Controls.Add(pnl_steps_4, 0, 6);
            pnl_info.SetColumnSpan(pnl_steps_4, 2);

            TableLayoutPanel pnl_steps_5 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_5.Margin = new Padding(0);
            pnl_steps_5.ColumnCount = 2;
            pnl_steps_5.RowCount = 1;
            pnl_steps_5.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_5.Controls.Add(lbl_steps_5_speechActAnnotation, 0, 0);
            pnl_info.Controls.Add(pnl_steps_5, 0, 7);
            pnl_info.SetColumnSpan(pnl_steps_5, 2);


            TableLayoutPanel pnl_steps_6 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_6.Margin = new Padding(0);
            pnl_steps_6.ColumnCount = 2;
            pnl_steps_6.RowCount = 1;
            pnl_steps_6.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_6.Controls.Add(lbl_steps_6_speechActAnnotation, 0, 0);
            pnl_info.Controls.Add(pnl_steps_6, 0, 8);
            pnl_info.SetColumnSpan(pnl_steps_6, 2);

            TableLayoutPanel pnl_steps_7 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_7.Margin = new Padding(0);
            pnl_steps_7.ColumnCount = 2;
            pnl_steps_7.RowCount = 1;
            pnl_steps_7.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_7.Controls.Add(lbl_steps_7_speechActAnnotation, 0, 0);
            pnl_info.Controls.Add(pnl_steps_7, 0, 9);
            pnl_info.SetColumnSpan(pnl_steps_7, 2);

            TableLayoutPanel pnl_steps_8 = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_steps_8.Margin = new Padding(0);
            pnl_steps_8.ColumnCount = 2;
            pnl_steps_8.RowCount = 1;
            pnl_steps_8.BackColor = System.Drawing.Color.LightBlue;
            pnl_steps_8.Controls.Add(lbl_steps_8_speechActAnnotation, 0, 0);
            pnl_info.Controls.Add(pnl_steps_8, 0, 10);
            pnl_info.SetColumnSpan(pnl_steps_8, 2);

            pnl_info.Controls.Add(lbl_outputstext_speechActAnnotation, 0, 11);

            TableLayoutPanel pnl_output = new TableLayoutPanel { Dock = DockStyle.Fill, Height = 40, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            pnl_output.Margin = new Padding(0);
            pnl_output.ColumnCount = 2;
            pnl_output.RowCount = 1;
            pnl_output.BackColor = System.Drawing.Color.LightBlue;
            pnl_output.Controls.Add(lbl_outputs_speechActAnnotation, 0, 0);
            pnl_output.Controls.Add(linklbl_sample_output_annotation_speech_speechactannotation, 1, 0);
            linklbl_sample_output_annotation_speech_speechactannotation.Links.Clear();
            linklbl_sample_output_annotation_speech_speechactannotation.Links.Add(new LinkLabel.Link(0, 50, Info.LINK_SPEECH_ANNOTATION));
            this.linklbl_sample_output_annotation_speech_speechactannotation.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_LinkClicked);
            pnl_info.Controls.Add(pnl_output, 0, 12);
            pnl_info.SetColumnSpan(pnl_output, 2);

            pnl_main_speechActAnnotation.Controls.Add(pnl_info, 0, 0);
            pnl_main_speechActAnnotation.SetColumnSpan(pnl_info, 2);
            pnl_main_speechActAnnotation.Controls.Add(btn_gotoFunction_speechActAnnotation_SpeechAnalysis, 1, 1);
            pnl_main_speechActAnnotation.Controls.Add(btn_gotoFunction_home_speechActAnnotation_SpeechAnalysis, 0, 1);

            return pnl_main_speechActAnnotation;
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
