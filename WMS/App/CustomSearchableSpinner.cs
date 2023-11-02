using Android.Content;
using Android.OS;
using Android.Util;
using Android.Views;
using Toptoche.SearchableSpinnerLibrary;
using Java.Lang;
using Java.Util.Jar;
using System;
using System.Threading.Tasks;
using System.Timers;
using Toptoche.SearchableSpinnerLibrary;

public class CustomSearchableSpinner : SearchableSpinner
{

    public static bool isSpinnerDialogOpen = false;

    private Timer timer;

    public CustomSearchableSpinner(Context context) : base(context)
    {
    }
    public CustomSearchableSpinner(Context context, IAttributeSet attrs, int defStyleAttr): base(context, attrs, defStyleAttr)
    {
 
    }
    public CustomSearchableSpinner(Context context, IAttributeSet attrs): base (context, attrs) 
    {

    }

    public override bool OnTouch(View v, MotionEvent motion)
    {
        if(isSpinnerDialogOpen) { return true; } 
        else if(motion.Action == MotionEventActions.Up)
        {
            if(!isSpinnerDialogOpen)
            {
                isSpinnerDialogOpen = true;
                PostDelayed(DefaultDialogValue, 2000);
                return base.OnTouch(v, motion);
            }
        }
        return true;
    }

    Action DefaultDialogValue = new Action(() => {  
        isSpinnerDialogOpen = false;
    });

}