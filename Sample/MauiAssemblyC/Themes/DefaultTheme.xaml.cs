
using Microsoft.Maui.Controls;

namespace MauiAssemblyC.Themes
{
    /// <summary>
    /// Dark theme resource dictionary.
    /// </summary>
    public partial class DefaultTheme : AThemeDictionary
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:MauiAssemblyC.Themes.DefaultTheme"/> class.
        /// </summary>
        public DefaultTheme():base ()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="isDark"></param>
        public DefaultTheme(bool isDark=false) : base(isDark)
        {
            InitializeComponent();
        }

    }

}