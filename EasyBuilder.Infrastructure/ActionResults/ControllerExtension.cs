using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace EasyBuilder.Infrastructure.ActionResults
{
    /// <summary>
    /// 控件数据结果扩展类
    /// </summary>
    public static class ControllerExtension
    {
        /// <summary>
        /// 表格控件数据结果
        /// </summary>
        public static DataResult GridData<T>(this Controller controller, int total, IList<T> list)
        {
            GridData data = new GridData { total = total, rows = list };
            return new DataResult(data);
        }

        /// <summary>
        /// 树控件数据结果
        /// </summary>
        public static DataResult TreeData<T>(this Controller controller, IList<T> list, Func<T, Guid> idFormat, Func<T, string> textFormat, Func<T, Guid?> pidFormat, Func<T, string> iconClsFormat = null, Func<T, string> hrefFormat = null)
        {
            if (idFormat == null || textFormat == null || pidFormat == null)
                throw new Exception("格式化参数不能为null");
            List<TreeData> data = new List<TreeData>();
            Dictionary<Guid, TreeData> dic = new Dictionary<Guid, TreeData>();
            //树内嵌算法
            foreach (T t in list)
            {
                dic.Add(idFormat(t), new TreeData { id = idFormat(t), pid = pidFormat(t), text = textFormat(t), iconCls = iconClsFormat == null ? null : iconClsFormat(t), attributes = hrefFormat == null ? null : new TreeAttributes { url = hrefFormat(t) } });
            }
            foreach (T t in list)
            {
                Guid id = idFormat(t);
                object pid = pidFormat(t);
                if (pid == null || !dic.ContainsKey((Guid)pid))
                {
                    data.Add(dic[id]);
                }
                else
                {
                    if (dic[(Guid)pid].children == null)
                        dic[(Guid)pid].children = new List<TreeData>();
                    dic[(Guid)pid].children.Add(dic[id]);
                }
            }
            dic.Clear();
            return new DataResult(data);
        }

        /// <summary>
        /// 下拉控件数据结果
        /// </summary>
        public static DataResult ComboData<T>(this Controller controller, IList<T> list, Func<T, Guid> idFormat, Func<T, string> textFormat, Func<T, string> iconClsFormat = null, Func<T, bool> selectedFormat = null)
        {
            if (idFormat == null || textFormat == null)
                throw new Exception("格式化参数不能为null");
            List<ComboData> data = new List<ComboData>();
            foreach (T t in list)
            {
                data.Add(new ComboData { id = idFormat(t), text = textFormat(t), iconCls = iconClsFormat == null ? null : iconClsFormat(t), selected = selectedFormat == null ? false : selectedFormat(t) });
            }
            return new DataResult(data);
        }

        /// <summary>
        /// 工具栏数据结果
        /// </summary>
        public static DataResult ToolBarData<T>(this Controller controller, IList<T> list, Func<T, string> textFormat, Func<T, string> iconClsFormat = null, Func<T, string> handlerFormat = null, Func<T, bool> plainFormat = null)
        {
            if (textFormat == null)
                throw new Exception("格式化参数不能为null");
            List<ToolBarData> data = new List<ToolBarData>();
            foreach (T t in list)
            {
                data.Add(new ToolBarData { text = textFormat(t), iconCls = iconClsFormat == null ? null : iconClsFormat(t), handler = handlerFormat == null ? null : handlerFormat(t), plain = plainFormat == null ? true : plainFormat(t) });
            }
            return new DataResult(data);
        }

        /// <summary>
        /// 成功或失败的消息数据
        /// </summary>
        public static DataResult MessageData(this Controller controller, bool result, string message)
        {
            MessageData data = new MessageData { result = result, message = message };
            return new DataResult(data);
        }
    }
}
