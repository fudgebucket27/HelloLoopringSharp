using HelloLoopringSharp.ApiRequests;
using HelloLoopringSharp.ApiResponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloLoopringSharp.Client
{
    public interface ILoopringClient
    {
        /// <summary>
        /// Gets the Loopring Relayer Timestamp
        /// </summary>
        /// <returns>Relayer Timestamp in milleseconds</returns>
        /// <exception cref="System.Exception">Thrown when there is an issue querying the Loopring API endpoint</exception>
        Task<GetRelayerTimestampResponse> GetRelayerTimestamp();

        /// <summary>
        /// Gets the Loopring Account Details
        /// </summary>
        /// <param name="owner">Loopring Hexadecimal Address</param>
        /// <param name="accountId">Loopring Account Id</param>
        /// <returns>Loopring Account Details</returns>
        /// <exception cref="System.Exception">Thrown when there is an issue querying the Loopring API endpoint</exception>
        Task<GetAccountResponse> GetAccount(GetAccountRequest getAccountRequest);

        /// <summary>
        /// Gets the Loopring API Key 
        /// </summary>
        /// <param name="layerTwoPrivateKey">Loopring Layer 2 Private Key</param>
        /// <param name="accountId">Loopring Account Id</param>
        /// <returns>Loopring API Key</returns>
        /// <exception cref="System.Exception">Thrown when there is an issue querying the Loopring API endpoint</exception>
        Task<ApiKeyResponse> GetApiKey(string layerTwoPrivateKey, int accountId);

        /// <summary>
        /// Updates the Loopring API Key 
        /// </summary>
        /// <param name="layerTwoPrivateKey">Loopring Layer 2 Private Key</param>
        /// <param name="apiKey">Loopring api key</param>
        /// <param name="updateApiKeyRequest">Update api key request</param>
        /// <returns>Loopring API Key</returns>
        /// <exception cref="System.Exception">Thrown when there is an issue querying the Loopring API endpoint</exception>
        Task<ApiKeyResponse> UpdateApiKey(string layerTwoPrivateKey, string apiKey, UpdateApiKeyRequest updateApiKeyRequest);

        /// <summary>
        /// Gets the next storage id
        /// </summary>
        /// <param name="apiKey">Loopring api key</param>
        /// <param name="getStorageIdRequest">Storage id request</param>
        /// <returns>The next storage id</returns>
        /// <exception cref="System.Exception">Thrown when there is an issue querying the Loopring API endpoint</exception>
        Task<GetStorageIdResponse> GetStorageId(string apiKey, GetStorageIdRequest getStorageIdRequest);
    }
}
