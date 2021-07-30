﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.MachineLearningServices.Models;
using Azure.ResourceManager.MachineLearningServices.Tests.Extensions;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Resources.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.MachineLearningServices.Tests.ScenarioTests
{
    public class TemplateOperationsTests : MachineLearningServicesManagerTestBase
    {
        private const string ResourceGroupNamePrefix = "test-TemplateOperations";
        private const string WorkspacePrefix = "test-workspace";
        private const string ParentPrefix = "test-parent";
        private const string ResourceNamePrefix = "test-resource";
        private readonly Location _defaultLocation = Location.WestUS2;
        private string _resourceName = ResourceNamePrefix;
        private string _workspaceName = WorkspacePrefix;
        private string _resourceGroupName = ResourceGroupNamePrefix;
        private string _parentPrefix = ParentPrefix;

        public TemplateOperationsTests(bool isAsync)
            : base(isAsync)
        {
        }

        [OneTimeSetUp]
        public async Task SetupResources()
        {
            _parentPrefix = SessionRecording.GenerateAssetName(ParentPrefix);
            _resourceName = SessionRecording.GenerateAssetName(ResourceNamePrefix);
            _resourceGroupName = SessionRecording.GenerateAssetName(ResourceGroupNamePrefix);

            // Create RG and Res with GlobalClient
            ResourceGroup rg = await GlobalClient.DefaultSubscription.GetResourceGroups()
                .CreateOrUpdateAsync(_resourceGroupName, new ResourceGroupData(_defaultLocation));

            Workspace ws = await rg.GetWorkspaces().CreateOrUpdateAsync(
                _workspaceName,
                DataHelper.GenerateWorkspaceData());

            EnvironmentContainerResource parent = await ws.GetEnvironmentContainerResources().CreateOrUpdateAsync(
                _parentPrefix,
                DataHelper.GenerateEnvironmentContainerResourceData());

            _ = await parent.GetTemplates().CreateOrUpdateAsync(
                _resourceName,
                DataHelper.GenerateTemplateData());
            StopSessionRecording();
        }

        [TestCase]
        [RecordedTest]
        public async Task Delete()
        {
            ResourceGroup rg = await Client.DefaultSubscription.GetResourceGroups().GetAsync(_resourceGroupName);
            Workspace ws = await rg.GetWorkspaces().GetAsync(_workspaceName);
            EnvironmentContainerResource parent = await ws.GetEnvironmentContainerResources().GetAsync(_parentPrefix);

            var deleteResourceName = Recording.GenerateAssetName(ResourceNamePrefix) + "_delete";
            Template res = null;
            Assert.DoesNotThrowAsync(async () => res = await parent.GetTemplates().CreateOrUpdateAsync(
                deleteResourceName,
                DataHelper.GenerateTemplateData()));
            Assert.DoesNotThrowAsync(async () => _ = await res.DeleteAsync());
        }

        [TestCase]
        [RecordedTest]
        public async Task Get()
        {
            ResourceGroup rg = await Client.DefaultSubscription.GetResourceGroups().GetAsync(_resourceGroupName);
            Workspace ws = await rg.GetWorkspaces().GetAsync(_workspaceName);
            EnvironmentContainerResource parent = await ws.GetEnvironmentContainerResources().GetAsync(_parentPrefix);

            Template resource = await parent.GetTemplates().GetAsync(_resourceName);
            Template resource1 = await resource.GetAsync();
            resource.AssertAreEqual(resource1);
        }

        [TestCase]
        [RecordedTest]
        public async Task Update()
        {
            ResourceGroup rg = await Client.DefaultSubscription.GetResourceGroups().GetAsync(_resourceGroupName);
            Workspace ws = await rg.GetWorkspaces().GetAsync(_workspaceName);
            EnvironmentContainerResource parent = await ws.GetEnvironmentContainerResources().GetAsync(_parentPrefix);

            Template resource = await parent.GetTemplates().GetAsync(_resourceName);
            var update = new ScaleSettings(5);
            Template updatedResource = await resource.UpdateAsync(update);
            Assert.AreEqual("Updated", updatedResource.Data.Properties.Description);
        }
    }
}
