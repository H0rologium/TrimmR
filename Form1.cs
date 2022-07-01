using FlyleafLib;
using FlyleafLib.MediaPlayer;
using System.Diagnostics;

namespace TrimmR
{
    public partial class TrimmR : Form
    {

        private readonly string ffmpeg_path = $"{System.AppDomain.CurrentDomain.BaseDirectory}/FFmpeg" ;
        private string filepath = "";
        private string folderpath = "";
        private Player player;
        private helpWindow formpopup;
        
        public TrimmR()
        {
            InitializeComponent();
            CheckFFMPEG();
            InitUI();
        }

        private void InitUI()
        {
            splabel.Text = "00:00:00";
            eplabel.Text = "00:00:00";
            startpointbtn.Enabled = false;
            endpointbtn.Enabled = false;
            replayfromstartbtn.Enabled = false;
            unloadbtn.Enabled = false;
            formpopup = new helpWindow();
            formpopup.Hide();
            return;
        }

        private void CheckFFMPEG()
        {
            if (Directory.Exists(ffmpeg_path))
            {
                UpdateFFMPEGLabelText("FFMPEG Found");
                ffmpeglabel.ForeColor = Color.Green;
                Engine.Start(new EngineConfig()
                {
                    UIRefresh = true,
                    UIRefreshInterval = 250,
                    UICurTimePerSecond = false,
                    HighPerformaceTimers = false,
                    LogOutput = $"{System.Environment.CurrentDirectory}//flyleaf.log",
                    LogLevel = LogLevel.Debug,
                    FFmpegLogLevel = FFmpegLogLevel.Warning,
                    //PluginsPath = $"{System.Environment.CurrentDirectory}/Plugins", not sure if needed anymore.
                    FFmpegPath = ffmpeg_path,
                    FFmpegDevices = false,
                });
                player = new Player();
                player.Control = flyleafplayer;
            }
            else
            {
                UpdateFFMPEGLabelText("FFMPEG NOT Found!");
                ffmpeglabel.ForeColor = Color.DarkRed;
            }
        }

        private void PickFile_Click(object sender, EventArgs e)
        {
            if (player.Status != Status.Stopped || player.Status != Status.Ended || player.Status != Status.Failed) player.Stop();
            OpenFileDiag.Filter = "Video Files(*.mp4;*.avi;*.mkv)|*.mp4;*.avi;*.mkv";
            if (OpenFileDiag.ShowDialog() == DialogResult.OK)
            {
                filepath = OpenFileDiag.FileName;
                folderpath = Path.GetDirectoryName(OpenFileDiag.FileName);
                player.OpenAsync(filepath);
                unloadbtn.Enabled = true;
                pausebtnclick(new object(), new EventArgs());
                player.PropertyChanged += (o, e) =>
                {
                    UpdatePlayerFields();
                };
            }
        }

        private void UpdatePlayerFields()
        {
            UpdateTimeStamps(player.CurTime, player.Duration);
            if (player.CurTime >= player.Duration) player.Stop();
        }

        private void pausebtnclick(object sender, EventArgs e)
        {
            if (player.Status == Status.Playing)
            {
                player.Pause();
                startpointbtn.Enabled = true;
                endpointbtn.Enabled = true;
                replayfromstartbtn.Enabled = true;
                pausebtn.Text = "RESUME";
            }
            else
            {
                player.Play();
                startpointbtn.Enabled = false;
                endpointbtn.Enabled = false;
                replayfromstartbtn.Enabled = false;
                pausebtn.Text = "PAUSE";
            }
            return;
        }

        private string startPos = "00:00:00";
        private string endPos = "00:00:00";

        private void markEndTrim(object sender, EventArgs e)
        {
            endPos = toHumanTongue(player.CurTime);
            eplabel.Text = endPos;
        }

        private void markStartTrim(object sender, EventArgs e)
        {
            startPos = toHumanTongue(player.CurTime);
            splabel.Text = startPos;
            trimandexportbtn.Enabled = true;
        }

