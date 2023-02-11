﻿namespace HuaweiMobileServices.Id
{
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    // Wrapper for com.huawei.hms.support.api.entity.auth.Scope
    public class Scope : JavaObjectWrapper
    {

        public Scope() : base("com.huawei.hms.support.api.entity.auth.Scope") { }

        public Scope(string uri) : base("com.huawei.hms.support.api.entity.auth.Scope", uri.AsJavaString()) { }

        
        public Scope(AndroidJavaObject javaObject) : base(javaObject) { }

    }

}