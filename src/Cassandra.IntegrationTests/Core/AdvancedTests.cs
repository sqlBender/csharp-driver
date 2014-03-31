//
//      Copyright (C) 2012 DataStax Inc.
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//      http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
//
﻿using System;
#if MYTEST
using MyTest;
#else
using Microsoft.VisualStudio.TestTools.UnitTesting;
#endif

namespace Cassandra.MSTest
{
    public partial class AdvancedTests
    {
        [TestMethod]
        [WorksForMe]
        [Stress]
        public void ParallelInsert()
        {
            parallelInsertTest();
        }

        [TestMethod]
        [WorksForMe]
        [Stress]
        public void ErrorInjectionParallelInsert()
        {
            ErrorInjectionInParallelInsertTest();
        }

        [TestMethod]
        [WorksForMe]
        [Stress]
        public void MassiveAsync()
        {
            MassiveAsyncTest();
        }

        [TestMethod]
        [WorksForMe]
        [Stress]
        public void ErrorInjectionMassiveAsync()
        {
            MassiveAsyncErrorInjectionTest();
        }

        [TestMethod]
        [WorksForMe]
        public void ShutdownAsync()
        {
            ShutdownAsyncTest();
        }
    }
}