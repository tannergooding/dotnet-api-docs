﻿
// The following code example encodes a string into an array of bytes,
// and then decodes the bytes into an array of characters.
// <Snippet1>
using namespace System;
using namespace System::Text;
void PrintCountsAndChars( array<Byte>^bytes, Encoding^ enc );
int main()
{
   
   // Create two instances of UTF32Encoding: one with little-endian byte order and one with big-endian byte order.
   Encoding^ u32LE = Encoding::GetEncoding( "utf-32" );
   Encoding^ u32BE = Encoding::GetEncoding( "utf-32BE" );
   
   // Use a string containing the following characters:
   //    Latin Small Letter Z (U+007A)
   //    Latin Small Letter A (U+0061)
   //    Combining Breve (U+0306)
   //    Latin Small Letter AE With Acute (U+01FD)
   //    Greek Small Letter Beta (U+03B2)
   String^ myStr = "za\u0306\u01FD\u03B2";
   
   // Encode the string using the big-endian byte order.
   array<Byte>^barrBE = gcnew array<Byte>(u32BE->GetByteCount( myStr ));
   u32BE->GetBytes( myStr, 0, myStr->Length, barrBE, 0 );
   
   // Encode the string using the little-endian byte order.
   array<Byte>^barrLE = gcnew array<Byte>(u32LE->GetByteCount( myStr ));
   u32LE->GetBytes( myStr, 0, myStr->Length, barrLE, 0 );
   
   // Get the char counts, and decode the byte arrays.
   Console::Write( "BE array with BE encoding : " );
   PrintCountsAndChars( barrBE, u32BE );
   Console::Write( "LE array with LE encoding : " );
   PrintCountsAndChars( barrLE, u32LE );
}

void PrintCountsAndChars( array<Byte>^bytes, Encoding^ enc )
{
   
   // Display the name of the encoding used.
   Console::Write( "{0,-25} :", enc );
   
   // Display the exact character count.
   int iCC = enc->GetCharCount( bytes );
   Console::Write( " {0,-3}", iCC );
   
   // Display the maximum character count.
   int iMCC = enc->GetMaxCharCount( bytes->Length );
   Console::Write( " {0,-3} :", iMCC );
   
   // Decode the bytes and display the characters.
   array<Char>^chars = enc->GetChars( bytes );
   Console::WriteLine( chars );
}

/* 
This code produces the following output.  The question marks take the place of characters that cannot be displayed at the console.

BE array with BE encoding : System.Text.UTF32Encoding : 5   12  :zăǽβ
LE array with LE encoding : System.Text.UTF32Encoding : 5   12  :zăǽβ

*/
// </Snippet1>
