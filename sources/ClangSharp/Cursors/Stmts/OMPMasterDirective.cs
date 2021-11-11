// Copyright (c) .NET Foundation and Contributors. All rights reserved. Licensed under the University of Illinois/NCSA Open Source License. See LICENSE.txt in the project root for license information.

using ClangSharp.Interop;

namespace ClangSharp
{
    public sealed class OMPMasterDirective : OMPExecutableDirective
    {
        internal OMPMasterDirective(CXCursor handle) : base(handle, CXCursorKind.CXCursor_OMPMasterDirective, CX_StmtClass.CX_StmtClass_OMPMasterDirective)
        {
        }
    }
}
