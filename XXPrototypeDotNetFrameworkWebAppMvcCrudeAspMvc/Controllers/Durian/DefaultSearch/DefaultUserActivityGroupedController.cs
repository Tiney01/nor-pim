﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/23/2020 12:02:03 PM
  Template: sql2x.MVCDurianGenerator.MethodControllerCode
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class DefaultUserActivityGroupedController : Controller {

        [HttpGet]
        public ActionResult DefaultUserActivityGroupedIndex() {

            return View(
                "~/Views/Durian/DefaultSearch/DefaultUserActivityGroupedIndex.cshtml",
                new DefaultSearchService().DefaultUserActivityGrouped()
                );
        }

    }
}
