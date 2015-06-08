// DemoCallPython.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "CallPython.h"


int main(int argc, const char *argv[])
{
	long ResultLong = SetSpecialValue_Long(2,3,4);
	printf( "This is a long: %d\n",  ResultLong);

	double ResultDouble = SetSpecialValue_Double(2.0,3.0,4.0);
	printf( "This is a double: %f\n",  ResultDouble);

	//const char *sLong[] = {"call", "CallMpmath", "TestLong", "lll", "3", "2"};
	//CallPythonFunction(6, sLong);

	//const char *sDouble[] = {"call", "CallMpmath", "TestDouble", "fff", "3", "2"};
	//CallPythonFunction(6, sDouble);

	//const char *sString[] = {"call", "CallMpmath", "TestStringFunc", "sss", "3", "2"};
	//CallPythonFunction(6, sString);

	//const char *sCode[] = {"call", "CallMpmath", "callfunc2", "lll", "3", "2"};
	//CallPythonFunction(6, sCode);

	const char *sLong2[] = {"TestLong", "lll", "3", "1432"};
	MyPythonFunction(4, sLong2);

	const char *sDouble2[] = {"TestDouble", "fff", "13.5", "265.34"};
	MyPythonFunction(4, sDouble2);

	const char *sString2[] = {"TestStringFunc", "sss", "3", "2"};
	MyPythonFunction(4, sString2);

	const char *sString3[] = {"TestStringMpf2", "3", "2.456"};
	MyPythonFunctionString2(3, sString3);

	char buffer[1600]; // 1600 bytes allocated here on the stack.
  int size0a = MyPythonFunctionStringReturn(3, sString3, buffer, sizeof(buffer));
  printf("New New0a %s\n", buffer); // prints "Mar"
	//printf("Length of string: %ld\n", size0a);



	char buffer0[1600]; // 1600 bytes allocated here on the stack.
  int size0 = MyPythonFunctionStringReturn00("TestStringMpf0", buffer0, sizeof(buffer0));
  printf("New New0 %s\n", buffer0); // prints "Mar"
	//printf("Length of string0: %ld\n", size0);


	char buffer1[1600]; // 1600 bytes allocated here on the stack.
  int size1 = MyPythonFunctionStringReturn01("TestStringMpf1", "3", buffer1, sizeof(buffer1));
  printf("New New1 %s\n", buffer1); // prints "Mar"
	//printf("Length of string: %ld\n", size1);


	char buffer2[1600]; // 1600 bytes allocated here on the stack.
  int size2 = MyPythonFunctionStringReturn02("TestStringMpf2", "3", "2.456", buffer2, sizeof(buffer2));
  printf("New New2 %s\n", buffer2); // prints "Mar"
	//printf("Length of string: %ld\n", size2);

	ClosePy();
	return 0;
}

