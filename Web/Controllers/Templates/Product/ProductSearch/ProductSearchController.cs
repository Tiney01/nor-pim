﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/28/2020 6:22:36 AM
  From Machine: DESKTOP-9A2DH39
  Template: sql2x.TemplateWithDurianByTypescriptGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;
using System.Collections.Generic;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public partial class ProductSearchController : Controller {

        [HttpGet]
        public ActionResult ProductSearchIndex(System.Guid productCategoryId,System.Boolean onParent) {

            List<ProductSearchByCategoryContract> productSearch = 
                new ProductSearchService().ProductSearchByCategory(productCategoryId,onParent);

            return View(
                "~/Views/Templates/Product/ProductSearch/ProductSearchIndex.cshtml",
                productSearch
                );
        }

    }
}
