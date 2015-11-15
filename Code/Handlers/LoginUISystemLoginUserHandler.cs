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
    
    
    public class LoginUISystemLoginUserHandler {
        
        private Playfab.LoginUser _Event;
        
        private uFrame.ECS.EcsSystem _System;
        
        private Playfab.LoginLoadingUI LoopGroupNode15_Item = default( Playfab.LoginLoadingUI );
        
        private UnityEngine.GameObject ActionNode14_gameObject = default( UnityEngine.GameObject );
        
        private UnityEngine.MonoBehaviour ActionNode14_behaviour = default( UnityEngine.MonoBehaviour );
        
        private Playfab.LoginUI LoopGroupNode21_Item = default( Playfab.LoginUI );
        
        private UnityEngine.GameObject ActionNode22_gameObject = default( UnityEngine.GameObject );
        
        private UnityEngine.MonoBehaviour ActionNode22_behaviour = default( UnityEngine.MonoBehaviour );
        
        public Playfab.LoginUser Event {
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
            // LoopGroupNode
            var LoopGroupNode15_GroupComponents = System.ComponentSystem.RegisterComponent<Playfab.LoginLoadingUI>().Components;
            for (var LoopGroupNode15_ItemIndex = 0
            ; LoopGroupNode15_ItemIndex < LoopGroupNode15_GroupComponents.Count; LoopGroupNode15_ItemIndex++
            ) {
                LoopGroupNode15_Item = LoopGroupNode15_GroupComponents[LoopGroupNode15_ItemIndex];
                LoopGroupNode15_Next();
            }
            // LoopGroupNode
            var LoopGroupNode21_GroupComponents = System.ComponentSystem.RegisterComponent<Playfab.LoginUI>().Components;
            for (var LoopGroupNode21_ItemIndex = 0
            ; LoopGroupNode21_ItemIndex < LoopGroupNode21_GroupComponents.Count; LoopGroupNode21_ItemIndex++
            ) {
                LoopGroupNode21_Item = LoopGroupNode21_GroupComponents[LoopGroupNode21_ItemIndex];
                LoopGroupNode21_Next();
            }
        }
        
        private void LoopGroupNode15_Next() {
            ActionNode14_behaviour = LoopGroupNode15_Item;
            // ActionNode
            // Visit uFrame.Actions.GameObjects.ActivateGameObject
            uFrame.Actions.GameObjects.ActivateGameObject(ActionNode14_gameObject, ActionNode14_behaviour);
        }
        
        private void LoopGroupNode21_Next() {
            ActionNode22_behaviour = LoopGroupNode21_Item;
            // ActionNode
            // Visit uFrame.Actions.GameObjects.DeactiateGameObject
            uFrame.Actions.GameObjects.DeactiateGameObject(ActionNode22_gameObject, ActionNode22_behaviour);
        }
    }
}