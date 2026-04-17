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

namespace NovaFramework.AssetLoader
{
    /// <summary>
    /// 原生文件对象接口类，对外提供原生文件的数据访问操作接口
    /// </summary>
    public interface IRawFileObject : IStreamableObject
    {
        /// <summary>
        /// 流式传输的数据类型
        /// </summary>
        new StreamableDataType DataType => StreamableDataType.RawFile;

        /// <summary>
        /// 获取原生文件的二进制数据
        /// </summary>
        /// <returns>返回二进制数据流</returns>
        byte[] GetRawFileData();

        /// <summary>
        /// 获取原生文件的文本数据
        /// </summary>
        /// <returns>返回文本字符串</returns>
        string GetRawFileText();
    }
}
