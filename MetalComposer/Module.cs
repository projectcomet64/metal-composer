using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M64MM.Additions;
using M64MM.Utils;
namespace MetalComposer
{
    public class Module : IModule
    {

        ComposerForm form;

        public string SafeName => "CoMposer";

        public string Description => "EXPERIMENTAL FEATURE - Modify some aspects of Mario's animation!";

        public void Close(EventArgs e)
        {

        }

        public List<ToolCommand> GetCommands()
        {
            List<ToolCommand> retList = new List<ToolCommand>();
            ToolCommand showForm = new ToolCommand("Show Composer Form");
            showForm.Summoned += (a, b) => form.Show();
            retList.Add(showForm);
            return retList;
        }

        public void Initialize()
        {
            form = new ComposerForm();
        }

        public void OnBaseAddressFound()
        {

        }

        public void OnBaseAddressZero()
        {

        }

        public void Reset()
        {

        }

        public void Update()
        {
            if (Core.CurrentLevelID > 3)
            {
                ComposerBase.UpdateCoreAddress();
                form.UpdateCoreAddressText(ComposerBase.CoreAddress);
            }
        }
    }
}
