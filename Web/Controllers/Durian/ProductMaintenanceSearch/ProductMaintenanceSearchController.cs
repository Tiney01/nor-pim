﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/11/2020 11:33:05 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.GenerateDurian.DurianController
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc {
    public class ProductMaintenanceSearchController : Controller {

        [HttpGet]
        public ActionResult ProductMaintenanceSearchIndex() {

            return View(
                "~/Views/Durian/ProductMaintenanceSearch/ProductMaintenanceSearch.cshtml"
                );
        }

    }
}