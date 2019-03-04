using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace React.Native.Traveling.RNReactNativeTraveling
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNReactNativeTravelingModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNReactNativeTravelingModule"/>.
        /// </summary>
        internal RNReactNativeTravelingModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNReactNativeTraveling";
            }
        }
    }
}
