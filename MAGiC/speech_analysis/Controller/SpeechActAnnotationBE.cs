using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxWMPLib;

namespace MAGiC
{
    public class SpeechActAnnotationBE
    {
        private SpeechActAnnotationUI controls;

        private System.Windows.Forms.TextBox editBox;
        private int itemSelected;
        private int delta = 10;
        private string itemText;
        private string itemId;
        private string lastSelectedAudioName = "";

        bool loadingPlayer = false;
        double duration;
        bool audioFilesLoaded = false;
        bool segmentIntervalLoaded = false;


        Dictionary<string, int[]> audioFileNameWithSegmentedInterval = new Dictionary<string, int[]>();
        public SpeechActAnnotationBE(SpeechActAnnotationUI _controls)
        {
            controls = _controls;
            initialize();
        }

        public SpeechActAnnotationBE()
        {
            initialize();
        }



        public void initialize()
        {

            controls.txt_add_speechAct.ForeColor = SystemColors.GrayText;
            controls.txt_add_speechAct.Text = Constants.MESSAGE_ENTER_SPEECH_ACT;
            controls.txt_add_speechAct.Leave += new System.EventHandler(this.txt_speechAct_Leave);
            controls.txt_add_speechAct.Enter += new System.EventHandler(this.txt_speechAct_Enter);

            controls.btn_save_speechAct.Click += new System.EventHandler(this.btn_save_Click);
            controls.btn_browseAndLoad_speechAct.Click += new System.EventHandler(this.btn_browseAndLoad_Click);
            //controls.btn_saveas_speechAct.Click += new System.EventHandler(this.btn_saveAs_Click);
            controls.btn_add_speechAct.Click += new System.EventHandler(this.btn_add_Click);
            controls.btn_remove_speechAct.Click += new System.EventHandler(this.btn_remove_Click);
            controls.btn_up_speechAct.Click += new System.EventHandler(this.btnUp_Click);
            controls.btn_down_speechAct.Click += new System.EventHandler(this.btnDown_Click);

            controls.lb_speechAct.DoubleClick += new System.EventHandler(this.listBox_SpeechActs_DoubleClick);
            controls.lb_speechAct.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBox_SpeechActs_KeyDown);
            controls.lb_speechAct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listBox_SpeechActs_KeyPress);

