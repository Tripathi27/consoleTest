// <autogenerated />
#pragma warning disable 618  // Ignore obsolete members warnings
#pragma warning disable 105  // Ignore duplicate namespaces
#pragma warning disable 1591 // Ignore missing XML comment warnings
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Uno.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Shapes;
using Windows.UI.Text;
using Uno.Extensions;
using Uno;
using TestConsoleDead.Wasm;

#if __ANDROID__
using _View = Android.Views.View;
#elif __IOS__
using _View = UIKit.UIView;
#elif __MACOS__
using _View = AppKit.NSView;
#elif __WASM__
using _View = Windows.UI.Xaml.UIElement;
#elif NET461
using _View = Windows.UI.Xaml.UIElement;
#endif

namespace TestConsoleDead.Shared
{
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV0056", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV0058", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV1003", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV0085", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2001", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2003", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2004", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2005", Justification="Generated code")]
	public sealed partial class GenericControl : Windows.UI.Xaml.Controls.UserControl
	{
		public Windows.UI.Xaml.Controls.Grid GetContent()
		{
			var nameScope = new global::Windows.UI.Xaml.NameScope();
			NameScope.SetNameScope(this, nameScope);
			// Source ..\..\..\..\..\..\..\TestConsoleDead.Shared\GenericControl.xaml (Line 1:2)
			Windows.UI.Xaml.Controls.Grid content = 			new global::Windows.UI.Xaml.Controls.Grid
			{
				Name = "gridlayout"/* string/, gridlayout, Grid/Name */,
				// Source ..\..\..\..\..\..\..\TestConsoleDead.Shared\GenericControl.xaml (Line 12:6)
			}
			.GenericControl_39182d44343ad6d2430ae1cfaf7ed3f7_XamlApply((GenericControl_39182d44343ad6d2430ae1cfaf7ed3f7XamlApplyExtensions.XamlApplyHandler0)(c0 => 
			{
				nameScope.RegisterName("gridlayout", c0);
				this.gridlayout = c0;
				global::Uno.UI.FrameworkElementHelper.SetBaseUri(c0, "file:///C:/Users/Nineleaps-user/source/repos/TestConsoleDead/TestConsoleDead.Shared/GenericControl.xaml");
			}
			))
			;
			
			content
			.Apply((c1 => 
			{
				// Source C:\Users\Nineleaps-user\source\repos\TestConsoleDead\TestConsoleDead.Shared\GenericControl.xaml (Line 1:2)
				
				// WARNING Property c1.base does not exist on {http://schemas.microsoft.com/winfx/2006/xaml/presentation}UserControl, the namespace is http://www.w3.org/XML/1998/namespace. This error was considered irrelevant by the XamlFileGenerator
			}
			))
			.Apply((c2 => 
			{
				// Class TestConsoleDead.Shared.GenericControl
				global::Uno.UI.FrameworkElementHelper.SetBaseUri(c2, "file:///C:/Users/Nineleaps-user/source/repos/TestConsoleDead/TestConsoleDead.Shared/GenericControl.xaml");
			}
			))
			;
			OnInitializeCompleted();
			InitializeXamlOwner();
			return content;
		}
		public GenericControl(bool skipsInitializeComponents)
		{
		}
		private void InitializeComponent()
		{
			Content = (_View)GetContent();
			global::Uno.UI.FrameworkElementHelper.SetBaseUri(this, "file:///C:/Users/Nineleaps-user/source/repos/TestConsoleDead/TestConsoleDead.Shared/GenericControl.xaml");
		}
		partial void OnInitializeCompleted();
		private global::Windows.UI.Xaml.Data.ElementNameSubject _gridlayoutSubject = new global::Windows.UI.Xaml.Data.ElementNameSubject();
		private global::Windows.UI.Xaml.Controls.Grid gridlayout
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.Grid)_gridlayoutSubject.ElementInstance;
			}
			set
			{
				_gridlayoutSubject.ElementInstance = value;
			}
		}
		class StaticResources
		{
		}
		private void InitializeXamlOwner()
		{
		}
	}
}
namespace TestConsoleDead.Wasm
{
	static class GenericControl_39182d44343ad6d2430ae1cfaf7ed3f7XamlApplyExtensions
	{
		public delegate void XamlApplyHandler0(global::Windows.UI.Xaml.Controls.Grid instance);
		public static global::Windows.UI.Xaml.Controls.Grid GenericControl_39182d44343ad6d2430ae1cfaf7ed3f7_XamlApply(this global::Windows.UI.Xaml.Controls.Grid instance, XamlApplyHandler0 handler)
		{
			handler(instance);
			return instance;
		}
	}
}
