﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 7:30:04 PM
  Template: sql2x.MVCDurianGenerator.MethodControllerCode
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class ProductSearchByCategoryType4Controller : Controller {

        [HttpGet]
        public ActionResult ProductSearchByCategoryType4Index(System.Guid productCategoryId,System.Boolean onParent) {

            return View(
                "~/Views/Durian/ProductSearch/ProductSearchByCategoryType4Index.cshtml",
                new ProductSearchService().ProductSearchByCategoryType4(productCategoryId,onParent)
                );
        }

    }
}
