// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace reachability {
	
	
	// Base type probably should be MonoTouch.Foundation.NSObject or subclass
	[Foundation.Register("ReachabilityAppDelegate")]
	public partial class ReachabilityAppDelegate {
		
		private UIKit.UIWindow __mt_window;
		
		private UIKit.UIView __mt_contentView;
		
		private UIKit.UILabel __mt_summaryLabel;
		
		#pragma warning disable 0169
		[Foundation.Connect("window")]
		private UIKit.UIWindow window {
			get {
				this.__mt_window = ((UIKit.UIWindow)(this.GetNativeField("window")));
				return this.__mt_window;
			}
			set {
				this.__mt_window = value;
				this.SetNativeField("window", value);
			}
		}
		
		[Foundation.Connect("contentView")]
		private UIKit.UIView contentView {
			get {
				this.__mt_contentView = ((UIKit.UIView)(this.GetNativeField("contentView")));
				return this.__mt_contentView;
			}
			set {
				this.__mt_contentView = value;
				this.SetNativeField("contentView", value);
			}
		}
		
		[Foundation.Connect("summaryLabel")]
		private UIKit.UILabel summaryLabel {
			get {
				this.__mt_summaryLabel = ((UIKit.UILabel)(this.GetNativeField("summaryLabel")));
				return this.__mt_summaryLabel;
			}
			set {
				this.__mt_summaryLabel = value;
				this.SetNativeField("summaryLabel", value);
			}
		}
	}
}
