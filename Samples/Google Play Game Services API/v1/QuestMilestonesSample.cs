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
// Unoffical sample for the Games v1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: The API for Google Play Game Services.
// API Documentation Link https://developers.google.com/games/services/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Games/v1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Games.v1/ 
// Install Command: PM>  Install-Package Google.Apis.Games.v1
//
//------------------------------------------------------------------------------  
using Google.Apis.Games.v1;
using Google.Apis.Games.v1.Data;
using System;

namespace GoogleSamplecSharpSample.Gamesv1.Methods
{
  
    public static class QuestMilestonesSample
    {

        public class QuestMilestonesClaimOptionalParms
        {
            /// The last-seen mutation timestamp.
            public string ConsistencyToken { get; set; }  
        
        }
 
        /// <summary>
        /// Report that a reward for the milestone corresponding to milestoneId for the quest corresponding to questId has been claimed by the currently authorized user. 
        /// Documentation https://developers.google.com/games/v1/reference/questMilestones/claim
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Games service.</param>  
        /// <param name="questId">The ID of the quest.</param>
        /// <param name="milestoneId">The ID of the milestone.</param>
        /// <param name="requestId">A numeric ID to ensure that the request is handled correctly across retries. Your client application must generate this ID randomly.</param>
        /// <param name="optional">Optional paramaters.</param>
        public static void Claim(GamesService service, string questId, string milestoneId, string requestId, QuestMilestonesClaimOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (questId == null)
                    throw new ArgumentNullException(questId);
                if (milestoneId == null)
                    throw new ArgumentNullException(milestoneId);
                if (requestId == null)
                    throw new ArgumentNullException(requestId);

                // Building the initial request.
                var request = service.QuestMilestones.Claim(questId, milestoneId, requestId);

                // Applying optional parameters to the request.                
                request = (QuestMilestonesResource.ClaimRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                 request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request QuestMilestones.Claim failed.", ex);
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