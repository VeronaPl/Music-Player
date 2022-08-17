using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Mp3_Player
{
    public static class Buffer
    {
        public delegate void ValueChangedEventHandler(object sender, EventArgs e);
        public static event ValueChangedEventHandler ValueChanged;
        private static String Title = String.Empty;
        private static String Singer = String.Empty;
        private static String Album = String.Empty;
        private static String Genre = String.Empty;

        public static String Title_Buffer
        {
            get { return Title; }
            set { ValueChanged(null, EventArgs.Empty); }
        }

        public static String Singer_Buffer
        {
            get { return Singer; }
            set { ValueChanged(null, EventArgs.Empty); }
        }

        public static String Album_Buffer
        {
            get { return Album; }
            set { ValueChanged(null, EventArgs.Empty); }
        }

        public static String Genre_Buffer
        {
            get { return Genre; }
            set { ValueChanged(null, EventArgs.Empty); }
        }
    }
}
