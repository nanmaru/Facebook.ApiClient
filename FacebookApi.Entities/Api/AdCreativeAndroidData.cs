﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp.Deserializers;
using RestSharp.Serializers;

namespace FacebookApi.Entities
{
    /// <summary>
    /// The specification for Android template spec.
    /// <para>https://developers.facebook.com/docs/marketing-api/reference/ad-creative-android-data/</para>
    /// </summary>
    public class AdCreativeAndroidData
    {
        /// <summary>
        /// The name of the Android app, e.g. Electronic Example Android
        /// </summary>
        [DeserializeAs(Name = "app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// A fully qualified package name for intent generation and store linking, e.g. com.electronic
        /// </summary>
        [DeserializeAs(Name = "package")]
        public string Package { get; set; }

        /// <summary>
        /// A custom URL scheme for the Android App, e.g. example-android://electronic/id={{product.retailor_id | urlencode}}
        /// </summary>
        [DeserializeAs(Name = "url")]
        public string Url { get; set; }
    }
}
