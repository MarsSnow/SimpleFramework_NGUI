using UnityEngine;
using System.Collections;
using LuaInterface;

public class AccessingLuaVariables01 : MonoBehaviour 
{
    private string luaScript = @"
            luanet.load_assembly('UnityEngine')
            GameObject = luanet.import_type('UnityEngine.GameObject')

            particles = {}

            for i = 1, Objs2Spawn, 1 do
                local newGameObj = GameObject('NewObj' .. tostring(i))
                local ps = newGameObj:AddComponent('ParticleSystem')
                ps:Stop()

                table.insert(particles, ps)
            end

            var2read = 42
        ";

	private void Start () 
    {
        LuaState luaState = new LuaState();
        // Assign to global scope variables as if they're keys in a dictionary (they are really)
        luaState["Objs2Spawn"] = 5;//声明数组长度
        luaState.DoString(luaScript);
        // Read from the global scope the same way
        print("Read from lua: " + luaState["var2read"].ToString());

        // Get the lua table as LuaTable object
        LuaTable luaTable = (LuaTable)luaState["particles"];    //获取LuaTable中的Particles字段

        // Typical foreach over values in table
        foreach( ParticleSystem ps in luaTable.Values )
        {
            ps.Play();
        }
	}
}
