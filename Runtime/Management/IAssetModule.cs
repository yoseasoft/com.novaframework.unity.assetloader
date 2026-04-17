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
    /// 资源模块接口类，用于定义资源访问所需的接口函数
    /// </summary>
    public interface IAssetModule
    {

        #region 场景资源加载

        /// <summary>
        /// 同步加载场景资源
        /// </summary>
        /// <param name="name">资源名称</param>
        /// <param name="url">资源地址</param>
        /// <param name="sceneMode">场景加载模式</param>
        /// <param name="physicsMode">场景物理模式</param>
        /// <returns>返回场景资源对象</returns>
        ISceneObject LoadSceneSync(string name, string url,
                                   LoadSceneMode sceneMode,
                                   LocalPhysicsMode physicsMode);

        /// <summary>
        /// 异步加载场景资源
        /// </summary>
        /// <param name="name">资源名称</param>
        /// <param name="url">资源地址</param>
        /// <param name="sceneMode">场景加载模式</param>
        /// <param name="physicsMode">场景物理模式</param>
        /// <returns>返回场景资源对象</returns>
        ISceneObject LoadSceneAsync(string name, string url,
                                    LoadSceneMode sceneMode,
                                    LocalPhysicsMode physicsMode);

        #endregion

        #region 通用资源加载

        /// <summary>
        /// 同步加载通用资源对象
        /// </summary>
        /// <param name="name">资源名称</param>
        /// <param name="url">资源地址</param>
        /// <returns>返回通用资源对象</returns>
        IAssetObject LoadAssetSync(string name, string url);

        /// <summary>
        /// 同步加载通用资源对象
        /// </summary>
        /// <typeparam name="T">资源类型</typeparam>
        /// <param name="name">资源名称</param>
        /// <param name="url">资源地址</param>
        /// <returns>返回通用资源对象</returns>
        IAssetObject LoadAssetSync<T>(string name, string url) where T : UnityEngine.Object;

        /// <summary>
        /// 同步加载通用资源对象
        /// </summary>
        /// <param name="name">资源名称</param>
        /// <param name="url">资源地址</param>
        /// <param name="type">资源类型</param>
        /// <returns>返回通用资源对象</returns>
        IAssetObject LoadAssetSync(string name, string url, Type type);

        /// <summary>
        /// 异步加载通用资源对象
        /// </summary>
        /// <param name="name">资源名称</param>
        /// <param name="url">资源地址</param>
        /// <returns>返回通用资源对象</returns>
        IAssetObject LoadAssetAsync(string name, string url);

        /// <summary>
        /// 异步加载通用资源对象
        /// </summary>
        /// <typeparam name="T">资源类型</typeparam>
        /// <param name="name">资源名称</param>
        /// <param name="url">资源地址</param>
        /// <returns>返回通用资源对象</returns>
        IAssetObject LoadAssetAsync<T>(string name, string url) where T : UnityEngine.Object;

        /// <summary>
        /// 异步加载通用资源对象
        /// </summary>
        /// <param name="name">资源名称</param>
        /// <param name="url">资源地址</param>
        /// <param name="type">资源类型</param>
        /// <returns>返回通用资源对象</returns>
        IAssetObject LoadAssetAsync(string name, string url, Type type);

        #endregion

        #region 原生资源加载

        /// <summary>
        /// 同步加载原生文件
        /// </summary>
        /// <param name="name">资源名称</param>
        /// <param name="url">资源地址</param>
        /// <returns>返回原生文件资源对象</returns>
        IRawFileObject LoadRawFileSync(string name, string url);

        /// <summary>
        /// 异步加载原生文件
        /// </summary>
        /// <param name="name">资源名称</param>
        /// <param name="url">资源地址</param>
        /// <returns>返回原生文件资源对象</returns>
        IRawFileObject LoadRawFileAsync(string name, string url);

        #endregion
    }
}
