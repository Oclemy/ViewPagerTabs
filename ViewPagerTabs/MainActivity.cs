using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Support.V4.App;
using Android.Support.V4.View;
using ViewPagerTabs.mTabs;
using Fragment = Android.Support.V4.App.Fragment;
using FragmentManager = Android.Support.V4.App.FragmentManager;
using FragmentTransaction = Android.App.FragmentTransaction;

namespace ViewPagerTabs
{
    [Activity(Label = "ViewPagerTabs", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : FragmentActivity,ActionBar.ITabListener
    {
        private ActionBar ab;
        private ViewPager vp;
        private TabsPagerAdapter adapter;
        private FragmentManager fm;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            //ACTION BAR
            ab = this.ActionBar;
            ab.NavigationMode = ActionBarNavigationMode.Tabs;
            ab.SetDisplayShowTitleEnabled(true);
            
            //FRAGMENT MANAGER
            fm = this.SupportFragmentManager;

            //ADAPTER
            adapter=new TabsPagerAdapter(fm,getPages());

            //VIEWPAGER
            vp = FindViewById<ViewPager>(Resource.Id.pager);
            vp.PageSelected += vp_PageSelected;


            //SET ADAPTER
            vp.Adapter = adapter;

            //ADD TABS
            addTabs();
        }

        void vp_PageSelected(object sender, ViewPager.PageSelectedEventArgs e)
        {
            ab.SetSelectedNavigationItem(e.Position);
        }

        //ADD FRAGMENTS
        private JavaList<Fragment> getPages()
        {
            JavaList<Fragment> pages=new JavaList<Fragment>();
            pages.Add(new CrimeFragment());
            pages.Add(new DramaFragment());
            pages.Add(new DocumentaryFragment());

            return pages;
        }

        //ADD TABS
        private void addTabs()
        {
            ActionBar.Tab t = ab.NewTab().SetText("Crime").SetIcon(Resource.Drawable.mango).SetTabListener(this);
            ab.AddTab(t);
            t = ab.NewTab().SetText("Drama").SetIcon(Resource.Drawable.oranges).SetTabListener(this);
            ab.AddTab(t);
            t = ab.NewTab().SetText("Documentary").SetIcon(Resource.Drawable.coconut).SetTabListener(this);
            ab.AddTab(t);

        }

        public void OnTabReselected(ActionBar.Tab tab, FragmentTransaction ft)
        {
            
        }

        public void OnTabSelected(ActionBar.Tab tab, FragmentTransaction ft)
        {
            vp.CurrentItem = tab.Position;
        }

        public void OnTabUnselected(ActionBar.Tab tab, FragmentTransaction ft)
        {
           
        }
    }
}

