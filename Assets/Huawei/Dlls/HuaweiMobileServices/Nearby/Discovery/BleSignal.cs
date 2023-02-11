﻿using HuaweiMobileServices.Utils;

namespace HuaweiMobileServices.Nearby.Discovery
{
    public class BleSignal : JavaObjectWrapper
    {
        
        public BleSignal() : base("com.huawei.hms.nearby.discovery.BleSignal") { }
        public int Rssi => Call<int>("getRssi");
        public int TxPower => Call<int>("getTxPower");
    }
}
