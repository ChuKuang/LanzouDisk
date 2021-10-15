using System;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace LanZouAPI
{
    public partial class LanZouCloud
    {
        public enum LogLevel
        {
            None = 0,
            Error = 1,
            Warning = 2,
            Info = 3,
        }

        private LogLevel _log_level = LogLevel.None;

        /// <summary>
        /// 设置日志等级
        /// </summary>
        /// <param name="level"></param>
        public void set_log_level(LogLevel level)
        {
            this._log_level = level;
        }

        private void LogError(object log)
        {
            if (_log_level < LogLevel.Error)
                return;

#if UNITY_5_3_OR_NEWER
            UnityEngine.Debug.LogError($"[LanZouCloud] {log}");
#else
            Console.WriteLine($"[LanZouCloud][Error] {log}");
#endif
        }

        private void LogWarning(object log)
        {
            if (_log_level < LogLevel.Warning)
                return;

#if UNITY_5_3_OR_NEWER
            UnityEngine.Debug.LogWarning($"[LanZouCloud] {log}");
#else
            Console.WriteLine($"[LanZouCloud][Warning] {log}");
#endif
        }

        private void LogInfo(object log)
        {
            if (_log_level < LogLevel.Info)
                return;

#if UNITY_5_3_OR_NEWER
            UnityEngine.Debug.Log($"[LanZouCloud] {log}");
#else
            Console.WriteLine($"[LanZouCloud][Info] {log}");
#endif
        }
    }
}