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
using SIT313Project1.Modules;

namespace SIT313Project1.Adapters
{
    public class AdapterOrder : RecyclerView.Adapter
    {
        private List<Order> orders;

        public AdapterOrder(List<Order> orders)
        {
            this.orders = orders;
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            OrderRecyclerViewHolder recyclerViewHolder = holder as OrderRecyclerViewHolder;
            Order order = orders[position];
            recyclerViewHolder.order_food_name.Text = order.food;
            recyclerViewHolder.order_food_price.Text = "$ " + order.price;
            recyclerViewHolder.order_food_quantity.Text = order.serve.ToString();
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View view = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.list_order, parent, false);
            return new OrderRecyclerViewHolder(view);
        }

        public override int ItemCount
        {
            get { return orders.Count; }
        }
    }

    public class OrderRecyclerViewHolder : RecyclerView.ViewHolder
    {
        public TextView order_food_name;
        public TextView order_food_price;
        public TextView order_food_quantity;

        public OrderRecyclerViewHolder(View itemView) : base(itemView)
        {
           this.order_food_name = itemView.FindViewById<TextView>(Resource.Id.order_food_name);
           this.order_food_price = itemView.FindViewById<TextView>(Resource.Id.order_food_price);
           this.order_food_quantity = itemView.FindViewById<TextView>(Resource.Id.order_food_quantity);
        }
    }
}