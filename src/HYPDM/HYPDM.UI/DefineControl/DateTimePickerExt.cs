using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;

namespace HYPDM.WinUI.DefineControl
{
    class DateTimePickerExt: DateTimePicker
    {
        public DateTimePickerExt()
            : base()
        {
            SetNullText();
        }

        /// <summary> 
        /// 值是否已改变 
        /// </summary> 
        private bool IsValueChanged = false;
        /// <summary> 
        /// 原格式字符串 
        /// </summary> 
        private string _formatString = "yyyy-MM-dd";

        /// <summary> 
        /// 原格式 
        /// </summary> 
        private DateTimePickerFormat _originalFormat = DateTimePickerFormat.Custom;

        /// <summary> 
        /// 可空日期 
        /// </summary> 
        private DateTime? valueX = null;

        /// <summary> 
        /// 日期(值改变前为null) 
        /// </summary> 
        [Browsable(true), Category("扩展属性"), Description("可空日期(值改变前为null)")]
        public DateTime? ValueX
        {
            get { return valueX; }
            set
            {
                if (value == null)
                {
                    valueX = value;
                    SetNullText();
                }
                else
                {
                    this.CustomFormat = FormatString;
                    this.Value = value.Value;
                    valueX = value;
                }
            }
        }
        /// <summary> 
        /// 格式字符串 
        /// </summary> 
        [Browsable(true), Category("扩展属性"), Description("格式字符串")]
        public string FormatString
        {
            get { return _formatString; }
            set { _formatString = value; }
        }
        /// <summary> 
        /// 设置格式 
        /// </summary> 
        [Browsable(true), Category("扩展属性"), Description("设置格式")]
        public DateTimePickerFormat OriginalFormat
        {
            get { return _originalFormat; }
            set { _originalFormat = value; }
        }
        /// <summary> 
        /// 开始时间(该日期的00:00:00) 
        /// </summary> 
        [Browsable(true), Category("扩展属性"), Description("开始时间(为当前选中日期的00:00:00)")]
        public DateTime? BeginTime
        {
            get
            {
                if (ValueX.HasValue)
                    return DateTime.Parse(ValueX.Value.ToString("yyyy-MM-dd 00:00:00"));
                else
                    return null;
            }
        }
        /// <summary> 
        /// 结束时间(该日期的23:59:59) 
        /// </summary> 
        [Browsable(true), Category("扩展属性"), Description("结束时间(为当前选中日期的23:59:59)")]
        public DateTime? EndTime
        {
            get
            {
                if (ValueX.HasValue)
                {
                    return DateTime.Parse(ValueX.Value.ToString("yyyy-MM-dd 23:59:59"));
                }
                else
                    return null;
            }
        }

        /// <summary> 
        /// 设置空字符显示 
        /// </summary> 
        private void SetNullText()
        {
            this.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.CustomFormat = " ";
        }

        protected override void OnCloseUp(EventArgs eventargs)
        {
            if (IsValueChanged)
            {
                this.Format = _originalFormat;
                this.CustomFormat = _formatString;
                valueX = this.Value;
                IsValueChanged = false;
            }
            base.OnCloseUp(eventargs);
        }

        protected override void OnValueChanged(EventArgs eventargs)
        {
            this.IsValueChanged = true;
            base.OnValueChanged(eventargs);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            //删除时间   www.2cto.com
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
            {
                this.ValueX = null;
                this.CustomFormat = " ";
            }
            base.OnKeyDown(e);
        }
    }
}
