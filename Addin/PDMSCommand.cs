using Aveva.ApplicationFramework.Presentation;
using System;

namespace PDMSAddin
{
    internal class PdmsCommand:Command
    {
        private readonly DockedWindow _window;

        // 带参实例化类
        public PdmsCommand(DockedWindow window)
        {
            // 定义command的Key，这个key是要在PDMS中显示的，命名规则应该为公司名+功能名
            Key = "Lim42.PDMSAddin";
            // Save the docked window
            _window = window;
            // 创建窗体关闭的事件委托
            _window.Closed += _window_Closed;
            // 创建窗体加载事件的委托
            WindowManager.Instance.WindowLayoutLoaded += Instance_WindowLayoutLoaded;
        }

        // 设置默认窗体不打开
        private void Instance_WindowLayoutLoaded(object sender, EventArgs e)
        {
            _window.Visible = false;
            Checked = _window.Visible;
        }

        private void _window_Closed(object sender, EventArgs e)
        {
            Checked = false;
        }

        public override void Execute()
        {
            if (_window.Visible)
            {
                _window.Hide();
            }
            else
            {
                _window.Show();
            }
        }
    }
}