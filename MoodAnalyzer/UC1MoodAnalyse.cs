﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class UC1MoodAnalyse
    {
        public string AnalyseMood(string message)
        {
            message = message.ToLower();
            if (message.Contains("happy"))
            {
                return "happy";
            }
            else
            {
                return "sad";
            }
        }
    }
}
Footer