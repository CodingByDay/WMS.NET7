﻿using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scanner.App
{

    class TakeoverDocumentAdapter : BaseAdapter
    {
        public List<TakeoverDocument> sList;
        private Context sContext;
        private string friendlySSCC;
        private string friendlySerial;

        public TakeoverDocumentAdapter(Context context, List<TakeoverDocument> list)
        {
            sList = list;
            sContext = context;
        }



        public override int Count
        {
            get
            {
                return sList.Count;
            }
        }

        public override Java.Lang.Object GetItem(int position)
        {
            return null;
        }

        public override long GetItemId(int position)
        {
            return position;
        }
        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View row = convertView;
            try
            {
                if (row == null)
                {
                    row = LayoutInflater.From(sContext).Inflate(Resource.Layout.TakeoverDocument, null, false);
                }

                TextView Ident = row.FindViewById<TextView>(Resource.Id.ident);
                Ident.Text = sList[position].ident;
                Ident.SetTextColor(Android.Graphics.Color.Black);

                TextView sscc = row.FindViewById<TextView>(Resource.Id.sscc);
                friendlySSCC = HelpfulMethods.lastReturn(sList[position].sscc, 5);
                sscc.Text = friendlySSCC;
                sscc.SetTextColor(Android.Graphics.Color.Black);

                TextView serial = row.FindViewById<TextView>(Resource.Id.serial);
                friendlySerial = HelpfulMethods.lastReturn(sList[position].serial, 5);

                serial.Text = friendlySerial;;
                serial.SetTextColor(Android.Graphics.Color.Black);

                TextView Qty = row.FindViewById<TextView>(Resource.Id.quantity);
                Qty.Text = sList[position].quantity;
                Qty.SetTextColor(Android.Graphics.Color.Black);


                TextView Location = row.FindViewById<TextView>(Resource.Id.location);
                Location.Text = sList[position].location;
                Location.SetTextColor(Android.Graphics.Color.Black);

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
            finally { }

            return row;

        }




    }
}