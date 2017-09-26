﻿// Copyright 2017 DAIMTO ([Linda Lawton](https://twitter.com/LindaLawtonDK)) :  [www.daimto.com](http://www.daimto.com/)
//
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by DAIMTO-Google-apis-Sample-generator 1.0.0
//     Template File Name:  methodTemplate.tt
//     Build date: 2017-09-26
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------  
// About 
// 
// Unoffical sample for the Drive v3 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Manages files in Drive including uploading, downloading, searching, detecting changes, and updating sharing permissions.
// API Documentation Link https://developers.google.com/drive/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Drive/v3/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Drive.v3/ 
// Install Command: PM>  Install-Package Google.Apis.Drive.v3
//
//------------------------------------------------------------------------------  
using Google.Apis.Drive.v3;
using Google.Apis.Drive.v3.Data;
using System;

namespace GoogleSamplecSharpSample.Drivev3.Methods
{
  
    public static class CommentsSample
    {


        /// <summary>
        /// Creates a new comment on a file. 
        /// Documentation https://developers.google.com/drive/v3/reference/comments/create
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Drive service.</param>  
        /// <param name="fileId">The ID of the file.</param>
        /// <param name="body">A valid Drive v3 body.</param>
        /// <returns>CommentResponse</returns>
        public static Comment Create(DriveService service, string fileId, Comment body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (fileId == null)
                    throw new ArgumentNullException(fileId);

                // Make the request.
                return service.Comments.Create(body, fileId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Comments.Create failed.", ex);
            }
        }

        /// <summary>
        /// Deletes a comment. 
        /// Documentation https://developers.google.com/drive/v3/reference/comments/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Drive service.</param>  
        /// <param name="fileId">The ID of the file.</param>
        /// <param name="commentId">The ID of the comment.</param>
        public static void Delete(DriveService service, string fileId, string commentId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (fileId == null)
                    throw new ArgumentNullException(fileId);
                if (commentId == null)
                    throw new ArgumentNullException(commentId);

                // Make the request.
                 service.Comments.Delete(fileId, commentId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Comments.Delete failed.", ex);
            }
        }
        public class CommentsGetOptionalParms
        {
            /// Whether to return deleted comments. Deleted comments will not include their original content.
            public bool? IncludeDeleted { get; set; }  
        
        }
 
        /// <summary>
        /// Gets a comment by ID. 
        /// Documentation https://developers.google.com/drive/v3/reference/comments/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Drive service.</param>  
        /// <param name="fileId">The ID of the file.</param>
        /// <param name="commentId">The ID of the comment.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>CommentResponse</returns>
        public static Comment Get(DriveService service, string fileId, string commentId, CommentsGetOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (fileId == null)
                    throw new ArgumentNullException(fileId);
                if (commentId == null)
                    throw new ArgumentNullException(commentId);

                // Building the initial request.
                var request = service.Comments.Get(fileId, commentId);

                // Applying optional parameters to the request.                
                request = (CommentsResource.GetRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Comments.Get failed.", ex);
            }
        }
        public class CommentsListOptionalParms
        {
            /// Whether to include deleted comments. Deleted comments will not include their original content.
            public bool? IncludeDeleted { get; set; }  
            /// The maximum number of comments to return per page.
            public int? PageSize { get; set; }  
            /// The token for continuing a previous list request on the next page. This should be set to the value of 'nextPageToken' from the previous response.
            public string PageToken { get; set; }  
            /// The minimum value of 'modifiedTime' for the result comments (RFC 3339 date-time).
            public string StartModifiedTime { get; set; }  
        
        }
 
        /// <summary>
        /// Lists a file's comments. 
        /// Documentation https://developers.google.com/drive/v3/reference/comments/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Drive service.</param>  
        /// <param name="fileId">The ID of the file.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>CommentListResponse</returns>
        public static CommentList List(DriveService service, string fileId, CommentsListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (fileId == null)
                    throw new ArgumentNullException(fileId);

                // Building the initial request.
                var request = service.Comments.List(fileId);

                // Applying optional parameters to the request.                
                request = (CommentsResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Comments.List failed.", ex);
            }
        }

        /// <summary>
        /// Updates a comment with patch semantics. 
        /// Documentation https://developers.google.com/drive/v3/reference/comments/update
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Drive service.</param>  
        /// <param name="fileId">The ID of the file.</param>
        /// <param name="commentId">The ID of the comment.</param>
        /// <param name="body">A valid Drive v3 body.</param>
        /// <returns>CommentResponse</returns>
        public static Comment Update(DriveService service, string fileId, string commentId, Comment body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (fileId == null)
                    throw new ArgumentNullException(fileId);
                if (commentId == null)
                    throw new ArgumentNullException(commentId);

                // Make the request.
                return service.Comments.Update(body, fileId, commentId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Comments.Update failed.", ex);
            }
        }
        
        }

        public static class SampleHelpers
        {

        /// <summary>
        /// Using reflection to apply optional parameters to the request.  
        /// 
        /// If the optonal parameters are null then we will just return the request as is.
        /// </summary>
        /// <param name="request">The request. </param>
        /// <param name="optional">The optional parameters. </param>
        /// <returns></returns>
        public static object ApplyOptionalParms(object request, object optional)
        {
            if (optional == null)
                return request;

            System.Reflection.PropertyInfo[] optionalProperties = (optional.GetType()).GetProperties();

            foreach (System.Reflection.PropertyInfo property in optionalProperties)
            {
                // Copy value from optional parms to the request.  They should have the same names and datatypes.
                System.Reflection.PropertyInfo piShared = (request.GetType()).GetProperty(property.Name);
				if (property.GetValue(optional, null) != null) // TODO Test that we do not add values for items that are null
					piShared.SetValue(request, property.GetValue(optional, null), null);
            }

            return request;
        }
    }
}