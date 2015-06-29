using UnityEngine;
using System.Collections;
using LuaInterface;

public class CreateGameObject01 : MonoBehaviour 
{
    private string script = @"
            luanet.load_assembly('UnityEngine')

            GameObject = luanet.import_type('UnityEngine.GameObject')
            ParticleSystem = luanet.import_type('UnityEngine.ParticleSystem')
            Rigidbody = luanet.import_type('UnityEngine.Rigidbody')
            BoxCollider = luanet.import_type('UnityEngine.BoxCollider')

            local newGameObj = GameObject('NewObj')

            newGameObj:AddComponent(luanet.ctype(ParticleSystem))
            newGameObj:AddComponent(luanet.ctype(Rigidbody))
            newGameObj:AddComponent(luanet.ctype(BoxCollider))
        ";

    //反射调用
    private void Start () 
    {
        LuaState luaState = new LuaState();
        luaState.DoString(script);
    }
    
    private void Update () 
    {
    
    }
}
