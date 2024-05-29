// Copyright Epic Games, Inc. All Rights Reserved.

#include "FF_Brotli.h"

#define LOCTEXT_NAMESPACE "FFF_BrotliModule"

void FFF_BrotliModule::StartupModule()
{
	// This code will execute after your module is loaded into memory; the exact timing is specified in the .uplugin file per-module
	
}

void FFF_BrotliModule::ShutdownModule()
{
	// This function may be called during shutdown to clean up your module.  For modules that support dynamic reloading,
	// we call this function before unloading the module.
	
}

#undef LOCTEXT_NAMESPACE
	
IMPLEMENT_MODULE(FFF_BrotliModule, FF_Brotli)