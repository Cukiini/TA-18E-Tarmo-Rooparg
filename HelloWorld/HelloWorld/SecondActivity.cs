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

namespace HelloWorld
{
    [Activity(Label = "SecondActivity")]
    public class SecondActivity : Activity
    {

        TextView _textview;
        Button _button;
        EditText _textfield;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.second_layout);
            //Create app here
            _textview = FindViewById<TextView>(Resource.Id.textview1);
            _button = FindViewById<Button>(Resource.Id.button1);
            _textfield = FindViewById<EditText>(Resource.Id.editText1);

            _button.Click += Button_Click;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            _textview.Text = "tekst muutus";
            _textview.Text = _textfield.Text;
        }
    }
}