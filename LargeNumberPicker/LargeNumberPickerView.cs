using System;
using Android;
using Android.Content;
using Android.Widget;
using Android.Util;
using Android.Views;
using Android.Runtime;
using Android.Graphics;
using System.Collections.Generic;
using System.Linq;

namespace LargeNumberPicker
{
	// Inspiration taken from:
	// http://stackoverflow.com/questions/6958460/android-can-i-increase-the-textsize-for-the-numberpicker-widget/12084420#12084420
	// http://stackoverflow.com/questions/10593022/monodroid-error-when-calling-constructor-of-custom-view-twodscrollview/10603714#10603714

	public class LargeNumberPickerView : NumberPicker
	{
		private int _fontSizeInDip = 18;
		private EditText TextBox;

		public LargeNumberPickerView(Context context, IAttributeSet attrs) : base(context,attrs)
		{
		}

		public LargeNumberPickerView(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		public LargeNumberPickerView(Context context) : base(context)
		{
		}

		public LargeNumberPickerView(Context context, IAttributeSet attrs, int defStyleAttr) : base(context, attrs, defStyleAttr)
		{
		}

		public LargeNumberPickerView(Context context, IAttributeSet attrs, int defStyleAttr, int defStyleRes) : base(context, attrs, defStyleAttr, defStyleRes)
		{
		}

	
		public override void AddView(Android.Views.View child)
		{
			base.AddView(child);
			UpdateView(child);
		}

		public override void AddView(Android.Views.View child, int index)
		{
			base.AddView(child, index);
			UpdateView(child);
		}

		public override void AddView(Android.Views.View child, Android.Views.ViewGroup.LayoutParams @params)
		{
			base.AddView(child, @params);
			UpdateView(child);
		}

		void UpdateView(View view)
		{
			if (view is EditText)
			{
				TextBox = ((EditText)view);
				TextBox.SetTextSize(ComplexUnitType.Dip, _fontSizeInDip);
			}
		}

		public int FontSize
		{
			get
			{
				return _fontSizeInDip;
			}

			set
			{
				_fontSizeInDip = value >= 18 ? value : 18;


				if (TextBox != null)
				{
					TextBox.SetTextSize(ComplexUnitType.Dip, _fontSizeInDip);
				}
			}
		}
	}
}

