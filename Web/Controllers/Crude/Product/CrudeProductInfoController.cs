﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/19/2020 5:23:24 PM
  From Machine: DESKTOP-KE5CSN3
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

// Client WinForm Layer
// the Client WinForm Layer uses the Proxy Layer to tie into SOAP services
// links:
//   https://docs.microsoft.com/en-us/dotnet/framework/winforms/: client winform layer
namespace SolutionNorSolutionPim.AspMvc.Controllers {

    // controller class for mvc
    public class CrudeProductInfoController : Controller {

        // index page for controller
        [HttpGet]
        public ActionResult CrudeProductInfoIndex() {

            return View(
                "~/Views/Crude/Product/CrudeProductInfo/CrudeProductInfoIndex.cshtml",
                new CrudeProductInfoServiceClient().FetchAll()
                );
        }

        // page with foreign key data
        [HttpGet]
        public ActionResult CrudeProductInfoByProductIndex(System.Guid productId) {
            ViewBag.ProductId = productId;

            return View(
                "~/Views/Crude/Product/CrudeProductInfo/CrudeProductInfoIndex.cshtml",
                new CrudeProductInfoServiceClient().FetchByProductId(productId)
                );
        }

        // fetch detail page for editing
        [HttpGet]
        public ActionResult CrudeProductInfoDetails(System.Guid productInfoId) {

            return View(
                "~/Views/Crude/Product/CrudeProductInfo/CrudeProductInfoDetails.cshtml",
                new CrudeProductInfoServiceClient().FetchByProductInfoId(productInfoId)
                );
        }

        // edit details page
        [HttpGet]
        public ActionResult CrudeProductInfoEdit(
            System.Guid productInfoId
            ) {

            CrudeProductInfoContract contract = new CrudeProductInfoServiceClient().FetchByProductInfoId(productInfoId);
            ViewBag.ProductId =
                new SelectList( new CrudeProductServiceClient().FetchAll(),
                                "ProductId",
                                "ProductName",
                                contract.ProductId
                                );

            ViewBag.ProductInfoRcd =
                new SelectList( new CrudeProductInfoRefServiceClient().FetchAll(),
                                "ProductInfoRcd",
                                "ProductInfoName",
                                contract.ProductInfoRcd
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;


            return View(
                "~/Views/Crude/Product/CrudeProductInfo/CrudeProductInfoEdit.cshtml",
                contract
                );
        }

        // save detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductInfoEdit([Bind()] CrudeProductInfoContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeProductInfoServiceClient().Update(contract);

                return RedirectToAction("CrudeProductInfoIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductInfo/CrudeProductInfoEdit.cshtml",
                contract
                );
        }

        // add new entity page
        [HttpGet]
        public ActionResult CrudeProductInfoCreate(System.Guid? productId, System.Guid? userId) {
            var contract = new CrudeProductInfoContract();
            if (productId != null) contract.ProductId = (System.Guid) productId;
            if (userId != null) contract.UserId = (System.Guid) userId;

            ViewBag.ProductId =
                new SelectList( new CrudeProductServiceClient().FetchAll(),
                                "ProductId",
                                "ProductName",
                                contract.ProductId
                                );

            ViewBag.ProductInfoRcd =
                new SelectList( new CrudeProductInfoRefServiceClient().FetchAll(),
                                "ProductInfoRcd",
                                "ProductInfoName",
                                contract.ProductInfoRcd
                                );

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Product/CrudeProductInfo/CrudeProductInfoCreate.cshtml",
                contract
                );
        }

        // add new detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductInfoCreate([Bind()] CrudeProductInfoContract contract) {
            if (ModelState.IsValid) {

                new CrudeProductInfoServiceClient().Insert(contract);

                return RedirectToAction("CrudeProductInfoIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductInfo/CrudeProductInfoCreate.cshtml",
                contract
                );
        }

        // delete entity page
        [HttpGet]
        public ActionResult CrudeProductInfoDelete(
            System.Guid productInfoId
            ) {
            new CrudeProductInfoServiceClient().Delete(productInfoId);

            return RedirectToAction("CrudeProductInfoIndex");
        }
    }
}
