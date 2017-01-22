using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAGiC
{
    public  class ImageConversion
    {
        public int faceTracking_workon_image_width;
        public int faceTracking_workon_image_hegiht;

        public int eyeTracker_raw_data_image_width;
        public int eyeTracker_raw_data_image_height;

        public double error_x = 0;
        public double error_y = 0;

        public Point eyeTrackerToFaceTrackingFramework( int raw_x,  int raw_y)
        {
            raw_x = raw_x * faceTracking_workon_image_width / eyeTracker_raw_data_image_width;
            raw_x = (raw_x + Constants.offset_x) > faceTracking_workon_image_width ? faceTracking_workon_image_width : ((raw_x + Constants.offset_x) < 0 ? 0 : (raw_x + Constants.offset_x));

            raw_y = raw_y * faceTracking_workon_image_hegiht / eyeTracker_raw_data_image_height;
            raw_y = (raw_y + Constants.offset_y) > faceTracking_workon_image_hegiht ? faceTracking_workon_image_hegiht : ((raw_y + Constants.offset_y) < 0 ? 0 : (raw_y + Constants.offset_y));

            return new Point(raw_x, raw_y);
        }

        public List<Point> eyeTrackerToFaceTrackingFrameworkWithErrors(int raw_x, int raw_y)
        {
            //possible x,y points: x-error_x,y-error_y; x+error_x,y-error_y; x,y+error_y; x+errror_x,y+error_y
            List<Point> list_xy = new List<Point>();
            eyeTrackerToFaceTrackingFramework(raw_x,  raw_y);//A-->B
                                                             //|   |
                                                             //C-->D
            /*A*/list_xy.Add(eyeTrackerToFaceTrackingFramework((int)((double)raw_x - error_x + 0.5), (int)((double)raw_y - error_y + 0.5))); //0.5 eklemenin nedeni rounding yaparken bunlaryuvarlam?yordu bu sayede biz roundingte yuvarlamay? sa?l?yorz.
                                                                                                                                             /*A*/
            /*B*/list_xy.Add(eyeTrackerToFaceTrackingFramework((int)((double)raw_x + error_x + 0.5), (int)((double)raw_y - error_y + 0.5))); //0.5 eklemenin nedeni rounding yaparken bunlaryuvarlam?yordu bu sayede biz roundingte yuvarlamay? sa?l?yorz.
                                                                                                                                             /*A*/
            /*C*/list_xy.Add(eyeTrackerToFaceTrackingFramework((int)((double)raw_x - error_x + 0.5), (int)((double)raw_y + error_y + 0.5))); //0.5 eklemenin nedeni rounding yaparken bunlaryuvarlam?yordu bu sayede biz roundingte yuvarlamay? sa?l?yorz.
                                                                                                                                             /*A*/
            /*D*/list_xy.Add(eyeTrackerToFaceTrackingFramework((int)((double)raw_x + error_x + 0.5), (int)((double)raw_y + error_y + 0.5))); //0.5 eklemenin nedeni rounding yaparken bunlaryuvarlam?yordu bu sayede biz roundingte yuvarlamay? sa?l?yorz.

            return list_xy;
        }

        public void set_errors_of_eye_tracker(double _x_error, double _y_error)
        {
            error_x = _x_error;
            error_y = _y_error;
        }

        public  void faceTrackingFrameworkToEyeTracker(ref int faceTrackingFramework_x, ref int faceTrackingFramework_y)
        {
            faceTrackingFramework_x = faceTrackingFramework_x * eyeTracker_raw_data_image_width / faceTracking_workon_image_width;
            faceTrackingFramework_y = faceTrackingFramework_y * eyeTracker_raw_data_image_height / faceTracking_workon_image_hegiht;
        }

        public ImageConversion() { }
        public ImageConversion(int _eyeTracker_raw_data_image_width, int _eyeTracker_raw_data_image_height, int _faceTracking_workon_image_width, int _faceTracking_workon_image_hegiht)
        {
            eyeTracker_raw_data_image_width = _eyeTracker_raw_data_image_width;
            eyeTracker_raw_data_image_height = _eyeTracker_raw_data_image_height;

            faceTracking_workon_image_width = _faceTracking_workon_image_width;
            faceTracking_workon_image_hegiht = _faceTracking_workon_image_hegiht;

        }

    }
}
