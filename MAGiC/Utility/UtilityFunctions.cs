using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAGiC
{
    public static class UtilityFunctions
    {

        public static void MoveUp(ListBox myListBox)
        {
            int selectedIndex = myListBox.SelectedIndex;
            if (selectedIndex > 0)
            {
                myListBox.Items.Insert(selectedIndex - 1, myListBox.Items[selectedIndex]);
                myListBox.Items.RemoveAt(selectedIndex + 1);
                myListBox.SelectedIndex = selectedIndex - 1;
            }
        }

        public static void MoveDown(ListBox myListBox)
        {
            int selectedIndex = myListBox.SelectedIndex;
            if (selectedIndex < myListBox.Items.Count - 1 & selectedIndex != -1)
            {
                myListBox.Items.Insert(selectedIndex + 2, myListBox.Items[selectedIndex]);
                myListBox.Items.RemoveAt(selectedIndex);
                myListBox.SelectedIndex = selectedIndex + 1;

            }
        }

        //convertMilliSecondToEyeTrackerFrameNo
        public static void findStartingEndingFrameNo(string fileName_experimentInterval, int participantNo, Constants.ParticipantInfo participantInfo, int frequency, ref int startingFrameNo, ref int endingFrameNo)
        {
            System.IO.StreamReader file_experiment_interval = new System.IO.StreamReader(fileName_experimentInterval);

            if (file_experiment_interval != null)
                file_experiment_interval.ReadLine(); //skip header

            string[] words_experiment_interval;
            char[] delimiterChars = { ' ', '\t', ',' };
            string line_experiment_interval = "";
            while ((line_experiment_interval = file_experiment_interval.ReadLine()) != null)
            {
                words_experiment_interval = line_experiment_interval.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
                if (Convert.ToInt32(words_experiment_interval[0]) == participantNo)
                {
                    if (participantInfo == Constants.ParticipantInfo.Second)
                    {
                        //when calculate ending frame by converting ending millisecond value to frame number as in finding the starting frame number case, it might cause different number of frame numbers in a pair, because of conversion issues. 
                        //thus ending frame number is calculated based on difference value which is absolutely same in a pair.
                        startingFrameNo = convertMilliSecondToEyeTrackerFrameNo(frequency, Convert.ToInt32(words_experiment_interval[3])); //round up, for instance for 30 Hz eye tracker 0-30 ms refers first frame not 0
                        endingFrameNo = startingFrameNo + convertMilliSecondToEyeTrackerFrameNo(frequency, (Convert.ToInt32(words_experiment_interval[4]) - Convert.ToInt32(words_experiment_interval[3])) ) -1;
                        return;
                    }
                    else
                    {
                        startingFrameNo = convertMilliSecondToEyeTrackerFrameNo(frequency, Convert.ToInt32(words_experiment_interval[1])); //round up, for instance for 30 Hz eye tracker 0-30 ms refers first frame not 0
                        endingFrameNo = startingFrameNo+ convertMilliSecondToEyeTrackerFrameNo(frequency, (Convert.ToInt32(words_experiment_interval[2]) - Convert.ToInt32(words_experiment_interval[1])) ) -1;
                        return;
                    }
                }
            }
        }

        public static int convertMilliSecondToEyeTrackerFrameNo(int frequency, int millisecondVal)
        {
            return (Convert.ToInt32(millisecondVal) * frequency / 1000 + 1);
        }

        public static int convertnextMilliSecondToEyeTrackerFrameNo(int frequency, string millisecondVal)
        {
            return ((Convert.ToInt32(millisecondVal) + 1) * frequency / 1000 + 1);
        }

        private static string getNewFileName(string file, int initialSegmentNum, int endingSegmentNum)
        {
            string nameWithoutExtension = Path.GetFileNameWithoutExtension(file);
            if (nameWithoutExtension != null && nameWithoutExtension.Length > 0)
            {
                if (Convert.ToInt32(nameWithoutExtension) > endingSegmentNum)
                    return "";
                int diff = (Convert.ToInt32(nameWithoutExtension) - (initialSegmentNum + 1));
                if (diff >= 0)
                    return Path.Combine(Path.GetDirectoryName(file), diff.ToString() + Path.GetExtension(file));
                return "";
            }
            return "";
        }

        public static void FixAllAudioNamesAccordingToExpInterval(string directory, int initialSegmentNum, int endingSegmentNum)
        {
            IEnumerable<string> files = Directory.EnumerateFiles(directory);

            IOrderedEnumerable<FileSystemInfo> vv = new DirectoryInfo(directory).GetFileSystemInfos("*.wav").OrderBy(fs => int.Parse(fs.Name.Split('\\').Last().Substring(0, fs.Name.Split('\\').Last().Length - fs.Extension.Length)));


            foreach (FileSystemInfo filesystemInf in vv.ToList())
            {
                try
                {
                    string file = filesystemInf.FullName;
                    FileInfo info = new FileInfo(file);
                    if (Path.GetExtension(info.FullName) == ".wav" && !info.IsReadOnly && !info.Attributes.HasFlag(FileAttributes.System))
                    {
                        string destFileName = getNewFileName(file, initialSegmentNum, endingSegmentNum);

                        if (destFileName != "")
                            info.MoveTo(destFileName);
                        else
                            info.Delete();
                    }
                }
                catch (Exception ex)
                {
                    throw;
                }

            }
        }


        public static void addOrUpdateDictionary(Dictionary<int, string> dic, int key, string line)
        {
            string val;
            if (dic.TryGetValue(key, out val))
            {
                // yay, value exists!
                dic[key] = val + "," + line;
            }
            else
            {
                // darn, lets add the value
                dic.Add(key, line);
            }
        }

        public static string LocateJava()
        {
            string _javadir = "";
            String path = Environment.GetEnvironmentVariable("path");
            String[] folders = path.Split(';');
            foreach (String folder in folders)
            {
                if (File.Exists(folder + "java.exe"))
                {
                    _javadir = folder;
                    break;

                }
                else if (File.Exists(folder + "\\java.exe"))
                {
                    _javadir = folder + "\\";
                    break;

                }


            }

            return _javadir;
        }

        public static string getAOIsofFile_OpenFace(Constants.FilesForAOIDetection filesforAOIDetection, ImageConversion imageConversion)
        {
            string line_features, line_raw_data;

            char[] delimiterChars = { ' ', '\t', ',' };

            string[] words_features;
            int frame_num, success;
            string[] words_eye_tracker_generated_file;
            string fixation_type = "", raw_x = "", raw_y = "";
            int frame_num_raw_data = 0;

            string AOIs = "";
            string writeToFile_str = "";


            if (filesforAOIDetection.file_2d_landmarks != null)
                filesforAOIDetection.file_2d_landmarks.ReadLine(); //skip header row,
            while ((line_features = filesforAOIDetection.file_2d_landmarks.ReadLine()) != null)
            {
                words_features = line_features.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
                frame_num = Convert.ToInt32(words_features[0]);

                line_raw_data = filesforAOIDetection.file_gaze_raw_data.ReadLine();


                Dictionary<int, string> manually_tracked_dict = null;
                string letter = "";
                if (!String.IsNullOrEmpty(filesforAOIDetection.file_manuallyLabelledAOIs_path) && !String.IsNullOrWhiteSpace(filesforAOIDetection.file_manuallyLabelledAOIs_path))
                {
                    string[] manually_tracked_lines = File.ReadAllLines(filesforAOIDetection.file_manuallyLabelledAOIs_path);

                    manually_tracked_dict = new Dictionary<int, string>();
                    foreach (string line in manually_tracked_lines)
                    {
                        if (!String.IsNullOrEmpty(line) && !String.IsNullOrWhiteSpace(line))
                        {
                            int frameNo = Convert.ToInt32(line.Split(' ')[0]);
                            letter = line.Split(' ')[1];
                            UtilityFunctions.addOrUpdateDictionary(manually_tracked_dict, frameNo, letter);
                        }
                    }
                }

                bool gaze_raw_data_empty = false, face_detection_empty = false;
                List<Point> face = new List<Point>();
                List<Point> nose_rect = new List<Point>();
                List<Point> eye_rect = new List<Point>();
                List<Point> mouth_rect = new List<Point>();
                if (line_raw_data != null)
                {
                    words_eye_tracker_generated_file = line_raw_data.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);

                    frame_num_raw_data = Convert.ToInt32(words_eye_tracker_generated_file[0]);
                    while (frame_num_raw_data > frame_num)
                    {
                        writeToFile_str += frame_num + " " + "\n";
                        line_features = filesforAOIDetection.file_2d_landmarks.ReadLine();
                        words_features = line_features.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
                        frame_num = Convert.ToInt32(words_features[0]);

                    }
                    if (frame_num != frame_num_raw_data)
                        throw new Exception("There is a problem in the size of 2dLandmarks file and eye tracker generated raw gaze data file. Please be sure you import the accurate files!!");

                    fixation_type = words_eye_tracker_generated_file[1];
                    success = Convert.ToInt32(words_features[3]);
                    gaze_raw_data_empty = false; face_detection_empty = false;
                    if ((fixation_type == Constants.EyeTrackerNotEmptyLineTxt))
                    {
                        raw_x = words_eye_tracker_generated_file[2];
                        raw_y = words_eye_tracker_generated_file[3];
                    }
                    else
                    {
                        gaze_raw_data_empty = true;
                    }

                    int total_num_of_empy = 0;
                    for (int i = 4; i < 31; i++)
                    {
                        face.Add(new Point((int)Convert.ToDouble(words_features[i]), (int)Convert.ToDouble(words_features[i + 68])));

                        if ((int)Convert.ToDouble(words_features[i + 68]) == 0 && (int)Convert.ToDouble(words_features[i]) == 0)
                            total_num_of_empy++;
                    }

                    if (total_num_of_empy >= 4)
                        face_detection_empty = true;
                }

                bool addedtoAOIsFrame = false;
                if (manually_tracked_dict != null && manually_tracked_dict.Count > 0 && manually_tracked_dict.TryGetValue(frame_num, out letter)) //manualy tracked value override face tracking outcomes
                {
                    if (letter.Equals("NULL"))  //while manual tracking, when user does not decide what is the appropriate AOI to assign, s/he press 0  and it assign Null to the related frame, most probably because of the empty gaze row data 
                    {
                        string newAOIs = "";
                        newAOIs = assignTheProblematicIssueLabel(frame_num, AOIs, gaze_raw_data_empty, face_detection_empty);
                        if (String.IsNullOrEmpty(newAOIs)) //sometimes if we assign null while manually track, but actually, there was no face detection issue or gaze raw data empty problem, assignTheProblematicIssueLabel do not add new line to the AOIs, for this cases it is necessary to add related frame AOI, based on detected face and raw gaze data.
                            addedtoAOIsFrame = false;
                        else
                        {
                            AOIs = newAOIs;
                            addedtoAOIsFrame = true;
                        }


                    }

                    else
                    {
                        AOIs += frame_num + " " + letter + "\n";
                        addedtoAOIsFrame = true;
                    }
                }
                if(!addedtoAOIsFrame && line_raw_data != null)
                {
                    

                    if (!gaze_raw_data_empty && !face_detection_empty)
                    {

                        //face_rect 
                        eye_rect.Add(new Point((int)Convert.ToDouble(words_features[4]), (int)Convert.ToDouble(words_features[4 + 68])));
                        eye_rect.Add(new Point((int)Convert.ToDouble(words_features[20]), (int)Convert.ToDouble(words_features[20 + 68])));
                        nose_rect.Add(new Point((int)Convert.ToDouble(words_features[5]), (int)Convert.ToDouble(words_features[5 + 68])));
                        nose_rect.Add(new Point((int)Convert.ToDouble(words_features[6]), (int)Convert.ToDouble(words_features[6 + 68])));
                        nose_rect.Add(new Point((int)Convert.ToDouble(words_features[19]), (int)Convert.ToDouble(words_features[19 + 68])));
                        nose_rect.Add(new Point((int)Convert.ToDouble(words_features[18]), (int)Convert.ToDouble(words_features[18 + 68])));

                        for (int i = 8; i < 19; i++)
                        {
                            mouth_rect.Add(new Point((int)Convert.ToDouble(words_features[i]), (int)Convert.ToDouble(words_features[i + 68])));
                        }

                        for (int i = 21; i < 31; i++)
                        {
                            eye_rect.Add(new Point((int)Convert.ToDouble(words_features[i]), (int)Convert.ToDouble(words_features[i + 68])));
                        }
                        for (int i = 31; i < 40; i++)
                        {
                            if (i == 31 || i == 32)
                                eye_rect.Add(new Point((int)Convert.ToDouble(words_features[i]), (int)Convert.ToDouble(words_features[i + 68])));
                            else
                                nose_rect.Add(new Point((int)Convert.ToDouble(words_features[i]), (int)Convert.ToDouble(words_features[i + 68])));
                        }
                        for (int i = 40; i < 46; i++)
                        {
                            eye_rect.Add(new Point((int)Convert.ToDouble(words_features[i]), (int)Convert.ToDouble(words_features[i + 68])));
                        }
                        for (int i = 46; i < 52; i++)
                        {
                            eye_rect.Add(new Point((int)Convert.ToDouble(words_features[i]), (int)Convert.ToDouble(words_features[i + 68])));
                        }
                        for (int i = 52; i < 72; i++)
                        {
                            mouth_rect.Add(new Point((int)Convert.ToDouble(words_features[i]), (int)Convert.ToDouble(words_features[i + 68])));
                        }



                        Dictionary<string, List<Point>> allFeaturePointLists = new Dictionary<string, List<Point>>();

                        allFeaturePointLists.Add(Constants.face, face);
                        allFeaturePointLists.Add(Constants.nose_rect, nose_rect);
                        allFeaturePointLists.Add(Constants.eye_rect, eye_rect);
                        allFeaturePointLists.Add(Constants.mouth_rect, mouth_rect);


                        string AOI = UtilityFunctions.determineAOIForFeatures(raw_x, raw_y, allFeaturePointLists, imageConversion);
                        AOIs += frame_num + " " + AOI + "\n";
                    }

                    else
                    {
                        AOIs = assignTheProblematicIssueLabel(frame_num, AOIs, gaze_raw_data_empty, face_detection_empty);

                    }


                }
            }

            return AOIs;

        }

        private static string assignTheProblematicIssueLabel(int frame_num, string AOIs, bool gaze_raw_data_empty, bool face_detection_empty)
        {
            if (face_detection_empty && !gaze_raw_data_empty)
                AOIs += frame_num + " " + Constants.FaceDetectionEmpty + "\n";
            else if (face_detection_empty && gaze_raw_data_empty)
                AOIs += frame_num + " " + Constants.BothFaceDetectionGazeRawDataEmpty + "\n";
            else if (!face_detection_empty && gaze_raw_data_empty)
                AOIs += frame_num + " " + Constants.GazeRawDataEmpty + "\n";
            else//sometimes if we assign null while manually track, but actually, there was no face detection issue or gaze raw data empty problem, assignTheProblematicIssueLabel do not add new line to the AOIs, for this cases it is necessary to add related frame AOI, based on detected face and raw gaze data.so return null here to check in the returned function
                return "";
            return AOIs;
        }

        public static string determineAOIForFeatures(string raw_x, string raw_y, Dictionary<string, List<Point>> allFeaturePointLists, ImageConversion imageConversion)
        {

            try
            {

                List<Point> convexhull_of_face = Geometry.MakeConvexHull(allFeaturePointLists[Constants.face]);
                bool insideFace = false;

                int x = Convert.ToInt32(raw_x);
                int y = Convert.ToInt32(raw_y);

                if (imageConversion.error_x != 0 || imageConversion.error_y != 0)
                {
                    List<Point> list_p = imageConversion.eyeTrackerToFaceTrackingFrameworkWithErrors(x, y); //holds A,B,C,D points of rectangle sequentially
                    //check each point A->B; A->C; C->D; B->D
                    Point A = list_p.ElementAt(0);
                    Point B = list_p.ElementAt(1);
                    Point C = list_p.ElementAt(2);
                    Point D = list_p.ElementAt(3);


                    foreach (Point p in list_p)
                    {//if rectangle vertices inside polygon
                        insideFace = Geometry.IsPointInPolygon(convexhull_of_face.ToArray(), p);
                        if (insideFace)
                        {
                            x = p.X;
                            y = p.Y;
                            break;
                        }
                    }


                    if (!insideFace)
                    {//if polygon vertices inside rectange
                        Rectangle rec = new Rectangle(A.X, A.Y, (B.X - A.X), (C.Y - A.Y));
                        foreach (Point p in convexhull_of_face.ToArray())
                        {
                            if (rec.Contains(p))
                            {
                                insideFace = true;
                                x = p.X;
                                y = p.Y;
                                break;
                            }

                        }
                    }



                }

                else
                {
                    Point p = imageConversion.eyeTrackerToFaceTrackingFramework(x, y);
                    x = p.X;
                    y = p.Y;
                    insideFace = Geometry.IsPointInPolygon(convexhull_of_face.ToArray(), new Point(x, y));
                }



                //IsPointInPolygon metodu alternatif olarak var
                // bool insideFace = Geometry.PointInPolygon(convexhull_of_face.ToArray(), new Point(x, y));

                string AOI = "";
                string whichpart_of_face = "";
                if (insideFace)
                {
                    AOI = Constants.AOI_e;

                    bool insideEye_rect = Geometry.minBoundingRecNotRotated(allFeaturePointLists[Constants.eye_rect]).Contains(x, y);
                    bool insideNose_rect = Geometry.minBoundingRecNotRotated(allFeaturePointLists[Constants.nose_rect]).Contains(x, y);
                    bool insideMouth_rect = Geometry.minBoundingRecNotRotated(allFeaturePointLists[Constants.mouth_rect]).Contains(x, y);
                    if (insideEye_rect)
                        whichpart_of_face += Constants.eye_rect;
                    else if (insideMouth_rect)
                        whichpart_of_face += Constants.mouth_rect;
                    else //regions not inside eyes or mouth region supposed as nose region
                        whichpart_of_face += Constants.nose_rect;

                    Rectangle minBoundingBox = Geometry.minBoundingRecNotRotated(allFeaturePointLists[Constants.face]);
                    int rec_x = minBoundingBox.X;
                    int rec_y = minBoundingBox.Y;
                    int rec_width = minBoundingBox.Width;
                    int rec_height = minBoundingBox.Height;
                    string min_rect = " " + rec_x + "," + rec_y + "," + rec_width + "," + rec_height;
                    whichpart_of_face += min_rect;

                }
                else
                {
                    Rectangle minBoundingBox = Geometry.minBoundingRecNotRotated(allFeaturePointLists[Constants.face]);
                    int rec_x = minBoundingBox.X;
                    int rec_y = minBoundingBox.Y;
                    int rec_width = minBoundingBox.Width;
                    int rec_height = minBoundingBox.Height;
                    string min_rect = " " + rec_x + "," + rec_y + "," + rec_width + "," + rec_height;

                    //face is not as a rectangle much like in an oval shape, this part is used to make correct annotation for oval shape 
                    if (minBoundingBox.Contains(x, y))
                    {
                        if (x <= (rec_width / 2 + rec_x))
                            AOI = Constants.AOI_d;
                        else
                            AOI = Constants.AOI_f;

                    }

                    else if (x >= rec_x && x <= (rec_x + rec_width))
                    {
                        if (y > (rec_y + rec_height))
                            AOI = Constants.AOI_h;
                        else if (y < rec_y)
                            AOI = Constants.AOI_b;

                    }
                    else if (y >= rec_y && y <= (rec_y + rec_height))
                    {
                        if (x < rec_x)
                            AOI = Constants.AOI_d;
                        else if (x > (rec_x + rec_width))
                            AOI = Constants.AOI_f;
                    }
                    else if (x < rec_x && y < rec_y)
                        AOI = Constants.AOI_a;
                    else if ((x > (rec_x + rec_width)) && (y > (rec_y + rec_height)))
                        AOI = Constants.AOI_i;
                    else if (x < rec_x && y > (rec_y + rec_height))
                        AOI = Constants.AOI_g;
                    else if ((x > (rec_x + rec_width)) && (y < rec_y))
                        AOI = Constants.AOI_c;




                    AOI += min_rect + " " + x + "," + y;

                }

                return AOI + " " + whichpart_of_face;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }



    }
}
