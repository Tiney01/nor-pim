﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/29/2020 5:56:53 PM
  From Machine: DESKTOP-9A2DH39
  Template: sql2x.MVCDurianGenerator.MethodControllerCode
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class DefaultUserActivityRecentController : Controller {

        [HttpGet]
        public ActionResult DefaultUserActivityRecentIndex(System.Guid defaultUserId) {

            return View(
                "~/Views/Durian/DefaultSearch/DefaultUserActivityRecentIndex.cshtml",
                new DefaultSearchService().DefaultUserActivityRecent(defaultUserId)
                );
        }

    }
}
