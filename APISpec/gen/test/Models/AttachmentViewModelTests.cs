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
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;
using HETSAPI;
using HETSAPI.Models;
using System.Reflection;

namespace HETSAPI.Test
{
    /// <summary>
    ///  Class for testing the model AttachmentViewModel
    /// </summary>
    
    public class AttachmentViewModelModelTests
    {
        // TODO uncomment below to declare an instance variable for AttachmentViewModel
        private AttachmentViewModel instance;

        /// <summary>
        /// Setup the test.
        /// </summary>        
        public AttachmentViewModelModelTests()
        {
            instance = new AttachmentViewModel();
        }

    
        /// <summary>
        /// Test an instance of AttachmentViewModel
        /// </summary>
        [Fact]
        public void AttachmentViewModelInstanceTest()
        {
            Assert.IsType<AttachmentViewModel>(instance);  
        }

        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Fact]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
			Assert.True(true);
        }
        /// <summary>
        /// Test the property 'FileName'
        /// </summary>
        [Fact]
        public void FileNameTest()
        {
            // TODO unit test for the property 'FileName'
			Assert.True(true);
        }
        /// <summary>
        /// Test the property 'FileSize'
        /// </summary>
        [Fact]
        public void FileSizeTest()
        {
            // TODO unit test for the property 'FileSize'
			Assert.True(true);
        }
        /// <summary>
        /// Test the property 'Description'
        /// </summary>
        [Fact]
        public void DescriptionTest()
        {
            // TODO unit test for the property 'Description'
			Assert.True(true);
        }
        /// <summary>
        /// Test the property 'Type'
        /// </summary>
        [Fact]
        public void TypeTest()
        {
            // TODO unit test for the property 'Type'
			Assert.True(true);
        }
        /// <summary>
        /// Test the property 'LastUpdateUserid'
        /// </summary>
        [Fact]
        public void LastUpdateUseridTest()
        {
            // TODO unit test for the property 'LastUpdateUserid'
			Assert.True(true);
        }
        /// <summary>
        /// Test the property 'LastUpdateTimestamp'
        /// </summary>
        [Fact]
        public void LastUpdateTimestampTest()
        {
            // TODO unit test for the property 'LastUpdateTimestamp'
			Assert.True(true);
        }

	}
	
}