            editBox = new System.Windows.Forms.TextBox();
            editBox.Location = new System.Drawing.Point(0, 0);
            editBox.Size = new System.Drawing.Size(0, 0);
            editBox.Hide();
            controls.lb_speechAct.Controls.AddRange(new System.Windows.Forms.Control[] { this.editBox });
            editBox.Text = "";
            editBox.BackColor = Color.Beige;
            editBox.Font = new Font("Varanda", 15, FontStyle.Regular | FontStyle.Underline, GraphicsUnit.Pixel);
            editBox.ForeColor = Color.Blue;
            editBox.BorderStyle = BorderStyle.FixedSingle;
            editBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EditOver);
            editBox.LostFocus += new System.EventHandler(this.FocusOver);
            controls.btn_gotoWalkthrough_speechAct.Click += new System.EventHandler(this.btn_gotoWalkthrough_speechAct_Click);


            //annotation
            controls.btn_createorLoad_output_annotation.Click += new System.EventHandler(this.btn_createorLoad_output_annotation_Click);
            controls.btn_load_speechAct_annotation.Click += new System.EventHandler(this.btn_load_speechAct_annotation_Click);
            controls.btn_load_audioFiles_annotation.Click += new System.EventHandler(this.btn_load_audioFiles_annotation_Click);
            controls.btn_load_segmentInterval_annotation.Click += new System.EventHandler(this.btn_load_segment_interval_annotation_Click);
            controls.btn_assignAndPlayNext_annotation.Click += new System.EventHandler(this.btn_assignAndPlayNext_annotation_Click);
            controls.btn_assign_annotation.Click += new System.EventHandler(this.btn_assign_annotation_Click);
            controls.lb_audioFiles_annotation.SelectedIndexChanged += new System.EventHandler(this.lb_audioFiles_annotation_SelectedIndexChanged);
            controls.btn_save_annotation.Click+= new System.EventHandler(this.btn_save_annotation_click);
            controls.rbOptionFirstParticipant_annotation.Checked = true;

            controls.timer1.Interval = 100;
            controls.timer1.Tick += new EventHandler(timer1_Tick);
            controls.timer1.Start();
            controls.axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer1_PlayStateChange);
            controls.btn_gotoWalkthrough_annotation.Click += new System.EventHandler(this.btn_gotoWalkthrough_annotation_Click);



        }

        private void btn_assign_annotation_Click(object sender, EventArgs e)
        {
            bool validation = annotationValidation();

            if (!validation)
                return;

            annotateAndReturnNextURL();
        }

        private void btn_save_annotation_click(object sender, EventArgs e)
        {
            File.WriteAllText(controls.txt_outputFile_annotation.Text, controls.txt_outputFileContent_annotation.Text);
            //controls.lb_speechAct.Items.Clear();
            MessageBox.Show("Succesfully done!!");
        }

        private void lb_audioFiles_annotation_SelectedIndexChanged(object sender, EventArgs e)
        {
            string urlToPlay = ((Constants.AudioFilesNameAndPath)(controls.lb_audioFiles_annotation.SelectedItem)).Path;
            controls.axWindowsMediaPlayer1.URL = urlToPlay;
            loadingPlayer = true;
        }

        private void btn_assignAndPlayNext_annotation_Click(object sender, EventArgs e)
        {
            bool validation = annotationValidation();

            if (!validation)
                return;

            string urlToPlay = "";

            urlToPlay = annotateAndReturnNextURL();
            if (urlToPlay == null)
            {
                MessageBox.Show("End of Audio List, please click the Save button to save the annotations!!");
                return;
            }

            controls.axWindowsMediaPlayer1.URL = urlToPlay;
            loadingPlayer = true;
            controls.axWindowsMediaPlayer1.Ctlcontrols.play();
            lastSelectedAudioName = Path.GetFileNameWithoutExtension(urlToPlay);

        }

        private string annotateAndReturnNextURL()
        {
            string urlToPlay = "";
            if (controls.lb_audioFiles_annotation.SelectedItem != null && controls.lb_speechAct_annotation.SelectedItem != null)
            {

                int[] existing;
                if (audioFileNameWithSegmentedInterval.TryGetValue(((Constants.AudioFilesNameAndPath)(controls.lb_audioFiles_annotation.SelectedItem)).Name, out existing))
                {
                    if (!String.IsNullOrEmpty(controls.txt_outputFileContent_annotation.Text) && !String.IsNullOrWhiteSpace(controls.txt_outputFileContent_annotation.Text))
                    {
                        controls.txt_outputFileContent_annotation.Text += Environment.NewLine + existing[0] + " " + existing[1] + " " + (controls.rbOptionFirstParticipant_annotation.Checked == true ? " First_Participant " : " ") + (controls.rbOptionSecondParticipant_annotation.Checked == true ? " Second_Participant " : " ");

                    }
                    else//first line
                        controls.txt_outputFileContent_annotation.Text += existing[0] + " " + existing[1] + " " + (controls.rbOptionFirstParticipant_annotation.Checked == true ? " First_Participant " : " ") + (controls.rbOptionSecondParticipant_annotation.Checked == true ? " Second_Participant " : " ");
                    int i = 0;
                    foreach (Constants.SpeechActs speechacts in controls.lb_speechAct_annotation.SelectedItems)
                    {
                        if (i > 0)
                            controls.txt_outputFileContent_annotation.Text += "," + speechacts.Name;
                        else
                            controls.txt_outputFileContent_annotation.Text += speechacts.Name;
                        i++;
                    }

                    controls.txt_outputFileContent_annotation.ScrollToCaret();
                }

                if ((controls.lb_audioFiles_annotation.SelectedIndex + 1) == controls.lb_audioFiles_annotation.Items.Count)
                    return null; //end of story

                urlToPlay = ((Constants.AudioFilesNameAndPath)(controls.lb_audioFiles_annotation.Items[controls.lb_audioFiles_annotation.SelectedIndex + 1])).Path;
                
                controls.lb_audioFiles_annotation.SelectedIndex = controls.lb_audioFiles_annotation.SelectedIndex + 1;
                controls.lb_speechAct_annotation.SelectedItem = null;
            }

            if (controls.lb_audioFiles_annotation.SelectedIndex != 1 && lastSelectedAudioName == "")
            {
                urlToPlay = ((Constants.AudioFilesNameAndPath)controls.lb_audioFiles_annotation.Items[0]).Path;
                controls.lb_audioFiles_annotation.SelectedIndex = 0;
            }

            return urlToPlay;
        }

        private bool annotationValidation()
        {
            bool validation = true;
            if (audioFilesLoaded == false)
            {

                controls.errorProvider_assignAndPlayNext_annotation.SetError(controls.btn_assignAndPlayNext_annotation, Constants.MESSAGE_LOAD_AUDIO_FILES);
                validation = false;
            }
            else
            {
                controls.errorProvider_assignAndPlayNext_annotation.Clear();
                controls.errorProvider_assignAndPlayNext_annotation.SetError(controls.btn_assignAndPlayNext_annotation, "");
            }

            if (segmentIntervalLoaded == false)
            {

                controls.errorProvider_assignAndPlayNext_annotation.SetError(controls.btn_assignAndPlayNext_annotation, Constants.MESSAGE_LOAD_SEGMENTS_INTERVAL_OF_LOADED_AUDIO_FILES);
                validation = false;
            }
            else
            {
                controls.errorProvider_assignAndPlayNext_annotation.Clear();
                controls.errorProvider_assignAndPlayNext_annotation.SetError(controls.btn_assignAndPlayNext_annotation, "");
            }
            if (controls.lb_audioFiles_annotation.SelectedItems == null || controls.lb_audioFiles_annotation.SelectedItems.Count < 0)
            {
                controls.errorProvider_assignAndPlayNext_annotation.SetError(controls.btn_assignAndPlayNext_annotation, Constants.MESSAGE_SELECT_AUDIO_FILE);
                validation = false;
            }
            else
            {
                controls.errorProvider_assignAndPlayNext_annotation.Clear();
                controls.errorProvider_assignAndPlayNext_annotation.SetError(controls.btn_assignAndPlayNext_annotation, "");
            }
            if (controls.lb_speechAct_annotation.SelectedItems == null || controls.lb_speechAct_annotation.SelectedItems.Count < 0)
            {
                controls.errorProvider_assignAndPlayNext_annotation.SetError(controls.btn_assignAndPlayNext_annotation, Constants.MESSAGE_SELECT_SPEECH_ACT);
                validation = false;
            }
            else
            {
                controls.errorProvider_assignAndPlayNext_annotation.Clear();
                controls.errorProvider_assignAndPlayNext_annotation.SetError(controls.btn_assignAndPlayNext_annotation, "");
            }

            if (String.IsNullOrEmpty(controls.txt_outputFile_annotation.Text) || String.IsNullOrWhiteSpace(controls.txt_outputFile_annotation.Text))
            {
                controls.errorProvider_output_file_annotation.SetError(controls.txt_outputFile_annotation, Constants.MESSAGE_SELECT_OUTPUT_FILE);
                validation = false;
            }
            else
            {
                controls.errorProvider_output_file_annotation.Clear();
                controls.errorProvider_output_file_annotation.SetError(controls.txt_outputFile_annotation, "");
            }

            return validation;
        }

        private void btn_load_segment_interval_annotation_Click(object sender, EventArgs e)
        {
            string fileName = "";
            List<Constants.AudioFilesNameAndPath> lb_audioFiles_annotationWithInterval = null;
            audioFileNameWithSegmentedInterval = new Dictionary<string, int[]>();

            controls.ofd_segmentInterval_annotation.InitialDirectory = "c:\\";
            controls.ofd_segmentInterval_annotation.Filter = "txt files (*.txt)|*.txt";
            controls.ofd_segmentInterval_annotation.FilterIndex = 2;
            controls.ofd_segmentInterval_annotation.RestoreDirectory = true;

            DialogResult result = controls.ofd_segmentInterval_annotation.ShowDialog();
            if (result == DialogResult.OK)
            {
                fileName = controls.ofd_segmentInterval_annotation.FileName;
                if (String.IsNullOrEmpty(fileName) || String.IsNullOrWhiteSpace(fileName))
                {
                    MessageBox.Show("You have to select segment-interval file of selected audio File");
                    return;
                }

                try
                {
                    char[] delimiterChars = { ' ', '\t' };
                    string[] words_segment_interval;
                    string line = "", segment_num = "";
                    int interval1 = 0, interval2 = 0, index = 1;
                    System.IO.StreamReader file_segment_interval = new System.IO.StreamReader(fileName);

                    if (controls.lb_audioFiles_annotation != null && controls.lb_audioFiles_annotation.Items != null )
                    {
                        lb_audioFiles_annotationWithInterval = controls.lb_audioFiles_annotation.Items.Cast<Constants.AudioFilesNameAndPath>().ToList();
                    }

                    while ((line = file_segment_interval.ReadLine()) != null)
                    {
                        words_segment_interval = line.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
                        if (words_segment_interval.Count() <= 3) continue;
                        segment_num = words_segment_interval[0];
                        index = 1;
                        for (; index < words_segment_interval.Count(); index++)
                        {
                            if (!String.IsNullOrEmpty(words_segment_interval[index]) && !String.IsNullOrWhiteSpace(words_segment_interval[index]))
                            {
                                interval1 = Convert.ToInt32(words_segment_interval[index]);
                                break;
                            }
                        }
                        index++;
                        for (; index < words_segment_interval.Count(); index++)
                        {
                            if (!String.IsNullOrEmpty(words_segment_interval[index]) && !String.IsNullOrWhiteSpace(words_segment_interval[index]))
                            {
                                interval2 = Convert.ToInt32(words_segment_interval[index]);
                                break;
                            }
                        }

                        audioFileNameWithSegmentedInterval.Add(segment_num, new int[] { interval1, interval2 });
                        if(lb_audioFiles_annotationWithInterval != null && lb_audioFiles_annotationWithInterval.Count> Convert.ToInt32(segment_num))
                        {
                            Constants.AudioFilesNameAndPath member = lb_audioFiles_annotationWithInterval.ElementAt(Convert.ToInt32(segment_num));
                            member.Interval = interval1 + "-" + interval2;

                        }
                          

                    }
                    segmentIntervalLoaded = true;
                    controls.errorProvider_load_segmentInterval_annotation.Clear();
                    controls.errorProvider_load_segmentInterval_annotation.SetError(controls.btn_load_segmentInterval_annotation, "");
                    controls.lb_audioFiles_annotation.Items.Clear();
                    controls.lb_audioFiles_annotation.DataSource = lb_audioFiles_annotationWithInterval;

                }
                catch (Exception ex)
                {


                    controls.errorProvider_load_segmentInterval_annotation.SetError(controls.btn_load_segmentInterval_annotation, Constants.ERROR_FILE_FORMAT_IS_WRONG);
                    return;
                }

            }

        }


        public string FilePath
        {
            get { return controls.txt_outputFile_speechAct.Text; }
            set { controls.txt_outputFile_speechAct.Text = value; }
        }


        private void btn_load_speechAct_annotation_Click(object sender, EventArgs e)
        {
            string fileName = "";

            controls.ofd_speechAct_file_annotation.InitialDirectory = "c:\\";
            controls.ofd_speechAct_file_annotation.Filter = "txt files (*.txt)|*.txt";
            controls.ofd_speechAct_file_annotation.FilterIndex = 2;
            controls.ofd_speechAct_file_annotation.RestoreDirectory = true;

            DialogResult result = controls.ofd_speechAct_file_annotation.ShowDialog();
            if (result == DialogResult.OK)
            {
                fileName = controls.ofd_speechAct_file_annotation.FileName;
                if (String.IsNullOrEmpty(fileName) || String.IsNullOrWhiteSpace(fileName))
                {
                    MessageBox.Show("You have to select SpeechAct File (txt file , each line consist of unique id and spech-act text delimited with ';'!!");
                    return;
                }

                loadSpeechActs(fileName);

            }
        }

        private void loadSpeechActs(string fileName)
        {
            controls.lb_speechAct_annotation.Items.Clear();
            string[] speechActs = File.ReadAllLines(fileName);
            foreach (string line in speechActs)
            {
                if (!String.IsNullOrEmpty(line) && !String.IsNullOrWhiteSpace(line)
                    && line.Split(';').Length > 1)
                {
                    string id = line.Split(';')[0];
                    string text = line.Split(';')[1];
                    controls.lb_speechAct_annotation.Items.Add(new Constants.SpeechActs(id, text));
                }
            }
        }


        private void btn_load_audioFiles_annotation_Click(object sender, EventArgs e)
        {
            string folderName = "";


            DialogResult result = controls.fbd_audioFiles_annotation.ShowDialog();
            if (result == DialogResult.OK)
            {
                folderName = controls.fbd_audioFiles_annotation.SelectedPath;
                if (String.IsNullOrEmpty(folderName) || String.IsNullOrWhiteSpace(folderName))
                {
                    MessageBox.Show("You have to select SpeechAct File (txt file , each line consist of unique id and spech-act text delimited with ';'!!");
                    return;
                }

                loadAudioFiles(folderName);
                audioFilesLoaded = true;

            }
        }

        private void loadAudioFiles(string folderName)
        {
            controls.lb_audioFiles_annotation.Items.Clear();
            IOrderedEnumerable<FileSystemInfo> fileSystemInfos = new DirectoryInfo(folderName).GetFileSystemInfos("*.wav").OrderBy(fs => int.Parse(fs.Name.Split('.')[0]));

            foreach (FileSystemInfo f in fileSystemInfos)
            {


                // audioFiles.Add(new Constants.AudioFiles(Path.GetFullPath(f), Path.GetFileNameWithoutExtension(f)));
                controls.lb_audioFiles_annotation.Items.Add(new Constants.AudioFilesNameAndPath(Path.GetFileNameWithoutExtension(f.FullName), f.FullName));
            }

        }

        private void CreateEditBox(object sender)
        {
            controls.lb_speechAct = (ListBox)sender;
            if (controls.lb_speechAct == null || controls.lb_speechAct.Items == null || controls.lb_speechAct.Items.Count < 1)
                return;
            itemSelected = controls.lb_speechAct.SelectedIndex;
            Rectangle r = controls.lb_speechAct.GetItemRectangle(itemSelected);
            Constants.SpeechActs item = (Constants.SpeechActs)controls.lb_speechAct.Items[itemSelected];
            itemText = item.Name;
            itemId = item.Id;
            editBox.Location = new System.Drawing.Point(r.X + delta, r.Y + delta);
            editBox.Size = new System.Drawing.Size(r.Width - 10, r.Height - delta);
            editBox.Show();
            controls.lb_speechAct.Controls.AddRange(new System.Windows.Forms.Control[] { this.editBox });
            editBox.Text = itemText;
            editBox.Focus();
            editBox.SelectAll();
            editBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EditOver);
            editBox.LostFocus += new System.EventHandler(this.FocusOver);
        }


        private void txt_speechAct_Enter(object sender, EventArgs e)
        {
            if (controls.txt_add_speechAct.Text.Equals(Constants.MESSAGE_ENTER_SPEECH_ACT))
            {
                controls.txt_add_speechAct.Text = "";
                controls.txt_add_speechAct.ForeColor = SystemColors.WindowText;
            }
        }


        private void txt_speechAct_Leave(object sender, EventArgs e)
        {
            if (controls.txt_add_speechAct.Text.Length == 0)
            {
                controls.txt_add_speechAct.Text = Constants.MESSAGE_ENTER_SPEECH_ACT;
                controls.txt_add_speechAct.ForeColor = SystemColors.GrayText;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(controls.txt_add_speechAct.Text) || String.IsNullOrWhiteSpace(controls.txt_add_speechAct.Text)
                 || controls.txt_add_speechAct.Text.Equals(Constants.MESSAGE_ENTER_SPEECH_ACT))
                controls.errorProvider_add_speechAct.SetError(controls.txt_add_speechAct, Constants.MESSAGE_ENTER_SPEECH_ACT);
            else
            {
                string id = "0";
                if (controls.lb_speechAct != null && controls.lb_speechAct.Items != null && controls.lb_speechAct.Items.Count > 0)
                    id = ((Constants.SpeechActs)controls.lb_speechAct.Items[(controls.lb_speechAct.Items.Count - 1)]).Id;
                controls.lb_speechAct.Items.Add(new Constants.SpeechActs((Convert.ToInt32(id) + 1).ToString(), controls.txt_add_speechAct.Text));
                controls.txt_add_speechAct.Text = Constants.MESSAGE_ENTER_SPEECH_ACT;
                controls.txt_add_speechAct.ForeColor = SystemColors.GrayText;

                if (controls.btn_saveas_speechAct.Visible == false)
                    controls.btn_saveas_speechAct.Visible = true;
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            for (int i = controls.lb_speechAct.SelectedIndices.Count - 1; i >= 0; --i)
            {
                controls.lb_speechAct.Items.RemoveAt(controls.lb_speechAct.SelectedIndices[i]);
            }

            if (controls.lb_speechAct.Items.Count < 1)
                controls.btn_saveas_speechAct.Visible = false;

        }


        private void listBox_SpeechActs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F2)
                CreateEditBox(sender);
        }

        private void listBox_SpeechActs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                CreateEditBox(sender);
        }

        private void listBox_SpeechActs_DoubleClick(object sender, EventArgs e)
        {
            CreateEditBox(sender);
        }

        private void FocusOver(object sender, System.EventArgs e)
        {
            if (String.IsNullOrEmpty(editBox.Text) || String.IsNullOrWhiteSpace(editBox.Text)
               || editBox.Text.Equals(Constants.MESSAGE_ENTER_SPEECH_ACT))
                controls.errorProvider_list_speechAct.SetError(editBox, Constants.MESSAGE_ENTER_SPEECH_ACT);
            else
            {

                controls.lb_speechAct.Items[itemSelected] = new Constants.SpeechActs(itemId, editBox.Text);
            }
            editBox.Hide();
        }

        private void EditOver(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {

            if (e.KeyChar == 13)
            {
                if (String.IsNullOrEmpty(editBox.Text) || String.IsNullOrWhiteSpace(editBox.Text)
                 || editBox.Text.Equals(Constants.MESSAGE_ENTER_SPEECH_ACT))
                    controls.errorProvider_list_speechAct.SetError(editBox, Constants.MESSAGE_ENTER_SPEECH_ACT);
                else
                {
                    controls.lb_speechAct.Items[itemSelected] = new Constants.SpeechActs(itemId, editBox.Text);

                }
                editBox.Hide();
            }
        }



        private void btnUp_Click(object sender, EventArgs e)
        {
            UtilityFunctions.MoveUp(controls.lb_speechAct);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            UtilityFunctions.MoveDown(controls.lb_speechAct);
        }



        private void btn_save_Click(object sender, EventArgs e)
        {

            bool validationError = false;
            if (String.IsNullOrEmpty(controls.txt_outputFile_speechAct.Text) || String.IsNullOrWhiteSpace(controls.txt_outputFile_speechAct.Text))
            {
                controls.errorProvider_output_file_speechAct.SetError(controls.txt_outputFile_speechAct, Constants.MESSAGE_SELECT_OUTPUT_FILE);
                validationError = true;
            }
            else
            {
                controls.errorProvider_output_file_speechAct.Clear();
                controls.errorProvider_output_file_speechAct.SetError(controls.txt_outputFile_speechAct, "");
            }

            if (controls.lb_speechAct == null || controls.lb_speechAct.Items == null || controls.lb_speechAct.Items.Count < 1)
            {
                controls.errorProvider_list_speechAct.SetError(controls.lb_speechAct, Constants.MESSAGE_ENTER_SPEECH_ACT);
                validationError = true;
            }
            else
            {
                controls.errorProvider_list_speechAct.Clear();
                controls.errorProvider_list_speechAct.SetError(controls.lb_speechAct, "");
            }
            if (validationError)
                return;


            List<string> allLines = new List<string>();
            foreach (Constants.SpeechActs speechActs in controls.lb_speechAct.Items)
            {
                allLines.Add(speechActs.Id + ";" + speechActs.Name);
            }
            File.WriteAllLines(controls.txt_outputFile_speechAct.Text, allLines.ToArray());

            controls.lb_audioFiles_annotation.DataSource = null;
            controls.lb_audioFiles_annotation.Items.Clear();
            controls.lb_speechAct_annotation.DataSource = null;
            controls.lb_speechAct_annotation.Items.Clear();
            controls.txt_outputFile_annotation.Text = "";
            controls.txt_duration_wmlayer_annotation.Text = "";
            controls.txt_outputFileContent_annotation.Text = "";

            //controls.lb_speechAct.Items.Clear();
            MessageBox.Show("Succesfully done!!");


        }

        private void btn_browseAndLoad_Click(object sender, EventArgs e)
        {

            string fileName = "";

            controls.lb_speechAct.Items.Clear();

            controls.ofd_outputFileOutput_speechAct.InitialDirectory = "c:\\";
            controls.ofd_outputFileOutput_speechAct.Filter = "txt files (*.txt)|*.txt";
            controls.ofd_outputFileOutput_speechAct.FilterIndex = 2;
            controls.ofd_outputFileOutput_speechAct.RestoreDirectory = true;
            controls.ofd_outputFileOutput_speechAct.FileName = "SpeechActs.txt";
            controls.ofd_outputFileOutput_speechAct.CheckFileExists = false;


            DialogResult result = controls.ofd_outputFileOutput_speechAct.ShowDialog();
            if (result == DialogResult.OK)
            {
                fileName = controls.ofd_outputFileOutput_speechAct.FileName;


                if (String.IsNullOrEmpty(fileName) || String.IsNullOrWhiteSpace(fileName))
                {
                    MessageBox.Show("You have to select SpeechAct File (txt file , each line consist of unique id and spech-act text delimited with ';'!!");
                    return;
                }

                if (File.Exists(fileName))
                {
                    string[] speechActs = File.ReadAllLines(fileName);
                    foreach (string line in speechActs)
                    {
                        if (!String.IsNullOrEmpty(line) && !String.IsNullOrWhiteSpace(line)
                            && line.Split(';').Length > 1)
                        {
                            string id = line.Split(';')[0];
                            string text = line.Split(';')[1];
                            controls.lb_speechAct.Items.Add(new Constants.SpeechActs(id, text));
                        }
                    }
                }

                controls.txt_outputFile_speechAct.Text = fileName;
                controls.btn_save_speechAct.Visible = true;


            }

        }

        private void btn_createorLoad_output_annotation_Click(object sender, EventArgs e)
        {

            string fileName = "";

            controls.txt_outputFileContent_annotation.Text = "";

            controls.ofd_outputFileOutput_annotation.InitialDirectory = "c:\\";
            controls.ofd_outputFileOutput_annotation.Filter = "txt files (*.txt)|*.txt";
            controls.ofd_outputFileOutput_annotation.FilterIndex = 2;
            controls.ofd_outputFileOutput_annotation.RestoreDirectory = true;
            controls.ofd_outputFileOutput_annotation.FileName = "SpeechAnnotation.txt";
            controls.ofd_outputFileOutput_annotation.CheckFileExists = false;


            DialogResult result = controls.ofd_outputFileOutput_annotation.ShowDialog();
            if (result == DialogResult.OK)
            {
                fileName = controls.ofd_outputFileOutput_annotation.FileName;


                if (String.IsNullOrEmpty(fileName) || String.IsNullOrWhiteSpace(fileName))
                {
                    MessageBox.Show("You have to select SpeechAct File (txt file , each line consist of unique id and spech-act text delimited with ';'!!");
                    return;
                }

                if (File.Exists(fileName))
                {
                    controls.txt_outputFileContent_annotation.Text = File.ReadAllText(fileName);
                }

                controls.txt_outputFile_annotation.Text = fileName;

            }

        }

        private void Player_MediaError(object pMediaObject)
        {
            MessageBox.Show("Cannot play media file.");
        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            //media player control's playstate change event handler
            if (controls.axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {

                controls.timer1.Start();
            }
            else if (controls.axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                controls.timer1.Stop();
            }
            else if (controls.axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsStopped)
            {

                string str = TimeSpan.FromMilliseconds(duration * 1000).ToString();
                controls.txt_duration_wmlayer_annotation.Text = str.Remove(str.Length - 4);
                controls.timer1.Stop();

            }

            if (loadingPlayer && e.newState == 3)
            {
                duration = controls.axWindowsMediaPlayer1.currentMedia.duration;
                loadingPlayer = false;

            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //timer 1 tick event handler
            //if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            //{
            //if (axWindowsMediaPlayer1.playState != WMPLib.WMPPlayState.wmppsStopped)
            string str = TimeSpan.FromMilliseconds(controls.axWindowsMediaPlayer1.Ctlcontrols.currentPosition * 1000).ToString();
            controls.txt_duration_wmlayer_annotation.Text = str.Remove(str.Length - 4);

            //}
        }

        public void btn_gotoWalkthrough_speechAct_Click(object sender, EventArgs e)
        {
            controls.navigationListener.navigateToDefineSpeechActWalkthrough();
        }

        public void btn_gotoWalkthrough_annotation_Click(object sender, EventArgs e)
        {
            controls.navigationListener.navigateToAnnotationWalkthrough();
        }

        //private void btn_saveAs_Click(object sender, EventArgs e)
        //{

        //    SaveFileDialog saveFileDialog1 = new SaveFileDialog();
        //    saveFileDialog1.Filter = "(*.txt)|*.txt";
        //    saveFileDialog1.Title = "Save Speech-Acts File";
        //    saveFileDialog1.ShowDialog();

        //    // If the file name is not an empty string open it for saving.
        //    if (saveFileDialog1.FileName != "")
        //    {
        //        controls.txt_outputFile_speechAct.Text = saveFileDialog1.FileName;
        //        List<string> allLines = new List<string>();
        //        foreach (Constants.SpeechActs speechActs in controls.lb_speechAct.Items)
        //        {
        //            allLines.Add(speechActs.Id + ";" + speechActs.Name);
        //        }
        //        File.WriteAllLines(saveFileDialog1.FileName, allLines.ToArray());
        //    }

        //}
    }
}

