Console.WriteLine ("Type Conversion");

// Checking Type
//GetType
int myInt = 123;
Console.WriteLine(myInt.GetType()); // Outputs: System.Int32


// Implicit Conversion
int iValue = 125;
long lValue = iValue;       // 125
double dValue = iValue;     // 125 -- vice versa isnt possible, it will throw compilation error

// Explicit Conversion
long lValue1  = 123123871283827;
double dValue1 = 123.45;
// int iValue1 = (int) lValue1; // this will cause runtime error
int iValue1 = (int) dValue1;// 123

// Convert Class
string sNumberString = "123";
int iNumFromString = Convert.ToInt32(sNumberString);
double dDoubleFromNum = Convert.ToDouble(iNumFromString);
string sBoolString = "true";
bool bBooleanFromString = Convert.ToBoolean (sBoolString);
DateTime dateTime = new DateTime(2024, 2, 09, 10, 30, 0);
string sFromDate = Convert.ToString(dateTime);

// Using Parse
string sString1 = "123";
int iValue3 = int.Parse(sString1);

// Using TryParse
string sTemp = "123";
int iValue4;
if (int.TryParse (sTemp, out iValue4)){
    Console.WriteLine ("Parsing Success ! Parsed Value :" + iValue4);
}
else{
    Console.WriteLine("Parsing Error ! Parsed Value :" + iValue4);
}