        private string toHumanTongue(long videoTime)
        {
            const int HOUR_H = 12, HOUR_L = 11, MIN_H = 10, MIN_L = 9, SEC_H = 8;

            string resultingTime = "";
            string sTime = videoTime.ToString();
            resultingTime += (sTime.Length > HOUR_L) ? (sTime.Length > HOUR_H) ? $"{sTime.Substring(0,2)}:" : $"0{sTime.Substring(0,1)}:" : $"00:";
            if (sTime.Length > HOUR_H) sTime = sTime.Remove(0, 2);
            if (sTime.Length > HOUR_L) sTime = sTime.Remove(0, 1);
            resultingTime += (sTime.Length > MIN_L) ? (sTime.Length > MIN_H) ? $"{sTime.Substring(0,2)}:" : $"0{sTime.Substring(0, 1)}:" : $"00:";
            if (sTime.Length > MIN_H) sTime = sTime.Remove(0, 2);
            if (sTime.Length > MIN_L) sTime = sTime.Remove(0, 1);
            resultingTime += (sTime.Length > SEC_H) ? $"{sTime.Substring(0, 2)}" : $"0{sTime.Substring(0,1)}";
            return resultingTime;
        }

        private void resetPoints(object sender, EventArgs e)
        {
            string defaultValue = "00:00:00";
            splabel.Text = defaultValue;
            startPos = defaultValue;
            eplabel.Text = defaultValue;
            endPos = defaultValue;
            trimandexportbtn.Enabled = false;
        }

        private void exportTrim(object sender, EventArgs e)
        {
            Microsoft.Win32.SaveFileDialog dlg = new()
            {
                FileName = $"export_{DateTime.Now.Hour}_{DateTime.Now.Minute}",
                DefaultExt = ".mp4",
                Filter = "Media Files (.mp4)|*.mp4"
            };
            Nullable<bool> result = dlg.ShowDialog();
            if (result == true)
            {
                string exportPath = dlg.FileName;
                dlg.InitialDirectory = folderpath;
                string endPo = (endPos == "00:00:00") ? toHumanTongue(player.Duration) : endPos;
                string ffmpegCommandArgs = $"-ss {startPos} -to {endPo} -i {filepath} -c copy {exportPath}";
                RunFFMPEG(ffmpegCommandArgs);
            }
        }
        private void RunFFMPEG(string parameters)
        {
            using Process p = new();
            p.StartInfo.UseShellExecute = true;
            p.StartInfo.CreateNoWindow = false;
            p.StartInfo.RedirectStandardOutput = false;
            p.StartInfo.FileName = $"{ffmpeg_path}/ffmpeg.exe";
            p.StartInfo.Arguments = parameters;
            p.Start();
            return;
        }

        private void replayFromStart(object sender, EventArgs e)
        {
            if (player.Status == Status.Playing) return;
            player.SeekAccurate(0);
            player.Play();
            replayfromstartbtn.Enabled = false;
        }
        #region skip methods
        private void skipFw1Sec(object sender, EventArgs e)
        {
            skipTo(1000);
        }

        private void skipFW30Seconds(object sender, EventArgs e)
        {
            skipTo(30000);
        }

        private void skipFW1Minute(object sender, EventArgs e)
        {
            skipTo(60000);
        }

        private void skipBW1Second(object sender, EventArgs e)
        {
            skipTo(1000,false);
        }

        private void skipBW30Seconds(object sender, EventArgs e)
        {
            skipTo(30000, false);
        }

        private void skipBW1Minute(object sender, EventArgs e)
        {
            skipTo(60000, false);
        }

        private void jumpToSpecificTime(object sender, EventArgs e)
        {
            if (player.Status != Status.Playing && player.Status != Status.Paused) return;
            //0 - hh 1 - mm 2 - ss
            List<String> timeDest = new();
            for (int i = 0; i < skipField.Text.Length; i += 3)
            {
                timeDest.Add(skipField.Text.Substring(i, 2));
            }
            //skip to forward then traverse to bookmark spot
            player.SeekAccurate(0);
            skipTo(int.Parse(timeDest[0] + timeDest[1] + timeDest[2] + "000"));
            pausebtnclick(new object(), new EventArgs());
            skipField.Text = "hh:mm:ss";
            return;
        }

        #endregion
        private void stopAndUnload(object sender, EventArgs e)
        {
            if (player.Status == Status.Playing || player.Status == Status.Paused) player.Stop();
            //player.Dispose();
            //player = new();
            //player.Control = flyleafplayer;
            unloadbtn.Enabled = false;
        }

        private void jumpFieldClick(object sender, EventArgs e)
        {
            skipField.Text = "";
        }

        private void showJumpToHelp(object sender, EventArgs e)
        {
            if (player.Status == Status.Paused) pausebtnclick(new object(), new EventArgs());
            formpopup.ShowDialog();
            return;
        }
    }
}