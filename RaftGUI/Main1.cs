using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using MelonLoader;
using UnityEngine;
using FMODUnity;
using Console = System.Console;
using Object = UnityEngine.Object;
using String = System.String;
using UltimateWater;

namespace RaftGUI
{
    //WHY CAN'T YOU JUST BE NAMED MAIN YOU PIECE OF SHIT IT'S BEEN 2 HOURS
    public class Main1 : MelonMod
    {
        internal static object gameController;
        private bool gameStarted;
        private int initializedScene;

        public static object AI_StateMachine_Shark { get; internal set; }

        public override void OnApplicationStart()
        {
            Debug.Msg("Set console title to: Raft", 1);
            Console.Title = string.Format("Raft");
        }
    }
}

namespace RaftGUI
{
    //Thanks for leaving your melon source up C4 I can't believe I overlooked this xD. Makes it way easier to split classes, god bless.
    public class CheatToggles
    {
        public static bool guiEnabled = false;

        public static bool enableDebug = false;

        public static bool enableInfoPlayer = false;

        public static bool enableFullbright = false;

        public static bool enableSharkESP = false;
        public static bool enablePlayerESP = false;
    }
}

namespace RaftGUI
{
    //Copy paste debug because C4PhasMod is a solid base. At least I left credit here.
    class Debug
    {
        public static void Msg(String text, int mode = 0)
        {
            if (CheatToggles.enableDebug && mode > 0)
            {
                if (debugMode1 && mode == 1)
                    MelonLogger.Msg($"[+] {text}");
                if (debugMode2 && mode == 2)
                    MelonLogger.Msg($"[#] {text}");
                if (debugMode3 && mode == 3)
                    MelonLogger.Msg($"[D] {text}");
            }
        }

        public static bool debugMode1 = false;
        public static bool debugMode2 = false;
        public static bool debugMode3 = false;
    }
}
namespace RaftGUI
{
    //Another shameless copy paste, don't worry C4 will be very credited, considering he is the reason I started ML modding. Big props to him. (Too lazy to create own draw style)
    class Drawing
    {
        public static GUIStyle StringStyle { get; set; } = new GUIStyle(GUI.skin.label);

        public static void DrawString(Vector2 position, string label, Color color, int fontSize, bool centered = true)
        {
            GUI.color = color;
            StringStyle.fontSize = fontSize;
            StringStyle.normal.textColor = color;
            var content = new GUIContent(label);
            var size = StringStyle.CalcSize(content);
            var upperLeft = centered ? position - size / 2f : position;
            GUI.Label(new Rect(upperLeft, size), content, StringStyle);
        }

        public static void DrawLine(Vector2 start, Vector2 end, Color color, float width)
        {
            GUI.depth = 0;
            var rad2deg = 360 / (Math.PI * 2);
            Vector2 d = end - start;
            float a = (float)rad2deg * Mathf.Atan(d.y / d.x);

            if (d.x < 0)
                a += 180;

            int width2 = (int)Mathf.Ceil(width / 2);

            GUIUtility.RotateAroundPivot(a, start);
            GUI.color = color;
            GUI.DrawTexture(new Rect(start.x, start.y - width2, d.magnitude, width), Texture2D.whiteTexture, ScaleMode.StretchToFill);
            GUIUtility.RotateAroundPivot(-a, start);
        }

        public static void DrawBox(Vector2 position, Vector2 size, Color color, bool centered = true)
        {
            var upperLeft = centered ? position - size / 2f : position;
            GUI.color = color;
            GUI.DrawTexture(new Rect(position, size), Texture2D.whiteTexture, ScaleMode.StretchToFill);
        }

        public static void DrawBoxOutline(Vector2 Point, float width, float height, Color color)
        {
            DrawLine(Point, new Vector2(Point.x + width, Point.y), color, 2);
            DrawLine(Point, new Vector2(Point.x, Point.y + height), color, 2);
            DrawLine(new Vector2(Point.x + width, Point.y + height), new Vector2(Point.x + width, Point.y), color, 2);
            DrawLine(new Vector2(Point.x + width, Point.y + height), new Vector2(Point.x, Point.y + height), color, 2);
        }
    }
}
namespace RaftGUI
{
    class FullBright
    {

    }
}
namespace RaftGUI
{
    class ESP
    {
        public static void Enable()
        {
            bool OnSceneActivated = false;
            if (OnSceneActivated == true)
                if (CheatToggles.enableSharkESP == true
                    && Main1.gameController != null
                    && Main1.AI_StateMachine_Shark != null)
                {

                }
        }
    }
}