﻿/*
 * REST API Documentation for the MOTI Hired Equipment Tracking System (HETS) Application
 *
 * The Hired Equipment Program is for owners/operators who have a dump truck, bulldozer, backhoe or  other piece of equipment they want to hire out to the transportation ministry for day labour and  emergency projects.  The Hired Equipment Program distributes available work to local equipment owners. The program is  based on seniority and is designed to deliver work to registered users fairly and efficiently  through the development of local area call-out lists. 
 *
 * OpenAPI spec version: v1
 * 
 * 
 */

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HETSAPI.Authorization;
using HETSAPI.Models;
using HETSAPI.Services.Impl;
using HETSCommon;
using System.Collections.Generic;
using System.IO;
using System;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace SchoolBusAPI.Controllers
{

    /// <summary>
    /// This controller is used to handle importing data from the previous system.
    /// </summary>
    [Route("api/import")]
    public class ImportController
    {
        private readonly IImportService _service;
        public ImportController(IImportService service)
        {
            _service = service;
        }

        /// <summary>
        /// Shows a basic file upload form
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("upload")]
        [Produces("text/html")]
        public virtual IActionResult UploadGet()
        {
            return new ObjectResult("<html><body><form method=\"post\" enctype=\"multipart/form-data\"><input type=\"file\" name = \"files\" multiple /><input type = \"submit\" value = \"Upload\" /></body></html>");
        }

        /// <summary>
        /// Receives uploaded files
        /// </summary>
        /// <param name="files"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("upload")]
        [Produces("text/html")]
        public virtual IActionResult UploadPost(IList<IFormFile> files)
        {
            return _service.UploadPostAsync(files);
        }        
    }


    public interface IImportService
    {        
        IActionResult UploadPostAsync(IList<IFormFile> files);
    }

    public class ImportService : ServiceBase, IImportService
    {
        private readonly IConfiguration Configuration;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="httpContextAccessor"></param>
        /// <param name="configuration"></param>
        /// <param name="context"></param>
        public ImportService(IHttpContextAccessor httpContextAccessor, IConfiguration configuration, DbAppContext context) : base(httpContextAccessor, context)
        {
            Configuration = configuration;
        }

        /// <summary>
        ///  Basic file receiver for .NET Core
        /// </summary>
        /// <param name="files"></param>
        /// <returns></returns>
        public IActionResult UploadPostAsync(IList<IFormFile> files)
        {            
            string result = "";
            string uploadPath = Configuration["UploadPath"];
            if (string.IsNullOrEmpty (uploadPath))
            {
                result = "ERROR:  UploadPath environment variable is empty.  Set it to the path where files will be stored.";
            }
            else
            {
                try
                {
                    result = "<html><body><h1>Files Received:</h1><p>";
                                       
                    foreach (var file in files)
                    {
                        if (file.Length > 0)
                        {
                            // Add a unique file prefix to allow for a file to be uploaded multiple times.
                            string filePrefix = "" + DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day + "-" + DateTime.Now.Ticks + "-";
                            using (var fileStream = new FileStream(Path.Combine(uploadPath, filePrefix + file.FileName), FileMode.Create))
                            {
                                file.CopyTo(fileStream);
                                result = result + file.FileName + "<br>";
                            }
                        }
                    }
                    result = result + "<body></html>";
                }
                catch (Exception e)
                {
                    result = "<html><body><h1>Error:</h1><p><pre>";
                    result = result + JsonConvert.SerializeObject(e) + "</pre></body></html>";
                }
            }            
            return new ObjectResult(result);
        }

    }

}

