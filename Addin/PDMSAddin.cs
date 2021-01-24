using Aveva.ApplicationFramework; // 封装插件发布、程序设置等类
using Aveva.ApplicationFramework.Presentation;
using CMD = Aveva.Pdms.Utilities.CommandLine.Command; // 封装PDMS界面相关类

namespace PDMSAddin
{
    public class PDMSAddin : IAddin // 任何PDMS插件都必须实现IAddin接口
    {
        public string Description => "PDMSAddin";
        public string Name => "PDMSAddin";

        public void Start(ServiceManager serviceManager)
        {
            #region 设置命令行快捷键
            CMD.CreateCommand("$S cls=alpha request clear").RunInPdms(); // 清空命令行
            CMD.CreateCommand("$S qk=rem all").RunInPdms(); // 清空模型
            CMD.CreateCommand("$S c=mtoc dotd").RunInPdms(); // 不出料
            CMD.CreateCommand("$S sw=conn pt to last mem").RunInPdms(); // 收头
            CMD.CreateCommand("$S st=conn ph to first mem").RunInPdms(); // 收尾

            #endregion

            // 获取WINDOWS服务
            var windowManager = (WindowManager)serviceManager.GetService(typeof(WindowManager));
            // 参数1和command的Key保持一致，参数2和Title保持一致
            var dockWindow = windowManager.CreateDockedWindow("Lim42.PDMSAddin", "PDMS辅助工具(Lim42)", 
                new PdmsControl(), DockedPosition.Right);
            dockWindow.SaveLayout = true;

            // 获取Command服务
            var commandManager = (CommandManager)serviceManager.GetService(typeof(CommandManager));
            // 添加自定义的Command到服务中
            commandManager.Commands.Add(new PdmsCommand(dockWindow));
        }
        public void Stop ()
        {
        }
    }
}
