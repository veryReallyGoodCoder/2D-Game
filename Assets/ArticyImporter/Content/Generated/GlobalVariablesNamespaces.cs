//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Articy.Unity;
using Articy.Unity.Interfaces;
using System;
using System.Collections;
using UnityEngine;


namespace Articy.Articy_Draft_Test_Drive.GlobalVariables
{
    
    
    [Serializable()]
    public class playerVars : IArticyNamespace
    {
        
        [SerializeField()]
        private BaseGlobalVariables _VariableStorage;
        
        // how much cash the player has
        public int Wallet
        {
            get
            {
                return _VariableStorage.Internal_GetVariableValueInt32(0);
            }
            set
            {
                _VariableStorage.Internal_SetVariableValueInt32(0, value);
            }
        }
        
        // 
        public bool hasMoney
        {
            get
            {
                return _VariableStorage.Internal_GetVariableValueBoolean(0);
            }
            set
            {
                _VariableStorage.Internal_SetVariableValueBoolean(0, value);
            }
        }
        
        public void RegisterVariables(BaseGlobalVariables aStorage)
        {
            _VariableStorage = aStorage;
            aStorage.RegisterVariable("playerVars.Wallet", 0);
            aStorage.RegisterVariable("playerVars.hasMoney", false);
        }
    }
}
