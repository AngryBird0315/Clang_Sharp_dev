// Copyright (c) .NET Foundation and Contributors. All Rights Reserved. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from https://github.com/dotnet/clangsharp/blob/main/sources/libClangSharp

namespace ClangSharp.Interop;

public enum CX_AttrKind
{
    CX_AttrKind_Invalid,
    CX_AttrKind_AddressSpace,
    CX_AttrKind_AnnotateType,
    CX_AttrKind_ArmMveStrictPolymorphism,
    CX_AttrKind_BTFTypeTag,
    CX_AttrKind_CmseNSCall,
    CX_AttrKind_HLSLGroupSharedAddressSpace,
    CX_AttrKind_NoDeref,
    CX_AttrKind_ObjCGC,
    CX_AttrKind_ObjCInertUnsafeUnretained,
    CX_AttrKind_ObjCKindOf,
    CX_AttrKind_OpenCLConstantAddressSpace,
    CX_AttrKind_OpenCLGenericAddressSpace,
    CX_AttrKind_OpenCLGlobalAddressSpace,
    CX_AttrKind_OpenCLGlobalDeviceAddressSpace,
    CX_AttrKind_OpenCLGlobalHostAddressSpace,
    CX_AttrKind_OpenCLLocalAddressSpace,
    CX_AttrKind_OpenCLPrivateAddressSpace,
    CX_AttrKind_Ptr32,
    CX_AttrKind_Ptr64,
    CX_AttrKind_SPtr,
    CX_AttrKind_TypeNonNull,
    CX_AttrKind_TypeNullUnspecified,
    CX_AttrKind_TypeNullable,
    CX_AttrKind_TypeNullableResult,
    CX_AttrKind_UPtr,
    CX_AttrKind_FallThrough,
    CX_AttrKind_Likely,
    CX_AttrKind_MustTail,
    CX_AttrKind_OpenCLUnrollHint,
    CX_AttrKind_Suppress,
    CX_AttrKind_Unlikely,
    CX_AttrKind_AlwaysInline,
    CX_AttrKind_NoInline,
    CX_AttrKind_NoMerge,
    CX_AttrKind_AArch64SVEPcs,
    CX_AttrKind_AArch64VectorPcs,
    CX_AttrKind_AMDGPUKernelCall,
    CX_AttrKind_AcquireHandle,
    CX_AttrKind_AnyX86NoCfCheck,
    CX_AttrKind_CDecl,
    CX_AttrKind_FastCall,
    CX_AttrKind_IntelOclBicc,
    CX_AttrKind_LifetimeBound,
    CX_AttrKind_MSABI,
    CX_AttrKind_NSReturnsRetained,
    CX_AttrKind_ObjCOwnership,
    CX_AttrKind_Pascal,
    CX_AttrKind_Pcs,
    CX_AttrKind_PreserveAll,
    CX_AttrKind_PreserveMost,
    CX_AttrKind_RegCall,
    CX_AttrKind_StdCall,
    CX_AttrKind_SwiftAsyncCall,
    CX_AttrKind_SwiftCall,
    CX_AttrKind_SysVABI,
    CX_AttrKind_ThisCall,
    CX_AttrKind_VectorCall,
    CX_AttrKind_SwiftAsyncContext,
    CX_AttrKind_SwiftContext,
    CX_AttrKind_SwiftErrorResult,
    CX_AttrKind_SwiftIndirectResult,
    CX_AttrKind_Annotate,
    CX_AttrKind_CFConsumed,
    CX_AttrKind_CarriesDependency,
    CX_AttrKind_NSConsumed,
    CX_AttrKind_NonNull,
    CX_AttrKind_OSConsumed,
    CX_AttrKind_PassObjectSize,
    CX_AttrKind_ReleaseHandle,
    CX_AttrKind_UseHandle,
    CX_AttrKind_HLSLSV_DispatchThreadID,
    CX_AttrKind_HLSLSV_GroupIndex,
    CX_AttrKind_AMDGPUFlatWorkGroupSize,
    CX_AttrKind_AMDGPUNumSGPR,
    CX_AttrKind_AMDGPUNumVGPR,
    CX_AttrKind_AMDGPUWavesPerEU,
    CX_AttrKind_ARMInterrupt,
    CX_AttrKind_AVRInterrupt,
    CX_AttrKind_AVRSignal,
    CX_AttrKind_AcquireCapability,
    CX_AttrKind_AcquiredAfter,
    CX_AttrKind_AcquiredBefore,
    CX_AttrKind_AlignMac68k,
    CX_AttrKind_AlignNatural,
    CX_AttrKind_Aligned,
    CX_AttrKind_AllocAlign,
    CX_AttrKind_AllocSize,
    CX_AttrKind_AlwaysDestroy,
    CX_AttrKind_AnalyzerNoReturn,
    CX_AttrKind_AnyX86Interrupt,
    CX_AttrKind_AnyX86NoCallerSavedRegisters,
    CX_AttrKind_ArcWeakrefUnavailable,
    CX_AttrKind_ArgumentWithTypeTag,
    CX_AttrKind_ArmBuiltinAlias,
    CX_AttrKind_Artificial,
    CX_AttrKind_AsmLabel,
    CX_AttrKind_AssertCapability,
    CX_AttrKind_AssertExclusiveLock,
    CX_AttrKind_AssertSharedLock,
    CX_AttrKind_AssumeAligned,
    CX_AttrKind_Assumption,
    CX_AttrKind_Availability,
    CX_AttrKind_BPFPreserveAccessIndex,
    CX_AttrKind_BTFDeclTag,
    CX_AttrKind_Blocks,
    CX_AttrKind_Builtin,
    CX_AttrKind_C11NoReturn,
    CX_AttrKind_CFAuditedTransfer,
    CX_AttrKind_CFGuard,
    CX_AttrKind_CFICanonicalJumpTable,
    CX_AttrKind_CFReturnsNotRetained,
    CX_AttrKind_CFReturnsRetained,
    CX_AttrKind_CFUnknownTransfer,
    CX_AttrKind_CPUDispatch,
    CX_AttrKind_CPUSpecific,
    CX_AttrKind_CUDAConstant,
    CX_AttrKind_CUDADevice,
    CX_AttrKind_CUDADeviceBuiltinSurfaceType,
    CX_AttrKind_CUDADeviceBuiltinTextureType,
    CX_AttrKind_CUDAGlobal,
    CX_AttrKind_CUDAHost,
    CX_AttrKind_CUDAInvalidTarget,
    CX_AttrKind_CUDALaunchBounds,
    CX_AttrKind_CUDAShared,
    CX_AttrKind_CXX11NoReturn,
    CX_AttrKind_CallableWhen,
    CX_AttrKind_Callback,
    CX_AttrKind_Capability,
    CX_AttrKind_CapturedRecord,
    CX_AttrKind_Cleanup,
    CX_AttrKind_CmseNSEntry,
    CX_AttrKind_CodeSeg,
    CX_AttrKind_Cold,
    CX_AttrKind_Common,
    CX_AttrKind_Const,
    CX_AttrKind_ConstInit,
    CX_AttrKind_Constructor,
    CX_AttrKind_Consumable,
    CX_AttrKind_ConsumableAutoCast,
    CX_AttrKind_ConsumableSetOnRead,
    CX_AttrKind_Convergent,
    CX_AttrKind_DLLExport,
    CX_AttrKind_DLLExportStaticLocal,
    CX_AttrKind_DLLImport,
    CX_AttrKind_DLLImportStaticLocal,
    CX_AttrKind_Deprecated,
    CX_AttrKind_Destructor,
    CX_AttrKind_DiagnoseAsBuiltin,
    CX_AttrKind_DiagnoseIf,
    CX_AttrKind_DisableSanitizerInstrumentation,
    CX_AttrKind_DisableTailCalls,
    CX_AttrKind_EmptyBases,
    CX_AttrKind_EnableIf,
    CX_AttrKind_EnforceTCB,
    CX_AttrKind_EnforceTCBLeaf,
    CX_AttrKind_EnumExtensibility,
    CX_AttrKind_Error,
    CX_AttrKind_ExcludeFromExplicitInstantiation,
    CX_AttrKind_ExclusiveTrylockFunction,
    CX_AttrKind_ExternalSourceSymbol,
    CX_AttrKind_Final,
    CX_AttrKind_FlagEnum,
    CX_AttrKind_Flatten,
    CX_AttrKind_Format,
    CX_AttrKind_FormatArg,
    CX_AttrKind_FunctionReturnThunks,
    CX_AttrKind_GNUInline,
    CX_AttrKind_GuardedBy,
    CX_AttrKind_GuardedVar,
    CX_AttrKind_HIPManaged,
    CX_AttrKind_HLSLNumThreads,
    CX_AttrKind_HLSLResource,
    CX_AttrKind_HLSLResourceBinding,
    CX_AttrKind_HLSLShader,
    CX_AttrKind_Hot,
    CX_AttrKind_IBAction,
    CX_AttrKind_IBOutlet,
    CX_AttrKind_IBOutletCollection,
    CX_AttrKind_InitPriority,
    CX_AttrKind_InternalLinkage,
    CX_AttrKind_LTOVisibilityPublic,
    CX_AttrKind_LayoutVersion,
    CX_AttrKind_Leaf,
    CX_AttrKind_LockReturned,
    CX_AttrKind_LocksExcluded,
    CX_AttrKind_M68kInterrupt,
    CX_AttrKind_MIGServerRoutine,
    CX_AttrKind_MSAllocator,
    CX_AttrKind_MSInheritance,
    CX_AttrKind_MSNoVTable,
    CX_AttrKind_MSP430Interrupt,
    CX_AttrKind_MSStruct,
    CX_AttrKind_MSVtorDisp,
    CX_AttrKind_MaxFieldAlignment,
    CX_AttrKind_MayAlias,
    CX_AttrKind_MaybeUndef,
    CX_AttrKind_MicroMips,
    CX_AttrKind_MinSize,
    CX_AttrKind_MinVectorWidth,
    CX_AttrKind_Mips16,
    CX_AttrKind_MipsInterrupt,
    CX_AttrKind_MipsLongCall,
    CX_AttrKind_MipsShortCall,
    CX_AttrKind_NSConsumesSelf,
    CX_AttrKind_NSErrorDomain,
    CX_AttrKind_NSReturnsAutoreleased,
    CX_AttrKind_NSReturnsNotRetained,
    CX_AttrKind_Naked,
    CX_AttrKind_NoAlias,
    CX_AttrKind_NoCommon,
    CX_AttrKind_NoDebug,
    CX_AttrKind_NoDestroy,
    CX_AttrKind_NoDuplicate,
    CX_AttrKind_NoInstrumentFunction,
    CX_AttrKind_NoMicroMips,
    CX_AttrKind_NoMips16,
    CX_AttrKind_NoProfileFunction,
    CX_AttrKind_NoRandomizeLayout,
    CX_AttrKind_NoReturn,
    CX_AttrKind_NoSanitize,
    CX_AttrKind_NoSpeculativeLoadHardening,
    CX_AttrKind_NoSplitStack,
    CX_AttrKind_NoStackProtector,
    CX_AttrKind_NoThreadSafetyAnalysis,
    CX_AttrKind_NoThrow,
    CX_AttrKind_NoUniqueAddress,
    CX_AttrKind_NoUwtable,
    CX_AttrKind_NotTailCalled,
    CX_AttrKind_OMPAllocateDecl,
    CX_AttrKind_OMPCaptureNoInit,
    CX_AttrKind_OMPDeclareTargetDecl,
    CX_AttrKind_OMPDeclareVariant,
    CX_AttrKind_OMPThreadPrivateDecl,
    CX_AttrKind_OSConsumesThis,
    CX_AttrKind_OSReturnsNotRetained,
    CX_AttrKind_OSReturnsRetained,
    CX_AttrKind_OSReturnsRetainedOnNonZero,
    CX_AttrKind_OSReturnsRetainedOnZero,
    CX_AttrKind_ObjCBridge,
    CX_AttrKind_ObjCBridgeMutable,
    CX_AttrKind_ObjCBridgeRelated,
    CX_AttrKind_ObjCException,
    CX_AttrKind_ObjCExplicitProtocolImpl,
    CX_AttrKind_ObjCExternallyRetained,
    CX_AttrKind_ObjCIndependentClass,
    CX_AttrKind_ObjCMethodFamily,
    CX_AttrKind_ObjCNSObject,
    CX_AttrKind_ObjCPreciseLifetime,
    CX_AttrKind_ObjCRequiresPropertyDefs,
    CX_AttrKind_ObjCRequiresSuper,
    CX_AttrKind_ObjCReturnsInnerPointer,
    CX_AttrKind_ObjCRootClass,
    CX_AttrKind_ObjCSubclassingRestricted,
    CX_AttrKind_OpenCLIntelReqdSubGroupSize,
    CX_AttrKind_OpenCLKernel,
    CX_AttrKind_OptimizeNone,
    CX_AttrKind_Override,
    CX_AttrKind_Owner,
    CX_AttrKind_Ownership,
    CX_AttrKind_Packed,
    CX_AttrKind_ParamTypestate,
    CX_AttrKind_PatchableFunctionEntry,
    CX_AttrKind_Pointer,
    CX_AttrKind_PragmaClangBSSSection,
    CX_AttrKind_PragmaClangDataSection,
    CX_AttrKind_PragmaClangRelroSection,
    CX_AttrKind_PragmaClangRodataSection,
    CX_AttrKind_PragmaClangTextSection,
    CX_AttrKind_PreferredName,
    CX_AttrKind_PtGuardedBy,
    CX_AttrKind_PtGuardedVar,
    CX_AttrKind_Pure,
    CX_AttrKind_RISCVInterrupt,
    CX_AttrKind_RandomizeLayout,
    CX_AttrKind_ReadOnlyPlacement,
    CX_AttrKind_Reinitializes,
    CX_AttrKind_ReleaseCapability,
    CX_AttrKind_ReqdWorkGroupSize,
    CX_AttrKind_RequiresCapability,
    CX_AttrKind_Restrict,
    CX_AttrKind_Retain,
    CX_AttrKind_ReturnTypestate,
    CX_AttrKind_ReturnsNonNull,
    CX_AttrKind_ReturnsTwice,
    CX_AttrKind_SYCLKernel,
    CX_AttrKind_SYCLSpecialClass,
    CX_AttrKind_ScopedLockable,
    CX_AttrKind_Section,
    CX_AttrKind_SelectAny,
    CX_AttrKind_Sentinel,
    CX_AttrKind_SetTypestate,
    CX_AttrKind_SharedTrylockFunction,
    CX_AttrKind_SpeculativeLoadHardening,
    CX_AttrKind_StandaloneDebug,
    CX_AttrKind_StrictFP,
    CX_AttrKind_StrictGuardStackCheck,
    CX_AttrKind_SwiftAsync,
    CX_AttrKind_SwiftAsyncError,
    CX_AttrKind_SwiftAsyncName,
    CX_AttrKind_SwiftAttr,
    CX_AttrKind_SwiftBridge,
    CX_AttrKind_SwiftBridgedTypedef,
    CX_AttrKind_SwiftError,
    CX_AttrKind_SwiftName,
    CX_AttrKind_SwiftNewType,
    CX_AttrKind_SwiftPrivate,
    CX_AttrKind_TLSModel,
    CX_AttrKind_Target,
    CX_AttrKind_TargetClones,
    CX_AttrKind_TargetVersion,
    CX_AttrKind_TestTypestate,
    CX_AttrKind_TransparentUnion,
    CX_AttrKind_TrivialABI,
    CX_AttrKind_TryAcquireCapability,
    CX_AttrKind_TypeTagForDatatype,
    CX_AttrKind_TypeVisibility,
    CX_AttrKind_Unavailable,
    CX_AttrKind_Uninitialized,
    CX_AttrKind_Unused,
    CX_AttrKind_Used,
    CX_AttrKind_UsingIfExists,
    CX_AttrKind_Uuid,
    CX_AttrKind_VecReturn,
    CX_AttrKind_VecTypeHint,
    CX_AttrKind_Visibility,
    CX_AttrKind_WarnUnused,
    CX_AttrKind_WarnUnusedResult,
    CX_AttrKind_Weak,
    CX_AttrKind_WeakImport,
    CX_AttrKind_WeakRef,
    CX_AttrKind_WebAssemblyExportName,
    CX_AttrKind_WebAssemblyImportModule,
    CX_AttrKind_WebAssemblyImportName,
    CX_AttrKind_WorkGroupSizeHint,
    CX_AttrKind_X86ForceAlignArgPointer,
    CX_AttrKind_XRayInstrument,
    CX_AttrKind_XRayLogArgs,
    CX_AttrKind_ZeroCallUsedRegs,
    CX_AttrKind_AbiTag,
    CX_AttrKind_Alias,
    CX_AttrKind_AlignValue,
    CX_AttrKind_BuiltinAlias,
    CX_AttrKind_CalledOnce,
    CX_AttrKind_IFunc,
    CX_AttrKind_InitSeg,
    CX_AttrKind_LoaderUninitialized,
    CX_AttrKind_LoopHint,
    CX_AttrKind_Mode,
    CX_AttrKind_NoBuiltin,
    CX_AttrKind_NoEscape,
    CX_AttrKind_OMPCaptureKind,
    CX_AttrKind_OMPDeclareSimdDecl,
    CX_AttrKind_OMPReferencedVar,
    CX_AttrKind_ObjCBoxable,
    CX_AttrKind_ObjCClassStub,
    CX_AttrKind_ObjCDesignatedInitializer,
    CX_AttrKind_ObjCDirect,
    CX_AttrKind_ObjCDirectMembers,
    CX_AttrKind_ObjCNonLazyClass,
    CX_AttrKind_ObjCNonRuntimeProtocol,
    CX_AttrKind_ObjCRuntimeName,
    CX_AttrKind_ObjCRuntimeVisible,
    CX_AttrKind_OpenCLAccess,
    CX_AttrKind_Overloadable,
    CX_AttrKind_RenderScriptKernel,
    CX_AttrKind_SwiftObjCMembers,
    CX_AttrKind_Thread,
    CX_AttrKind_FirstAttr = CX_AttrKind_AddressSpace,
    CX_AttrKind_LastAttr = CX_AttrKind_Thread,
    CX_AttrKind_FirstTypeAttr = CX_AttrKind_AddressSpace,
    CX_AttrKind_LastTypeAttr = CX_AttrKind_UPtr,
    CX_AttrKind_FirstStmtAttr = CX_AttrKind_FallThrough,
    CX_AttrKind_LastStmtAttr = CX_AttrKind_Unlikely,
    CX_AttrKind_FirstDeclOrStmtAttr = CX_AttrKind_AlwaysInline,
    CX_AttrKind_LastDeclOrStmtAttr = CX_AttrKind_NoMerge,
    CX_AttrKind_FirstInheritableAttr = CX_AttrKind_AlwaysInline,
    CX_AttrKind_LastInheritableAttr = CX_AttrKind_ZeroCallUsedRegs,
    CX_AttrKind_FirstDeclOrTypeAttr = CX_AttrKind_AArch64SVEPcs,
    CX_AttrKind_LastDeclOrTypeAttr = CX_AttrKind_VectorCall,
    CX_AttrKind_FirstInheritableParamAttr = CX_AttrKind_SwiftAsyncContext,
    CX_AttrKind_LastInheritableParamAttr = CX_AttrKind_UseHandle,
    CX_AttrKind_FirstParameterABIAttr = CX_AttrKind_SwiftAsyncContext,
    CX_AttrKind_LastParameterABIAttr = CX_AttrKind_SwiftIndirectResult,
    CX_AttrKind_FirstHLSLAnnotationAttr = CX_AttrKind_HLSLSV_DispatchThreadID,
    CX_AttrKind_LastHLSLAnnotationAttr = CX_AttrKind_HLSLSV_GroupIndex,
}
