using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InmNow.API.ViewModels;

namespace InmNow.API.Factories
{
    //IVSR: Abstract factory using common interface
    public class ViewModelFactory<T>
    {
        private ViewModelFactory() { }

        static readonly Dictionary<int, Func<T>> _dict = new Dictionary<int, Func<T>>();

        public static T Create(int id)
        {
            Func<T> constructor = null;
            if (_dict.TryGetValue(id, out constructor))
                return constructor();

            throw new ArgumentException("No type registered for this id");
        }

        public static void Register(int id, Func<T> ctor)
        {
            _dict.Add(id, ctor);
        }
    }
}