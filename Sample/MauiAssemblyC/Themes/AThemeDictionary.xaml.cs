
using Microsoft.Maui.Controls;
using System.ComponentModel.Design;

namespace MauiAssemblyC.Themes
{
    /// <summary>
    /// 
    /// </summary>
    public partial class AThemeDictionary : ResourceDictionary
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:MauiAssemblyC.Themes.AThemeDictionary"/> class.
        /// </summary>
        public AThemeDictionary()
        {
            this.InitializeElement();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="isDark"></param>
        public AThemeDictionary(bool isDark=false)
        {
            if (isDark)
            {
                this.MergedDictionaries.Add(new DarkThemeColors());
            }
            else
            {
                this.MergedDictionaries.Add(new LightThemeColors());
            }

            this.InitializeElement();
        }

        /// <summary>
        /// 
        /// </summary>
        private void InitializeElement()
        {
            InitializeComponent();
        }
    }
}