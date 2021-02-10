using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {

        List<ProductDetailDto> GetProductDetails();

    }
}

//BURAYA CORE SINIFINI REFERANS ALDIK BUNA CODE REFACTORİNG (KOD İYİLEŞTİRMESİ DENİR)