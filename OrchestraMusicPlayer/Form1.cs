using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;


namespace OrchestraMusicPlayer
{
    public partial class Form1 : Form
    {
        MySqlConnection ConnectDB = new MySqlConnection("server=localhost; uid=root; password=''; database=orchestra");
        MySqlCommand Command = new MySqlCommand();
        MySqlDataReader reader;

        string currentPrevMusic = string.Empty;
        string currentNextMusic = string.Empty;
        string currentMusicTitle = string.Empty;
        string currentMusicPath = string.Empty;
        string currentMusicLength = string.Empty;
        string selectedMusic = string.Empty;
        string readableTitle = string.Empty;
        string nextMusic = string.Empty;
        string prevMusic = string.Empty;
        string tablePage = "Music"; // WILL BE USE FOR TOP BUTTON HOVER
        bool newSongSelected = false;
        bool pause = false;
        int currentMusicValue = 0;
        int currentVolumeValue = 0;
        int musicDuration = 0;

        // UNICODE OR ANY REPRESENTATIVE OF A CERTAIN CHARACTER
        string[] charCode = new string[] { //============================================>>> UNICODE
            // 10 ROWS
            //===========================================================================>>> OTHER SYMBOLS
            "U+3000", "U+0027", "/", "U+FF0F", "U+23BE", "U+23CC", "U+2661", "U+300E", "U+300F", "U+FF01",
            
            //===========================================================================>>> KOREAN CHARACTERS
            "U+C740", "U+D63C", "U+C0AC", "U+BB34", "U+B77C", "U+C774", "U+D558", "U+D2B8",

            //===========================================================================>>> JAPANESE CHARACTERS
            "U+7F8E", "U+6CE2", "U+30A2", "U+30AB", "U+30AF", "U+30AD", "U+30E1", "U+30EF", "U+FF66", "U+3092", 
            "U+6B4C", "U+3063", "U+3066", "U+307F", "U+307E", "U+3057", "U+305F", "U+30EB", "U+5B63", "U+306A", 
            "U+3093", "U+3067", "U+3082", "U+3044", "U+3084", "U+541B", "U+306E", "U+540D", "U+306F", "U+3002", 
            "U+30AA", "U+30FC", "U+30D0", "U+30ED", "U+30C9", "U+51DB", "U+3068", "U+3066", "U+6642", "U+96E8", 
            "U+50D5", "U+30D2", "U+30DF", "U+30C7", "U+5167", "U+7530", "U+771F", "U+79AE", "U+5915", "U+66AE",
            "U+308C", "U+9CE5", "U+795E", "U+8056", "U+304B", "U+3061", "U+3083", "U+9280", "U+9B42", "U+30B5",
            "U+30E0", "U+30E9", "U+30A4", "U+30CF", "U+30C8", "U+30E5", "U+96FB", "U+5F71", "U+65B0", "U+4E16", 
            "U+4E2D", "U+65E5", "U+8A5E", "U+75AC", "U+30A8", "U+30B9", "U+30BF", "U+9AED", "U+7537", "U+30D1",
            "U+4E88", "U+544A", "U+7DE8", "U+4EBA", "U+9593", "U+958B", "U+81B1", "U+521D", "U+56DE", "U+76E4",
            "U+524D", "U+30D7", "U+30CB", "U+30F3", "U+30B0", "U+56DB", "U+6708", "U+5618", "U+58F0", "U+7248",
            "U+30B8", "U+30C3", "U+30D3", "U+5F31", "U+866B", "U+30DA", "U+30C6", "U+30DE", "U+30C0", "U+6E15",
            "U+4E0A", "U+821E" /* >>> NEW: */
        };

        string[] charSym = new string[] { //=============================================>>> SYMBOLS
            // 10 ROWS
            //===========================================================================>>> OTHER SYMBOLS
            "　",   "'",   "\\",   "／",   "「",   "」",   "♡",   "『", "』", "！",

            //===========================================================================>>> KOREAN CHARACTERS
            "은",   "혼",   "사",   "무",   "라",   "이",   "하",   "트",

            //===========================================================================>>> JAPANESE CHARACTERS
            "美",   "波",   "ア",   "カ",   "ク",   "キ",   "メ",   "ワ",   "ヲ",  "を",   
            "歌",   "っ",   "て",   "み",   "ま",   "し",   "た",   "ル",   "季",   "な",   
            "ん",   "で",   "も",   "い",   "や",   "君",   "の",   "名",   "は",   "。",   
            "オ",   "ー",   "バ",   "ロ",   "ド",   "凛",   "と",   "て",   "時",   "雨", 
            "僕",   "ヒ",   "ミ",   "デ",   "内",   "田",   "真",   "禮",   "夕",   "暮",
            "れ",   "鳥",   "神",   "聖",   "か",   "ち",   "ゃ",   "銀",   "魂",   "サ",
            "ム",   "ラ",   "イ",   "ハ",   "ト",   "ュ",   "電",   "影",   "新",   "世", 
            "中",   "日",   "詞",   "界",   "エ",   "ス",   "タ",   "髭",   "男",   "パ",
            "予",   "告",   "編",   "人",   "間",   "開",   "花",   "初",   "回",   "盤",
            "前",   "プ",   "ニ",   "ン",   "グ",   "四",   "月",   "嘘",   "声",   "版",
            "ジ",   "ッ",   "ビ",   "弱",   "虫",   "ペ",   "テ",   "マ",   "ダ",   "渕",
            "上",   "舞" /* >>> NEW: */
        };

        public Form1()
        {
            InitializeComponent();
            Command.Connection = ConnectDB;

            // CURRENT USED DATA GRID VIEW DOES NOT HAVE MOUSE WHEEL EVENT THAT WHY WE INITIALIZE IT
            dataGridView1.MouseWheel += new MouseEventHandler(dataGridView1_MouseWheel);
            //trkMusic1.MouseWheel += new MouseEventHandler(trkMusic1_MouseWheel); PART OF THE BUG THAT IS UNABLE TO FIXED
        }

        //====================================================================================================================//
        //================================================>>> METHODS <<<=====================================================//
        //====================================================================================================================//

