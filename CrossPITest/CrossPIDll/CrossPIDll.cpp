// CrossPIDll.cpp : Defines the exported functions for the DLL application.
//

#include "stdafx.h"
#include <iostream>


extern  "C"
{

    __declspec(dllexport) void __cdecl TheDllFunction()
    {
        std::cout << "TheDllFunction() has been called" << std::endl;
    }

    __declspec(dllexport) void TakeTheDelegate(void(*funcp)(void))
    {
        funcp();
    }
}
