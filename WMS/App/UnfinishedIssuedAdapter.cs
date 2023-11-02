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
    class UnfinishedIssuedAdapter : BaseAdapter
    {
        public List<UnfinishedIssuedList> sList;
        private Context sContext;
        public UnfinishedIssuedAdapter(Context context, List<UnfinishedIssuedList> list)
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
                    row = LayoutInflater.From(sContext).Inflate(Resource.Layout.UnfinishedIssued, null, false);
                }

                TextView Document = row.FindViewById<TextView>(Resource.Id.Document);
                Document.Text = sList[position].Document;
                Document.SetTextColor(Android.Graphics.Color.Black);

                TextView Orderer = row.FindViewById<TextView>(Resource.Id.Orderer);
                Orderer.Text = sList[position].Orderer;
                Orderer.SetTextColor(Android.Graphics.Color.Black);
                TextView Date = row.FindViewById<TextView>(Resource.Id.Date);
                Date.Text = sList[position].Date;
                Date.SetTextColor(Android.Graphics.Color.Black);

                TextView NumberOfPositions = row.FindViewById<TextView>(Resource.Id.NumberOfPositions);
                NumberOfPositions.Text = sList[position].NumberOfPositions;
                NumberOfPositions.SetTextColor(Android.Graphics.Color.Black);


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