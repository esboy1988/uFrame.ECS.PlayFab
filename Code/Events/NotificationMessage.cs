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
    using UniRx;
    using uFrame.ECS;
    
    
    [uFrame.Attributes.EventId(14)]
    public partial class NotificationMessage : object {
        
        [UnityEngine.SerializeField()]
        private String _Title;
        
        [UnityEngine.SerializeField()]
        private String _Message;
        
        public String Title {
            get {
                return _Title;
            }
            set {
                _Title = value;
            }
        }
        
        public String Message {
            get {
                return _Message;
            }
            set {
                _Message = value;
            }
        }
    }
}
