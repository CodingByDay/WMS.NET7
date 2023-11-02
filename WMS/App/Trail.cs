﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.IO;

namespace Scanner.App
{
    [Serializable]
    public class Trail: Java.Lang.Object, Java.IO.ISerializable
    {
        public string Ident { get; set; }

        public string Location { get; set; }

        public string Qty{ get; set; }

        public string Name { get; set; }


        public string Key { get; set; }


        public int No { get; set; }

        public int originalIndex { get; set; }


        public  Dictionary<string, double> locationQty { get; set; } = new Dictionary<string, double>();

        // Constructor for deserialization
        public Trail(SerializationInfo info, StreamingContext context)
        {
            Ident = info.GetString("Ident");
            Location = info.GetString("Location");
            Qty = info.GetString("Qty");
            Name = info.GetString("Name");
            Key = info.GetString("Key");
            No = info.GetInt32("No");
            locationQty = (Dictionary<string, double>)info.GetValue("locationQty", typeof(Dictionary<string, double>));
        }

        // Default constructor
        public Trail()
        {
        }

        // Method to perform serialization
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Ident", Ident);
            info.AddValue("Location", Location);
            info.AddValue("Qty", Qty);
            info.AddValue("Name", Name);
            info.AddValue("Key", Key);
            info.AddValue("No", No);
            info.AddValue("locationQty", locationQty, typeof(Dictionary<string, double>));
        }

        // Helper method to serialize an object to a byte array
        public static byte[] Serialize(object obj)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(memoryStream, obj);
                return memoryStream.ToArray();
            }
        }

        // Helper method to deserialize a byte array to an object
        public static T Deserialize<T>(byte[] data)
        {
            using (MemoryStream memoryStream = new MemoryStream(data))
            {
                IFormatter formatter = new BinaryFormatter();
                return (T)formatter.Deserialize(memoryStream);
            }
        }

    }
}