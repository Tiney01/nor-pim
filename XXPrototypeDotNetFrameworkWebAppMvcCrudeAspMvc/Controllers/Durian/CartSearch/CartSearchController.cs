﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/6/2020 12:45:06 PM
  Template: sql2x.GenerateDurian.DurianController
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc {
    public class CartSearchController : Controller {

        [HttpGet]
        public ActionResult CartSearchIndex() {

            return View(
                "~/Views/Durian/CartSearch/CartSearch.cshtml"
                );
        }

    }
}
