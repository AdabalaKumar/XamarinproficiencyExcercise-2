using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Exercises2
{
	public partial class Passwordkata : ContentPage
	{
		public Passwordkata ()
		{
			InitializeComponent ();
			BindingContext =new PasswordViewModel();
		}
	}
}

