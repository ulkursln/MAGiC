using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAGiC
{
    public interface INavigationListener
    {
        //Navigate to Speech Analysis Items
        void navigateToExtractFormatAudio();
        void navigateToExtractFormatAudioWalkthrough();

        void navigateToSegmentAudio();
        void navigateToSegmentAudioWalkthrough();

        void navigateToSpecifyTimeInterval();
        void navigateToSpecifyTimeIntervalWalkthrough();

        void navigateToDefineSpeechAct();
        void navigateToDefineSpeechActWalkthrough();

        void navigateToAnnotation();
        void navigateToAnnotationWalkthrough();

        //Navigate to AOI Analysis Items
        void navigateToFaceTrackingWithDefaultDetector();
        void navigateToFaceTrackingWithDefaultDetectorWalkthrough();

        void navigateToFaceTrackingWithTrainedDetector();
        void navigateToFaceTrackingWithTrainedDetectorWalkthrough();

        void navigateToPreProcessGazeData();
        void navigateToPreProcessGazeDataWalkthrough();

        void navigateToDetectAOI();
        void navigateToDetectAOIWalkthrough();

        void navigateToVisualizeTrackingResults();
        void navigateToVisualizeTrackingResultsWalkthrough();

        void navigateToFindDetectionRatio();
        void navigateToFindDetectionRatioWalkthrough();

        void navigateToLabelAOIManually();
        void navigateToLabelAOIManuallyWalkthrough();

        void navigateToReanalyseAOI();
        void navigateToReanalyseAOIWalkthrough();

        //Summary
        void navigateToSummary();
        void navigateToSummaryWalkthrough();

        void navigateToWalkthroughHome();



    }
}
