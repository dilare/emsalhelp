using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LeftMenu1.Models
{
    public class WordDocumentAttribute: ActionFilterAttribute
    {
        public string DefaultFilename { get; set; }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            var result = filterContext.Result as ViewResult;

            if (result != null)
                result.MasterName = "~/Views/Shared/_LayoutWord.cshtml";

            filterContext.Controller.ViewBag.WordDocumentMode = true;
            //Response.ContentType = "image/jpeg";
            //Response.AppendHeader("Content-Disposition", "attachment; filename=SailBig.jpg");
            //Response.TransmitFile(Server.MapPath("~/images/sailbig.jpg"));
            //Response.End();
            base.OnActionExecuted(filterContext);
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            var filename = filterContext.Controller.ViewBag.WordDocumentFilename;
            filename = filename ?? DefaultFilename ?? "Document";

            //filterContext.HttpContext.Response.AppendHeader("Content-Disposition", string.Format("filename={0}.doc", filename));

            //filterContext.HttpContext.Response.ContentType = "application/msword"; 
            filterContext.HttpContext.Response.AppendHeader("Content-Disposition", "attachment;filename=" + "{0}" + ".pdf");

            filterContext.HttpContext.Response.ContentType = "application/pdf";
            //Response.ContentType = "application/pdf";
            //Response.AddHeader("content-disposition", "attachment;filename=" + fileName + ".pdf");
            

            base.OnResultExecuted(filterContext);
        }
    }
}