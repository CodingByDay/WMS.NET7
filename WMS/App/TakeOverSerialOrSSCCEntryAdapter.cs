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

    class TakeOverSerialOrSSCCEntryAdapter : BaseAdapter
    {
        public List<TakeOverSerialOrSSCCEntryList> sList;
        private Context sContext;
        public TakeOverSerialOrSSCCEntryAdapter(Context context, List<TakeOverSerialOrSSCCEntryList> list)
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
                    row = LayoutInflater.From(sContext).Inflate(Resource.Layout.TakeOverSerialOrSSCCListView, null, false);
                }

                TextView Ident = row.FindViewById<TextView>(Resource.Id.Ident);
                Ident.Text = sList[position].Ident;
                Ident.SetTextColor(Android.Graphics.Color.Black);

                TextView SerialNumber = row.FindViewById<TextView>(Resource.Id.SerialNumber);
                SerialNumber.Text = sList[position].SerialNumber;
                SerialNumber.SetTextColor(Android.Graphics.Color.Black);

                TextView Location = row.FindViewById<TextView>(Resource.Id.Location);
                Location.Text = sList[position].Location;
                Location.SetTextColor(Android.Graphics.Color.Black);
                TextView Qty = row.FindViewById<TextView>(Resource.Id.Qty);
                Qty.Text = sList[position].Qty;
                Qty.SetTextColor(Android.Graphics.Color.Black);


                TextView Filled = row.FindViewById<TextView>(Resource.Id.Filled);
                Filled.Text = sList[position].Filled;
                Filled.SetTextColor(Android.Graphics.Color.Black);

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