/*
 * Copyright (c) 2016 Billy Wolfington
 *
 * This software may be modified and distributed under the terms
 * of the MIT license.  See the LICENSE file for details.
 * 
 * https://github.com/piranhacms/piranha.core
 * 
 */

using Piranha.Areas.Manager.Controllers;
using Moq;
using Piranha.Extend;
using System.Collections.Generic;

namespace Piranha.Manager.Tests.Areas.Manager.Controllers
{
    public abstract class ManagerAreaControllerUnitTestBase<TController>
        where TController : ManagerAreaControllerBase
    {
        #region Properties
        #region Protected Properties
        /// <summary>
        /// The controller being tested
        /// </summary>
        protected readonly TController controller;

        /// <summary>
        /// The mocked Piranha api
        /// </summary>
        protected readonly Mock<IApi> mockApi;
        #endregion
        #endregion

        #region Test initialize
        public ManagerAreaControllerUnitTestBase() {
            mockApi = SetupApi();
            controller = SetupController();
            App.Init(mockApi.Object, IncludedModules());
            AdditionalSetupAfterAppInit();
        }

        protected virtual Mock<IApi> SetupApi() {
            var api = new Mock<IApi>();
            api.Setup(a => a.PageTypes.Get()).Returns(new List<PageType>());
            api.Setup(a => a.BlockTypes.Get()).Returns(new List<BlockType>());
            return api;
        }

        protected virtual IModule[] IncludedModules() {
            return null;
        }

        protected abstract TController SetupController();

        protected virtual void AdditionalSetupAfterAppInit() {
            
        }
        #endregion
    }
}