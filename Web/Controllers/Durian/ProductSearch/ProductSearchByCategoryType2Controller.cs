﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/19/2020 5:36:25 PM
  From Machine: DESKTOP-KE5CSN3
  Template: sql2x.MVCDurianGenerator.MethodControllerCode
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class ProductSearchByCategoryType2Controller : Controller {

        [HttpGet]
        public ActionResult ProductSearchByCategoryType2Index(System.Guid productCategoryId,System.Boolean onParent) {

            return View(
                "~/Views/Durian/ProductSearch/ProductSearchByCategoryType2Index.cshtml",
                new ProductSearchService().ProductSearchByCategoryType2(productCategoryId,onParent)
                );
        }

    }
}
