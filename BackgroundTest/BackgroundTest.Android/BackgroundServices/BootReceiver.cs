using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace BackgroundTest.Droid.BackgroundServices
{
    public class BootReceiver : BroadcastReceiver
    {
        public override void OnReceive(Context context, Intent intent)
        {
            Intent i = new Intent(context, typeof(MainActivity));
            i.AddFlags(ActivityFlags.NewTask);
            context.StartActivity(i);
        }
    }
}