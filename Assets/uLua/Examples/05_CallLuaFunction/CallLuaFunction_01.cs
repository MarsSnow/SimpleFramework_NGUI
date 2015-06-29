using UnityEngine;
using System.Collections;
using LuaInterface;

public class CallLuaFunction_01 : MonoBehaviour 
{
    private string luaScriptStr = @"
        function luaFunc(message)
            print(message)
            return 42
        end
    ";

    private void Start()
    {
        LuaState luaState = new LuaState();
        luaState.DoString(luaScriptStr);
        LuaFunction luaFunction = luaState.GetFunction("luaFunc");
        object[] returnValues = luaFunction.Call("I called a lua function!");
        print(returnValues[0]);
    }
}
