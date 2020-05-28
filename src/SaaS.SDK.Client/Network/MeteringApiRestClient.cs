﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE file in the project root for license information.
namespace Microsoft.Marketplace.SaaS.Client.Network
{
    using System.IO;
    using System.Net;
    using System.Text.Json;
    using Microsoft.Marketplace.SaaS.Client.Network;
    using Microsoft.Marketplace.SaaS.Client.Configurations;
    using Microsoft.Marketplace.SaaS.Client.Contracts;
    using Microsoft.Marketplace.SaaS.Client.Exceptions;
    using Microsoft.Marketplace.SaaS.Client.Models;

    /// <summary>
    /// Metering Api RestClient.
    /// </summary>
    /// <typeparam name="T"> Generic.</typeparam>
    /// <seealso cref="SaaS.Client.Network.AbstractSaaSApiRestClient{T}" />
    public class MeteringApiRestClient<T> : AbstractSaaSApiRestClient<T>
                                  where T : SaaSApiResult, new()
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MeteringApiRestClient{T}" /> class.
        /// </summary>
        /// <param name="clientConfiguration">The client configuration.</param>
        /// <param name="logger">The logger.</param>
        public MeteringApiRestClient(SaaSApiClientConfiguration clientConfiguration, ILogger logger)
                                                                    : base(clientConfiguration, logger)
        {
        }

        /// <summary>
        /// Processes the error response.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <param name="ex">The ex.</param>
        /// <returns>
        /// Error result built using the data in the response.
        /// </returns>
        /// <exception cref="MeteredBillingException">Exception.</exception>
        /// <exception cref="Microsoft.Marketplace.SaaS.Client.Exceptions.MeteredBillingException">Token expired. Please logout and login again.
        /// Not Found.
        /// Bad Request.
        /// Internal Server error.</exception>
        protected override T ProcessErrorResponse(string url, WebException ex)
        {
            var webresponse = ex.Response as System.Net.HttpWebResponse;
            if (webresponse != null)
            {
                string responseString = string.Empty;
                MeteringErrorResult meteredBillingErrorResult = new MeteringErrorResult();

                using (StreamReader reader = new StreamReader(webresponse.GetResponseStream()))
                {
                    responseString = reader.ReadToEnd();
                    meteredBillingErrorResult = JsonSerializer.Deserialize<MeteringErrorResult>(responseString);
                }

                this.logger?.Info("Error :: " + responseString);

                if (webresponse.StatusCode == HttpStatusCode.Unauthorized || webresponse.StatusCode == HttpStatusCode.Forbidden)
                {
                    throw new MeteredBillingException("Token expired. Please logout and login again.", SaasApiErrorCode.Unauthorized, meteredBillingErrorResult);
                }
                else if (webresponse.StatusCode == HttpStatusCode.NotFound)
                {
                    this.logger?.Warn("Returning the error as " + JsonSerializer.Serialize(new { Error = "Not Found" }));
                    throw new MeteredBillingException(string.Format("Unable to find the request {0}", url), SaasApiErrorCode.NotFound, meteredBillingErrorResult);
                }
                else if (webresponse.StatusCode == HttpStatusCode.Conflict)
                {
                    this.logger?.Warn("Returning the error as " + JsonSerializer.Serialize(new { Error = "Conflict" }));
                    throw new MeteredBillingException(string.Format("Conflict came for {0}", url), SaasApiErrorCode.Conflict, meteredBillingErrorResult);
                }
                else if (webresponse.StatusCode == HttpStatusCode.BadRequest)
                {
                    this.logger?.Warn("Returning the error as " + JsonSerializer.Serialize(new { Error = "Bad Request" }));
                    throw new MeteredBillingException(string.Format("Unable to process the request {0}, server responding as BadRequest. Please verify the post data. ", url), SaasApiErrorCode.BadRequest, meteredBillingErrorResult);
                }
            }

            return null;
        }
    }
}
