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
    using uFrame.Kernel;
    using UniRx;
    using uFrame.ECS;
    
    
    public partial class GameSystemBase : uFrame.ECS.EcsSystem {
        
        public override void Setup() {
            base.Setup();
        }
    }
    
    [uFrame.Attributes.uFrameIdentifier("d9deebf1-015e-4f0b-91b8-126071419d7b")]
    public partial class GameSystem : GameSystemBase {
        
        private static GameSystem _Instance;
        
        public GameSystem() {
            Instance = this;
        }
        
        public static GameSystem Instance {
            get {
                return _Instance;
            }
            set {
                _Instance = value;
            }
        }
    }
}