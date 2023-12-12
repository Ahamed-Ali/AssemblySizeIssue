using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAssemblyC.Themes
{

    /// <summary>
    /// 
    /// </summary>
    public class AThemeResourceDictionary : ResourceDictionary
    {

        private AVisuals aVisualTheme = AVisuals.LightDefault;

        /// <summary>
        /// 
        /// </summary>
        public AVisuals AVisualTheme
        {
            get
            {
                return aVisualTheme;
            }
            set
            {
                aVisualTheme = value;

                this.UpdateVisualTheme();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public AThemeResourceDictionary()
        {
            this.UpdateDefaultTheme();
        }  

        private void UpdateVisualTheme()
        {

            this.MergedDictionaries.Clear();
            if (this.AVisualTheme == AVisuals.LightDefault)
            {
                this.UpdateDefaultTheme();
            }
            else if (this.AVisualTheme == AVisuals.DarkDefault)
            {
                this.UpdateDefaultTheme(true);
            }
        }

        private void UpdateDefaultTheme(bool isDark = false)
        {
            this.MergedDictionaries.Clear();
            this.MergedDictionaries.Add(new DefaultTheme(isDark));
        }

    }

    /// <summary>
    /// 
    /// </summary>
    public enum AVisuals
    {
        /// <summary>
        /// 
        /// </summary>
        LightDefault,

        /// <summary>
        /// 
        /// </summary>
        DarkDefault

    }
}
