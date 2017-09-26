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
// Unoffical sample for the Calendar v3 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Manipulates events and other calendar data.
// API Documentation Link https://developers.google.com/google-apps/calendar/firstapp
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Calendar/v3/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Calendar.v3/ 
// Install Command: PM>  Install-Package Google.Apis.Calendar.v3
//
//------------------------------------------------------------------------------  
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using System;

namespace GoogleSamplecSharpSample.Calendarv3.Methods
{
  
    public static class AclSample
    {


        /// <summary>
        /// Deletes an access control rule. 
        /// Documentation https://developers.google.com/calendar/v3/reference/acl/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Calendar service.</param>  
        /// <param name="calendarId">Calendar identifier. To retrieve calendar IDs call the calendarList.list method. If you want to access the primary calendar of the currently logged in user, use the "primary" keyword.</param>
        /// <param name="ruleId">ACL rule identifier.</param>
        public static void Delete(CalendarService service, string calendarId, string ruleId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (calendarId == null)
                    throw new ArgumentNullException(calendarId);
                if (ruleId == null)
                    throw new ArgumentNullException(ruleId);

                // Make the request.
                 service.Acl.Delete(calendarId, ruleId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Acl.Delete failed.", ex);
            }
        }

        /// <summary>
        /// Returns an access control rule. 
        /// Documentation https://developers.google.com/calendar/v3/reference/acl/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Calendar service.</param>  
        /// <param name="calendarId">Calendar identifier. To retrieve calendar IDs call the calendarList.list method. If you want to access the primary calendar of the currently logged in user, use the "primary" keyword.</param>
        /// <param name="ruleId">ACL rule identifier.</param>
        /// <returns>AclRuleResponse</returns>
        public static AclRule Get(CalendarService service, string calendarId, string ruleId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (calendarId == null)
                    throw new ArgumentNullException(calendarId);
                if (ruleId == null)
                    throw new ArgumentNullException(ruleId);

                // Make the request.
                return service.Acl.Get(calendarId, ruleId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Acl.Get failed.", ex);
            }
        }

        /// <summary>
        /// Creates an access control rule. 
        /// Documentation https://developers.google.com/calendar/v3/reference/acl/insert
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Calendar service.</param>  
        /// <param name="calendarId">Calendar identifier. To retrieve calendar IDs call the calendarList.list method. If you want to access the primary calendar of the currently logged in user, use the "primary" keyword.</param>
        /// <param name="body">A valid Calendar v3 body.</param>
        /// <returns>AclRuleResponse</returns>
        public static AclRule Insert(CalendarService service, string calendarId, AclRule body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (calendarId == null)
                    throw new ArgumentNullException(calendarId);

                // Make the request.
                return service.Acl.Insert(body, calendarId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Acl.Insert failed.", ex);
            }
        }
        public class AclListOptionalParms
        {
            /// Maximum number of entries returned on one result page. By default the value is 100 entries. The page size can never be larger than 250 entries. Optional.
            public int? MaxResults { get; set; }  
            /// Token specifying which result page to return. Optional.
            public string PageToken { get; set; }  
            /// Whether to include deleted ACLs in the result. Deleted ACLs are represented by role equal to "none". Deleted ACLs will always be included if syncToken is provided. Optional. The default is False.
            public bool? ShowDeleted { get; set; }  
            /// Token obtained from the nextSyncToken field returned on the last page of results from the previous list request. It makes the result of this list request contain only entries that have changed since then. All entries deleted since the previous list request will always be in the result set and it is not allowed to set showDeleted to False.If the syncToken expires, the server will respond with a 410 GONE response code and the client should clear its storage and perform a full synchronization without any syncToken.Learn more about incremental synchronization.Optional. The default is to return all entries.
            public string SyncToken { get; set; }  
        
        }
 
