using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Controls;
using static Android.App.ActionBar;

namespace Scanner.App
{
    //    public static class SignatureClass
    //    {
    //        private static Dialog popupDialog;
    //        private static SignaturePadView view;
    //        private static Button btnConfirm;
    //        //#nullable enable
    //        //        private static Bitmap? signature;
    //        //#nullable disable
    //        public static Bitmap signature;
    //        /// <summary>
    //        ///  A method to sign the document 
    //        /// </summary>
    //        /// <param name="where"></param>
    //        /// <returns></returns>
    //        public static void SignHere(Context where)
    //        {
    //            popupDialog = new Dialog(where);
    //            popupDialog.SetContentView(Resource.Layout.SignatureView);
    //            popupDialog.Window.SetSoftInputMode(SoftInput.AdjustResize);
    //            popupDialog.Show();

    //            popupDialog.Window.SetLayout(LayoutParams.MatchParent, LayoutParams.WrapContent);
    //            popupDialog.Window.SetBackgroundDrawableResource(Android.Resource.Color.BackgroundLight);

    //            // Access Popup layout fields like below
    //            view = popupDialog.FindViewById<SignaturePadView>(Resource.Id.signature);
    //            btnConfirm = popupDialog.FindViewById<Button>(Resource.Id.confirm);
    //            btnConfirm.Click += (e, ev) => { Confirm(where); };

    //            await popupDialog.res



    //        }

    //        private static void Confirm(Context where)
    //        {

    //            Toast.MakeText(where, "Podpis poslan na server..", ToastLength.Long).Show();
    //            signature = view.GetImage(); // Get the signature.


    //        }







    //    }
    //}
}