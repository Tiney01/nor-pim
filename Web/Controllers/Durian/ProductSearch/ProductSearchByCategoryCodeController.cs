﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 8/12/2020 7:48:56 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.MVCDurianGenerator.MethodControllerCode
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class ProductSearchByCategoryCodeController : Controller {

        [HttpGet]
        public ActionResult ProductSearchByCategoryCodeIndex(System.String productCategoryCode,System.Boolean onParent) {

            return View(
                "~/Views/Durian/ProductSearch/ProductSearchByCategoryCodeIndex.cshtml",
                new ProductSearchService().ProductSearchByCategoryCode(productCategoryCode,onParent)
                );
        }

    }
}
