// CrossPIDll.cpp : Defines the exported functions for the DLL application.
//

#include "stdafx.h"
#include <iostream>
#include <string>

namespace
{
    void (*theDelegate)(wchar_t const* str) = 0;
}


extern  "C"
{

    __declspec(dllexport) void __cdecl TheDllFunction(const wchar_t* str)
    {
        std::wstring output(str);
        std::wcout << L"TheDllFunction() has been called: " << output << std::endl;
    }

    __declspec(dllexport) void TakeTheDelegate(void(*funcp)(wchar_t const* str))
    {
        theDelegate = funcp;
    }

    __declspec(dllexport) void CallTheDelegate()
    {
        std::wstring str(L"This is passed string");
        theDelegate(str.c_str());
    }
}
