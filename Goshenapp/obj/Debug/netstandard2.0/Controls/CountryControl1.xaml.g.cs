//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::Xamarin.Forms.Xaml.XamlResourceIdAttribute("Goshenapp.Controls.CountryControl1.xaml", "Controls/CountryControl1.xaml", typeof(global::XamarinCountryPicker.Controls.CountryControl))]

namespace XamarinCountryPicker.Controls {
    
    
    [global::Xamarin.Forms.Xaml.XamlFilePathAttribute("Controls\\CountryControl1.xaml")]
    public partial class CountryControl : global::Xamarin.Forms.StackLayout {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::FFImageLoading.Svg.Forms.SvgCachedImage FlagImage;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.Label CountryNameLabel;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.Label CountryCodeLabel;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent() {
            global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(CountryControl));
            FlagImage = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::FFImageLoading.Svg.Forms.SvgCachedImage>(this, "FlagImage");
            CountryNameLabel = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Label>(this, "CountryNameLabel");
            CountryCodeLabel = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Label>(this, "CountryCodeLabel");
        }
    }
}
