﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MoodAnalyser.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Janardan Das"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Class1
{
    using System;
    public class MoodAnalyser
    {
        public string str;
       
        public MoodAnalyser(string message)
        {
            this.str = message;
        }
        public static string AnalysisMoodFunction(string strr)
        {
            if (strr.ToLower().Contains("sad"))
            {
                return "Sad mood";
            }
            return "Happy";
            //return "sad";
        }      
        public string AnalysisMoodFunctionWithConstructor()
        {
           
            if (str.ToLower().Contains("sad"))
            {
                return "sad";
            }
            return "Happy";
            
        }
    }
}
