using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace TestProject.Model
{
    public class Constants
    {
        public static bool isDev = true;
        public static Color BackgroundColor = Color.FromArgb(58, 153, 215);
        public static Color MainTextColor = Color.White;

        public static int LoginIconHeight = 120;

        //-----Login-------
        public static string LoginUrl = "https://test.com/api/Auth/Login";
    }
}
