using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.App;
using Android.Views;
using Android.Widget;
using Fragment = Android.Support.V4.App.Fragment;
using FragmentManager = Android.Support.V4.App.FragmentManager;

namespace ViewPagerTabs.mTabs
{
    class TabsPagerAdapter : FragmentPagerAdapter
    {
        private JavaList<Fragment> fragments; 

        public TabsPagerAdapter(FragmentManager fm,JavaList<Fragment> fragments ) : base(fm)
        {
            this.fragments = fragments;
        }

        public override int Count
        {
            get { return fragments.Size(); }
        }

        public override Fragment GetItem(int position)
        {
            return fragments[position];
        }
    }
}