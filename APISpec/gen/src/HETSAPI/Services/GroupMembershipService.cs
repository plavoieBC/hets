/*
 * REST API Documentation for the MOTI Hired Equipment Tracking System (HETS) Application
 *
 * The Hired Equipment Program is for owners/operators who have a dump truck, bulldozer, backhoe or  other piece of equipment they want to hire out to the transportation ministry for day labour and  emergency projects.  The Hired Equipment Program distributes available work to local equipment owners. The program is  based on seniority and is designed to deliver work to registered users fairly and efficiently  through the development of local area call-out lists. 
 *
 * OpenAPI spec version: v1
 * 
 * 
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using HETSAPI.Models;
using HETSAPI.ViewModels;

namespace HETSAPI.Services
{
    /// <summary>
    /// 
    /// </summary>
    public interface IGroupMembershipService
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="items"></param>
        /// <response code="201">GroupMembership created</response>
        IActionResult GroupmembershipsBulkPostAsync(GroupMembership[] items);

        /// <summary>
        /// 
        /// </summary>
        /// <response code="200">OK</response>
        IActionResult GroupmembershipsGetAsync();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">id of GroupMembership to delete</param>
        /// <response code="200">OK</response>
        /// <response code="404">GroupMembership not found</response>
        IActionResult GroupmembershipsIdDeletePostAsync(int id);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">id of GroupMembership to fetch</param>
        /// <response code="200">OK</response>
        /// <response code="404">GroupMembership not found</response>
        IActionResult GroupmembershipsIdGetAsync(int id);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">id of GroupMembership to fetch</param>
        /// <param name="item"></param>
        /// <response code="200">OK</response>
        /// <response code="404">GroupMembership not found</response>
        IActionResult GroupmembershipsIdPutAsync(int id, GroupMembership item);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <response code="201">GroupMembership created</response>
        IActionResult GroupmembershipsPostAsync(GroupMembership item);
    }
}
