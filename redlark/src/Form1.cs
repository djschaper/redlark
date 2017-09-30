using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;

namespace redlark
{
    public partial class Form1 : Form
    {
        const string CHORUS = "Chorus";
        const string VERSE = "Verse";
        const string BRIDGE = "Bridge";
        const string PRE_CHORUS = "Pre-Chorus";
        const string INTERLUDE = "Interlude";
        const string ENDING = "Ending";
        const string TAG = "Tag";
        const string MISC = "Misc";
        const string TOU = "For use solely with the SongSelect";
        static string[] SONG_ELEMENTS = { CHORUS, VERSE, BRIDGE, PRE_CHORUS, INTERLUDE, ENDING, TAG, MISC };

        XElement Song;
        string TxtFilepath;

        public Form1()
        {
            InitializeComponent();
            this.DragEnter += new System.Windows.Forms.DragEventHandler(Form1_DragEnter);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(Form1_DragDrop);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Song = new XElement("song");
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) {
                e.Effect = DragDropEffects.Copy;
            }
            else {
                e.Effect = DragDropEffects.None;
            }
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            FileInfo fi = new FileInfo(files[0]);
            if (fi.Exists && fi.Extension == ".txt") {
                TxtFilepath = files[0];
                ReadTextFile(TxtFilepath);
            }   
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK) {
                TxtFilepath = openFileDialog1.FileName;
                if (File.Exists(TxtFilepath)) {
                    ReadTextFile(TxtFilepath);
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // suggest file name
            string xmlFilepath = Path.ChangeExtension(TxtFilepath, "");
            saveFileDialog1.FileName = Path.GetFileName(xmlFilepath);
            
            saveFileDialog1.InitialDirectory = Path.GetDirectoryName(TxtFilepath);

            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK) {
                SaveToOpenSong(saveFileDialog1.FileName);
            }
        }

        private void ReadTextFile(string filepath)
        {
            XElement title, author, copyright, ccli, lyrics;
            XElement capo = new XElement("capo");
            capo.SetAttributeValue("print", "false");
            List<string> lyricLines = new List<string>();
            string[] lines;
            bool finishedSong;
            string sectionHeading;

            Song = new XElement("song");
            title = new XElement("title");
            author = new XElement("author");
            copyright = new XElement("copyright");
            ccli = new XElement("ccli");
            lyrics = new XElement("lyrics");

            finishedSong = false;
            lines = File.ReadAllLines(filepath);

            for (int i = 0; i < lines.Length; i++) {
                if (!finishedSong && lines[i].Length > 0) {
                    if (i == 0) {
                        //title
                        title.Add(lines[i]);
                    }
                    else if (lines[i - 1].Length == 0 && lines[i].Length > 0) {
                        if (SONG_ELEMENTS.Contains(lines[i].Split(' ').ElementAt(0))) {
                            //start of song element
                            sectionHeading = lines[i];

                            if (lines[i].StartsWith(MISC)) {
                                i++;
                                sectionHeading = lines[i].Substring(1, lines[i].Length - 2);
                            }
                            sectionHeading = sectionHeading.Replace(PRE_CHORUS, "P");
                            sectionHeading = sectionHeading.Replace(CHORUS, "C");
                            sectionHeading = sectionHeading.Replace(VERSE, "V");
                            sectionHeading = sectionHeading.Replace(BRIDGE, "B");
                            sectionHeading = sectionHeading.Replace(TAG, "T");
                            sectionHeading = sectionHeading.Replace(" ", "");

                            if (lyricLines.Count > 0) {
                                lyricLines.Add("");
                            }
                            lyricLines.Add(string.Format("[{0}]", sectionHeading));
                        }
                        else {
                            //start of copyright paragraph
                            bool isCCLI = lines[i].StartsWith("CCLI");
                            if (isCCLI) {
                                ccli.Add(lines[i++].Split('#').ElementAt(1).Trim());
                            }
                            author.Add(lines[i++]);
                            if (isCCLI) {
                                List<string> copy = new List<string>();
                                while (!lines[i].StartsWith(TOU)) {
                                    copy.Add(lines[i++]);
                                }
                                copyright.Add(string.Join(", ", copy));
                            }
                            finishedSong = true;
                        }
                    }
                    else {
                        //regular line
                        lyricLines.Add(".");
                        lyricLines.Add(" " + lines[i]);
                    }
                }
            }
            lyrics.Add(string.Join(Environment.NewLine, lyricLines));

            Song.Add(title);
            Song.Add(author);
            Song.Add(copyright);
            Song.Add(new XElement("presentation"));
            Song.Add(new XElement("hymn_number"));
            Song.Add(capo);
            Song.Add(new XElement("tempo"));
            Song.Add(new XElement("time_sig"));
            Song.Add(ccli);
            Song.Add(new XElement("theme"));
            Song.Add(new XElement("alttheme"));
            Song.Add(new XElement("user1"));
            Song.Add(new XElement("user2"));
            Song.Add(new XElement("user3"));
            Song.Add(new XElement("key"));
            Song.Add(new XElement("hymn_number"));
            Song.Add(new XElement("aka"));
            Song.Add(new XElement("key_line"));
            Song.Add(new XElement("link_youtube"));
            Song.Add(lyrics);

            // update form fields
            txtTitle.Text = title.Value;
            txtAltTitle.Text = "";
            txtAuthor.Text = author.Value;
            txtCopy.Text = copyright.Value;
            txtCCLI.Text = ccli.Value;
            txtTimeSig.Text = "";
            txtTempo.Text = "";
            txtKey.Text = "";
            txtEditor.Text = lyrics.Value;
            txtYouTube.Text = "";
        }

        private void SaveToOpenSong(string filepath)
        {
            using (TextWriter writer = File.CreateText(filepath)) {
                writer.WriteLine("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
                writer.Write(Song.ToString());
                writer.Close();
            }
        }

        private void textBoxTitle_TextChanged(object sender, EventArgs e)
        {
            Song.SetElementValue("title", txtTitle.Text);
        }

        private void textBoxAltTitle_TextChanged(object sender, EventArgs e)
        {
            Song.SetElementValue("aka", txtAltTitle.Text);
        }

        private void textBoxAuthor_TextChanged(object sender, EventArgs e)
        {
            Song.SetElementValue("author", txtAuthor.Text);
        }

        private void textBoxCopy_TextChanged(object sender, EventArgs e)
        {
            Song.SetElementValue("copyright", txtCopy.Text);
        }

        private void textBoxCCLI_TextChanged(object sender, EventArgs e)
        {
            Song.SetElementValue("ccli", txtCCLI.Text);
        }

        private void textBoxTimeSig_TextChanged(object sender, EventArgs e)
        {
            Song.SetElementValue("time_sig", txtTimeSig.Text);
        }

        private void textBoxTempo_TextChanged(object sender, EventArgs e)
        {
            Song.SetElementValue("tempo", txtTempo.Text);
        }

        private void textBoxKey_TextChanged(object sender, EventArgs e)
        {
            Song.SetElementValue("key", txtKey.Text);
        }

        private void textBoxEditor_TextChanged(object sender, EventArgs e)
        {
            Song.SetElementValue("lyrics", txtEditor.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Song.SetElementValue("link_youtube", txtYouTube.Text);
        }
    }
}
