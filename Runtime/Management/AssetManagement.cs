/// -------------------------------------------------------------------------------
/// NovaFramework By UnityEngine
///
/// Copyright (C) 2026, Hurley, Independent Studio.
///
/// Permission is hereby granted, free of charge, to any person obtaining a copy
/// of this software and associated documentation files (the "Software"), to deal
/// in the Software without restriction, including without limitation the rights
/// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
/// copies of the Software, and to permit persons to whom the Software is
/// furnished to do so, subject to the following conditions:
///
/// The above copyright notice and this permission notice shall be included in
/// all copies or substantial portions of the Software.
///
/// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
/// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
/// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
/// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
/// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
/// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
/// THE SOFTWARE.
/// -------------------------------------------------------------------------------

using System;

using UnityEngine.SceneManagement;

namespace NovaFramework.AssetLoader
{
    /// <summary>
    /// 资源管理器对象类，用于封装并对外提供统一的资源访问操作接口
    /// </summary>
    public static class AssetManagement
    {
        /// <summary>
        /// 注册的资源模块对象实例
        /// </summary>
        private static IAssetModule _assetModule;

        #region 场景资源加载

        /// <summary>
        /// 同步加载场景资源
        /// </summary>
        /// <param name="url">资源地址</param>
        /// <returns>返回场景资源句柄</returns>
        public static ISceneHandler LoadSceneSync(string url)
        {
            return LoadSceneSync(url, LoadSceneMode.Additive, LocalPhysicsMode.None);
        }

        /// <summary>
        /// 同步加载场景资源
        /// </summary>
        /// <param name="url">资源地址</param>
        /// <param name="sceneMode">场景加载模式</param>
        /// <param name="physicsMode">场景物理模式</param>
        /// <returns>返回场景资源句柄</returns>
        public static ISceneHandler LoadSceneSync(string url, LoadSceneMode sceneMode, LocalPhysicsMode physicsMode)
        {
            Logger.Assert(null != _assetModule, "The asset module must be non-null.");
            return _assetModule.LoadSceneSync(url, sceneMode, physicsMode);
        }

        /// <summary>
        /// 异步加载场景资源
        /// </summary>
        /// <param name="url">资源地址</param>
        /// <returns>返回场景资源句柄</returns>
        public static ISceneHandler LoadSceneAsync(string url)
        {
            return LoadSceneAsync(url, LoadSceneMode.Additive, LocalPhysicsMode.None);
        }

        /// <summary>
        /// 异步加载场景资源
        /// </summary>
        /// <param name="url">资源地址</param>
        /// <param name="sceneMode">场景加载模式</param>
        /// <param name="physicsMode">场景物理模式</param>
        /// <returns>返回场景资源句柄</returns>
        public static ISceneHandler LoadSceneAsync(string url, LoadSceneMode sceneMode, LocalPhysicsMode physicsMode)
        {
            Logger.Assert(null != _assetModule, "The asset module must be non-null.");
            return _assetModule.LoadSceneAsync(url, sceneMode, physicsMode);
        }

        #endregion

        #region 通用资源加载

        /// <summary>
        /// 同步加载通用资源对象
        /// </summary>
        /// <param name="url">资源地址</param>
        /// <returns>返回通用资源句柄</returns>
        public static IAssetHandler LoadAssetSync(string url)
        {
            Logger.Assert(null != _assetModule, "The asset module must be non-null.");
            return _assetModule.LoadAssetSync(url);
        }

        /// <summary>
        /// 同步加载通用资源对象
        /// </summary>
        /// <typeparam name="T">资源类型</typeparam>
        /// <param name="url">资源地址</param>
        /// <returns>返回通用资源句柄</returns>
        public static IAssetHandler LoadAssetSync<T>(string url) where T : UnityEngine.Object
        {
            Logger.Assert(null != _assetModule, "The asset module must be non-null.");
            return _assetModule.LoadAssetSync<T>(url);
        }

        /// <summary>
        /// 同步加载通用资源对象
        /// </summary>
        /// <param name="url">资源地址</param>
        /// <param name="type">资源类型</param>
        /// <returns>返回通用资源句柄</returns>
        public static IAssetHandler LoadAssetSync(string url, Type type)
        {
            Logger.Assert(null != _assetModule, "The asset module must be non-null.");
            return _assetModule.LoadAssetSync(url, type);
        }

        /// <summary>
        /// 异步加载通用资源对象
        /// </summary>
        /// <param name="url">资源地址</param>
        /// <returns>返回通用资源句柄</returns>
        public static IAssetHandler LoadAssetAsync(string url)
        {
            Logger.Assert(null != _assetModule, "The asset module must be non-null.");
            return _assetModule.LoadAssetAsync(url);
        }

        /// <summary>
        /// 异步加载通用资源对象
        /// </summary>
        /// <typeparam name="T">资源类型</typeparam>
        /// <param name="url">资源地址</param>
        /// <returns>返回通用资源句柄</returns>
        public static IAssetHandler LoadAssetAsync<T>(string url) where T : UnityEngine.Object
        {
            Logger.Assert(null != _assetModule, "The asset module must be non-null.");
            return _assetModule.LoadAssetAsync<T>(url);
        }

        /// <summary>
        /// 异步加载通用资源对象
        /// </summary>
        /// <param name="url">资源地址</param>
        /// <param name="type">资源类型</param>
        /// <returns>返回通用资源句柄</returns>
        public static IAssetHandler LoadAssetAsync(string url, Type type)
        {
            Logger.Assert(null != _assetModule, "The asset module must be non-null.");
            return _assetModule.LoadAssetAsync(url, type);
        }

        #endregion

        #region 原生资源加载

        /// <summary>
        /// 同步加载原生文件
        /// </summary>
        /// <param name="url">资源地址</param>
        /// <returns>返回原生文件资源句柄</returns>
        public static IRawFileHandler LoadRawFileSync(string url)
        {
            Logger.Assert(null != _assetModule, "The asset module must be non-null.");
            return _assetModule.LoadRawFileSync(url);
        }

        /// <summary>
        /// 异步加载原生文件
        /// </summary>
        /// <param name="url">资源地址</param>
        /// <returns>返回原生文件资源句柄</returns>
        public static IRawFileHandler LoadRawFileAsync(string url)
        {
            Logger.Assert(null != _assetModule, "The asset module must be non-null.");
            return _assetModule.LoadRawFileAsync(url);
        }

        #endregion

        #region 资源模块实例管理

        /// <summary>
        /// 注册资源加载模块的对象实例
        /// </summary>
        /// <typeparam name="T">模块类型</typeparam>
        public static void RegisterAssetModule<T>() where T : IAssetModule
        {
            IAssetModule assetModule = Activator.CreateInstance<T>();
            RegisterAssetModule(assetModule);
        }

        /// <summary>
        /// 注册资源加载模块的对象实例
        /// </summary>
        /// <param name="module">模块对象实例</param>
        public static void RegisterAssetModule(IAssetModule module)
        {
            _assetModule = module;
        }

        /// <summary>
        /// 注销当前登记的资源加载模块对象实例
        /// </summary>
        public static void UnregisterCurrentAssetModule()
        {
            _assetModule = null;
        }

        #endregion
    }
}
