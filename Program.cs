// See https://aka.ms/new-console-template for more information
using System;
using System.IO; // Used to Read or Write Files in the System

public class Ali
{
    public static void Main()
    {
        StreamReader streamReader =  null;
        try
        {
            streamReader = new StreamReader("/home/pi/Documents/C#/data.txt");
            Console.WriteLine(streamReader.ReadToEnd());
        }
        // Always Specific Exceptions at Top otherwiaw you will get Compiler Error
        catch(FileNotFoundException FE) // Specific Exception at Top
        {
            Console.WriteLine(FE.Message);  // Couldn't find file message
            // Console.WriteLine("Couldn't find file: {0}", Ex.FileName);   // Specifies the file not found
            Console.WriteLine("\n-----------------------------------------------------------------------------\n");
            // Console.WriteLine(FE.StackTrace);    // Specifies the line of code on which exception was found
            Console.WriteLine("Please check if the file exists in the specified folder.");    // A Message for User
        }
        catch(DirectoryNotFoundException DE) // Specific Exception
        {
            Console.WriteLine(DE.Message);
            Console.WriteLine("\n-----------------------------------------------------------------------------\n");
            Console.WriteLine("Please check if the specified folder exists.");    // A Message for User
        }
        catch(Exception Ex)  // General Exception
        {
            Console.WriteLine(Ex.Message);
        }
        finally // Always Close in Finally Block with a Condition
        {
            if (streamReader != null)
            {
            streamReader.Close();
            }
        }
    }
}