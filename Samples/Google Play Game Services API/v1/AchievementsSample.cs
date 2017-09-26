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
  
    public static class AchievementsSample
    {

        public class AchievementsIncrementOptionalParms
        {
            /// The last-seen mutation timestamp.
            public string ConsistencyToken { get; set; }  
            /// A randomly generated numeric ID for each request specified by the caller. This number is used at the server to ensure that the request is handled correctly across retries.
            public string RequestId { get; set; }  
        
        }
 
        /// <summary>
        /// Increments the steps of the achievement with the given ID for the currently authenticated player. 
        /// Documentation https://developers.google.com/games/v1/reference/achievements/increment
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Games service.</param>  
        /// <param name="achievementId">The ID of the achievement used by this method.</param>
        /// <param name="stepsToIncrement">The number of steps to increment.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>AchievementIncrementResponseResponse</returns>
        public static AchievementIncrementResponse Increment(GamesService service, string achievementId, int? stepsToIncrement, AchievementsIncrementOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (achievementId == null)
                    throw new ArgumentNullException(achievementId);
                if (stepsToIncrement == null)
                    throw new ArgumentNullException(stepsToIncrement);

                // Building the initial request.
                var request = service.Achievements.Increment(achievementId, stepsToIncrement);

                // Applying optional parameters to the request.                
                request = (AchievementsResource.IncrementRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Achievements.Increment failed.", ex);
            }
        }
        public class AchievementsListOptionalParms
        {
            /// The last-seen mutation timestamp.
            public string ConsistencyToken { get; set; }  
            /// The preferred language to use for strings returned by this method.
            public string Language { get; set; }  
            /// The maximum number of achievement resources to return in the response, used for paging. For any response, the actual number of achievement resources returned may be less than the specified maxResults.
            public int? MaxResults { get; set; }  
            /// The token returned by the previous request.
            public string PageToken { get; set; }  
            /// Tells the server to return only achievements with the specified state. If this parameter isn't specified, all achievements are returned.
            public string State { get; set; }  
        
        }
 
        /// <summary>
        /// Lists the progress for all your application's achievements for the currently authenticated player. 
        /// Documentation https://developers.google.com/games/v1/reference/achievements/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Games service.</param>  
        /// <param name="playerId">A player ID. A value of me may be used in place of the authenticated player's ID.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>PlayerAchievementListResponseResponse</returns>
        public static PlayerAchievementListResponse List(GamesService service, string playerId, AchievementsListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (playerId == null)
                    throw new ArgumentNullException(playerId);

                // Building the initial request.
                var request = service.Achievements.List(playerId);

                // Applying optional parameters to the request.                
                request = (AchievementsResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Achievements.List failed.", ex);
            }
        }
        public class AchievementsRevealOptionalParms
        {
            /// The last-seen mutation timestamp.
            public string ConsistencyToken { get; set; }  
        
        }
 
        /// <summary>
        /// Sets the state of the achievement with the given ID to REVEALED for the currently authenticated player. 
        /// Documentation https://developers.google.com/games/v1/reference/achievements/reveal
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Games service.</param>  
        /// <param name="achievementId">The ID of the achievement used by this method.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>AchievementRevealResponseResponse</returns>
        public static AchievementRevealResponse Reveal(GamesService service, string achievementId, AchievementsRevealOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (achievementId == null)
                    throw new ArgumentNullException(achievementId);

                // Building the initial request.
                var request = service.Achievements.Reveal(achievementId);

                // Applying optional parameters to the request.                
                request = (AchievementsResource.RevealRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Achievements.Reveal failed.", ex);
            }
        }
        public class AchievementsSetStepsAtLeastOptionalParms
        {
            /// The last-seen mutation timestamp.
            public string ConsistencyToken { get; set; }  
        
        }
 
        /// <summary>
        /// Sets the steps for the currently authenticated player towards unlocking an achievement. If the steps parameter is less than the current number of steps that the player already gained for the achievement, the achievement is not modified. 
        /// Documentation https://developers.google.com/games/v1/reference/achievements/setStepsAtLeast
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Games service.</param>  
        /// <param name="achievementId">The ID of the achievement used by this method.</param>
        /// <param name="steps">The minimum value to set the steps to.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>AchievementSetStepsAtLeastResponseResponse</returns>
        public static AchievementSetStepsAtLeastResponse SetStepsAtLeast(GamesService service, string achievementId, int? steps, AchievementsSetStepsAtLeastOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (achievementId == null)
                    throw new ArgumentNullException(achievementId);
                if (steps == null)
                    throw new ArgumentNullException(steps);

                // Building the initial request.
                var request = service.Achievements.SetStepsAtLeast(achievementId, steps);

                // Applying optional parameters to the request.                
                request = (AchievementsResource.SetStepsAtLeastRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Achievements.SetStepsAtLeast failed.", ex);
            }
        }
        public class AchievementsUnlockOptionalParms
        {
            /// The last-seen mutation timestamp.
            public string ConsistencyToken { get; set; }  
        
        }
 
        /// <summary>
        /// Unlocks this achievement for the currently authenticated player. 
        /// Documentation https://developers.google.com/games/v1/reference/achievements/unlock
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Games service.</param>  
        /// <param name="achievementId">The ID of the achievement used by this method.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>AchievementUnlockResponseResponse</returns>
        public static AchievementUnlockResponse Unlock(GamesService service, string achievementId, AchievementsUnlockOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (achievementId == null)
                    throw new ArgumentNullException(achievementId);

                // Building the initial request.
                var request = service.Achievements.Unlock(achievementId);

                // Applying optional parameters to the request.                
                request = (AchievementsResource.UnlockRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Achievements.Unlock failed.", ex);
            }
        }
        public class AchievementsUpdateMultipleOptionalParms
        {
            /// The last-seen mutation timestamp.
            public string ConsistencyToken { get; set; }  
        
        }
 
        /// <summary>
        /// Updates multiple achievements for the currently authenticated player. 
        /// Documentation https://developers.google.com/games/v1/reference/achievements/updateMultiple
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Games service.</param>  
        /// <param name="body">A valid Games v1 body.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>AchievementUpdateMultipleResponseResponse</returns>
        public static AchievementUpdateMultipleResponse UpdateMultiple(GamesService service, AchievementUpdateMultipleRequest body, AchievementsUpdateMultipleOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");

                // Building the initial request.
                var request = service.Achievements.UpdateMultiple(body);

                // Applying optional parameters to the request.                
                request = (AchievementsResource.UpdateMultipleRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Achievements.UpdateMultiple failed.", ex);
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