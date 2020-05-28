using System;
using System.Text;
using System.IO;
using System.Reflection;
using System.Diagnostics;
using MelonLoader;
using Microsoft.Win32;
using UnityEngine;


namespace AdaptiveGraphicsSettings
{
    public static class BuildInfo
    {
        public const string Name = "AdaptiveGraphicsSettings";
        public const string Author = "Teo";
        public const string Company = null;
        public const string Version = "1.0.0";
        public const string DownloadLink = null;
    }

    public class AdaptiveGraphicsSettings : MelonMod
    {
        public static float Average = 0f;
        public static float FPS = 0f;
        private static float RefreshRate = 0f;
        public override void OnUpdate()
        {
            //MelonModLogger.Log("OnUpdate");

            Average += ((Time.deltaTime / Time.timeScale) - Average) * 0.03f;
            FPS = 1 / Average;

            RefreshRate += Time.deltaTime;
            if (RefreshRate < 8f) return;
            RefreshRate = 0f;

            if (FPS > 50f)
            {
                ultra();
            }
            else if (FPS > 40f)
            {
                high();
            }
            else if (FPS > 30f)
            {
                medium();
            }
            else if (FPS > 20f)
            {
                low();
            }
            else if (FPS < 10f)
            {
                ultraLow();
            }
            owo++;
        }
        int owo = 0;

        public static void ultra()
        {
            QualitySettings.antiAliasing = 8;
            QualitySettings.pixelLightCount = 8;
            QualitySettings.lodBias = 2f;
            QualitySettings.shadowDistance = 200f;
        }
        public static void high()
        {
            QualitySettings.antiAliasing = 6;
            QualitySettings.pixelLightCount = 6;
            QualitySettings.lodBias = 1.5f;
            QualitySettings.shadowDistance = 180f;
        }

        public static void medium()
        {
            QualitySettings.antiAliasing = 4;
            QualitySettings.pixelLightCount = 4;
            QualitySettings.lodBias = 1.2f;
            QualitySettings.shadowDistance = 120f;
        }

        public static void low()
        {
            QualitySettings.antiAliasing = 2;
            QualitySettings.pixelLightCount = 2;
            QualitySettings.lodBias = 0.8f;
            QualitySettings.shadowDistance = 80f;
        }

        public static void ultraLow()
        {
            QualitySettings.antiAliasing = 0;
            QualitySettings.pixelLightCount = 0;
            QualitySettings.lodBias = 0.4f;
            QualitySettings.shadowDistance = 20f;
        }


    }
}
