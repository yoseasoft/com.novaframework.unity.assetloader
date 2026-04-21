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
using System.Threading.Tasks;

namespace NovaFramework.AssetLoader
{
    /// <summary>
    /// 流式传输句柄接口类，对外提供可流式传输资源的数据访问操作接口
    /// </summary>
    public interface IStreamableHandler
    {
        /// <summary>
        /// 流式传输句柄初始化回调函数
        /// </summary>
        void Initialize();
        /// <summary>
        /// 流式传输句柄清理回调函数
        /// </summary>
        void Cleanup();

        /// <summary>
        /// 释放当前数据句柄接收的资源实例
        /// </summary>
        void Release();

        /// <summary>
        /// 流式资源地址属性获取函数
        /// </summary>
        string Url { get; }

        /// <summary>
        /// 资源装载完成的结束状态标识
        /// </summary>
        bool IsDone { get; }

        /// <summary>
        /// 异步任务属性获取函数
        /// </summary>
        Task Task { get; }
    }
}
