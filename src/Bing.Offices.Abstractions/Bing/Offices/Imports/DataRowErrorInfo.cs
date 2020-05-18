﻿using System.Collections.Generic;

namespace Bing.Offices.Imports
{
    /// <summary>
    /// 数据行错误信息
    /// </summary>
    public class DataRowErrorInfo
    {
        /// <summary>
        /// 序号
        /// </summary>
        public int RowIndex { get; set; }

        /// <summary>
        /// 字段错误信息
        /// </summary>
        public IDictionary<string,string> FieldErrors { get; set; }

        /// <summary>
        /// 初始化一个<see cref="DataRowErrorInfo"/>类型的实例
        /// </summary>
        public DataRowErrorInfo()
        {
            FieldErrors = new Dictionary<string, string>();
        }
    }
}
