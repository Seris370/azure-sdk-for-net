﻿using System.Threading.Tasks;
using Azure.Identity;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Resources.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Tests.Samples
{
    class Sample3_CreatingAVirtualNetwork
    {
        [Test]
        [Ignore("Only verifying that the sample builds")]
        public async Task CreateResourceGroupAsync()
        {
            #region Snippet:Creating_A_Virtual_Network_CreateResourceGroup
            ArmClient armClient = new ArmClient(new DefaultAzureCredential());
            ResourceGroupContainer rgContainer = armClient.DefaultSubscription.GetResourceGroups();
            string rgName = "myResourceGroup";
            ResourceGroup resourceGroup = await rgContainer.Construct(Location.WestUS2).CreateOrUpdateAsync(rgName);
            #endregion Snippet:Creating_A_Virtual_Network_CreateResourceGroup
        }
    }
}
