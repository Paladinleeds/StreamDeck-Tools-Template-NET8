using BarRaider.SdTools;
using BarRaider.SdTools.Payloads;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamDeckTools_Template1
{
    [PluginActionId("com.developer.csharptemplate.pluginactiondial")]
    public class PluginActionDial : EncoderBase
    {
        private class PluginSettings
        {
            public static PluginSettings CreateDefaultSettings()
            {
                PluginSettings instance = new PluginSettings();
                instance.OutputFileName = String.Empty;
                instance.InputString = String.Empty;
                return instance;
            }

            [FilenameProperty]
            [JsonProperty(PropertyName = "outputFileName")]
            public string OutputFileName { get; set; }

            [JsonProperty(PropertyName = "inputString")]
            public string InputString { get; set; }
        }

        #region Private Members

        private PluginSettings settings;

        #endregion
        public PluginActionDial(SDConnection connection, InitialPayload payload) : base(connection, payload)
        {
            throw new NotImplementedException();
        }

        private void UpdateTitle()
        {
            throw new NotImplementedException();
        }

        public override void DialRotate(DialRotatePayload payload)
        {
            throw new NotImplementedException();
        }

        public override void DialDown(DialPayload payload)
        {
            throw new NotImplementedException();
        }

        public override void DialUp(DialPayload payload)
        {
            throw new NotImplementedException();
        }

        public override void TouchPress(TouchpadPressPayload payload)
        {
            throw new NotImplementedException();
        }

        public override void ReceivedSettings(ReceivedSettingsPayload payload)
        {
            throw new NotImplementedException();
        }

        public override void ReceivedGlobalSettings(ReceivedGlobalSettingsPayload payload)
        {
            throw new NotImplementedException();
        }

        public override void OnTick()
        {
            throw new NotImplementedException();
        }

        public override void Dispose()
        {
            throw new NotImplementedException();
        }

        // Additional event handling methods can be added as needed

        // Implement any other necessary methods or properties

        // Define the settings model class if not already defined
        public class MySettingsModel
        {
            public string ImagePath { get; set; }
            public string TargetDevice { get; set; }
            // Add any other settings properties here
        }
    }
}