﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 7:34:39 AM
  Template: sql2x.MVCDurianGenerator.MethodControllerCode
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class DefaultPerformanceIssueFetchWithFilterController : Controller {

        [HttpGet]
        public ActionResult DefaultPerformanceIssueFetchWithFilterIndex(System.String commandName) {

            return View(
                "~/Views/Durian/DefaultSearch/DefaultPerformanceIssueFetchWithFilterIndex.cshtml",
                new DefaultSearchService().DefaultPerformanceIssueFetchWithFilter(commandName)
                );
        }

    }
}