using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;

using LargeNumberPicker;

namespace Sample
{
	[Activity(Label = "Sample", MainLauncher = true, Icon = "@mipmap/icon", Theme = "@style/AppTheme")]
	public class MainActivity : AppCompatActivity
	{
		int count = 1;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button>(Resource.Id.myButton);

			button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };

			var lnp = FindViewById<LargeNumberPickerView>(Resource.Id.largenumberpicker);
			lnp.MinValue = 1;
			lnp.MaxValue = 20;
			lnp.FontSize = 22;

			var np = FindViewById<NumberPicker>(Resource.Id.numberpicker);
			np.MinValue = 1;
			np.MaxValue = 20;
		}
	}
}


