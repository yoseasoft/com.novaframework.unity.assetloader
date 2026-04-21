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
    /// 场景资源句柄接口类，对外提供场景资源的数据访问操作接口
    /// </summary>
    public interface ISceneHandler : IStreamableHandler
    {
        Scene SceneObject { get; }

        float LoadingProgress { get; }

        /// <summary>
        /// 加载完成的回调注册
        /// </summary>
        Action<ISceneHandler> Completed { set; get; }

        /// <summary>
        /// 同步加载场景资源
        /// </summary>
        /// <param name="url">资源地址</param>
        /// <param name="sceneMode">场景加载模式</param>
        /// <param name="physicsMode">场景物理模式</param>
        /// <returns>返回场景资源句柄</returns>
        ISceneHandler LoadSync(string url, LoadSceneMode sceneMode, LocalPhysicsMode physicsMode);

        /// <summary>
        /// 异步加载场景资源
        /// </summary>
        /// <param name="url">资源地址</param>
        /// <param name="sceneMode">场景加载模式</param>
        /// <param name="physicsMode">场景物理模式</param>
        /// <returns>返回场景资源句柄</returns>
        ISceneHandler LoadAsync(string url, LoadSceneMode sceneMode, LocalPhysicsMode physicsMode);
    }
}
