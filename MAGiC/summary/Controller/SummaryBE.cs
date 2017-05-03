using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAGiC
{
    public class SummaryBE
    {
        private SummaryUI controls;



        bool baseisFirst = false;

        string fileName_speechAnnotation = "", fileName_AOI_file_summary_first_pair="", fileName_AOI_file_summary_second_pair="", fileName_AOI_file_summary_single="",
               fileName_expInterval="";

        int id, frequency, diff_timeOffset_frameNo = 0;

        public SummaryBE(SummaryUI _controls)
        {
            controls = _controls;
            initialize();
        }

        public SummaryBE()
        {
            initialize();
        }

        public void initialize()
        {
            //controls.btn_createFileOutput_summary.Click += new System.EventHandler(this.btn_createFileOutput_summary_Click);
            controls.btn_output_folder_summary.Click += new System.EventHandler(this.btn_output_folder_summary_Click);
            controls.btn_openFileSpeechAnnotation_summary.Click += new System.EventHandler(this.btn_openFileSpeechAnnotation_summary_Click);
            controls.btn_openFileAOI_single_summary.Click += new System.EventHandler(this.btn_openFileAOI_single_summary_Click);

            controls.btn_openExpInterval_single_summary.Click += new System.EventHandler(this.btn_openExpInterval_single_summary_Click);
            controls.btn_save_summary_single.Click += new System.EventHandler(this.btn_save_summary_single_Click);
            controls.btn_openFileAOI_summary_first_pair.Click += new System.EventHandler(this.btn_openFileAOI_summary_first_pair_Click);

            controls.btn_openFileAOI_summary_second_pair.Click += new System.EventHandler(this.btn_openFileAOI_summary_second_pair_Click);
            controls.btn_openExpInterval_pair_summary.Click += new System.EventHandler(this.btn_openExpInterval_pair_summary_Click);
            controls.btn_save_summary_pair.Click += new System.EventHandler(this.btn_save_summary_pair_Click);

            controls.btn_gotoWalkthrough_summary.Click += new System.EventHandler(this.btn_gotoWalkthrough_Click);

        }

        private void btn_gotoWalkthrough_Click(object sender, EventArgs e)
        {
            controls.navigationListener.navigateToSummaryWalkthrough();
        }

        private void btn_save_summary_pair_Click(object sender, EventArgs e)
        {
            bool validationError = false;
            string output_file = controls.txt_output_folder_summary.Text+ "\\summary.txt";
            string output_file_speech = controls.txt_output_folder_summary.Text + "\\speech.txt";
            string output_file_starting_ending_frames_firstParticipant = controls.txt_output_folder_summary.Text + "\\starting_ending_frames_firstParticipant.txt";
            string output_file_starting_ending_frames_secondParticipant = controls.txt_output_folder_summary.Text + "\\starting_ending_frames_secondParticipant.txt";


            if (String.IsNullOrEmpty(output_file) || String.IsNullOrWhiteSpace(output_file))
            {
                controls.errorProvider_outputFolder_summary.SetError(controls.txt_output_folder_summary, Constants.MESSAGE_SELECT_OUTPUT_FILE);
                validationError = true;
            }
            else
            {
                controls.errorProvider_outputFolder_summary.Clear();
                controls.errorProvider_outputFolder_summary.SetError(controls.txt_output_folder_summary, "");
            }

             fileName_speechAnnotation = controls.txt_speechAnnotation_summary.Text;
            if (String.IsNullOrEmpty(fileName_speechAnnotation) || String.IsNullOrWhiteSpace(fileName_speechAnnotation) || !File.Exists(fileName_speechAnnotation))
            {
                controls.errorProvider_speechAnnotation_file_summary.SetError(controls.txt_speechAnnotation_summary, Constants.MESSAGE_SELECT_SPEECHANNOTATION_FILE);
                validationError = true;
            }
            else
            {
                controls.errorProvider_speechAnnotation_file_summary.Clear();
                controls.errorProvider_speechAnnotation_file_summary.SetError(controls.txt_speechAnnotation_summary, "");
            }


             fileName_AOI_file_summary_first_pair = controls.txt_AOI_file_summary_first_pair.Text;
            if (String.IsNullOrEmpty(fileName_AOI_file_summary_first_pair) || String.IsNullOrWhiteSpace(fileName_AOI_file_summary_first_pair) || !File.Exists(fileName_AOI_file_summary_first_pair))
            {
                controls.errorProvider_AOI_file_summary_first_pair.SetError(controls.txt_AOI_file_summary_first_pair, Constants.MESSAGE_SELECT_AOI_FILE);
                validationError = true;
            }
            else
            {
                controls.errorProvider_AOI_file_summary_first_pair.Clear();
                controls.errorProvider_AOI_file_summary_first_pair.SetError(controls.txt_AOI_file_summary_first_pair, "");
            }


             fileName_AOI_file_summary_second_pair = controls.txt_AOI_file_summary_second_pair.Text;
            if (String.IsNullOrEmpty(fileName_AOI_file_summary_second_pair) || String.IsNullOrWhiteSpace(fileName_AOI_file_summary_second_pair) || !File.Exists(fileName_AOI_file_summary_second_pair))
            {
                controls.errorProvider_AOI_file_summary_second_pair.SetError(controls.txt_AOI_file_summary_second_pair, Constants.MESSAGE_SELECT_AOI_FILE);
                validationError = true;
            }
            else
            {
                controls.errorProvider_AOI_file_summary_second_pair.Clear();
                controls.errorProvider_AOI_file_summary_second_pair.SetError(controls.txt_AOI_file_summary_second_pair, "");
            }

             fileName_expInterval = controls.txt_ExpInterval_file_summary_pair.Text;
            if (String.IsNullOrEmpty(fileName_expInterval) || String.IsNullOrWhiteSpace(fileName_expInterval) || !File.Exists(fileName_expInterval))
            {
                controls.errorProvider_expInterval_summary_pair.SetError(controls.txt_ExpInterval_file_summary_pair, Constants.MESSAGE_SELECT_EXPERIMENT_INTERVAL_FILE);
                validationError = true;
            }
            else
            {
                controls.errorProvider_expInterval_summary_pair.Clear();
                controls.errorProvider_expInterval_summary_pair.SetError(controls.txt_ExpInterval_file_summary_pair, "");
            }

             id = -1;
            string idStr = controls.txt_ExpIntervalParticipantNo_summary_pair.Text;
            if (String.IsNullOrEmpty(idStr) || String.IsNullOrWhiteSpace(idStr) || (!int.TryParse(idStr, out id)))
            {
                controls.errorProvider_participantID_pair.SetError(controls.txt_ExpIntervalParticipantNo_summary_pair, Constants.MESSAGE_ENTER_POSITIVE_INTEGER_VALUE);
                validationError = true;
            }
            else
            {
                controls.errorProvider_participantID_pair.Clear();
                controls.errorProvider_participantID_pair.SetError(controls.txt_ExpIntervalParticipantNo_summary_pair, "");
            }

            string frequencystr = controls.txt_ExpIntervalFrequency_summary_pair.Text;
             frequency = -1;
            if (String.IsNullOrEmpty(frequencystr) || String.IsNullOrWhiteSpace(frequencystr) || (!int.TryParse(frequencystr, out frequency)))
            {
                controls.errorProvider_eyetrackerFrequency_pair.SetError(controls.txt_ExpIntervalFrequency_summary_pair, Constants.MESSAGE_ENTER_POSITIVE_INTEGER_VALUE);
                validationError = true;
            }
            else
            {
                controls.errorProvider_eyetrackerFrequency_pair.Clear();
                controls.errorProvider_eyetrackerFrequency_pair.SetError(controls.txt_ExpIntervalFrequency_summary_pair, "");
            }

            if (validationError)
                return;

            try
            {
                Dictionary<int, string> dict_base_AOI = new Dictionary<int, string>();
                Dictionary<int, string> dict_ref_AOI = new Dictionary<int, string>();
                Dictionary<int, string> dict_speech_annotation = new Dictionary<int, string>();

                List<string> starting_endingFrames = fillDictionaries(ref dict_speech_annotation, ref dict_base_AOI, ref dict_ref_AOI);

                

                StringBuilder write_toLine = new StringBuilder() ;
                StringBuilder write_speechAnnotationToFile = new StringBuilder();

                int i = 0;
                foreach (KeyValuePair<int, string> pair in dict_speech_annotation)
                {
                    write_toLine.AppendLine((i + 1) + " " + pair.Value + " " + (baseisFirst == true ? dict_base_AOI.ElementAt((pair.Key-1)) : dict_ref_AOI.ElementAt(pair.Key - diff_timeOffset_frameNo-1)) + " " + (baseisFirst == true ? dict_ref_AOI.ElementAt(pair.Key-diff_timeOffset_frameNo-1) : dict_base_AOI.ElementAt(pair.Key-1)));
                    write_speechAnnotationToFile.AppendLine((i + 1) + " " + pair.Value);
                    i++;
                   
                }

                File.WriteAllText(output_file, write_toLine.ToString());
                File.WriteAllText(output_file_speech, write_speechAnnotationToFile.ToString());
                File.WriteAllText(output_file_starting_ending_frames_firstParticipant, starting_endingFrames.ElementAt(0));
                File.WriteAllText(output_file_starting_ending_frames_secondParticipant, starting_endingFrames.ElementAt(1));
                MessageBox.Show("Succesfully done!!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private List<string> fillDictionaries(ref Dictionary<int, string> dict_speech_annotation, ref Dictionary<int, string> dict_base_AOI, ref Dictionary<int, string> dict_ref_AOI)
        {
             

            try
            {
                List<string> starting_endingFrames = new List<string>(); 
                char[] delimiterChars = { ' ', '\t' };
                string[] words_speech_annotation;
                string line_sa = "", starting_time_str = "", ending_time_str = "", extended_speech_act = "";
                int interval_pair_1_starting = 0, interval_pair_1_ending = 0, interval_pair_2_starting = 0, interval_pair_2_ending = 0, starting_time = 0,
                    ending_time = 0, time_offset_between_participants = 0,  starting_frameNo = 0, ending_frameNo = 0;



                System.IO.StreamReader file_speechAnnotation = new System.IO.StreamReader(fileName_speechAnnotation);

                System.IO.StreamReader file_base = null, file_ref = null;

                Constants.ParticipantInfo participantInfo = Constants.ParticipantInfo.First;
                UtilityFunctions.findStartingEndingFrameNo(fileName_expInterval, id, participantInfo, frequency, ref interval_pair_1_starting, ref interval_pair_1_ending);

                if (dict_ref_AOI != null)
                {
                    participantInfo = Constants.ParticipantInfo.Second;
                    UtilityFunctions.findStartingEndingFrameNo(fileName_expInterval, id, participantInfo, frequency, ref interval_pair_2_starting, ref interval_pair_2_ending);
                }



                //set starting ending frame values
                if (dict_ref_AOI != null)
                {
                   
                        starting_endingFrames.Add(interval_pair_1_starting + " " + interval_pair_1_ending);
                        starting_endingFrames.Add(interval_pair_2_starting + " " + interval_pair_2_ending);
                    
                }
                else//if a single participant selected
                {
                    starting_endingFrames.Add(interval_pair_1_starting + " " + interval_pair_1_ending);
                }


                bool firstLine = true;
                while ((line_sa = file_speechAnnotation.ReadLine()) != null)
                {
                    words_speech_annotation = line_sa.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
                    if (words_speech_annotation.Count() <= 3) continue;

                    starting_time_str = words_speech_annotation[0];
                    starting_time = Convert.ToInt32(starting_time_str);

                    ending_time_str = words_speech_annotation[1];
                    ending_time = Convert.ToInt32(ending_time_str);

                    extended_speech_act = words_speech_annotation[2] + " ";
                    for (int i = 3; i < words_speech_annotation.Length; i++)
                    {
                        extended_speech_act += words_speech_annotation[i];
                    }


                    if (firstLine & dict_ref_AOI!=null)
                    {

                        if (UtilityFunctions.convertMilliSecondToEyeTrackerFrameNo(frequency, starting_time) == interval_pair_1_starting)
                        {
                            file_base = new System.IO.StreamReader(fileName_AOI_file_summary_first_pair);
                            file_ref = new System.IO.StreamReader(fileName_AOI_file_summary_second_pair);
                            time_offset_between_participants = interval_pair_1_starting - interval_pair_2_starting;
                            baseisFirst = true;

                        }
                        else
                        {
                            file_base = new System.IO.StreamReader(fileName_AOI_file_summary_second_pair);
                            file_ref = new System.IO.StreamReader(fileName_AOI_file_summary_first_pair);
                            time_offset_between_participants = interval_pair_2_starting - interval_pair_1_starting;
                            baseisFirst = false;
                        }

                        //diff_timeOffset_frameNo = UtilityFunctions.convertMilliSecondToEyeTrackerFrameNo(frequency, time_offset_between_participants);
                        diff_timeOffset_frameNo = time_offset_between_participants;
                        dict_base_AOI = fill_AOI_dict(file_base);
                        dict_ref_AOI = fill_AOI_dict(file_ref);

                        firstLine = false;
                    }
                    else if(firstLine & dict_ref_AOI == null)
                    {
                        file_base = new System.IO.StreamReader(fileName_AOI_file_summary_single);
                        dict_base_AOI = fill_AOI_dict(file_base);
                    }

                    //when calculate ending frame by converting ending millisecond value to frame number as in finding the starting frame number case, it might cause different number of frame numbers in a pair, because of conversion issues. 
                    //thus ending frame number is calculated based on difference value which is absolutely same in a pair.
                    starting_frameNo = UtilityFunctions.convertnextMilliSecondToEyeTrackerFrameNo(frequency, starting_time_str);
                    ending_frameNo = starting_frameNo+ UtilityFunctions.convertMilliSecondToEyeTrackerFrameNo(frequency, ending_time - starting_time) -1;




                    for (int i = starting_frameNo; i <= ending_frameNo; i++)
                    {

                        string val;

                        if (dict_speech_annotation.TryGetValue(i, out val))
                        {
                            // yay, value exists!
                            string[] outputLine_words = val.Split(delimiterChars);

                            string updatedLine = "";


                            string actor = outputLine_words[0];
                            //string speech_act = outputLine_words[1];
                            string speech_act = "";
                            for (int index = 1; index < outputLine_words.Length; index++)
                            {
                                speech_act += (i == 1 ? "" : " ") + outputLine_words[index];
                            }


                            string actor_newline = words_speech_annotation[2];
                            //string speech_act_newline = words_speech_annotation[3];
                            string speech_act_newline = "";
                            for (int index = 3; index < words_speech_annotation.Length; index++)
                            {
                                //speech_act_newline += (i==3?"":" ")+words_speech_annotation[index];
                                speech_act_newline += words_speech_annotation[index]; //remove spaces inside speechAct, as did we before
                            }


                            if (!actor.Contains(actor_newline))
                                updatedLine += actor + "," + actor_newline + " ";
                            else
                                updatedLine += actor_newline + " ";

                            if (!speech_act.Contains(speech_act_newline))
                                updatedLine += speech_act + "," + speech_act_newline;
                            else
                                updatedLine += speech_act_newline;

                            dict_speech_annotation[i] = updatedLine;

                        }
                        else
                            dict_speech_annotation[i] = extended_speech_act;



                    }
                }
                return starting_endingFrames;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private  Dictionary<int, string> fill_AOI_dict(StreamReader file)
        {
            Dictionary<int, string> dict_AOI = new Dictionary<int, string>();
            char[] delimiterChars = { ' ', '\t' };
            string line_aoi = "", line_aoi_without_frameNo = "";
            int frame_no = 0;
            while ((line_aoi = file.ReadLine()) != null)
            {
                string[] words = line_aoi.Split(delimiterChars);
                if (words.Count() < 1) continue;

                frame_no = Convert.ToInt32(words[0]);

                line_aoi_without_frameNo= line_aoi.Substring(line_aoi.IndexOf(" ") + 1).Trim();


                string val;

                if (!dict_AOI.TryGetValue(frame_no, out val))
                {
     
                    // darn, lets add the value
                    dict_AOI.Add(frame_no, line_aoi_without_frameNo);
                }

            }
            return dict_AOI;
        }

        private void btn_openExpInterval_pair_summary_Click(object sender, EventArgs e)
        {
            controls.ofd_openFileExpInterval_pair_summary.InitialDirectory = "c:\\";
            controls.ofd_openFileExpInterval_pair_summary.Filter = "txt files (*.txt)|*.txt";

            controls.ofd_openFileExpInterval_pair_summary.RestoreDirectory = true;

            DialogResult result = controls.ofd_openFileExpInterval_pair_summary.ShowDialog();

            string fileName = controls.ofd_openFileExpInterval_pair_summary.FileName;
            controls.txt_ExpInterval_file_summary_pair.Text = fileName;
            if (String.IsNullOrEmpty(fileName) || String.IsNullOrWhiteSpace(fileName))
            {
                controls.errorProvider_expInterval_summary_pair.SetError(controls.txt_ExpInterval_file_summary_pair, Constants.MESSAGE_SELECT_EXPERIMENT_INTERVAL_FILE);
                return;
            }
            else
            {
                controls.errorProvider_expInterval_summary_pair.Clear();
                controls.errorProvider_expInterval_summary_pair.SetError(controls.txt_ExpInterval_file_summary_pair, "");
            }
        }

        private void btn_openFileAOI_summary_second_pair_Click(object sender, EventArgs e)
        {
            controls.ofd_openFileAOI_summary_second_pair.InitialDirectory = "c:\\";
            controls.ofd_openFileAOI_summary_second_pair.Filter = "txt files (*.txt)|*.txt";

            controls.ofd_openFileAOI_summary_second_pair.RestoreDirectory = true;

            DialogResult result = controls.ofd_openFileAOI_summary_second_pair.ShowDialog();

            string fileName = controls.ofd_openFileAOI_summary_second_pair.FileName;
            controls.txt_AOI_file_summary_second_pair.Text = fileName;
            if (String.IsNullOrEmpty(fileName) || String.IsNullOrWhiteSpace(fileName))
            {
                controls.errorProvider_AOI_file_summary_second_pair.SetError(controls.txt_AOI_file_summary_second_pair, Constants.MESSAGE_SELECT_AOI_FILE);
                return;
            }
            else
            {
                controls.errorProvider_AOI_file_summary_second_pair.Clear();
                controls.errorProvider_AOI_file_summary_second_pair.SetError(controls.txt_AOI_file_summary_second_pair, "");
            }
        }

        private void btn_openFileAOI_summary_first_pair_Click(object sender, EventArgs e)
        {
            controls.ofd_openFileAOI_summary_first_pair.InitialDirectory = "c:\\";
            controls.ofd_openFileAOI_summary_first_pair.Filter = "txt files (*.txt)|*.txt";

            controls.ofd_openFileAOI_summary_first_pair.RestoreDirectory = true;

            DialogResult result = controls.ofd_openFileAOI_summary_first_pair.ShowDialog();

            string fileName = controls.ofd_openFileAOI_summary_first_pair.FileName;
            controls.txt_AOI_file_summary_first_pair.Text = fileName;
            if (String.IsNullOrEmpty(fileName) || String.IsNullOrWhiteSpace(fileName))
            {
                controls.errorProvider_AOI_file_summary_first_pair.SetError(controls.txt_AOI_file_summary_first_pair, Constants.MESSAGE_SELECT_AOI_FILE);
                return;
            }
            else
            {
                controls.errorProvider_AOI_file_summary_first_pair.Clear();
                controls.errorProvider_AOI_file_summary_first_pair.SetError(controls.txt_AOI_file_summary_first_pair, "");
            }
        }

        private void btn_save_summary_single_Click(object sender, EventArgs e)
        {
            bool validationError = false;

            string output_file = controls.txt_output_folder_summary.Text + "\\summary.txt";
            string output_file_speech = controls.txt_output_folder_summary.Text + "\\speech.txt";
            string output_file_starting_ending_frames_singleParticipant = controls.txt_output_folder_summary.Text + "\\starting_ending_frames_singleParticipant.txt";

            if (String.IsNullOrEmpty(output_file) || String.IsNullOrWhiteSpace(output_file))
            {
                controls.errorProvider_outputFolder_summary.SetError(controls.txt_output_folder_summary, Constants.MESSAGE_SELECT_OUTPUT_FILE);
                validationError = true;
            }
            else
            {
                controls.errorProvider_outputFolder_summary.Clear();
                controls.errorProvider_outputFolder_summary.SetError(controls.txt_output_folder_summary, "");
            }

            fileName_speechAnnotation = controls.txt_speechAnnotation_summary.Text;
            if (String.IsNullOrEmpty(fileName_speechAnnotation) || String.IsNullOrWhiteSpace(fileName_speechAnnotation) || !File.Exists(fileName_speechAnnotation))
            {
                controls.errorProvider_speechAnnotation_file_summary.SetError(controls.txt_speechAnnotation_summary, Constants.MESSAGE_SELECT_SPEECHANNOTATION_FILE);
                validationError = true;
            }
            else
            {
                controls.errorProvider_speechAnnotation_file_summary.Clear();
                controls.errorProvider_speechAnnotation_file_summary.SetError(controls.txt_speechAnnotation_summary, "");
            }


            fileName_AOI_file_summary_single = controls.txt_AOI_file_summary_single.Text;
            if (String.IsNullOrEmpty(fileName_AOI_file_summary_single) || String.IsNullOrWhiteSpace(fileName_AOI_file_summary_single) || !File.Exists(fileName_AOI_file_summary_single))
            {
                controls.errorProvider_AOI_file_summary_single.SetError(controls.txt_AOI_file_summary_single, Constants.MESSAGE_SELECT_AOI_FILE);
                validationError = true;
            }
            else
            {
                controls.errorProvider_AOI_file_summary_single.Clear();
                controls.errorProvider_AOI_file_summary_single.SetError(controls.txt_AOI_file_summary_single, "");
            }
           
            fileName_expInterval = controls.txt_ExpInterval_file_summary_single.Text;
            if (String.IsNullOrEmpty(fileName_expInterval) || String.IsNullOrWhiteSpace(fileName_expInterval) || !File.Exists(fileName_expInterval))
            {
                controls.errorProvider_expInterval_summary_single.SetError(controls.txt_ExpInterval_file_summary_single, Constants.MESSAGE_SELECT_EXPERIMENT_INTERVAL_FILE);
                validationError = true;
            }
            else
            {
                controls.errorProvider_expInterval_summary_single.Clear();
                controls.errorProvider_expInterval_summary_single.SetError(controls.txt_ExpInterval_file_summary_single, "");
            }

            id = -1;
            string idStr = controls.txt_ExpIntervalParticipantNo_summary_single.Text;
            if (String.IsNullOrEmpty(idStr) || String.IsNullOrWhiteSpace(idStr) || (!int.TryParse(idStr, out id)))
            {
                controls.errorProvider_participantID_single.SetError(controls.txt_ExpIntervalParticipantNo_summary_single, Constants.MESSAGE_ENTER_POSITIVE_INTEGER_VALUE);
                validationError = true;
            }
            else
            {
                controls.errorProvider_participantID_single.Clear();
                controls.errorProvider_participantID_single.SetError(controls.txt_ExpIntervalParticipantNo_summary_single, "");
            }

            string frequencystr = controls.txt_ExpIntervalFrequency_summary_single.Text;
            frequency = -1;
            if (String.IsNullOrEmpty(frequencystr) || String.IsNullOrWhiteSpace(frequencystr) || (!int.TryParse(frequencystr, out frequency)))
            {
                controls.errorProvider_eyetrackerFrequency_single.SetError(controls.txt_ExpIntervalFrequency_summary_single, Constants.MESSAGE_ENTER_POSITIVE_INTEGER_VALUE);
                validationError = true;
            }
            else
            {
                controls.errorProvider_eyetrackerFrequency_single.Clear();
                controls.errorProvider_eyetrackerFrequency_single.SetError(controls.txt_ExpIntervalFrequency_summary_single, "");
            }

            if (validationError)
                return;

            try
            {
                Dictionary<int, string> dict_base_AOI = new Dictionary<int, string>();
                Dictionary<int, string> dict_ref_AOI = null;
                Dictionary<int, string> dict_speech_annotation = new Dictionary<int, string>();

                List<string> starting_endingFrames = fillDictionaries(ref dict_speech_annotation, ref dict_base_AOI, ref dict_ref_AOI);


                
                StringBuilder write_toLine = new StringBuilder();
                StringBuilder write_speechAnnotationToFile = new StringBuilder();

                int i = 0;
                foreach (KeyValuePair<int, string> pair in dict_speech_annotation)
                {
                    write_toLine.AppendLine((i + 1) + " " + pair.Value + " " + dict_base_AOI.ElementAt(pair.Key-1));
                    write_speechAnnotationToFile.AppendLine((i + 1) + " " + pair.Value);
                    i++;

                }

                File.WriteAllText(output_file, write_toLine.ToString());
                File.WriteAllText(output_file_speech, write_speechAnnotationToFile.ToString());
                File.WriteAllText(output_file_starting_ending_frames_singleParticipant, starting_endingFrames.ElementAt(0));



                MessageBox.Show("Succesfully done!!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btn_openExpInterval_single_summary_Click(object sender, EventArgs e)
        {
            controls.ofd_openFileExpInterval_single_summary.InitialDirectory = "c:\\";
            controls.ofd_openFileExpInterval_single_summary.Filter = "txt files (*.txt)|*.txt";

            controls.ofd_openFileExpInterval_single_summary.RestoreDirectory = true;

            DialogResult result = controls.ofd_openFileExpInterval_single_summary.ShowDialog();

            string fileName = controls.ofd_openFileExpInterval_single_summary.FileName;
            controls.txt_ExpInterval_file_summary_single.Text = fileName;
            if (String.IsNullOrEmpty(fileName) || String.IsNullOrWhiteSpace(fileName))
            {
                controls.errorProvider_expInterval_summary_single.SetError(controls.txt_ExpInterval_file_summary_single, Constants.MESSAGE_SELECT_MANUALLY_LABELLED_AOIs_FILE);
                return;
            }
            else
            {
                controls.errorProvider_expInterval_summary_single.Clear();
                controls.errorProvider_expInterval_summary_single.SetError(controls.txt_ExpInterval_file_summary_single, "");
            }
        }

        private void btn_openFileSpeechAnnotation_summary_Click(object sender, EventArgs e)
        {
            controls.ofd_openFileSpeechAnnotation_summary.InitialDirectory = "c:\\";
            controls.ofd_openFileSpeechAnnotation_summary.Filter = "txt files (*.txt)|*.txt";
            controls.ofd_openFileSpeechAnnotation_summary.RestoreDirectory = true;

            DialogResult result = controls.ofd_openFileSpeechAnnotation_summary.ShowDialog();

            string fileName = controls.ofd_openFileSpeechAnnotation_summary.FileName;
            controls.txt_speechAnnotation_summary.Text = fileName;
            if (String.IsNullOrEmpty(fileName) || String.IsNullOrWhiteSpace(fileName))
            {
                controls.errorProvider_speechAnnotation_file_summary.SetError(controls.txt_speechAnnotation_summary, Constants.MESSAGE_SELECT_SPEECHANNOTATION_FILE);
                return;
            }
            else
            {
                controls.errorProvider_speechAnnotation_file_summary.Clear();
                controls.errorProvider_speechAnnotation_file_summary.SetError(controls.txt_speechAnnotation_summary, "");
            }
        }

        private void btn_openFileAOI_single_summary_Click(object sender, EventArgs e)
        {
            controls.ofd_openFileAOI_single_summary.InitialDirectory = "c:\\";
            controls.ofd_openFileAOI_single_summary.Filter = "txt files (*.txt)|*.txt";
            controls.ofd_openFileAOI_single_summary.RestoreDirectory = true;

            DialogResult result = controls.ofd_openFileAOI_single_summary.ShowDialog();

            string fileName = controls.ofd_openFileAOI_single_summary.FileName;
            controls.txt_AOI_file_summary_single.Text = fileName;
            if (String.IsNullOrEmpty(fileName) || String.IsNullOrWhiteSpace(fileName))
            {
                controls.errorProvider_AOI_file_summary_single.SetError(controls.txt_AOI_file_summary_single, Constants.MESSAGE_SELECT_AOI_FILE);
                return;
            }
            else
            {
                controls.errorProvider_AOI_file_summary_single.Clear();
                controls.errorProvider_AOI_file_summary_single.SetError(controls.txt_AOI_file_summary_single, "");
            }
        }

        //private void btn_createFileOutput_summary_Click(object sender, EventArgs e)
        //{
        //    controls.sfd_outputFile_summary_create.InitialDirectory = @"C:\";
        //    controls.sfd_outputFile_summary_create.Title = "Save text File";
        //    controls.sfd_outputFile_summary_create.FileName = "summary.txt";
        //    controls.sfd_outputFile_summary_create.CheckPathExists = true;
        //    controls.sfd_outputFile_summary_create.DefaultExt = "txt";
        //    controls.sfd_outputFile_summary_create.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
        //    controls.sfd_outputFile_summary_create.FilterIndex = 2;
        //    controls.sfd_outputFile_summary_create.RestoreDirectory = true;

        //    if (controls.sfd_outputFile_summary_create.ShowDialog() == DialogResult.OK)
        //    {
        //        controls.txt_outputFile_summary.Text = controls.sfd_outputFile_summary_create.FileName;
        //    }
        //}


        private void btn_output_folder_summary_Click(object sender, EventArgs e)
        {
            string folderName = "";

            DialogResult result = controls.fbd_output_folder_summary.ShowDialog();
            if (result == DialogResult.OK)
            {
                folderName = controls.fbd_output_folder_summary.SelectedPath;
                if (String.IsNullOrEmpty(folderName) || String.IsNullOrWhiteSpace(folderName))
                {

                    controls.errorProvider_outputFolder_summary.SetError(controls.txt_output_folder_summary, Constants.MESSAGE_SELECT_OUTPUT_FOLDER);
                    return;
                }

                else
                {
                    controls.errorProvider_outputFolder_summary.Clear();
                    controls.errorProvider_outputFolder_summary.SetError(controls.txt_output_folder_summary, "");
                }


                controls.txt_output_folder_summary.Text = folderName;

            }
        }
    }
}
