﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/19/2020 5:31:51 PM
  From Machine: DESKTOP-KE5CSN3
  Template: sql2x.MVCDurianGenerator.MethodControllerCode
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class DefaultTestOverviewController : Controller {

        [HttpGet]
        public ActionResult DefaultTestOverviewIndex(System.String commandName) {

            return View(
                "~/Views/Durian/DefaultSearch/DefaultTestOverviewIndex.cshtml",
                new DefaultSearchService().DefaultTestOverview(commandName)
                );
        }

    }
}
