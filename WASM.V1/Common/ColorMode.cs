namespace WASM.V1.Common
{
    public class ColorMode
    {
        private bool darkMode;
        public string BG { get; set; }
        public string HBG { get; set; }
        public string GBG { get; set; }
        public string TXT { get; set; }
        public string HTXT { get; set; }
        public string NTXT { get; set; }
        public string PTXT { get; set; }
        public string BUTTON { get; set; }
        public string GRAYSCALE { get; set; }
        public string HEADERTEXT { get; set; }

        public ColorMode(bool darkMode)
        {
            this.darkMode = darkMode;
            SetColorMode();
        }

        private void SetColorMode()
        {
            if (darkMode)
            {
                BG = "bg-black";
                HBG = "hover:bg-gray-900 transition-colors duration-600";
                GBG = "transition-all duration-400 bg-gradient-to-r bg-gradient-to-r hover:from-sky-400 hover:to-indigo-900";
                TXT = "text-white";
                HTXT = "hover:text-transparent transition-colors duration-400 bg-clip-text bg-gradient-to-r bg-gradient-to-r from-sky-400 to-indigo-900";
                NTXT = TXT+ " " + HTXT;
                PTXT = "text-transparent bg-clip-text bg-gradient-to-r from-sky-400 to-indigo-900";
                BUTTON = TXT + " " + BG + " " + "hover:bg-white border border-gray-900 hover:border-black hover:text-black transition-colors duration-500";
                GRAYSCALE = "transition-all duration-500 filter grayscale hover:filter-none";
                HEADERTEXT = "transform-all duration-500 hover:text-sky-400 ";
            }
            else
            {
                
            }
        }
    }
}