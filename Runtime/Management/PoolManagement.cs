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

namespace NovaFramework.AssetLoader
{
    /// <summary>
    /// 流式传输对象的缓冲池管理类，用于对所有流程传输对象实例进行池化管理
    /// </summary>
    public static class PoolManagement
    {
        /// <summary>
        /// 分配指定类型的流程传输对象实例
        /// </summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <returns>返回流程传输对象实例</returns>
        public static T Acquire<T>() where T : class, IStreamableHandler, new()
        {
            return null;
        }

        /// <summary>
        /// 分配指定类型的流程传输对象实例
        /// </summary>
        /// <param name="type">对象类型</param>
        /// <returns>返回流程传输对象实例</returns>
        public static IStreamableHandler Acquire(Type type)
        {
            return null;
        }

        /// <summary>
        /// 释放指定的流程传输对象实例
        /// </summary>
        /// <param name="streamableObject">对象实例</param>
        public static void Release(IStreamableHandler streamableObject)
        {
        }
    }
}
