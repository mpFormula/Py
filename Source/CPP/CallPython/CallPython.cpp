// CallPython.cpp : Defines the exported functions for the DLL application.
//

#define _CRT_SECURE_NO_WARNINGS
#include "CallPython.h"
#include "stdafx.h"
#include<stdio.h>
#include <Python.h>


long SetSpecialValue_Long(long m, long n, long what)
	{
		return (m + n + 1) * what;
	}



double SetSpecialValue_Double(double m, double n, double what)
	{
		return (m + n) * what;
	}




int CallPythonFunction(int argc, const char *argv[])
{
    PyObject *pName, *pModule, *pFunc;
    PyObject *pArgs, *pValue;
    int i;

    if (argc < 3) {
        fprintf(stderr,"Usage: call pythonfile funcname [args]\n");
        return 1;
    }

		//numargs = argc;
		//PyImport_AppendInittab("emb", &PyInit_emb);

    Py_Initialize();
    pName = PyUnicode_FromString(argv[1]);
    /* Error checking of pName left out */

		char argtype_string[50];
		strcpy (argtype_string, argv[3]);
		
    pModule = PyImport_Import(pName);
    Py_DECREF(pName);

    if (pModule != NULL) {
        pFunc = PyObject_GetAttrString(pModule, argv[2]);
        /* pFunc is a new reference */

        if (pFunc && PyCallable_Check(pFunc)) {
            pArgs = PyTuple_New(argc - 4);
            for (i = 0; i < argc - 4; ++i) {
							char c = argtype_string[i];
							if (c == 's') {printf("Input Type: s\n");}
              if (c == 'f') {printf("Input Type: f\n");}
							if (c == 'l') {printf("Input Type: l\n");}

							if (c == 's') {pValue = PyUnicode_FromString(argv[i + 4]);;}
              if (c == 'f') {pValue = PyFloat_FromDouble(atof(argv[i + 4]));}
							if (c == 'l') {pValue = PyLong_FromLong(atoi(argv[i + 4]));}

								if (!pValue) {
                    Py_DECREF(pArgs);
                    Py_DECREF(pModule);
                    fprintf(stderr, "Cannot convert argument\n");
                    return 1;
                }
                /* pValue reference stolen here: */
                PyTuple_SetItem(pArgs, i, pValue);
            }
            pValue = PyObject_CallObject(pFunc, pArgs);
            Py_DECREF(pArgs);
            if (pValue != NULL) {
							char c2 = argtype_string[argc-4];
							if (c2 == 's') {printf("Output Type: s\n");}
              if (c2 == 'f') {printf("Output Type: f\n");}
							if (c2 == 'l') {printf("Output Type: l\n");}

							if (c2 == 's') {printf("Result of call: %s\n", PyUnicode_AsUTF8(pValue));}
              if (c2 == 'f') {printf("Result of call: %f\n", PyFloat_AsDouble(pValue));}
							if (c2 == 'l') {printf("Result of call: %ld\n", PyLong_AsLong(pValue));}

								// d = PyFloat_AsDouble(pValue);
                Py_DECREF(pValue);
            }
            else {
                Py_DECREF(pFunc);
                Py_DECREF(pModule);
                PyErr_Print();
                fprintf(stderr,"Call failed\n");
                return 1;
            }
        }
        else {
            if (PyErr_Occurred())
                PyErr_Print();
            fprintf(stderr, "Cannot find function \"%s\"\n", argv[2]);
        }
        Py_XDECREF(pFunc);
        Py_DECREF(pModule);
    }
    else {
        PyErr_Print();
        fprintf(stderr, "Failed to load \"%s\"\n", argv[1]);
        return 1;
    }
    Py_Finalize();


		//char c = getc(stdin);
    return 0;
}



PyObject* GetPythonModule2()
{
	  static PyObject *pModule = NULL;
    PyObject *pName;
    
		if (pModule == NULL) {
		Py_Initialize();
    pName = PyUnicode_FromString("CallMpmath");
    pModule = PyImport_Import(pName);
    Py_DECREF(pName);

    if (pModule != NULL) {
    }
    else {
        PyErr_Print();
        fprintf(stderr, "Failed to load \"%s\"\n", "CallMpmath");
        //return 1;
    }
		}
    //Py_Finalize();
    return pModule;
}




