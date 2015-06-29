using UnityEngine;
using System.Collections;
using LuaInterface;

public class ScriptsFromFile_02 : MonoBehaviour
{
    private void Start()
    {
        LuaState luaState = new LuaState();
        string path = Application.dataPath + "/uLua/Examples/04_ScriptsFromFile/ScriptsFromFile02.lua";
        luaState.DoFile(path);
    }
}
