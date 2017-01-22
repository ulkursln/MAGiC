using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAGiC
{
    public class AOIAnalysisWalkthroughBE
    {
        private AOIAnalysisWalkthroughUI controls;
        public AOIAnalysisWalkthroughBE(AOIAnalysisWalkthroughUI _controls)
        {
            controls = _controls;
            initialize();
        }

        public AOIAnalysisWalkthroughBE()
        {
            initialize();
        }


        private void initialize()
        {
            controls.btn_gotoFunction_detectAOIs_AOIAnalysis.Click += new System.EventHandler(this.btn_gotoFunction_detectAOIs_AOIAnalysis_Click);
            controls.btn_gotoFunction_findAOIsDetectionRatio_AOIAnalysis.Click += new System.EventHandler(this.btn_gotoFunction_findAOIsDetectionRatio_AOIAnalysis_Click);
            controls.btn_gotoFunction_labelAOIsManually_AOIAnalysis.Click += new System.EventHandler(this.btn_gotoFunction_labelAOIsManually_AOIAnalysis_Click);
            controls.btn_gotoFunction_preprocessGazeData_AOIAnalysis.Click += new System.EventHandler(this.btn_gotoFunction_preprocessGazeData_AOIAnalysis_Click);
            controls.btn_gotoFunction_reanalyseAOIs_AOIAnalysis.Click += new System.EventHandler(this.btn_gotoFunction_reanalyseAOIs_AOIAnalysis_Click);
            controls.btn_gotoFunction_trackingWithDefaultDetector_AOIAnalysis.Click += new System.EventHandler(this.btn_gotoFunction_trackingWithDefaultDetector_AOIAnalysis_Click);
            controls.btn_gotoFunction_trackingWithTrainedDetector_AOIAnalysis.Click += new System.EventHandler(this.btn_gotoFunction_trackingWithTrainedDetector_AOIAnalysis_Click);
            controls.btn_gotoFunction_visualizeTracking_AOIAnalysis.Click += new System.EventHandler(this.btn_gotoFunction_visualizeTracking_AOIAnalysis_Click);

            controls.btn_gotoFunction_home_detectAOIs_AOIAnalysis.Click += new System.EventHandler(this.btn_gotoFunction_home_Click);
            controls.btn_gotoFunction_home_findAOIsDetectionRatio_AOIAnalysis.Click += new System.EventHandler(this.btn_gotoFunction_home_Click);
            controls.btn_gotoFunction_home_labelAOIsManually_AOIAnalysis.Click += new System.EventHandler(this.btn_gotoFunction_home_Click);
            controls.btn_gotoFunction_home_preprocessGazeData_AOIAnalysis.Click += new System.EventHandler(this.btn_gotoFunction_home_Click);
            controls.btn_gotoFunction_home_reanalyseAOIs_AOIAnalysis.Click += new System.EventHandler(this.btn_gotoFunction_home_Click);
            controls.btn_gotoFunction_home_trackingWithDefaultDetector_AOIAnalysis.Click += new System.EventHandler(this.btn_gotoFunction_home_Click);
            controls.btn_gotoFunction_home_trackingWithTrainedDetector_AOIAnalysis.Click += new System.EventHandler(this.btn_gotoFunction_home_Click);
            controls.btn_gotoFunction_home_visualizeTracking_AOIAnalysis.Click += new System.EventHandler(this.btn_gotoFunction_home_Click);

        }

        private void btn_gotoFunction_home_Click(object sender, EventArgs e)
        {
            controls.navigationListener.navigateToWalkthroughHome();
        }

        private void btn_gotoFunction_visualizeTracking_AOIAnalysis_Click(object sender, EventArgs e)
        {
            controls.navigationListener.navigateToVisualizeTrackingResults();
        }

        private void btn_gotoFunction_trackingWithTrainedDetector_AOIAnalysis_Click(object sender, EventArgs e)
        {
            controls.navigationListener.navigateToFaceTrackingWithTrainedDetector();
        }

        private void btn_gotoFunction_trackingWithDefaultDetector_AOIAnalysis_Click(object sender, EventArgs e)
        {
            controls.navigationListener.navigateToFaceTrackingWithDefaultDetector();
        }

        private void btn_gotoFunction_reanalyseAOIs_AOIAnalysis_Click(object sender, EventArgs e)
        {
            controls.navigationListener.navigateToReanalyseAOI();
        }

        private void btn_gotoFunction_preprocessGazeData_AOIAnalysis_Click(object sender, EventArgs e)
        {
            controls.navigationListener.navigateToPreProcessGazeData();
        }

        private void btn_gotoFunction_labelAOIsManually_AOIAnalysis_Click(object sender, EventArgs e)
        {
            controls.navigationListener.navigateToLabelAOIManually();
        }

        private void btn_gotoFunction_findAOIsDetectionRatio_AOIAnalysis_Click(object sender, EventArgs e)
        {
            controls.navigationListener.navigateToFindDetectionRatio();
        }

        private void btn_gotoFunction_detectAOIs_AOIAnalysis_Click(object sender, EventArgs e)
        {
            controls.navigationListener.navigateToDetectAOI();
        }
    }
}
