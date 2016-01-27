// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license. See license.txt file in the project root for full license information.
namespace Textamina.Scriban.Runtime
{
    [ScriptSyntax("function statement", "func <variable> ... end")]
    public class ScriptFunction : ScriptStatement
    {
        public ScriptVariable Name { get; set; }

        public ScriptStatement Body { get; set; }

        public override void Evaluate(TemplateContext context)
        {
            context.SetValue(Name, this);
        }

        public override string ToString()
        {
            return $"func {Name} ... end";
        }
    }
}