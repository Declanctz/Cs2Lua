﻿using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_RangeInt : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			UnityEngine.RangeInt o;
			if(argc==3){
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				o=new UnityEngine.RangeInt(a1,a2);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(argc<=2){
				o=new UnityEngine.RangeInt();
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			return error(l,"New object failed.");
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_start(IntPtr l) {
		try {
			UnityEngine.RangeInt self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.start);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_start(IntPtr l) {
		try {
			UnityEngine.RangeInt self;
			checkValueType(l,1,out self);
			System.Int32 v;
			checkType(l,2,out v);
			self.start=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_length(IntPtr l) {
		try {
			UnityEngine.RangeInt self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.length);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_length(IntPtr l) {
		try {
			UnityEngine.RangeInt self;
			checkValueType(l,1,out self);
			System.Int32 v;
			checkType(l,2,out v);
			self.length=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_end(IntPtr l) {
		try {
			UnityEngine.RangeInt self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.end);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.RangeInt");
		addMember(l,"start",get_start,set_start,true);
		addMember(l,"length",get_length,set_length,true);
		addMember(l,"end",get_end,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.RangeInt),typeof(System.ValueType));
	}
}
