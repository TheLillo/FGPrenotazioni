﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGPrenotazioni.Models.Products
{
    [Serializable]
    public class VideoProduct : Product
    {
        private VideoCategoryEnum _category;

        private VideoProduct() { }
        public VideoProduct(string _productCode, string _description, double _sellPrice, double _rentPrice, bool _isNew, bool _isAvailable, string _brand, VideoCategoryEnum category) : base(_productCode, _description, _sellPrice, _rentPrice, _isNew, _isAvailable, _brand)
        {
            _category = category;
        }

        public override string Category
        {
            get
            {
                return _category.ToString();
            }
            set
            {
                Enum.TryParse(value, out _category);
            }
        }

        public override string GetKind()
        {
            return "Video";
        }

        public override string toFullString()
        {
            return ProductCode + "; " + Description + "; " + SellPrice + "€ sp - " + RentPrice + "€ rp; isNew = " + IsNew.ToString() + "; Marca:" + Brand + "; " + Category.ToString();
        }
    }
}
