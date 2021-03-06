﻿/* Copyright 2015 Brock Reeve
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pickaxe.Runtime
{
    public class VariableDownloadTable : ThreadedDownloadTable<DownloadPage>
    {
        private IList<LazyDownloadPage> _pages;

        public VariableDownloadTable(LazyDownloadArgs args)
            : base(args)
        {
             _pages = new List<LazyDownloadPage>();
             InitPages();
        }

        private void InitPages()
        {
            foreach (IHttpWire wire in Wires)
            {
                _pages.Add(new VariableDownloadPage(this));
            }
        }

        protected override RuntimeTable<DownloadPage> Fetch(IRuntime runtime, IHttpWire wire)
        {
            return Http.DownloadPage(runtime, wire);
        }

        public override IEnumerator<DownloadPage> GetEnumerator() //Give out empty lazy wrappers
        {
            return _pages.GetEnumerator();
        }
    }
}
