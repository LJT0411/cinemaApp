﻿using CinemaApp.MovieModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaApp.Functions
{
    public class DisplayOutput
    {
        // To Display the output from NowShowing to Now Showing
        public static string DisplayOP(MAvail mvail)
        {
            switch (mvail)
            {
                case MAvail.NowShowing:
                    return "Now Showing";
                case MAvail.ComingSoon:
                    return "Coming Soon";
                default:
                    return "";
            }
        }
    }
}
