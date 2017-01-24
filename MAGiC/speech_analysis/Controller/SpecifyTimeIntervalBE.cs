using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAGiC
{
    public class SpecifyTimeIntervalBE
    {
        //once the automatic steps are complete, a human annotator must still listen to the recordings and enter the actual transcription.
        //The primary time savings comes by automatically segmenting the audio into short spoken utterances and by limiting the amount of mouse movement required to create an annotation
        private SpecifyTimeIntervalUI controls;


        public SpecifyTimeIntervalBE(SpecifyTimeIntervalUI _controls)
        {
            controls = _controls;
            initialize();

        }

        public SpecifyTimeIntervalBE()
        {
            initialize();
        }

        private void initialize()
        {

            controls.btn_openFileOutput_determine_interval.Click += new System.EventHandler(this.btn_openFileOutput_determine_interval);
            controls.btn_openFileInterval_determine_interval_single.Click += new System.EventHandler(this.btn_openFileInterval_determine_interval_single);
            controls.btn_save_determine_interval_single.Click += new System.EventHandler(this.btn_save_determine_interval_single);
            controls.btn_openFileInterval_determine_interval_multiple_1.Click += new System.EventHandler(this.btn_openFileInterval_determine_interval_multiple_1);
            controls.btn_openFileInterval_determine_interval_multiple_2.Click += new System.EventHandler(this.btn_openFileInterval_determine_interval_multiple_2);
            controls.btn_save_determine_interval_multiple.Click += new System.EventHandler(this.btn_save_determine_interval_multiple);
            controls.btn_save_resegment_determine_interval_multiple.Click += new System.EventHandler(this.btn_save_resegment_determine_interval_multiple);
            controls.btn_openFile_resegment.Click += new System.EventHandler(this.btn_openFile_resegment);
            controls.btn_openFolderOutput_resegment.Click += new System.EventHandler(this.btn_openFolderOutput_resegment);
            controls.btn_gotoWalkthrough_determine_interval.Click += new System.EventHandler(this.btn_gotoWalkthrough_Click);

        }



        public void btn_openFileOutput_determine_interval(object sender, EventArgs e)
        {
            string fileName = "";
            controls.ofd_outputFileOutput_determine_interval.InitialDirectory = "c:\\";
            controls.ofd_outputFileOutput_determine_interval.Filter = "txt files (*.txt)|*.txt";
            // ofd_aviFile.FilterIndex = 2;
            controls.ofd_outputFileOutput_determine_interval.RestoreDirectory = true;
            controls.ofd_outputFileOutput_determine_interval.CheckFileExists = false;
            controls.ofd_outputFileOutput_determine_interval.FileName = "exp_time_interval.txt";

            DialogResult result = controls.ofd_outputFileOutput_determine_interval.ShowDialog();

            fileName = controls.ofd_outputFileOutput_determine_interval.FileName;
            controls.txt_outputFile_determine_interval.Text = fileName;

        }

        public void btn_openFileInterval_determine_interval_single(object sender, EventArgs e)
        {
            string fileName = "";
            controls.ofd_openFileInterval_determine_interval_single.InitialDirectory = "c:\\";
            controls.ofd_openFileInterval_determine_interval_single.Filter = "txt files (*.txt)|*.txt";
            // ofd_aviFile.FilterIndex = 2;
            controls.ofd_openFileInterval_determine_interval_single.RestoreDirectory = true;

            DialogResult result = controls.ofd_openFileInterval_determine_interval_single.ShowDialog();

            fileName = controls.ofd_openFileInterval_determine_interval_single.FileName;
            controls.txt_interval_determine_interval_single.Text = fileName;

        }

        public void btn_openFileInterval_determine_interval_multiple_1(object sender, EventArgs e)
        {
            string fileName = "";
            controls.ofd_openFileInterval_determine_interval_multiple_1.InitialDirectory = "c:\\";
            controls.ofd_openFileInterval_determine_interval_multiple_1.Filter = "txt files (*.txt)|*.txt";
            // ofd_aviFile.FilterIndex = 2;
            controls.ofd_openFileInterval_determine_interval_multiple_1.RestoreDirectory = true;

            DialogResult result = controls.ofd_openFileInterval_determine_interval_multiple_1.ShowDialog();

            fileName = controls.ofd_openFileInterval_determine_interval_multiple_1.FileName;
            controls.txt_interval_determine_interval_multiple_1.Text = fileName;

        }

        public void btn_openFileInterval_determine_interval_multiple_2(object sender, EventArgs e)
        {
            string fileName = "";
            controls.ofd_openFileInterval_determine_interval_multiple_2.InitialDirectory = "c:\\";
            controls.ofd_openFileInterval_determine_interval_multiple_2.Filter = "txt files (*.txt)|*.txt";
            // ofd_aviFile.FilterIndex = 2;
            controls.ofd_openFileInterval_determine_interval_multiple_2.RestoreDirectory = true;

            DialogResult result = controls.ofd_openFileInterval_determine_interval_multiple_2.ShowDialog();

            fileName = controls.ofd_openFileInterval_determine_interval_multiple_2.FileName;
            controls.txt_interval_determine_interval_multiple_2.Text = fileName;

        }

        public void btn_save_determine_interval_single(object sender, EventArgs e)
        {

            bool validationError = false;
            if (String.IsNullOrEmpty(controls.txt_outputFile_determine_interval.Text) || String.IsNullOrWhiteSpace(controls.txt_outputFile_determine_interval.Text))
            {
                controls.errorProvider_outputFile_interval.SetError(controls.txt_outputFile_determine_interval, Constants.MESSAGE_SELECT_OUTPUT_FOLDER);
                validationError = true;
            }
            else
            {
                controls.errorProvider_outputFile_interval.Clear();
                controls.errorProvider_outputFile_interval.SetError(controls.txt_outputFile_determine_interval, "");
            }

            if (String.IsNullOrEmpty(controls.txt_interval_determine_interval_single.Text) || String.IsNullOrWhiteSpace(controls.txt_interval_determine_interval_single.Text))
            {
                controls.errorProvider_segmentsIntervalFile_single.SetError(controls.txt_interval_determine_interval_single, Constants.MESSAGE_SELECT_SEGMENTS_INTERVAL_FILE);
                validationError = true;
            }
            else
            {
                controls.errorProvider_segmentsIntervalFile_single.Clear();
                controls.errorProvider_segmentsIntervalFile_single.SetError(controls.txt_interval_determine_interval_single, "");
            }

            int id = 0;
            if (String.IsNullOrEmpty(controls.txt_id_determine_interval_single.Text) || String.IsNullOrWhiteSpace(controls.txt_id_determine_interval_single.Text)
                || (!int.TryParse(controls.txt_id_determine_interval_single.Text, out id)))
            {
                controls.errorProvider_id_single.SetError(controls.txt_id_determine_interval_single, Constants.MESSAGE_ENTER_POSITIVE_INTEGER_VALUE);
                validationError = true;
            }
            else
            {
                controls.errorProvider_id_single.Clear();
                controls.errorProvider_id_single.SetError(controls.txt_id_determine_interval_single, "");
            }

            string initialSegment = controls.txt_starting_number_determine_interval_single.Text;
            int initial_segment = 0;
            if (String.IsNullOrEmpty(initialSegment) || String.IsNullOrWhiteSpace(initialSegment)
                || (!int.TryParse(initialSegment, out initial_segment)))
            {
                controls.errorProvider_starting_segment_single.SetError(controls.txt_starting_number_determine_interval_single, Constants.MESSAGE_ENTER_POSITIVE_INTEGER_VALUE);
                validationError = true;
            }
            else
            {
                controls.errorProvider_starting_segment_single.Clear();
                controls.errorProvider_starting_segment_single.SetError(controls.txt_starting_number_determine_interval_single, "");
            }

            int last_segment = 0;
            string lastSegment = controls.txt_final_number_determine_interval_single.Text;
            if (String.IsNullOrEmpty(lastSegment) || String.IsNullOrWhiteSpace(lastSegment)
                || (!int.TryParse(lastSegment, out last_segment)))
            {
                controls.errorProvider_final_segment_single.SetError(controls.txt_final_number_determine_interval_single, Constants.MESSAGE_ENTER_POSITIVE_INTEGER_VALUE);
                validationError = true;
            }
            else
            {
                controls.errorProvider_final_segment_single.Clear();
                controls.errorProvider_final_segment_single.SetError(controls.txt_final_number_determine_interval_single, "");
            }

            if (last_segment < initial_segment)
            {
                controls.errorProvider_segmentsIntervalFile_single.SetError(controls.txt_final_number_determine_interval_single, Constants.MESSAGE_ENTER_GREATER_VALUE);
                validationError = true;
            }
            if (validationError)
                return;

            else
            {

                string segmented_file_path = controls.txt_interval_determine_interval_single.Text;
                string[] segmentedAudios;

                char[] delimeters = new char[] { ' ', '\t' };
                string starting_time = "", ending_time = "";
                if (File.Exists(segmented_file_path))
                {
                    segmentedAudios = File.ReadAllLines(segmented_file_path);
                    Dictionary<string, string> dict = new Dictionary<string, string>();
                    List<String> strSegmentsInsideExp = new List<String>();
                    
                    foreach (String line in segmentedAudios)
                    {
                        if (String.IsNullOrEmpty(line) || String.IsNullOrWhiteSpace(line) || line.Trim(new[] { ' ', '\t', '\n' }).Length <= 0)
                            continue;

                        //order of if statements should not be changed.
                        if (!String.IsNullOrEmpty(starting_time) && !String.IsNullOrWhiteSpace(starting_time))
                            strSegmentsInsideExp.Add(line);


                        if (line.Split(delimeters, StringSplitOptions.RemoveEmptyEntries)[0].Equals(initialSegment))
                        {
                            starting_time = line.Split(delimeters, StringSplitOptions.RemoveEmptyEntries)[2];
                        }
                        if (line.Split(delimeters, StringSplitOptions.RemoveEmptyEntries)[0].Equals(lastSegment))
                        {
                            ending_time = line.Split(delimeters, StringSplitOptions.RemoveEmptyEntries)[2];
                            break;
                        }
                 


                    }

                    using (StreamWriter newTask = new StreamWriter(segmented_file_path, false))
                    {
                        foreach (string line_s in strSegmentsInsideExp)
                        {
                            int newID=0;
                            string[] lineItems = line_s.Split(delimeters, StringSplitOptions.RemoveEmptyEntries);
                            if (line_s.Split(delimeters, StringSplitOptions.RemoveEmptyEntries)[0] != null)
                                newID = Convert.ToInt32(lineItems[0]) - Convert.ToInt32(initialSegment) - 1;

                            string line_changed = newID.ToString() + "		" + lineItems[1] + " " + lineItems[2] + " " + lineItems[3];
                            newTask.WriteLine(line_changed);
                        }

                    }

                    UtilityFunctions.FixAllAudioNamesAccordingToExpInterval(Path.GetDirectoryName(segmented_file_path), Convert.ToInt32(initialSegment), Convert.ToInt32(lastSegment));

                    

                    bool createOutputFile = false;
                    string output_path = controls.txt_outputFile_determine_interval.Text;
                    if (!File.Exists(output_path))
                        createOutputFile = true;
                    if (createOutputFile)
                    {
                        string[] lines = { "#id #StartingTime #EndingTime", id + " " + starting_time + " " + ending_time };

                        System.IO.File.WriteAllLines(output_path, lines);
                    }
                    else
                    {

                        string[] starting_ending_time_file = File.ReadAllLines(output_path);
                        Dictionary<string, string> dict_output_file = new Dictionary<string, string>();
                        string writeToFile = "";
                        foreach (String line in starting_ending_time_file)
                        {
                            string line_to_write = line;
                            if (line.Contains('#')) //header
                            {
                                continue;
                            }
                            else if (String.IsNullOrEmpty(line) || String.IsNullOrWhiteSpace(line) || line.Trim(new[] { ' ', '\t', '\n' }).Length <= 0)
                                continue;
                            else if (line.Split(delimeters)[0].Equals(id))
                            {
                                line_to_write = id + " " + starting_time + " " + ending_time;
                            }

                            writeToFile += line_to_write + "\n";

                        }
                        System.IO.File.WriteAllText(output_path, writeToFile);

                    }


                    MessageBox.Show("Succesfully done!!");
                }
            }

        }

        public void btn_save_determine_interval_multiple(object sender, EventArgs e)
        {
            bool validationError = false;
            int id;
            string initialSegment_pair1, initialSegment_pair2, lastSegment_pair1, lastSegment_pair2;
            validationError = validation_MultipleFiles(out id, out initialSegment_pair1, out initialSegment_pair2, out lastSegment_pair1, out lastSegment_pair2);
            if (validationError)
                return;

            else
            {
                bool fileExist = specifyIntervals(id, initialSegment_pair1, initialSegment_pair2, lastSegment_pair1, lastSegment_pair2);
                if (fileExist)
                    MessageBox.Show("Succesfully done!!");
                else
                    MessageBox.Show("Please be sure the files exist!!");
            }

        }

        private bool specifyIntervals(int id, string initialSegment_pair1, string initialSegment_pair2, string lastSegment_pair1, string lastSegment_pair2)
        {
            string segmented_file_path_pair1 = controls.txt_interval_determine_interval_multiple_1.Text;
            string segmented_file_path_pair2 = controls.txt_interval_determine_interval_multiple_2.Text;
            string[] segmentedAudios_pair1, segmentedAudios_pair2;

            char[] delimeters = new char[] { ' ', '\t' };
            string starting_time_pair1 = "", ending_time_pair_1 = "", starting_time_pair2 = "", ending_time_pair_2 = "";
            if (File.Exists(segmented_file_path_pair1) && File.Exists(segmented_file_path_pair2))
            {
                segmentedAudios_pair1 = File.ReadAllLines(segmented_file_path_pair1);
                foreach (String line in segmentedAudios_pair1)
                {
                    if (String.IsNullOrEmpty(line) || String.IsNullOrWhiteSpace(line) || line.Trim(new[] { ' ', '\t', '\n' }).Length <= 0)
                        continue;
                    if (line.Split(delimeters, StringSplitOptions.RemoveEmptyEntries)[0].Equals(initialSegment_pair1))
                    {
                        starting_time_pair1 = line.Split(delimeters, StringSplitOptions.RemoveEmptyEntries)[2];
                    }
                    if (line.Split(delimeters, StringSplitOptions.RemoveEmptyEntries)[0].Equals(lastSegment_pair1))
                    {
                        ending_time_pair_1 = line.Split(delimeters, StringSplitOptions.RemoveEmptyEntries)[2];
                        break;
                    }

                }

                segmentedAudios_pair2 = File.ReadAllLines(segmented_file_path_pair2);
                foreach (String line in segmentedAudios_pair2)
                {
                    if (String.IsNullOrEmpty(line) || String.IsNullOrWhiteSpace(line) || line.Trim(new[] { ' ', '\t', '\n' }).Length <= 0)
                        continue;
                    if (line.Split(delimeters, StringSplitOptions.RemoveEmptyEntries)[0].Equals(initialSegment_pair2))
                    {
                        starting_time_pair2 = line.Split(delimeters, StringSplitOptions.RemoveEmptyEntries)[2];
                    }
                    if (line.Split(delimeters, StringSplitOptions.RemoveEmptyEntries)[0].Equals(lastSegment_pair2))
                    {
                        ending_time_pair_2 = line.Split(delimeters, StringSplitOptions.RemoveEmptyEntries)[2];
                        break;
                    }

                }

                bool createOutputFile = false;
                string output_path = controls.txt_outputFile_determine_interval.Text;
                if (!File.Exists(output_path))
                    createOutputFile = true;
                Constants.ExpIntervalofPair expIntervals = new Constants.ExpIntervalofPair(starting_time_pair1, ending_time_pair_1, starting_time_pair2, ending_time_pair_2);
                output_expInterval(id, expIntervals, createOutputFile, output_path);

                return true;
            }
            else
            {
                return false;
            }

        }

        private static void output_expInterval(int id, Constants.ExpIntervalofPair expIntervals, bool createOutputFile, string output_path)
        {

            char[] delimeters = new char[] { ' ', '\t' };
            if (createOutputFile)
            {
                string[] lines = { "#id #StartingTime(Pair_FirstParticipant) #EndingTime(Pair_FirstParticipant) #StartingTime(Pair_SecondParticipant) #EndingTime(Pair_SecondParticipant)", id + " " + expIntervals.starting_time_pair1 + " " + expIntervals.ending_time_pair_1 + " " + expIntervals.starting_time_pair2 + " " + expIntervals.ending_time_pair_2 };

                System.IO.File.WriteAllLines(output_path, lines);
            }
            else
            {

                string[] starting_ending_time_file = File.ReadAllLines(output_path);
                Dictionary<string, string> dict_output_file = new Dictionary<string, string>();
                string writeToFile = "";
                foreach (String line in starting_ending_time_file)
                {
                    string line_to_write = line;
                    //if (line.Contains('#')) //header
                    //{
                    //    continue;
                    //}
                    if (String.IsNullOrEmpty(line) || String.IsNullOrWhiteSpace(line) || line.Trim(new[] { ' ', '\t', '\n' }).Length <= 0)
                        continue;
                    else if (line.Split(delimeters)[0].Equals(id.ToString()))
                    {
                        line_to_write = id + " " + expIntervals.starting_time_pair1 + " " + expIntervals.ending_time_pair_1 + " " + expIntervals.starting_time_pair2 + " " + expIntervals.ending_time_pair_2;
                    }

                    writeToFile += line_to_write + "\n";

                }
                writeToFile += id + " " + expIntervals.starting_time_pair1 + " " + expIntervals.ending_time_pair_1 + " " + expIntervals.starting_time_pair2 + " " + expIntervals.ending_time_pair_2;
                System.IO.File.WriteAllText(output_path, writeToFile);

            }
        }

        private bool validation_MultipleFiles(out int id, out string initialSegment_pair1, out string initialSegment_pair2, out string lastSegment_pair1, out string lastSegment_pair2)
        {
            bool validationError = false;
            if (String.IsNullOrEmpty(controls.txt_outputFile_determine_interval.Text) || String.IsNullOrWhiteSpace(controls.txt_outputFile_determine_interval.Text))
            {
                controls.errorProvider_outputFile_interval.SetError(controls.txt_outputFile_determine_interval, Constants.MESSAGE_SELECT_OUTPUT_FOLDER);
                validationError = true;
            }
            else
            {
                controls.errorProvider_outputFile_interval.Clear();
                controls.errorProvider_outputFile_interval.SetError(controls.txt_outputFile_determine_interval, "");
            }

            if (String.IsNullOrEmpty(controls.txt_interval_determine_interval_multiple_1.Text) || String.IsNullOrWhiteSpace(controls.txt_interval_determine_interval_multiple_1.Text))
            {
                controls.errorProvider_segmentsIntervalFile_multiple_1.SetError(controls.txt_interval_determine_interval_multiple_1, Constants.MESSAGE_SELECT_SEGMENTS_INTERVAL_FILE);
                validationError = true;
            }
            else
            {
                controls.errorProvider_segmentsIntervalFile_multiple_1.Clear();
                controls.errorProvider_segmentsIntervalFile_multiple_1.SetError(controls.txt_interval_determine_interval_multiple_1, "");
            }

            if (String.IsNullOrEmpty(controls.txt_interval_determine_interval_multiple_2.Text) || String.IsNullOrWhiteSpace(controls.txt_interval_determine_interval_multiple_2.Text))
            {
                controls.errorProvider_segmentsIntervalFile_multiple_2.SetError(controls.txt_interval_determine_interval_multiple_2, Constants.MESSAGE_SELECT_SEGMENTS_INTERVAL_FILE);
                validationError = true;
            }
            else
            {
                controls.errorProvider_segmentsIntervalFile_multiple_2.Clear();
                controls.errorProvider_segmentsIntervalFile_multiple_2.SetError(controls.txt_interval_determine_interval_multiple_2, "");
            }

            id = 0;
            if (String.IsNullOrEmpty(controls.txt_id_determine_interval_multiple.Text) || String.IsNullOrWhiteSpace(controls.txt_id_determine_interval_multiple.Text)
                || (!int.TryParse(controls.txt_id_determine_interval_multiple.Text, out id)))
            {
                controls.errorProvider_id_multiple.SetError(controls.txt_id_determine_interval_multiple, Constants.MESSAGE_ENTER_POSITIVE_INTEGER_VALUE);
                validationError = true;
            }
            else
            {
                controls.errorProvider_id_multiple.Clear();
                controls.errorProvider_id_multiple.SetError(controls.txt_id_determine_interval_multiple, "");
            }

            initialSegment_pair1 = controls.txt_starting_number_determine_interval_multiple_1.Text;
            initialSegment_pair2 = controls.txt_starting_number_determine_interval_multiple_2.Text;
            int initial_segment_pair1 = 0, initial_segment_pair2 = 0;
            if (String.IsNullOrEmpty(initialSegment_pair1) || String.IsNullOrWhiteSpace(initialSegment_pair1)
                || (!int.TryParse(initialSegment_pair1, out initial_segment_pair1)))
            {
                controls.errorProvider_starting_segment_multiple_1.SetError(controls.txt_starting_number_determine_interval_multiple_1, Constants.MESSAGE_ENTER_POSITIVE_INTEGER_VALUE);
                validationError = true;
            }
            else
            {
                controls.errorProvider_starting_segment_multiple_1.Clear();
                controls.errorProvider_starting_segment_multiple_1.SetError(controls.txt_starting_number_determine_interval_multiple_1, "");
            }

            if (String.IsNullOrEmpty(initialSegment_pair2) || String.IsNullOrWhiteSpace(initialSegment_pair2)
              || (!int.TryParse(initialSegment_pair2, out initial_segment_pair2)))
            {
                controls.errorProvider_starting_segment_multiple_2.SetError(controls.txt_starting_number_determine_interval_multiple_2, Constants.MESSAGE_ENTER_POSITIVE_INTEGER_VALUE);
                validationError = true;
            }
            else
            {
                controls.errorProvider_starting_segment_multiple_2.Clear();
                controls.errorProvider_starting_segment_multiple_2.SetError(controls.txt_starting_number_determine_interval_multiple_2, "");
            }

            int last_segment_pair1 = 0, last_segment_pair2 = 0;
            lastSegment_pair1 = controls.txt_final_number_determine_interval_multiple_1.Text;
            lastSegment_pair2 = controls.txt_final_number_determine_interval_multiple_2.Text;
            if (String.IsNullOrEmpty(lastSegment_pair1) || String.IsNullOrWhiteSpace(lastSegment_pair1)
                || (!int.TryParse(lastSegment_pair1, out last_segment_pair1)))
            {
                controls.errorProvider_final_segment_multiple_1.SetError(controls.txt_final_number_determine_interval_multiple_1, Constants.MESSAGE_ENTER_POSITIVE_INTEGER_VALUE);
                validationError = true;
            }
            else
            {
                controls.errorProvider_final_segment_multiple_1.Clear();
                controls.errorProvider_final_segment_multiple_1.SetError(controls.txt_final_number_determine_interval_multiple_1, "");
            }

            if (String.IsNullOrEmpty(lastSegment_pair2) || String.IsNullOrWhiteSpace(lastSegment_pair2)
                || (!int.TryParse(lastSegment_pair2, out last_segment_pair2)))
            {
                controls.errorProvider_final_segment_multiple_2.SetError(controls.txt_final_number_determine_interval_multiple_2, Constants.MESSAGE_ENTER_POSITIVE_INTEGER_VALUE);
                validationError = true;
            }
            else
            {
                controls.errorProvider_final_segment_multiple_2.Clear();
                controls.errorProvider_final_segment_multiple_2.SetError(controls.txt_final_number_determine_interval_multiple_2, "");
            }

            if (last_segment_pair1 < initial_segment_pair1)
            {
                controls.errorProvider_segmentsIntervalFile_single.SetError(controls.txt_final_number_determine_interval_multiple_1, Constants.MESSAGE_ENTER_GREATER_VALUE);
                validationError = true;
            }
            if (last_segment_pair2 < initial_segment_pair2)
            {
                controls.errorProvider_segmentsIntervalFile_single.SetError(controls.txt_final_number_determine_interval_multiple_2, Constants.MESSAGE_ENTER_GREATER_VALUE);
                validationError = true;
            }

            return validationError;
        }

        public void btn_save_resegment_determine_interval_multiple(object sender, EventArgs e)
        {
            try
            {
                bool validationError = false;
                int id;
                string initialSegment_pair1, initialSegment_pair2, lastSegment_pair1, lastSegment_pair2;
                validationError = validation_MultipleFiles(out id, out initialSegment_pair1, out initialSegment_pair2, out lastSegment_pair1, out lastSegment_pair2);

                validationError = validationResegmentFields(validationError);

                if (validationError)
                    return;

                else
                {

                    if (controls.rbOptionFirstParticipant_determine_interval_resegment.Checked)
                    {
                        Constants.base_file_path = controls.txt_interval_determine_interval_multiple_1.Text;
                        Constants.ref_file_path = controls.txt_interval_determine_interval_multiple_2.Text;
                        Constants.starting_segment_num_base = controls.txt_starting_number_determine_interval_multiple_1.Text;
                        Constants.starting_segment_num_ref = controls.txt_starting_number_determine_interval_multiple_2.Text;
                        Constants.ending_segment_num_base = controls.txt_final_number_determine_interval_multiple_1.Text;
                        Constants.ending_segment_num_ref = controls.txt_final_number_determine_interval_multiple_2.Text;
                    }
                    else if (controls.rbOptionSecondParticipant_determine_interval_resegment.Checked)
                    {
                        Constants.base_file_path = controls.txt_interval_determine_interval_multiple_2.Text;
                        Constants.ref_file_path = controls.txt_interval_determine_interval_multiple_1.Text;
                        Constants.starting_segment_num_base = controls.txt_starting_number_determine_interval_multiple_2.Text;
                        Constants.starting_segment_num_ref = controls.txt_starting_number_determine_interval_multiple_1.Text;
                        Constants.ending_segment_num_base = controls.txt_final_number_determine_interval_multiple_2.Text;
                        Constants.ending_segment_num_ref = controls.txt_final_number_determine_interval_multiple_1.Text;
                    }


                    Constants.output_path_resegment = controls.txt_outputFolder_resegment.Text;
                    Constants.ExpIntervalofPair expIntervals = findSegmentsWithUtilizingSynchInfo();
                    string path_resegmented = Constants.output_path_resegment + "\\segments_interval.txt"; //resegmented file path created in findSegmentsWithUtilizingSynchInfo call

                    bool createOutputFile = false;
                    string output_path = controls.txt_outputFile_determine_interval.Text;
                    if (!File.Exists(output_path))
                        createOutputFile = true;

                    output_expInterval(id, expIntervals, createOutputFile, output_path);


                    string fileName = controls.txt_resegment_file.Text;
                    string _javadir = UtilityFunctions.LocateJava();

                    ProcessStartInfo start = new ProcessStartInfo();
                    if (!_javadir.Equals(String.Empty))
                    {
                        start.FileName = _javadir + "java.exe";
                    }
                    else
                    {
                        start.FileName = "java.exe";
                    }

                    start.Arguments = "-cp " + Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\speech_analysis\\Sphinx4Files\\sphinx4-core-all-1.0.jar edu.cmu.sphinx.tools.endpoint.Segmenter -i " + fileName + " -o " + controls.txt_outputFolder_resegment.Text + "\\ -comb " + path_resegmented;

                    start.UseShellExecute = false;
                    start.RedirectStandardInput = true;
                    start.RedirectStandardOutput = true;

                    //Start the Process
                    Process java = new Process();
                    java.StartInfo = start;
                    bool isStarted = java.Start();
                    java.WaitForExit();
                    int exitCode = java.ExitCode;
                    java.Close();
                    if (exitCode == 1)
                        MessageBox.Show("Java error thrown, please be sure to pre-request wriiten in walkthrough to run java.");
                    else
                    {

                        MessageBox.Show("Succesfully done!!");
                    }


                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Please be sure the files exist!!");
            }
        }

        private bool validationResegmentFields(bool validationError)
        {
            if (String.IsNullOrEmpty(controls.txt_resegment_file.Text) || String.IsNullOrWhiteSpace(controls.txt_resegment_file.Text))
            {
                controls.errorProvider_openFile_resegment.SetError(controls.txt_resegment_file, Constants.MESSAGE_SELECT_WAV_FILE);
                validationError = true;
            }
            else
            {
                controls.errorProvider_openFile_resegment.Clear();
                controls.errorProvider_openFile_resegment.SetError(controls.txt_resegment_file, "");
            }

            if (String.IsNullOrEmpty(controls.txt_outputFolder_resegment.Text) || String.IsNullOrWhiteSpace(controls.txt_outputFolder_resegment.Text))
            {
                controls.errorProvider_outputFolder_resegment.SetError(controls.txt_outputFolder_resegment, Constants.MESSAGE_SELECT_OUTPUT_FOLDER);
                validationError = true;
            }
            else
            {
                controls.errorProvider_outputFolder_resegment.Clear();
                controls.errorProvider_outputFolder_resegment.SetError(controls.txt_outputFolder_resegment, "");
            }

            if (controls.rbOptionFirstParticipant_determine_interval_resegment.Checked == false && controls.rbOptionSecondParticipant_determine_interval_resegment.Checked == false)
            {
                controls.errorProvider_first_or_second_partiicpant_resegment.SetError(controls.rbOptionSecondParticipant_determine_interval_resegment, Constants.MESSAGE_SELECT_ONE_OF_PARTICIPANT);
                validationError = true;
            }
            else
            {
                controls.errorProvider_first_or_second_partiicpant_resegment.Clear();
                controls.errorProvider_first_or_second_partiicpant_resegment.SetError(controls.rbOptionSecondParticipant_determine_interval_resegment, "");
            }

            return validationError;
        }

        public void btn_openFile_resegment(object sender, EventArgs e)
        {
            controls.ofd_openFile_resegment.InitialDirectory = "c:\\";
            controls.ofd_openFile_resegment.Filter = "wav files (*.wav)|*.wav";
            // ofd_aviFile.FilterIndex = 2;
            controls.ofd_openFile_resegment.RestoreDirectory = true;

            DialogResult result = controls.ofd_openFile_resegment.ShowDialog();

            string fileName = controls.ofd_openFile_resegment.FileName;
            controls.txt_resegment_file.Text = fileName;
            if (String.IsNullOrEmpty(fileName) || String.IsNullOrWhiteSpace(fileName))
            {
                controls.errorProvider_openFile_resegment.SetError(controls.txt_resegment_file, Constants.MESSAGE_SELECT_WAV_FILE);
                //MessageBox.Show("You have to select Video File (avi file)'!!");
                return;

            }
        }

        public void btn_openFolderOutput_resegment(object sender, EventArgs e)
        {
            string folderName = "";
            controls.fbd_outputFile_resegment.SelectedPath = "";

            DialogResult result = controls.fbd_outputFile_resegment.ShowDialog();
            if (result == DialogResult.OK)
            {
                folderName = controls.fbd_outputFile_resegment.SelectedPath;
                if (String.IsNullOrEmpty(folderName) || String.IsNullOrWhiteSpace(folderName))
                {
                    controls.errorProvider_outputFolder_resegment.SetError(controls.txt_outputFolder_resegment, Constants.MESSAGE_SELECT_OUTPUT_FOLDER);
                    //MessageBox.Show("You have to select outputFolder'!!");
                    return;
                }

                controls.txt_outputFolder_resegment.Text = folderName;

            }
        }

        public Constants.ExpIntervalofPair findSegmentsWithUtilizingSynchInfo()
        {


            Dictionary<int, string> dictionary = new Dictionary<int, string>();


            int starting_time_difference_between_participants_in_pair = 0;
            char[] delimiterChars = { ' ', '\t' };
            string[] words_base, words_ref;
            string segment_num = "";
            string line_base = "", line_ref = "";
            int seg_interval_start_base = 0, seg_interval_end_base = 0;
            int seg_interval_start_ref = 0, seg_interval_end_ref = 0;


            System.IO.StreamReader file_base = new System.IO.StreamReader(Constants.base_file_path);
            System.IO.StreamReader file_ref = new System.IO.StreamReader(Constants.ref_file_path);
            while ((line_base = file_base.ReadLine()) != null)
            {
                words_base = line_base.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
                if (words_base.Count() <= 3) continue;
                segment_num = words_base[0];
                if (Convert.ToInt32(segment_num) == (Convert.ToInt32(Constants.starting_segment_num_base) + 1)) //entered starting segment num represents just before the experiment, i.e., bip like sound, so we start from the next segment to exclude bip like sound
                {
                    seg_interval_start_base = Convert.ToInt32(words_base[1]);
                    break;
                }

            }

            while ((line_ref = file_ref.ReadLine()) != null)
            {
                words_ref = line_ref.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
                if (words_ref.Count() <= 3) continue;
                segment_num = words_ref[0];
                if (Convert.ToInt32(segment_num) == (Convert.ToInt32(Constants.starting_segment_num_ref) + 1))
                {
                    seg_interval_start_ref = Convert.ToInt32(words_ref[1]);
                    break;
                }

            }


            starting_time_difference_between_participants_in_pair = seg_interval_start_base - seg_interval_start_ref;
            List<int> intervals = new List<int>();
            string audio_of_the_one_selected_for_resegment = controls.rbOptionFirstParticipant_determine_interval_resegment.Checked ? "FirstParticipant" : "SecondParticipant";
            string audio_of_the_one_not_selected_for_resegment = controls.rbOptionFirstParticipant_determine_interval_resegment.Checked ? "SecondParticipant" : "FirstParticipant";

            try
            {
                do
                {

                    words_base = line_base.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
                    if (words_base.Count() <= 3) continue;
                    segment_num = words_base[0];
                    if (Convert.ToInt32(segment_num) == (Convert.ToInt32(Constants.ending_segment_num_base) + 1))
                        break;
                    seg_interval_start_base = Convert.ToInt32(words_base[1]);
                    seg_interval_end_base = Convert.ToInt32(words_base[2]);
                    if (!intervals.Contains(seg_interval_start_base))
                    {
                        intervals.Add(seg_interval_start_base);
                        dictionary.Add(seg_interval_start_base, " Start:" + audio_of_the_one_selected_for_resegment + ":" + words_base[0]);
                    }
                    if (!intervals.Contains(seg_interval_end_base))
                    {
                        intervals.Add(seg_interval_end_base);
                        if (!dictionary.ContainsKey(seg_interval_end_base))
                        {
                            dictionary.Add(seg_interval_end_base, " End:" + audio_of_the_one_selected_for_resegment + ":" + words_base[0]);
                        }
                    }

                } while ((line_base = file_base.ReadLine()) != null);
            }
            catch (Exception ex)
            {

                throw ex;
            }


            do
            {
                words_ref = line_ref.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
                if (words_ref.Count() <= 3) continue;
                segment_num = words_ref[0];
                if (Convert.ToInt32(segment_num) == (Convert.ToInt32(Constants.ending_segment_num_ref) + 1))
                    break;
                seg_interval_start_ref = Convert.ToInt32(words_ref[1]) + starting_time_difference_between_participants_in_pair;
                seg_interval_end_ref = Convert.ToInt32(words_ref[2]) + starting_time_difference_between_participants_in_pair;
                if (!intervals.Contains(seg_interval_start_ref))
                {

                    intervals.Add(seg_interval_start_ref);
                    if (!dictionary.ContainsKey(seg_interval_start_ref))
                    {
                        dictionary.Add(seg_interval_start_ref, " Start:" + audio_of_the_one_not_selected_for_resegment + ":" + words_ref[0]);
                    }


                }

                if (!intervals.Contains(seg_interval_end_ref))
                {
                    intervals.Add(seg_interval_end_ref);
                    if (!dictionary.ContainsKey(seg_interval_end_ref))
                    {
                        dictionary.Add(seg_interval_end_ref, " End:" + audio_of_the_one_not_selected_for_resegment + ":" + words_ref[0]);
                    }

                }

            } while ((line_ref = file_ref.ReadLine()) != null);

            intervals.Sort();

            string starting_time_pair1 = "", ending_time_pair_1 = "", starting_time_pair2 = "", ending_time_pair_2 = "";
            for (int i = 0; i < intervals.Count; i = i + 1)
            {

                if (i == 0)
                {
                    File.WriteAllText(Constants.output_path_resegment + "\\segments_interval.txt", i + " " + intervals[i] + "    " + intervals[(i + 1)] + "    " + (intervals[(i + 1)] - intervals[i]) + "  " + dictionary[intervals[i]] + "    " + dictionary[intervals[(i + 1)]] + "    " + starting_time_difference_between_participants_in_pair + "\n");
                    if (controls.rbOptionFirstParticipant_determine_interval_resegment.Checked)
                    {
                        starting_time_pair1 = intervals[i].ToString();
                        starting_time_pair2 = (intervals[i] - starting_time_difference_between_participants_in_pair).ToString();
                    }
                    else
                    {
                        starting_time_pair2 = intervals[i].ToString();
                        starting_time_pair1 = (intervals[i] - starting_time_difference_between_participants_in_pair).ToString();
                    }

                }

                else
                    File.AppendAllText(Constants.output_path_resegment + "\\segments_interval.txt", i + " " + intervals[i] + "    " + intervals[(i + 1)] + "    " + (intervals[(i + 1)] - intervals[i]) + "  " + dictionary[intervals[i]] + dictionary[intervals[(i + 1)]] + "    " + "\n");

                if (i + 2 == intervals.Count())
                {
                    if (controls.rbOptionFirstParticipant_determine_interval_resegment.Checked)
                    {
                        ending_time_pair_1 = intervals[(i + 1)].ToString();
                        ending_time_pair_2 = (intervals[(i + 1)] - starting_time_difference_between_participants_in_pair).ToString();
                    }
                    else
                    {
                        ending_time_pair_2 = intervals[(i + 1)].ToString();
                        ending_time_pair_1 = (intervals[(i + 1)] - starting_time_difference_between_participants_in_pair).ToString();
                    }
                    break;
                }

            }

            Constants.ExpIntervalofPair expInterval = new Constants.ExpIntervalofPair(starting_time_pair1, ending_time_pair_1, starting_time_pair2, ending_time_pair_2);

            return expInterval;


        }

        public void btn_gotoWalkthrough_Click(object sender, EventArgs e)
        {
            controls.navigationListener.navigateToSpecifyTimeIntervalWalkthrough();
        }
    }
}
