﻿using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Services
{
    //public class InMemoryRestaurentData : IRestaurantData
    //{
    //    public InMemoryRestaurentData()
    //    {
    //        _restaurants = new List<Restaurant>
    //        {
    //            new Restaurant{Id =1, Name = "Scotts pizza place" },
    //            new Restaurant{Id =2, Name = "Lucky Biriyani" },
    //            new Restaurant{Id =3, Name = "Swagath Grand" }
    //        };
    //    }

    //    public IEnumerable<Restaurant> GetAll()
    //    {
    //        return _restaurants.OrderBy(r => r.Name);
    //    }

    //    public Restaurant Get(int id)
    //    {
    //        return _restaurants.FirstOrDefault(r => r.Id == id);
    //    }

    //    public Restaurant Add(Restaurant restaurant)
    //    {
    //        restaurant.Id = _restaurants.Max(r => r.Id) + 1;
    //        _restaurants.Add(restaurant);
    //        return restaurant;
    //    }

    //    List<Restaurant> _restaurants;

    //}
}
