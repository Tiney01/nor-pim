﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/19/2020 5:30:33 PM
  From Machine: DESKTOP-KE5CSN3
  Template: sql2x.MVCDurianGenerator.MethodControllerCode
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class ProductMaintenanceDocumentationIndexWithFilterController : Controller {

        [HttpGet]
        public ActionResult ProductMaintenanceDocumentationIndexWithFilterIndex(System.Guid productId) {

            return View(
                "~/Views/Durian/ProductMaintenanceSearch/ProductMaintenanceDocumentationIndexWithFilterIndex.cshtml",
                new ProductMaintenanceSearchService().ProductMaintenanceDocumentationIndexWithFilter(productId)
                );
        }

    }
}
