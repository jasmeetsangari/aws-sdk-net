/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Get Bucket Request Payment Request Marshaller
    /// </summary>       
    public class GetBucketRequestPaymentRequestMarshaller : IMarshaller<IRequest, GetBucketRequestPaymentRequest>
    {
        public IRequest Marshall(GetBucketRequestPaymentRequest getBucketRequestPaymentRequest)
        {
            IRequest request = new DefaultRequest(getBucketRequestPaymentRequest, "AmazonS3");

            request.HttpMethod = "GET";

            var uriResourcePath = string.Concat("/", S3Transforms.ToStringValue(getBucketRequestPaymentRequest.BucketName));

            request.Parameters.Add("requestPayment", null);

            request.CanonicalResource = S3Transforms.GetCanonicalResource(uriResourcePath, request.Parameters);
            request.ResourcePath = S3Transforms.FormatResourcePath(uriResourcePath, request.Parameters);
            request.UseQueryString = true;
            
            return request;
        }
    }
}
    
