﻿using System;
using UnityEngine;
using LuaInterface;
using Object = UnityEngine.Object;

public class ConstantForce2DWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("New", _CreateConstantForce2D),
			new LuaMethod("GetClassType", GetClassType),
			new LuaMethod("__eq", Lua_Eq),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("force", get_force, set_force),
			new LuaField("relativeForce", get_relativeForce, set_relativeForce),
			new LuaField("torque", get_torque, set_torque),
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.ConstantForce2D", typeof(ConstantForce2D), regs, fields, typeof(PhysicsUpdateBehaviour2D));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateConstantForce2D(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			ConstantForce2D obj = new ConstantForce2D();
			LuaScriptMgr.Push(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: ConstantForce2D.New");
		}

		return 0;
	}

	static Type classType = typeof(ConstantForce2D);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_force(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ConstantForce2D obj = (ConstantForce2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name force");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index force on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.force);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_relativeForce(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ConstantForce2D obj = (ConstantForce2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name relativeForce");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index relativeForce on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.relativeForce);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_torque(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ConstantForce2D obj = (ConstantForce2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name torque");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index torque on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.torque);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_force(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ConstantForce2D obj = (ConstantForce2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name force");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index force on a nil value");
			}
		}

		obj.force = LuaScriptMgr.GetVector2(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_relativeForce(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ConstantForce2D obj = (ConstantForce2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name relativeForce");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index relativeForce on a nil value");
			}
		}

		obj.relativeForce = LuaScriptMgr.GetVector2(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_torque(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		ConstantForce2D obj = (ConstantForce2D)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name torque");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index torque on a nil value");
			}
		}

		obj.torque = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Lua_Eq(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Object arg0 = LuaScriptMgr.GetLuaObject(L, 1) as Object;
		Object arg1 = LuaScriptMgr.GetLuaObject(L, 2) as Object;
		bool o = arg0 == arg1;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}