        /// <summary>
        /// Returns the rules in the access control list for the calendar. 
        /// Documentation https://developers.google.com/calendar/v3/reference/acl/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Calendar service.</param>  
        /// <param name="calendarId">Calendar identifier. To retrieve calendar IDs call the calendarList.list method. If you want to access the primary calendar of the currently logged in user, use the "primary" keyword.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>AclResponse</returns>
        public static Acl List(CalendarService service, string calendarId, AclListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (calendarId == null)
                    throw new ArgumentNullException(calendarId);

                // Building the initial request.
                var request = service.Acl.List(calendarId);

                // Applying optional parameters to the request.                
                request = (AclResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Acl.List failed.", ex);
            }
        }

        /// <summary>
        /// Updates an access control rule. This method supports patch semantics. 
        /// Documentation https://developers.google.com/calendar/v3/reference/acl/patch
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Calendar service.</param>  
        /// <param name="calendarId">Calendar identifier. To retrieve calendar IDs call the calendarList.list method. If you want to access the primary calendar of the currently logged in user, use the "primary" keyword.</param>
        /// <param name="ruleId">ACL rule identifier.</param>
        /// <param name="body">A valid Calendar v3 body.</param>
        /// <returns>AclRuleResponse</returns>
        public static AclRule Patch(CalendarService service, string calendarId, string ruleId, AclRule body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (calendarId == null)
                    throw new ArgumentNullException(calendarId);
                if (ruleId == null)
                    throw new ArgumentNullException(ruleId);

                // Make the request.
                return service.Acl.Patch(body, calendarId, ruleId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Acl.Patch failed.", ex);
            }
        }

        /// <summary>
        /// Updates an access control rule. 
        /// Documentation https://developers.google.com/calendar/v3/reference/acl/update
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Calendar service.</param>  
        /// <param name="calendarId">Calendar identifier. To retrieve calendar IDs call the calendarList.list method. If you want to access the primary calendar of the currently logged in user, use the "primary" keyword.</param>
        /// <param name="ruleId">ACL rule identifier.</param>
        /// <param name="body">A valid Calendar v3 body.</param>
        /// <returns>AclRuleResponse</returns>
        public static AclRule Update(CalendarService service, string calendarId, string ruleId, AclRule body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (calendarId == null)
                    throw new ArgumentNullException(calendarId);
                if (ruleId == null)
                    throw new ArgumentNullException(ruleId);

                // Make the request.
                return service.Acl.Update(body, calendarId, ruleId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Acl.Update failed.", ex);
            }
        }
        public class AclWatchOptionalParms
        {
            /// Maximum number of entries returned on one result page. By default the value is 100 entries. The page size can never be larger than 250 entries. Optional.
            public int? MaxResults { get; set; }  
            /// Token specifying which result page to return. Optional.
            public string PageToken { get; set; }  
            /// Whether to include deleted ACLs in the result. Deleted ACLs are represented by role equal to "none". Deleted ACLs will always be included if syncToken is provided. Optional. The default is False.
            public bool? ShowDeleted { get; set; }  
            /// Token obtained from the nextSyncToken field returned on the last page of results from the previous list request. It makes the result of this list request contain only entries that have changed since then. All entries deleted since the previous list request will always be in the result set and it is not allowed to set showDeleted to False.If the syncToken expires, the server will respond with a 410 GONE response code and the client should clear its storage and perform a full synchronization without any syncToken.Learn more about incremental synchronization.Optional. The default is to return all entries.
            public string SyncToken { get; set; }  
        
        }
 
        /// <summary>
        /// Watch for changes to ACL resources. 
        /// Documentation https://developers.google.com/calendar/v3/reference/acl/watch
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Calendar service.</param>  
        /// <param name="calendarId">Calendar identifier. To retrieve calendar IDs call the calendarList.list method. If you want to access the primary calendar of the currently logged in user, use the "primary" keyword.</param>
        /// <param name="body">A valid Calendar v3 body.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>ChannelResponse</returns>
        public static Channel Watch(CalendarService service, string calendarId, Channel body, AclWatchOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (calendarId == null)
                    throw new ArgumentNullException(calendarId);

                // Building the initial request.
                var request = service.Acl.Watch(body, calendarId);

                // Applying optional parameters to the request.                
                request = (AclResource.WatchRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Acl.Watch failed.", ex);
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