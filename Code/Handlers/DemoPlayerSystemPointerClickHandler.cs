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
    using UnityEngine;
    
    
    public class DemoPlayerSystemPointerClickHandler {
        
        public ClickCount Source;
        
        private uFrame.ECS.MouseDownDispatcher _Event;
        
        private uFrame.ECS.EcsSystem _System;
        
        private int ActionNode4_a = default( System.Int32 );
        
        private int ActionNode4_Result = default( System.Int32 );
        
        public uFrame.ECS.MouseDownDispatcher Event {
            get {
                return _Event;
            }
            set {
                _Event = value;
            }
        }
        
        public uFrame.ECS.EcsSystem System {
            get {
                return _System;
            }
            set {
                _System = value;
            }
        }
        
        public virtual void Execute() {
            ActionNode4_a = Source.Count;
            // ActionNode
            // Visit uFrame.Actions.IntLibrary.Increment
            ActionNode4_Result = uFrame.Actions.IntLibrary.Increment(ActionNode4_a);
            // SetVariableNode
            Source.Count = (System.Int32)ActionNode4_Result;
        }
    }
}