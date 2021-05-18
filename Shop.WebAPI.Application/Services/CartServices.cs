using AutoMapper;
using DocumentFormat.OpenXml.Office2010.Excel;
using Microsoft.AspNetCore.Http;
using Nest;
using Shop.Domain.Enities;
using Shop.WebAPI.Application.Dto;
using Shop.WebAPI.Application.Interface;
using Shop.WebAPI.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.WebAPI.Application.Services
{
    public class CartServices
    {
        private readonly ShopContext _context;
        private readonly IMapper mapper;

        public CartServices(ShopContext context, IMapper mapper)
        {
            this._context = context;
            this.mapper = mapper;


        }

        public int CartItemsId { get; set; }
        public int ShoppingCartId { get; private set; }

        private ShopContext _db = new ShopContext();
        private int ID;
        public const string CartSessionId = "CartId";

        public void GetCartItems(CartItems cartItem)
        {
            if (_db.ShoppingcartItems.SingleOrDefault(
               c => c.CartID == ShoppingCartId && c.ProductID == ID) == null)
            {
                var results = (from items in _context.Products
                               join shop in _context.ShoppingcartItems
                                    on items.ID equals shop.ProductID
                               select new Cart
                               {

                                   ID = shop.ID,
                                   Name = items.Name,
                                   Path = items.Path,

                                   Quantity = shop.Quantity,

                                   Price = shop.Price,

                               }).ToList();
            }
        }
     //
     //
     //
     //        //    ShoppingCartId = GetCartId();
     //        //    var cartItem = _db.ShoppingcartItems.SingleOrDefault(
     //        //        c => c.CartID == ShoppingCartId && c.ProductID == ID);
     //        //    if (cartItem == null)
     //        //    {
     //        //        cartItem = new CartItem
     //        //        {
     //        //
     //        //            ItemID = Guid.NewGuid().ToString(),
     //        //            ProductID = ID,
     //        //            CartID = ShoppingCartId,
     //        //            //Product = _db.Products.SingleOrDefault(
     //        //                p => p.ID == ID),
     //        //            Quantity = 1,
     //        //        };
     //        //        _db.ShoppingcartItems.Add(cartItem);
     //        //    }
     //        //    else
     //        //    {//if cart items does exist in cart , then add 1 to quantity
     //        //        cartItem.Quantity++;
     //        //    }
     //        //    _db.SaveChanges();
     //    }
     //
     //     void Dispose()
     //    {
     //        if (_db != null)
     //        {
     //            _db.Dispose();
     //            _db = null;
     //        }
     //    }


             List<CartItem> GetCartItems()
            {
                CartItemsId = GetCartId();
                return _db.ShoppingcartItems.Where(
                    c => c.CartID == CartItemsId).ToList();
            }

        private int GetCartId()
        {
            throw new NotImplementedException();
        }
    }

       
    }
    
