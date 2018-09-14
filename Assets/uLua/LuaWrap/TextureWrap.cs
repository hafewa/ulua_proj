﻿using System;
using UnityEngine;
using LuaInterface;
using Object = UnityEngine.Object;

public class TextureWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("SetGlobalAnisotropicFilteringLimits", SetGlobalAnisotropicFilteringLimits),
			new LuaMethod("GetNativeTexturePtr", GetNativeTexturePtr),
			new LuaMethod("IncrementUpdateCount", IncrementUpdateCount),
			new LuaMethod("SetStreamingTextureMaterialDebugProperties", SetStreamingTextureMaterialDebugProperties),
			new LuaMethod("New", _CreateTexture),
			new LuaMethod("GetClassType", GetClassType),
			new LuaMethod("__eq", Lua_Eq),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("masterTextureLimit", get_masterTextureLimit, set_masterTextureLimit),
			new LuaField("anisotropicFiltering", get_anisotropicFiltering, set_anisotropicFiltering),
			new LuaField("width", get_width, set_width),
			new LuaField("height", get_height, set_height),
			new LuaField("dimension", get_dimension, set_dimension),
			new LuaField("wrapMode", get_wrapMode, set_wrapMode),
			new LuaField("wrapModeU", get_wrapModeU, set_wrapModeU),
			new LuaField("wrapModeV", get_wrapModeV, set_wrapModeV),
			new LuaField("wrapModeW", get_wrapModeW, set_wrapModeW),
			new LuaField("filterMode", get_filterMode, set_filterMode),
			new LuaField("anisoLevel", get_anisoLevel, set_anisoLevel),
			new LuaField("mipMapBias", get_mipMapBias, set_mipMapBias),
			new LuaField("texelSize", get_texelSize, null),
			new LuaField("updateCount", get_updateCount, null),
			new LuaField("totalTextureMemory", get_totalTextureMemory, null),
			new LuaField("desiredTextureMemory", get_desiredTextureMemory, null),
			new LuaField("targetTextureMemory", get_targetTextureMemory, null),
			new LuaField("currentTextureMemory", get_currentTextureMemory, null),
			new LuaField("nonStreamingTextureMemory", get_nonStreamingTextureMemory, null),
			new LuaField("streamingMipmapUploadCount", get_streamingMipmapUploadCount, null),
			new LuaField("streamingRendererCount", get_streamingRendererCount, null),
			new LuaField("streamingTextureCount", get_streamingTextureCount, null),
			new LuaField("nonStreamingTextureCount", get_nonStreamingTextureCount, null),
			new LuaField("streamingTexturePendingLoadCount", get_streamingTexturePendingLoadCount, null),
			new LuaField("streamingTextureLoadingCount", get_streamingTextureLoadingCount, null),
			new LuaField("streamingTextureForceLoadAll", get_streamingTextureForceLoadAll, set_streamingTextureForceLoadAll),
			new LuaField("streamingTextureDiscardUnusedMips", get_streamingTextureDiscardUnusedMips, set_streamingTextureDiscardUnusedMips),
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.Texture", typeof(Texture), regs, fields, typeof(Object));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateTexture(IntPtr L)
	{
		LuaDLL.luaL_error(L, "Texture class does not have a constructor function");
		return 0;
	}

	static Type classType = typeof(Texture);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_masterTextureLimit(IntPtr L)
	{
		LuaScriptMgr.Push(L, Texture.masterTextureLimit);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_anisotropicFiltering(IntPtr L)
	{
		LuaScriptMgr.Push(L, Texture.anisotropicFiltering);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_width(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Texture obj = (Texture)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name width");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index width on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.width);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_height(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Texture obj = (Texture)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name height");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index height on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.height);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_dimension(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Texture obj = (Texture)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name dimension");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index dimension on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.dimension);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_wrapMode(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Texture obj = (Texture)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name wrapMode");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index wrapMode on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.wrapMode);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_wrapModeU(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Texture obj = (Texture)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name wrapModeU");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index wrapModeU on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.wrapModeU);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_wrapModeV(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Texture obj = (Texture)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name wrapModeV");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index wrapModeV on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.wrapModeV);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_wrapModeW(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Texture obj = (Texture)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name wrapModeW");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index wrapModeW on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.wrapModeW);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_filterMode(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Texture obj = (Texture)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name filterMode");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index filterMode on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.filterMode);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_anisoLevel(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Texture obj = (Texture)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name anisoLevel");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index anisoLevel on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.anisoLevel);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_mipMapBias(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Texture obj = (Texture)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name mipMapBias");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index mipMapBias on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.mipMapBias);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_texelSize(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Texture obj = (Texture)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name texelSize");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index texelSize on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.texelSize);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_updateCount(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Texture obj = (Texture)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name updateCount");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index updateCount on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.updateCount);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_totalTextureMemory(IntPtr L)
	{
		LuaScriptMgr.Push(L, Texture.totalTextureMemory);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_desiredTextureMemory(IntPtr L)
	{
		LuaScriptMgr.Push(L, Texture.desiredTextureMemory);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_targetTextureMemory(IntPtr L)
	{
		LuaScriptMgr.Push(L, Texture.targetTextureMemory);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_currentTextureMemory(IntPtr L)
	{
		LuaScriptMgr.Push(L, Texture.currentTextureMemory);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_nonStreamingTextureMemory(IntPtr L)
	{
		LuaScriptMgr.Push(L, Texture.nonStreamingTextureMemory);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_streamingMipmapUploadCount(IntPtr L)
	{
		LuaScriptMgr.Push(L, Texture.streamingMipmapUploadCount);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_streamingRendererCount(IntPtr L)
	{
		LuaScriptMgr.Push(L, Texture.streamingRendererCount);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_streamingTextureCount(IntPtr L)
	{
		LuaScriptMgr.Push(L, Texture.streamingTextureCount);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_nonStreamingTextureCount(IntPtr L)
	{
		LuaScriptMgr.Push(L, Texture.nonStreamingTextureCount);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_streamingTexturePendingLoadCount(IntPtr L)
	{
		LuaScriptMgr.Push(L, Texture.streamingTexturePendingLoadCount);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_streamingTextureLoadingCount(IntPtr L)
	{
		LuaScriptMgr.Push(L, Texture.streamingTextureLoadingCount);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_streamingTextureForceLoadAll(IntPtr L)
	{
		LuaScriptMgr.Push(L, Texture.streamingTextureForceLoadAll);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_streamingTextureDiscardUnusedMips(IntPtr L)
	{
		LuaScriptMgr.Push(L, Texture.streamingTextureDiscardUnusedMips);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_masterTextureLimit(IntPtr L)
	{
		Texture.masterTextureLimit = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_anisotropicFiltering(IntPtr L)
	{
		Texture.anisotropicFiltering = (AnisotropicFiltering)LuaScriptMgr.GetNetObject(L, 3, typeof(AnisotropicFiltering));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_width(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Texture obj = (Texture)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name width");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index width on a nil value");
			}
		}

		obj.width = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_height(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Texture obj = (Texture)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name height");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index height on a nil value");
			}
		}

		obj.height = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_dimension(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Texture obj = (Texture)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name dimension");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index dimension on a nil value");
			}
		}

		obj.dimension = (UnityEngine.Rendering.TextureDimension)LuaScriptMgr.GetNetObject(L, 3, typeof(UnityEngine.Rendering.TextureDimension));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_wrapMode(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Texture obj = (Texture)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name wrapMode");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index wrapMode on a nil value");
			}
		}

		obj.wrapMode = (TextureWrapMode)LuaScriptMgr.GetNetObject(L, 3, typeof(TextureWrapMode));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_wrapModeU(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Texture obj = (Texture)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name wrapModeU");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index wrapModeU on a nil value");
			}
		}

		obj.wrapModeU = (TextureWrapMode)LuaScriptMgr.GetNetObject(L, 3, typeof(TextureWrapMode));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_wrapModeV(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Texture obj = (Texture)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name wrapModeV");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index wrapModeV on a nil value");
			}
		}

		obj.wrapModeV = (TextureWrapMode)LuaScriptMgr.GetNetObject(L, 3, typeof(TextureWrapMode));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_wrapModeW(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Texture obj = (Texture)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name wrapModeW");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index wrapModeW on a nil value");
			}
		}

		obj.wrapModeW = (TextureWrapMode)LuaScriptMgr.GetNetObject(L, 3, typeof(TextureWrapMode));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_filterMode(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Texture obj = (Texture)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name filterMode");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index filterMode on a nil value");
			}
		}

		obj.filterMode = (FilterMode)LuaScriptMgr.GetNetObject(L, 3, typeof(FilterMode));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_anisoLevel(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Texture obj = (Texture)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name anisoLevel");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index anisoLevel on a nil value");
			}
		}

		obj.anisoLevel = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_mipMapBias(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Texture obj = (Texture)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name mipMapBias");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index mipMapBias on a nil value");
			}
		}

		obj.mipMapBias = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_streamingTextureForceLoadAll(IntPtr L)
	{
		Texture.streamingTextureForceLoadAll = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_streamingTextureDiscardUnusedMips(IntPtr L)
	{
		Texture.streamingTextureDiscardUnusedMips = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetGlobalAnisotropicFilteringLimits(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		int arg0 = (int)LuaScriptMgr.GetNumber(L, 1);
		int arg1 = (int)LuaScriptMgr.GetNumber(L, 2);
		Texture.SetGlobalAnisotropicFilteringLimits(arg0,arg1);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetNativeTexturePtr(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		Texture obj = (Texture)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Texture");
		IntPtr o = obj.GetNativeTexturePtr();
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IncrementUpdateCount(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		Texture obj = (Texture)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Texture");
		obj.IncrementUpdateCount();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetStreamingTextureMaterialDebugProperties(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 0);
		Texture.SetStreamingTextureMaterialDebugProperties();
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
