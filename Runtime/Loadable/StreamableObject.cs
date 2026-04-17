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
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NovaFramework.AssetLoader
{
    /// <summary>
    /// 流式传输抽象对象类，用于对所有可流式传输资源的数据及访问操作的封装<br/>
    /// 在Unity环境下，该对象包含了场景、原生文件、预制体、纹理在内的所有资产数据。<br/>
    /// 你可以基于该对象，对具体的资产类型进行封装。
    /// </summary>
    public abstract class StreamableObject : IStreamableObject
    {
        /// <summary>
        /// 异步资源的状态标识
        /// </summary>
        protected bool _isAsyncStatus = false;
        /// <summary>
        /// 资源对象的名称
        /// </summary>
        protected string _nickname;

        /// <summary>
        /// 流程传输对象初始化回调函数
        /// </summary>
        public void Initialize()
        {
            OnInitialize();
        }

        /// <summary>
        /// 流程传输对象清理回调函数
        /// </summary>
        public void Cleanup()
        {
            // 先释放资源，再清理回收
            Release();

            OnCleanup();
        }

        /// <summary>
        /// 释放当前对象接收的资源实例
        /// </summary>
        public void Release()
        {
            OnRelease();
        }

        /// <summary>
        /// 对象内部初始化处理函数
        /// </summary>
        protected virtual void OnInitialize() { }
        /// <summary>
        /// 对象内部清理处理函数
        /// </summary>
        protected virtual void OnCleanup() { }
        /// <summary>
        /// 对象内部资源释放处理函数
        /// </summary>
        protected virtual void OnRelease() { }

        /// <summary>
        /// 同步加载回调通知接口函数
        /// </summary>
        /// <param name="nickname">资源名称</param>
        /// <param name="loadableObject">资源加载对象</param>
        public virtual void OnLoadSync(string nickname, object loadableObject)
        {
            _isAsyncStatus = false;
            _nickname = nickname;
        }

        /// <summary>
        /// 异步加载回调通知接口函数
        /// </summary>
        /// <param name="nickname">资源名称</param>
        /// <param name="loadableObject">资源加载对象</param>
        public virtual void OnLoadAsync(string nickname, object loadableObject)
        {
            _isAsyncStatus = true;
            _nickname = nickname;
        }

        #region 异步调度所需实现的接口函数

        public Task Task
        {
            get
            {
                if (!_isAsyncStatus) throw new InvalidOperationException();

                return CurrentSchedulingTask;
            }
        }

        /// <summary>
        /// 获取当前正在调度任务属性
        /// </summary>
        protected abstract Task CurrentSchedulingTask { get; }

        #endregion
    }
}
