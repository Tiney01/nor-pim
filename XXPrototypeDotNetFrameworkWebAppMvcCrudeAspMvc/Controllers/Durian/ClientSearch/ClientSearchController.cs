﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 3:07:27 PM
  Template: sql2x.GenerateDurian.DurianController
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc {
    public class ClientSearchController : Controller {

        [HttpGet]
        public ActionResult ClientSearchIndex() {

            return View(
                "~/Views/Durian/ClientSearch/ClientSearch.cshtml"
                );
        }

    }
}
