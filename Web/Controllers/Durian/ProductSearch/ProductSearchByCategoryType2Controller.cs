﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 6:03:10 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.MVCDurianGenerator.MethodControllerCode
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class ProductSearchByCategoryType2Controller : Controller {

        [HttpGet]
        public ActionResult ProductSearchByCategoryType2Index(System.Guid productCategoryId, bool onParent) {

            return View(
                "~/Views/Durian/ProductSearch/ProductSearchByCategoryType2Index.cshtml",
                new ProductSearchService().ProductSearchByCategoryType2(productCategoryId, onParent)
                );
        }

    }
}
