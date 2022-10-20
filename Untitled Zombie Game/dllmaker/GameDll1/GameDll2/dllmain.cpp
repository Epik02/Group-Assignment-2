// dllmain.cpp : Defines the entry point for the DLL application.
#include "pch.h"
#include <string>

//extern "C" { __declspec(dllexport) const char* ReadLevelLayout(); }
extern "C" { __declspec(dllexport) INT ReturnInt(); }
extern "C" { __declspec(dllexport) FLOAT ReturnFloat(); }
extern "C" { __declspec(dllexport) INT AddTwo(INT x, INT y); }
extern "C" { __declspec(dllexport) INT SubtractTwo(INT x, INT y); }
extern "C" { __declspec(dllexport) FLOAT SubtractFloats(FLOAT x, FLOAT y); }

BOOL APIENTRY DllMain(HMODULE hModule,
    DWORD  ul_reason_for_call,
    LPVOID lpReserved
)
{
    switch (ul_reason_for_call)
    {
    case DLL_PROCESS_ATTACH:
    case DLL_THREAD_ATTACH:
    case DLL_THREAD_DETACH:
    case DLL_PROCESS_DETACH:
        break;
    }
    return TRUE;
}

//const char* ReadLevelLayout() {
//    std::string str = "abcdef123";
//    return str.c_str();
//}

INT ReturnInt() {
    FLOAT x = 69;
    return x;
}

FLOAT ReturnFloat() {
    FLOAT x = 5.2;
    return x;
}

FLOAT SubtractFloats(FLOAT x, FLOAT y) {
    FLOAT result = x - y;
    return result;
}

INT AddTwo(INT x, INT y) {
    return x + y;
}

INT SubtractTwo(INT x, INT y) {
    INT result = x - y;
    return result;
}