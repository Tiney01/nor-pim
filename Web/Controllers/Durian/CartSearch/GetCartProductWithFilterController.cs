﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/29/2020 5:04:24 PM
  From Machine: DESKTOP-9A2DH39
  Template: sql2x.MVCDurianGenerator.MethodControllerCode
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class GetCartProductWithFilterController : Controller {

        [HttpGet]
        public ActionResult GetCartProductWithFilterIndex() {

            return View(
                "~/Views/Durian/CartSearch/GetCartProductWithFilterIndex.cshtml",
                new CartSearchService().GetCartProductWithFilter()
                );
        }

    }
}
