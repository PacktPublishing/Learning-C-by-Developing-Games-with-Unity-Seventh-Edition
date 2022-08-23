using System;
using Unity.Services.Core.Configuration.Editor;
using Unity.Services.Core.Internal;
using UnityEditor.Build;

namespace Unity.Services.Core.Editor
{
    class CloudEnvironmentConfigProvider : IConfigurationProvider
    {
        const string k_CloudEnvironmentArg = "-cloudEnvironment";
        const string k_CloudEnvironmentKey = "com.unity.services.core.cloud-environment";

        int IOrderedCallback.callbackOrder { get; }

        void IConfigurationProvider.OnBuildingConfiguration(ConfigurationBuilder builder)
        {
            SetCloudEnvironment(builder, GetCloudEnvironment(Environment.GetCommandLineArgs()));
        }

        internal string GetCloudEnvironment(string[] commandLineArgs)
        {
            try
            {
                var cloudEnvironmentIndex = Array.IndexOf(commandLineArgs, k_CloudEnvironmentArg);

                if (cloudEnvironmentIndex >= 0 && cloudEnvironmentIndex <= commandLineArgs.Length - 2)
                {
                    return commandLineArgs[cloudEnvironmentIndex + 1];
                }
            }
            catch (Exception e)
            {
                CoreLogger.LogVerbose(e);
            }

            return null;
        }

        internal void SetCloudEnvironment(ConfigurationBuilder builder, string cloudEnvironment)
        {
            if (cloudEnvironment != null)
            {
                builder?.SetString(k_CloudEnvironmentKey, cloudEnvironment, true);
            }
        }
    }
}
