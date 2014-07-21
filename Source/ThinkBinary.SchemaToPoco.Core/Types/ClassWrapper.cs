﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkBinary.SchemaToPoco.Core.Types
{
    /// <summary>
    /// Wrapper for a CodeDom class.
    /// </summary>
    public class ClassWrapper : BaseWrapper<CodeTypeDeclaration>
    {
        public ClassWrapper(CodeTypeDeclaration cl)
            : base(cl)
        {
            Property.IsClass = true;
        }

        public void AddInterface(string name)
        {
            Property.BaseTypes.Add(new CodeTypeReference(name));
        }
    }
}
