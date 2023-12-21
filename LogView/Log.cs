using System;
using System.Diagnostics;
using System.Text;
using UnityEngine;

namespace FlowEngine
{
    public static class Log
    {
        private const string At = " @ ";
        private const string With = " ! ";
        private const string CyonColorOpen = "<color=cyan>";
        private const string ColorClose = "</color>";

        public static bool Enable = true;

        private static string CurrentTime()
        {
            return string.Empty;
            //DateTime now = DateTime.Now;
            //return now.ToLongTimeString() + ":" + now.Millisecond;
        }

        public static void Debug(string title, string msg)
        {
            if (!Enable)
                return;
            var builder = new StringBuilder(CurrentTime());
            builder.Append(At).Append(CyonColorOpen).Append(title).Append(ColorClose).Append(With).Append(msg);
            UnityEngine.Debug.Log(builder.ToString());
        }

        public static void Debug(object msg)
        {
            if (!Enable)
                return;
            msg = CurrentTime() + At + msg;
            UnityEngine.Debug.Log(msg);
        }

        public static void DebugFormat(string format, params object[] args)
        {
            if (!Enable)
                return;
            string msg = CurrentTime() + At + string.Format(format, args);
            UnityEngine.Debug.Log(msg);
        }

        public static void Error(object msg)
        {
            if (!Enable)
                return;
            msg = CurrentTime() + At + msg;
            UnityEngine.Debug.LogError(msg);
        }

        public static void Error(UnityEngine.Object obj, object msg)
        {
            if (!Enable)
                return;
            msg = CurrentTime() + At + msg;
            UnityEngine.Debug.LogError(msg, obj);
        }

        public static void ErrorFormat(string format, params object[] args)
        {
            if (!Enable)
                return;
            string msg = CurrentTime() + At + string.Format(format, args);
            UnityEngine.Debug.LogError(msg);
        }

        public static void Trace()
        {
            if (!Enable)
                return;
            UnityEngine.Debug.Log(Environment.StackTrace);
        }

        public static void Warning(object msg)
        {
            if (!Enable)
                return;
            msg = CurrentTime() + At + msg;
            UnityEngine.Debug.LogWarning(msg);
        }

        public static void WarningFormat(string format, params object[] args)
        {
            if (!Enable)
                return;
            string msg = CurrentTime() + At + string.Format(format, args);
            UnityEngine.Debug.LogWarning(msg);
        }

        [Conditional("UNITY_EDITOR")]
        public static void DrawLine(Vector3 start, Vector3 end, Color color, float duration)
        {
            if (!Enable)
                return;
            UnityEngine.Debug.DrawLine(start, end, color, duration);
        }

        [Conditional("UNITY_EDITOR")]
        public static void DrawLine(Vector3 start, Vector3 end, Color color)
        {
            if (!Enable)
                return;
            UnityEngine.Debug.DrawLine(start, end, color);
        }
    }
}