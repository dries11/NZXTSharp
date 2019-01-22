﻿using System;
using System.Collections.Generic;
using System.Text;

using RGB.NET.Core;

namespace RGB.NET.Devices.NZXT {
    public class NZXTCoolerRGBDeviceInfo : NZXTRGBDeviceInfo {

        internal NZXTCoolerRGBDeviceInfo(int deviceIndex, _NZXTDeviceInfo nativeInfo)
            : base(deviceIndex, RGBDeviceType.Mousepad, nativeInfo) { }
    }
}
