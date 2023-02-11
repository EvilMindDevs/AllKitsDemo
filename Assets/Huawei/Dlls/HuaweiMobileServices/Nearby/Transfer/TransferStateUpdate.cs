﻿using UnityEngine;
using System.Collections;
using HuaweiMobileServices.Utils;

//com.huawei.hms.nearby.transfer.TransferStateUpdate
namespace HuaweiMobileServices.Nearby.Transfer
{
    public class TransferStateUpdate : JavaObjectWrapper
    {
        
        public TransferStateUpdate(AndroidJavaObject javaObject) : base(javaObject) { }

        public long BytesTransferred  => Call<long>("getBytesTransferred");
        public long DataId => Call<long>("getDataId");
        public int TransferStatus => Call<int>("getStatus");
        public long TotalBytes => Call<long>("getTotalBytes");

        public static class Status
        {
            private static AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.huawei.hms.nearby.transfer.TransferStateUpdate$Status");
            public static int TRANSFER_STATE_CANCELED  => androidJavaClass.GetStatic<int>("TRANSFER_STATE_CANCELED");
            public static int TRANSFER_STATE_FAILURE => androidJavaClass.GetStatic<int>("TRANSFER_STATE_FAILURE");
            public static int TRANSFER_STATE_IN_PROGRESS => androidJavaClass.GetStatic<int>("TRANSFER_STATE_IN_PROGRESS");
            public static int TRANSFER_STATE_SUCCESS => androidJavaClass.GetStatic<int>("TRANSFER_STATE_SUCCESS");
        }
    }
}