        public void getPrevAndNextMusic(string musicToPlay) //===========================>>> GET THE NEXT AND PREV MUSIC
        {
            currentPrevMusic = string.Empty;
            currentNextMusic = string.Empty;

            btnPrev.Enabled = true;
            btnNext.Enabled = true;
            btnPrev.BackgroundImage = Properties.Resources.PrevButtonDefault;
            btnNext.BackgroundImage = Properties.Resources.NextButtonDefault;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (Convert.ToString(dataGridView1.Rows[i].Cells[0].Value) == musicToPlay)
                {
                    dataGridView1.Rows[i].Selected = false; // TO REMOVE HIGHLIGHT
                    if (i == 0)
                    {
                        //DISABLE PREV BUTTON...
                        btnPrev.Enabled = false;
                        btnPrev.BackgroundImage = Properties.Resources.PrevButtonDisable;
                        currentNextMusic = Convert.ToString(dataGridView1.Rows[i + 1].Cells[0].Value);
                    }

                    else if (i > 0 && i < dataGridView1.Rows.Count)
                    {
                        btnPrev.Enabled = true;
                        btnNext.Enabled = true;
                        btnPrev.BackgroundImage = Properties.Resources.PrevButtonDefault;
                        btnNext.BackgroundImage = Properties.Resources.NextButtonDefault;
                        currentPrevMusic = Convert.ToString(dataGridView1.Rows[i - 1].Cells[0].Value);
                        currentNextMusic = Convert.ToString(dataGridView1.Rows[i + 1].Cells[0].Value);
                    }

                    else if (i == dataGridView1.Rows.Count - 1)
                    {
                        //DISABLE NEXT BUTTON...
                        btnNext.Enabled = false;
                        btnNext.BackgroundImage = Properties.Resources.NextButtonDisable;
                        currentPrevMusic = Convert.ToString(dataGridView1.Rows[i - 1].Cells[0].Value);
                    }
                    break;
                }
            }
            //MessageBox.Show("Prev: " + currentPrevMusic + "\nNext: " + currentNextMusic);
        }