int MyPythonFunction(int argc, const char *argv[])
{
    PyObject *pDict, *pFunc;
    PyObject *pArgs, *pValue;
    int i;

		PyObject *pModule;
		pModule = GetPythonModule2();

		char argtype_string[50];
		strcpy (argtype_string, argv[3-2]);
        pFunc = PyObject_GetAttrString(pModule, argv[2-2]);
        /* pFunc is a new reference */

        if (pFunc && PyCallable_Check(pFunc)) {
            pArgs = PyTuple_New(argc - (4-2));
            for (i = 0; i < argc - (4-2); ++i) {
							char c = argtype_string[i];
							if (c == 's') {printf("Input Type: s\n");}
              if (c == 'f') {printf("Input Type: f\n");}
							if (c == 'l') {printf("Input Type: l\n");}

							if (c == 's') {pValue = PyUnicode_FromString(argv[i + 4-2]);;}
              if (c == 'f') {pValue = PyFloat_FromDouble(atof(argv[i + 4-2]));}
							if (c == 'l') {pValue = PyLong_FromLong(atoi(argv[i + 4-2]));}

								if (!pValue) {
                    Py_DECREF(pArgs);
                    //Py_DECREF(pModule);
                    fprintf(stderr, "Cannot convert argument\n");
                    return 1;
                }
                /* pValue reference stolen here: */
                PyTuple_SetItem(pArgs, i, pValue);
            }
            pValue = PyObject_CallObject(pFunc, pArgs);
            Py_DECREF(pArgs);
            if (pValue != NULL) {
							char c2 = argtype_string[argc-4];
							if (c2 == 's') {printf("Output Type: s\n");}
              if (c2 == 'f') {printf("Output Type: f\n");}
							if (c2 == 'l') {printf("Output Type: l\n");}

							if (c2 == 's') {printf("Result of call: %s\n", PyUnicode_AsUTF8(pValue));}
              if (c2 == 'f') {printf("Result of call: %f\n", PyFloat_AsDouble(pValue));}
							if (c2 == 'l') {printf("Result of call: %ld\n", PyLong_AsLong(pValue));}

								// d = PyFloat_AsDouble(pValue);
                Py_DECREF(pValue);
            }
            else {
                Py_DECREF(pFunc);
                //Py_DECREF(pModule);
                PyErr_Print();
                fprintf(stderr,"Call failed\n");
                return 1;
            }
        }
        else {
            if (PyErr_Occurred())
                PyErr_Print();
            fprintf(stderr, "Cannot find function \"%s\"\n", argv[2]);
        }
        Py_XDECREF(pFunc);

}



int MyPythonFunctionString(int argc, const char *argv[])
{
    PyObject *pDict, *pFunc;
    PyObject *pArgs, *pValue;
    int i;

		PyObject *pModule;
		pModule = GetPythonModule2();

    pFunc = PyObject_GetAttrString(pModule, argv[2-2]);

        if (pFunc && PyCallable_Check(pFunc)) {
            pArgs = PyTuple_New(argc - (4-2));
            for (i = 0; i < argc - (4-2); ++i) {
							pValue = PyUnicode_FromString(argv[i + 4-2]);

								if (!pValue) {
                    Py_DECREF(pArgs);
                    fprintf(stderr, "Cannot convert argument\n");
                    return 1;
                }
                PyTuple_SetItem(pArgs, i, pValue);
            }
            pValue = PyObject_CallObject(pFunc, pArgs);
            Py_DECREF(pArgs);
            if (pValue != NULL) {

							printf("Result of call: %s\n", PyUnicode_AsUTF8(pValue));
              Py_DECREF(pValue);
            }
            else {
                Py_DECREF(pFunc);
                PyErr_Print();
                fprintf(stderr,"Call failed\n");
                return 1;
            }
        }
        else {
            if (PyErr_Occurred())
                PyErr_Print();
            fprintf(stderr, "Cannot find function \"%s\"\n", argv[2-2]);
        }
        Py_XDECREF(pFunc);

}



int MyPythonFunctionString2(int argc, const char *argv[])
{
    PyObject *pDict, *pFunc;
    PyObject *pArgs, *pValue;
    int i;

		PyObject *pModule;
		pModule = GetPythonModule2();

    pFunc = PyObject_GetAttrString(pModule, argv[0]);

        if (pFunc && PyCallable_Check(pFunc)) {
            pArgs = PyTuple_New(argc - 1);
            for (i = 0; i < argc - 1; ++i) {
							pValue = PyUnicode_FromString(argv[i + 1]);

								if (!pValue) {
                    Py_DECREF(pArgs);
                    fprintf(stderr, "Cannot convert argument\n");
                    return 1;
                }
                PyTuple_SetItem(pArgs, i, pValue);
            }
            pValue = PyObject_CallObject(pFunc, pArgs);
            Py_DECREF(pArgs);
            if (pValue != NULL) {

							printf("Result of call: %s\n", PyUnicode_AsUTF8(pValue));
              Py_DECREF(pValue);
            }
            else {
                Py_DECREF(pFunc);
                PyErr_Print();
                fprintf(stderr,"Call failed\n");
                return 1;
            }
        }
        else {
            if (PyErr_Occurred())
                PyErr_Print();
            fprintf(stderr, "Cannot find function \"%s\"\n", argv[0]);
        }
        Py_XDECREF(pFunc);

}


