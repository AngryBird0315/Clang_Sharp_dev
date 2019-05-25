﻿using System.Diagnostics;
using ClangSharp;

namespace ClangSharpPInvokeGenerator
{
    internal sealed class ParenExpr : Expr
    {
        public ParenExpr(CXCursor handle, Cursor parent) : base(handle, parent)
        {
            Debug.Assert(handle.Kind == CXCursorKind.CXCursor_ParenExpr);
        }

        protected override CXChildVisitResult VisitChildren(CXCursor childHandle, CXCursor handle, CXClientData clientData)
        {
            ValidateVisit(ref handle);

            switch (childHandle.Kind)
            {
                case CXCursorKind.CXCursor_DeclRefExpr:
                {
                    return GetOrAddChild<DeclRefExpr>(childHandle).Visit(clientData);
                }

                case CXCursorKind.CXCursor_CallExpr:
                {
                    return GetOrAddChild<CallExpr>(childHandle).Visit(clientData);
                }

                case CXCursorKind.CXCursor_IntegerLiteral:
                {
                    return GetOrAddChild<IntegerLiteral>(childHandle).Visit(clientData);
                }

                case CXCursorKind.CXCursor_FloatingLiteral:
                {
                    return GetOrAddChild<FloatingLiteral>(childHandle).Visit(clientData);
                }

                case CXCursorKind.CXCursor_StringLiteral:
                {
                    return GetOrAddChild<StringLiteral>(childHandle).Visit(clientData);
                }

                case CXCursorKind.CXCursor_CharacterLiteral:
                {
                    return GetOrAddChild<CharacterLiteral>(childHandle).Visit(clientData);
                }

                case CXCursorKind.CXCursor_ParenExpr:
                {
                    return GetOrAddChild<ParenExpr>(childHandle).Visit(clientData);
                }

                case CXCursorKind.CXCursor_UnaryOperator:
                {
                    return GetOrAddChild<UnaryOperator>(childHandle).Visit(clientData);
                }

                case CXCursorKind.CXCursor_ArraySubscriptExpr:
                {
                    return GetOrAddChild<ArraySubscriptExpr>(childHandle).Visit(clientData);
                }

                case CXCursorKind.CXCursor_BinaryOperator:
                {
                    return GetOrAddChild<BinaryOperator>(childHandle).Visit(clientData);
                }

                case CXCursorKind.CXCursor_ConditionalOperator:
                {
                    return GetOrAddChild<ConditionalOperator>(childHandle).Visit(clientData);
                }

                case CXCursorKind.CXCursor_CStyleCastExpr:
                {
                    return GetOrAddChild<CStyleCastExpr>(childHandle).Visit(clientData);
                }

                default:
                {
                    return base.VisitChildren(childHandle, handle, clientData);
                }
            }
        }
    }
}
