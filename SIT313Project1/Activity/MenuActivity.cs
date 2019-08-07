using System;
using System.Collections.Generic;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Support.V7.Widget;
using Android.Widget;
using SIT313Project1.Activity;
using SIT313Project1.Adapters;
using SIT313Project1.Modules;

namespace SIT313Project1
{
    [Activity(Label = "MenuActivity", Theme = "@style/AppTheme")]
    public class MenuActivity : Android.App.Activity
    {
        
        private List<Food> foodList;

        private RecyclerView foodRecyclerView;
        private RecyclerView.LayoutManager layoutManager;

        private Button place_order;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.activity_menu);

            // clear shared preferences
            var localOrders = Application.Context.GetSharedPreferences("MyOrders", FileCreationMode.Private);
            var orderEdit = localOrders.Edit();
            orderEdit.Clear().Commit();

            SetupList();
            
            this.foodRecyclerView = FindViewById<RecyclerView>(Resource.Id.recyclerView);

            // create layout manager
            this.layoutManager = new LinearLayoutManager(this);
            this.foodRecyclerView.SetLayoutManager(this.layoutManager);
            AdapterFood adapterFood = new AdapterFood(foodList);
            this.foodRecyclerView.SetAdapter(adapterFood);

            this.place_order = FindViewById<Button>(Resource.Id.place_order_btn);
            this.place_order.Click += (obj, e) =>
            {
                Intent intent = new Intent(this, typeof(OrderActivity));
                this.StartActivity(intent);
            };

        }

        private void SetupList()
        {
            foodList = new List<Food>();
            foodList.Add(new Food(1, "Prawn Dumpling", 10.98, "prawn_dumpling"));
            foodList.Add(new Food(2, "Vegetable Roll", 6.98, "vegetable_roll"));
            foodList.Add(new Food(3, "Vegetable Salad", 7.98, "vegetable_salad"));
            foodList.Add(new Food(4, "Dutch Baby Pancake", 7.98, "pancake"));
            foodList.Add(new Food(5, "Lemon Curd Tart", 8.98, "cheese_tart"));
            foodList.Add(new Food(6, "Chocolate Waffle", 8.98, "chocolate_waffle"));
            foodList.Add(new Food(7, "Vege Burger", .98, "vege_berger"));
            foodList.Add(new Food(8, "Pad Thai", 8.98, "pad_thai"));
            foodList.Add(new Food(9, "Salmon Salad", 15.98, "salmon_salad"));
            foodList.Add(new Food(10, "Mango Pudding", 9.98, "mango_pudding"));
        }
    }
}