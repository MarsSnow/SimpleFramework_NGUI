using UnityEngine;
using System.Collections;
using LuaInterface;

public class HelloWorld : MonoBehaviour 
{
    private void Start () 
    {
        LuaState luaState = new LuaState(); //创建一个LuaState对象
        string str = @"print('hello world 世界')";
        luaState.DoString(str); //调用luaState对象的DoString方法，解析并运行包装成string的lua代码
    }

    private void Update () 
    {
    }
}