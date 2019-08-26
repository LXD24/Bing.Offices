﻿using Bing.Offices.Decorators;
using Bing.Offices.Models.Excels;

namespace Bing.Offices.Abstractions
{
    /// <summary>
    /// 装饰器
    /// </summary>
    public interface IDecorator
    {
        /// <summary>
        /// 装饰
        /// </summary>
        /// <typeparam name="T">实体类型</typeparam>
        /// <param name="workbookBytes">工作簿字节数组</param>
        /// <param name="exportOptions">导出选项</param>
        /// <param name="context">装饰器上下文</param>
        /// <param name="excelExportProvider">Excel导出器提供程序</param>
        byte[] Decorate<T>(byte[] workbookBytes, ExportOptions<T> exportOptions, DecoratorContext context,
            IExcelExportProvider excelExportProvider) where T : class, new();
    }
}