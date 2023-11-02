using Android.Content;
using Android.Net;
using Android.Runtime;
using Android.Views;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Microsoft.AppCenter.Distribute;
using Uri = System.Uri;

namespace WMS
{
    [Activity(Label = "@string/app_name", MainLauncher = true)]
    public class MainActivity : Activity
    {
        private Dialog popupDialog;
        public static bool isValid;
        private EditText Password;
        public static ProgressBar progressBar1;
        private Button ok;
        private EditText rootURL;
        private EditText ID;
        private ImageView img;
        private TextView deviceURL;
 
        private Button btnOkRestart;
        public object MenuInflaterFinal { get; private set; }

        // Internet connection method.
        public bool IsOnline()
        {
            var cm = (ConnectivityManager)GetSystemService(ConnectivityService);
            return cm.ActiveNetworkInfo == null ? false : cm.ActiveNetworkInfo.IsConnected;
        }


        private void BtnOkRestart_Click(object sender, EventArgs e)
        {
            var stop = true;
        }

        private void ProcessRegistration()
        {

            //var id = settings.ID.ToString();
            string result;



           
        }




        protected override void OnPause()
        {
            base.OnPause();
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            Distribute.SetEnabledAsync(true);
            AppCenter.Start("ec2ca4ce-9e86-4620-9e90-6ecc5cda0e0e",
                   typeof(Analytics), typeof(Crashes), typeof(Distribute));

            Crashes.NotifyUserConfirmation(UserConfirmation.AlwaysSend);

            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_main);
            Password = FindViewById<EditText>(Resource.Id.tbPassword);
            Password.InputType = Android.Text.InputTypes.NumberVariationPassword |
                          Android.Text.InputTypes.ClassNumber;
            progressBar1 = FindViewById<ProgressBar>(Resource.Id.progressBar1);
            img = FindViewById<ImageView>(Resource.Id.imglogo);
    

            Button btnRegistrationEvent = FindViewById<Button>(Resource.Id.btnRegistrationClick);
            btnRegistrationEvent.Clickable = true;
            btnRegistrationEvent.Enabled = true;
            btnRegistrationEvent.Click += BtnRegistrationEvent_Click;

        }

     

    
        public override bool DispatchKeyEvent(Android.Views.KeyEvent e)
        {
            if (e.KeyCode == Keycode.Enter) { BtnRegistrationEvent_Click(this, null); }
            return base.DispatchKeyEvent(e);
        }
      
      

        private void BtnOk_Click(object sender, EventArgs e)
        {
            Distribute.NotifyUpdateAction(UpdateAction.Update);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Resource.Id.action_setting1:
                    {
                        Toast.MakeText(this, "Testing settings", ToastLength.Long).Show();                                          
                        return true;
                    }

            }

            return base.OnOptionsItemSelected(item);
        }
        private void Listener_Click(object sender, EventArgs e)
        {
  
      
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
           MenuInflater.Inflate(Resource.Layout.popup_action, menu);
            return base.OnCreateOptionsMenu(menu);
        }
        /// <summary>
        /// First navigation event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRegistrationEvent_Click(object sender, System.EventArgs e)
        {
            progressBar1.Visibility = ViewStates.Visible;
            ProcessRegistration();
        }
        public override bool OnKeyDown(Keycode keyCode, KeyEvent e)
        {
            switch (keyCode)
            {
                // in smart-phone
                case Keycode.Enter:
                    BtnRegistrationEvent_Click(this, null);
                    break;
                    // return true;
            }
            return base.OnKeyDown(keyCode, e);
        }
    
    
}
}