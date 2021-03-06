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
using Xunit;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.XPath;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Serialization;
using Npgsql;
using Microsoft.EntityFrameworkCore;
using Moq;
using HETSAPI;
using HETSAPI.Models;
using HETSAPI.Controllers;
using HETSAPI.Services.Impl;

namespace HETSAPI.Test
{
	public class AttachmentUnitTest 
    { 
		
		private readonly AttachmentController _Attachment;
		
		/// <summary>
        /// Setup the test
        /// </summary>        
		public AttachmentUnitTest()
		{			
                    DbContextOptions<DbAppContext> options = new DbContextOptions<DbAppContext>();
                    Mock<DbAppContext> dbAppContext = new Mock<DbAppContext>(null, options);
			
                    /*
			
                    Here you will need to mock up the context.
			
            ItemType fakeItem = new ItemType(...);

            Mock<DbSet<ItemType>> mockList = MockDbSet.Create(fakeItem);

            dbAppContext.Setup(x => x.ModelEndpoint).Returns(mockItem.Object);

                    */

                    AttachmentService _service = new AttachmentService(dbAppContext.Object);
			
                    _Attachment = new AttachmentController (_service);

		}
	
		
		[Fact]
		/// <summary>
        /// Unit test for AttachmentBulkPost
        /// </summary>
		public void TestAttachmentBulkPost()
		{
			// Add test code here
			// it may look like: 
			//  var result = _AttachmentController.AttachmentBulkPost();
			//  Assert.True (result == expected-result);

            Assert.True(true);
		}		
        
		
		[Fact]
		/// <summary>
        /// Unit test for AttachmentGet
        /// </summary>
		public void TestAttachmentGet()
		{
			// Add test code here
			// it may look like: 
			//  var result = _AttachmentController.AttachmentGet();
			//  Assert.True (result == expected-result);

            Assert.True(true);
		}		
        
		
		[Fact]
		/// <summary>
        /// Unit test for AttachmentIdDeletePost
        /// </summary>
		public void TestAttachmentIdDeletePost()
		{
			// Add test code here
			// it may look like: 
			//  var result = _AttachmentController.AttachmentIdDeletePost();
			//  Assert.True (result == expected-result);

            Assert.True(true);
		}		
        
		
		[Fact]
		/// <summary>
        /// Unit test for AttachmentIdGet
        /// </summary>
		public void TestAttachmentIdGet()
		{
			// Add test code here
			// it may look like: 
			//  var result = _AttachmentController.AttachmentIdGet();
			//  Assert.True (result == expected-result);

            Assert.True(true);
		}		
        
		
		[Fact]
		/// <summary>
        /// Unit test for AttachmentIdPut
        /// </summary>
		public void TestAttachmentIdPut()
		{
			// Add test code here
			// it may look like: 
			//  var result = _AttachmentController.AttachmentIdPut();
			//  Assert.True (result == expected-result);

            Assert.True(true);
		}		
        
		
		[Fact]
		/// <summary>
        /// Unit test for AttachmentPost
        /// </summary>
		public void TestAttachmentPost()
		{
			// Add test code here
			// it may look like: 
			//  var result = _AttachmentController.AttachmentPost();
			//  Assert.True (result == expected-result);

            Assert.True(true);
		}		
        
    }
}
