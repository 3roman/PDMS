using Aveva.ApplicationFramework;
using Aveva.ApplicationFramework.Presentation;
using pdmsCommand = Aveva.Pdms.Utilities.CommandLine.Command;

namespace PdmsAddin
{
    public class PdmsAddin : IAddin
    {
        public string Description => "PDMS辅助工具 Lim42";

        public string Name => "PDMS辅助工具 Lim42";

        public void Start(ServiceManager serviceManager)
        {
            #region 设置命令行快捷键
            pdmsCommand.CreateCommand("$S cls=alpha request clear").RunInPdms();
            pdmsCommand.CreateCommand("$S sw=conn pt to last mem").RunInPdms();
            pdmsCommand.CreateCommand("$S st=conn ph to first mem").RunInPdms();


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
