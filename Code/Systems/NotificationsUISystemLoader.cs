// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Playfab {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrame.ECS;
    using uFrame.Kernel;
    
    
    [uFrame.Attributes.uFrameIdentifier("f449a859-4ace-4b46-a05b-103cc98dd01e")]
    public partial class NotificationsUISystemLoader : uFrame.Kernel.SystemLoader {
        
        public override void Load() {
            this.AddSystem<NotificationsUISystem>();
        }
    }
}