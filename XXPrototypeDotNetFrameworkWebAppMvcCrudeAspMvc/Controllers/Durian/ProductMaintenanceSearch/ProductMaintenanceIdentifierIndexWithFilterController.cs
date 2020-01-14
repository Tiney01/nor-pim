﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 7:34:14 AM
  Template: sql2x.MVCDurianGenerator.MethodControllerCode
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class ProductMaintenanceIdentifierIndexWithFilterController : Controller {

        [HttpGet]
        public ActionResult ProductMaintenanceIdentifierIndexWithFilterIndex(System.Guid productId) {

            return View(
                "~/Views/Durian/ProductMaintenanceSearch/ProductMaintenanceIdentifierIndexWithFilterIndex.cshtml",
                new ProductMaintenanceSearchService().ProductMaintenanceIdentifierIndexWithFilter(productId)
                );
        }

    }
}