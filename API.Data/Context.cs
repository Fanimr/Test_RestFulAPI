using API.Domain.Entities;
using System;
using System.Collections.Generic;

namespace API.Data
{
    public sealed class Context
    {
        private static Context _instance = null;

        /// <summary>
        /// 
        /// </summary>
        public List<ProductEntity> _products { get; set; }

        public Context()
        {
            _products = new List<ProductEntity>();

            _products.Add(
                new ProductEntity
                {
                    Id = Guid.NewGuid(),
                    Name = "Galletas de nuez",
                    Description = "Galleta con nuez 150 gr",
                    Category = "Galletas",
                    Price = 12,
                    Amount = 10
                }
            );

            _products.Add(
                new ProductEntity
                {
                    Id = Guid.NewGuid(),
                    Name = "Refresco de manzana",
                    Description = "Refresco de manzana 500 ml",
                    Category = "Bebidas",
                    Price = 15,
                    Amount = 10
                }
            );

            _products.Add(
                new ProductEntity
                {
                    Id = Guid.NewGuid(),
                    Name = "Papas con sal",
                    Description = "Papas con sal 150 gr",
                    Category = "Botana",
                    Price = 15,
                    Amount = 10
                }
            );
        }

        public static Context Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Context();
                }
                return _instance;
            }
        }
    }
}
