using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using Newtonsoft.Json;
using SIT313Project1.Adapters;
using SIT313Project1.Modules;

namespace SIT313Project1.Activity
{
    [Activity(Label = "OrderActivity", Theme = "@style/AppTheme")]
    public class OrderActivity : Android.App.Activity
    {
        private List<Order> orders;
        private TextView txt_total_price;
        private RecyclerView orderRecyclerView;
        private RecyclerView.LayoutManager layoutManager;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.activity_order);

            // retrieve orders from shared preferences
            var localOrders = Application.Context.GetSharedPreferences("MyOrders", FileCreationMode.Private);
            var ordersJson = localOrders.GetString("orders", null);
            Console.WriteLine(ordersJson);
            if (ordersJson == null)
            {
                orders = new List<Order>();
            }
            else
            {
                orders = JsonConvert.DeserializeObject<List<Order>>(ordersJson);
            }

            this.orderRecyclerView = FindViewById<RecyclerView>(Resource.Id.order_recyclerView);

            this.layoutManager = new LinearLayoutManager(this);
            this.orderRecyclerView.SetLayoutManager(this.layoutManager);
            AdapterOrder adapterOrder = new AdapterOrder(orders);
            this.orderRecyclerView.SetAdapter(adapterOrder);

            this.txt_total_price = FindViewById<TextView>(Resource.Id.total_price);
            double double_total_price = 0;

            for (int i = 0; i < orders.Count; i++)
            {
                double price = orders[i].price * orders[i].serve;
                double_total_price += price;
            }

            txt_total_price.Text = "$ " + double_total_price;
        }
    }
}