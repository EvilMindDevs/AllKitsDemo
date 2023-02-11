﻿using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Nearby.Discovery
{
    public class ScanOption : JavaObjectWrapper
    {
        
        public ScanOption(AndroidJavaObject javaObject) : base(javaObject) { }

        public Policy Policy => CallAsWrapper<Policy>("getPolicy");

        public class Builder : JavaObjectWrapper
        {
            
            public Builder(AndroidJavaObject javaObject) : base(javaObject) { }

            public Builder() : base("com.huawei.hms.nearby.discovery.ScanOption$Builder") { }
            public ScanOption Build() => CallAsWrapper<ScanOption>("build");
            public Builder SetPolicy(Policy policy) => CallAsWrapper<Builder>("setPolicy", policy);         }
    }
}