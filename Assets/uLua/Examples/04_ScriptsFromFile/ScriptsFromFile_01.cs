using UnityEngine;
using System.Collections;
using LuaInterface;

public class ScriptsFromFile_01 : MonoBehaviour
{

    public TextAsset scriptFile;

    private void Start()
    {
        LuaState luaState = new LuaState();
        luaState.DoString(scriptFile.text);
    }
}
