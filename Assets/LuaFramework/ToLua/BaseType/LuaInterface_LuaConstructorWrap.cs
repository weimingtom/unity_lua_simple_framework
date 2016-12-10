﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class LuaInterface_LuaConstructorWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(LuaInterface.LuaConstructor), typeof(System.Object));
		L.RegFunction("Call", Call);
		L.RegFunction("Destroy", Destroy);
		L.RegFunction("__tostring", Lua_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Call(IntPtr L)
	{
		try
		{			
			LuaInterface.LuaConstructor obj = (LuaInterface.LuaConstructor)ToLua.CheckObject(L, 1, typeof(LuaInterface.LuaConstructor));            
			return obj.Call(L);						
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Destroy(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			LuaInterface.LuaConstructor obj = (LuaInterface.LuaConstructor)ToLua.CheckObject(L, 1, typeof(LuaInterface.LuaConstructor));
			obj.Destroy();
            ToLua.Destroy(L);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Lua_ToString(IntPtr L)
	{
		object obj = ToLua.ToObject(L, 1);

		if (obj != null)
		{
			LuaDLL.lua_pushstring(L, obj.ToString());
		}
		else
		{
			LuaDLL.lua_pushnil(L);
		}

		return 1;
	}
}

