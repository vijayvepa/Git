using System;
using Android.App;
using Android.OS;
using Android.Widget;

namespace CoursesAndroid
{
    [Activity(Label = "Courses", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private Button ButtonPrev { get; set; }

        private Button ButtonNext { get; set; }

        private TextView TextTitle { get; set; }

        ImageView ImageCourse { get; set; }

        TextView TextDescription { get; set; }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            ButtonPrev = FindViewById<Button>(Resource.Id.buttonPrev);
            ButtonNext = FindViewById<Button>(Resource.Id.buttonNext);
            TextTitle = FindViewById<TextView>(Resource.Id.textTitle);
            ImageCourse = FindViewById<ImageView>(Resource.Id.imageCourse);
            TextDescription = FindViewById<TextView>(Resource.Id.textDescription);

            ButtonPrev.Click += ButtonPrev_Click;
            ButtonNext.Click += ButtonNext_Click;
        }

        private void ButtonPrev_Click(object sender, EventArgs e)
        {
            TextTitle.Text = "Prev Clicked";
            TextDescription.Text = "The description that appears when prev is clicked.";
            ImageCourse.SetImageResource(Resource.Drawable.ps_top_card_01);
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            TextTitle.Text = "Next Clicked";
            TextDescription.Text = "The description that appears when next is clicked.";
            ImageCourse.SetImageResource(Resource.Drawable.ps_top_card_02);
        }
    }
}