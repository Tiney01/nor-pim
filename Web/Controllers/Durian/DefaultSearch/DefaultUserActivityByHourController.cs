﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/19/2020 5:32:57 PM
  From Machine: DESKTOP-KE5CSN3
  Template: sql2x.MVCDurianGenerator.MethodControllerCode
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class DefaultUserActivityByHourController : Controller {

        [HttpGet]
        public ActionResult DefaultUserActivityByHourIndex() {

            return View(
                "~/Views/Durian/DefaultSearch/DefaultUserActivityByHourIndex.cshtml",
                new DefaultSearchService().DefaultUserActivityByHour()
                );
        }

    }
}
