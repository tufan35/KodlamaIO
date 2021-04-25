using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Business
{

    //Business Katmanında yazılan iş kurallarını coree katmanına aldık 
    //yazılan iş kurallarını ıresult şeklinde liste halinde tutaar işlem başarısız ise kaydeder
   public class BusinessRules
    {
        public static IResult Run( params IResult[] logics)
        {
            foreach (var logic in logics)
            {
                if (!logic.Success)
                {
                    return logic;
                }
            }
            return null;
        }

    }
}
