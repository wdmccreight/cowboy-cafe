﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests
{
    class MockOrderItem : IOrderItem
    {
        public double Price { get; set; }

        public List<string> SpecialInstructions { get; set; }
    }


    public class OrderTests
    {
        //Adding something to the order should have it appear in the Items property

        [Fact]
        public void AddedOrderItemsAppearInItemsProperty()
        {
            var order = new Order();
            var item = new MockOrderItem();
            order.Add(item);
            Assert.Contains(item, order.Items);
        }

        [Fact]
        public void RemovedOrderItemsDoeNotAppearInItemsProperty()
        {
            var order = new Order();
            var item = new MockOrderItem();
            order.Add(item);
            order.Remove(item);
            Assert.DoesNotContain(item, order.Items);
        }

        [Theory]
        [InlineData(new double[] {0})]
        [InlineData(new double[] {10, 15, 18})]
        [InlineData(new double[] {20, -4, 3.6, 8})]
        [InlineData(new double[] {-100, -5})]
        public void SubtotalShouldBeTheSumOfOrderItemPrices(double[] prices)
        {
            var order = new Order();
            double total = 0;
            foreach (var price in prices)
            {
                total += price;
                order.Add(new MockOrderItem() { Price = price });
            }
            Assert.Equal(total, order.Subtotal);
        }

        [Fact]
        public void ItemsShouldContainOnlyAddedItems()
        {
            var items = new IOrderItem[]
            {
                new MockOrderItem() { Price = 3},
                new MockOrderItem() { Price = 4},
                new MockOrderItem() { Price = 7}
            };
            var order = new Order();
            foreach(var item in items)
            {
                order.Add(item);
            }
            Assert.Equal(items.Length, order.Items.Count());
            foreach(var item in items)
            {
                Assert.Contains(item, order.Items);
            }
        }
        //Removing something to the order should have it disappear from the Items property

        //Get the price - needs to be right
        //(for the items we have added)
    }
}
