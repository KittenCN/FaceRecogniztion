using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iFlyDotNet;
using NAudio.Wave;
using System.Reflection;

namespace FaceRecogniztion.Util
{
    class TTS
    {
        public static void voicePlay(string s, int speaker)
        {
            string appid = "appid=56826d04";
            iFlyTTS tts = new iFlyTTS(appid);
            tts.Finished += tts_Finished;
            tts.vol = enuVol.x_loud;
            tts.speed = enuSpeed.fast;
            tts.speeker = (enuSpeeker)speaker;
            tts.MultiSpeek(s, "audio.wav");
            System.Media.SoundPlayer sp = new System.Media.SoundPlayer("audio.wav");
            sp.Play();
        }

        private static void tts_Finished(object sender, iFlyTTS.JinDuEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(e.AllP.ToString());
        }

        public static string wordClear(string s)
        {
            string returnStr = "";
            string dotFlag = "，|,|。|？|！";
            if (dotFlag.IndexOf(s) != -1)
            {
                returnStr = "";
            }

            foreach (string dot in dotFlag.Split('|'))
            {
                s = s.Replace(dot, "");
            }
            returnStr = s;

            return returnStr;
        }
    }
}
