﻿using HuaweiMobileServices.Utils;
using System;
using UnityEngine;

namespace HuaweiMobileServices.Nearby.Discovery
{

    public class ConnectCallback : JavaObjectWrapper
    {
        private class ConnectCallbackInterface : AndroidJavaProxy
        {
            private readonly IConnectCallBack mListener;
            public ConnectCallbackInterface(IConnectCallBack listener) : base("org.m0skit0.android.hms.unity.nearby.NearbyListener")
            {
                mListener = listener;
            }

            public void onEstablish(string p0, AndroidJavaObject p1)
            {
                this.CallOnMainThread(() => { mListener.onEstablish(p0, p1.AsWrapper<ConnectInfo>()); });
            }

            public void onResult(string p0, AndroidJavaObject p1)
            {
                this.CallOnMainThread(() => { mListener.onResult(p0, p1.AsWrapper<ConnectResult>()); });
            }

            public void onDisconnected(string p0)
            {
                this.CallOnMainThread(() => { mListener.onDisconnected(p0); });
            }

        }

        public ConnectCallback(IConnectCallBack listener)
            : base("org.m0skit0.android.hms.unity.nearby.NearbyListenerWrapper", new ConnectCallbackInterface(listener)) { }

    }
}
