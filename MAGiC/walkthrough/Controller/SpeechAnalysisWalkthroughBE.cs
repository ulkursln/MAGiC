using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAGiC
{
    public class SpeechAnalysisWalkthroughBE
    {

        private SpeechAnalysisWalkthroughUI controls;
        public SpeechAnalysisWalkthroughBE(SpeechAnalysisWalkthroughUI _controls)
        {
            controls = _controls;
            initialize();
        }

        public SpeechAnalysisWalkthroughBE()
        {
            initialize();
        }


        private void initialize()
        {
            controls.btn_gotoFunction_ExtractFormat_SpeechAnalysis.Click += new System.EventHandler(this.btn_gotoFunction_ExtractFormat_SpeechAnalysis_Click);
            controls.btn_gotoFunction_SegmentAudio_SpeechAnalysis.Click += new System.EventHandler(this.btn_gotoFunction_SegmentAudio_SpeechAnalysis_Click);
            controls.btn_gotoFunction_TimeIntervalSpecification_SpeechAnalysis.Click += new System.EventHandler(this.btn_gotoFunction_TimeIntervalSpecification_SpeechAnalysis_Click);
            controls.btn_gotoFunction_defineSpeechAct_SpeechAnalysis.Click += new System.EventHandler(this.btn_gotoFunction_defineSpeechAct_SpeechAnalysis_Click);
            controls.btn_gotoFunction_speechActAnnotation_SpeechAnalysis.Click += new System.EventHandler(this.btn_gotoFunction_speechActAnnotation_SpeechAnalysis_Click);

            controls.btn_gotoFunction_home_defineSpeechAct_SpeechAnalysis.Click += new System.EventHandler(this.btn_gotoFunction_home_Click);
            controls.btn_gotoFunction_home_determineInterval_SpeechAnalysis.Click += new System.EventHandler(this.btn_gotoFunction_home_Click);
            controls.btn_gotoFunction_home_ExtractFormat_SpeechAnalysis.Click += new System.EventHandler(this.btn_gotoFunction_home_Click);
            controls.btn_gotoFunction_home_segment_SpeechAnalysis.Click += new System.EventHandler(this.btn_gotoFunction_home_Click);
            controls.btn_gotoFunction_home_speechActAnnotation_SpeechAnalysis.Click += new System.EventHandler(this.btn_gotoFunction_home_Click);

        }

        private void btn_gotoFunction_home_Click(object sender, EventArgs e)
        {
            controls.navigationListener.navigateToWalkthroughHome();
        }

        private void btn_gotoFunction_speechActAnnotation_SpeechAnalysis_Click(object sender, EventArgs e)
        {
            controls.navigationListener.navigateToAnnotation();
        }

        private void btn_gotoFunction_defineSpeechAct_SpeechAnalysis_Click(object sender, EventArgs e)
        {
            controls.navigationListener.navigateToDefineSpeechAct();
        }

        private void btn_gotoFunction_TimeIntervalSpecification_SpeechAnalysis_Click(object sender, EventArgs e)
        {
            controls.navigationListener.navigateToSpecifyTimeInterval();
        }

        private void btn_gotoFunction_SegmentAudio_SpeechAnalysis_Click(object sender, EventArgs e)
        {
            controls.navigationListener.navigateToSegmentAudio();
        }

        private void btn_gotoFunction_ExtractFormat_SpeechAnalysis_Click(object sender, EventArgs e)
        {
            controls.navigationListener.navigateToExtractFormatAudio();
        }
    }
}