int MyPythonFunctionStringReturn(int argc, const char *argv[], char* buffer, int buffersize)
{
    PyObject *pDict, *pFunc;
    PyObject *pArgs, *pValue;
		Py_ssize_t size1;
		ssize_t size2;

		
    int i;

		PyObject *pModule;
		pModule = GetPythonModule2();

    pFunc = PyObject_GetAttrString(pModule, argv[0]);

        if (pFunc && PyCallable_Check(pFunc)) {
            pArgs = PyTuple_New(argc - 1);
            for (i = 0; i < argc - 1; ++i) {
							pValue = PyUnicode_FromString(argv[i + 1]);

								if (!pValue) {
                    Py_DECREF(pArgs);
                    fprintf(stderr, "Cannot convert argument\n");
                    return 1;
                }
                PyTuple_SetItem(pArgs, i, pValue);
            }
            pValue = PyObject_CallObject(pFunc, pArgs);
            Py_DECREF(pArgs);
            if (pValue != NULL) {

							printf("Result of call: %s\n", PyUnicode_AsUTF8AndSize(pValue, &size1));
							printf("Length of call: %ld\n", size1);
							strncpy(buffer, PyUnicode_AsUTF8(pValue), buffersize-1);
              Py_DECREF(pValue);
            }
            else {
                Py_DECREF(pFunc);
                PyErr_Print();
                fprintf(stderr,"Call failed\n");
                return 1;
            }
        }
        else {
            if (PyErr_Occurred())
                PyErr_Print();
            fprintf(stderr, "Cannot find function \"%s\"\n", argv[0]);
        }
        Py_XDECREF(pFunc);
				return size1;
}


//


int MyPythonFunctionStringReturn00(const char* FuncName, char* buffer, int buffersize)
{
    PyObject *pFunc;
    PyObject *pValue;
		Py_ssize_t size;
		PyObject *pModule= GetPythonModule2();
    pFunc = PyObject_GetAttrString(pModule, FuncName);
    if (pFunc && PyCallable_Check(pFunc)) {
         pValue = PyObject_CallObject(pFunc, NULL);
        if (pValue != NULL) {
					strncpy(buffer, PyUnicode_AsUTF8AndSize(pValue, &size), buffersize-1);
          Py_DECREF(pValue);
        }
    }
    Py_XDECREF(pFunc);
		return size;
}

int MyPythonFunctionStringReturn01(const char* FuncName, const char* Arg01, char* buffer, int buffersize)
{
    PyObject *pFunc, *pArgs, *pValue;
		PyObject *pModule= GetPythonModule2();
		Py_ssize_t size;
		pFunc = PyObject_GetAttrString(pModule, FuncName);
    if (pFunc && PyCallable_Check(pFunc)) {
        pArgs = PyTuple_New(1);
				pValue = PyUnicode_FromString(Arg01);
        PyTuple_SetItem(pArgs, 0, pValue);

        pValue = PyObject_CallObject(pFunc, pArgs);
        Py_DECREF(pArgs);
        if (pValue != NULL) {
					strncpy(buffer, PyUnicode_AsUTF8AndSize(pValue, &size), buffersize-1);
          Py_DECREF(pValue);
        }
    }
    Py_XDECREF(pFunc);
		return size;
}


int MyPythonFunctionStringReturn02(const char* FuncName, const char* Arg01, const char* Arg02, char* buffer, int buffersize)
{
    PyObject *pFunc, *pArgs, *pValue;
		PyObject *pModule= GetPythonModule2();
		Py_ssize_t size;

    pFunc = PyObject_GetAttrString(pModule, FuncName);

    if (pFunc && PyCallable_Check(pFunc)) {
        pArgs = PyTuple_New(2);
				pValue = PyUnicode_FromString(Arg01);
        PyTuple_SetItem(pArgs, 0, pValue);
				
				pValue = PyUnicode_FromString(Arg02);
        PyTuple_SetItem(pArgs, 1, pValue);

        pValue = PyObject_CallObject(pFunc, pArgs);
        Py_DECREF(pArgs);
        if (pValue != NULL) {
					strncpy(buffer, PyUnicode_AsUTF8AndSize(pValue, &size), buffersize-1);
          Py_DECREF(pValue);
        }
    }
    Py_XDECREF(pFunc);
		return size;
}


//
//void StartPy()
//{
//	Py_Initialize();
//}


void ClosePy()
{
		PyObject *pModule;
		pModule = GetPythonModule2();
		Py_DECREF(pModule);
	Py_Finalize();
}



//
//int UnLoadPythonModule(PyObject *pModule)
//{
//	  Py_DECREF(pModule);
//		return 0;
//}

