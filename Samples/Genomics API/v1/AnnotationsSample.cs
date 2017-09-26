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
// Unoffical sample for the Genomics v1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Upload, process, query, and search Genomics data in the cloud.
// API Documentation Link https://cloud.google.com/genomics
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Genomics/v1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Genomics.v1/ 
// Install Command: PM>  Install-Package Google.Apis.Genomics.v1
//
//------------------------------------------------------------------------------  
using Google.Apis.Genomics.v1;
using Google.Apis.Genomics.v1.Data;
using System;

namespace GoogleSamplecSharpSample.Genomicsv1.Methods
{
  
    public static class AnnotationsSample
    {


        /// <summary>
        /// Deletes an annotation. Caller must have WRITE permission forthe associated annotation set. 
        /// Documentation https://developers.google.com/genomics/v1/reference/annotations/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Genomics service.</param>  
        /// <param name="annotationId">The ID of the annotation to be deleted.</param>
        /// <returns>EmptyResponse</returns>
        public static Empty Delete(GenomicsService service, string annotationId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (annotationId == null)
                    throw new ArgumentNullException(annotationId);

                // Make the request.
                return service.Annotations.Delete(annotationId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Annotations.Delete failed.", ex);
            }
        }

        /// <summary>
        /// Creates a new annotation. Caller must have WRITE permissionfor the associated annotation set.The following fields are required:* annotationSetId* referenceName or  referenceId### TranscriptsFor annotations of type TRANSCRIPT, the following fields oftranscript must be provided:* exons.start* exons.endAll other fields may be optionally specified, unless documented as beingserver-generated (for example, the `id` field). The annotatedrange must be no longer than 100Mbp (mega base pairs). See theAnnotation resourcefor additional restrictions on each field. 
        /// Documentation https://developers.google.com/genomics/v1/reference/annotations/create
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Genomics service.</param>  
        /// <param name="body">A valid Genomics v1 body.</param>
        /// <returns>AnnotationResponse</returns>
        public static Annotation Create(GenomicsService service, Annotation body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");

                // Make the request.
                return service.Annotations.Create(body).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Annotations.Create failed.", ex);
            }
        }

        /// <summary>
        /// Creates one or more new annotations atomically. All annotations mustbelong to the same annotation set. Caller must have WRITEpermission for this annotation set. For optimal performance, batchpositionally adjacent annotations together.If the request has a systemic issue, such as an attempt to write toan inaccessible annotation set, the entire RPC will fail accordingly. Forlesser data issues, when possible an error will be isolated to thecorresponding batch entry in the response; the remaining well formedannotations will be created normally.For details on the requirements for each individual annotation resource,seeCreateAnnotation. 
        /// Documentation https://developers.google.com/genomics/v1/reference/annotations/batchCreate
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Genomics service.</param>  
        /// <param name="body">A valid Genomics v1 body.</param>
        /// <returns>BatchCreateAnnotationsResponseResponse</returns>
        public static BatchCreateAnnotationsResponse BatchCreate(GenomicsService service, BatchCreateAnnotationsRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");

                // Make the request.
                return service.Annotations.BatchCreate(body).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Annotations.BatchCreate failed.", ex);
            }
        }

        /// <summary>
        /// Searches for annotations that match the given criteria. Results areordered by genomic coordinate (by reference sequence, then position).Annotations with equivalent genomic coordinates are returned in anunspecified order. This order is consistent, such that two queries for thesame content (regardless of page size) yield annotations in the same orderacross their respective streams of paginated responses. Caller must haveREAD permission for the queried annotation sets. 
        /// Documentation https://developers.google.com/genomics/v1/reference/annotations/search
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Genomics service.</param>  
        /// <param name="body">A valid Genomics v1 body.</param>
        /// <returns>SearchAnnotationsResponseResponse</returns>
        public static SearchAnnotationsResponse Search(GenomicsService service, SearchAnnotationsRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");

                // Make the request.
                return service.Annotations.Search(body).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Annotations.Search failed.", ex);
            }
        }

        /// <summary>
        /// Gets an annotation. Caller must have READ permissionfor the associated annotation set. 
        /// Documentation https://developers.google.com/genomics/v1/reference/annotations/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Genomics service.</param>  
        /// <param name="annotationId">The ID of the annotation to be retrieved.</param>
        /// <returns>AnnotationResponse</returns>
        public static Annotation Get(GenomicsService service, string annotationId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (annotationId == null)
                    throw new ArgumentNullException(annotationId);

                // Make the request.
                return service.Annotations.Get(annotationId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Annotations.Get failed.", ex);
            }
        }
        public class AnnotationsUpdateOptionalParms
        {
            /// An optional mask specifying which fields to update. Mutable fields arename,variant,transcript, andinfo. If unspecified, all mutablefields will be updated.
            public string UpdateMask { get; set; }  
        
        }
 
        /// <summary>
        /// Updates an annotation. Caller must haveWRITE permission for the associated dataset. 
        /// Documentation https://developers.google.com/genomics/v1/reference/annotations/update
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Genomics service.</param>  
        /// <param name="annotationId">The ID of the annotation to be updated.</param>
        /// <param name="body">A valid Genomics v1 body.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>AnnotationResponse</returns>
        public static Annotation Update(GenomicsService service, string annotationId, Annotation body, AnnotationsUpdateOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (annotationId == null)
                    throw new ArgumentNullException(annotationId);

                // Building the initial request.
                var request = service.Annotations.Update(body, annotationId);

                // Applying optional parameters to the request.                
                request = (AnnotationsResource.UpdateRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Annotations.Update failed.", ex);
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