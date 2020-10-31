using System;
using System.Collections.Generic;
using System.Text;

namespace Ton.Sdk.Abi
{
    using Newtonsoft.Json;

    public class ParamsOfEncodeMessage
    {
        /// <summary>
        /// Gets or sets the contract abi.
        /// </summary>
        /// <value>
        /// The contract abi.
        /// </value>
        [JsonProperty("abi")]
        public ContractAbi ContractAbi { get; set; }

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        /// <value>
        /// The address.
        /// </value>
        [JsonProperty("address")]
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets the deploy set.
        /// </summary>
        /// <value>
        /// The deploy set.
        /// </value>
        [JsonProperty("deploy_set")]
        public DeploySet DeploySet { get; set; }

        /// <summary>
        /// Gets or sets the call set.
        /// </summary>
        /// <value>
        /// The call set.
        /// </value>
        [JsonProperty("call_set")]
        public CallSet CallSet { get; set; }

        /// <summary>
        /// Gets or sets the signer.
        /// </summary>
        /// <value>
        /// The signer.
        /// </value>
        [JsonProperty("signer")]
        public Signer Signer { get; set; }

        /// <summary>
        /// Gets or sets the index of the processing try.
        /// </summary>
        /// <value>
        /// The index of the processing try.
        /// </value>
        [JsonProperty("processing_try_index")]
        public uint? ProcessingTryIndex { get; set; }
    }
}
