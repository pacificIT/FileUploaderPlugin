﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Plugin.FileUploader
{
    public interface ICountProgressListener
    {
        void OnProgress(long bytesWritten, long contentLength);
    }
}