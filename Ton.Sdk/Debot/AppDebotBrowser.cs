namespace Ton.Sdk.Debot
{
    using System;
    using Newtonsoft.Json;

    /// <summary>
    ///     The App debot browser
    /// </summary>
    public class AppDebotBrowser
    {
        #region Properties

        [JsonProperty("type")] public AppDebotBrowserType Type { get; private set; }

        [JsonProperty("msg")] public string Msg { get; private set; }

        public int ContextId { get; private set; }

        [JsonProperty("action")] public DebotAction Action { get; private set; }

        [JsonProperty("prompt")] public string Prompt { get; private set; }

        [JsonProperty("debot_addr")] public string DebotAddr { get; private set; }

        #endregion

        #region Methods

        public static AppDebotBrowser CreateAppDebotBrowser(AppDebotBrowserType type, string value)
        {
            switch (type)
            {
                case AppDebotBrowserType.Log:
                    return new AppDebotBrowser { Type = AppDebotBrowserType.Log, Msg = value };
                case AppDebotBrowserType.Input:
                    return new AppDebotBrowser { Type = AppDebotBrowserType.Input, Prompt = value };
            }

            throw new ArgumentException("type: " + type + " not incomparable argument of string type");
        }

        public static AppDebotBrowser CreateAppDebotBrowser(int contextId)
        {
            return new AppDebotBrowser { Type = AppDebotBrowserType.Switch, ContextId = contextId };
        }

        public static AppDebotBrowser CreateAppDebotBrowser(DebotAction action)
        {
            return new AppDebotBrowser { Type = AppDebotBrowserType.ShowAction, Action = action };
        }

        public static AppDebotBrowser CreateAppDebotBrowser(AppDebotBrowserType type)
        {
            if (type == AppDebotBrowserType.GetSigningBox || type == AppDebotBrowserType.SwitchCompleted)
            {
                return new AppDebotBrowser { Type = type };
            }

            throw new ArgumentException("type: " + type + " cannot be used without arguments");
        }

        public static AppDebotBrowser CreateAppDebotBrowser(string debotAddr, DebotAction action)
        {
            return new AppDebotBrowser { Type = AppDebotBrowserType.InvokeDebot, Action = action, DebotAddr = debotAddr };
        }

        #endregion
    }
}