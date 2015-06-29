using UnityEngine;
using System.Collections;
using LuaInterface;

public class CreateGameObject02 : MonoBehaviour {

    /*private string script = @"
            luanet.load_assembly('UnityEngine')
            GameObject = UnityEngine.GameObject
            ParticleSystem = UnityEngine.ParticleSystem
            local newGameObj = GameObject('NewObj')
            newGameObj:AddComponent(ParticleSystem.GetClassType())
           
        ";*/

    private string script = @"
            luanet.load_assembly('UnityEngine')
            --GameObject = UnityEngine.GameObject
            --ParticleSystem = UnityEngine.ParticleSystem
            --local newGameObj = GameObject('NewObj')
            --newGameObj:AddComponent(ParticleSystem.GetClassType())
        ";
    // newGameObj:AddComponent(BoxCollider.GetClassType())
	//非反射调用
	void Start () 
    {
        LuaScriptMgr lua = new LuaScriptMgr();
        lua.Start();
        lua.DoString(script);
	}

	void Update () 
    {
	
	}
}
