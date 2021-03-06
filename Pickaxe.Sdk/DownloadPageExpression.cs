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

using System.Linq;

namespace Pickaxe.Sdk
{
    public class DownloadPageExpression : AstNode
    {
        public AstNode Statement
        {
            get
            {
                return Children.Where(x => x.GetType() != typeof(ThreadTableHint) &&
                    x.GetType() != typeof(JSTableHint) && x.GetType() != typeof(JavascriptCode)).Single();
            }
        }

        public JavascriptCode JavascriptCode
        {
            get
            {
                return Children.Where(x => x.GetType() == typeof(JavascriptCode)).Cast<JavascriptCode>().SingleOrDefault();
            }
        }

        public ThreadTableHint ThreadHint
        {
            get
            {
                var hint = Children.Where(x => x.GetType() == typeof(ThreadTableHint)).Cast<ThreadTableHint>().SingleOrDefault();
                if(hint == null)
                    hint = Parent.Children.Where(x => x.GetType() == typeof(ThreadTableHint)).Cast<ThreadTableHint>().SingleOrDefault();

                return hint;
            }
        }

        public JSTableHint JSTableHint
        {
            get
            {
                var hint = Children.Where(x => x.GetType() == typeof(JSTableHint)).Cast<JSTableHint>().SingleOrDefault();
                if (hint == null)
                    hint = Parent.Children.Where(x => x.GetType() == typeof(JSTableHint)).Cast<JSTableHint>().SingleOrDefault();

                return hint;
            }
        }

        public override void Accept(IAstVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
