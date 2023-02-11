﻿using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.CloudDB
{
    public class CloudDBZoneObjectList :JavaObjectWrapper
    {
        
        public CloudDBZoneObjectList() : base("com.huawei.agconnect.cloud.database.CloudDBZoneObjectList") { }

        
        public CloudDBZoneObjectList(AndroidJavaObject javaObject) : base(javaObject) { }

        public int Size => Call<int>("size"); 

        public CloudDBZoneObject Get(int index) => CallAsWrapper<CloudDBZoneObject>("get", index); 
        public CloudDBZoneObject Next() => CallAsWrapper<CloudDBZoneObject>("next");
        public bool HasNext() => Call<bool>("hasNext");
    }
    
    public class CloudDBZoneObjectList<T> : CloudDBZoneObjectList where T : ICloudDBZoneObject, new()
    {
        
        public CloudDBZoneObjectList(AndroidJavaObject javaObject) : base(javaObject) { }

        public int Size => Call<int>("size"); 

        public T Get(int arg0) 
        {
            T t = new T();
            t.SetObj(base.Get(arg0).JavaObject);
            return t;
        }

        public T Next()
        {
            T t = new T();
            t.SetObj(base.Next().JavaObject);
            return t;
        }

        public bool HasNext() => Call<bool>("hasNext"); 
    }
}