        public void getSelectedMusic() //================================================>>> GET SELECTED ROW
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                selectedMusic = Convert.ToString(row.Cells[0].Value); // GET THE SELECTED MUSIC
            }
        }

        public void LoadTable(string localQuery) //======================================>>> LOADING THE DATA TO TABLE
        {
            string music = string.Empty;
            int counter = 0;

            try
            {
                ConnectDB.Open();
                Command.CommandText = localQuery;
                reader = Command.ExecuteReader();

                while (reader.Read())
                {
                    dataGridView1.Rows.Add(
                        Convert.ToString(reader["musicTitle"])
                            .Replace("U+3000", "　") // DO NOT REMOVE THIS IS NOT NORMAL SPACE
                            // NORMAL SPACE HAS UNICODE VALUE OF U+0020

                            //===========================================================>>> OTHER SYMBOLS    
                            .Replace("U+0027", "'").Replace("/", "\\").Replace("U+FF0F", "／")
                            .Replace("U+23BE", "「").Replace("U+23CC", "」").Replace("U+300E", "『")
                            .Replace("U+300F", "』").Replace("U+2661", "♡").Replace("U+FF01", "！")

                            //===========================================================>>> KOREAN CHARACTERS
                            .Replace("U+C740", "은").Replace("U+D63C", "혼").Replace("U+C0AC", "사")
                            .Replace("U+BB34", "무").Replace("U+B77C", "라").Replace("U+C774", "이")
                            .Replace("U+D558", "하").Replace("U+D2B8", "트")

                            //===========================================================>>> JAPANESE CHARACTERS
                            .Replace("U+7F8E", "美").Replace("U+6CE2", "波").Replace("U+30A2", "ア")
                            .Replace("U+30AB", "カ").Replace("U+30AF", "ク").Replace("U+30AD", "キ")
                            .Replace("U+30E1", "メ").Replace("U+30EF", "ワ").Replace("U+FF66", "ヲ")
                            .Replace("U+3092", "を").Replace("U+6B4C", "歌").Replace("U+3063", "っ")
                            .Replace("U+3066", "て").Replace("U+307F", "み").Replace("U+307E", "ま")
                            .Replace("U+3057", "し").Replace("U+305F", "た").Replace("U+30EB", "ル")
                            .Replace("U+5B63", "季").Replace("U+306A", "な").Replace("U+3093", "ん")
                            .Replace("U+3067", "で").Replace("U+3082", "も").Replace("U+3044", "い")
                            .Replace("U+3084", "や").Replace("U+541B", "君").Replace("U+306E", "の")
                            .Replace("U+540D", "名").Replace("U+306F", "は").Replace("U+3002", "。")
                            .Replace("U+30AA", "オ").Replace("U+30FC", "ー").Replace("U+30D0", "バ")
                            .Replace("U+30ED", "ロ").Replace("U+30C9", "ド").Replace("U+51DB", "凛")
                            .Replace("U+3068", "と").Replace("U+3066", "て").Replace("U+6642", "時")
                            .Replace("U+96E8", "雨").Replace("U+50D5", "僕").Replace("U+30D2", "ヒ")
                            .Replace("U+30DF", "ミ").Replace("U+30C7", "デ").Replace("U+5167", "内")
                            .Replace("U+7530", "田").Replace("U+771F", "真").Replace("U+79AE", "禮")
                            .Replace("U+5915", "夕").Replace("U+66AE", "暮").Replace("U+308C", "れ")
                            .Replace("U+9CE5", "鳥").Replace("U+795E", "神").Replace("U+8056", "聖")
                            .Replace("U+304B", "か").Replace("U+3061", "ち").Replace("U+3083", "ゃ")
                            .Replace("U+9280", "銀").Replace("U+9B42", "魂").Replace("U+30B5", "サ")
                            .Replace("U+30E0", "ム").Replace("U+30E9", "ラ").Replace("U+30A4", "イ")
                            .Replace("U+30CF", "ハ").Replace("U+30C8", "ト").Replace("U+30E5", "ュ")
                            .Replace("U+96FB", "電").Replace("U+5F71", "影").Replace("U+65B0", "新")
                            .Replace("U+4E16", "世").Replace("U+4E2D", "中").Replace("U+65E5", "日")
                            .Replace("U+8A5E", "詞").Replace("U+75AC", "界").Replace("U+30A8", "エ")
                            .Replace("U+30B9", "ス").Replace("U+30BF", "タ").Replace("U+9AED", "髭")
                            .Replace("U+7537", "男").Replace("U+30D1", "パ").Replace("U+4E88", "予")
                            .Replace("U+544A", "告").Replace("U+7DE8", "編").Replace("U+4EBA", "人")
                            .Replace("U+9593", "間").Replace("U+958B", "開").Replace("U+81B1", "花")
                            .Replace("U+521D", "初").Replace("U+56DE", "回").Replace("U+76E4", "盤")
                            .Replace("U+524D", "前").Replace("U+30D7", "プ").Replace("U+30CB", "ニ")
                            .Replace("U+30F3", "ン").Replace("U+30B0", "グ").Replace("U+56DB", "四")
                            .Replace("U+6708", "月").Replace("U+5618", "嘘").Replace("U+58F0", "声")
                            .Replace("U+7248", "版").Replace("U+30B8", "ジ").Replace("U+30C3", "ッ")
                            .Replace("U+30D3", "ビ").Replace("U+5F31", "弱").Replace("U+866B", "虫")
                            .Replace("U+30DA", "ペ").Replace("U+30C6", "テ").Replace("U+30DE", "マ")
                            .Replace("U+30C0", "ダ").Replace("U+6E15", "渕").Replace("U+4E0A", "上")
                            .Replace("U+821E", "舞"),
                        Convert.ToString(reader["musicLength"])
                    );
                    counter++;
                }
                reader.Close();
                ConnectDB.Close();

                if (counter > 0)
                {
                    dataGridView1.Rows[0].Selected = false;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Orchestra Music Player",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        public void LoadMusic(string musicToPlay) //=====================================>>> LOAD THE MUSIC
        {
            string musicTitle = string.Empty;
            string musicPath = string.Empty;
            var music = string.Empty;
            newSongSelected = true;

            lblTitle.Text = musicToPlay;

            // REMOVING ALL SPECIAL CHARACTERS (TO ACCESS THE MUSIC FILE PATH FROM DATABASE)
            char[] titleArr = musicToPlay.ToCharArray(); // PER CHARACTERS
            for (int k = 0; k < titleArr.Length; k++)
            {
                for (int j = 0; j < charCode.Length; j++)
                {
                    // REPLACE CHAR IF SPECIAL CHAR EXIST
                    if (charSym[j] == Convert.ToString(titleArr[k]) && j < charCode.Length)
                    {
                        // REMOVING SYMBOLS TURN INTO CODE
                        musicTitle += Convert.ToString(titleArr[k]).Replace(charSym[j], charCode[j]);
                        break; // IF A MATCH IS FOUND STOP THE LOOP THEN PROCEED TO NEXT PAIR OF CHAR
                    }

                    else if (charSym[j] != Convert.ToString(titleArr[k]) && j < charCode.Length)
                    {
                        if (j == charCode.Length - 1) // LAST SPECIAL CHAR IS REACHED
                        {
                            // WRITE THE CHAR
                            musicTitle += Convert.ToString(titleArr[k]);
                        }
                    }
                }
            }

            try
            {
                ConnectDB.Open();
                Command.CommandText = "SELECT * FROM music WHERE musicTitle = '" + musicTitle + "'";
                reader = Command.ExecuteReader();

                while (reader.Read())
                {
                    currentMusicTitle = Convert.ToString(reader["musicTitle"]);
                    currentMusicPath = Convert.ToString(reader["musicDirectory"]);
                    currentMusicLength = Convert.ToString(reader["musicLength"]);
                }

                reader.Close();
                ConnectDB.Close();

                musicDuration = 0;
                trkMusic1.Value = 0;
                musicDuration += Convert.ToInt32(currentMusicLength.Substring(0, 2)) * 60; // MINUTES CONVERT TO SECONDS
                musicDuration += Convert.ToInt32(currentMusicLength.Substring(3, 2));
                trkMusic1.Maximum = musicDuration;

                timer1.Stop(); // RESTART TIMER
                timer1 = new Timer();
                timer1.Interval = 1000; // 1 SECOND
                timer1.Start();
                timer1.Tick += new EventHandler(timer1_Tick);

                lblMusicStart.Text = "00:00";
                lblMusicLength.Text = currentMusicLength;

                axVLCPlugin21.playlist.stop();
                axVLCPlugin21.playlist.items.clear();

                // THE CONVERSION BELOW OF UNICODE TO ACTUAL CHARACTERS IS USED TO ACCESS THE MUSIC FILE FROM ITS FILE DIRECTORY
                music = new Uri(
                    @"" + currentMusicPath
                        .Replace("U+3000", "　") // DO NOT REMOVE THIS IS NOT NORMAL SPACE
                        // NORMAL SPACE HAS UNICODE VALUE OF U+0020

                        //===========================================================>>> OTHER SYMBOLS    
                        .Replace("U+0027", "'").Replace("/", "\\").Replace("U+FF0F", "／")
                        .Replace("U+23BE", "「").Replace("U+23CC", "」").Replace("U+300E", "『")
                        .Replace("U+300F", "』").Replace("U+2661", "♡").Replace("U+FF01", "！")

                        //===========================================================>>> KOREAN CHARACTERS
                        .Replace("U+C740", "은").Replace("U+D63C", "혼").Replace("U+C0AC", "사")
                        .Replace("U+BB34", "무").Replace("U+B77C", "라").Replace("U+C774", "이")
                        .Replace("U+D558", "하").Replace("U+D2B8", "트")

                        //===========================================================>>> JAPANESE CHARACTERS
                        .Replace("U+7F8E", "美").Replace("U+6CE2", "波").Replace("U+30A2", "ア")
                        .Replace("U+30AB", "カ").Replace("U+30AF", "ク").Replace("U+30AD", "キ")
                        .Replace("U+30E1", "メ").Replace("U+30EF", "ワ").Replace("U+FF66", "ヲ")
                        .Replace("U+3092", "を").Replace("U+6B4C", "歌").Replace("U+3063", "っ")
                        .Replace("U+3066", "て").Replace("U+307F", "み").Replace("U+307E", "ま")
                        .Replace("U+3057", "し").Replace("U+305F", "た").Replace("U+30EB", "ル")
                        .Replace("U+5B63", "季").Replace("U+306A", "な").Replace("U+3093", "ん")
                        .Replace("U+3067", "で").Replace("U+3082", "も").Replace("U+3044", "い")
                        .Replace("U+3084", "や").Replace("U+541B", "君").Replace("U+306E", "の")
                        .Replace("U+540D", "名").Replace("U+306F", "は").Replace("U+3002", "。")
                        .Replace("U+30AA", "オ").Replace("U+30FC", "ー").Replace("U+30D0", "バ")
                        .Replace("U+30ED", "ロ").Replace("U+30C9", "ド").Replace("U+51DB", "凛")
                        .Replace("U+3068", "と").Replace("U+3066", "て").Replace("U+6642", "時")
                        .Replace("U+96E8", "雨").Replace("U+50D5", "僕").Replace("U+30D2", "ヒ")
                        .Replace("U+30DF", "ミ").Replace("U+30C7", "デ").Replace("U+5167", "内")
                        .Replace("U+7530", "田").Replace("U+771F", "真").Replace("U+79AE", "禮")
                        .Replace("U+5915", "夕").Replace("U+66AE", "暮").Replace("U+308C", "れ")
                        .Replace("U+9CE5", "鳥").Replace("U+795E", "神").Replace("U+8056", "聖")
                        .Replace("U+304B", "か").Replace("U+3061", "ち").Replace("U+3083", "ゃ")
                        .Replace("U+9280", "銀").Replace("U+9B42", "魂").Replace("U+30B5", "サ")
                        .Replace("U+30E0", "ム").Replace("U+30E9", "ラ").Replace("U+30A4", "イ")
                        .Replace("U+30CF", "ハ").Replace("U+30C8", "ト").Replace("U+30E5", "ュ")
                        .Replace("U+96FB", "電").Replace("U+5F71", "影").Replace("U+65B0", "新")
                        .Replace("U+4E16", "世").Replace("U+4E2D", "中").Replace("U+65E5", "日")
                        .Replace("U+8A5E", "詞").Replace("U+75AC", "界").Replace("U+30A8", "エ")
                        .Replace("U+30B9", "ス").Replace("U+30BF", "タ").Replace("U+9AED", "髭")
                        .Replace("U+7537", "男").Replace("U+30D1", "パ").Replace("U+4E88", "予")
                        .Replace("U+544A", "告").Replace("U+7DE8", "編").Replace("U+4EBA", "人")
                        .Replace("U+9593", "間").Replace("U+958B", "開").Replace("U+81B1", "花")
                        .Replace("U+521D", "初").Replace("U+56DE", "回").Replace("U+76E4", "盤")
                        .Replace("U+524D", "前").Replace("U+30D7", "プ").Replace("U+30CB", "ニ")
                        .Replace("U+30F3", "ン").Replace("U+30B0", "グ").Replace("U+56DB", "四")
                        .Replace("U+6708", "月").Replace("U+5618", "嘘").Replace("U+58F0", "声")
                        .Replace("U+7248", "版").Replace("U+30B8", "ジ").Replace("U+30C3", "ッ")
                        .Replace("U+30D3", "ビ").Replace("U+5F31", "弱").Replace("U+866B", "虫")
                        .Replace("U+30DA", "ペ").Replace("U+30C6", "テ").Replace("U+30DE", "マ")
                        .Replace("U+30C0", "ダ").Replace("U+6E15", "渕").Replace("U+4E0A", "上")
                        .Replace("U+821E", "舞")
                ).AbsoluteUri;
                axVLCPlugin21.playlist.add(music);
                axVLCPlugin21.playlist.play();

                pause = true;
                btnPlay.BackgroundImage = Properties.Resources.PauseButtonDefault;
            }

            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Orchestra Music Player",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        public void DisplayMusicTime() //================================================>>> TIME START AND REMAINING
        {
            lblMusicStart.Text = Convert.ToString(
                TimeSpan.FromMilliseconds(axVLCPlugin21.input.time)
            ).Substring(3, 5);

            //lblMusicLength.Text = (time[2] - time[0]).ToString("00") + ":" + (time[1] - time[3]).ToString("00");
            lblMusicLength.Text = Convert.ToString(
                TimeSpan.FromMilliseconds(axVLCPlugin21.input.time) - TimeSpan.FromMilliseconds(musicDuration * 1000)
            ).Replace("-", "").Substring(3, 5);
        }

//====================================================================================================================//
//=================================================>>> EVENTS <<<=====================================================//
//====================================================================================================================//

        private void dataGridView1_MouseWheel(object sender, MouseEventArgs e) //========>>> TO SCROLL WITHOUT SCROLL BAR
        {
            if (e.Delta > 0 && dataGridView1.FirstDisplayedScrollingRowIndex > 0)
            {
                dataGridView1.FirstDisplayedScrollingRowIndex--;
            }

            else if (e.Delta < 0)
            {
                dataGridView1.FirstDisplayedScrollingRowIndex++;
            }
        }

        private void Form1_Load(object sender, EventArgs e) //===========================>>> FORM LOAD
        {
            dataGridView1.Rows.Clear();
            LoadTable("SELECT * FROM music WHERE musicTitle LIKE 'U+%' ORDER BY MusicTitle;");
            LoadTable("SELECT * FROM music WHERE musicTitle LIKE '[%' ORDER BY MusicTitle;");
            LoadTable("SELECT * FROM music WHERE musicTitle NOT LIKE 'U+%' AND musicTitle NOT LIKE '[%' ORDER BY MusicTitle;");

            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font( // SET BOLD TEXT TO TABLE'S HEADER
                dataGridView1.ColumnHeadersDefaultCellStyle.Font,
                FontStyle.Bold
            );

            trkVolume.Value = axVLCPlugin21.volume;
            lblVolume.Text = "Volume: " + trkVolume.Value + "%";
            currentVolumeValue = trkVolume.Value;
            //prgVolume.Value = axVLCPlugin21.volume;

            // EXPERIMENT: SPECIAL CHARACTERS ON TABLE
            //lblTitle.Text = "(なんでもないや)「AMV」Kimi no Na wa. (Your Name.)君の名は。";
            //dataGridView1.Rows.Add("RADWIMPS – Nandemonaiya  (なんでもないや)「AMV」Kimi no Na wa. (Your Name.)君の名は。", "");
        }

        private void btnPrev_Click(object sender, EventArgs e) //========================>>> PREVIOUS BUTTON CLICKED
        {
            if (trkMusic1.Value > 0)
            {
                lblMusicStart.Text = "00:00";
                lblMusicLength.Text = currentMusicLength;
                trkMusic1.Value = 0;
                timer1.Stop();
                axVLCPlugin21.playlist.stop();

                if (pause == true)
                {
                    timer1 = new Timer();
                    timer1.Interval = 1000; // 1 SECOND
                    timer1.Start();
                    timer1.Tick += new EventHandler(timer1_Tick);
                    //backgroundWorker1.RunWorkerAsync();
                    axVLCPlugin21.playlist.play();
                }
            }

            else if (trkMusic1.Value == 0)
            {
                LoadMusic(currentPrevMusic);
                getPrevAndNextMusic(currentPrevMusic);
            }
        }

        private void btnNext_Click(object sender, EventArgs e) //========================>>> NEXT BUTTON CLICKED
        {
            LoadMusic(currentNextMusic);
            getPrevAndNextMusic(currentNextMusic);
        }

        // RETURN HERE LATER FOR PROCESSING JAPANESE CHARACTERS, KOREAN, ETC.============>>> FUNCTION WAS NOT DONE YET
        private void btnAddMusic_Click(object sender, EventArgs e) //====================>>> ADD MUSIC BUTTON CLICKED
        {
            string musicLength = string.Empty;
            string musicTitle = string.Empty;
            string musicPath = string.Empty;
            bool duplicate = false;

            OpenFileDialog file = new OpenFileDialog();
            file.RestoreDirectory = true;
            file.Multiselect = true;
            file.InitialDirectory = @"C:\Music";
            file.Title = "Browse Audio File";
            file.Filter = "Audio Files (*.mp3, *.wav, *.aac, *.wma) | *.mp3; *.wav; *.aac; *.wma";

            file.ShowDialog();
            try
            {
                // FileNames WAS AN ARRAY SO WE USE FOR LOOP TO GET ACCESS OF ALL SELECTED FILES
                for (int i = 0; i < file.FileNames.Length; i++)
                {
                    var tfile = TagLib.File.Create(file.FileNames[i]);
                    musicTitle = string.Empty;
                    musicPath = string.Empty;

                    // REMOVING ALL SPECIAL CHARACTERS
                    //===================================================================>>> MUSIC TITLE
                    char[] titleArr = Path.GetFileName(file.FileNames[i]).ToCharArray(); // PER CHARACTERS
                    for (int k = 0; k < titleArr.Length; k++)
                    {
                        for (int j = 0; j < charCode.Length; j++)
                        {
                            // REPLACE CHAR IF SPECIAL CHAR EXIST
                            if (charSym[j] == Convert.ToString(titleArr[k]) && j < charCode.Length)
                            {
                                // REMOVING SYMBOLS TURN INTO CODE
                                musicTitle += Convert.ToString(titleArr[k]).Replace(charSym[j], charCode[j]);
                                break; // IF A MATCH IS FOUND STOP THE LOOP THEN PROCEED TO NEXT PAIR OF CHAR
                            }

                            else if (charSym[j] != Convert.ToString(titleArr[k]) && j < charCode.Length)
                            {
                                if (j == charCode.Length - 1) // LAST SPECIAL CHAR IS REACHED
                                {
                                    // WRITE THE CHAR
                                    musicTitle += Convert.ToString(titleArr[k]);
                                }
                            }
                        }
                    }

                    //===================================================================>>> MUSIC DIRECTORY
                    char[] pathArr = Convert.ToString(file.FileNames[i]).ToCharArray(); // PER CHARACTERS
                    for (int k = 0; k < pathArr.Length; k++) // ACCESSING CHARACTERS IN PATH
                    {
                        for (int j = 0; j < charCode.Length; j++) // ACCESSING CHARACTERS IN SPECIAL CHAR
                        {
                            // REPLACE CHAR IF SPECIAL CHAR EXIST
                            if (charSym[j] == Convert.ToString(pathArr[k]) && j < charCode.Length)
                            {
                                // REMOVING SYMBOLS TURN INTO CODE
                                musicPath += Convert.ToString(pathArr[k]).Replace(charSym[j], charCode[j]);
                                break; // IF A MATCH IS FOUND STOP THE LOOP THEN PROCEED TO NEXT PAIR OF CHAR
                            }

                            else if (charSym[j] != Convert.ToString(pathArr[k]) && j < charCode.Length)
                            {
                                if (j == charCode.Length - 1) // LAST SPECIAL CHAR IS REACHED
                                {
                                    // WRITE THE CHAR
                                    musicPath += Convert.ToString(pathArr[k]);
                                }
                            }
                        }
                    }

                    //===================================================================>>> MUSIC LENGTH
                    if (Convert.ToString(tfile.Properties.Duration).Substring(0, 2) == "00") // FORMATTING LENGTH
                    {
                        musicLength = Convert.ToString(tfile.Properties.Duration).Substring(3, 5);
                    }

                    else
                    {
                        musicLength = Convert.ToString(tfile.Properties.Duration).Substring(0, 8);
                    }

                    // LOOKING FOR DUPLICATE
                    ConnectDB.Open();
                    Command.CommandText = "SELECT COUNT(*) AS result FROM music WHERE " +
                        "musicTitle = '" + musicTitle + "'";
                    reader = Command.ExecuteReader();

                    while (reader.Read())
                    {
                        if (Convert.ToInt32(reader["result"]) > 0) { duplicate = true; } // DUPLICATE FOUND
                        else if (Convert.ToInt32(reader["result"]) == 0) { duplicate = false; } // NO DUPLICATE FOUND
                    }

                    reader.Close();
                    ConnectDB.Close();

                    // IF THESONG DOESN'T HAVE DUPLICATE THEN IT WILL BE ADDED TO DATABASE
                    if (duplicate == false)
                    {
                        ConnectDB.Open();
                        Command = new MySqlCommand(
                            "INSERT INTO music (" +
                                "MusicTitle, " +
                                "MusicDirectory, " +
                                "MusicLength, " +
                                "Favorite" +
                            ") VALUES (" +
                                "'" + musicTitle + "', " + // GETTING FILE NAME ONLY
                                "'" + musicPath + "', " +// GETTING FILE PATH WITH FILE NAME
                                "'" + musicLength + "', " +
                                "'Void'" +
                            ");", ConnectDB
                        );
                        Command.ExecuteNonQuery();
                        ConnectDB.Close();
                    }
                }
                dataGridView1.Rows.Clear();
                LoadTable("SELECT * FROM music WHERE musicTitle LIKE 'U+%' ORDER BY MusicTitle;");
                LoadTable("SELECT * FROM music WHERE musicTitle LIKE '[%' ORDER BY MusicTitle;");
                LoadTable("SELECT * FROM music WHERE musicTitle NOT LIKE 'U+%' AND musicTitle NOT LIKE '[%' ORDER BY MusicTitle;");
            }

            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Orchestra Music Player",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DisplayMusicTime();
            if (trkMusic1.Value == 1)
            {
                newSongSelected = false;
            }

            if (trkMusic1.Value < musicDuration)
            {
                trkMusic1.Value++;
                currentMusicValue = trkMusic1.Value;
            }

            else if (trkMusic1.Value == musicDuration)
            {
                timer1.Stop();
                LoadMusic(currentNextMusic);
                getPrevAndNextMusic(currentNextMusic);
            }
        }

        //=======================================================================================>>> PREVIOUS BUTTON HOVER

        private void btnPrev_MouseEnter(object sender, EventArgs e)
        {
            if (btnPrev.Enabled == true)
            {
                btnPrev.FlatAppearance.MouseOverBackColor = Color.Orange;
                btnPrev.BackgroundImage = Properties.Resources.PrevButtonHover;
            }
        }

        private void btnPrev_MouseLeave(object sender, EventArgs e)
        {
            if (btnPrev.Enabled == true)
            {
                btnPrev.BackgroundImage = Properties.Resources.PrevButtonDefault;
            }
        }

        //=======================================================================================>>> PLAY/PAUSE BUTTON HOVER

        private void btnPlay_MouseEnter(object sender, EventArgs e)
        {
            if (pause == true)
            {
                btnPlay.FlatAppearance.MouseOverBackColor = Color.Orange;
                btnPlay.BackgroundImage = Properties.Resources.PauseButtonHover;
            }

            else
            {
                btnPlay.FlatAppearance.MouseOverBackColor = Color.Orange;
                btnPlay.BackgroundImage = Properties.Resources.PlayButtonHover;
            }
        }

        private void btnPlay_MouseLeave(object sender, EventArgs e)
        {
            if (pause == true)
            {
                btnPlay.FlatAppearance.MouseOverBackColor = Color.Orange;
                btnPlay.BackgroundImage = Properties.Resources.PauseButtonDefault;
            }

            else
            {
                btnPlay.FlatAppearance.MouseOverBackColor = Color.Orange;
                btnPlay.BackgroundImage = Properties.Resources.PlayButtonDefault;
            }
        }

        //=======================================================================================>>> NEXT BUTTON HOVER

        private void btnNext_MouseEnter(object sender, EventArgs e)
        {
            if (btnNext.Enabled == true)
            {
                btnNext.FlatAppearance.MouseOverBackColor = Color.Orange;
                btnNext.BackgroundImage = Properties.Resources.NextButtonHover;
            }
        }

        private void btnNext_MouseLeave(object sender, EventArgs e)
        {
            if (btnNext.Enabled == true)
            {
                btnNext.BackgroundImage = Properties.Resources.NextButtonDefault;
            }
        }

        //=======================================================================================>>> VOLUME BUTTON HOVER

        private void btnVolume_MouseEnter(object sender, EventArgs e) //=================>>> THE SPEAKER ICON
        {
            btnVolume.FlatAppearance.MouseOverBackColor = Color.Orange;

            if (trkVolume.Value == 0)
            {
                btnVolume.BackgroundImage = Properties.Resources.MuteButtonHover;
            }

            else if (trkVolume.Value > 0 && trkVolume.Value < 33)
            {
                btnVolume.BackgroundImage = Properties.Resources.VolumeLowButtonHover;
            }

            else if (trkVolume.Value > 31 && trkVolume.Value < 67)
            {
                btnVolume.BackgroundImage = Properties.Resources.VolumeMediumButtonHover;
            }

            else if (trkVolume.Value > 65 && trkVolume.Value < 101)
            {
                btnVolume.BackgroundImage = Properties.Resources.VolumeHighButtonHover;
            }
        }

        private void btnVolume_MouseLeave(object sender, EventArgs e) //=================>>> THE SPEAKER ICON
        {
            btnVolume.FlatAppearance.MouseOverBackColor = Color.Orange;

            if (trkVolume.Value == 0)
            {
                btnVolume.BackgroundImage = Properties.Resources.MuteButtonDefault;
            }

            else if (trkVolume.Value > 0 && trkVolume.Value < 33)
            {
                btnVolume.BackgroundImage = Properties.Resources.VolumeLowButtonDefault;
            }

            else if (trkVolume.Value > 31 && trkVolume.Value < 67)
            {
                btnVolume.BackgroundImage = Properties.Resources.VolumeMediumButtonDefault;
            }

            else if (trkVolume.Value > 65 && trkVolume.Value < 101)
            {
                btnVolume.BackgroundImage = Properties.Resources.VolumeHighButtonDefault;
            }
        }

        private void btnPlay_Click_1(object sender, EventArgs e) //======================>>> PLAY/PAUSE BUTTON CLICKED
        {
            if (pause == true)
            {
                timer1.Stop();
                pause = false;
                axVLCPlugin21.playlist.pause();
                btnPlay.BackgroundImage = Properties.Resources.PlayButtonHover;
            }

            else if (pause == false)
            {
                timer1 = new Timer();
                timer1.Interval = 1000; // 1 SECOND
                timer1.Start();
                timer1.Tick += new EventHandler(timer1_Tick);
                //backgroundWorker1.RunWorkerAsync();

                pause = true;
                axVLCPlugin21.playlist.play();
                btnPlay.BackgroundImage = Properties.Resources.PauseButtonHover;
            }
        }

        //=======================================================================================>>> SHOW OPTION BUTTON HOVER

        private void btnShowOption_MouseEnter(object sender, EventArgs e)
        {
            btnShowOption.FlatAppearance.BorderColor = Color.Orange;
            btnShowOption.FlatAppearance.BorderSize = 1;
        }

        private void btnShowOption_MouseLeave(object sender, EventArgs e)
        {
            btnShowOption.FlatAppearance.BorderSize = 0;
        }

        //=======================================================================================>>> SEARCH BUTTON HOVER

        private void btnSearch_MouseEnter(object sender, EventArgs e)
        {
            btnSearch.FlatAppearance.BorderColor = Color.Orange;
            btnSearch.FlatAppearance.BorderSize = 1;
        }

        private void btnSearch_MouseLeave(object sender, EventArgs e)
        {
            btnSearch.FlatAppearance.BorderSize = 0;
        }

        //=======================================================================================>>> ADD MUSIC BUTTON HOVER

        private void btnAddMusic_MouseEnter(object sender, EventArgs e)
        {
            btnAddMusic.FlatAppearance.BorderColor = Color.Orange;
            btnAddMusic.FlatAppearance.BorderSize = 1;
        }

        private void btnAddMusic_MouseLeave(object sender, EventArgs e)
        {
            btnAddMusic.FlatAppearance.BorderSize = 0;
        }

        //=======================================================================================>>> ADD PLAYLIST BUTTON HOVER

        private void btnAddPlaylist_MouseEnter(object sender, EventArgs e)
        {
            btnAddPlaylist.FlatAppearance.BorderColor = Color.Orange;
            btnAddPlaylist.FlatAppearance.BorderSize = 1;
        }

        private void btnAddPlaylist_MouseLeave(object sender, EventArgs e)
        {
            btnAddPlaylist.FlatAppearance.BorderSize = 0;
        }

        //=======================================================================================>>> FAVORITES BUTTON HOVER

        private void btnFavorites_MouseEnter(object sender, EventArgs e)
        {
            btnFavorites.FlatAppearance.BorderColor = Color.Orange;
            btnFavorites.FlatAppearance.BorderSize = 1;
        }

        private void btnFavorites_MouseLeave(object sender, EventArgs e)
        {
            btnFavorites.FlatAppearance.BorderSize = 0;
        }

        //=======================================================================================>>> DELETE BUTTON HOVER

        private void btnDelete_MouseEnter(object sender, EventArgs e)
        {
            btnDelete.FlatAppearance.BorderColor = Color.Orange;
            btnDelete.FlatAppearance.BorderSize = 1;
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            btnDelete.FlatAppearance.BorderSize = 0;
        }

        //=======================================================================================>>> RECENT PLAYS BUTTON HOVER

        private void btnRecent_MouseEnter(object sender, EventArgs e)
        {
            btnRecent.FlatAppearance.BorderColor = Color.Orange;
            btnRecent.FlatAppearance.BorderSize = 1;
        }

        private void btnRecent_MouseLeave(object sender, EventArgs e)
        {
            btnRecent.FlatAppearance.BorderSize = 0;
        }

        private void trkVolume_ValueChanged(object sender, EventArgs e)
        {
            lblVolume.Text = "Volume: " + trkVolume.Value + "%";

            // TIMER 2 USED TO DELAY THE REACTION OF VOLUME OF VLC BECAUSE THE PROGRAM STOP RESPONDING IF IT WAS CALLED
            // EVERY TIME THAT THE VALUE OF trkVolume CHANGES
            timer2.Stop();
            timer2 = new Timer();
            timer2.Interval = 25; // 25 MILLISECOND
            timer2.Start();
            timer2.Tick += new EventHandler(timer2_Tick);


            if (trkVolume.Value == 0)
            {
                btnVolume.BackgroundImage = Properties.Resources.MuteButtonDefault;
            }

            else if (trkVolume.Value > 0 && trkVolume.Value < 33)
            {
                btnVolume.BackgroundImage = Properties.Resources.VolumeLowButtonDefault;
            }

            else if (trkVolume.Value > 31 && trkVolume.Value < 67)
            {
                btnVolume.BackgroundImage = Properties.Resources.VolumeMediumButtonDefault;
            }

            else if (trkVolume.Value > 65 && trkVolume.Value < 101)
            {
                btnVolume.BackgroundImage = Properties.Resources.VolumeHighButtonDefault;
            }
        }

        private void btnVolume_Click(object sender, EventArgs e)
        {
            if (axVLCPlugin21.volume > 0)
            {
                currentVolumeValue = axVLCPlugin21.volume;
                btnVolume.BackgroundImage = Properties.Resources.MuteButtonHover;
                trkVolume.Value = 0;
            }

            else
            {
                currentVolumeValue = axVLCPlugin21.volume;
                trkVolume.Value = currentVolumeValue;

                if (trkVolume.Value == 0)
                {
                    btnVolume.BackgroundImage = Properties.Resources.MuteButtonHover;
                }

                else if (trkVolume.Value > 0 && trkVolume.Value < 33)
                {
                    btnVolume.BackgroundImage = Properties.Resources.VolumeLowButtonHover;
                }

                else if (trkVolume.Value > 31 && trkVolume.Value < 67)
                {
                    btnVolume.BackgroundImage = Properties.Resources.VolumeMediumButtonHover;
                }

                else if (trkVolume.Value > 65 && trkVolume.Value < 101)
                {
                    btnVolume.BackgroundImage = Properties.Resources.VolumeHighButtonHover;
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e) // TO DELAY VOLUME'S REACTION
        {
            if (trkVolume.Value != axVLCPlugin21.volume)
            {
                axVLCPlugin21.volume = trkVolume.Value;
                timer2.Stop();
            }
        }

//=======================================================================================>>> BUG AREA (START)
        // WHAT THESE EVENT SUPPOSED TO DO WAS TO SIMPLY DISABLE SCROLL OF trkMusic1 
        // WITH THE INTERNET DISCONNECTION IN EARLY DAYS OF THIS MONTH (SEPTEMBER) IT WAS QUITE IMPOSSIBLE TO SOLVE
        private void trkMusic1_MouseWheel(object sender, MouseEventArgs e) // CAN'T USE TO AVOID SCROLLING
        {
            // HOW THE HELL CAN I DISABLE THE SCROLL EVENT! : BUG HERE...
            //MessageBox.Show("Mouse Scrolled!"); // REACHED!
            //if (trkMusic1.Value < currentMusicValue || trkMusic1.Value > currentMusicValue + 1)
            //if (trkMusic1.Value != currentMusicValue)
            //if (e.Delta > 0)
            //{
            //    trkMusicScrolled = true;
                //trkMusic1Counter++;
            //}
            
            //trkMusic1.ValueChanged += new EventHandler(trkMusic1_ValueChanged);
        }

        private void trkMusic1_ValueChanged(object sender, EventArgs e)
        {
            //if (trkMusicScrolled == true && trkMusic1.Value > currentMusicValue && trkMusic1Counter > 0)
            //{
            //    //MessageBox.Show(trkMusic1Counter + "");
            //    //trkMusic1.Value = currentMusicValue; // STACK OVERFLOW. THIS IS WHAT IT THROWS! BUG HERE...
            //    trkMusic1.MouseWheel -= new MouseEventHandler(trkMusic1_MouseWheel);

            //    if (pause == true)
            //    {
            //        // RIGHT NOW THE BUG WAS trkMusic1'S VALUE STOPS INCREMENTING
            //        //MessageBox.Show("Condition Met!");
            //        //timer1.Tick += new EventHandler(timer1_Tick); // THIS IS WHERE THE trkMusic1 VALUE INCREMENT
            //        if (trkMusic1.Value == 1)
            //        {
            //            newSongSelected = false;
            //        }

            //        if (trkMusic1.Value < musicDuration)
            //        {
            //            trkMusic1.Value++;
            //            currentMusicValue = trkMusic1.Value;
            //        }

            //        else if (trkMusic1.Value == musicDuration)
            //        {
            //            timer1.Stop();
            //            LoadMusic(currentNextMusic);
            //            getPrevAndNextMusic(currentNextMusic);
            //        }
            //    }
            //}
        }
//=======================================================================================>>> BUG AREA (END)

        private void trkMusic1_MouseClick(object sender, MouseEventArgs e)
        {
            if (trkMusic1.Value != currentMusicValue)
            {
                currentMusicValue = trkMusic1.Value;
                axVLCPlugin21.input.time = trkMusic1.Value * 1000;
                DisplayMusicTime();
            }
        }

        private void dataGridView1_MouseDoubleClick_1(object sender, MouseEventArgs e) //==>>> A SONG HAS BEEN SELECTED
        {
            //trkMusic1.MouseWheel += new MouseEventHandler(trkMusic1_MouseWheel); // TO DETECT SCROLL EVENT (REMOVE BECAUSE THIS WAS PART OF THE DEGBUGGING THAT IS UNSOLVED)
            getSelectedMusic();
            getPrevAndNextMusic(selectedMusic);
            LoadMusic(selectedMusic);
        }

        //===============================================================================>>> HOVER ON TABLE ROW
        private void dataGridView1_CellMouseMove_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dataGridView1.ClearSelection();
                dataGridView1.Rows[e.RowIndex].Selected = true;
            }
        }

        private void dataGridView1_MouseLeave_1(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }

//=======================================================================================>>> TOP BUTTON HOVER (START)
        private void btnDefault1_MouseEnter(object sender, EventArgs e) //===============>>> HOVERING SECOND BUTTON
        {
            btnNumTwoHover0.Visible = true;
            btnNumTwoHover1.Visible = true;
            btnNumTwoHover2.Visible = true;

            btnDefault0.Visible = false;
            btnDefault1.Visible = false;
            btnDefault2.Visible = false;

            if(tablePage == "Music")
            {
                btnNumTwoHover0.BackgroundImage = Properties.Resources.MusicTopButtonWhite;
                btnNumTwoHover1.BackgroundImage = Properties.Resources.PlaylistTopButton;
                btnNumTwoHover2.BackgroundImage = Properties.Resources.FavoritesTopButtonOrange;
            } 

            else if (tablePage == "Playlist")
            {
                btnNumTwoHover0.BackgroundImage = Properties.Resources.PlaylistTopButton;
                btnNumTwoHover1.BackgroundImage = Properties.Resources.MusicTopButtonWhite;
                btnNumTwoHover2.BackgroundImage = Properties.Resources.FavoritesTopButtonOrange;
            }

            else if (tablePage == "Favorites")
            {
                btnNumTwoHover0.BackgroundImage = Properties.Resources.FavoritesTopButton;
                btnNumTwoHover1.BackgroundImage = Properties.Resources.PlaylistTopButton;
                btnNumTwoHover2.BackgroundImage = Properties.Resources.MusicTopButtonOrange;
            }
        }

        private void btnDefault2_MouseEnter(object sender, EventArgs e) //===============>>> HOVERING THIRD BUTTON
        {
            btnNumThreeHover0.Visible = true;
            btnNumThreeHover1.Visible = true;
            btnNumThreeHover2.Visible = true;

            btnDefault0.Visible = false;
            btnDefault1.Visible = false;
            btnDefault2.Visible = false;

            if (tablePage == "Music") //=================================================>>> IF TABLE CURRENTLY DISPLAYED IS MUSIC
            {
                btnNumTwoHover0.BackgroundImage = Properties.Resources.MusicTopButtonWhite;
                btnNumTwoHover1.BackgroundImage = Properties.Resources.PlaylistTopButtonOrange;
                btnNumTwoHover2.BackgroundImage = Properties.Resources.FavoritesTopButton;
            }

            else if (tablePage == "Playlist") //=========================================>>> IF TABLE CURRENTLY DISPLAYED IS PLAYLIST
            {
                btnNumTwoHover0.BackgroundImage = Properties.Resources.PlaylistTopButton;
                btnNumTwoHover1.BackgroundImage = Properties.Resources.MusicTopButtonOrange;
                btnNumTwoHover2.BackgroundImage = Properties.Resources.FavoritesTopButton;
            }

            else if (tablePage == "Favorites") //========================================>>> IF TABLE CURRENTLY DISPLAYED IS FAVORITES
            {
                btnNumTwoHover0.BackgroundImage = Properties.Resources.FavoritesTopButton;
                btnNumTwoHover1.BackgroundImage = Properties.Resources.PlaylistTopButtonOrange;
                btnNumTwoHover2.BackgroundImage = Properties.Resources.MusicTopButtonWhite;
            }
        }

        private void btnNumTwoHover1_MouseLeave(object sender, EventArgs e) //===========>>> RETURN TO DEFAULT FROM SECOND BUTTON
        {
            btnDefault0.Visible = true;
            btnDefault1.Visible = true;
            btnDefault2.Visible = true;

            btnNumTwoHover0.Visible = false;
            btnNumTwoHover1.Visible = false;
            btnNumTwoHover2.Visible = false;
        }

        private void btnNumThreeHover2_MouseLeave(object sender, EventArgs e) //=========>>> RETURN TO DEFAULT FROM THIRD BUTTON
        {
            btnDefault0.Visible = true;
            btnDefault1.Visible = true;
            btnDefault2.Visible = true;

            btnNumThreeHover0.Visible = false;
            btnNumThreeHover1.Visible = false;
            btnNumThreeHover2.Visible = false;
        }
//=======================================================================================>>> TOP BUTTON HOVER (END)

        private void btnNumTwoHover1_Click(object sender, EventArgs e)
        {
            btnDefault0.Visible = true;
            btnDefault1.Visible = true;
            btnDefault2.Visible = true;

            btnNumTwoHover0.Visible = false;
            btnNumTwoHover1.Visible = false;
            btnNumTwoHover2.Visible = false;

            if (tablePage == "Music")
            {
                btnNumTwoHover0.BackgroundImage = Properties.Resources.MusicTopButtonWhite;
                btnNumTwoHover1.BackgroundImage = Properties.Resources.PlaylistTopButton;
                btnNumTwoHover2.BackgroundImage = Properties.Resources.FavoritesTopButtonOrange;
            }

            else if (tablePage == "Playlist")
            {
                btnNumTwoHover0.BackgroundImage = Properties.Resources.PlaylistTopButton;
                btnNumTwoHover1.BackgroundImage = Properties.Resources.MusicTopButtonWhite;
                btnNumTwoHover2.BackgroundImage = Properties.Resources.FavoritesTopButtonOrange;
            }

            else if (tablePage == "Favorites")
            {
                btnNumTwoHover0.BackgroundImage = Properties.Resources.FavoritesTopButton;
                btnNumTwoHover1.BackgroundImage = Properties.Resources.PlaylistTopButton;
                btnNumTwoHover2.BackgroundImage = Properties.Resources.MusicTopButtonOrange;
            }
        }
    }
}