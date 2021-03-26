namespace Ton.Sdk.Debot
{
    using System;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Request;

    /// <summary>
    ///     The App debot browser
    /// </summary>
    public class AppDebotBrowser : TonClientModule
    {
        #region Constructors

        public AppDebotBrowser(TonClient tonClient) : base(tonClient)
        {
        }

        #endregion

        #region Properties

        [JsonProperty("type")]
        public AppDebotBrowserType Type { get; private set; }

        [JsonProperty("msg")]
        public string Msg { get; private set; }

        public int ContextId { get; private set; }

        [JsonProperty("action")]
        public DebotAction Action { get; private set; }

        [JsonProperty("prompt")]
        public string Prompt { get; private set; }

        [JsonProperty("debot_addr")]
        public string DebotAddr { get; private set; }

        #endregion

        #region Methods

        public static AppDebotBrowser CreateAppDebotBrowser(TonClient tonClient, AppDebotBrowserType type, string value)
        {
            switch (type)
            {
                case AppDebotBrowserType.Log:
                    return new AppDebotBrowser(tonClient)
                    {
                        Type = AppDebotBrowserType.Log,
                        Msg = value
                    };
                case AppDebotBrowserType.Input:
                    return new AppDebotBrowser(tonClient)
                    {
                        Type = AppDebotBrowserType.Input,
                        Prompt = value
                    };
            }

            throw new ArgumentException("type: " + type + " not incomparable argument of string type");
        }

        public static AppDebotBrowser CreateAppDebotBrowser(TonClient tonClient, int contextId)
        {
            return new AppDebotBrowser(tonClient)
            {
                Type = AppDebotBrowserType.Switch,
                ContextId = contextId
            };
        }

        public static AppDebotBrowser CreateAppDebotBrowser(TonClient tonClient, DebotAction action)
        {
            return new AppDebotBrowser(tonClient)
            {
                Type = AppDebotBrowserType.ShowAction,
                Action = action
            };
        }

        public static AppDebotBrowser CreateAppDebotBrowser(TonClient tonClient, AppDebotBrowserType type)
        {
            if (type == AppDebotBrowserType.GetSigningBox || type == AppDebotBrowserType.SwitchCompleted)
            {
                return new AppDebotBrowser(tonClient)
                {
                    Type = type
                };
            }

            throw new ArgumentException("type: " + type + " cannot be used without arguments");
        }

        public static AppDebotBrowser CreateAppDebotBrowser(TonClient tonClient, string debotAddr, DebotAction action)
        {
            return new AppDebotBrowser(tonClient)
            {
                Type = AppDebotBrowserType.InvokeDebot,
                Action = action,
                DebotAddr = debotAddr
            };
        }

        /// <summary>
        /// Fetches the specified parameters of fetch.
        /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_debot.md#log
        /// </summary>
        /// <param name="paramsOfAppDebotBrowserLog">The parameters of application debot browser log.</param>
        public async Task Log(ParamsOfAppDebotBrowserLog paramsOfAppDebotBrowserLog)
        {
            await this.Request<string>("app_debot_browser.log", paramsOfAppDebotBrowserLog);
        }

        /// <summary>
        /// Switches the specified parameters of application debot browser switch.
        /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_debot.md#switch
        /// </summary>
        /// <param name="paramsOfAppDebotBrowserSwitch">The parameters of application debot browser switch.</param>
        public async Task Switch(ParamsOfAppDebotBrowserSwitch paramsOfAppDebotBrowserSwitch)
        {
            await this.Request<string>("app_debot_browser.switch", paramsOfAppDebotBrowserSwitch);
        }

        /// <summary>
        /// Switches the completed.
        /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_debot.md#switch_completed
        /// </summary>
        public async Task SwitchCompleted()
        {
            await this.Request<string>("app_debot_browser.switch_completed");
        }

        /// <summary>
        /// Shows the action.
        /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_debot.md#show_action
        /// </summary>
        /// <param name="paramsOfAppDebotBrowserShowAction">The parameters of application debot browser show action.</param>
        public async Task ShowAction(ParamsOfAppDebotBrowserShowAction paramsOfAppDebotBrowserShowAction)
        {
            await this.Request<string>("app_debot_browser.show_action", paramsOfAppDebotBrowserShowAction);
        }

        /// <summary>
        /// Inputs the specified parameters of application debot browser input.
        /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_debot.md#input
        /// </summary>
        /// <param name="paramsOfAppDebotBrowserInput">The parameters of application debot browser input.</param>
        /// <returns></returns>
        public async Task<ResultOfAppDebotBrowserInput> Input(ParamsOfAppDebotBrowserInput paramsOfAppDebotBrowserInput)
        {
            return await this.Request<ResultOfAppDebotBrowserInput>("app_debot_browser.input", paramsOfAppDebotBrowserInput);
        }

        /// <summary>
        /// Gets the signing box.
        /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_debot.md#get_signing_box
        /// </summary>
        /// <returns></returns>
        public async Task<ResultOfAppDebotBrowserGetSigningBox> GetSigningBox()
        {
            return await this.Request<ResultOfAppDebotBrowserGetSigningBox>("app_debot_browser.get_signing_box");
        }

        /// <summary>
        /// Invokes the debot.
        /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_debot.md#invoke_debot
        /// </summary>
        /// <param name="paramsOfAppDebotBrowserInvokeDebot">The parameters of application debot browser invoke debot.</param>
        public async Task InvokeDebot(ParamsOfAppDebotBrowserInvokeDebot  paramsOfAppDebotBrowserInvokeDebot)
        {
            await this.Request<string>("app_debot_browser.invoke_debot", paramsOfAppDebotBrowserInvokeDebot);
        }

        /// <summary>
        /// Sends the specified parameters of application debot browser send.
        /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_debot.md#send-1
        /// </summary>
        /// <param name="paramsOfAppDebotBrowserSend">The parameters of application debot browser send.</param>
        public async Task Send(ParamsOfAppDebotBrowserSend paramsOfAppDebotBrowserSend)
        {
            await this.Request<string>("app_debot_browser.send", paramsOfAppDebotBrowserSend);
        }

        #endregion
    }
}